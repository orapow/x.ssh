using NShell.Entiry;
using NShell.Service;
using NShell.UserContorl;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NShell
{
    public partial class GroupPanel : UserControl
    {
        public delegate void TabEmptyHandler();
        public event TabEmptyHandler TabEmpty;

        public delegate void SetFocusHandler(GroupPanel p);
        public event SetFocusHandler OnFocused;

        public string Id { get; private set; }

        /// <summary>
        /// 1、tab
        /// 2、split
        /// </summary>
        public int Model { get; private set; } = 1;

        DragTo dragTo;
        SplitPanel spanel;
        TabControl tpanel;

        int level = 0;

        public GroupPanel() : this(0) { }

        public GroupPanel(int l = 0)
        {
            InitializeComponent();
            Id = Guid.NewGuid().ToString();
            AllowDrop = true;
            dragTo = DragTo.None;

            DoubleBuffered = true;
            SetStyle(ControlStyles.DoubleBuffer | ControlStyles.OptimizedDoubleBuffer | ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint, true);
            UpdateStyles();

            tpanel = new TabControl() { Dock = DockStyle.Fill };
            tpanel.MouseDown += tpanel_MouseDown;
            tpanel.MouseUp += tpanel_MouseUp;
            tpanel.Enter += Tpanel_Enter;
            Controls.Add(tpanel);

            level = l;
        }

        public Layout GetLayout()
        {
            var lay = new Layout();
            if (Model == 1)
            {
                lay.Hosts = GetHosts();
            }
            else if (Model == 2)
            {
                lay.Node = spanel.GetNode();
            }
            return lay;
        }

        public void SetLayout(Layout lay)
        {
            if (lay.Node != null)
            {
                InitSpanel();
                spanel.SetNode(lay.Node);
            }
            else if (lay.Hosts != null)
            {
                SetHosts(lay.Hosts);
            }
        }

        public void SetTabs(TabPage[] tabs)
        {
            tpanel.TabPages.Clear();
            foreach (var t in tabs)
            {
                var se = t.Controls[0] as Session;
                se.ClearBreakedEvents();
                se.Breaked += Session_Breaked;
            }
            tpanel.TabPages.AddRange(tabs);
            tpanel.Visible = true;
        }

        public void DropDone()
        {
            checkEmpty();
        }

        public void NewTab(HostInfo h)
        {
            if (Model == 2)
            {
                spanel.NewSession(h);
                return;
            }

            var se = new Session(h);

            var tab = new TabPage() { Text = h.Name, Name = h.Name };
            tab.Controls.Add(se);

            se.Breaked += Session_Breaked;

            tpanel.TabPages.Add(tab);
            se.Open();
            se.ShowPutty();

            tpanel.SelectedTab = tab;
            //session = se;
        }

        protected override void OnDragOver(DragEventArgs drgevent)
        {
            var data = drgevent.Data.GetData(typeof(DragData)) as DragData;
            if (data == null)
            {
                return;
            }

            drgevent.Effect = DragDropEffects.Move;

            var wsd = Width / 3;
            var hsd = Height / 3;

            var pt = PointToClient(new Point(drgevent.X, drgevent.Y));

            if (pt.X > wsd && pt.X < Width - wsd && pt.Y > hsd && pt.Y < Height - hsd)
            {
                if (data.Id == Id) return;
                tp_mask.Width = Width;
                tp_mask.Height = Height;
                tp_mask.Left = 0;
                tp_mask.Top = 0;
                tp_mask.Visible = true;
                dragTo = DragTo.Center;
            }
            else if (pt.X < wsd || pt.Y < hsd)
            {
                if (pt.X < wsd || pt.X < pt.Y)
                {
                    tp_mask.Width = Width / 2;
                    tp_mask.Height = Height;
                    dragTo = DragTo.Left;
                }
                else
                {
                    tp_mask.Width = Width;
                    tp_mask.Height = Height / 2;
                    dragTo = DragTo.Top;
                }
                tp_mask.Left = 0;
                tp_mask.Top = 0;
                tp_mask.Visible = true;
            }
            else if (pt.X > Width - wsd || pt.Y > Height - hsd)
            {
                if (pt.X > Width - wsd || pt.X > pt.Y)
                {
                    tp_mask.Width = Width / 2;
                    tp_mask.Height = Height;
                    tp_mask.Left = Width - tp_mask.Width;
                    tp_mask.Top = 0;
                    dragTo = DragTo.Right;
                }
                else
                {
                    tp_mask.Width = Width;
                    tp_mask.Height = Height / 2;
                    tp_mask.Top = Height - tp_mask.Height;
                    tp_mask.Left = 0;
                    dragTo = DragTo.Bottom;
                }
                tp_mask.Visible = true;
            }
            else
            {
                tp_mask.Visible = false;
                dragTo = DragTo.None;
            }
        }

        protected override void OnDragEnter(DragEventArgs drgevent)
        {
            base.OnDragEnter(drgevent);
            drgevent.Effect = DragDropEffects.Move;
        }

        protected override void OnDragLeave(EventArgs e)
        {
            tp_mask.Visible = false;
            dragTo = DragTo.None;
        }

        protected override void OnDragDrop(DragEventArgs drgevent)
        {
            tp_mask.Visible = false;

            if (dragTo == DragTo.None) return;

            var data = drgevent.Data.GetData(typeof(DragData)) as DragData;
            if (data == null) return;

            if (tpanel.TabPages.Count == 1 && data.Id == Id) return;

            if (dragTo == DragTo.Center)
            {
                if (data.Id == Id) return;
                tpanel.TabPages.Add(data.Tab);

                tpanel.Visible = true;
                if (spanel != null)
                    spanel.Visible = false;
            }
            else
            {
                if (tpanel.TabPages.Count == 1 && data.Id == Id) return;

                var tps1 = new List<TabPage>();
                var tps2 = new List<TabPage>();

                tps1.Add(data.Tab);
                tpanel.TabPages.Remove(data.Tab);
                tps2.AddRange(tpanel.TabPages.Cast<TabPage>().ToArray());

                InitSpanel();

                if (dragTo == DragTo.Top || dragTo == DragTo.Left)
                {
                    spanel.SetTabs(tps1.ToArray(), tps2.ToArray());
                }
                else
                {
                    spanel.SetTabs(tps2.ToArray(), tps1.ToArray());
                }

                if (dragTo == DragTo.Top || dragTo == DragTo.Bottom)
                {
                    spanel.SetDirection(Orientation.Horizontal);
                }
                else
                {
                    spanel.SetDirection(Orientation.Vertical);
                }

                dragTo = DragTo.None;

                tpanel.Visible = false;
                spanel.Visible = true;
            }

            data.Source.DropDone();
        }

        private List<HostInfo> GetHosts()
        {
            var hs = new List<HostInfo>();
            foreach (TabPage t in tpanel.TabPages)
            {
                var h = (t.Controls[0] as Session).host;
                if (h == null) continue;
                hs.Add(h);
            }
            return hs;
        }

        private void Session_Breaked(Session s)
        {
            try
            {
                Invoke((Action)(() =>
                {
                    (s.Parent.Parent as TabControl).TabPages.Remove(s.Parent as TabPage);
                    checkEmpty();
                }));
            }
            catch { }
        }

        private void SetHosts(List<HostInfo> hts)
        {
            tpanel.TabPages.Clear();
            foreach (var h in hts) NewTab(h);
        }

        private void checkEmpty()
        {
            if (tpanel.TabPages.Count == 0) TabEmpty?.Invoke();
        }

        private void InitSpanel()
        {
            if (spanel != null) return;
            spanel = new SplitPanel(level + 1) { Dock = DockStyle.Fill };
            spanel.SPanelEmpty += Spanel_PanelEmpty;
            Controls.Add(spanel);
            Model = 2;
        }

        private void Spanel_PanelEmpty(GroupPanel p)
        {
            if (p.Model == 1)
            {
                tpanel.TabPages.Clear();
                tpanel.TabPages.AddRange(p.tpanel.TabPages.Cast<TabPage>().ToArray());
                tpanel.Visible = true;
                spanel.Visible = false;
                Model = 1;
            }
            else if (p.Model == 2)
            {
                Controls.Remove(spanel);
                p.spanel.ClearSPanelEmptyEvents();
                spanel = p.spanel;
                spanel.SPanelEmpty += Spanel_PanelEmpty;
                Controls.Add(p.spanel);
                tpanel.Visible = false;
                spanel.Visible = true;
                Model = 2;
            }
        }

        private void tpanel_MouseUp(object sender, MouseEventArgs e)
        {
            tpanel.SelectedTab.Tag = "";
            EventBus.Emit("session.drag.end");
        }

        private void tpanel_MouseDown(object sender, MouseEventArgs e)
        {
            var tn = tpanel.SelectedTab;
            var id = tn.Tag = Guid.NewGuid().ToString();

            Task.Factory.StartNew(() =>
            {
                Thread.Sleep(300);
                Invoke((Action)(() =>
                {
                    var stn = tpanel.SelectedTab.Tag.ToString();
                    if (stn != id + "") return;
                    EventBus.Emit("session.drag.start");
                    tpanel.SelectedTab.DoDragDrop(new DragData() { Tab = tpanel.SelectedTab, Id = Id, Source = this }, DragDropEffects.Move);
                }));
            });
        }

        private void Tpanel_Enter(object sender, EventArgs e)
        {
            OnFocused?.Invoke(this);
        }
    }

    /// <summary>
    /// 拖动到
    /// </summary>
    enum DragTo
    {
        None,
        Top,
        Left,
        Right,
        Bottom,
        Center
    }

    /// <summary>
    /// 拖动数据
    /// </summary>
    class DragData
    {
        /// <summary>
        /// 选项卡
        /// </summary>
        public TabPage Tab { get; set; }
        /// <summary>
        /// GroupId
        /// </summary>
        public string Id { get; set; }
        /// <summary>
        /// 来源
        /// </summary>
        public GroupPanel Source { get; set; }
    }
}

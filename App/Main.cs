using Newtonsoft.Json;
using NShell.Entiry;
using NShell.Service;
using NShell.Tools;
using NShell.UserContorl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;

namespace NShell
{
    public partial class Main : Form
    {
        IntPtr win = IntPtr.Zero;

        public Main()
        {
            InitializeComponent();
            loadTree();
        }

        protected override void OnDeactivate(EventArgs e)
        {
            base.OnDeactivate(e);
            //this.TopLevel = false;
            this.TopMost = false;
        }
        protected override void OnActivated(EventArgs e)
        {
            base.OnActivated(e);
            //this.TopLevel = true;
            this.TopMost = true;
        }
        protected override void OnClosing(CancelEventArgs e)
        {
            killAll();
            base.OnClosing(e);
        }

        void loadTree()
        {
            var tns = Hosts.LoadHosts();
            if (tns == null) return;
            transNode(tns, tv_ses.Nodes);

            void transNode(List<Tn> _tns, TreeNodeCollection tnc)
            {
                foreach (var t in _tns)
                {
                    NTreeNode tn;
                    if (t.Type == TnType.Group)
                        tn = new NTreeNode(t.Name);
                    else
                        tn = new NTreeNode(t.Host);
                    tn.Type = t.Type;
                    transNode(t.Child, tn.Nodes);
                    tnc.Add(tn);
                    tn.Expand();
                }
            }
        }

        void saveTree()
        {
            var tns = new List<Tn>();
            transNode(tv_ses.Nodes, tns);
            Hosts.SaveHosts(tns);

            void transNode(TreeNodeCollection tnc, List<Tn> _tns)
            {
                foreach (NTreeNode p in tnc)
                {
                    var tn = new Tn()
                    {
                        Name = p.Text,
                        Host = p.Host,
                        Type = p.Type
                    };
                    transNode(p.Nodes, tn.Child);
                    _tns.Add(tn);
                }
            }
        }

        private void killAll()
        {
            EventBus.Emit("app.close");
        }

        private void tsmi_new_se_Click(object sender, EventArgs e)
        {
            var he = new Host();
            if (he.ShowDialog() != DialogResult.OK)
                return;

            var newNode = new NTreeNode(he.host) { Type = TnType.Host };

            var selectNode = tv_ses.SelectedNode as NTreeNode;
            var nds = selectNode == null ? tv_ses.Nodes : selectNode.Nodes;
            nds.Add(newNode);

            selectNode?.Expand();

            saveTree();
        }

        private void tsb_new_sdir_Click(object sender, EventArgs e)
        {
            var newNode = new NTreeNode("会话组") { Type = TnType.Group };
            var selectNode = tv_ses.SelectedNode as NTreeNode;

            var nds = selectNode == null ? tv_ses.Nodes : selectNode.Nodes;
            nds.Add(newNode);

            selectNode?.Expand();
            saveTree();
        }

        private void tv_ses_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            tv_ses.SelectedNode = e.Node;
        }

        private void tsmi_tree_del_Click(object sender, EventArgs e)
        {
            tv_ses.SelectedNode.Remove();
            saveTree();
        }

        private void tsmi_tree_edit_Click(object sender, EventArgs e)
        {
            var tn = tv_ses.SelectedNode as NTreeNode;
            if (tn == null) return;

            if (tn.Type == TnType.Host)
            {
                var he = new Host();
                he.SetHost(tn.Host);
                if (he.ShowDialog() != DialogResult.OK)
                    return;
                tn.Host = he.host;
                tn.Text = he.host.Name;
            }
            else
            {
                tn.BeginEdit();
            }

            saveTree();
        }

        private void tv_ses_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            var tn = e.Node as NTreeNode;
            if (tn.Host == null) return;
            se_panel.NewTab(tn.Host);
        }

        private void tv_ses_AfterLabelEdit(object sender, NodeLabelEditEventArgs e)
        {
            if (e.Label == null) return;
            e.Node.Text = e.Label;
            saveTree();
        }

        private void tsmi_tree_copy_Click(object sender, EventArgs e)
        {
            var selectNode = tv_ses.SelectedNode as NTreeNode;
            if (selectNode == null) return;

            if (selectNode.Type != TnType.Host) return;

            var he = new Host();
            he.SetHost(selectNode.Host);
            if (he.ShowDialog() != DialogResult.OK)
                return;

            var newNode = new NTreeNode(he.host) { Type = TnType.Host };

            var nds = selectNode == null ? tv_ses.Nodes : selectNode.Parent.Nodes;
            nds.Add(newNode);

            selectNode?.Expand();

            saveTree();
        }

        private void tsmi_new_dir_root_Click(object sender, EventArgs e)
        {
            tv_ses.SelectedNode = null;
            //tsb_group_Click(sender, e);
        }

        private void tsb_trans_Click(object sender, EventArgs e)
        {
            new Trans().Show();
        }

        private void tm_showtime_Tick(object sender, EventArgs e)
        {
            tssl_time.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            var w = WinApi.GetForegroundWindow();
            if (win != w)
            {
                EventBus.Emit("window.active", new object[] { w });
            }
            win = w;
        }

        private void tsb_save_Click(object sender, EventArgs e)
        {
            var sfd = new SaveFileDialog();
            sfd.Filter = "布局文件|*.lay";
            if (sfd.ShowDialog() != DialogResult.OK) return;
            var lay = se_panel.GetLayout();
            File.WriteAllText(sfd.FileName, Secret.RC4Encrypt(JsonConvert.SerializeObject(lay)));
        }

        private void tsb_load_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog();
            ofd.Filter = "布局文件|*.lay";
            if (ofd.ShowDialog() != DialogResult.OK) return;
            killAll();
            var da = File.ReadAllText(ofd.FileName);
            var lay = JsonConvert.DeserializeObject<Layout>(Secret.RC4Decrypt(da));
            se_panel.SetLayout(lay);
        }
    }
}

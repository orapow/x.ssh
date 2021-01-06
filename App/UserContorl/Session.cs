using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Runtime.ConstrainedExecution;
using NShell.Service;

namespace NShell
{
    public partial class Session : UserControl, IDisposable
    {
        public delegate void BreakedHandler(Session se);
        public event BreakedHandler Breaked;

        public HostInfo host { get; private set; }

        Process p;
        bool inited = false;

        public Session(HostInfo _host)
        {
            p = new Process();
            InitializeComponent();

            host = _host;

            Dock = DockStyle.Fill;
            DoubleBuffered = true;
            SetStyle(ControlStyles.DoubleBuffer | ControlStyles.OptimizedDoubleBuffer | ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint, true);
            UpdateStyles();

            EventBus.On += EventBus_On;
        }

        public void ClearBreakedEvents()
        {
            foreach (var d in Breaked.GetInvocationList())
            {
                Breaked -= d as BreakedHandler;
            }
        }

        private void EventBus_On(string name, object[] parms)
        {
            switch (name)
            {
                case "session.drag.start":
                    this.ShowThumbNail();
                    break;
                case "session.drag.end":
                    this.ShowPutty();
                    break;
                case "app.close":
                    Quit();
                    break;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Open()
        {
            p.StartInfo.FileName = Application.StartupPath + "\\putty\\putty.exe";
            p.StartInfo.Arguments = $"-pw {Secret.RC4Decrypt(host.Pwd).Replace("\"", "\\\"")} -l {host.Uin} -P {host.Port} {host.Ipa}";
            p.StartInfo.WindowStyle = ProcessWindowStyle.Minimized;
            p.EnableRaisingEvents = true;
            p.Exited += P_Exited;
            p.Start();

            while (p.MainWindowHandle.ToInt32() == 0)
            {
                System.Threading.Thread.Sleep(100);
            }

            WinApi.SetParent(p.MainWindowHandle, pn_proccess.Handle);
            WinApi.ShowWindow(p.MainWindowHandle, 3);
            WinApi.HideScroll(p.MainWindowHandle);
            WinApi.HideTitle(p.MainWindowHandle);
            WinApi.SetWindowPos(p.MainWindowHandle, IntPtr.Zero, 0, 0, Width, Height, 8);

            inited = true;
        }

        /// <summary>
        /// 
        /// </summary>
        public void Quit()
        {
            try
            {
                p.Kill();
            }
            catch { }
        }

        /// <summary>
        /// 
        /// </summary>
        public void ShowThumbNail()
        {
            pb_thumb.Visible = true;
            pn_proccess.Visible = false;
            tm_upthumb.Enabled = true;
            pb_Op.Visible = false;
        }

        /// <summary>
        /// 
        /// </summary>
        public void ShowPutty()
        {
            pb_thumb.Visible = false;
            pn_proccess.Visible = true;
            tm_upthumb.Enabled = false;
            pb_Op.Visible = true;
        }

        private void P_Exited(object sender, EventArgs e)
        {
            tm_upthumb.Enabled = false;
            Breaked?.Invoke(this);
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            if (!inited) return;
            WinApi.MoveWindow(p.MainWindowHandle, 0, 0, this.Bounds.Width, this.Bounds.Height, true);
        }

        private void tm_upthumb_Tick(object sender, EventArgs e)
        {
            if (!inited) return;
            pb_thumb.Image = WinApi.GetWindowCapture(p.MainWindowHandle);
        }

        private void pb_thumb_Click(object sender, EventArgs e)
        {
            ShowPutty();
        }

        private void 关闭会话ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Quit();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
        }

        private void Tm_FormClosed(object sender, FormClosedEventArgs e)
        {
            WinApi.SetParent(p.MainWindowHandle, pn_proccess.Handle);
            WinApi.ShowWindow(p.MainWindowHandle, 3);
            WinApi.HideScroll(p.MainWindowHandle);
            WinApi.HideTitle(p.MainWindowHandle);
            WinApi.SetWindowPos(p.MainWindowHandle, IntPtr.Zero, 0, 0, Width, Height, 8);
        }

        private void tsmi_newwin_Click(object sender, EventArgs e)
        {
            var tm = new Terminal();
            tm.FormClosed += Tm_FormClosed;
            tm.Resize += Tm_Resize;
            tm.Show();
            WinApi.SetParent(p.MainWindowHandle, tm.Handle);
            WinApi.ShowWindow(p.MainWindowHandle, 3);
            WinApi.HideScroll(p.MainWindowHandle);
            WinApi.HideTitle(p.MainWindowHandle);
            WinApi.MoveWindow(p.MainWindowHandle, 0, 0, tm.Width - 16, tm.Height - 39, true);
        }

        private void Tm_Resize(object sender, EventArgs e)
        {
            var tm = sender as Terminal;
            WinApi.MoveWindow(p.MainWindowHandle, 0, 0, tm.Width - 16, tm.Height - 39, true);
        }

        private void pb_Op_DoubleClick(object sender, EventArgs e)
        {
            tsmi_newwin_Click(sender, e);
        }

        private void tsmi_upload_Click(object sender, EventArgs e)
        {
            p.StandardInput.WriteLine("pwd" + Environment.NewLine);
        }
    }
}

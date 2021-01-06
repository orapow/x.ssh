using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NShell
{
    public partial class Host : Form
    {
        public HostInfo host { get; private set; }

        public Host()
        {
            InitializeComponent();
        }

        public void SetHost(HostInfo _host)
        {
            host = _host;
            tb_title.Text = _host.Name;
            tb_cert.Text = _host.Cert;
            tb_ip.Text = _host.Ipa;
            tb_pt.Text = _host.Port;
            tb_pwd.Text = Secret.RC4Decrypt(_host.Pwd);
            tb_uin.Text = _host.Uin;
            tb_cert.Text = _host.Cert;
        }

        private void bt_Ok_Click(object sender, EventArgs e)
        {
            host = new HostInfo()
            {
                Name = tb_title.Text,
                Ipa = tb_ip.Text,
                Port = tb_pt.Text,
                Uin = tb_uin.Text,
                Pwd = Secret.RC4Encrypt(tb_pwd.Text),
                Cert = tb_cert.Text
            };
            DialogResult = DialogResult.OK;
            Close();
        }

        private void bt_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

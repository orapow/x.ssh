using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NShell.UserContorl
{
    public class NTreeNode : TreeNode
    {
        public TnType Type { get; set; }
        public HostInfo Host { get; set; }

        public NTreeNode(string text)
        {
            Text = text;
        }

        public NTreeNode(HostInfo _host)
        {
            Host = _host;
            Text = _host.Name;
        }
    }
}

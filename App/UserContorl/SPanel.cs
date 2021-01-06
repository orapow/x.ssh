using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using NShell.Entiry;
using NShell.Service;

namespace NShell.UserContorl
{
    public partial class SplitPanel : UserControl
    {
        public delegate void PanelEmptyHandler(GroupPanel p);
        public event PanelEmptyHandler SPanelEmpty;

        GroupPanel cPanel;
        GroupPanel lPanel;
        GroupPanel rPanel;

        public SplitPanel(int l)
        {
            InitializeComponent();

            lPanel = new GroupPanel(l) { Dock = DockStyle.Fill };
            rPanel = new GroupPanel(l) { Dock = DockStyle.Fill };

            lPanel.TabEmpty += lPanel_TabEmpty;
            lPanel.OnFocused += GPanel_OnFocused;

            rPanel.TabEmpty += rPanel_TabEmpty;
            rPanel.OnFocused += GPanel_OnFocused;

            cPanel = lPanel;

            DoubleBuffered = true;
            SetStyle(ControlStyles.DoubleBuffer | ControlStyles.OptimizedDoubleBuffer | ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint, true);
            UpdateStyles();

            scPanel.Panel1.Controls.Add(lPanel);
            scPanel.Panel2.Controls.Add(rPanel);

            void lPanel_TabEmpty()
            {
                SPanelEmpty?.Invoke(rPanel);
            }

            void rPanel_TabEmpty()
            {
                SPanelEmpty?.Invoke(lPanel);
            }

            void GPanel_OnFocused(GroupPanel gp)
            {
                cPanel = gp;
            }
        }

        public void ClearSPanelEmptyEvents()
        {
            var evs = SPanelEmpty.GetInvocationList();
            foreach (var e in evs)
            {
                SPanelEmpty -= e as PanelEmptyHandler;
            }
        }

        public void SetNode(Layout.SpNode node)
        {
            if (node == null) return;
            SetDirection(node.Orientation == 1 ? Orientation.Horizontal : Orientation.Vertical,
                        (int)(node.SplitDist * (node.Orientation == 1 ? scPanel.Height : scPanel.Width)));
            if (node.Left != null)
            {
                lPanel.SetLayout(node.Left);
                scPanel.Panel1Collapsed = false;
            }
            if (node.Right != null)
            {
                rPanel.SetLayout(node.Right);
                scPanel.Panel2Collapsed = false;
            }
        }

        public Layout.SpNode GetNode()
        {
            var node = new Layout.SpNode();
            if (scPanel.Panel1Collapsed == false)
            {
                node.Left = lPanel.GetLayout();
            }
            if (scPanel.Panel2Collapsed == false)
            {
                node.Right = rPanel.GetLayout();
            }
            node.Orientation = scPanel.Orientation == Orientation.Horizontal ? 1 : 2;
            node.SplitDist = scPanel.SplitterDistance / (decimal)(scPanel.Orientation == Orientation.Horizontal ? scPanel.Height : scPanel.Width);
            return node;
        }

        public void NewSession(HostInfo h)
        {
            cPanel.NewTab(h);
        }

        public void SetTabs(TabPage[] leftTabs, TabPage[] rightTabs)
        {
            if (leftTabs.Length > 0)
            {
                lPanel.SetTabs(leftTabs);
                scPanel.Panel1Collapsed = false;
            }

            if (rightTabs.Length > 0)
            {
                rPanel.SetTabs(rightTabs);
                scPanel.Panel2Collapsed = false;
            }
        }

        public void SetDirection(Orientation orientation, int splitDist = 0)
        {
            scPanel.Orientation = orientation;
            if (orientation == Orientation.Horizontal)
                scPanel.SplitterDistance = splitDist == 0 ? Height / 2 : splitDist;

            else if (orientation == Orientation.Vertical)
                scPanel.SplitterDistance = splitDist == 0 ? Width / 2 : splitDist;
        }

        private void scPanel_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            SetDirection(scPanel.Orientation);
        }
    }
}

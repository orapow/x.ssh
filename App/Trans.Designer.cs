namespace NShell
{
    partial class Trans
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.sc_panel = new System.Windows.Forms.SplitContainer();
            this.cms_file = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmi_trans = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_pkg = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmi_copy = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_cut = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_parse = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmi_del = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_rename = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.新建文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.新建文件夹ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmi_refresh = new System.Windows.Forms.ToolStripMenuItem();
            this.sbar = new System.Windows.Forms.StatusStrip();
            this.tssl_info = new System.Windows.Forms.ToolStripStatusLabel();
            this.fb_left = new NShell.UserContorl.FileBrowser();
            this.fb_right = new NShell.UserContorl.FileBrowser();
            ((System.ComponentModel.ISupportInitialize)(this.sc_panel)).BeginInit();
            this.sc_panel.Panel1.SuspendLayout();
            this.sc_panel.Panel2.SuspendLayout();
            this.sc_panel.SuspendLayout();
            this.cms_file.SuspendLayout();
            this.sbar.SuspendLayout();
            this.SuspendLayout();
            // 
            // sc_panel
            // 
            this.sc_panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sc_panel.Location = new System.Drawing.Point(0, 0);
            this.sc_panel.Name = "sc_panel";
            // 
            // sc_panel.Panel1
            // 
            this.sc_panel.Panel1.Controls.Add(this.fb_left);
            this.sc_panel.Panel1.Padding = new System.Windows.Forms.Padding(5, 5, 2, 2);
            // 
            // sc_panel.Panel2
            // 
            this.sc_panel.Panel2.Controls.Add(this.fb_right);
            this.sc_panel.Panel2.Padding = new System.Windows.Forms.Padding(2, 5, 5, 2);
            this.sc_panel.Size = new System.Drawing.Size(784, 536);
            this.sc_panel.SplitterDistance = 392;
            this.sc_panel.SplitterWidth = 2;
            this.sc_panel.TabIndex = 0;
            // 
            // cms_file
            // 
            this.cms_file.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_trans,
            this.tsmi_pkg,
            this.toolStripMenuItem1,
            this.tsmi_copy,
            this.tsmi_cut,
            this.tsmi_parse,
            this.toolStripMenuItem3,
            this.tsmi_del,
            this.tsmi_rename,
            this.toolStripMenuItem2,
            this.新建文件ToolStripMenuItem,
            this.新建文件夹ToolStripMenuItem,
            this.toolStripMenuItem4,
            this.tsmi_refresh});
            this.cms_file.Name = "cms_file";
            this.cms_file.Size = new System.Drawing.Size(163, 248);
            // 
            // tsmi_trans
            // 
            this.tsmi_trans.Name = "tsmi_trans";
            this.tsmi_trans.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
            this.tsmi_trans.Size = new System.Drawing.Size(162, 22);
            this.tsmi_trans.Text = "传输(&T)";
            this.tsmi_trans.Click += new System.EventHandler(this.tsmi_trans_Click);
            // 
            // tsmi_pkg
            // 
            this.tsmi_pkg.Name = "tsmi_pkg";
            this.tsmi_pkg.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.tsmi_pkg.Size = new System.Drawing.Size(162, 22);
            this.tsmi_pkg.Text = "打包(&P)";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(159, 6);
            // 
            // tsmi_copy
            // 
            this.tsmi_copy.Name = "tsmi_copy";
            this.tsmi_copy.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.tsmi_copy.Size = new System.Drawing.Size(162, 22);
            this.tsmi_copy.Text = "复制(&C)";
            // 
            // tsmi_cut
            // 
            this.tsmi_cut.Name = "tsmi_cut";
            this.tsmi_cut.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.tsmi_cut.Size = new System.Drawing.Size(162, 22);
            this.tsmi_cut.Text = "剪切(&X)";
            // 
            // tsmi_parse
            // 
            this.tsmi_parse.Name = "tsmi_parse";
            this.tsmi_parse.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.tsmi_parse.Size = new System.Drawing.Size(162, 22);
            this.tsmi_parse.Text = "粘贴(&P)";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(159, 6);
            // 
            // tsmi_del
            // 
            this.tsmi_del.Name = "tsmi_del";
            this.tsmi_del.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.tsmi_del.Size = new System.Drawing.Size(162, 22);
            this.tsmi_del.Text = "删除(&D)";
            this.tsmi_del.Click += new System.EventHandler(this.tsmi_del_Click);
            // 
            // tsmi_rename
            // 
            this.tsmi_rename.Name = "tsmi_rename";
            this.tsmi_rename.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.tsmi_rename.Size = new System.Drawing.Size(162, 22);
            this.tsmi_rename.Text = "重命名(&M)";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(159, 6);
            // 
            // 新建文件ToolStripMenuItem
            // 
            this.新建文件ToolStripMenuItem.Name = "新建文件ToolStripMenuItem";
            this.新建文件ToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.新建文件ToolStripMenuItem.Text = "新建文件";
            // 
            // 新建文件夹ToolStripMenuItem
            // 
            this.新建文件夹ToolStripMenuItem.Name = "新建文件夹ToolStripMenuItem";
            this.新建文件夹ToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.新建文件夹ToolStripMenuItem.Text = "新建文件夹";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(159, 6);
            // 
            // tsmi_refresh
            // 
            this.tsmi_refresh.Name = "tsmi_refresh";
            this.tsmi_refresh.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.tsmi_refresh.Size = new System.Drawing.Size(162, 22);
            this.tsmi_refresh.Text = "刷新(&R)";
            this.tsmi_refresh.Click += new System.EventHandler(this.tsmi_refresh_Click);
            // 
            // sbar
            // 
            this.sbar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssl_info});
            this.sbar.Location = new System.Drawing.Point(0, 539);
            this.sbar.Name = "sbar";
            this.sbar.Size = new System.Drawing.Size(784, 22);
            this.sbar.TabIndex = 2;
            this.sbar.Text = "statusStrip1";
            // 
            // tssl_info
            // 
            this.tssl_info.Name = "tssl_info";
            this.tssl_info.Size = new System.Drawing.Size(0, 17);
            // 
            // fb_left
            // 
            this.fb_left.ContextMenuStrip = this.cms_file;
            this.fb_left.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fb_left.Location = new System.Drawing.Point(5, 5);
            this.fb_left.Name = "fb_left";
            this.fb_left.Size = new System.Drawing.Size(385, 529);
            this.fb_left.TabIndex = 1;
            // 
            // fb_right
            // 
            this.fb_right.ContextMenuStrip = this.cms_file;
            this.fb_right.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fb_right.Location = new System.Drawing.Point(2, 5);
            this.fb_right.Name = "fb_right";
            this.fb_right.Size = new System.Drawing.Size(383, 529);
            this.fb_right.TabIndex = 3;
            // 
            // Trans
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.sbar);
            this.Controls.Add(this.sc_panel);
            this.Name = "Trans";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "文件传输";
            this.sc_panel.Panel1.ResumeLayout(false);
            this.sc_panel.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sc_panel)).EndInit();
            this.sc_panel.ResumeLayout(false);
            this.cms_file.ResumeLayout(false);
            this.sbar.ResumeLayout(false);
            this.sbar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer sc_panel;
        private UserContorl.FileBrowser fb_left;
        private UserContorl.FileBrowser fb_right;
        private System.Windows.Forms.ContextMenuStrip cms_file;
        private System.Windows.Forms.ToolStripMenuItem tsmi_trans;
        private System.Windows.Forms.StatusStrip sbar;
        private System.Windows.Forms.ToolStripStatusLabel tssl_info;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tsmi_copy;
        private System.Windows.Forms.ToolStripMenuItem tsmi_cut;
        private System.Windows.Forms.ToolStripMenuItem tsmi_parse;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem tsmi_del;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem 新建文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 新建文件夹ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem tsmi_refresh;
        private System.Windows.Forms.ToolStripMenuItem tsmi_rename;
        private System.Windows.Forms.ToolStripMenuItem tsmi_pkg;
    }
}
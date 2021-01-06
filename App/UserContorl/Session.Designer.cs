namespace NShell
{
    partial class Session
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pn_proccess = new System.Windows.Forms.Panel();
            this.tm_upthumb = new System.Windows.Forms.Timer(this.components);
            this.cm_Menu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmi_repeate = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmi_upload = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_newwin = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmi_extend_h = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_extend_v = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmi_close = new System.Windows.Forms.ToolStripMenuItem();
            this.pb_Op = new System.Windows.Forms.PictureBox();
            this.pb_thumb = new System.Windows.Forms.PictureBox();
            this.cm_Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Op)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_thumb)).BeginInit();
            this.SuspendLayout();
            // 
            // pn_proccess
            // 
            this.pn_proccess.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_proccess.Location = new System.Drawing.Point(0, 0);
            this.pn_proccess.Margin = new System.Windows.Forms.Padding(0);
            this.pn_proccess.Name = "pn_proccess";
            this.pn_proccess.Size = new System.Drawing.Size(180, 180);
            this.pn_proccess.TabIndex = 0;
            // 
            // tm_upthumb
            // 
            this.tm_upthumb.Tick += new System.EventHandler(this.tm_upthumb_Tick);
            // 
            // cm_Menu
            // 
            this.cm_Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_repeate,
            this.toolStripSeparator2,
            this.tsmi_upload,
            this.tsmi_newwin,
            this.toolStripSeparator1,
            this.tsmi_extend_h,
            this.tsmi_extend_v,
            this.toolStripMenuItem1,
            this.tsmi_close});
            this.cm_Menu.Name = "cm_Menu";
            this.cm_Menu.Size = new System.Drawing.Size(181, 176);
            // 
            // tsmi_repeate
            // 
            this.tsmi_repeate.Name = "tsmi_repeate";
            this.tsmi_repeate.Size = new System.Drawing.Size(180, 22);
            this.tsmi_repeate.Text = "重复会话";
            this.tsmi_repeate.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
            // 
            // tsmi_upload
            // 
            this.tsmi_upload.Name = "tsmi_upload";
            this.tsmi_upload.Size = new System.Drawing.Size(180, 22);
            this.tsmi_upload.Text = "上传文件";
            this.tsmi_upload.Click += new System.EventHandler(this.tsmi_upload_Click);
            // 
            // tsmi_newwin
            // 
            this.tsmi_newwin.Name = "tsmi_newwin";
            this.tsmi_newwin.Size = new System.Drawing.Size(180, 22);
            this.tsmi_newwin.Text = "独立窗口";
            this.tsmi_newwin.Click += new System.EventHandler(this.tsmi_newwin_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // tsmi_extend_h
            // 
            this.tsmi_extend_h.Name = "tsmi_extend_h";
            this.tsmi_extend_h.Size = new System.Drawing.Size(180, 22);
            this.tsmi_extend_h.Text = "横向扩展";
            // 
            // tsmi_extend_v
            // 
            this.tsmi_extend_v.Name = "tsmi_extend_v";
            this.tsmi_extend_v.Size = new System.Drawing.Size(180, 22);
            this.tsmi_extend_v.Text = "竖向扩展";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(177, 6);
            // 
            // tsmi_close
            // 
            this.tsmi_close.Name = "tsmi_close";
            this.tsmi_close.Size = new System.Drawing.Size(180, 22);
            this.tsmi_close.Text = "关闭会话";
            this.tsmi_close.Click += new System.EventHandler(this.关闭会话ToolStripMenuItem_Click);
            // 
            // pb_Op
            // 
            this.pb_Op.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pb_Op.ContextMenuStrip = this.cm_Menu;
            this.pb_Op.Location = new System.Drawing.Point(153, 2);
            this.pb_Op.Name = "pb_Op";
            this.pb_Op.Size = new System.Drawing.Size(25, 25);
            this.pb_Op.TabIndex = 2;
            this.pb_Op.TabStop = false;
            this.pb_Op.DoubleClick += new System.EventHandler(this.pb_Op_DoubleClick);
            // 
            // pb_thumb
            // 
            this.pb_thumb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pb_thumb.Location = new System.Drawing.Point(0, 0);
            this.pb_thumb.Margin = new System.Windows.Forms.Padding(0);
            this.pb_thumb.Name = "pb_thumb";
            this.pb_thumb.Size = new System.Drawing.Size(180, 180);
            this.pb_thumb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_thumb.TabIndex = 1;
            this.pb_thumb.TabStop = false;
            this.pb_thumb.Click += new System.EventHandler(this.pb_thumb_Click);
            // 
            // Session
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pb_Op);
            this.Controls.Add(this.pb_thumb);
            this.Controls.Add(this.pn_proccess);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.MinimumSize = new System.Drawing.Size(120, 120);
            this.Name = "Session";
            this.Size = new System.Drawing.Size(180, 180);
            this.cm_Menu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Op)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_thumb)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pn_proccess;
        private System.Windows.Forms.PictureBox pb_thumb;
        private System.Windows.Forms.Timer tm_upthumb;
        private System.Windows.Forms.PictureBox pb_Op;
        private System.Windows.Forms.ContextMenuStrip cm_Menu;
        private System.Windows.Forms.ToolStripMenuItem tsmi_extend_h;
        private System.Windows.Forms.ToolStripMenuItem tsmi_extend_v;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tsmi_close;
        private System.Windows.Forms.ToolStripMenuItem tsmi_repeate;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem tsmi_newwin;
        private System.Windows.Forms.ToolStripMenuItem tsmi_upload;
    }
}

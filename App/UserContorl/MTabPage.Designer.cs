namespace NShell.UserContorl
{
    partial class MTabPage
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
            this.pb_thumb = new System.Windows.Forms.PictureBox();
            this.pn_proccess = new System.Windows.Forms.Panel();
            this.tm_upthumb = new System.Windows.Forms.Timer(this.components);
            this.pb_Op = new System.Windows.Forms.PictureBox();
            this.cm_Menu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.横向扩展ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.竖向扩展ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.关闭会话ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pb_thumb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Op)).BeginInit();
            this.cm_Menu.SuspendLayout();
            this.SuspendLayout();
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
            // pb_Op
            // 
            this.pb_Op.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pb_Op.ContextMenuStrip = this.cm_Menu;
            this.pb_Op.Location = new System.Drawing.Point(153, 2);
            this.pb_Op.Name = "pb_Op";
            this.pb_Op.Size = new System.Drawing.Size(25, 25);
            this.pb_Op.TabIndex = 2;
            this.pb_Op.TabStop = false;
            // 
            // cm_Menu
            // 
            this.cm_Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripSeparator2,
            this.toolStripMenuItem3,
            this.toolStripSeparator1,
            this.横向扩展ToolStripMenuItem,
            this.竖向扩展ToolStripMenuItem,
            this.toolStripMenuItem1,
            this.关闭会话ToolStripMenuItem});
            this.cm_Menu.Name = "cm_Menu";
            this.cm_Menu.Size = new System.Drawing.Size(125, 132);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(124, 22);
            this.toolStripMenuItem2.Text = "重复会话";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(121, 6);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(124, 22);
            this.toolStripMenuItem3.Text = "独立窗口";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(121, 6);
            // 
            // 横向扩展ToolStripMenuItem
            // 
            this.横向扩展ToolStripMenuItem.Name = "横向扩展ToolStripMenuItem";
            this.横向扩展ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.横向扩展ToolStripMenuItem.Text = "横向扩展";
            // 
            // 竖向扩展ToolStripMenuItem
            // 
            this.竖向扩展ToolStripMenuItem.Name = "竖向扩展ToolStripMenuItem";
            this.竖向扩展ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.竖向扩展ToolStripMenuItem.Text = "竖向扩展";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(121, 6);
            // 
            // 关闭会话ToolStripMenuItem
            // 
            this.关闭会话ToolStripMenuItem.Name = "关闭会话ToolStripMenuItem";
            this.关闭会话ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.关闭会话ToolStripMenuItem.Text = "关闭会话";
            // 
            // MTabPage
            // 
            this.ContextMenuStrip = this.cm_Menu;
            ((System.ComponentModel.ISupportInitialize)(this.pb_thumb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Op)).EndInit();
            this.cm_Menu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_thumb;
        private System.Windows.Forms.Panel pn_proccess;
        private System.Windows.Forms.Timer tm_upthumb;
        private System.Windows.Forms.PictureBox pb_Op;
        private System.Windows.Forms.ContextMenuStrip cm_Menu;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem 横向扩展ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 竖向扩展ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 关闭会话ToolStripMenuItem;
    }
}

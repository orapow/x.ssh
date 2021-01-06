namespace NShell.UserContorl
{
    partial class SplitPanel
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
            this.scPanel = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.scPanel)).BeginInit();
            this.scPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // scPanel
            // 
            this.scPanel.BackColor = System.Drawing.SystemColors.Control;
            this.scPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scPanel.Location = new System.Drawing.Point(0, 0);
            this.scPanel.Margin = new System.Windows.Forms.Padding(0);
            this.scPanel.Name = "scPanel";
            // 
            // scPanel.Panel1
            // 
            this.scPanel.Panel1.BackColor = System.Drawing.Color.Transparent;
            // 
            // scPanel.Panel2
            // 
            this.scPanel.Panel2.BackColor = System.Drawing.Color.Transparent;
            this.scPanel.Panel2Collapsed = true;
            this.scPanel.Size = new System.Drawing.Size(400, 400);
            this.scPanel.SplitterDistance = 375;
            this.scPanel.SplitterWidth = 1;
            this.scPanel.TabIndex = 0;
            this.scPanel.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.scPanel_MouseDoubleClick);
            // 
            // SplitPanel
            // 
            this.AllowDrop = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.Controls.Add(this.scPanel);
            this.Name = "SplitPanel";
            this.Size = new System.Drawing.Size(400, 400);
            ((System.ComponentModel.ISupportInitialize)(this.scPanel)).EndInit();
            this.scPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.SplitContainer scPanel;
    }
}

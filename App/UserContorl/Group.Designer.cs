namespace NShell
{
    partial class GroupPanel
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
            this.tp_mask = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.tp_mask)).BeginInit();
            this.SuspendLayout();
            // 
            // tp_mask
            // 
            this.tp_mask.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tp_mask.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.tp_mask.Location = new System.Drawing.Point(0, 0);
            this.tp_mask.Name = "tp_mask";
            this.tp_mask.Size = new System.Drawing.Size(400, 400);
            this.tp_mask.TabIndex = 1;
            this.tp_mask.TabStop = false;
            this.tp_mask.Visible = false;
            // 
            // GroupPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.tp_mask);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "GroupPanel";
            this.Size = new System.Drawing.Size(400, 400);
            ((System.ComponentModel.ISupportInitialize)(this.tp_mask)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox tp_mask;
    }
}

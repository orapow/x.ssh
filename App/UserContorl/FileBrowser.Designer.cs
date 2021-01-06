namespace NShell.UserContorl
{
    partial class FileBrowser
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tb_path = new System.Windows.Forms.TextBox();
            this.dgv_fs = new System.Windows.Forms.DataGridView();
            this.NameEx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SizeEx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cb_hosts = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_fs)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_path
            // 
            this.tb_path.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_path.Location = new System.Drawing.Point(129, 0);
            this.tb_path.Name = "tb_path";
            this.tb_path.Size = new System.Drawing.Size(231, 21);
            this.tb_path.TabIndex = 5;
            this.tb_path.MouseDown += new System.Windows.Forms.MouseEventHandler(this.comm_MouseDown);
            // 
            // dgv_fs
            // 
            this.dgv_fs.AllowUserToAddRows = false;
            this.dgv_fs.AllowUserToDeleteRows = false;
            this.dgv_fs.AllowUserToResizeRows = false;
            this.dgv_fs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_fs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_fs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_fs.ColumnHeadersHeight = 26;
            this.dgv_fs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameEx,
            this.SizeEx,
            this.Date,
            this.Type});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_fs.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_fs.Location = new System.Drawing.Point(0, 27);
            this.dgv_fs.MultiSelect = false;
            this.dgv_fs.Name = "dgv_fs";
            this.dgv_fs.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_fs.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_fs.RowHeadersVisible = false;
            this.dgv_fs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_fs.Size = new System.Drawing.Size(360, 393);
            this.dgv_fs.TabIndex = 6;
            this.dgv_fs.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_fs_CellMouseClick);
            this.dgv_fs.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_fs_CellMouseDoubleClick);
            this.dgv_fs.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_fs_CellMouseDown);
            this.dgv_fs.MouseDown += new System.Windows.Forms.MouseEventHandler(this.comm_MouseDown);
            // 
            // NameEx
            // 
            this.NameEx.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NameEx.HeaderText = "名称";
            this.NameEx.Name = "NameEx";
            this.NameEx.ReadOnly = true;
            this.NameEx.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // SizeEx
            // 
            this.SizeEx.HeaderText = "大小";
            this.SizeEx.MinimumWidth = 80;
            this.SizeEx.Name = "SizeEx";
            this.SizeEx.ReadOnly = true;
            this.SizeEx.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.SizeEx.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.SizeEx.Width = 80;
            // 
            // Date
            // 
            this.Date.HeaderText = "日期";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            this.Date.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Date.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Date.Width = 120;
            // 
            // Type
            // 
            this.Type.HeaderText = "类型";
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            this.Type.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Type.Visible = false;
            // 
            // cb_hosts
            // 
            this.cb_hosts.Dock = System.Windows.Forms.DockStyle.Left;
            this.cb_hosts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_hosts.FormattingEnabled = true;
            this.cb_hosts.Location = new System.Drawing.Point(0, 0);
            this.cb_hosts.Name = "cb_hosts";
            this.cb_hosts.Size = new System.Drawing.Size(123, 20);
            this.cb_hosts.TabIndex = 7;
            this.cb_hosts.SelectedIndexChanged += new System.EventHandler(this.cb_hosts_SelectedIndexChanged);
            this.cb_hosts.MouseDown += new System.Windows.Forms.MouseEventHandler(this.comm_MouseDown);
            // 
            // FileBrowser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cb_hosts);
            this.Controls.Add(this.dgv_fs);
            this.Controls.Add(this.tb_path);
            this.Name = "FileBrowser";
            this.Size = new System.Drawing.Size(360, 420);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.comm_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_fs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tb_path;
        private System.Windows.Forms.DataGridView dgv_fs;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameEx;
        private System.Windows.Forms.DataGridViewTextBoxColumn SizeEx;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.ComboBox cb_hosts;
    }
}

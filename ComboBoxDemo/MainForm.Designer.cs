namespace CustomPopupDemo
{
    partial class MainForm
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
            this.dataGridViewDemo = new System.Windows.Forms.DataGridView();
            this.dgvColCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColEmployeeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDemo)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewDemo
            // 
            this.dataGridViewDemo.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewDemo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewDemo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDemo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvColCode,
            this.dgvColEmployeeName});
            this.dataGridViewDemo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewDemo.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewDemo.Name = "dataGridViewDemo";
            this.dataGridViewDemo.Size = new System.Drawing.Size(393, 167);
            this.dataGridViewDemo.TabIndex = 3;
            this.dataGridViewDemo.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.MainDataGridView_EditingControlShowing);
            // 
            // dgvColCode
            // 
            this.dgvColCode.HeaderText = "Code";
            this.dgvColCode.Name = "dgvColCode";
            // 
            // dgvColEmployeeName
            // 
            this.dgvColEmployeeName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvColEmployeeName.HeaderText = "Employee Name";
            this.dgvColEmployeeName.Name = "dgvColEmployeeName";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 167);
            this.Controls.Add(this.dataGridViewDemo);
            this.DoubleBuffered = true;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Custom Popup Demo";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDemo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewDemo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColEmployeeName;
    }
}


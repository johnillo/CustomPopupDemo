namespace CustomPopupDemo
{
    partial class EmployeePicker
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // mainListBox
            // 
            this.mainListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mainListBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainListBox.FormattingEnabled = true;
            this.mainListBox.IntegralHeight = false;
            this.mainListBox.ItemHeight = 17;
            this.mainListBox.Location = new System.Drawing.Point(3, 3);
            this.mainListBox.Name = "mainListBox";
            this.mainListBox.Size = new System.Drawing.Size(275, 199);
            this.mainListBox.TabIndex = 3;
            this.mainListBox.DoubleClick += new System.EventHandler(this.MainListBox_DoubleClick);
            this.mainListBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainListBox_KeyDown);
            // 
            // EmployeePicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.mainListBox);
            this.DoubleBuffered = true;
            this.Name = "EmployeePicker";
            this.Size = new System.Drawing.Size(278, 202);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox mainListBox;
    }
}

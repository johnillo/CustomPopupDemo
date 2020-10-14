using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace CustomPopupDemo
{
    public partial class EmployeePicker : UserControl
    {
        class EmployeePickerItem
        {
            public string Code { get; set; }
            public string Name { get; set; }
        }

        TextBox TargetTextBox { get; set; }

        private ToolStripDropDown Popup
        {
            get {
                return (Parent is ToolStripDropDown popup) ? popup : null;
            }
        }

        public EmployeePicker(TextBox input)
        {
            InitializeComponent();

            List<EmployeePickerItem> options = new List<EmployeePickerItem>() {
                new EmployeePickerItem() {Code = "001", Name = "John Doe"},
                new EmployeePickerItem() {Code = "002", Name = "Jane Doe"},
                new EmployeePickerItem() {Code = "003", Name = "Steve Jobs"},
                new EmployeePickerItem() {Code = "004", Name = "Bill Gates"},
                new EmployeePickerItem() {Code = "005", Name = "Jeff Bezos"},
                new EmployeePickerItem() {Code = "006", Name = "Mark Twain"},
                new EmployeePickerItem() {Code = "007", Name = "Yoh Asakura"},
                new EmployeePickerItem() {Code = "008", Name = "Ruby Rose"},
                new EmployeePickerItem() {Code = "009", Name = "Rintarou Okabe"},
                new EmployeePickerItem() {Code = "010", Name = "Kurisu Makise"},
                new EmployeePickerItem() {Code = "011", Name = "Weiss Schnee"},
                new EmployeePickerItem() {Code = "012", Name = "Nokz LeBron"},
            };

            mainListBox.DataSource = new BindingList<EmployeePickerItem>(options);
            mainListBox.DisplayMember = "Name";
            mainListBox.ValueMember = "Code";

            TargetTextBox = input;
        }
    
        private void Close()
        {
            Popup.Close();
            Dispose();
        }

        private void MainListBox_DoubleClick(object sender, EventArgs e)
        {
            TargetTextBox.Text = mainListBox.SelectedValue.ToString();
            Close();
        }

        private void MainListBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter) {
                return;
            }
            TargetTextBox.Text = mainListBox.SelectedValue.ToString();
            Close();
        }
    }
}

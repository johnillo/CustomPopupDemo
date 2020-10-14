using System.Drawing;
using System.Windows.Forms;

namespace CustomPopupDemo
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainDataGridView_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            // show only on "Code" column cells
            if (dataGridViewDemo.CurrentCell.ColumnIndex != dataGridViewDemo.Columns["dgvColCode"].Index) {
                return;
            }

            DataGridViewTextBoxEditingControl textBox = e.Control as DataGridViewTextBoxEditingControl;
            Rectangle cellRect = dataGridViewDemo.GetCellDisplayRectangle(dataGridViewDemo.CurrentCell.ColumnIndex, dataGridViewDemo.CurrentCell.RowIndex, true);

            // cell should be a textbox
            if (textBox == null) {
                return;
            }

            // display the popup below the cell
            EmployeePicker popup = new EmployeePicker(textBox);
            new DropDown(popup).Show((Control)sender, new Point(cellRect.Left, cellRect.Top + cellRect.Height));

            popup.Focus();
        }
    }
}

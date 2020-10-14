using System.Windows.Forms;

namespace CustomPopupDemo
{
    class DropDown : ToolStripDropDown
    {
        public DropDown(Control content) {
            Margin = Padding.Empty;
            Padding = Padding.Empty;

            ToolStripControlHost host = new ToolStripControlHost(content);

            host.Margin = Padding.Empty;
            host.Padding = Padding.Empty;

            Items.Add(host);
        }
    }
}

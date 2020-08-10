using System;
using System.Windows.Forms;

namespace image_editor
{
    public partial class NewImage : Form
    {
        Panel panel;

        int width;
        int height;
        public NewImage(Panel panel)
        {
            InitializeComponent();

            this.panel = panel;

            widthNumericUpDown.Maximum = panel.Size.Width;
            heightNumericUpDown.Maximum = panel.Size.Height;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            width = (int)widthNumericUpDown.Value;
            height = (int)heightNumericUpDown.Value;
        }

        public int getWidth()
        {
            return width;
        }
        public int getHeight()
        {
            return height;
        }
    }
}

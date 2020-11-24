using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tech
{
    public partial class ImportOtherFormat : Form
    {
        public ImportOtherFormat()
        {
            InitializeComponent();
        }

        private void BrowserOtherFormats_Click(object sender, EventArgs e)
        {
            OpenFileDialog OtherFormatsdlg = new OpenFileDialog();
            OtherFormatsdlg.ShowDialog();
            OtherFormatsPath.Text = OtherFormatsdlg.FileName;
        }

        private void OtherFormatsPath_TextChanged(object sender, EventArgs e)
        {

        }

        private void PanelOtherFileFormats_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LoadOtherFormats_Click(object sender, EventArgs e)
        {

        }
    }
}

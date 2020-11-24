using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tech
{
    public partial class Export_OptionControl : UserControl
    {
        public Export_OptionControl()
        {
            InitializeComponent();
        }

        private void btnOutputOtherFormats_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                richTextBox.SaveFile(saveFileDialog.FileName);
            }
            richTextBox.Text = "";
        }

        private void BrowserInputFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ConvertOtherdlg = new OpenFileDialog();
            ConvertOtherdlg.ShowDialog();
            richTextBox.Text = ConvertOtherdlg.FileName;
        }
    }
}

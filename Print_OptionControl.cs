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
    public partial class Print_OptionControl : UserControl
    {
        public Print_OptionControl()
        {
            InitializeComponent();
        }

        private void BrowserFileToPrint_Click(object sender, EventArgs e)
        {
            OpenFileDialog ConvertOtherdlg = new OpenFileDialog();
            ConvertOtherdlg.ShowDialog();
            richTextBox.Text = ConvertOtherdlg.FileName;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                
                //richTextBox.SaveFile(printDialog.ToString);
            }
            richTextBox.Text = "";
        }
    }
}

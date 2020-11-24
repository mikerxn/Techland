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
    public partial class ConvertPDF : Form
    {
        public ConvertPDF()
        {
            InitializeComponent();
        }
        private void BrowserInputFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ConvertPDFdlg = new OpenFileDialog();
            ConvertPDFdlg.ShowDialog();
            richTextBox.Text = ConvertPDFdlg.FileName;
        }
        private void btnOutputOtherFormats_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                richTextBox.SaveFile(saveFileDialog.FileName);
            }
            this.Close();
        }        
    }
}

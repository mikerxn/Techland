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
    public partial class ConvertImage : Form
    {
        public ConvertImage()
        {
            InitializeComponent();
        }

        private void BrowserInputFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ConvertOtherdlg = new OpenFileDialog();
            ConvertOtherdlg.ShowDialog();
            richTextBox.Text = ConvertOtherdlg.FileName;
        }

        private void btnImage_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                richTextBox.SaveFile(saveFileDialog.FileName);
            }
            this.Close();
        }
    }
}

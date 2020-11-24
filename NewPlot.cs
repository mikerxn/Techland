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
    public partial class NewPlot : Form
    {
        public NewPlot()
        {
            InitializeComponent();
        }

        private void BrowserInputFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog Inputfiledlg = new OpenFileDialog();
            Inputfiledlg.ShowDialog();
            InputfilePath.Text = Inputfiledlg.FileName;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog FileToUsedlg = new OpenFileDialog();
            FileToUsedlg.ShowDialog();
            InputFileToUsePath.Text = FileToUsedlg.FileName;
        }
    }
}

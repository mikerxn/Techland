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
    public partial class JoinPlots : Form
    {
        public JoinPlots()
        {
            InitializeComponent();
        }

        private void BrowserFirstInputFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog FirstFiledlg = new OpenFileDialog();
            FirstFiledlg.ShowDialog();
            FirstInputfilePath.Text = FirstFiledlg.FileName;
        }

        private void BrowserSecondInputFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog SecondFiledlg = new OpenFileDialog();
            SecondFiledlg.ShowDialog();
            SecondInputfilePath.Text = SecondFiledlg.FileName;
        }
    }
}

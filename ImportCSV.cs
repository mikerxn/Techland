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
    public partial class ImportCSV : Form
    {
        public ImportCSV()
        {
            InitializeComponent();
        }

        private void BrowserCSV_Click(object sender, EventArgs e)
        {
            OpenFileDialog CSVdlg = new OpenFileDialog();
            CSVdlg.ShowDialog();
            CSVPath.Text = CSVdlg.FileName;
        }
    }
}

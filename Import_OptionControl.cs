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
    public partial class Import_OptionControl : UserControl
    {
        public Import_OptionControl()
        {
            InitializeComponent();
        }

        private void BrowserOtherFormats_Click(object sender, EventArgs e)
        {
            OpenFileDialog OtherFormatsdlg = new OpenFileDialog();
            OtherFormatsdlg.ShowDialog();
            OtherFormatsPath.Text = OtherFormatsdlg.FileName;
        }
    }
}

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
    public partial class HelpControl : UserControl
    {
        public HelpControl()
        {
            InitializeComponent();
        }

        private void buttonManual_Click(object sender, EventArgs e)
        {
            HelpManualForm HelpManualBackground = new HelpManualForm();

            try
            {
                HelpManualBackground.WindowState = FormWindowState.Normal;
                HelpManualBackground.TopMost = false;
                HelpManualBackground.Location = this.Location;
                HelpManualBackground.ShowInTaskbar = false;
                HelpManualBackground.ShowDialog(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

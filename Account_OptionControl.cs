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
    public partial class Account_OptionControl : UserControl
    {
        public Account_OptionControl()
        {
            InitializeComponent();
        }

        private void buttonPrevilages_Click(object sender, EventArgs e)
        {
            AccountSettingForm AccountSettingsBackground = new AccountSettingForm();
            try
            {
                AccountSettingsBackground.WindowState = FormWindowState.Normal;
                AccountSettingsBackground.TopMost = true;
                AccountSettingsBackground.Location = this.Location;
                AccountSettingsBackground.ShowInTaskbar = false;
                AccountSettingsBackground.ShowDialog(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

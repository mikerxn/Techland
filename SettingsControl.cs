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
    public partial class SettingsControl : UserControl
    {
        public SettingsControl()
        {
            InitializeComponent();
        }

        private void buttonCustom_Click(object sender, EventArgs e)
        {
            CustomProjectionsForm CustomProjectionsBackground = new CustomProjectionsForm();
            try
            {
                CustomProjectionsBackground.WindowState = FormWindowState.Normal;
                CustomProjectionsBackground.TopMost = true;
                CustomProjectionsBackground.Location = this.Location;
                CustomProjectionsBackground.ShowInTaskbar = false;
                CustomProjectionsBackground.ShowDialog(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonAccount_Click(object sender, EventArgs e)
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

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
    public partial class Edit_OptionControl : UserControl
    {
        public Edit_OptionControl()
        {
            InitializeComponent();
        }

        private void editLease_Click(object sender, EventArgs e)
        {
            EditLeaseForm ELeaseBackground = new EditLeaseForm();
            try
            {
                ELeaseBackground.WindowState = FormWindowState.Normal;
                ELeaseBackground.TopMost = true;
                ELeaseBackground.Location = this.Location;
                ELeaseBackground.ShowInTaskbar = false;
                ELeaseBackground.ShowDialog(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void editFree_Click(object sender, EventArgs e)
        {
            EditFreeHoldForm EFreeBackground = new EditFreeHoldForm();
            try
            {
                EFreeBackground.WindowState = FormWindowState.Normal;
                EFreeBackground.TopMost = true;
                EFreeBackground.Location = this.Location;
                EFreeBackground.ShowInTaskbar = false;
                EFreeBackground.ShowDialog(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void editCustomary_Click(object sender, EventArgs e)
        {
            EditCustomaryForm ECustomaryBackground = new EditCustomaryForm();
            try
            {
                ECustomaryBackground.WindowState = FormWindowState.Normal;
                ECustomaryBackground.TopMost = true;
                ECustomaryBackground.Location = this.Location;
                ECustomaryBackground.ShowInTaskbar = false;
                ECustomaryBackground.ShowDialog(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void editMailo_Click(object sender, EventArgs e)
        {
            EditMailoForm EMailoBackground = new EditMailoForm();
            try
            {
                EMailoBackground.WindowState = FormWindowState.Normal;
                EMailoBackground.TopMost = true;
                EMailoBackground.Location = this.Location;
                EMailoBackground.ShowInTaskbar = false;
                EMailoBackground.ShowDialog(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

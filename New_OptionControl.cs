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
    public partial class New_OptionControl : UserControl
    {
        public New_OptionControl()
        {
            InitializeComponent();
        }

        private void newLease_Click(object sender, EventArgs e)
        {
            NewLeaseForm NLeaseBackground = new NewLeaseForm();
            try
            {
                NLeaseBackground.WindowState = FormWindowState.Normal;
                NLeaseBackground.TopMost = true;
                NLeaseBackground.Location = this.Location;
                NLeaseBackground.ShowInTaskbar = false;
                NLeaseBackground.ShowDialog(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void newFree_Click(object sender, EventArgs e)
        {
            NewFreeHoldForm NFreeHoldBackground = new NewFreeHoldForm();
            try
            {
                NFreeHoldBackground.WindowState = FormWindowState.Normal;
                NFreeHoldBackground.TopMost = true;
                NFreeHoldBackground.Location = this.Location;
                NFreeHoldBackground.ShowInTaskbar = false;
                NFreeHoldBackground.ShowDialog(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void newCustomary_Click(object sender, EventArgs e)
        {
            NewCustomaryForm NCustomaryBackground = new NewCustomaryForm();
            try
            {
                NCustomaryBackground.WindowState = FormWindowState.Normal;
                NCustomaryBackground.TopMost = true;
                NCustomaryBackground.Location = this.Location;
                NCustomaryBackground.ShowInTaskbar = false;
                NCustomaryBackground.ShowDialog(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void newMailo_Click(object sender, EventArgs e)
        {
            NewMailoForm NMailoBackground = new NewMailoForm();
            try
            {
                NMailoBackground.WindowState = FormWindowState.Normal;
                NMailoBackground.TopMost = true;
                NMailoBackground.Location = this.Location;
                NMailoBackground.ShowInTaskbar = false;
                NMailoBackground.ShowDialog(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

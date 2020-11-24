using GMap.NET;
using GMap.NET.MapProviders;
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
    public partial class HomeControl : UserControl
    {
        public HomeControl()
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

        private void btnImport_Click(object sender, EventArgs e)
        {
            ImportOtherFormat ImportOtherFormatBackground = new ImportOtherFormat();
            try
            {
                ImportOtherFormatBackground.WindowState = FormWindowState.Normal;
                ImportOtherFormatBackground.TopMost = true;
                ImportOtherFormatBackground.Location = this.Location;
                ImportOtherFormatBackground.ShowInTaskbar = false;
                ImportOtherFormatBackground.ShowDialog(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            ConvertOther ConvertOtherBackground = new ConvertOther();
            try
            {
                ConvertOtherBackground.WindowState = FormWindowState.Normal;
                ConvertOtherBackground.TopMost = true;
                ConvertOtherBackground.Location = this.Location;
                ConvertOtherBackground.ShowInTaskbar = false;
                ConvertOtherBackground.ShowDialog(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

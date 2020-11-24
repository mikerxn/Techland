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
    public partial class OtherDBSearch : Form
    {
        public OtherDBSearch()
        {
            InitializeComponent();
        }

        private void btnSQLServerConnection_Click(object sender, EventArgs e)
        {
            OtherConnectionDetails OtherBackground = new OtherConnectionDetails();
            try
            {
                OtherBackground.WindowState = FormWindowState.Normal;
                OtherBackground.TopMost = true;
                OtherBackground.Location = this.Location;
                OtherBackground.ShowInTaskbar = false;
                OtherBackground.ShowDialog(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

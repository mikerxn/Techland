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
    public partial class SQLServerSearch : Form
    {
        public SQLServerSearch()
        {
            InitializeComponent();
        }

        private void btnSQLServerConnection_Click(object sender, EventArgs e)
        {
            SQLServerConnectionDetails SQLServerBackground = new SQLServerConnectionDetails();
            try
            {
                SQLServerBackground.WindowState = FormWindowState.Normal;
                SQLServerBackground.TopMost = true;
                SQLServerBackground.Location = this.Location;
                SQLServerBackground.ShowInTaskbar = false;
                SQLServerBackground.ShowDialog(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

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
    public partial class PostgreSQLSearch : Form
    {
        public PostgreSQLSearch()
        {
            InitializeComponent();
        }

        private void btnPostgreSQlDatabaseConnection_Click(object sender, EventArgs e)
        {
            PostgreSQLConnectionDetails PgcdBackground = new PostgreSQLConnectionDetails();
            try
            {
                PgcdBackground.WindowState = FormWindowState.Normal;
                PgcdBackground.TopMost = true;
                PgcdBackground.Location = this.Location;
                PgcdBackground.ShowInTaskbar = false;
                PgcdBackground.ShowDialog(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

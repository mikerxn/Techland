using Npgsql;
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
    public partial class PostgreSQLConnectionDetails : Form
    {
        //PostgreSQL database connection
        private NpgsqlConnection conn;
        string connstring = String.Format("Server={0}; Port={1};" + "User Id= {2}; Password={3};Database={4};", "127.0.0.1", "5432", "postgres", "mikerxn", "Techland");
        private NpgsqlCommand cmd;
        private string sql = null;

        public PostgreSQLConnectionDetails()
        {
            InitializeComponent();
        }

        private void PostgreSQLConnectionDetails_Load(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(connstring);
        }

        private void Connect_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                sql = @"select * from tech_land (:_username, :_password)";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("_username", txtusername.Text);
                cmd.Parameters.AddWithValue("_password", txtpassword.Text);
                int result = (int)cmd.ExecuteScalar();
                conn.Close();
                if (result == 1)//login successfull
                {
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Please Check Your Username or Password", "Login Fail", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Something went wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
            }
        }
    }
}

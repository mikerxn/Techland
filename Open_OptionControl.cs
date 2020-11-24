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
    public partial class Open_OptionControl : UserControl
    {
        public Open_OptionControl()
        {
            InitializeComponent();
        }

        private void FromCSV_Click(object sender, EventArgs e)
        {
            ImportCSV ImportCSVBackground = new ImportCSV();
            try
            {
                ImportCSVBackground.WindowState = FormWindowState.Normal;
                ImportCSVBackground.TopMost = true;
                ImportCSVBackground.Location = this.Location;
                ImportCSVBackground.ShowInTaskbar = false;
                ImportCSVBackground.ShowDialog(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void fromGeoJSON_Click(object sender, EventArgs e)
        {
            ImportGeoJSON ImportGeoJSONBackground = new ImportGeoJSON();
            try
            {
                ImportGeoJSONBackground.WindowState = FormWindowState.Normal;
                ImportGeoJSONBackground.TopMost = true;
                ImportGeoJSONBackground.Location = this.Location;
                ImportGeoJSONBackground.ShowInTaskbar = false;
                ImportGeoJSONBackground.ShowDialog(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FromShapefile_Click(object sender, EventArgs e)
        {
            ImportShapefile ImportShapefileBackground = new ImportShapefile();
            try
            {
                ImportShapefileBackground.WindowState = FormWindowState.Normal;
                ImportShapefileBackground.TopMost = true;
                ImportShapefileBackground.Location = this.Location;
                ImportShapefileBackground.ShowInTaskbar = false;
                ImportShapefileBackground.ShowDialog(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void fromOther_Click(object sender, EventArgs e)
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
    }
}

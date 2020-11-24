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
    public partial class ImportGeoJSON : Form
    {
        public ImportGeoJSON()
        {
            InitializeComponent();
        }

        private void BrowserGeoJSON_Click(object sender, EventArgs e)
        {
            OpenFileDialog GeoJSONdlg = new OpenFileDialog();
            GeoJSONdlg.ShowDialog();
            GeoJSONPath.Text = GeoJSONdlg.FileName;
        }
    }
}

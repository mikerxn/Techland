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
    public partial class MapsControl : UserControl
    {
        public MapsControl()
        {
            InitializeComponent();
        }

        public void buttonSatellite_Click(object sender, EventArgs e)
        {
            /*MainForm gmapform = new MainForm();
            gmapform.GmapSatellite();*/
        }

        private void buttonVector_Click(object sender, EventArgs e)
        {
            /*MainForm gmapform = new MainForm();
            gmapform.GmapVector();*/
        }

        private void buttonTerain_Click(object sender, EventArgs e)
        {
            /*MainForm gmapform = new MainForm();
            gmapform.GmapTerrain();*/
        }

        private void buttonHybridMap_Click(object sender, EventArgs e)
        {
            /*MainForm gmapform = new MainForm();
            gmapform.GmapHybrid();*/
        }
    }
}

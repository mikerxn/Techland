﻿using System;
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
    public partial class ImportShapefile : Form
    {
        public ImportShapefile()
        {
            InitializeComponent();
        }

        private void BrowserShapefile_Click(object sender, EventArgs e)
        {
            OpenFileDialog Shapefiledlg = new OpenFileDialog();
            Shapefiledlg.ShowDialog();
            ShapefilePath.Text = Shapefiledlg.FileName;
        }
    }
}

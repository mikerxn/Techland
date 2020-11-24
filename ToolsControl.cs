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
    public partial class ToolsControl : UserControl
    {
        public ToolsControl()
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

        private void btnSplit_Click(object sender, EventArgs e)
        {
            SplitPlot SplitPlotsBackground = new SplitPlot();
            try
            {
                SplitPlotsBackground.WindowState = FormWindowState.Normal;
                SplitPlotsBackground.TopMost = true;
                SplitPlotsBackground.Location = this.Location;
                SplitPlotsBackground.ShowInTaskbar = false;
                SplitPlotsBackground.ShowDialog(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            NewPlot NewPlotBackground = new NewPlot();
            try
            {
                NewPlotBackground.WindowState = FormWindowState.Normal;
                NewPlotBackground.TopMost = true;
                NewPlotBackground.Location = this.Location;
                NewPlotBackground.ShowInTaskbar = false;
                NewPlotBackground.ShowDialog(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            PlotDetails PlotDetailsBackground = new PlotDetails();
            try
            {
                PlotDetailsBackground.WindowState = FormWindowState.Normal;
                PlotDetailsBackground.TopMost = true;
                PlotDetailsBackground.Location = this.Location;
                PlotDetailsBackground.ShowInTaskbar = false;
                PlotDetailsBackground.ShowDialog(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnJoin_Click(object sender, EventArgs e)
        {
            JoinPlots JoinPlotsBackground = new JoinPlots();
            try
            {
                JoinPlotsBackground.WindowState = FormWindowState.Normal;
                JoinPlotsBackground.TopMost = true;
                JoinPlotsBackground.Location = this.Location;
                JoinPlotsBackground.ShowInTaskbar = false;
                JoinPlotsBackground.ShowDialog(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ToShp_Click(object sender, EventArgs e)
        {
            ConvertShapefile ConvertShapefileBackground = new ConvertShapefile();
            try
            {
                ConvertShapefileBackground.WindowState = FormWindowState.Normal;
                ConvertShapefileBackground.TopMost = true;
                ConvertShapefileBackground.Location = this.Location;
                ConvertShapefileBackground.ShowInTaskbar = false;
                ConvertShapefileBackground.ShowDialog(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ToPDF_Click(object sender, EventArgs e)
        {
            ConvertPDF ConvertPDFBackground = new ConvertPDF();
            try
            {
                ConvertPDFBackground.WindowState = FormWindowState.Normal;
                ConvertPDFBackground.TopMost = true;
                ConvertPDFBackground.Location = this.Location;
                ConvertPDFBackground.ShowInTaskbar = false;
                ConvertPDFBackground.ShowDialog(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ToImage_Click(object sender, EventArgs e)
        {
            ConvertImage ConvertImageBackground = new ConvertImage();
            try
            {
                ConvertImageBackground.WindowState = FormWindowState.Normal;
                ConvertImageBackground.TopMost = true;
                ConvertImageBackground.Location = this.Location;
                ConvertImageBackground.ShowInTaskbar = false;
                ConvertImageBackground.ShowDialog(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ToOther_Click(object sender, EventArgs e)
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

        private void btnPostgreSQL_Click(object sender, EventArgs e)
        {
            PostgreSQLSearch PostgreSQLSearchBackground = new PostgreSQLSearch();
            try
            {
                PostgreSQLSearchBackground.WindowState = FormWindowState.Normal;
                PostgreSQLSearchBackground.TopMost = true;
                PostgreSQLSearchBackground.Location = this.Location;
                PostgreSQLSearchBackground.ShowInTaskbar = false;
                PostgreSQLSearchBackground.ShowDialog(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSQLServer_Click(object sender, EventArgs e)
        {
            SQLServerSearch SQLServerSearchBackground = new SQLServerSearch();
            try
            {
                SQLServerSearchBackground.WindowState = FormWindowState.Normal;
                SQLServerSearchBackground.TopMost = true;
                SQLServerSearchBackground.Location = this.Location;
                SQLServerSearchBackground.ShowInTaskbar = false;
                SQLServerSearchBackground.ShowDialog(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnOracleServer_Click(object sender, EventArgs e)
        {
            OracleSearch OracleSearchBackground = new OracleSearch();
            try
            {
                OracleSearchBackground.WindowState = FormWindowState.Normal;
                OracleSearchBackground.TopMost = true;
                OracleSearchBackground.Location = this.Location;
                OracleSearchBackground.ShowInTaskbar = false;
                OracleSearchBackground.ShowDialog(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnOtherServer_Click(object sender, EventArgs e)
        {
            OtherDBSearch OtherDBSearchBackground = new OtherDBSearch();
            try
            {
                OtherDBSearchBackground.WindowState = FormWindowState.Normal;
                OtherDBSearchBackground.TopMost = true;
                OtherDBSearchBackground.Location = this.Location;
                OtherDBSearchBackground.ShowInTaskbar = false;
                OtherDBSearchBackground.ShowDialog(this);
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
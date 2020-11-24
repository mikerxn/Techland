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
    public partial class RibbonControl : UserControl
    {
        public RibbonControl()
        {
            InitializeComponent();
        }


        private void HomeButton_Click(object sender, EventArgs e)
        {
            HomeButton.ChangeColorMouseHC = false;
            mapsButton.ChangeColorMouseHC = true;
            toolsButton.ChangeColorMouseHC = true;
            settingsButton.ChangeColorMouseHC = true;
            aboutButton.ChangeColorMouseHC = true;
            helpButton.ChangeColorMouseHC = true;

            HomeButton.ForeColor = Color.FromArgb(45, 85, 155);
            mapsButton.ForeColor = Color.FromArgb(30, 30, 30);
            toolsButton.ForeColor = Color.FromArgb(30, 30, 30);
            settingsButton.ForeColor = Color.FromArgb(30, 30, 30);
            aboutButton.ForeColor = Color.FromArgb(30, 30, 30);
            helpButton.ForeColor = Color.FromArgb(30, 30, 30);

            HomeButton.ShowBorder = true;
            mapsButton.ShowBorder = false;
            toolsButton.ShowBorder = false;
            settingsButton.ShowBorder = false;
            aboutButton.ShowBorder = false;
            helpButton.ShowBorder = false;

            tabPanel.SkipXRange = new Point(HomeButton.Location.X,
                                            HomeButton.Location.X + HomeButton.Width);
        }

        private void mapsButton_Click(object sender, EventArgs e)
        {
            mapsButton.ChangeColorMouseHC = false;
            HomeButton.ChangeColorMouseHC = true;
            toolsButton.ChangeColorMouseHC = true;
            settingsButton.ChangeColorMouseHC = true;
            aboutButton.ChangeColorMouseHC = true;
            helpButton.ChangeColorMouseHC = true;

            mapsButton.ForeColor = Color.FromArgb(45, 85, 155);
            HomeButton.ForeColor = Color.FromArgb(30, 30, 30);
            toolsButton.ForeColor = Color.FromArgb(30, 30, 30);
            settingsButton.ForeColor = Color.FromArgb(30, 30, 30);
            aboutButton.ForeColor = Color.FromArgb(30, 30, 30);
            helpButton.ForeColor = Color.FromArgb(30, 30, 30);

            mapsButton.ShowBorder = true;
            HomeButton.ShowBorder = false;
            toolsButton.ShowBorder = false;
            settingsButton.ShowBorder = false;
            aboutButton.ShowBorder = false;
            helpButton.ShowBorder = false;

            tabPanel.SkipXRange = new Point(mapsButton.Location.X,
                                            mapsButton.Location.X + mapsButton.Width);
        }

        private void toolsButton_Click(object sender, EventArgs e)
        {
            toolsButton.ChangeColorMouseHC = false;
            HomeButton.ChangeColorMouseHC = true;
            mapsButton.ChangeColorMouseHC = true;
            settingsButton.ChangeColorMouseHC = true;
            aboutButton.ChangeColorMouseHC = true;
            helpButton.ChangeColorMouseHC = true;

            toolsButton.ForeColor = Color.FromArgb(45, 85, 155);
            mapsButton.ForeColor = Color.FromArgb(30, 30, 30);
            HomeButton.ForeColor = Color.FromArgb(30, 30, 30);
            settingsButton.ForeColor = Color.FromArgb(30, 30, 30);
            aboutButton.ForeColor = Color.FromArgb(30, 30, 30);
            helpButton.ForeColor = Color.FromArgb(30, 30, 30);

            toolsButton.ShowBorder = true;
            HomeButton.ShowBorder = false;
            mapsButton.ShowBorder = false;
            settingsButton.ShowBorder = false;
            aboutButton.ShowBorder = false;
            helpButton.ShowBorder = false;

            tabPanel.SkipXRange = new Point(toolsButton.Location.X,
                                            toolsButton.Location.X + toolsButton.Width);
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            settingsButton.ChangeColorMouseHC = false;
            HomeButton.ChangeColorMouseHC = true;
            mapsButton.ChangeColorMouseHC = true;
            aboutButton.ChangeColorMouseHC = true;
            toolsButton.ChangeColorMouseHC = true;
            helpButton.ChangeColorMouseHC = true;

            settingsButton.ForeColor = Color.FromArgb(45, 85, 155);
            mapsButton.ForeColor = Color.FromArgb(30, 30, 30);
            HomeButton.ForeColor = Color.FromArgb(30, 30, 30);
            aboutButton.ForeColor = Color.FromArgb(30, 30, 30);
            toolsButton.ForeColor = Color.FromArgb(30, 30, 30);
            helpButton.ForeColor = Color.FromArgb(30, 30, 30);

            settingsButton.ShowBorder = true;
            HomeButton.ShowBorder = false;
            mapsButton.ShowBorder = false;
            aboutButton.ShowBorder = false;
            toolsButton.ShowBorder = false;
            helpButton.ShowBorder = false;

            tabPanel.SkipXRange = new Point(settingsButton.Location.X,
                                                        settingsButton.Location.X + settingsButton.Width);
        }

        private void aboutButton_Click(object sender, EventArgs e)
        {
            aboutButton.ChangeColorMouseHC = false;
            HomeButton.ChangeColorMouseHC = true;
            mapsButton.ChangeColorMouseHC = true;
            toolsButton.ChangeColorMouseHC = true;
            settingsButton.ChangeColorMouseHC = true;
            helpButton.ChangeColorMouseHC = true;

            aboutButton.ForeColor = Color.FromArgb(45, 85, 155);
            mapsButton.ForeColor = Color.FromArgb(30, 30, 30);
            HomeButton.ForeColor = Color.FromArgb(30, 30, 30);
            toolsButton.ForeColor = Color.FromArgb(30, 30, 30);
            settingsButton.ForeColor = Color.FromArgb(30, 30, 30);
            helpButton.ForeColor = Color.FromArgb(30, 30, 30);

            aboutButton.ShowBorder = true;
            HomeButton.ShowBorder = false;
            mapsButton.ShowBorder = false;
            toolsButton.ShowBorder = false;
            settingsButton.ShowBorder = false;
            helpButton.ShowBorder = false;

            tabPanel.SkipXRange = new Point(aboutButton.Location.X,
                                            aboutButton.Location.X + aboutButton.Width);
        }

        private void helpsButton_Click(object sender, EventArgs e)
        {
            helpButton.ChangeColorMouseHC = false;
            HomeButton.ChangeColorMouseHC = true;
            mapsButton.ChangeColorMouseHC = true;
            toolsButton.ChangeColorMouseHC = true;
            settingsButton.ChangeColorMouseHC = true;
            aboutButton.ChangeColorMouseHC = true;

            helpButton.ForeColor = Color.FromArgb(45, 85, 155);
            mapsButton.ForeColor = Color.FromArgb(30, 30, 30);
            HomeButton.ForeColor = Color.FromArgb(30, 30, 30);
            toolsButton.ForeColor = Color.FromArgb(30, 30, 30);
            settingsButton.ForeColor = Color.FromArgb(30, 30, 30);
            aboutButton.ForeColor = Color.FromArgb(30, 30, 30);

            helpButton.ShowBorder = true;
            HomeButton.ShowBorder = false;
            mapsButton.ShowBorder = false;
            toolsButton.ShowBorder = false;
            settingsButton.ShowBorder = false;
            aboutButton.ShowBorder = false;

            tabPanel.SkipXRange = new Point(helpButton.Location.X,
                                            helpButton.Location.X + helpButton.Width);
        }

        private void RibbonControl_Load(object sender, EventArgs e)
        {
            HomeButton_Click(sender, e);
        }
    }
}

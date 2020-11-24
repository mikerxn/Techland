using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
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
    public partial class MainForm : Form
    {
        private List<PointLatLng> markStones;

        public MainForm()
        {
            InitializeComponent();
            markStones = new List<PointLatLng>();
        }

        bool isTopPanelDragged = false;
        bool isLeftPanelDragged = false;
        bool isRightPanelDragged = false;
        bool isBottomPanelDragged = false;
        bool isTopBorderPanelDragged = false;

        bool isRightBottomPanelDragged = false;
        bool isLeftBottomPanelDragged = false;
        bool isRightTopPanelDragged = false;
        bool isLeftTopPanelDragged = false;

        bool isWindowMaximized = false;
        Point offset;
        Size _normalWindowSize;
        Point _normalWindowLocation = Point.Empty;

        //Maps functions

        /*public void GmapSatellite()
        {
            MapControl.MapProvider = GMapProviders.GoogleSatelliteMap;
            MapControl.DragButton = MouseButtons.Left;
            MapControl.ShowCenter = false;
            MapControl.Position = new PointLatLng(0.345833, 32.630719);
            MapControl.MinZoom = 1;
            MapControl.MaxZoom = 100;
            MapControl.Zoom = 15;
        }
        public void GmapVector()
        {
            MapControl.MapProvider = GMapProviders.GoogleMap;
            MapControl.DragButton = MouseButtons.Left;
            MapControl.ShowCenter = false;
            MapControl.Position = new PointLatLng(0.345833, 32.630719);
            MapControl.MinZoom = 1;
            MapControl.MaxZoom = 100;
            MapControl.Zoom = 15;
        }
        public void GmapHybrid()
        {
            MapControl.MapProvider = GMapProviders.GoogleHybridMap;
            MapControl.DragButton = MouseButtons.Left;
            MapControl.ShowCenter = false;
            MapControl.Position = new PointLatLng(0.345833, 32.630719);
            MapControl.MinZoom = 1;
            MapControl.MaxZoom = 100;
            MapControl.Zoom = 15;
        }
        public void GmapTerrain()
        {
            MapControl.MapProvider = GMapProviders.GoogleTerrainMap;
            MapControl.DragButton = MouseButtons.Left;
            MapControl.ShowCenter = false;
            MapControl.Position = new PointLatLng(0.345833, 32.630719);
            MapControl.MinZoom = 1;
            MapControl.MaxZoom = 100;
            MapControl.Zoom = 15;
        }*/

        //********************************************************************
        // TopBorderPanel
        private void TopBorderPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isTopBorderPanelDragged = true;
            }
            else
            {
                isTopBorderPanelDragged = false;
            }
        }

        private void TopBorderPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Y < this.Location.Y)
            {
                if (isTopBorderPanelDragged)
                {
                    if (this.Height < 50)
                    {
                        this.Height = 50;
                        isTopBorderPanelDragged = false;
                    }
                    else
                    {
                        this.Location = new Point(this.Location.X, this.Location.Y + e.Y);
                        this.Height = this.Height - e.Y;
                    }
                }
            }
        }

        private void TopBorderPanel_MouseUp(object sender, MouseEventArgs e)
        {
            isTopBorderPanelDragged = false;
        }


        //********************************************************************
        // TopPanel
        private void TopPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isTopPanelDragged = true;
                Point pointStartPosition = this.PointToScreen(new Point(e.X, e.Y));
                offset = new Point();
                offset.X = this.Location.X - pointStartPosition.X;
                offset.Y = this.Location.Y - pointStartPosition.Y;
            }
            else
            {
                isTopPanelDragged = false;
            }
            if (e.Clicks == 2)
            {
                isTopPanelDragged = false;
                minMaxButton_Click(sender, e);
            }
        }

        private void TopPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (isTopPanelDragged)
            {
                Point newPoint = TopPanel.PointToScreen(new Point(e.X, e.Y));
                newPoint.Offset(offset);
                this.Location = newPoint;

                if (this.Location.X > 2 || this.Location.Y > 2)
                {
                    if (this.WindowState == FormWindowState.Maximized)
                    {
                        this.Location = _normalWindowLocation;
                        this.Size = _normalWindowSize;
                        toolTip1.SetToolTip(minMaxButton, "Maximize");
                        minMaxButton.CFormState = MinMaxButton.CustomFormState.Normal;
                        isWindowMaximized = false;
                    }
                }
            }
        }

        private void TopPanel_MouseUp(object sender, MouseEventArgs e)
        {
            isTopPanelDragged = false;
            if (this.Location.Y <= 5)
            {
                if (!isWindowMaximized)
                {
                    _normalWindowSize = this.Size;
                    _normalWindowLocation = this.Location;

                    Rectangle rect = Screen.PrimaryScreen.WorkingArea;
                    this.Location = new Point(0, 0);
                    this.Size = new System.Drawing.Size(rect.Width, rect.Height);
                    toolTip1.SetToolTip(minMaxButton, "Restore Down");
                    minMaxButton.CFormState = MinMaxButton.CustomFormState.Maximize;
                    isWindowMaximized = true;
                }
            }
        }


        //********************************************************************
        // LeftPanel
        private void LeftPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (this.Location.X <= 0 || e.X < 0)
            {
                isLeftPanelDragged = false;
                this.Location = new Point(10, this.Location.Y);
            }
            else
            {
                if (e.Button == MouseButtons.Left)
                {
                    isLeftPanelDragged = true;
                }
                else
                {
                    isLeftPanelDragged = false;
                }
            }
        }

        private void LeftPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.X < this.Location.X)
            {
                if (isLeftPanelDragged)
                {
                    if (this.Width < 100)
                    {
                        this.Width = 100;
                        isLeftPanelDragged = false;
                    }
                    else
                    {
                        this.Location = new Point(this.Location.X + e.X, this.Location.Y);
                        this.Width = this.Width - e.X;
                    }
                }
            }
        }

        private void LeftPanel_MouseUp(object sender, MouseEventArgs e)
        {
            isLeftPanelDragged = false;
        }


        //********************************************************************
        // RightPanel
        private void RightPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isRightPanelDragged = true;
            }
            else
            {
                isRightPanelDragged = false;
            }
        }

        private void RightPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (isRightPanelDragged)
            {
                if (this.Width < 100)
                {
                    this.Width = 100;
                    isRightPanelDragged = false;
                }
                else
                {
                    this.Width = this.Width + e.X;
                }
            }
        }

        private void RightPanel_MouseUp(object sender, MouseEventArgs e)
        {
            isRightPanelDragged = false;
        }


        //********************************************************************
        // BottomPanel
        private void BottomPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isBottomPanelDragged = true;
            }
            else
            {
                isBottomPanelDragged = false;
            }
        }

        private void BottomPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (isBottomPanelDragged)
            {
                if (this.Height < 50)
                {
                    this.Height = 50;
                    isBottomPanelDragged = false;
                }
                else
                {
                    this.Height = this.Height + e.Y;
                }
            }
        }

        private void BottomPanel_MouseUp(object sender, MouseEventArgs e)
        {
            isBottomPanelDragged = false;
        }


        //********************************************************************
        // RightBottomPanel 1
        private void RightBottomPanel_1_MouseDown(object sender, MouseEventArgs e)
        {
            isRightBottomPanelDragged = true;
        }

        private void RightBottomPanel_1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isRightBottomPanelDragged)
            {
                if (this.Width < 100 || this.Height < 50)
                {
                    this.Width = 100;
                    this.Height = 50;
                    isRightBottomPanelDragged = false;
                }
                else
                {
                    this.Width = this.Width + e.X;
                    this.Height = this.Height + e.Y;
                }
            }
        }

        private void RightBottomPanel_1_MouseUp(object sender, MouseEventArgs e)
        {
            isRightBottomPanelDragged = false;
        }

        //********************************************************************
        // RightBottomPanel 2
        private void RightBottomPanel_2_MouseDown(object sender, MouseEventArgs e)
        {
            RightBottomPanel_1_MouseDown(sender, e);
        }

        private void RightBottomPanel_2_MouseMove(object sender, MouseEventArgs e)
        {
            RightBottomPanel_1_MouseMove(sender, e);
        }

        private void RightBottomPanel_2_MouseUp(object sender, MouseEventArgs e)
        {
            RightBottomPanel_1_MouseUp(sender, e);
        }


        //********************************************************************
        // LeftBottomPanel 1
        private void LeftBottomPanel_1_MouseDown(object sender, MouseEventArgs e)
        {
            isLeftBottomPanelDragged = true;
        }

        private void LeftBottomPanel_1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.X < this.Location.X)
            {
                if (isLeftBottomPanelDragged || this.Height < 50)
                {
                    if (this.Width < 100)
                    {
                        this.Width = 100;
                        this.Height = 50;
                        isLeftBottomPanelDragged = false;
                    }
                    else
                    {
                        this.Location = new Point(this.Location.X + e.X, this.Location.Y);
                        this.Width = this.Width - e.X;
                        this.Height = this.Height + e.Y;
                    }
                }
            }
        }

        private void LeftBottomPanel_1_MouseUp(object sender, MouseEventArgs e)
        {
            isLeftBottomPanelDragged = false;
        }


        //********************************************************************
        // LeftBottomPanel 2
        private void LeftBottomPanel_2_MouseDown(object sender, MouseEventArgs e)
        {
            LeftBottomPanel_1_MouseDown(sender, e);
        }

        private void LeftBottomPanel_2_MouseMove(object sender, MouseEventArgs e)
        {
            LeftBottomPanel_1_MouseMove(sender, e);
        }

        private void LeftBottomPanel_2_MouseUp(object sender, MouseEventArgs e)
        {
            LeftBottomPanel_1_MouseUp(sender, e);
        }



        //********************************************************************
        // RightTopPanel 1
        private void RightTopPanel_1_MouseDown(object sender, MouseEventArgs e)
        {
            isRightTopPanelDragged = true;
        }

        private void RightTopPanel_1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Y < this.Location.Y || e.X < this.Location.X)
            {
                if (isRightTopPanelDragged)
                {
                    if (this.Height < 50 || this.Width < 100)
                    {
                        this.Height = 50;
                        this.Width = 100;
                        isRightTopPanelDragged = false;
                    }
                    else
                    {
                        this.Location = new Point(this.Location.X, this.Location.Y + e.Y);
                        this.Height = this.Height - e.Y;
                        this.Width = this.Width + e.X;
                    }
                }
            }
        }

        private void RightTopPanel_1_MouseUp(object sender, MouseEventArgs e)
        {
            isRightTopPanelDragged = false;
        }

        //********************************************************************
        // RightTopPanel 2
        private void RightTopPanel_2_MouseDown(object sender, MouseEventArgs e)
        {
            RightTopPanel_1_MouseDown(sender, e);
        }

        private void RightTopPanel_2_MouseMove(object sender, MouseEventArgs e)
        {
            RightTopPanel_1_MouseMove(sender, e);
        }

        private void RightTopPanel_2_MouseUp(object sender, MouseEventArgs e)
        {
            RightTopPanel_1_MouseUp(sender, e);
        }


        //********************************************************************
        // LeftTopPanel 1
        private void LeftTopPanel_1_MouseDown(object sender, MouseEventArgs e)
        {
            isLeftTopPanelDragged = true;
        }

        private void LeftTopPanel_1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.X < this.Location.X || e.Y < this.Location.Y)
            {
                if (isLeftTopPanelDragged)
                {
                    if (this.Width < 100 || this.Height < 50)
                    {
                        this.Width = 100;
                        this.Height = 100;
                        isLeftTopPanelDragged = false;
                    }
                    else
                    {
                        this.Location = new Point(this.Location.X + e.X, this.Location.Y);
                        this.Width = this.Width - e.X;
                        this.Location = new Point(this.Location.X, this.Location.Y + e.Y);
                        this.Height = this.Height - e.Y;
                    }
                }
            }

        }

        private void LeftTopPanel_1_MouseUp(object sender, MouseEventArgs e)
        {
            isLeftTopPanelDragged = false;
        }


        //********************************************************************
        // LeftTopPanel 2
        private void LeftTopPanel_2_MouseDown(object sender, MouseEventArgs e)
        {
            LeftTopPanel_1_MouseDown(sender, e);
        }

        private void LeftTopPanel_2_MouseMove(object sender, MouseEventArgs e)
        {
            LeftTopPanel_1_MouseMove(sender, e);
        }

        private void LeftTopPanel_2_MouseUp(object sender, MouseEventArgs e)
        {
            LeftTopPanel_1_MouseUp(sender, e);
        }

        //FormText
        private void FormText_MouseDown(object sender, MouseEventArgs e)
        {
            TopPanel_MouseDown(sender, e);
        }

        private void FormText_MouseMove(object sender, MouseEventArgs e)
        {
            TopPanel_MouseMove(sender, e);
        }

        private void FormText_MouseUp(object sender, MouseEventArgs e)
        {
            TopPanel_MouseUp(sender, e);
        }

        //buttons actions
        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void minMaxButton_Click(object sender, EventArgs e)
        {
            if (isWindowMaximized)
            {
                this.Location = _normalWindowLocation;
                this.Size = _normalWindowSize;
                toolTip1.SetToolTip(minMaxButton, "Maximize");
                minMaxButton.CFormState = MinMaxButton.CustomFormState.Normal;
                FormText.Anchor =  AnchorStyles.Bottom | AnchorStyles.Top;
                isWindowMaximized = false;
            }
            else
            {
                _normalWindowSize = this.Size;
                _normalWindowLocation = this.Location;

                Rectangle rect = Screen.PrimaryScreen.WorkingArea;
                this.Location = new Point(0, 0);
                this.Size = new System.Drawing.Size(rect.Width, rect.Height);
                FormText.Anchor = AnchorStyles.Bottom | AnchorStyles.Top;
                toolTip1.SetToolTip(minMaxButton, "Restore Down");
                minMaxButton.CFormState = MinMaxButton.CustomFormState.Maximize;
                isWindowMaximized = true;
            }
        }

        private void minButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void helpButton_Click(object sender, EventArgs e)
        {

        }


        private void MainForm_Load(object sender, EventArgs e)
        {
            ribbonControl.FileButton.Click += new EventHandler(this.FileButton_Click);
            ribbonControl.HomeButton.Click += new EventHandler(this.HomeButton_Click);
            ribbonControl.mapsButton.Click += new EventHandler(this.mapsButton_Click);
            ribbonControl.toolsButton.Click += new EventHandler(this.toolsButton_Click);
            ribbonControl.settingsButton.Click += new EventHandler(this.settingsButton_Click);
            ribbonControl.aboutButton.Click += new EventHandler(this.aboutButton_Click);
            ribbonControl.helpButton.Click += new EventHandler(this.helpsButton_Click);
            FormText.Anchor = AnchorStyles.Bottom | AnchorStyles.Top;


            HomeButton_Click(sender, e);
        }



        Timer timer = new Timer();
        FileOptionsControl fileOptionsControl;
        public static int width = 200;
        int count = 1;

        private void AddFileOptionsControl()
        {
            timer.Interval = 160;
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();
        }


        void timer_Tick(object sender, EventArgs e)
        {
            width += 100;
            count++;
            fileOptionsControl.Width = width;

            if (width >= MainPanel.Width - 100)
            {
                fileOptionsControl.Dock = DockStyle.Fill;
                timer.Stop();

            }
        }

        enum CTRLTypes
        {
            None,
            HomeType,
            MapsType,
            ToolsType,
            SettingsType,
            AboutType,
            HelpType,
        }


        private void FileButton_Click(object sender, EventArgs e)
        {
            //editorContainer.Visible = false;
            LeftTopItemsPanel.Visible = false;
            MapPanel.Visible = false;
            TestPanel.Visible = false;
            ribbonControl.Visible = false;
            StatusPanel.Visible = true;
            TopPanel.Separator = 125;
            fileOptionsControl = new FileOptionsControl(fileOptionsControl, this);
            fileOptionsControl.Location = new Point(0, 0);
            fileOptionsControl.Height = MainPanel.Height;
            MainPanel.Controls.Add(fileOptionsControl);
            fileOptionsControl.SetFileOptionsObject = fileOptionsControl;
            AddFileOptionsControl();
        }


        static CTRLTypes addedControlType = CTRLTypes.None;

        private void HomeButton_Click(object sender, EventArgs e)
        {
            if (addedControlType != CTRLTypes.HomeType)
            {
                ribbonControl.tabPanel.Controls.Clear();
                HomeControl homectrl = new HomeControl();
                homectrl.Location = new Point(1, 1);
                homectrl.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
                ribbonControl.tabPanel.Controls.Add(homectrl);
                addedControlType = CTRLTypes.HomeType;
            }
        }

        private void mapsButton_Click(object sender, EventArgs e)
        {
            if (addedControlType != CTRLTypes.MapsType)
            {
                ribbonControl.tabPanel.Controls.Clear();
                MapsControl mapsctrl = new MapsControl();
                mapsctrl.Location = new Point(1, 1);
                mapsctrl.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
                ribbonControl.tabPanel.Controls.Add(mapsctrl);
                addedControlType = CTRLTypes.MapsType;
            }           
        }

        private void toolsButton_Click(object sender, EventArgs e)
        {
            if (addedControlType != CTRLTypes.ToolsType)
            {
                ribbonControl.tabPanel.Controls.Clear();
                ToolsControl toolsctrl = new ToolsControl();
                toolsctrl.Location = new Point(1, 1);
                toolsctrl.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
                ribbonControl.tabPanel.Controls.Add(toolsctrl);
                addedControlType = CTRLTypes.ToolsType;
            }
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            if (addedControlType != CTRLTypes.SettingsType)
            {
                ribbonControl.tabPanel.Controls.Clear();
                SettingsControl settingsctrl = new SettingsControl();
                settingsctrl.Location = new Point(1, 1);
                settingsctrl.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
                ribbonControl.tabPanel.Controls.Add(settingsctrl);
                addedControlType = CTRLTypes.SettingsType;
            }
        }

        private void aboutButton_Click(object sender, EventArgs e)
        {
            if (addedControlType != CTRLTypes.AboutType)
            {
                ribbonControl.tabPanel.Controls.Clear();
                AboutControl aboutctrl = new AboutControl();
                aboutctrl.Location = new Point(1, 1);
                aboutctrl.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
                ribbonControl.tabPanel.Controls.Add(aboutctrl);
                addedControlType = CTRLTypes.AboutType;
            }
        }

        private void helpsButton_Click(object sender, EventArgs e)
        {
            if (addedControlType != CTRLTypes.HelpType)
            {
                ribbonControl.tabPanel.Controls.Clear();
                HelpControl helpctrl = new HelpControl();
                helpctrl.Location = new Point(1, 1);
                helpctrl.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
                ribbonControl.tabPanel.Controls.Add(helpctrl);
                addedControlType = CTRLTypes.HelpType;
            }
        }

        private void buttonVector_Click(object sender, EventArgs e)
        {
            MapControl.MapProvider = GMapProviders.HereMap;
            MapControl.DragButton = MouseButtons.Left;
            MapControl.ShowCenter = false;
            MapControl.Position = new PointLatLng(0.345833, 32.630719);
            MapControl.MinZoom = 1;
            MapControl.MaxZoom = 100;
            MapControl.Zoom = 15;
        }

        private void buttonSatelite_Click(object sender, EventArgs e)
        {
            MapControl.MapProvider = GMapProviders.HereSatelliteMap;
            MapControl.DragButton = MouseButtons.Left;
            MapControl.ShowCenter = false;
            MapControl.Position = new PointLatLng(0.345833, 32.630719);
            MapControl.MinZoom = 1;
            MapControl.MaxZoom = 100;
            MapControl.Zoom = 15;
        }

        private void buttonHybrid_Click(object sender, EventArgs e)
        {
            MapControl.MapProvider = GMapProviders.HereHybridMap;
            MapControl.DragButton = MouseButtons.Left;
            MapControl.ShowCenter = false;
            MapControl.Position = new PointLatLng(0.345833, 32.630719);
            MapControl.MinZoom = 1;
            MapControl.MaxZoom = 100;
            MapControl.Zoom = 15;
        }

        private void buttonTerrain_Click(object sender, EventArgs e)
        {
            MapControl.MapProvider = GMapProviders.HereTerrainMap;
            MapControl.DragButton = MouseButtons.Left;
            MapControl.ShowCenter = false;
            MapControl.Position = new PointLatLng(0.345833, 32.630719);
            MapControl.MinZoom = 1;
            MapControl.MaxZoom = 100;
            MapControl.Zoom = 15;
        }

        private void btnAddMarkStone_Click(object sender, EventArgs e)
        {
            var point = new PointLatLng(Convert.ToDouble(txtLat.Text), Convert.ToDouble(txtLong.Text));
            MapControl.Position = new PointLatLng(Convert.ToDouble(txtLat.Text), Convert.ToDouble(txtLong.Text));
            markStones.Add(new PointLatLng(Convert.ToDouble(txtLat.Text), Convert.ToDouble(txtLong.Text)));
            //create a marker
            GMapMarker marker = new GMarkerGoogle(point, GMarkerGoogleType.blue_dot);
            //create an overlay
            GMapOverlay markers = new GMapOverlay("markers");
            //Add all the markers to that overlay
            markers.Markers.Add(marker);
            //cover the map with an overlay
            MapControl.Overlays.Add(markers);
            //MapControl.RefreshMap();
        }

        private void btnClearMarks_Click(object sender, EventArgs e)
        {
            //Clears the mark stones points
            markStones.Clear();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (MapControl.Overlays.Count > 0)
            {
                //Removes the layers
                MapControl.Overlays.RemoveAt(0);
                MapControl.Refresh();
            }
        }

        private void btnDistance_Click(object sender, EventArgs e)
        {
            GMapOverlay routes = new GMapOverlay("routes");
            GMapRoute route = new GMapRoute(markStones, "Marked Route");
            route.Stroke = new Pen(Color.Red, 3);
            routes.Routes.Add(route);
            MapControl.Overlays.Add(routes);
            //MapControl.RefreshMap();
            lblDistance.Text = "Distance = " + route.Distance + " km";
        }

        private void buttonCalArea_Click(object sender, EventArgs e)
        {
            GMapPolygon plot = new GMapPolygon(markStones, "Plot of land");
            plot.Stroke = new Pen(Color.Red, 1);
            plot.Fill = new SolidBrush(Color.LightGreen);
            GMapOverlay plots = new GMapOverlay("plots");
            plots.Polygons.Add(plot);
            MapControl.Overlays.Add(plots);
            //MapControl.RefreshMap();
        }

        private void MapControl_MouseClick(object sender, MouseEventArgs e)
        {
            if (chkMouseClick.Checked == true && e.Button == MouseButtons.Left)
            {

                var point = MapControl.FromLocalToLatLng(e.X, e.Y);
                double lat = point.Lat;
                double lng = point.Lng;

                txtLat.Text = lat + "";
                txtLong.Text = lng + "";

                //markStones.Add(new PointLatLng(Convert.ToDouble(txtLat.Text), Convert.ToDouble(txtLong.Text)));
                LoadMap(point);

                //function to load a marker
                AddMarker(point);
            }
        }
        private void LoadMap(PointLatLng point)
        {
            MapControl.Position = point;
        }
        private void AddMarker(PointLatLng point, GMarkerGoogleType markerType = GMarkerGoogleType.blue_dot)
        {
            //create a marker
            GMapMarker marker = new GMarkerGoogle(point, markerType);
            //create an overlay
            GMapOverlay markers = new GMapOverlay("markers");
            //add toolpit
            marker.ToolTipText = $"Latitude: {MapControl.Position.Lat} \nLongtitude: {MapControl.Position.Lng}";

            var toolTip = new GMapToolTip(marker)
            {
                Fill = new SolidBrush(Color.LightGray),
                Foreground = new SolidBrush(Color.Black),
                Offset = new Point(10, 0),
                Stroke = new Pen(new SolidBrush(Color.Red))
            };
            marker.ToolTip = toolTip;
            //Add all the markers to that overlay
            markers.Markers.Add(marker);
            //cover the map with an overlay
            MapControl.Overlays.Add(markers);
            markStones.Add(new PointLatLng(Convert.ToDouble(txtLat.Text), Convert.ToDouble(txtLong.Text)));
        }
    }
}

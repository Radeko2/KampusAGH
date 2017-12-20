using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;


namespace KampusAGH
{
    public partial class Form1 : Form
    {
       
        

        GMarkerGoogle marker;
        GMapOverlay markerOverlay;
        DataTable datatable;

        //routing
        bool drawRoute = false;
        int counter = 0;
        PointLatLng start;
        PointLatLng finish;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Map Control
            gMapControl1.DragButton = MouseButtons.Left;
            gMapControl1.CanDragMap = true;
            gMapControl1.MapProvider = GMapProviders.GoogleMap;
            gMapControl1.SetPositionByKeywords("AGH, Poland");
            gMapControl1.ShowCenter = false;

           



        }

        private void navigate_Click(object sender, EventArgs e)
        {
            drawRoute = true;
            navigate.Enabled = false;

        }
        public void createDirections(double lat, double lng)
        {
            if (drawRoute)
            {
                switch (counter)
                {
                    case 0:
                        counter++;
                        start = new PointLatLng(lat, lng);
                        break;
                    case 1:
                        counter++;
                        finish = new PointLatLng(lat, lng);
                        GDirections direction;
                        var routeDirection = GMapProviders.GoogleMap.GetDirections(out direction, start, finish, false, false, false, false, false);
                        GMapRoute obtainRoute = new GMapRoute(direction.Route, "route");
                        GMapOverlay routesOverlay = new GMapOverlay("Routes");
                        routesOverlay.Routes.Add(obtainRoute);
                        gMapControl1.Overlays.Add(routesOverlay);
                        counter = 0;
                        drawRoute = false;
                        navigate.Enabled = true;

                        break;
                 }
            }
        }

        private void agh_button_Click(object sender, EventArgs e)
        {
            gMapControl1.SetPositionByKeywords("AGH, Poland");
        }

        private void aghMap_Click(object sender, EventArgs e)
        {
            if(pictureBox1.Visible == false)
            {
                pictureBox1.Visible = true;
            }else if(pictureBox1.Visible == true)
            {
                pictureBox1.Visible = false;
            }

        }

        private void gMapControl1_DoubleClick(object sender, EventArgs e)
        {
            
        }

        private void gMapControl1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            double lat = gMapControl1.FromLocalToLatLng(e.X, e.Y).Lat;
            double lng = gMapControl1.FromLocalToLatLng(e.X, e.Y).Lng;
            createDirections(lat, lng);
        }
    }
}

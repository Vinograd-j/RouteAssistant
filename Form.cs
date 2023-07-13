using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace RouteAssistant
{
    public partial class ApplicationForm : Form
    {

        private List<PointLatLng> _points;

        private GMapOverlay _markers = new GMapOverlay("markersOverlay");
        private GMapOverlay _routes = new GMapOverlay("routesOverlay");


        public ApplicationForm()
        {
            InitializeComponent();
            _points = new List<PointLatLng>();
        }

        private void GmapInitialize(object sender, EventArgs e)
        {
            Map.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance;
      
            Map.MinZoom = 3;
            Map.MaxZoom = 20;
            Map.Zoom = 3;
            Map.ShowCenter = false;
        }


        private void OnResetButtonClicked(object sender, EventArgs e)
        {
            RemoveMarkersAndRoutes();
        }

        private void RemoveMarkersAndRoutes()
        {
            _points.Clear();
            _routes.Clear();
            _markers.Markers.Clear();
            Map.Overlays.Clear();
           
        }

        private void MapDoubleClick(object sender, MouseEventArgs e)
        {

            if (_points.Count >= 2)
                RemoveMarkersAndRoutes();

            if (e.Button == MouseButtons.Left)
            {

                PointLatLng point = Map.FromLocalToLatLng(e.X, e.Y);

                Marker marker = new Marker(point, GMarkerGoogleType.orange);
                  
                _markers.Markers.Add(marker.GetMarker());

                Map.Overlays.Add(_markers);

                _points.Add(point);

                if(_points.Count == 2)
                    DrawRoute(_points[0], _points[1]);

                ReloadMap();
            }
        }

        private void DrawRoute(PointLatLng firstPoint, PointLatLng secondPoint)
        {
            Route route = new Route(firstPoint, secondPoint, Color.DarkCyan);


            GMap.NET.WindowsForms.GMapRoute routeToDraw = route.GetRoute();

            if (routeToDraw == null)
            {
                RemoveMarkersAndRoutes();
                return;
            }
            

            _routes.Routes.Add(routeToDraw);
            Map.Overlays.Add(_routes);
        }

        private void OnSearchCoordsButtonClick(object sender, EventArgs e)
        {
            CoordsOutput.Text = new CitySearcher(CityField.Text).GetCoordinates();
        }

        private void ReloadMap()
        {
            Map.Zoom--;
            Map.Zoom++;
        }


        private void LoadForm(object sender, EventArgs e) { }
        private void TitleText_Click(object sender, EventArgs e) {}

    }
}

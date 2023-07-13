using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using System.Drawing;

namespace RouteAssistant
{
    internal class Route
    {

        private PointLatLng _firstPoint;
        private PointLatLng _secondPoint;

        private Color _color;


        public Route(PointLatLng firstPoint, PointLatLng secondPoint, Color color)
        {
            _firstPoint = firstPoint;
            _secondPoint = secondPoint;
            _color = color;
        }

        public GMapRoute GetRoute()
        {

            var route = OpenStreetMapProvider.Instance.GetRoute(new PointLatLng(_firstPoint.Lat, _firstPoint.Lng), new PointLatLng(_secondPoint.Lat, _secondPoint.Lng), false, false, 15);

            if (route == null)
                return null;

            var routePath = new GMap.NET.WindowsForms.GMapRoute(route.Points, "Route");

            routePath.Stroke.Color = _color;

            return routePath;
        }

    }
}

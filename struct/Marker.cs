using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;

namespace RouteAssistant
{
    internal class Marker
    {

        private GMapOverlay _markers = new GMapOverlay("markersOverlay");


        private PointLatLng _point;

        private GMarkerGoogleType _gMarkerGoogleType;

        public Marker(PointLatLng point, GMarkerGoogleType gMarkerGoogleType)
        {
            _point = point;
            _gMarkerGoogleType = gMarkerGoogleType;
        }


        public GMapMarker GetMarker()
        {

            GMapMarker marker = new GMarkerGoogle(_point, _gMarkerGoogleType);

            _markers.Markers.Add(marker);

            return marker;
        }

    }
}

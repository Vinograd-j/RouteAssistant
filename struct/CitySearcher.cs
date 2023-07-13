using System;
using System.IO;
using System.Net;
using System.Runtime.Serialization.Json;
using System.Text;

using static RouteAssistant.GeoNames;

namespace RouteAssistant
{
    internal class CitySearcher
    {

        private string _city;

        private GeoNamesResult _geoNamesResult;

        public CitySearcher(string city) 
        { 
           _city = city;
            Initialize();
        }

        private void Initialize()
        {
            string url = $"http://api.geonames.org/searchJSON?q={_city}&maxRows=1&username=ldx46052";
            WebClient client = new WebClient();
            string result = client.DownloadString(url);

            DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(GeoNamesResult));
            MemoryStream ms = new MemoryStream(Encoding.UTF8.GetBytes(result));
            _geoNamesResult = (GeoNamesResult)serializer.ReadObject(ms);
        }

        public string GetCoordinates()
        {
            if (_geoNamesResult.geonames.Length == 0)
                return "Такого объекта не существует!";

            double lat = _geoNamesResult.geonames[0].lat;
            double lng = _geoNamesResult.geonames[0].lng;

            return $"Широта: {lat}, Долгота: {lng}";
        }

    }
}

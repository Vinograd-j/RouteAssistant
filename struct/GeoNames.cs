using System.Runtime.Serialization;

namespace RouteAssistant
{
    internal class GeoNames
    {

        [DataContract]
        public class GeoNamesResult
        {
            [DataMember(Name = "geonames")]
            public GeoName[] geonames { get; set; }
        }

        [DataContract]
        public class GeoName
        {
            [DataMember(Name = "lat")]
            public double lat { get; set; }

            [DataMember(Name = "lng")]
            public double lng { get; set; }
        }
    }
}

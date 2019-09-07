using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GeoAPI.Models
{
    public class MapRoute
    {
        public DateTime Moment { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public MapRoute(DateTime moment, double latitude, double longitude)
        {
            Moment = moment;
            Latitude = latitude;
            Longitude = longitude;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using GeoAPI.Models;
using GeoAPI.DAL;

namespace GeoAPI.Controllers
{
    public class MapRoutesController : ApiController
    {
        // GET: api/MapRoutes/StartDate, EndDate
        public IEnumerable<MapRoute> Get(string startDate, string endDate)
        {
            IList<MapRoute> routeList = new MapRouteDAO().GetMapRoutes(DateTime.Parse(startDate), DateTime.Parse(endDate));
            return routeList;
        }

        public string Get()
        {
            return "You must specify a starting date and an ending date";
        }

        // GET: api/MapRoutes/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/MapRoutes
        public string Post(string value)
        {
            return value;
        }


        // PUT: api/MapRoutes/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/MapRoutes/5
        public void Delete(int id)
        {
        }
    }
}

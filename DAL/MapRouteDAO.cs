using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using GeoAPI.Models;

namespace GeoAPI.DAL
{
    public class MapRouteDAO
    {
        private DbConnection conn;

        public MapRouteDAO()
        {
            conn = new DbConnection();
        }

        public IList<MapRoute> GetMapRoutes(DateTime startDate, DateTime endDate)
        {
            List<MapRoute> mapRoute = new List<MapRoute>();

            try
            {
                SqlCommand command = new SqlCommand
                {
                    Connection = DbConnection.Connection,
                    CommandText = "SELECT Moment, Lat, Long FROM GeoLocalizationData WHERE Moment >= @startDate AND Moment <=  @endDate",
                };
                command.Parameters.AddWithValue("@startDate", startDate);
                command.Parameters.AddWithValue("@endDate", endDate);

                DbConnection.OpenConnection();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        mapRoute.Add(
                            new MapRoute(
                                reader.GetDateTime(0),
                                reader.GetDouble(1),
                                reader.GetDouble(2)
                            )
                        );
                    }
                }
                return mapRoute;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                DbConnection.CloseConnection();
            }
        }
    }
}
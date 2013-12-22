using System.Linq;
using Newtonsoft.Json.Linq;
using RestSharp;

namespace BackOffice
{
    static class GeocodingHelper
    {
        private static readonly RestClient Client = new RestClient(GoogleDistanceMatrixApi);
        //private const string GoogleGeocodingApi = "http://maps.googleapis.com/maps/api/geocode/json?address=";
        private const string GoogleDistanceMatrixApi = "http://maps.googleapis.com/maps/api/distancematrix/";

        public static string GetGeolocation(string adressToGeolocate)
        {
            return string.Empty;
        }

        /// <summary>
        ///Accepts either addresses or geolocation points both as origin or destination. Variables point1 and point2 can be either. Outputs distance in meters.
        /// </summary>
        /// <param name="point1"></param>
        /// <param name="point2"></param>
        /// <returns></returns>
        public static string GetDistanceBetweenPlaces(string point1, string point2)
        {
            var origin = point1.Replace(" ", "+");
            var destination = point2.Replace(" ", "+");

            var getLocation =
                "json?origins="+origin+"&destinations="+destination+"&mode=driving&language=en-US&sensor=false";

            var distanceMatrixOutput = JObject.Parse(CallApi(getLocation));

            var actualDistance =
                from distance in distanceMatrixOutput["rows"][0]["elements"]
            select distance["distance"]["value"];

            var firstOrDefault = actualDistance.FirstOrDefault();
            if (firstOrDefault != null) 
                return firstOrDefault.ToString();

            return string.Empty;
        }

        private static string CallApi(string whatToGet)
        {
            var request = new RestRequest(whatToGet);

            var response = Client.Execute(request);

            return response.Content;
        }
    }
}

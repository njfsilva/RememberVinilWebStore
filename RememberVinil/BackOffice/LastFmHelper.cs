using System;
using System.Linq;
using Newtonsoft.Json.Linq;
using RestSharp;

namespace BackOffice
{
    static class LastFmHelper
    {
        private static readonly RestClient Client = new RestClient(LastFmApi);
        private const string LastFmApi = "http://ws.audioscrobbler.com/2.0/";

        public static void GetArtistTopAlbums(string artistName)
        {
            string topAlbums = "?method=artist.gettopalbums&artist="+artistName+"&api_key=3de031038c2c688d3e3da6ec730628ae&format=json";

            var topalbums = JObject.Parse(CallLastFmApi(topAlbums));

            var albumNames =
                from album in topalbums["topalbums"]["album"]
                select (string)album["name"];

            foreach (var albumName in albumNames)
            {
                Console.WriteLine(albumName);
            }
        }

        private static string CallLastFmApi(string whatToGet)
        {
            var request = new RestRequest(whatToGet);

            var response = Client.Execute(request);

            return response.Content;
        }
    }
}

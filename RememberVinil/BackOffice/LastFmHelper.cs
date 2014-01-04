using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json.Linq;
using RestSharp;

namespace BackOffice
{
    static class LastFmHelper
    {
        private static readonly RestClient Client = new RestClient(LastFmApi);
        private const string LastFmApi = "http://ws.audioscrobbler.com/2.0/";

        public static List<string> GetArtistTopAlbums(string artistName)
        {
            var topAlbumsByArtist = "?method=artist.gettopalbums&artist=" + artistName + "&api_key=3de031038c2c688d3e3da6ec730628ae&format=json";

            var topAlbums = JObject.Parse(CallApi(topAlbumsByArtist));

            var albumNames =
                from album in topAlbums["topalbums"]["album"]
                select (string)album["name"];

            return albumNames.ToList();
        }

        public static List<string> GetArtistTopTracks(string artistName)
        {
            var topTracksByArtist = "?method=artist.gettoptracks&artist=" + artistName + "&api_key=3de031038c2c688d3e3da6ec730628ae&format=json";

            var topTracks = JObject.Parse(CallApi(topTracksByArtist));

            var trackNames =
                from track in topTracks["toptracks"]["track"]
                select (string)track["name"];

            return trackNames.ToList();
        }

        public static List<string> GetAlbumTracksByMbId(string mbID)
        {
            var albumTacksByAlbumMbId = "?method=album.getinfo&api_key=3de031038c2c688d3e3da6ec730628ae&mbid=" + mbID + "&format=json";

            var albumTracks = JObject.Parse(CallApi(albumTacksByAlbumMbId));

            var trackNames =
                from track in albumTracks["album"]["tracks"]["track"]
                select (string)track["name"];

            return trackNames.ToList();

        }

        public static List<string> SearchArtistByName(string artistName)
        {
            var searchArtistiByname = "?method=artist.search&artist=" + artistName + "&api_key=3de031038c2c688d3e3da6ec730628ae&format=json";

            var artists = JObject.Parse(CallApi(searchArtistiByname));

            var artistNames =
                from artist in artists["results"]["artistmatches"]["artist"]
                select (string)artist["name"];

            return artistNames.ToList();
        }

        private static string CallApi(string whatToGet)
        {
            var request = new RestRequest(whatToGet);

            var response = Client.Execute(request);

            return response.Content;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BackOffice;
using Newtonsoft.Json.Linq;
using RestSharp;
using RestSharp.Extensions;

namespace CDFactory
{
    public class LyricsHelper
    {
        private static readonly RestClient Client = new RestClient(MusixMatchApi);
        public const string Apikey = "d99c1b1f2051b32ac58469b0576dd207";
        public const string MusixMatchApi = "http://api.musixmatch.com/ws/1.1/";

        public static string GetLyrics(string trackName, string artist)
        {
            try
            {
                var searchTrackByname = "track.search?q_track=" + InputHandler(trackName) + "&q_artist=" + InputHandler(artist) + "&f_has_lyrics=1&format=json&apikey=" + Apikey;

                var tracks = JObject.Parse(CallApi(searchTrackByname));

                var trackId =
                    from track in tracks["message"]["body"]["track_list"]
                    select (string)track["track"]["track_id"];


                var getTrackLyrics = "track.lyrics.get?track_id=" + trackId.FirstOrDefault() + "&format=json&apikey=" + Apikey;

                var trackLyricsresponse = JObject.Parse(CallApi(getTrackLyrics));

                var trackLyrics = (string)trackLyricsresponse["message"]["body"]["lyrics"]["lyrics_body"];

                return trackLyrics;
            }
            catch (Exception ex)
            {
                return "Nao foi possivel obter a letra desta musica";
            }
        }

        private static string InputHandler(string input)
        {
            byte[] bytes = Encoding.Default.GetBytes(input);
            return Encoding.UTF8.GetString(bytes);
        }

        private static string CallApi(string whatToGet)
        {
            var request = new RestRequest(whatToGet);

            var response = Client.Execute(request);

            return response.Content;
        }
    }
}

﻿using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using RestSharp;

namespace Website
{
    public partial class WebsiteMain : Form
    {
        private static readonly RestClient Client = new RestClient(BackOfficeServiceRest);
        public const string BackOfficeServiceRest = "http://localhost:9001/WebSiteService";

        public static List<Track> ShoppingCartItems = new List<Track>();
        public static string Artist = string.Empty;

        
        public WebsiteMain()
        {
            InitializeComponent();
            lvShoppingCart.Columns.Add("Song");
            lvShoppingCart.Columns.Add("Price");
            lvShoppingCart.View = View.Details;
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            if (string.IsNullOrEmpty(txtArtist.Text)) return;
            
            //Artists by name
            var response = CallApi("/Artists/" + txtArtist.Text);
            var artistas = JObject.Parse(response);


            var artistsNames =
                from artist in artistas["ArtistsList"]
                select artist.ToString();

            lbArtists.DataSource = artistsNames.ToList();
        }

        private static string CallApi(string whatToGet)
        {
            var request = new RestRequest(whatToGet);
            var response = Client.Execute(request);

            return response.Content;
        }

        private void btnAddSongToOrder_Click(object sender, System.EventArgs e)
        {
            var song = new Track()
            {
                ArtisName = Artist,
                TrackName = lvSongs.SelectedItems[0].Text,
                PriceFormatted = lvSongs.SelectedItems[0].SubItems[1].Text
            };

            ShoppingCartItems.Add(song);

            string[] track = {song.TrackName, song.PriceFormatted};
            var item = new ListViewItem(track);
            lvShoppingCart.Items.Add(item);
        }

        private void lbArtists_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            Artist = lbArtists.SelectedItem.ToString();

            //Top Tracks by artist
            var response = CallApi("/TopTracks/" + lbArtists.SelectedItem);
            var songs = JObject.Parse(response);


            var trackNames =
                from track in songs["TracksList"]
                select new Track()
                {
                    ArtisName = (string) track["ArtisName"],
                    TrackName = (string) track["TrackName"],
                    Price = (double) track["Price"],
                    PriceFormatted = (string) track["PriceFormatted"]
                };

            lvSongs.Clear();
            lvSongs.View = View.Details;
            lvSongs.Columns.Add("Song");
            lvSongs.Columns.Add("Price");
           
            foreach (var trackName in trackNames)
            {
                string[] song = {trackName.TrackName, trackName.PriceFormatted};
                var item = new ListViewItem(song);
                lvSongs.Items.Add(item);
            }
        }
    }

    //public class teste
    //{
    //    public string musica;
    //    public string preco = "$0.99";

    //}

    //listView1.Columns.Add("Musica");
    //            listView1.Columns.Add("Preco");
    //            listView1.View = View.Details;

    //            foreach (var trackName in trackNames)
    //            {
    //                List<teste> teste = new List<teste>();
    //                var merda = new teste();
    //                merda.musica = trackName;
    //                teste.Add(merda);


    //                string[] row = { merda.musica, merda.preco };
    //                var listViewItem = new ListViewItem(row);
                    
    //                listView1.Items.Add(listViewItem);
    //            }
}

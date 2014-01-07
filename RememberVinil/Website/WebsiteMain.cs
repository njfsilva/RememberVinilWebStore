using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using BackOffice;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Text.RegularExpressions;

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
            lblTotal.Text = "0.00€";
            lblAddress.Visible = false;
            txtAddress.Visible = false;
            btnConfirmOrder.Visible = false;
            lb_Status2.DataSource = GetStatusList();
        }

        private void button1_Click(object sender, EventArgs e)
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

        private List<string> GetStatusList()
        {
            List<string> result = new List<string>();
            string response = CallApi("/RequestUpdate/u1");
            string[] array = response.Split('*');
            foreach (string pos in array)
            {
                result.Add(pos);
            }
            return result;
        }

        private static string CallApi(string whatToGet)
        {
            var request = new RestRequest(whatToGet);
            var response = Client.Execute(request);

            return response.Content;
        }

        private void btnAddSongToOrder_Click(object sender, EventArgs e)
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

            var songDouble = double.Parse(song.PriceFormatted.Replace("€", string.Empty));
            var previousTotal = double.Parse(lblTotal.Text.Replace("€", string.Empty));
            var total = songDouble + previousTotal;
            lblTotal.Text = total + "€";
        }

        private void lbArtists_SelectedIndexChanged(object sender, EventArgs e)
        {
            Artist = lbArtists.SelectedItem.ToString();

            //Top Tracks by artist
            var response = CallApi("/TopTracks/" + lbArtists.SelectedItem);
            //response = response.Replace("k__BackingField", "");

            var songs = JObject.Parse(response);

           

            var trackNames =
                from track in songs["TracksList"]
                select new Track()
                {
                    ArtisName = (string)track["ArtisName"],
                    TrackName = (string)track["TrackName"],
                    Price = (double)track["Price"],
                    PriceFormatted = (string)track["PriceFormatted"]
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

        private void btnFinishOrder_Click(object sender, EventArgs e)
        {
            lblAddress.Visible = !lblAddress.Visible;
            txtAddress.Visible = !txtAddress.Visible;
            btnConfirmOrder.Visible = !btnConfirmOrder.Visible;
        }

        private void btnConfirmOrder_Click(object sender, EventArgs e)
        {
            var request = new RestRequest("/RequestOrder/", Method.POST);

            var orderInfo = new OrderInfo
            {

                orderedTracks = ShoppingCartItems,
                morada = txtAddress.Text
            };

            var json = JsonConvert.SerializeObject(orderInfo);
            request.AddParameter("text/json", json, ParameterType.RequestBody);

            var response = Client.Execute(request);

            var res = JObject.Parse(response.Content);

            var sucesso = (string) res["status"];

            lbResultado.Text = sucesso;

        }
    }
}

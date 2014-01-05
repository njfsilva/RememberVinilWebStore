using System.Collections.Generic;
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

        public static List<string> ShoppingCartItems = new List<string>();
        public static string Artist = string.Empty;

        
        public WebsiteMain()
        {
            InitializeComponent();
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
            var selectSong = lbSongs.SelectedItem;

            ShoppingCartItems.Add(selectSong.ToString());

            lbShoppingCart.DataSource = null;
            lbShoppingCart.DataSource = ShoppingCartItems;
        }

        private void lbArtists_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            Artist = lbArtists.SelectedItem.ToString();

            //Top Tracks by artist
            var response = CallApi("/TopTracks/" + lbArtists.SelectedItem);
            var songs = JObject.Parse(response);


            var trackNames =
                from track in songs["TracksList"]
                select track.ToString();

            lbSongs.DataSource = null;
            lbSongs.DataSource = trackNames.ToList();
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

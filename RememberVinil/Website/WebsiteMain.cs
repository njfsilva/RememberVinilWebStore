using System.Linq;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using RestSharp;

namespace Website
{
    public partial class WebsiteMain : Form
    {
        private static readonly RestClient Client = new RestClient(BackOfficeServiceREST);
        public const string BackOfficeServiceREST = "http://localhost:9001/WebSiteService";

        public WebsiteMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, System.EventArgs e)
        {

            var response = CallApi("/Albums/" + txtArtist.Text);
            var albums = JObject.Parse(response);


            var albumNames =
                from album in albums["AlbumsList"]
                select album.ToString();

            lbAlbums.DataSource = albumNames.ToList();
        }

        private static string CallApi(string whatToGet)
        {
            var request = new RestRequest(whatToGet);
            var response = Client.Execute(request);

            return response.Content;
        }
    }
}

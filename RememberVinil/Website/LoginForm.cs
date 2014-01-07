using System.Threading;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using RestSharp;


namespace Website
{
    public partial class LoginForm : Form
    {
        private static readonly RestClient Client = new RestClient(BackOfficeServiceRest);
        public const string BackOfficeServiceRest = "http://localhost:9001/WebSiteService";

        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, System.EventArgs e)
        {
            var response = CallApi("/Login/" + txtUsername.Text);

            var user = JObject.Parse(response);

            var canAccess = (bool) user["HasPermissionToUseApplication"];

            if (canAccess)
            {

                var website = new WebsiteMain();
                website.Show();

            }

        }

        private static string CallApi(string whatToGet)
        {
            var request = new RestRequest(whatToGet);
           

            var response = Client.Execute(request);

            return response.Content;
        }
    }
}


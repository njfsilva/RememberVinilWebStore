using System.Collections.Generic;

namespace BackOffice
{
    class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string CallBackUrl { get; set; }
        public bool HasPermissionToChat { get; set; }
        public string UserId { get; set; }
        public string Name { get; set; }
        public string Adress { get; set; }
        public List<Order> ListaEncomendas = new List<Order>();

        public string TransportadoraId { get; set; }
        //public string TransportadoraStatus { get; set; }
        public string FabricaId { get; set; }
        //public string FabricaStatus { get; set; }

        public User(string clientId)
        {
            UserId = clientId;
        }

        public User(string username, string password)
        {
            Username = username;
            Password = password;
            HasPermissionToChat = false;
            CallBackUrl = string.Empty;
        }

        public string addOrder()
        {
            var o = new Order { orderID = ListaEncomendas.Count.ToString() };
            ListaEncomendas.Add(o);
            return o.orderID;
        }

        public void updateOrderStatus(string id, string status)
        {
            var ord= ListaEncomendas.Find(o => o.orderID.Equals(id));
            ord.status = status;
        }
    }

    class Order
    {
        public string orderID { get; set; }
        public string status { get; set; }
    }
}

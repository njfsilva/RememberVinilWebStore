using System.Collections.Generic;
using System.Globalization;

namespace BackOffice
{
    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string CallBackUrl { get; set; }
        public bool HasPermissionToUseApplication { get; set; }
        public string UserId { get; set; }
        public string Name { get; set; }
        public string Adress { get; set; }
        public List<OrderStatus> ListaEncomendas = new List<OrderStatus>();

        public string TransportadoraId { get; set; }
        //public string TransportadoraStatus { get; set; }
        public string FabricaId { get; set; }
        //public string FabricaStatus { get; set; }

        public User(string clientId)
        {
            UserId = clientId;
        }
        public User()
        {
        }

        //public User(string username, string password)
        //{
        //    Username = username;
        //    Password = password;
        //    System.Random rnd = new System.Random();
        //    UserId = Convert.ToString(rnd.Next(1, 100)); 
        //    HasPermissionToUseApplication = false;
        //    CallBackUrl = string.Empty;
        //}

        public User(string username, string password, string uid)
        {
            Username = username;
            Password = password;
            UserId = uid;
            HasPermissionToUseApplication = false;
            CallBackUrl = string.Empty;
        }

        public string AddOrder()
        {
            var o = new OrderStatus { OrderId = ListaEncomendas.Count.ToString(CultureInfo.InvariantCulture) };
            ListaEncomendas.Add(o);
            return o.OrderId;
        }

        public void UpdateOrderStatus(string id, string status)
        {
            var ord = ListaEncomendas.Find(o => o.OrderId.Equals(id));
            ord.Status = status;
        }

        public string GetLatestOrderStatus()
        {
            string resultado = string.Empty;
            foreach (var item in ListaEncomendas)
            {
                resultado += item.OrderId + " está " + item.Status;
                resultado += "*";
            }
            return resultado;
        }

    }

    public class OrderStatus
    {
        public string OrderId { get; set; }
        public string Status { get; set; }
    }
}

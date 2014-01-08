using System;
using System.Collections.Generic;

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

        public string addOrder()
        {
            var o = new OrderStatus { orderID = ListaEncomendas.Count.ToString() };
            ListaEncomendas.Add(o);
            return o.orderID;
        }

        public void updateOrderStatus(string id, string status)
        {
            var ord = ListaEncomendas.Find(o => o.orderID.Equals(id));
            ord.status = status;
        }

        public string getLatestOrderStatus()
        {
            string resultado = string.Empty;
            foreach (var item in ListaEncomendas)
            {
                resultado += item.orderID + " está " + item.status;
                resultado += "*";
            }
            return resultado;
        }

    }

    public class OrderStatus
    {
        public string orderID { get; set; }
        public string status { get; set; }
    }
}

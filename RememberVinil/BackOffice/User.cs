namespace BackOffice
{
    class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string CallBackUrl { get; set; }
        public bool HasPermissionToChat { get; set; }
        public string userID { get; set; }
        public string Name { get; set; }
        public string Adress { get; set; }
        public List<Order> ListaEncomendas { get; set; }

        public string TransportadoraId { get; set; }
        //public string TransportadoraStatus { get; set; }
        public string FabricaId { get; set; }
        //public string FabricaStatus { get; set; }

        public User(string clientId)
        {
            userID = clientId;
        }

        public User(string username, string password)
        {
            Username = username;
            Password = password;
            HasPermissionToChat = false;
            CallBackUrl = string.Empty;
        }
    }

    class Order
    {
        public string orderID { get; set; }
        public string status { get; set; }
    }
}

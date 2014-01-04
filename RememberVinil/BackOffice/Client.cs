namespace BackOffice
{
    class Client
    {
        public string ClientId { get; set; }
        public string Name { get; set; }
        public string Adress { get; set; }
        public string TransportadoraId { get; set; }

        public Client(string clientId)
        {
            ClientId = clientId;
        }
    }
}

namespace Transportadora
{
    public class TransportJobPriceRequest
    {
        public int id { get; set; }    
        public string DeliveryAdress { get; set; }
        public string fabrica { get; set; }
        public string WSCallback { get; set; }
        public string Distance { get; set; }
        public string userID { get; set; }
        public string encomendaID { get; set; }
    }
}

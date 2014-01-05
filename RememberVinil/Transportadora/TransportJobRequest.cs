namespace Transportadora
{
    public class TransportJobRequest
    {
        public int id { get; set; }    
        public string DeliveryAdress { get; set; }
        public string Status { get; set; }
        public string WSCallback { get; set; }   
    }
}

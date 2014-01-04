namespace Transportadora
{
    public class TransportJobResponse
    {
        public bool Sucess { get; set; }
        public string Status { get; set; }

        public TransportJobResponse()
        {
        }

        public TransportJobResponse(string status)
        {
            this.Status = status;
        }
    }
}

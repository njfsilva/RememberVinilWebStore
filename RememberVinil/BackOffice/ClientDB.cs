using System.Collections.Generic;

namespace BackOffice
{
    public class ClientDb
    {
        public static List<Client> DbBackOffice = new List<Client>();

        public static bool AddNewTransportJob(Client c)
        {
            DbBackOffice.Add(c);

            return true;
        }


        public static List<Client> GetClients()
        {
            return DbBackOffice;
        }

        public static string GetTransportIDbyClientId(string id)
        {
            foreach (var c in DbBackOffice)
            {
                if (c.ClientId == id)
                {
                    return c.TransportadoraId;
                }
            } 
            return "";
        }
    }
}

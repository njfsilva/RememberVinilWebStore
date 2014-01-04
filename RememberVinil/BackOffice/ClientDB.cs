using System.Collections.Generic;

namespace BackOffice
{
    class ClientDB
    {
        static List<Client> DbBackOffice = new List<Client>();

        public static bool AddNewTransportJob(Client c)
        {
            DbBackOffice.Add(c);

            return true;
        }


        public static List<Client> GetClients()
        {
            return DbBackOffice;
        }

        public static string GetTransportIDbyClientID(string id)
        {
            foreach (Client c in DbBackOffice)
            {
                if (c.ClientID == id)
                {
                    return c.TransportadoraID;
                }
            } 
            return "";
        }
    }
}

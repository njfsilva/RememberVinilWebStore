using System.Collections.Generic;

namespace BackOffice
{
    public interface IAdapterFabricantes
    {
        double getPrice(List<Track> list);

        //string setOrder(List<Track> list);
    }
}

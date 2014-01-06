using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BackOffice
{
    public interface IAdapterFabricantes
    {
        double getPrice(List<Track> list);

        //string setOrder(List<Track> list);
    }
}

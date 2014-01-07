using System.Collections.Generic;

namespace BackOffice
{
    public interface IAdapterFabricantes
    {
        FabricantePriceResponse getPrice(List<Track> list);

        ObjectMakeCDResponse setOrder(List<Track> list);
    }
}

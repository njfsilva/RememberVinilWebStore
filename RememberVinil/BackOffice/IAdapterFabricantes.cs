﻿using System.Collections.Generic;

namespace BackOffice
{
    public interface IAdapterFabricantes
    {
        FabricantePriceResponse getPrice(OrderInfo order);

        ObjectMakeCDResponse setOrder(OrderInfo order);
    }
}

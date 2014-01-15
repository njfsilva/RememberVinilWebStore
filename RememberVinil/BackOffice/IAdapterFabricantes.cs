namespace BackOffice
{
    public interface IAdapterFabricantes
    {
        FabricantePriceResponse GetPrice(OrderInfo order);

        ObjectMakeCdResponse SetOrder(OrderInfo order);
    }
}

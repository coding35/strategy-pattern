namespace Model.Product.Behavior.Deliver;

public class DeliverAsDropShipment : IDeliveryBehavior
{
    public void Deliver()
    {
        Console.WriteLine("Deliver the product by drop shipment");
    }
}
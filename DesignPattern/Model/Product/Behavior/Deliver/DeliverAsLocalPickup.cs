namespace Model.Product.Behavior;

public class DeliverAsLocalPickup : IDeliveryBehavior
{
    public void Deliver()
    {
        Console.WriteLine("Deliver the product by pickup");
    }
}

namespace Model.Product.Behavior.Deliver;

public class DeliverAsParcel : IDeliveryBehavior
{
    public void Deliver()
    {
        Console.WriteLine("Deliver the product by parcel post");
    }
}
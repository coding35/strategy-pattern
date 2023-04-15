namespace Model.Product.Behavior;

public class DeliverAsDownload : IDeliveryBehavior
{
    public void Deliver()
    {
        Console.WriteLine("Deliver the product by download");
    }
}
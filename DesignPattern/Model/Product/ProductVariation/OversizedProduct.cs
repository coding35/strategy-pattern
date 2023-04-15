using Model.Product.Behavior.Deliver;
using Model.Product.Behavior.Tax;

namespace Model.Product.ProductVariation;

public class OversizedProduct : Product
{
    public OversizedProduct() : base(new DeliverAsParcel(), new Taxable())
    {
    }

    public override void Display()
    {
        Console.WriteLine("Displaying local pickup product");
    }
}
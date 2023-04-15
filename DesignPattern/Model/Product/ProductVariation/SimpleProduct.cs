using Model.Product.Behavior;
using Model.Product.Behavior.Deliver;
using Model.Product.Behavior.Tax;

namespace Model.Product.ProductVariation;

public class SimpleProduct : Product
{
    public SimpleProduct() : base(new DeliverAsParcel(), new Taxable())
    {
    }

    public override void Display()
    {
        Console.WriteLine("Displaying simple product");
    }
}
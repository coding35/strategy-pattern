using Model.Product.Behavior;
using Model.Product.Behavior.Deliver;
using Model.Product.Behavior.Tax;

namespace Model.Product;

public class ModelProduct : Product
{
    public ModelProduct() : base(new DeliverAsParcel(), new Taxable())
    {
    }

    public override void Display()
    {
        Console.WriteLine("Displaying model product");
    }
}
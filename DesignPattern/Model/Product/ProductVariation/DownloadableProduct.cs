using Model.Product.Behavior;
using Model.Product.Behavior.Deliver;
using Model.Product.Behavior.Tax;

namespace Model.Product.ProductVariation;

public class DownloadableProduct : Product
{
    public DownloadableProduct() : base(new DeliverAsParcel(), new Taxable())
    {
    }

    public override void Display()
    {
        Console.WriteLine("Displaying downloadable product");
    }
}
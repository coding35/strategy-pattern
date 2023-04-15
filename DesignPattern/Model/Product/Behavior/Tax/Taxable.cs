namespace Model.Product.Behavior.Tax;

public class Taxable : ITaxableBehavior
{
    public void Tax()
    {
        Console.WriteLine("Tax the product");
    }
}

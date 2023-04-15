namespace Model.Product.Behavior.Tax;

public class NonTaxable : ITaxableBehavior
{
    public void Tax()
    {
        Console.WriteLine("Do not tax the product");
    }
}
using Model.Product.Behavior;

namespace Model.Product;

public abstract class Product
{
    private IDeliveryBehavior _deliveryBehavior;
    private ITaxableBehavior _taxableBehavior;

    protected Product(IDeliveryBehavior deliveryBehavior, ITaxableBehavior taxableBehavior)
    {
        _deliveryBehavior = deliveryBehavior;
        _taxableBehavior = taxableBehavior;
    }
    
    public abstract void Display();
    
    public void GetDeliveryBehavior()
    {
        _deliveryBehavior.Deliver();
    }
    
    public void SetDeliveryBehavior(IDeliveryBehavior deliveryBehavior)
    {
        _deliveryBehavior = deliveryBehavior;
    }
    
    public void GetTaxableBehavior()
    {
        _taxableBehavior.Tax();
    }
    
    public void SetTaxableBehavior(ITaxableBehavior taxableBehavior)
    {
        _taxableBehavior = taxableBehavior;
    }
    
    public void CheckInventory()
    {
        Console.WriteLine("Checking inventory...");
    }
}


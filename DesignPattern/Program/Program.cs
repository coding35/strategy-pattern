using Model.Product;
using Model.Product.Behavior.Deliver;


Product model = new ModelProduct();
model.SetDeliveryBehavior(new DeliverAsDropShipment());
model.GetDeliveryBehavior();
model.GetTaxableBehavior();
model.CheckInventory();
model.Display();

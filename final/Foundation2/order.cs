class Order
{
    private Customer _customer;
    private List<Product> _products;
    //private string _shippingLable;
    //private string _packingLable;
    private const decimal _ShippingCostUSA = 5.00m;
    private const decimal _shippingCostOther = 35.00m;

    public Order(Customer customer, List<Product> products)
    {
        _customer = customer;
        _products = products;
        //_shippingLable = shippingLable;
        //_packingLable = packingLable;
        
    }
    public decimal TotalPrice()
    {
        decimal productTotal = 0m;
        foreach (Product product in _products)
        {
            productTotal += product.TotalCost();
        }

        decimal shippingCost;
        if (_customer.USA())
        {
            shippingCost = _ShippingCostUSA;
        }
        else
        {
            shippingCost = _shippingCostOther;
        }
        return productTotal + shippingCost;
    }

    // public string GetPackingLabel()
    // {
    //     String label += Product.GetName()+"(ID:"+Product.GetProductID()+")\n";
    //     return label;
    // }
public string GetPackingLabel()
{
    string label = "";
    foreach (Product product in _products)
    {
        label += product.GetName() + " (ID:" + product.GetProductID() + ")\n";
    }
    return label;
}
    // public string GetShippingLabel()
    // {
    //     string label = ($"shipping label:\n {orderCustomer.GetName()}");
    //     return label;
    // }
    public string GetShippingLabel()
{
    string label = $"Shipping Label:\n{_customer.GetName()}\n{_customer.GetAddress()}";
    return label;
}
}
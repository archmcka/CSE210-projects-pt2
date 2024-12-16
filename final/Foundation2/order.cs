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

        int shippingCost;
        if (_customer.USA())
        {
            shippingCost = _ShippingCostUSA;
        }
        else
        {
            shippingCost = _shippingCostOther;
        }
        return ProductTotal + shippingCost;
    }

    public string GetPackingLabel()
    {
        label += product.GetName()+"(ID:"+product.GetID()+")\n";
        return label;
    }
    public string GetShippingLabel()
    {
        string label = ($"shipping label:\n {orderCustomer.GetName()}");
        return label;
    }
}
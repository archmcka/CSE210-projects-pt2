class Product
{
    private string _name;
    private string _productID;
    private decimal _price;
    private int _quantity;

    public Product(string name, string productID, decimal price, int quantity)
    {
        _name = name;
        _productID = productID;
        _price = price;
        _quantity = quantity;
    }   
    public string GetProductID()
    {
        return _productID;
    }
    public string GetName()
    {
        return _name;
    }
    public decimal GetTotalCost()
    {
        int TotalCost = _price * _quantity;
        return TotalCost;
    }

    
}
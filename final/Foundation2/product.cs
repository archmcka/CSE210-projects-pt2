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
/*************  ✨ Codeium Command ⭐  *************/
    /// <summary>
    /// Gets the product ID.
    /// </summary>
    /// <returns>The product ID.</returns>
/******  ad4eb58e-5128-47f9-ad80-6b712d51cf8a  *******/
    public string GetProductID()
    {
        return _productID;
    }
    public string GetName()
    {
        return _name;
    }
        public decimal TotalCost()
    {
         decimal totalCost = _price * _quantity;
        return totalCost;
    }
}
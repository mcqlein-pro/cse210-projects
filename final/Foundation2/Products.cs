class Product
{
    public string _productName;
    public string _productId;
    public double _price;
    public int _quantity;

    public Product(string productName, string productId, double price, int quantity)
    {
        _productName = productName;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }
}

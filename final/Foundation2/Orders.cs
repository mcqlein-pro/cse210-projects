using System.Collections.Generic;

class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public double GetTotalPrice()
    {
        double totalPrice = 0;
        foreach (Product product in _products)
        {
            totalPrice += product._price * product._quantity;
        }
        totalPrice += _customer.IsInUSA() ? 5 : 35; // Shipping cost
        return totalPrice;
    }

    public string GetPackingLabel()
    {
        string packingLabel = "";
        foreach (Product product in _products)
        {
            packingLabel += "Name: " + product._productName + ", Product ID: " + product._productId + "\n";
        }
        return packingLabel;
    }

    public string GetShippingLabel()
    {
        return "Name: " + _customer._name + "\n" + _customer._address.GetAddressString();
    }
}

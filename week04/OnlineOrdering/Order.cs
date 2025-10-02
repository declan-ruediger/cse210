public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public float GetCostTotal()
    {
        float shippingCost;

        if (_customer.LivesInUSA())
        {
            shippingCost = 5;
        }
        else
        {
            shippingCost = 35;
        }

        float costOfProducts = 0;

        foreach (Product product in _products)
        {
            costOfProducts += product.GetCost();
        }

        float totalCost = costOfProducts + shippingCost;
        return totalCost;
    }

    public string GetPackingLabel()
    {
        string packingLabel = "";
        foreach (Product product in _products)
        {
            packingLabel += $"{product.GetDisplayText()}\n";
        }
        // Remove last unnecessary newline
        packingLabel = packingLabel.Substring(0, packingLabel.Length - 1);

        return packingLabel;
    }

    public string GetShippingLabel()
    {
        return _customer.GetDisplayText();
    }
}
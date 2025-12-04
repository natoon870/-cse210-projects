using System.Text;
public class Order
{
    
    private Customer _customer;
    private List<Product> _products;
        public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public double TotalCost()
    {
        double subtotal = 0;

        foreach (Product product in _products)
        {
            subtotal += product.TotalCost();
        }

        double shipping = _customer.LivesInUSA() ? 5.0 : 35.0;

        return subtotal + shipping;
    }

    public string PackingLabel()
{
    string label = "";

    foreach (Product product in _products)
    {
        label += product.DisplayProductInfo() + "\n";
    }

    return label;
}

    public string ShippingLabel()
    {
        return _customer.ShippingLabel();
    }
}
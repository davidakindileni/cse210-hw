using System;

class Program
{
    static void Initialize(List<Order> orders)
    {
        List<Product> products = new List<Product>(); Customer customer;
        Address address; Product product; Order order;
        address = new Address("2 Fawnbrake Avenue", "Gainesborough", "IL", "USA");
        customer = new Customer("Evelyn Bucket", address);
        product = new Product("Heads and Shoulders", "SQ4576898", 12.99, 2);
        products.Add(product);
        product = new Product("Styling Heat Comb", "LK9096574", 19.45, 1);
        products.Add(product);
        product = new Product("Vyes Saint Laurent Hair Spray", "QG0238467", 8.25, 2);
        products.Add(product);
        order = new Order(products, customer);

        orders.Add(order);
        products = new List<Product>();
        address = new Address("Flat 7, House 2", "Stockwell", "London SE8 4QS", "England");
        customer = new Customer("Mark Lantern", address);
        product = new Product("Air Bugatti Evo 4 Sofa", "JS7349934", 475.89, 1);
        products.Add(product);
        product = new Product("IKEA sofa cushions ", "BC8671209", 4.82, 7);
        products.Add(product);
        product = new Product("Rotary Center Table", "PX7239647", 78.23, 1);
        products.Add(product);
        order = new Order(products, customer);

        orders.Add(order);
    }
    static void Main(string[] args)
    {
        List<Order> orders = new List<Order>();
        Initialize(orders);
        foreach (Order order in orders)
        {
            Console.WriteLine("Packing Label");
            Console.WriteLine(order.PackingLabel());
            Console.WriteLine("Shipping Label");
            Console.WriteLine(order.ShippingLabel());
            Console.WriteLine();
            Console.WriteLine($"Shipping Price: ${order.GetShippingPrice()}.00");
            Console.WriteLine($"Total Price: ${Math.Round(order.CalcTotalPrice(), 2)}\n");
        }
    }
}
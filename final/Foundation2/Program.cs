using System;

class Program
{
    static void Main(string[] args)
    {
       
        Address address1 = new Address("345 Pebblestone St", "Boise", "ID", "USA");
        Customer customer1 = new Customer("Nathan Taylor", address1);
        Order order1 = new Order(customer1);

        order1.AddProduct(new Product("Airpods", "B0FG01", 199.99, 1));
        order1.AddProduct(new Product("Pillow", "G20HA0", 29.99, 2));

        Address address2 = new Address("223 Croissant Dr", "Paris", "Île-de-France", "France");
        Customer customer2 = new Customer("Paul Pogba", address2);
        Order order2 = new Order(customer2);

        order2.AddProduct(new Product("Soccer Cleats", "C4HF00", 220.00, 1));
        order2.AddProduct(new Product("Laptop", "H1FD23", 499.99, 1));
        order2.AddProduct(new Product("Pens", "N2JG20", 4.99, 8));

        Console.WriteLine("===== ORDER 1 =====");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order1.PackingLabel());
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order1.ShippingLabel());
        Console.WriteLine($"Total Price: ${order1.TotalCost():0.00}\n");

        Console.WriteLine("===== ORDER 2 =====");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order2.PackingLabel());
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order2.ShippingLabel());
        Console.WriteLine($"Total Price: ${order2.TotalCost():0.00}");
    }
}
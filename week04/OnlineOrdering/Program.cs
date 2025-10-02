using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("3 Smith Rd", "Treeville", "Auckland", "New Zealand");
        Customer customer1 = new Customer("Whanae Smith", address1);
        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Paper", 3456, 4.56f, 56));
        order1.AddProduct(new Product("Pens", 3457, 2.11f, 14));

        Address address2 = new Address("7 Smith Rd", "Treeville", "Auckland", "New Zealand");
        Customer customer2 = new Customer("George Smith", address2);
        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Cheese", 1233, 10.11f, 2));
        order2.AddProduct(new Product("Eggs", 1456, 1.00f, 14));

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine();
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine();
        Console.WriteLine($"Total Cost: ${order1.GetCostTotal()}");
        Console.WriteLine();
        Console.WriteLine();

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine();
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine();
        Console.WriteLine($"Total Cost: ${order2.GetCostTotal()}");

    }
}
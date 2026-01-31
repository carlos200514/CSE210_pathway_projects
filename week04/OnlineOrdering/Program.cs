using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("OnlineOrdering Project.");
        Console.WriteLine();

        Address address1 = new Address(
            "123 Main Street",
            "New York",
            "NY",
            "USA"
        );
        Customer customer1 = new Customer("John Smith", address1);
        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Laptop", "P1001", 900.00, 1));
        order1.AddProduct(new Product("Mouse", "P1002", 25.00, 2));
        Console.WriteLine("========== ORDER 1 ==========");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine("Total Price: $" + order1.GetTotalPrice());
        Console.WriteLine();

        Address address2 = new Address(
            "55 King Road",
            "Toronto",
            "Ontario",
            "Canada"
        );
        Customer customer2 = new Customer("Emily Johnson", address2);
        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Headphones", "P2001", 80.00, 1));
        order2.AddProduct(new Product("Keyboard", "P2002", 45.00, 1));
        order2.AddProduct(new Product("USB Cable", "P2003", 10.00, 3));
        Console.WriteLine("========== ORDER 2 ==========");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine("Total Price: $" + order2.GetTotalPrice());
    }
}
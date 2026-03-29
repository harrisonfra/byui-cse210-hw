using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("1700 Mountain View dr", "Lyman", "WY", "USA");
        //this is not a real address, but I lived close to here for four transfers on my mission.
        Customer customer1 = new Customer("Elder Fraser", address1);

        Product product1 = new Product("Instant Pot", "IP1", 100, 1);
        Product product2 = new Product("Book of Mormon", "BOM1", 1, 20);

        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total: ${order1.GetTotalCost()}");
        Console.WriteLine();

        Address address2 = new Address("100 Main Street", "Preston", "Lancashire", "England");
        Customer customer2 = new Customer("Heber C. Kimball", address2);

        Product product3 = new Product("Keyboard", "KB1", 50, 1);
        Product product4 = new Product("Monitor", "MN1", 200, 1);
        Product product5 = new Product("Gaming PC", "PC1", 2500, 1);

        Order order2 = new Order(customer2);
        order2.AddProduct(product3);
        order2.AddProduct(product4);
        order2.AddProduct(product5);

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total: ${order2.GetTotalCost()}");

    }
}
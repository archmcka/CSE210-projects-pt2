using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Address address1= new Address("2665 sagebrush ave", "iona","ID","USA");
        Address address2= new Address("1234 glock st", "Ammon","ID","USA");

        Customer customer1= new Customer("Ashlynn Archibald",address1);
        Customer customer2= new Customer("David Andrus",address2);

        Product product1= new Product("red rider BB-gun","GUN1234", 99.99m,1);
        Product product2= new Product("luminary gel","Nail4564", 8.99m,1);
        Product product3= new Product("springfeild echelon","GUN0707", 799.99m,1);
        Product product4= new Product("breast pump","BOOB8008", 79.99m,1);

        List<Product> order1Products = new List<Product>{product1,product2};
        Order order1= new Order(customer1,order1Products);

        List<Product> order2Products = new List<Product>{product3,product4};
        Order order2= new Order(customer2,order2Products);

        Console.WriteLine($"order 1 total: {order1.TotalPrice()} packing lable: {order1.GetPackingLabel()} shipping label:{ order1.GetShippingLabel()}");
        Console.WriteLine($"order 2 total: {order2.TotalPrice()} packing lable: {order2.GetPackingLabel()} shipping label:{ order2.GetShippingLabel()}");
    }
}
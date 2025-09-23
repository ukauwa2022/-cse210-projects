using System;
using System.Collections.Generic;

// =======================
// Product Class
// =======================
public class Product
{
    private string name;
    private string productId;
    private double price;
    private int quantity;

    public Product(string name, string productId, double price, int quantity)
    {
        this.name = name;
        this.productId = productId;
        this.price = price;
        this.quantity = quantity;
    }

    public double GetTotalCost()
    {
        return price * quantity;
    }

    public string GetPackingInfo()
    {
        return $"{name} (ID: {productId})";
    }
}

// =======================
// Address Class
// =======================
public class Address
{
    private string street;
    private string city;
    private string state;
    private string country;

    public Address(string street, string city, string state, string country)
    {
        this.street = street;
        this.city = city;
        this.state = state;
        this.country = country;
    }

    public bool IsInUSA()
    {
        return country.Trim().ToUpper() == "USA";
    }

    public string GetFullAddress()
    {
        return $"{street}\n{city}, {state}\n{country}";
    }
}

// =======================
// Customer Class
// =======================
public class Customer
{
    private string name;
    private Address address;

    public Customer(string name, Address address)
    {
        this.name = name;
        this.address = address;
    }

    public bool LivesInUSA()
    {
        return address.IsInUSA();
    }

    public string GetShippingLabel()
    {
        return $"{name}\n{address.GetFullAddress()}";
    }
}

// =======================
// Order Class
// =======================
public class Order
{
    private List<Product> products = new List<Product>();
    private Customer customer;

    public Order(Customer customer)
    {
        this.customer = customer;
    }

    public void AddProduct(Product product)
    {
        products.Add(product);
    }

    public double GetTotalPrice()
    {
        double total = 0;
        foreach (var product in products)
        {
            total += product.GetTotalCost();
        }

        // Add shipping cost
        if (customer.LivesInUSA())
            total += 5;
        else
            total += 35;

        return total;
    }

    public string GetPackingLabel()
    {
        string label = "Packing Label:\n";
        foreach (var product in products)
        {
            label += product.GetPackingInfo() + "\n";
        }
        return label;
    }

    public string GetShippingLabel()
    {
        return "Shipping Label:\n" + customer.GetShippingLabel();
    }
}

// =======================
// Program Class (Main)
// =======================
public class Program
{
    public static void Main(string[] args)
    {
        // Customer 1 (USA)
        Address address1 = new Address("123 Main St", "New York", "NY", "USA");
        Customer customer1 = new Customer("John Doe", address1);
        Order order1 = new Order(customer1);

        order1.AddProduct(new Product("Laptop", "P001", 1000, 1));
        order1.AddProduct(new Product("Mouse", "P002", 25, 2));

        // Customer 2 (International)
        Address address2 = new Address("45 Oxford St", "London", "England", "UK");
        Customer customer2 = new Customer("Mary Smith", address2);
        Order order2 = new Order(customer2);

        order2.AddProduct(new Product("Tablet", "P003", 500, 1));
        order2.AddProduct(new Product("Keyboard", "P004", 50, 1));
        order2.AddProduct(new Product("Headphones", "P005", 75, 2));

        // Display results
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine("Total Price: $" + order1.GetTotalPrice());
        Console.WriteLine();

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine("Total Price: $" + order2.GetTotalPrice());
    }
}

// LINQ and Lambda Expression Practice with Product Data

using LINQ_and_Lambda_Expression_Practice;
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        // Create a list of sample products
        List<Product> products = new List<Product>
        {
            new Product{ Id = 1, Name = "Laptop", Price = 999.99},
            new Product{ Id = 2, Name = "Smartphone", Price = 499.99},
            new Product{ Id = 3, Name = "Tablet", Price = 299.99},
            new Product{ Id = 4, Name = "Headphones", Price = 79.99},
            new Product{ Id = 5, Name = "Mouse", Price = 19.99},
        };

        // Exercise 1: Filter products with a price less than 100
        var cheapProducts = products.Where(product => product.Price < 100);
        Console.WriteLine("Cheap product:");
        foreach (var product in cheapProducts)
        {
            Console.WriteLine(product.Name);
        }

        // Exercise 2: Project product names
        var productNames = products.Select(product => product.Name);
        Console.WriteLine("\nProduct Names:");
        foreach (var name in productNames)
        {
            Console.WriteLine(name);
        }

        // Exercise 3: Order products by price in ascending order
        var orderedProducts = products.OrderBy(product => product.Price);
        Console.WriteLine("\nOrdered Products (Ascending):");
        foreach (var product in orderedProducts)
        {
            Console.WriteLine($"{product.Name} - {product.Price}");
        }

        // Exercise 4: Calculate the total price of all products
        var totalPrice = products.Sum(product => product.Price);
        Console.WriteLine($"\nTotal Price of All Products: {totalPrice}");

        // Exercise 5: Find the most expensive product
        var mostExpensiveProduct = products.OrderByDescending(product => product.Price).First();
        Console.WriteLine($"\nMost Expensive Product: {mostExpensiveProduct.Name} - {mostExpensiveProduct.Price}");
    }
}
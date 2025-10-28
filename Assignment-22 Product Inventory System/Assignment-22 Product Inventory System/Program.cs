using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace Assignment_22_Product_Inventory_System
{

    /// <summary>
    /// Represents a product in the inventory.
    /// </summary>
    class Product
    {
        public string Name { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }

        public Product(string name, int quantity, double price)
        {
            Name = name;
            Quantity = quantity;
            Price = price;
        }
    }

    /// <summary>
    /// Manages inventory operations such as adding, viewing, and saving products.
    /// </summary>
    class ProductInventorySystem
    {
        private List<Product> products = new List<Product>();
        private string filePath = "inventory.json";

        // Add new product
        public void AddProduct(Product product)
        {
            products.Add(product);
            Console.WriteLine(" Product added successfully!");
        }

        // Display all products
        public void DisplayProducts()
        {
            if (products.Count == 0)
            {
                Console.WriteLine("No products found in inventory.");
                return;
            }

            Console.WriteLine("\n  Product Inventory ");
            foreach (var p in products)
            {
                Console.WriteLine($"Name: {p.Name}, Quantity: {p.Quantity}, Price: Rs.{p.Price}");
            }
        }

        // Save products to JSON file
        public void SaveToJson()
        {
            string jsonData = JsonSerializer.Serialize(products, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(filePath, jsonData);
            Console.WriteLine($"\n Inventory saved to {filePath}");
        }

        // Load products from JSON file
        public void LoadFromJson()
        {
            if (!File.Exists(filePath))
            {
                Console.WriteLine("No saved data found. Starting with an empty inventory.");
                return;
            }

            string jsonData = File.ReadAllText(filePath);
            products = JsonSerializer.Deserialize<List<Product>>(jsonData);
            Console.WriteLine(" Inventory loaded successfully!");
        }
    }

    /// <summary>
    /// Entry point for the Product Inventory System.
    /// </summary>
    class Program
    {
        static void Main()
        {
            ProductInventorySystem inventory = new ProductInventorySystem();
            inventory.LoadFromJson(); // Load previous data if available
            int choice;

            do
            {
                Console.WriteLine("\n PRODUCT INVENTORY SYSTEM ");
                Console.WriteLine("1. Add Product");
                Console.WriteLine("2. Display Products");
                Console.WriteLine("3. Save to JSON");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice: ");

                if (!int.TryParse(Console.ReadLine(), out choice)) choice = 0;

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter product name: ");
                        string name = Console.ReadLine();

                        Console.Write("Enter quantity: ");
                        int quantity = int.Parse(Console.ReadLine());

                        Console.Write("Enter price (in Rs): ");
                        double price = double.Parse(Console.ReadLine());

                        inventory.AddProduct(new Product(name, quantity, price));
                        break;

                    case 2:
                        inventory.DisplayProducts();
                        break;

                    case 3:
                        inventory.SaveToJson();
                        break;

                    case 4:
                        Console.WriteLine("Exiting program...");
                        break;

                    default:
                        Console.WriteLine("Invalid choice! Try again.");
                        break;
                }

            } while (choice != 4);
        }
    }
}

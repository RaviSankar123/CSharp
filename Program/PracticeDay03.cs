/*
In this assignment, you will create a basic inventory management system using C#. You will define an array to store product information and implement functionalities to add, view, and update product records.

Task:

Define Product Structure:
Create a struct named Product to represent products.
Add fields to the struct: Name (string type), Price (decimal type), and Quantity (integer type).
Initialize Product Array:
Create an array of Product structs to store product information.
Define the array size based on the maximum number of products that can be stored in the inventory.
Implement Menu Options:
Display a menu with options to add a new product, view all products, and update product details.
Use a switch statement to handle user input and perform corresponding actions.
Input Handling:
Prompt the user to enter product details (name, price, quantity) when adding a new product.
Convert the user input for price and quantity to their respective data types.
Perform Operations:
Add a new product to the inventory when the user selects the "Add Product" option.
View all products in the inventory when the user selects the "View Products" option.
Update product details (price or quantity) when the user selects the "Update Product" option.
Instructions:

Write the C# code to implement the inventory management system as described above.
Ensure that the menu options are clearly displayed and user-friendly.
Test your program by adding, viewing, and updating product records to verify its functionality.
Document your code with appropriate comments to explain its purpose and functionality.
Submission:

Submit the C# code file (.cs) containing the implementation of the inventory management system.
Include any additional instructions or notes if necessary.
*/

using System;

struct Product
{
    public string Name;
    public decimal Price;
    public int Quantity;

    public Product(string name, decimal price, int quantity)
    {
        this.Name = name;
        this.Price = price;
        this.Quantity = quantity;
    }
}

class Program
{
    static void Main(string[] args)
    {
        int maxProducts = 10; // Set a reasonable default limit
        Product[] products = new Product[maxProducts];
        int productCount = 0;

        while (true)
        {
            Console.Write("1. Add Product\n2. View Products\n3. Update Product\n4. Exit\nEnter your choice: ");
            string choice = Console.ReadLine()?.Trim();

            switch (choice)
            {
                case "1":
                    if (productCount < maxProducts)
                    {
                        Console.Write("Enter product name: ");
                        string name = Console.ReadLine()?.Trim();

                        Console.Write("Enter product price: ");
                        if (!decimal.TryParse(Console.ReadLine(), out decimal price) || price < 0)
                        {
                            continue; // Ignore invalid input
                        }

                        Console.Write("Enter product quantity: ");
                        if (!int.TryParse(Console.ReadLine(), out int quantity) || quantity < 0)
                        {
                            continue; // Ignore invalid input
                        }

                        products[productCount] = new Product(name, price, quantity);
                        productCount++;

                        Console.Write("Product added successfully!\n");
                    }
                    break;

                case "2":
                    for (int i = 0; i < productCount; i++)
                    {
                        Console.Write($"Name: {products[i].Name}, Price: {products[i].Price:F1}, Quantity: {products[i].Quantity}\n");
                    }
                    break;

                case "3":
                    Console.Write("Enter product name to update: ");
                    string updateName = Console.ReadLine()?.Trim();
                    bool found = false;

                    for (int i = 0; i < productCount; i++)
                    {
                        if (products[i].Name.Equals(updateName, StringComparison.OrdinalIgnoreCase))
                        {
                            found = true;

                            Console.Write("Enter new price: ");
                            if (!decimal.TryParse(Console.ReadLine(), out products[i].Price) || products[i].Price < 0)
                            {
                                continue;
                            }

                            Console.Write("Enter new quantity: ");
                            if (!int.TryParse(Console.ReadLine(), out products[i].Quantity) || products[i].Quantity < 0)
                            {
                                continue;
                            }

                            Console.Write("Product updated successfully!\n");
                            break;
                        }
                    }
                    break;

                case "4":
                    return; // Exit the program

                default:
                    break; // Ignore invalid choices
            }
        }
    }
}

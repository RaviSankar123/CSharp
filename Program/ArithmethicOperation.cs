using System;

class Program
{
    static void Main(string[] args)
    {
        // Prompt the user to enter the first number
        Console.WriteLine("Enter the first number:");
        int num1;
        // Ensure the input is a valid integer
        while (!int.TryParse(Console.ReadLine(), out num1))
        {
            Console.WriteLine("Invalid input. Please enter a valid integer:");
        }

        // Prompt the user to enter the second number
        Console.WriteLine("Enter the second number:");
        int num2;
        // Ensure the input is a valid integer
        while (!int.TryParse(Console.ReadLine(), out num2))
        {
            Console.WriteLine("Invalid input. Please enter a valid integer:");
        }

        // Perform arithmetic operations

        // Declare variables for results
        int sum = num1 + num2;
        int difference = num1 - num2;
        int product = num1 * num2;
        double quotient = 0;
        bool divisionByZero = false;

        // Handle division by zero
        if (num2 != 0)
        {
            quotient = (double)num1 / num2;
        }
        else
        {
            divisionByZero = true;
        }

        // Print the results of the operations
        Console.WriteLine("The sum is: " + sum);
        Console.WriteLine("The difference is: " + difference);
        Console.WriteLine("The product is: " + product);
        
        // Handle division result based on division by zero
        if (!divisionByZero)
        {
            Console.WriteLine("The quotient is: " + quotient);
        }
        else
        {
            Console.WriteLine("Error: Division by zero is not allowed.");
        }
    }
}

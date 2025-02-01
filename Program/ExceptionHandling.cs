using System;
using System.IO; // Required for FileNotFoundException

public class Program
{
    public static void Main(string[] args)
    {
        if (args.Length == 0)
        {
            Console.WriteLine("Please provide an exception type (IndexOutOfRangeException, DivideByZeroException, FileNotFoundException).");
            return;
        }

        try
        {
            // Call appropriate function based on input
            if (args[0] == "IndexOutOfRangeException")
            {
                CauseIndexOutOfRangeException();
            }
            else if (args[0] == "DivideByZeroException")
            {
                CauseDivideByZeroException();
            }
            else if (args[0] == "FileNotFoundException")
            {
                CauseFileNotFoundException();
            }
            else
            {
                Console.WriteLine("Unknown exception type provided.");
            }
        }
        catch (IndexOutOfRangeException ex)
        {
            Console.WriteLine("Index out of range error: " + ex.Message);
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("Divide by zero error: " + ex.Message);
        }
        catch (FileNotFoundException ex)
        {
            Console.WriteLine("File error: " + ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("An unexpected error occurred: " + ex.Message);
        }
    }

    // Method to trigger IndexOutOfRangeException
    static void CauseIndexOutOfRangeException()
    {
        int[] numbers = { 1, 2, 3 };
        Console.WriteLine(numbers[5]); // Accessing an invalid index
    }

    // Method to trigger DivideByZeroException
    static void CauseDivideByZeroException()
    {
        int num = 10;
        int result = num / 0; // Division by zero
        Console.WriteLine(result);
    }

    // Method to trigger FileNotFoundException
    static void CauseFileNotFoundException()
    {
        throw new FileNotFoundException("The specified file was not found.");
    }
}

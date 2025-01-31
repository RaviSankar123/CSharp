using System;

public class Collections
{
    public string Name; // Moved outside Main()

    public void CreateEmployee()
    {
        // Non-generic type
        object a = 10;
        int x = (int)a;  // Type casting
        object b = "ravi";
        object c = true;

        // Generic type
        int value = 20;
        string y = "sankar";
        bool z = true;

        // Output
        Console.WriteLine(a);
        Console.WriteLine(x);
        Console.WriteLine(b);
        Console.WriteLine(c);
        Console.WriteLine(value);
        Console.WriteLine(y);
        Console.WriteLine(z);
    }
}

public class CollectionExample
{
    public static void Main(string[] args)
    {
        Collections c = new Collections();
        c.CreateEmployee();
    }
}

using System;

public class Employee{
    public void CreateEmployee<T>(T value)//Generic
    {
        Console.WriteLine(value);
    }
}

public class GenericCollections{
    public static void Main(String[] args){
        Employee employee = new Employee();
        employee.CreateEmployee<int>(10);
        employee.CreateEmployee<string>("ravisankar");
        employee.CreateEmployee<bool>(true);
    }
}
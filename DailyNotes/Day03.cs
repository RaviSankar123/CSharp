/*
Create a C# program that implements an abstract class Animal
that has a Name property of type text and three methods SetName (string name),
GetName and Eat. The Eat method will be an abstract method of type void.

You will also need to create a Dog class that implements the above Animal class 
and the Eat method that says the dog is Eating.

To test the program ask the user for a dog name and create a new Dog type object 
from the Main of the program, give the Dog object a name,
and then execute the GetName and Eat methods
*/

using System;

public abstract class Animal
{
    public string Name;
    
    public void SetName(String name)
    {
        Name=name;
    }
    
    public string GetName()
    {
        return Name;
    }
    
    public abstract void Eat();
}

public class Dog:Animal
{
    public override void Eat()
    {
        Console.WriteLine(Name+" is Eating");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the dog name:");
        string dogName = Console.ReadLine();
        
        Dog objDog=new Dog();
        objDog.SetName(dogName);
        
        objDog.Eat();
        
    }
}
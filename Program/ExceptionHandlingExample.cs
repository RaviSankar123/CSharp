// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;
using System.Collections.Generic;

public class HelloWorld
{
    public void FileProcess(){
        try{
            Console.WriteLine("Enter the value");
            int a=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Value of A:{a}");
        }
        catch(Exception ex){
            Console.WriteLine("invalid input");
        }
    }
}

public class ExceptionHandlingExample{
    public static void Main(String[] args){
        HelloWorld hello = new HelloWorld();
        hello.FileProcess();
    }
}
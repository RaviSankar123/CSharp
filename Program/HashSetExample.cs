// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;
using System.Collections.Generic;

public class HelloWorld
{
    public void CreateHelloWorld(){
        int[] values={1,2,3,4,5};
        HashSet<int> hashSet = new HashSet<int>();
        foreach(int value in values){
          hashSet.Add(value);
        }
        foreach(int value in hashSet){
            Console.WriteLine(value);
        }
    }
}

public class HashSetExample{
    public static void Main(String[] args){
        HelloWorld hello = new HelloWorld();
        hello.CreateHelloWorld();
    }
}
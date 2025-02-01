using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        List<string> characters = new List<string>()
        {
            "Luke Skywalker",
            "Han Solo",
            "Chewbacca"
        };
        
		Console.WriteLine("Before remove an item:");
		foreach(var character in characters){
			Console.WriteLine(character);
        // Your code goes here.
        }
		
		//characters.Remove("Luke Skywalker");
		characters.RemoveAt(1);//index based
		characters.Clear();//remove all elements from the list
		
		Console.WriteLine("After remove an item:");
		foreach(var character in characters){
			Console.WriteLine(character);
        }
	}	
}
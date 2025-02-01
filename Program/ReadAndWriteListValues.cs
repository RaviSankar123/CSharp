using System;
using System.Collections.Generic;

//Read Operations: Retrieving and printing values from the list.
//Write Operations: Adding new elements to the list.
public class Program
{
    public static void Main()
    {
		
		string[] characterName = {"Senthil", "Guna", "velu" , "Anbu"};
        List<string> characters = new List<string>(characterName);
        
        // Your code goes here.
		Console.WriteLine("Original List");
		foreach(var character in characters){
			Console.WriteLine(character);
        }
		
		characters.Add("Rajan");	
		
		Console.WriteLine("Updated List");
	    foreach(var character in characters){
			Console.WriteLine(character);
	    }
		
		Console.WriteLine("First character in the list:");
		Console.WriteLine(characters[0]);
	}	
}
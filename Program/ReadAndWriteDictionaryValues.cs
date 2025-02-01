/*
Please add a new value, the key of which is your name, and the value of which is your age. Do this using the Add method.

Next, add another value to the dictionary using the index notation. This time, use a different name and a different age.

Lastly, read the first item you added to the dictionary, and write it to the console using Console.WriteLine`.
*/

using System;
using System.Collections.Generic;
using System.Linq;//for First()

public class Program
{
    public static void Main()
    {
        Dictionary<string, int> people = new Dictionary<string, int>()
		{
			{"Senthil", 35},
		};
		
		people.Add("Guna",38);//add method
		people["Velu"]=40;//add method using index
		
		people.Remove("Guna");
		people.Clear();
		
		//Console.WriteLine($"Name: {people.Keys.First()} Age : {people.Values.First()}");
		Console.WriteLine("Name: "+people.Keys.First()+ " Age: "+people.Values.First());

        foreach(var character in people){
			Console.WriteLine("Name: "+character.Key + " Age: "+character.Value);
		}	
    }
}
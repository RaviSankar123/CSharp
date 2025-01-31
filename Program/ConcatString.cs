/*
Problem Statement: Create a program that:

1. Concatenates all elements of an array into a single string

2. Extracts all numeric characters from the concatenated string.

3. Finds the maximum and minimum numbers formed from these characters.

4. Calculates the difference between the maximum and minimum numbers.

Input:["apple1", "banana2", "cherry3"]

Output:

• Concatenated String:"apple1banana2cherry3"

• Extracted Numbers: [1, 2, 3]

• Maximum Number:3

• Minimum Number:1

• Difference:2
*/

using System;
using System.Linq;

public class Example{
    public static void Main(String[] args){
        string message1, message2, message3;
        message1=Console.ReadLine();
        message2=Console.ReadLine();
        message3=Console.ReadLine();
        
        Methods m=new Methods();
        m.ConcatStrings(message1,message2,message3);
    }
}

public class Methods{
    public void ConcatStrings(string message1,string message2,string message3){
        String CombinedString=message1+message2+message3;
        Console.WriteLine($"Concatenation: {CombinedString}");
        ExtractNumbers(CombinedString);
    }
    public void ExtractNumbers(string CombinedString){
        //check if is a digit 
        string numericValues="";
        foreach(char ch in CombinedString){
            if(char.IsDigit(ch)){
                numericValues=numericValues+ch;
            }
        }
        //Console.WriteLine(numericValues);
        
        //convert into number
        int[] number=new int[numericValues.Length];
        
        Console.WriteLine("Numbers:");
        for(int i=0;i<numericValues.Length;i++){
            number[i]=numericValues[i] - '0';
        }
        for(int i=0;i<numericValues.Length;i++){
            Console.WriteLine(number[i]);
        }
        
        FindMaxMin(number);
        
    }
    
    public void FindMaxMin(int[] number){
        int maximum=number.Max();
        int minimum=number.Min();
        Console.WriteLine($"Maximum: {maximum}");
        Console.WriteLine($"Minimum: {minimum}");
        Difference(maximum,minimum);
    }
    
    public void Difference(int maximum,int minimum){
        int difference=maximum-minimum;
        Console.WriteLine($"Difference: {difference}");
    }
    
}
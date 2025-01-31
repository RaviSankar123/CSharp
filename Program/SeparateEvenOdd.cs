using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int n;
        Console.WriteLine("Enter the array length");
        n=Convert.ToInt32(Console.ReadLine());
        
        int[] arr = new int[n];
        Console.WriteLine("Enter the array elements");
        for(int i=0;i<arr.Length;i++){
            arr[i]=Convert.ToInt32(Console.ReadLine());
        }
        
        Console.WriteLine("Even numbers: ");
        /*
        for(int i=0;i<arr.Length;i++){
            if(arr[i]%2==0){
                Console.Write(arr[i]+" ");
            }
        }
        */
        
        foreach(int num in arr){
            if(num%2==0){
                Console.Write(num+" ");
            }
        }
        
        Console.WriteLine();
        
        /*
        Console.WriteLine("Odd numbers: ");
        for(int i=0;i<arr.Length;i++){
            if(arr[i]%2!=0){
                Console.Write(arr[i]+" ");
            }
        }
        */
        foreach(int num in arr){
            if(num%2!=0){
                Console.Write(num+" ");
            }
        }
        
    }
}

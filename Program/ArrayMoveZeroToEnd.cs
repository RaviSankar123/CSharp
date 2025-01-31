using System;

public class Hello
{
    public static void Main(string[] args)
    {
        int n;
        Console.WriteLine("Enter the array length:");
        n = Convert.ToInt32(Console.ReadLine());
        
        int[] arr = new int[n];
        Console.WriteLine("Enter the array values");
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }
        
        MoveZeroToEnd(arr);
        
    }
    
    static void MoveZeroToEnd(int[] arr)
    {
        int index = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] != 0)
            {
                arr[index++] = arr[i];
            }
        }
        
        while (index < arr.Length)
        {
            arr[index++] = 0;
        }
        
        Console.WriteLine("After moving zero to the end");
        for(int i=0;i<arr.Length;i++){
            Console.WriteLine(arr[i]);
        }
    }    
}

//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace CSharp_Program.Array
//{
//    public class DuplicateArray
//    {
//        static void DuplicateValue(int[] arr)
//        {
//            for(int i = 0; i < arr.Length; i++)
//            {
//                for(int j = i+1;j< arr.Length; j++)
//                {
//                    if(arr[j] == arr[i])
//                        Console.WriteLine(arr[i]);
//                }
//            }
//        }
//        public static void Main(String[] args)
//        {
//            int n;
//            Console.WriteLine("Enter the array length");
//            n = Convert.ToInt32(Console.ReadLine());
//            int[] arr = new int[n];
//            Console.WriteLine("Enter the array values");
//            for (int i = 0; i < arr.Length; i++)
//            {
//                arr[i] = Convert.ToInt32(Console.ReadLine());
//            }
//            DuplicateValue(arr);
//        }
//    }
//}

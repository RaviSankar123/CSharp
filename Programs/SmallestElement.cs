//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace CSharp_Program.Array
//{
//    public class SmallestElement
//    {
//        static void smalest(int[] arr)
//        {
//            int minimum = arr[0];
//            for (int i = 0; i < arr.Length; i++)
//            {
//                if (arr[i] < minimum)
//                    minimum = arr[i];
//            }
//            Console.WriteLine(minimum);
//        }
//        public static void Main(string[] args)
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
//            smalest(arr);
//        }
//    }
//}

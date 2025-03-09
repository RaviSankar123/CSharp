//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace CSharp_Program.Array
//{
//    public class AscendingOrder
//    {
//        static void Ascending(int[] arr)
//        {
//            //int temp;
//            //for(int i = 0; i < arr.Length; i++)
//            //{
//            //    for(int j = i+1;j< arr.Length; j++)
//            //    {
//            //        if (arr[i] > arr[j])
//            //        {
//            //            temp = arr[i];
//            //            arr[i] = arr[j];
//            //            arr[j] = temp;
//            //        }
//            //    }
//            //}
//            System.Array.Sort(arr);

//            for(int i=0;i<arr.Length;i++)
//            {
//                Console.WriteLine(arr[i]);
//            }
//        }
//        public static void Main(String[] args)
//        {
//            int n;
//            Console.WriteLine("Enter the array length");
//            n = Convert.ToInt32(Console.ReadLine());
//            int[] arr = new int[n];
//            for(int i = 0; i < n; i++)
//            {
//                arr[i]= Convert.ToInt32(Console.ReadLine());
//            }

//            Ascending(arr);
//        }
//    }
//}

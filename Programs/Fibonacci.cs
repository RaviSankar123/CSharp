//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace CSharp_Program.Level1
//{
//    internal class Fibonacci
//    {
//        public static void Main(string[] args)
//        {
//            int firstTerm = 0, secondTerm = 1, nextTerm;
//            int n;
//            Console.WriteLine("Enter the no. of series");
//            n = Convert.ToInt32(Console.ReadLine());
//            Console.Write($"Fibonacci series of {n} is ");

//            for (int i = 0; i < n; i++)
//            {
//                Console.Write(firstTerm + " ");
//                nextTerm = firstTerm + secondTerm;
//                firstTerm = secondTerm;
//                secondTerm = nextTerm;
//            }
//        }
//    }
//}

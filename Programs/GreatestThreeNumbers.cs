//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace CSharp_Program.Level1
//{
//    internal class GreatestThreeNumbers
//    {
//        public static void GreatestNumber(int a, int b, int c)
//        {
//            if (a > b && a > c)
//            {
//                Console.WriteLine($"Greatest no. is {a}");
//            }
//            else if (b > a && b > c)
//            {
//                Console.WriteLine($"Greatest no. is {b}");
//            }
//            else if (c > a && c > b)
//            {
//                Console.WriteLine($"Greatest no. is {c}");
//            }
//            else
//            {
//                Console.WriteLine("given three nos. are zero");
//            }
//        }
//        public static void Main(string[] args)
//        {
//            int a, b, c;
//            Console.WriteLine("Enter a :");
//            a = Convert.ToInt32(Console.ReadLine());
//            Console.WriteLine("Enter b :");
//            b = Convert.ToInt32(Console.ReadLine());
//            Console.WriteLine("Enter c :");
//            c = Convert.ToInt32(Console.ReadLine());

//            GreatestNumber(a, b, c);
//        }
//    }
//}

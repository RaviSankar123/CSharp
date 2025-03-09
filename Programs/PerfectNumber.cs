//using System;
//using System.Collections.Generic;
//using System.Diagnostics.CodeAnalysis;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace CSharp_Program.Level2
//{
//    public class PerfectNumber
//    {
//        static void perfectNumber(int n)
//        {
//            int Sum = 0;
//            int originalNumber = n;
//            for(int i = 1; i <= n; i++)
//            {
//                if (n % i == 0)
//                {
//                    Sum += i;
//                }
//            }
//            if (Sum == originalNumber)
//                Console.WriteLine("perfect number");
//            else
//                Console.WriteLine("not perfect");
//        }
//        public static void Main(String[] args)
//        {
//            int n;
//            Console.WriteLine("Enter the number");
//            n=Convert.ToInt32(Console.ReadLine());

//            perfectNumber(n);
//        }
//    }
//}

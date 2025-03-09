//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace CSharp_Program.Level2
//{
//    public class Reverse
//    {
//        static void reverse(int n)
//        {
//            int remainder, rev = 0;
//            while (n != 0)
//            {
//                remainder = n % 10;
//                rev = rev * 10 + remainder;
//                n = n / 10;
//            }

//            Console.WriteLine(rev);
//        }
//        public static void Main(String[] args)
//        {
//            int n;
//            Console.WriteLine("Enter the number:");
//            n=Convert.ToInt32(Console.ReadLine());

//            reverse(n); 
//        }
//    }
//}

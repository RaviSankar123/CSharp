//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace CSharp_Program.Level1
//{
//    internal class Palindrome
//    {
//        static void palindrome(int n)
//        {
//            int reverse = 0;
//            int remainder;
//            int originalNumber = n;
//            while (n > 0)
//            {
//                remainder = n % 10;
//                reverse = reverse * 10 + remainder;
//                n = n / 10;
//            }

//            if(reverse == originalNumber)
//            {
//                Console.WriteLine("Palindrome");
//            }
//            else
//            {
//                Console.WriteLine("not palindrome");
//            }
//        }
//        public static void Main(string[] args)
//        {
//            int n;
//            Console.WriteLine("Enter the number:");
//            n=Convert.ToInt32(Console.ReadLine());

//            palindrome(n);
//        }
//    }
//}

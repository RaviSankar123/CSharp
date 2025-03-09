//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace CSharp_Program.Level1
//{
//    internal class Armstrong
//    {
//        static void armstrong(int n)
//        {
//            int originalNumber = n;
//            int count = 0;
//            int remainder;
//            while (n > 0)
//            {
//                remainder = n % 10;
//                count++;
//                n=n/10;
//            }

//            n = originalNumber;

//            double result=0;
//            while (n > 0)
//            {
//                remainder = n % 10;
//                result += Math.Pow(remainder, count);
//                n=n/10;
//            }

//            if (originalNumber == result)
//                Console.WriteLine("armstrong");
//            else
//                Console.WriteLine("not armstrong");
//        }
//        public static void Main(String[] args)
//        {
//            int n;
//            Console.WriteLine("Enter the number:");
//            n=Convert.ToInt32(Console.ReadLine());

//            armstrong(n);
//        }
//    }
//}

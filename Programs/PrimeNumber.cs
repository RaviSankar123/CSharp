//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace CSharp_Program.Level1
//{
//    public class PrimeNumber
//    {
//        static void primeNumber(int n)
//        {
//            Boolean flag = false;
//            for(int i = 2; i <= n / 2; i++)
//            {
//                if(n % i == 0)
//                {
//                    Console.WriteLine("Not a prime");
//                    flag = true;
//                    break;
//                }
//            }
//            if(flag==false)
//            {
//                Console.WriteLine("prime");
//            }
//        }
//        public static void Main(String[] args)
//        {
//            int n;
//            Console.WriteLine("Enter the number:");
//            n=Convert.ToInt32(Console.ReadLine());

//            primeNumber(n);
//        }
//    }
//}

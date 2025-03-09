//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace CSharp_Program.Level2
//{
//    public class PrimeNumberBetweenIntervals
//    {
//        static void check(int a, int b)
//        {
//            while (a < b)
//            {
//                Boolean flag = false;
//                for(int i = 2; i <= a/2; i++)
//                {
//                    if (a % 2 == 0)
//                    {
//                        flag = true;
//                        break;
//                    }
//                }
//                if (flag == false)
//                    Console.WriteLine(a + " is prime");
//                a++;
//            }
//        }
//        public static void Main(String[] args)
//        {
//            int a, b;
//            Console.WriteLine("Enter the numbers");

//            a=Convert.ToInt32(Console.ReadLine());
//            b = Convert.ToInt32(Console.ReadLine());

//            check(a,b);
//        }
//    }
//}

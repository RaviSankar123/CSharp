//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace CSharp_Program.Level1
//{
//    internal class SwitchCase
//    {
//        public static void Main(string[] args)
//        {
//            int a, b;
//            Console.WriteLine("Enter a:");
//            a=Convert.ToInt32(Console.ReadLine());
//            Console.WriteLine("Enter b:");
//            b = Convert.ToInt32(Console.ReadLine());
//            string Operator;
//            Console.WriteLine("Enter the operator :");
//            Operator= Console.ReadLine().Trim().ToLower();

//            switch (Operator)
//            {
//                case "add":
//                    Console.WriteLine($"Addition:{a + b} ");
//                    break;
//                case "sub":
//                    Console.WriteLine($"sub:{a - b} ");
//                    break;
//                case "mul":
//                    Console.WriteLine($"mul:{a * b} ");
//                    break;
//                case "div":
//                    if (b != 0)
//                        Console.WriteLine($"Div:{a / b} ");
//                    else
//                        Console.WriteLine("divisible by zero is not possible");
//                    break;
//                dfault:
//                    Console.WriteLine("given nos. are zero");
//            }
//        }
//    }
//}

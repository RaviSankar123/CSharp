//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//using System;

//namespace CSharp_Program.Level1
//{
//    internal class ArithmeticOperations
//    {
//        static void Addition(int number1, int number2)
//        {
//            int addition = number1 + number2;
//            Console.WriteLine("Addition: " + addition);
//        }

//        static void Subtraction(int number1, int number2)
//        {
//            int subtraction = number1 - number2;
//            Console.WriteLine("Subtraction: " + subtraction);
//        }

//        static void Multiplication(int number1, int number2)
//        {
//            int multiplication = number1 * number2;
//            Console.WriteLine("Multiplication: " + multiplication);
//        }

//        static void Division(int number1, int number2)
//        {
//            if (number2 != 0)
//            {
//                int division = number1 / number2;
//                Console.WriteLine("Division: " + division);
//            }
//            else
//            {
//                Console.WriteLine("Division by zero is not allowed.");
//            }
//        }

//        static void Modulo(int number1, int number2)
//        {
//            if (number2 != 0)
//            {
//                int modulo = number1 % number2;
//                Console.WriteLine("Modulo: " + modulo);
//            }
//            else
//            {
//                Console.WriteLine("Modulo by zero is not allowed.");
//            }
//        }

//        public static void Main(string[] args)
//        {
//            Console.Write("Enter number 1: ");
//            int number1 = Convert.ToInt32(Console.ReadLine());

//            Console.Write("Enter number 2: ");
//            int number2 = Convert.ToInt32(Console.ReadLine());

//            Addition(number1, number2);
//            Subtraction(number1, number2);
//            Multiplication(number1, number2);
//            Division(number1, number2);
//            Modulo(number1, number2);
//        }
//    }
//}


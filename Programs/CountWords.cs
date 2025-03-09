//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace CSharp_Program.String
//{
//    public class CountWords
//    {
//        static int WordsCount(string message)
//        {
//            int count = 0;
//            foreach(char currentChar in message)
//            {
//                if(currentChar ==' ' || currentChar == '\t')
//                    count++;
//            }
//            count++;
//            return count;
//        }
//        public static void Main(string[] args)
//        {
//            string message;
//            Console.WriteLine("Enter the message");
//            message = Console.ReadLine();

//            int countWords = WordsCount(message);
//            Console.WriteLine("no. of words " + countWords);
//        }
//    }
//}

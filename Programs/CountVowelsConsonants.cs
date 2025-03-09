//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace CSharp_Program.String
//{
//    public class countVowelsConsonants
//    {
//        static void checkVowelsConsonents(string message)
//        {
//            int vowelsCount = 0;
//            int consonantsCount = 0;

//            foreach(char currentChar in message)
//            {
//                if (currentChar == ' ')
//                {
//                    continue;
//                }

//                char c = char.ToLower(currentChar);

//                if ("aeiou".Contains(c))
//                {
//                    vowelsCount++;
//                }
//                else
//                {
//                    consonantsCount++;
//                }
//            }
//            Console.WriteLine($"no. of vowels : {vowelsCount} \n No. of consonants : {consonantsCount}");
//        }
//        public static void Main(string[] args)
//        {
//            string message;
//            Console.WriteLine("Enter the message");
//            message= Console.ReadLine();

//            checkVowelsConsonents(message);
//        }

//    }
//}

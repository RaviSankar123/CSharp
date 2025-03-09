using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Program.String
{
    public class stringPalindrome
    {
        static void check(string word)
        {
            Boolean flag = true;
            int length=word.Length;
            for(int i = 0; i < length; i++)
            {
                if(word[i] != word[length -1 - i])
                {
                    flag = false;
                    break;
                }
            }

            if (flag == true)
                Console.WriteLine("palindrome");
            else
                Console.WriteLine("not palindrome");
        }
        public static void Main(string[] args)
        {
            string word;
            Console.WriteLine("Enter the word");

            word= Console.ReadLine();

            check(word);
        }
    }
}

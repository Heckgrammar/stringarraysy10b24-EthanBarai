using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prefix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Write a subroutine called Prefix from your pseudo-code 
            * The subroutine takes two, character arrays called word and pre as parameters and 
            * The subroutine determines whether the start of the character array word is the 
            * same as all of the character array pre.*/

            /* Your subroutine should also:
            •           work for character arrays of all lengths greater than 0
            •           not assume that the length of pre is less than the length of word.*/

            /* use fixed (hard coded) string arrays to test your code. 
             Call your subroutine using your test arrays from Main() routine
             and return the result to Main() */

            /* Starter code for your subroutine has been provided*/
            Console.WriteLine("Enter a word");
            string Word = Console.ReadLine();
            Console.WriteLine("Enter a prefix");
            string Pre = Console.ReadLine();
            while (Pre.Length > Word.Length)
            {
                Console.WriteLine("Enter a word");
                Word = Console.ReadLine();
                Console.WriteLine("Enter a prefix");
                Pre = Console.ReadLine();
            }
            Console.WriteLine(Prefix(Word, Pre));
        }
        static bool Prefix(string word, string pre)
        {
            for (int i = 0; i < pre.Length; i++)
            {
                if (word[i] != pre[i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}




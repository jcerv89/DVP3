using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVP1.CE1
    //Justin Cervenec
    //1811
    //Project & Portfolio 1
    //Displays user text input backwards, i.e. class = ssalc
{
    class Backwards
    {
        public static void Reverse()
        {
            //Welcome user and give intructions to program
            Console.WriteLine("Welcome to the backwards text program!");
            Console.WriteLine("Enter a sentence containing at least six words and press enter.");

            //Get user input 
            string userTextString = Console.ReadLine();

            //Validate user input not blank
            while (string.IsNullOrWhiteSpace(userTextString))
            {
                Console.WriteLine("Please type something to see it backwards");
                userTextString = Console.ReadLine();
            }
            /*
             CREATE A CONDITIONAL TO VERIFY USER INPUT HAS AT LEAST 6 WORDS.
             */
            //Call custom method to run
            string flip = Back(userTextString);

            Console.WriteLine(flip);//output back to conditional call in menu class
        }

        public static string Back(string name)//Method to make user input appear backwards
        {
            char[] cArray = name.ToCharArray();
            string reverse = String.Empty;
            for (int i = cArray.Length - 1; i > -1; i--)//Loop to make string text appear backwards
            {
                reverse += cArray[i];
            }
            return reverse;
        }
    }

}

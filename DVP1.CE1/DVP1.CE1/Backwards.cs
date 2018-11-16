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

            string[] counter = userTextString.Split(' ');
            int num = counter.Length;//variable to count words from user
           


            //Validate user input not blank and correcrt number of words
            while (string.IsNullOrWhiteSpace(userTextString)||(num<6))
            {               
                    Console.WriteLine("Please type something to see it backwards of at least six words.");
                    userTextString = Console.ReadLine();
                    counter = userTextString.Split(' ');//Will recount words from user if needed
                    num = counter.Length;//variable to count words from user


            }

            //Call custom method to run
            string flip = Back(userTextString);

            Console.WriteLine(flip.Trim());//output back to conditional call in menu class

            Console.WriteLine("Press any key to return to main menu.");
            Console.ReadKey();//Gives user a chance to press a key to go back to menu
            Menu.Choices();//calls main menu back to user

            Console.WriteLine();//seperates key input that sends user back to main menu
        }

        public static string Back(string text)//Method to make user input appear backwards
        {

            char[] cArray = text.ToCharArray();
            string reverse = String.Empty;
            for (int i = cArray.Length - 1; i > -1; i--)//Loop to make string text appear backwards
            {
                reverse += cArray[i];
            }
            return reverse;
        }
    }

}

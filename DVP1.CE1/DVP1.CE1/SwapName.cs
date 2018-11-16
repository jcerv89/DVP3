using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVP1.CE1
    //Justin Cervenec
    //1811
    //Project & Portfolio 1
    //When ran, this will switch order of the users entered name
{
    class SwapName
    {
        public static void Names()
        {
            //Tell user what to do
            Console.WriteLine("Enter your first name please.");

            //Prompt user
            string userFirstName = Console.ReadLine();

            //Display user input
            Console.WriteLine("You entered " + userFirstName+" as your first name.");

            //verify user input
            while (string.IsNullOrWhiteSpace(userFirstName))
            {
                Console.WriteLine("Please enter your first name.");
                userFirstName = Console.ReadLine();
            }

            //Tell user to type last name
            Console.WriteLine("Now please enter your last name.");

            //Prompt user
            string userLastName = Console.ReadLine();

            //Display user text
            Console.WriteLine("You entered "+userLastName+" as your last name.");

            //varify user input
            while (string.IsNullOrWhiteSpace(userLastName))
            {
                Console.WriteLine("Please enter your last name.");
                userLastName = Console.ReadLine();
            
            }

            Name(userFirstName, userLastName);//Calls custom method for the name of user
     

            Console.WriteLine("Press any key to return to main menu.");
            Console.ReadKey();//Gives user a chance to press a key to go back to menu
            Menu.Choices();//calls main menu back to user

            Console.WriteLine();//seperates key input that sends user back to main menu

           

        }
        public static void Name(string first, string last)//Method to take names from the user and output them in reverse order
        {
            Console.WriteLine("Your name is " +first + " " + last+", but...");//Normal name

            
            Console.WriteLine("Reversed your name is "+last+" " + first+"!");//Flipped name
        }
     
    }
}

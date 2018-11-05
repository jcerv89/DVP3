using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVP1.CE1
    //Justin Cervenec
    //1811
    //Project & Protfolio 1
    //Gives user age via multiple ways, i.e. age in hours, minutes, ect...
{
    class AgeConverter
    {
        public static void AgeConvert()
        {
            //Welcomes user with instructions
            Console.WriteLine("Hello. Welcome to the Age Converter!");
            Console.WriteLine("Lets start with your name. Enter you name now.");

            //Prompt user for name
            string userNameString = Console.ReadLine();
            //verify user input exists
            while (string.IsNullOrWhiteSpace(userNameString))
            {
                Console.WriteLine("Please enter your name, or whatever you want to be called here.");
                userNameString = Console.ReadLine();
            }

            //Got to thank the user for their name. Now get their age.
            Console.WriteLine("Thanks"+userNameString+", now tell us your age.");

            //Get user age
            string userAgeString = Console.ReadLine();
            //variable to convert and store age data
            int userAge;

            //verify age entered is a whole number
            while (!int.TryParse(userAgeString, out userAge))
            {
                Console.WriteLine("We simply need a number for your age, such as 21 or 55.");
                userAgeString = Console.ReadLine();
            }
        }
    }
}

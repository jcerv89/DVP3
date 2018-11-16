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

            //Have to thank the user for their name. Now get their age.
            Console.WriteLine("Thanks "+userNameString+", now tell us your age.");

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
            
            //Congrats user on being old
            Console.WriteLine("Good job surviving until the age of " + userAge+".");

          
            Age(userAge);



            Console.WriteLine("Press any key to return to main menu.");
            Console.ReadKey();//Gives user a chance to press a key to go back to menu
            Menu.Choices();//calls main menu back to user

            Console.WriteLine();//seperates key input that sends user back to main menu

        }

        public static void Age(int age)//Method to convert user age to other age types
        {
          
            //Some quick math to convert the user age to nonsense ages
            int ageDays = age * 365;
            //Age in hours
            int ageHours = ageDays * 24;
            //Age in minutes
            int ageMinutes = ageHours * 60;
            //Age in seconds
            int ageSeconds = ageMinutes * 60;

            //The .ToString(##,#) puts commas in the appropriate places of the numbers to read easier
            Console.WriteLine("To make you feel really old, you are " + ageDays.ToString("##,#") + " days old, " + ageHours.ToString("##,#") + " hours old, " + ageMinutes.ToString("##,#") + " minutes old and " + ageSeconds.ToString("##,#") + " seconds old!");



        }
        
      

    }
}

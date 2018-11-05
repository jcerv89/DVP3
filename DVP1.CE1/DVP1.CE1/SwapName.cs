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

       
            string name = userFirstName+" " + userLastName;//User full name enterd
            string reverseName = userLastName + " " + userFirstName;//User full name in reverse order

            Console.WriteLine("Your name is "+name+", but in reverse order it is "+reverseName+".");

            //Displays user name and name in reverse. Will edit later to make more efficiant
           // Console.WriteLine("Your name is "+name +", but in reverse it is " + reverseName);

            /*Above only creates correct output. DO NOT KEEP FOR USE. Make custom function below with argurmants for names
              with a .reverse, or something like it to swap the name order.            
            */
            
        }

     
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVP1.CE1
//Justin Cervenec
//1811
//Project & Portfolio 1
//User menu for program selection
{
    class Menu
    {
        public static void Choices()
        {
            //Welcome user to program with intructions
            Console.WriteLine("Coding challenge menu:");
            Console.WriteLine("Please select the program you want to run and press enter.");
            Console.WriteLine();//Space between outputs

            //Displays the menu choices
            Console.WriteLine("[1] Swap Name\r\n[2] Backwards\r\n[3] Age Convert\r\n[4] Temp Convert\r\n[5] Big Blue Fish\r\n[0] Exit");

            //User prompt for selection
            string userChoiceString = Console.ReadLine();

            //Variable to store user number input
            int userChoice;

            //Loop to varify user input
            while (!int.TryParse(userChoiceString, out userChoice) || (userChoice > 5) || (string.IsNullOrWhiteSpace(userChoiceString)))
            {
                Console.WriteLine("Please enter a valid option");
                userChoiceString = Console.ReadLine();
            }

            
            
                if (userChoiceString == "1")
                {
                    SwapName.Names();
                }
                else if (userChoiceString == "2")
                {
                    Backwards.Reverse();
                }
                else if (userChoiceString=="3")
                {
                    AgeConverter.AgeConvert();
                }
               
            

        }
}
}

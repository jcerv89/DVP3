using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVP1.CE1
{
    //Justin Cervenec
    //1811
    //Project & Portfolio 1
    //Temp converter for celcius and fahrenheit
    class TempConverter
    {
        public static void TempConvert()
        {
            //Welcome user to program
            Console.WriteLine("Welcome to the Temperature Converter! What would you like to do? Select an option.");
            //Displays options for user
            Console.WriteLine("1. Fahrenheit to Celcius\r\n2. Celcius to Fahrenheit");

            //Gets choice from user
            string userChoiceString = Console.ReadLine();

            //Verify user input
            while (string.IsNullOrWhiteSpace(userChoiceString)||(userChoiceString!="1")&&(userChoiceString!="2"))
            {
               
                    Console.WriteLine("Please select a valid option.");
                    userChoiceString = Console.ReadLine();
                
            }
            //Tell user enter the temp they are converting
            Console.WriteLine("Now enter the temperature you want to convert");
            //Prompt user
            string userTempString = Console.ReadLine();
            //Variable to store user input
            double userTemp;
            //varify user input
            while (!double.TryParse(userTempString, out userTemp))
            {
                Console.WriteLine("Enter a correct temperature. You know, as a number.");
                userTempString = Console.ReadLine();
            }

            if (userChoiceString=="1")//Fahrenheit to Celcius to user
            {
                double celsTemp = FahrToCel(userTemp);
                Console.WriteLine("The temperature is "+Math.Round(celsTemp, 1) +" degrees celcius.");//rounds to nearest tenth of a decimal
            }
            else if (userChoiceString=="2")
            {
                double fahrTemp = CelToFahr(userTemp);
                Console.WriteLine("The temperature is "+Math.Round(fahrTemp)+" degrees fahrenheit.");
            }
            Console.WriteLine("Press any key to return to main menu.");
            Console.ReadKey();//Gives user a chance to press a key to go back to menu
            Menu.Choices();//calls main menu back to user
            
            Console.WriteLine();//seperates key input that sends user back to main menu
           
        }


        public static double FahrToCel(double temp)//Method for fahrenheit to celcius conversion
        {
            double toCelcius = (temp - 32) * .5556;//Some quick math
            return toCelcius;
        }

        public static double CelToFahr(double temp)//Method to convert cel to fahrenheit
        {
            double toFahr = (temp * 1.8) + 32;//More quick math
            return toFahr;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVP1.CE1
    //Justin Cervenec
    //1811
    //Project & Porfolio 1
    //Gives user size of selcted color of fish
{
    class BigBlueFish
    {
        public static void BigFish()
        {
            //Array for colors of fish data
            string[] Fishcolor = new string[12] {"blue", "red", "pink", "blue", "green", "pink", "green", "red", "blue", "green", "red", "pink"};
            //Array for fish size date
            float[] fishSize = new float[12] { 2.7F, 5.6F, 10.3F, 12.4F, 3.8F, 13.3F, 16.7F, 15.5F, 8.9F, 18.1F, 6.6F, 9.2F}; 

            //Welcome user to the program with instructions
            Console.WriteLine("Welcome to Big Blue Fish");
            Console.WriteLine("Lets find the biggest fish of your selected color!\r\n");

            //Menu of colors for user to choose from
            Console.WriteLine("[1] blue\r\n[2] red\r\n[3] pink\r\n[4] green\r\n");

            //Prompt user to select a color from given menu
            string userColorChoice = Console.ReadLine();
        }
    }
}

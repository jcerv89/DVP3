using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVP1.CE1
    //Justin Cervenec
    //1811
    //Project & Porfolio 1
    //Gives user largest size of selected color of fish
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
            //variable for user number selection for validation purposes
            int userColor;
            //validate user input
            while (!int.TryParse(userColorChoice, out userColor)||(userColor>4)||(userColor<1))
            {
                Console.WriteLine("Please select a valid choice from the given menu.");
                userColorChoice = Console.ReadLine();

            }

            float[] bigsize = FindBig(fishSize, Fishcolor);//calls method with array loops
            if (userColor == 1)
            {
                Console.WriteLine("It looks like the biggest blue fish "+bigsize.Max()+" inches.");//Gives user the largest size in the array since the blue fish is the biggest one.
            }
            else if (userColor==2)
            {
                Console.WriteLine("It looks like the biggest red fishis "+bigsize[1]+" inches.");//Big red fish
            }
            else if (userColor==3)
            {
                Console.WriteLine("It looks like the biggest pink fish is " +bigsize[2]+" inches.");//Big pink fish
            }
            else if (userColor==4)
            {
                Console.WriteLine("It looks like the biggest green fich is "+bigsize[3]+" inches.");//Big green fish

            }

            Console.WriteLine("Press any key to return to main menu.");
            Console.ReadKey();//Gives user a chance to press a key to go back to menu
            Menu.Choices();//calls main menu back to user

            Console.WriteLine();//seperates key input that sends user back to main menu
        }

        public static float[] FindBig(float[] size, string[] color)//Method to loop and sort array size
        {
            for (int i =0; i< size.Length && i<color.Length; i++)
            {
                size[i].ToString();
               
            }
            Array.Sort(size);//Sorts array size large to small for organization
            Array.Reverse(size);
            return size;
            
        }
    }
}

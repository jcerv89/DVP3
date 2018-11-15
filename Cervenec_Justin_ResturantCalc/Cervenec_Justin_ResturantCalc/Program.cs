using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cervenec_Justin_ResturantCalc
{
    class Program
    {
        static void Main(string[] args)
        
        {
            /*Justin Cervenec
            Section 02 
             
            Tip Calculator assignemt
             
            */





            //This is a tool for for users to calculate a tip for a meal cost


            //Prompt user for a total amount
            Console.WriteLine("Please enter the amount for check one and press enter.");

            //user input for check amounts
            string check1String = Console.ReadLine();
            double check1;//varibale for check one from user
            //verify user input is a dollar amount
            while (!double.TryParse(check1String, out check1))
            {
                Console.WriteLine("Please enter a dollar value, such as 12.99.");
                check1String = Console.ReadLine();
            }
            Console.WriteLine("What is the amount for check 2?");
            string check2String = Console.ReadLine(); double check2;//holds user input
            while (!double.TryParse(check2String, out check2))
            {
                Console.WriteLine("Please enter a dollar value, such as 12.99.");
                check2String = Console.ReadLine();
            }
            Console.WriteLine("What is the amount for check 3?");
            string check3String = Console.ReadLine(); double check3;//holds third check amount
            while (!double.TryParse(check3String, out check3))
            {
                Console.WriteLine("Please enter a dollar value, such as 12.99.");
                check3String = Console.ReadLine();
            }


            //User prompt for a tip
            Console.WriteLine("If you were satisfied with your service, what tip percent do you want to add to check 1? ");

            string tip1String = Console.ReadLine(); double tip1;
            while (!double.TryParse(tip1String, out tip1))
            {
                Console.WriteLine("Please enter the percent amount you want to leave, such as 15 or 20.");
                tip1String = Console.ReadLine();
            }
            Console.WriteLine("What tip percent do you want to add for check 2?");
            string tip2String = Console.ReadLine(); double tip2;
            while (!double.TryParse(tip2String, out tip2))
            {
                Console.WriteLine("Please enter the percent amount you want to leave, such as 15 or 20.");
                tip2String = Console.ReadLine();
            }
            Console.WriteLine("What tip percent do you want to add for check 3?");
            string tip3String = Console.ReadLine(); double tip3;
            while (!double.TryParse(tip3String, out tip3))
            {
                Console.WriteLine("Please enter the percent amount you want to leave, such as 15 or 20.");
                tip3String = Console.ReadLine();
            }




            //tip amount calculations
            double tipAmount1 = (tip1 * .01) * check1;
            double tipAmount2 = (tip2 * .01) * check2;
            double tipAmount3 = (tip3 * .01) * check3;
            //Displays tip amount only to user
            Console.WriteLine("The tip amount for check one will be $" + tipAmount1);
            Console.WriteLine("The tip amount for check two will be $" + tipAmount2);
            Console.WriteLine("The tip amount for check three will be $" + tipAmount3);

            //This adds the tip amount to the original check amount
            double totalAmount1 = tipAmount1 + check1;
            double totalAmount2 = tipAmount2 + check2;
            double totalAmount3 = tipAmount3 + check3;
            //convert data to decimal type
            decimal finalAmount1 = (decimal)totalAmount1;
            decimal finalAmount2 = (decimal)totalAmount2;
            decimal finalAmount3 = (decimal)totalAmount3;

            //total of three checks combined
            double totalCombo = check1 + check2 + check3;

            //total of the three tips entered
            double totalTip = tipAmount1 + tipAmount2 + tipAmount3;


            //output total cost to user
            Console.WriteLine("The total cost for check one will be $" + finalAmount1);
            Console.WriteLine("The total cost for check two will be $" + finalAmount2);
            Console.WriteLine("The total cost for check three will be $" + finalAmount3);

            //Combined total of all three tips
            Console.WriteLine("The total combined tip amount is $" + totalTip);


            //This is the final amount if the check split evenly
            double splitCheck = (totalCombo + totalTip) / 3;



            //Combined final total including tips
            Console.WriteLine("The combined costs including tips is $" + (totalTip + totalCombo));

            //Out put split cost to user
            Console.WriteLine("If you split the amount evenly, each indidvidual cost would be $" + Math.Round(splitCheck, 2));

            /*Test values to ensure corrct algorithms
             TEST 1
           
            Inputs
            Check 1 – 10.00 Tip % – 15
            Check 2 – 15.00 Tip % – 15
            Check 3 – 25.00 Tip % – 20

            Results
             Total For Check #1 – $11.50
             Total For Check #2 – $17.25
             Total For Check #3 – $30.00
             Total Tip For The Waiter – $8.75
             Grand total With Tips – $58.75
             3 way split cost – $19.58333 or $19.58 Rounded


            TEST 2

            Inputs
             Check 1  –24.50   Tip %–15
             Check 2 – 17.25 Tip % – 25
             Check 3 – 31.00 Tip % – 20


             Total For Check #1 – $28.175 or $28.18 Rounded
             Total For Check #2 – $21.5625 or $21.56 Rouded
             Total For Check #3 – $37.20
             Total Tip For The Waiter – $14.1875 or $14.19 Rounded
             Grand total With Tips – $86.9375 or $86.94 Rounded
             3 way split cost – $28.9791666 or $28.98 Rounded
       */





























        }
    }
}

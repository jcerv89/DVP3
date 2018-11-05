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
            Console.WriteLine("Please enter the amount for each check and press enter.");

            //user input for check amounts
            string check1String = Console.ReadLine();
            string check2String = Console.ReadLine();
            string check3String = Console.ReadLine();
            //Variables for check amounts
            decimal check1;
            decimal check2;
            decimal check3;
            //verify that user input is some kind of money format
            while (!decimal.TryParse(check1String, out check1)&&(!decimal.TryParse(check2String, out check2)&&(!decimal.TryParse(check3String, out check3))))
            {
                Console.WriteLine("Please enter the check amounts. For example, 25.98.");
                check1String = Console.ReadLine();
                check2String = Console.ReadLine();
                check3String = Console.ReadLine();

            }
            ////converts input to number
            //double checkOne = double.Parse(check1);
            //double checkTwo = double.Parse(check2);
            //double checkThree = double.Parse(check3);

            //User prompt for a tip
            Console.WriteLine("If you were satisfied with your service and want to add a tip, type the percent amount and press enter");

            string tip1 = Console.ReadLine();
            string tip2 = Console.ReadLine();
            string tip3 = Console.ReadLine();
            //convert tip to number
            double tipPercent1 = double.Parse(tip1);
            double tipPercent2 = double.Parse(tip2);
            double tipPercent3 = double.Parse(tip3);



            //tip amount calculations
            double tipAmount1 = (tipPercent1 * .01)*checkOne;
            double tipAmount2 = (tipPercent2 * .01) * checkTwo;
            double tipAmount3 = (tipPercent3 * .01) * checkThree;
            //Displays tip amount only to user
            Console.WriteLine("The tip amount for check one will be $"+tipAmount1);
            Console.WriteLine("The tip amount for check two will be $"+tipAmount2);
            Console.WriteLine("The tip amount for check three will be $"+tipAmount3);

            //This adds the tip amount to the original check amount
            double totalAmount1 = tipAmount1 + checkOne;
            double totalAmount2 = tipAmount2 + checkTwo;
            double totalAmount3 = tipAmount3 + checkThree;
            //convert data to decimal type
            decimal finalAmount1 = (decimal)totalAmount1;
            decimal finalAmount2 = (decimal)totalAmount2;
            decimal finalAmount3 = (decimal)totalAmount3;

            //total of three checks combined
            double totalCombo = checkOne + checkTwo + checkThree;

            //total of the three tips entered
            double totalTip = tipAmount1 + tipAmount2 + tipAmount3;
        

            //output total cost to user
            Console.WriteLine("The total cost for check one will be $"+finalAmount1);
            Console.WriteLine("The total cost for check two will be $"+finalAmount2);
            Console.WriteLine("The total cost for check three will be $"+finalAmount3);

            //Combined total of all three tips
            Console.WriteLine("The total combined tip amount is $"+totalTip);


        //This is the final amount if the check split evenly
            double splitCheck = (totalCombo + totalTip) / 3;
            
           

            //Combined final total including tips
            Console.WriteLine("The combined costs including tips is $" + (totalTip + totalCombo));

            //Out put split cost to user
            Console.WriteLine("If you split the amount evenly, each indidvidual cost would be $" + splitCheck);

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

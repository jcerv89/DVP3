using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cervenec_Justin_Lists
{
    //Justin Cervenec
    //Lists Assignment
    //Section 02
    class Program
    {
        static void Main(string[] args)
        {
            //Initial Item list
            List<string> itemsString = new List<string>()//sent down custom function named CombineTheLists
            {
                "Ibanez",
                "Strings",
                "Guitar Picks",
                "Tuner",
                "Cable",
                "Guitar Case",
                "Strap"

            };


            //Items cost in the string list
            List<decimal> itemsCost = new List<decimal>()
            {
                249.99M,
                6.55M,
                4.85M,
                15.25M,
                9.90M,
                60.75M,
                6.98M,

            };
            // Call the CombineTheList Method
            CombineTheLists(itemsString, itemsCost);//Will display the matching item with price from loop, using correct index numbers
            Console.WriteLine("\r\nWe are going to change the list a little bit now.\r\n");//Output will have matching idex nums with item to price

           //2 items removed from original list above
            itemsString.Remove("Ibanez");
            itemsString.Remove("Strings");

            
            //2 Costs removed repective to the index nums of the list
            itemsCost.Remove(249.99M);
            itemsCost.Remove(6.55M);                                    //Ouput will remove these listed items and add what is is entered. The remaining original items and cost will still match
            //New item and cost added to beginning of both lists
            itemsString.Insert(0, "Amp");
            itemsCost.Insert(0, 499.99M);
            CombineTheLists(itemsString, itemsCost);


        }

        public static void CombineTheLists(List <string> item, List<decimal> cost )//Custom method for the lists
        {

            //Loop to go through both lists and match index numbers
            for (int i = 0; i < cost.Count && (i < item.Count); i++)
            {


                //This output will be called in the main method
                Console.WriteLine("The cost of the {0} is ${1}. ", item[i], cost[i]);
            }

           

        }
    
        }
    }


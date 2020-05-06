using SodaMachine;
using System;
using System.Collections.Generic;
using System.Text;

namespace SodaMachineOOP
{
    class SodaMachine
    {
        // member variables (Has a)

        Inventory inventory;
        MoneyHolder moneyHolder;
        public double amountEntered;
        public double amountRequired;
        public string userInput;






        //  constructor (Spawner)

        public SodaMachine()
        {
            inventory = new Inventory();
            inventory.AddGrapeSoda(32);
            inventory.AddLemonSoda(32);
            inventory.AddOrangeSoda(32);

            moneyHolder = new MoneyHolder();
            moneyHolder.AddDimes(10);
            moneyHolder.AddNickles(20);
            moneyHolder.AddPennys(50);
            moneyHolder.AddQuarters(20);

            
        }




        // member methods (Can do)

        public void EnterMoney()
        {
            Console.WriteLine("Please enter a Penny, Nickle, Dime, Quarter, Cancel");
            string userInput = Console.ReadLine().ToLower();
            if (userInput == "penny")
            {
                moneyHolder.AddPennys(1);
                amountEntered = 0.01;
            }
            else if (userInput == "nickle")
            {
                moneyHolder.AddNickles(1);
                amountEntered = 0.05;
            }
            else if (userInput == "dime")
            {
                moneyHolder.AddDimes(1);
                amountEntered = 0.10;
            }
            else if (userInput == "quarter")
            {
                moneyHolder.AddQuarters(1);
                amountEntered = 0.25;
            }
            else if (userInput == "cancel")
            {
                return;
            }
            else EnterMoney();
        }

        // add buy soda method







        public void BuyOrangeSoda()
        {
            amountRequired = 0.35;
            int amountEntered;
            amountEntered = int.Parse(Console.ReadLine());


            Console.WriteLine("Please put in 35 cents");

            if (amountEntered == amountRequired && inventory.orangeSodas.Count > 0) // exact change send soda
                {
                    Console.WriteLine("Crush soda coming down !");
                    inventory.orangeSodas.RemoveAt(0);
                    for (int i = 0; i < inventory.orangeSodas.Count; i++)
                    {
                        inventory.orangeSodas[i] = inventory.orangeSodas[i + 1];
                    }
                }
                else if (amountEntered < amountRequired) // require more money
                {
                    Console.WriteLine("Add more money");

                    
                }
                else if (amountEntered == amountRequired && inventory.orangeSodas.Count < 0) // return money to customer
                {
                    Console.WriteLine("Sorry ! There are no more Crush sodas. You're money will be returned");
                }



            
        }

        public void BuyLemonSoda()
        {
            amountRequired = 0.06;
            int amountEntered;
            amountEntered = int.Parse(Console.ReadLine());

            Console.WriteLine("Please put in 6 cents");
            if(amountEntered == amountRequired && inventory.lemonSodas.Count > 0)
            {
                Console.WriteLine("Mountain coming down !");
                inventory.lemonSodas.RemoveAt(0);
                for(int i = 0; i < inventory.lemonSodas.Count; i++)
                {
                    inventory.lemonSodas[i] = inventory.lemonSodas[i + 1];
                }
            }
            else if(amountEntered < amountRequired)
            {
                Console.WriteLine("Please put in required amount ");
            }
            else if (amountEntered == amountRequired && inventory.lemonSodas.Count < 0)
            {
                Console.WriteLine("Sorry ! There is no more Mountain Dew");

            }
        }


        public void BuyGrapeSoda()
        {
            amountRequired = 0.60;
            int amountEntered;
            amountEntered = int.Parse(Console.ReadLine());

            Console.WriteLine("Please put in 60 cents");
            if (amountEntered == amountRequired && inventory.grapeSodas.Count > 0)
            {
                Console.WriteLine("Fanta soda coming down !");
                inventory.grapeSodas.RemoveAt(0);
                for (int i = 0; i < inventory.grapeSodas.Count; i++)
                {
                    inventory.grapeSodas[i] = inventory.grapeSodas[i + 1];
                }
            }
            else if (amountEntered < amountRequired)
            {
                Console.WriteLine("Please put in required amount");

            }
            else if (amountEntered == amountRequired && inventory.grapeSodas.Count < 0)
            {
                Console.WriteLine("Sorry ! Fanta soda is sold out");
            }

        }

        public void DisplayScreen()
        {
            Console.WriteLine("Hello and welcome to Brad's Soda Machine ! Hope you're thirsty !");
            Console.WriteLine("Choose from the following sodas: Mountain Dew, Fanta, and Crush");

        }

    }
}           
           
     
            
       
        
 


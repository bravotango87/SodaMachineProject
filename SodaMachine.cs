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
        public string inputGiving;






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

        public void BuySoda()
        {
            Console.WriteLine("What would you like to buy ? Orange Soda ? Grape Soda ? Lemon Soda ?");
            string inputGiving = Console.ReadLine().ToLower();
            amountRequired = 0.35;
            if(inputGiving == "orange")
            {
                if(amountEntered == amountRequired && inventory.orangeSodas.Count > 0)
                {
                    Console.WriteLine("Crush soda coming down !");
                } 
            }
        }
     
            
       
        
 }


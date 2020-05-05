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


        public void BuySoda() /// if statement or switch case statement to buy a drink.
        {

        }

    }
            
       
        
 }


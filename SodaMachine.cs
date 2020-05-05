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

        public void RunWelcomeScreen()
        {
            Console.WriteLine("Welcome To Brads Soda Machine !");

            bool transactionComplete = false;
            bool validPurchase = false;
            while (transactionComplete == false)
            {
                do
                {
                    Console.WriteLine("What would you like to buy ? Orange Soda ? Lemon Soda ? Grape Soda ?");
                    string userInput = Console.ReadLine().ToLower();
                    switch (userInput)
                    {
                        case "orange soda":
                            AddLemonSoda();
                            validPurchase = true;
                            break;
                            
                    }
                }
            }
        }
       
        
    }
}

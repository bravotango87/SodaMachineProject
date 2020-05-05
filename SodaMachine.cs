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
            moneyHolder = new MoneyHolder();
        }
        



        // member methods (Can do)

        public void RunMachine()
        {

        }
       
        
    }
}

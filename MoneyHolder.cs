using SodaMachineOOP;
using System;
using System.Collections.Generic;
using System.Text;

namespace SodaMachine
{
    class MoneyHolder // coins
    {
        // member variables (Has a)

        public List<Penny> pennies;
        public List<Dime> dimes;
        public List<Nickel> nickels;
        public List<Quarter> quarters;






       // constructor (Spawner) 

        public MoneyHolder()
        {
            pennies = new List<Penny>();
            dimes = new List<Dime>();
            nickels = new List<Nickel>();
            quarters = new List<Quarter>();
            MoneyInMachine();
            
        }

     
   



      // member methods (Can do)

        public void MoneyInMachine()
        {

        }
    }
}

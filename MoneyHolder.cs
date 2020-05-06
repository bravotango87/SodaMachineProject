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
            
            
        }

     
   



      // member methods (Can do)

        public void AddPennys(int numberOfPennies)
        {
            for (int i = 0; i < numberOfPennies; i++)
            {
                Penny penny = new Penny();
                pennies.Add(penny);
            }
        }

        public void AddDimes(int numberOfDimes)
        {
            for (int i = 0; i < numberOfDimes; i++)
            {
                Dime dime = new Dime();
                dimes.Add(dime);
            }
        }

        public void AddNickles(int numberOfNickles)
        {
            for (int i = 0; i < numberOfNickles; i++)
            {
                Nickel nickel = new Nickel();
                nickels.Add(nickel);
            }
        }

        public void AddQuarters(int numberOfQuarters)
        {
            for (int i = 0; i < numberOfQuarters; i++)
            {
                Quarter quarter = new Quarter();
                quarters.Add(quarter);
            }
        }

        public void RemovePennys(int numberOfPennys)
        {
            for (int i = 0; i < numberOfPennys; i--)
            {
                Penny penny = new Penny();
                pennies.Remove(penny);
            }
        }

        public void RemoveNickels(int numberOfNickels)
        {
            for (int i = 0; i < numberOfNickels; i--)
            {
                Nickel nickel = new Nickel();
                nickels.Remove(nickel);
            }
        }

        public void RemoveDimes(int numberOfDimes)
        {
            for (int i = 0; i < numberOfDimes; i--)
            {
                Dime dime = new Dime();
                dimes.Remove(dime);
            }
        }

        public void RemoveQuarters(int numberOfQuarters)
        {
            for (int i = 0; i < numberOfQuarters; i--)
            {
                Quarter quarter = new Quarter();
                quarters.Remove(quarter);
            }
        }
    }
}

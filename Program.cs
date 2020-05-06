using System;

namespace SodaMachineOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            SodaMachine sodaMachine = new SodaMachine();

            sodaMachine.DisplayScreen();
            sodaMachine.EnterMoney();
            sodaMachine.BuyGrapeSoda();
            sodaMachine.BuyLemonSoda();
            sodaMachine.BuyOrangeSoda();

        }
    }
}

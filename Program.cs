using SodaMachinOOP;
using System;

namespace SodaMachinOOP
{
    class Program
    {
        static void Main(string[] args)
        {


            SodaGame sodaGame = new SodaGame();
            sodaGame.RunSodaGame();

            GrapeSoda grapeSoda = new GrapeSoda();
            LemonSoda lemonSoda = new LemonSoda();
            OrangeSoda orangeSoda = new OrangeSoda();


            sodaGame.SodaMachine.DisplayScreen();
            sodaGame.SodaMachine.EnterMoney();
        }
    }
}

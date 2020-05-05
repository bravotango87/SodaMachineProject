using System;
using System.Collections.Generic;
using System.Text;

namespace SodaMachine
{
    class Inventory // sodas
    {
        // member variables (Has a)


        public List<LemonSoda> lemonSodas;
        public List<OrangeSoda> orangeSodas;
        public List<GrapeSoda> grapeSodas;


      // constructor (Spawner)

      public Inventory()
        {
            lemonSodas = new List<LemonSoda>();
            orangeSodas = new List<OrangeSoda>();
            grapeSodas = new List<GrapeSoda>();
            
              
        }

     // member methods (Can do)

       public void AddLemonSoda(int cansOfLemon)
        {
            for (int i = 0; i < cansOfLemon; i++)
            {
                LemonSoda lemonSoda = new LemonSoda();
                lemonSodas.Add(lemonSoda);

            }
        }

        public void AddOrangeSoda(int cansofOrange)
        {
            for (int i = 0; i < cansofOrange; i++)
            {
                OrangeSoda orangeSoda = new OrangeSoda();
                orangeSodas.Add(orangeSoda);
            }
        }

        public void AddGrapeSoda(int cansOfGrape)
        {
            for (int i = 0; i < cansOfGrape; i++)
            {
                GrapeSoda grapeSoda = new GrapeSoda();
                grapeSodas.Add(grapeSoda);
            }
        }

    }
}

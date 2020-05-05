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
            FillMachine();
              
        }

     // member methods (Can do)

       public void FillMachine()
        {

        }

    }
}

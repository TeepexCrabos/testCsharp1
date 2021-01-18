using System;
using System.Collections.Generic;
using System.Text;

namespace testCsharp1
{
    class PNJ : Personnage
    {
        public PNJ()
        {

        }

        public override void attaqueSpe(Personnage perso)
        {
            perso.Pv = perso.PvMax;
            Console.WriteLine("le pnj vous a soigné");
        }
    }
}

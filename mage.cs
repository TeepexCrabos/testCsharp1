using System;
using System.Collections.Generic;
using System.Text;

namespace testCsharp1
{
    class mage : Personnage
    {
        public mage()
        {
        Pv = 80;
        Atk = 30;
        PvMax = 80;
        }

        public override void attaqueSpe(Personnage perso)
        {
            perso.subirDegat(50);
        }
       
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace testCsharp1
{
    class Guerrier : Personnage
    {
        public Guerrier()
        {
         Pv = 100;
         Atk = 20;
            PvMax = 100;
        }

        public override void attaqueSpe(Personnage perso)
        {
            perso.subirDegat(50);
        }

    }
}

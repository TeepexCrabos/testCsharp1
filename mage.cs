using System;
using System.Collections.Generic;
using System.Text;

namespace testCsharp1
{
    class mage : Personnage , IBaton
    {
        public mage()
        {
        Pv = 80;
        Atk = 30;
        PvMax = 80;
        }

        void IBaton.fireBall()
        {

        }
    }
}

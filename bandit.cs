using System;
using System.Collections.Generic;
using System.Text;

namespace testCsharp1
{
    class bandit : Personnage
    {
        public bandit(int Pv,int Atk)
        {
            Pv = Pv;
            Atk = Atk;
        }

        public int Pv { get; set; }
        public int Atk { get; set; }
        public override void attaquer()
        {
           
        }
    }
}

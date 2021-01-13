using System;
using System.Collections.Generic;
using System.Text;

namespace testCsharp1
{
    class Guerrier : Personnage , IEpee
    {
        public Guerrier()
        {
         Pv = 100;
         Atk = 20;
            PvMax = 100;
        }
       
         void IEpee.intimidation()
        {
            Console.WriteLine("le guerrier fait tourner son epée pour intimider son adversaire");
        }
       
    }
}

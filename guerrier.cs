using System;
using System.Collections.Generic;
using System.Text;

namespace testCsharp1
{
    class Guerrier : Personnage , IEpee
    {
        public Guerrier()
        {
            int pv = 10;
            int defense = 5;
            int atk = 10; 
        }
        public override void Deplacement()
        {

        }
         void IEpee.intimidation()
        {
            Console.WriteLine("le guerrier fait tourner son epée pour intimider son adversaire");
        }
        public override void attaquer()
        {
            Console.WriteLine("le guerrier attaque");
        }
    }
}

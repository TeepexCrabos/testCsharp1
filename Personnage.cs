using System;
using System.Collections.Generic;
using System.Text;

namespace testCsharp1
{
    class Personnage
    {
        // Constructor that takes no arguments:
        public Personnage()
        {
            name = "unknown";
            Pv = 100;
            Atk = 10;
            PvMax = 100;
            
        }

        // Constructor that takes one argument:
        public Personnage(string name)
        {
            this.name = name;
            
        }

        // Auto-implemented readonly property:
        public string name { get; set; }
        public int Pv { get; set; }
        public int PvMax { get; set; }
        public int Atk { get; set; }

        public virtual void attaquer() 
        {
            Console.WriteLine("le personnage attaque");
        }
        public void Atk_plus(int valeur1) 
        {
            Atk = Atk + valeur1;
        }
        public void PvMax_Plus(int valeur2)
        {
            PvMax = PvMax + valeur2;
        }

        public void Pv_Plus(int valeur2)
        {
            PvMax_Plus(valeur2);
            Pv = Pv + valeur2;
        }

        
    }
}

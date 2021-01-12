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
            
        }

        // Constructor that takes one argument:
        public Personnage(string name)
        {
            this.name = name;
            
        }

        // Auto-implemented readonly property:
        public string name { get; set; }
        public int Pv { get; set; }
        public int Atk { get; set; }

        public virtual void Deplacement()
        {
            Console.WriteLine("le personnage avance");
        }
        public virtual void attaquer() 
        {
            Console.WriteLine("le personnage attaque");
        }

    }
}

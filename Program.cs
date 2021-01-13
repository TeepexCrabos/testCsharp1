using System;

namespace testCsharp1
{
    class Program
    {
        static void Main(string[] args)
        {



            Console.WriteLine("bonjour a toi aventurier");
            Console.WriteLine("avant toute chose choisie ta classe parmi ces 2 classe 1-Mage 2-Guerrier");
            string saisie = Console.ReadLine();
            int reponse = int.Parse(saisie);
            Personnage perso;
            if (reponse == 1)
            {
                perso = new mage();
            }
            else
            {
                perso = new Guerrier();
                
            }

            while (perso.Pv > 0)
            {

            }


        }
    }
}

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
            if (reponse == 1)
            {
                Personnage perso = new mage();
            }
            else
            {
                Personnage perso = new Guerrier();
            }

            


        }
    }
}

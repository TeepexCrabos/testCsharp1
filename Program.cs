﻿using System;

namespace testCsharp1
{
    class Program
    {
        static void Main(string[] args)
        {



            Console.WriteLine("bonjour a toi aventurier");
            Console.WriteLine("avant toute chose choisie ta classe parmis ces 2 classe 1-Mage 2-Guerrier");
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
            Piece piece = new Piece();

            while (perso.Pv > 0)
            {
                piece.piece_plus();
                Personnage gardien;
                Console.WriteLine("vous entrez dans la piece " + piece.numero);
                Random aleatoire = new Random();
                int NbRand = aleatoire.Next(1,5);

             
                if(NbRand == 1)
                {
                    gardien = new PNJ();
                    gardien.attaqueSpe(perso);

                }
                else
                {
                    int coef = piece.numero * 1000;
                    gardien = new bandit(aleatoire.Next(100, coef), aleatoire.Next(100, coef));
                    while (gardien.Pv > 0 && perso.Pv > 0)
                    {
                        Console.WriteLine("le bandit vous attaque");
                        gardien.attaquer(perso);
                        Console.WriteLine("il vous reste " + perso.Pv + " Pv");
                       
                        int nb = aleatoire.Next(1, 5);
                        if (nb == 1 && perso.Pv > 0)
                        {
                            Console.WriteLine("vous utilisez votre attaque Spéciale");
                            perso.attaqueSpe(gardien);
                            Console.WriteLine("il reste " + gardien.Pv + " Pv a l'ennemie");
                        }
                        else
                        {
                            if (perso.Pv > 0)
                            {
                                Console.WriteLine("vous attaquez");
                                perso.attaquer(gardien);
                                Console.WriteLine("il reste " + gardien.Pv + " Pv a l'ennemie");
                            }
                        }
                    }
                    
                }
                if (perso.Pv > 0)
                {
                    perso.Pv_Plus(aleatoire.Next(1,5));
                    perso.PvMax_Plus(aleatoire.Next(1, 5));
                    perso.Atk_plus(aleatoire.Next(1, 5));
                }
                
            }
            Console.WriteLine("vous avez perdu vous etes arrivé a la piece "+piece.numero);


        }
    }
}

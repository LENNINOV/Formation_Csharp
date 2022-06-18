/*
*=================================================================================+
* Exercce25 :  Le programme permet de saisir plusieurs valeurs numériques (à      |  
*              chaque saisie le choix doit être posé de saisir une autre valeur   |
*              Puis indiquer si la suite est strictement croissante.              |
*              Le control de saisi n'est pas nécessaire.                          |   
*                                                                                 |  
* Author     : LENINOV                                                            |
*                                                                                 |
* Date       : 12 / 12 / 2021                                                     |
* ================================================================================+
*/
using System;

namespace Exercice25
{
    class Program
    {
        static void Main(string[] args)
        {   /***************************\
            //---------Variables-------*\
            ****************************/
            char réponse;
            int valeur,valeur_Rec;
            bool croissant = true;

            // Saisie de la première valeur 
            Console.Write("Valeur : ");
            valeur_Rec = int.Parse(Console.ReadLine());

            // Demander si autre valeur à saisir 
            Console.Write("Voulez vous continuer ? (O/N) : ");
            réponse = Console.ReadKey().KeyChar;
            Console.WriteLine();

            while (réponse == 'O' || réponse == 'o')
            {
                // Saisie d'une valeur 
                Console.Write("Valeur : ");
                valeur = int.Parse(Console.ReadLine());

                // Comparaison avec la valeur précédente 
                if (valeur <= valeur_Rec)
                {
                    croissant = false;
                }

                // Mémorisation de la valeur saisie 
                valeur_Rec = valeur;

                // Demander si autre valeur à saisir 
                Console.Write("Voulez vous continuer ? (O/N) : ");
                réponse = Console.ReadKey().KeyChar;
                Console.WriteLine();
            }

            // Affichage du message final : croissante ou non 
            if (croissant)
            {
                Console.WriteLine("La suite est strictement croissante.");
            }
            else
            {
                Console.WriteLine("La suite n'est pas strictement croissante.");
            }
        }
    }
}

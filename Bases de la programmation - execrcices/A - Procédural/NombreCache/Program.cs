/**
 * Jeu du nombre caché
 * Author : LENINOV
 * date : 11/11/2021
 */

using System;

namespace NombreCache
{
    class Program
    {
        static void Main(string[] args)
        {
            // déclaration 
            int valeur, essai, nbre = 1;

            // saisie un nombre à chercher
            Console.Write("Entrez le nombre à chercher : ");
            valeur = int.Parse(Console.ReadLine());
            Console.Clear();

            // saisie du premier essai
            Console.Write("Entrez un essai : ");
            essai = int.Parse(Console.ReadLine());

            // boucle sur les essais
            while (essai != valeur)
            {

                //test entre l'essai par rapport à la valeur à chercher
                if (essai > valeur)
                {
                    Console.WriteLine("Essai saisi trop grand !");
                }
                else
                {
                    Console.WriteLine("Essai saisi trop petit !");
                }

                // saisie d'un nouvel essai
                Console.Write("Essayez à nouveau : ");
                essai = int.Parse(Console.ReadLine());

                // incrémentation du compteur d'essais
                nbre++;
            }

            // en sortie de boucle, la valeur a été trouvée 
            Console.WriteLine($"Vous avez trouvé en {nbre} éssai(s)");

            // permet de laisser le temps au message de rester afficher
            Console.ReadLine();
        }
    }
}

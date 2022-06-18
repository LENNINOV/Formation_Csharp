/**
* =================================================================================+
* Exercice7 : Le pgm doit permettre de saisir une saise de prix et retourner la    |
*             somme tant que 0 n'a pas été saisie.                                 |            
* Author : LENINOV                                                                 |
* Date : 21/11/2021                                                                |
* =================================================================================+
*/
using System;

namespace Exercice7
{
    class Program
    {
        static void Main(string[] args)
        {
            // Déclarations des variables
            float prix, total = 0;

            // Première saisie (saisie d'amorçage)
            Console.Write("Veuillez saisir un prix (0 pour terminer la saisie) = ");
            prix = float.Parse(Console.ReadLine());

            //Boucle sur la saisie des prix
            // Tant que prix est différent de 0
            while (prix != 0)
            {
                total = total + prix;

                // Saisi d'un nouveau prix
                Console.Write("Veuillez saisir un prix (0 pour terminer la saisie) = ");
                prix = float.Parse(Console.ReadLine());
            }

            // Sorti de boucle et affichage du total des prix
            Console.WriteLine($"Le total des prix est de {total}e.");
        }
    }
}

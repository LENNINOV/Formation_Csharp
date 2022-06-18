/**
* =================================================================================+
* Exercice9 : Le programme permet la saisie de note comprise entre 0 et 20 et      |
*             la restitue si les conditions sont remplies                          |            
* Author    : LENINOV                                                              |
* Date      : 27/11/2021                                                           |
* =================================================================================+
*/
using System;

namespace Exercice9
{
    class Program
    {
        static void Main(string[] args)
        {
            // Déclaration des variables : 
            float saisie;

            // Saisie d'amorçage
            Console.Write("Veuillez saisir une note comprise entre 0 et 20 : ");
            saisie = float.Parse(Console.ReadLine());

            // Tant que la saisie n'est pas comprise entre 0 et 20
            do
            {// Boucle sur la saisie de note
                // Si la première saisie remplie les conditions d'intervalle arret de boucle
                if (saisie >= 0 && saisie <= 20)
                {
                    break;
                }

                // Si la saisie ne remplie pas les conditions
                else if (saisie < 0)
                {
                    Console.Write("Veuillez saisir une note positive : ");
                    saisie = float.Parse(Console.ReadLine());
                }
                
                else
                {
                    Console.Write("Veuillez saisir une note inférieure à 20 : ");
                    saisie = float.Parse(Console.ReadLine());
                }

            } while (saisie < 0 || saisie > 20);

            // Sortie de boucle et affichage 
            Console.WriteLine("                          ");
            Console.WriteLine($"Vous avez saisie {saisie}");
            Console.WriteLine("                          ");
        }
    }
}

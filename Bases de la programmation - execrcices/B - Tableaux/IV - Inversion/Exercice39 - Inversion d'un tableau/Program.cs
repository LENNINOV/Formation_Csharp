/**************************************************************************\
 * Description : Saisie d'un vecteur de n cases. Les éléments permuttent   |
 *               (1er avec dernier, 2e avec avant dernier, ...).           |
 *               L'inversion se fait directement dans le même vecteur.     |
 *               Affichage du vecteur inversé.                             | 
 *                                                                         | 
 * Author : LENINOV                                                        | 
 *                                                                         | 
 * Date : 28/01/2022                                                       | 
/**************************************************************************/
using System;

namespace Exercice39
{
    class Program
    {
        static void Main(string[] args)
        {
            // saisie de la taille du vecteur 
            Console.Write("Veuillez saisir la taille du tableau : ");
            int n = int.Parse(Console.ReadLine());

            // Paramétrage du vecteur 
            int[] vecteur = new int[n];

            // Alimentation du vecteur 
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Indice n°{i + 1} : ");
                vecteur[i] = int.Parse(Console.ReadLine());
            }

            // inversion du vecteur
            // i < n/2 car si dépasse la moitié ré-inversion
            for (int i = 0; i < n/2; i++)
            {
                // Echange triangulaire
                int sauv = vecteur[i];
                vecteur[i] = vecteur[n - i - 1];
                vecteur[n - i - 1] = sauv;
            }

            // Affichage du vecteur inversé
            Console.WriteLine("Vecteur inversé : ");

            for (int i = 0; i < n; i++)
            {
                Console.Write($"{vecteur[i]}, ");
            }
        }
    }
}

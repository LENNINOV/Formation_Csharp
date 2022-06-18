/**************************************************************************\
 * Description : Saisie d'un vecteur de n cases et affiche chaque étape de |
 *               l'état du vecteur suivant un algo de tri par séléction,   |
 *               jusqu'à ce qu'il soit trié.                               | 
 *                                                                         | 
 * Author : LENINOV                                                        | 
 *                                                                         | 
 * Date : 31/12/2021                                                       | 
/**************************************************************************/
using System;

namespace Exercice33
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variables 
            int sauvegarde = 0;

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

            // Premier affichage du vecteur non trié
            for (int i = 0; i < n; i++)
            {
                Console.Write($"{vecteur[i]}, ");
            }

            // Début algorythme de tri par séléction
            // a chaque tour, avance de 1
            for (int i = 0; i < n; i++)
            {
                // recherche de la plus petite valeur
                for (int j = i; j < n; j++)
                {
                    // Echange de valeur entre les trois cases
                    if (vecteur[j] < vecteur[i])
                    {
                        sauvegarde = vecteur[i];
                        vecteur[i] = vecteur[j];
                        vecteur[j] = sauvegarde;
                    }
                }
                // Affichage intermédiaire en cours de tri
                Console.WriteLine();               
                for (int k = 0; k < n; k++)
                {
                    Console.Write($"{vecteur[k]}, ");
                }
            }
        }
    }
}

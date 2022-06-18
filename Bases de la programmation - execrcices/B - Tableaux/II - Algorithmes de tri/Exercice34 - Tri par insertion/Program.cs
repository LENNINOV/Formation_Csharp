/**************************************************************************\
 * Description : Saisie d'un vecteur de n cases et affiche chaque étape de |
 *               l'état du vecteur suivant un algo de tri par insertion,   |
 *               jusqu'à ce qu'il soit trié.                               | 
 *                                                                         | 
 * Author : LENINOV                                                        | 
 *                                                                         | 
 * Date : 04/01/2022                                                       | 
/**************************************************************************/
using System;

namespace Exercice33
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variables 
            int en_cours = 0, j;


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

            // Début algorythme de tri par insertion
            // commence à indice 1 du vecteur 
            // a chaque tour, avance de 1
            for (int i = 1; i < n; i++)
            {
                // Isolemet de l'indice 1 du vecteur 
                en_cours = vecteur[i];
                // Transfert de l'indice pour boucle suivante
                j = i - 1;
                // Décallage des éléments du vecteur 
                while (j >= 0 && en_cours < vecteur[j])
                {
                    vecteur[j+1] = vecteur[j];
                    j--;
                }
                // Insertion de l'élément à la place 
                vecteur[j+1] = en_cours;

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

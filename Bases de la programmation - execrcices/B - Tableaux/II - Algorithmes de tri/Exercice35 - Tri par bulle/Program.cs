/**************************************************************************\
 * Description : Saisie d'un vecteur de n cases et affiche chaque étape de |
 *               l'état du vecteur suivant un algo de tri par bulle,       |
 *               jusqu'à ce qu'il soit trié.                               | 
 *                                                                         | 
 * Author : LENINOV                                                        | 
 *                                                                         | 
 * Date : 06/01/2022                                                       | 
/**************************************************************************/
using System;

namespace Exercice35
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variables 
            int sauv = 0, passage = 0;
            // Initialisation de la condition d'échnage 
            bool échange;

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

            //========================================//
            // ---Début algorythme de tri par bulle---//
            //========================================//

            // Répéter action ...
            do
            {
                // Ré initialisation de la condition d'échange à chaque tour 
                // Initialisation pour le premier tour 
                échange = false;

                // Pour l'index i variant de 1 a n-1-passage
                for (int i = 0; i < n - passage - 1; i++)
                {
                    if (vecteur[i] > vecteur[i + 1])
                    {
                        // Echanger la case i et la case i+1
                        sauv = vecteur[i + 1];
                        vecteur[i + 1] = vecteur[i];
                        vecteur[i] = sauv;

                        // Set de la condition à vraie
                        échange = true;
                    }
                }

                // Affichage intermédiaire en cours de tri
                Console.WriteLine();
                for (int k = 0; k < n; k++)
                {
                    Console.Write($"{vecteur[k]}, ");
                }

                passage++;
                // ... tant qu'il y a échnage 
            } while (échange);
        }
    }
}



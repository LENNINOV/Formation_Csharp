/**************************************************************************\
 * Description : Saisie de plusieurs villes (après avoir saisi le nombre). |
 *               Affichage unique du nom de la ville, et de la frequence   |
 *               d'apparition.                                             | 
 *                                                                         | 
 * Author : LENINOV                                                        | 
 *                                                                         | 
 * Date : 06/02/2022                                                       | 
/**************************************************************************/
using System;

namespace Exercice41
{
    class Program
    {
        struct StrVille
        {
            public string nom;
            public int frequence;
        }

        static void Main(string[] args)
        {
            // Saisie du nombre de villes
            Console.Write("Combien de ville(s) devez vous saisir ? : ");
            int n = int.Parse(Console.ReadLine());

            // Paramétrage du tableau 
            StrVille[] lesVilles = new StrVille[n];
            int nbVilles = 0;

            // Alimentation du tableau
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Ville n° {i + 1} : ");
                string ville = Console.ReadLine();
                
                // Recherche dans le tableau
                int j = 0;
                while(j < nbVilles-1 && ville != lesVilles[j].nom)
                {
                    j++;
                }
                if(ville == lesVilles[j].nom)
                {
                    // ville déjà présente
                    lesVilles[j].frequence++;
                }
                else
                {
                    // nouvelle ville
                    lesVilles[nbVilles].nom = ville;
                    lesVilles[nbVilles].frequence = 1;
                    nbVilles++;
                }
            }

            // Afichage des fréquences par ville
            Console.WriteLine();
            for(int k = 0; k <nbVilles; k++)
            {
                Console.WriteLine($"{lesVilles[k].nom} apparait {lesVilles[k].frequence} foi(s).");
            }
        }
    }
}

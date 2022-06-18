/**************************************************************************\
 * Description : Saisie de plusieurs températures entières :               |
 *                                   Min : -20                             |
 *                                   Max : +40                             |
 *               Saisie du nombre de températures à entrer. Pour chaque    |
 *               températures, affichage de sa fréquence d'apparition.     |
 * ------------------------------------------------------------------------|
 *               Avec optimisation, retrait de la deuxième boucle pour     |
 *               l'affichage. Tableau de fréquences au lieu de temp.       |
 *               Gain = traitement / n                                     | 
 *                                                                         | 
 * Author : LENINOV                                                        | 
 *                                                                         | 
 * Date : 30/01/2022                                                       | 
/**************************************************************************/
using System;

namespace Exercice40
{
    class Program
    {
        static void Main(string[] args)
        {
              //******************//
             //----CONSTANTES----//
            //******************//
            int Max = 40, Min = -20;

            //******************//
            //----VARIABLES-----//
            //******************//
            int temp; 

            // saisie de la taille du vecteur 
            Console.Write("Veuillez saisir le nombre de températures " +
                          "(Température maximale = 40°C" +
                          " Température minimale = - 20°C) : ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();

            // Paramétrage du vecteur 
            int[] fréquence = new int[61];

            // initialisation du tableau de fréquence 
            for (int i = 0; i < 61; i++)
            {
                fréquence[i] = 0;
            }

            // Saisie des températures 
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Température n°{i + 1} : ");
                temp = int.Parse(Console.ReadLine());

                // Contrôle de la saisie
                while(temp < Min || temp > Max)
                {
                    // Si la température est supérieure à 40 
                    if(temp > Max)
                    {
                        Console.WriteLine("ATTENTION ! LA TEMPERATURE " +
                                          "SAISIE EST SUPERIEUR A 40°C !");
                    }
                    // Si la température est supérieure à 40 
                    else if (temp < Min)
                    {
                        Console.WriteLine("ATTENTION ! LA TEMPERATURE " +
                                          "SAISIE EST INFERIEURE A -20°C !");
                    }
                    Console.Write($"Température n°{i + 1} : ");
                    temp = int.Parse(Console.ReadLine());
                }
                fréquence[temp + 20]++;
            }

            // Comptage du nombre d'apparition
            // Parcours du vecteur pour une valeur
            for (int i = 0; i < 61; i++)
            {
                // Affichage du nombre d'apparrition
                if (fréquence[i] != 0)
                {
                    Console.WriteLine("------------------------------------------");
                    Console.WriteLine($"Température : {i-20} / {fréquence[i]} apparition(s).");
                    Console.WriteLine("------------------------------------------");
                }
            }
        }
    }
}

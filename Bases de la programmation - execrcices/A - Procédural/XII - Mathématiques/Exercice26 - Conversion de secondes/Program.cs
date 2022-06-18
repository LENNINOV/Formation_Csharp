/*
*=================================================================================+
* Exercce26 :  Le programme permet de saisir un nombre de seconde (entre 0 et     |  
*              86400). L'affichage est la conversion sous forme HH:MM:SS. Il doit |
*              y avoir 2 positions pour chaque valeur, donc éventuellemenent en   |
*              ajoutant 0 quand nécessaire.                                       |  
*                                                                                 |  
* Author     : LENINOV                                                            |
*                                                                                 |
* Date       : 12 / 12 / 2021                                                     |
* ================================================================================+
*/
using System;

namespace Exercice26
{
    class Program
    {
        static void Main(string[] args)
        {
            // Déclarations des variables
            int secondes, HEURES=0, MINUTES=0, SECONDES=0;
            string format = "00";

            // Saisie du nombre de secondes 
            Console.Write("Veuillez siaisr un nombre de secondes (entre 0 et 86400) : ");
            secondes = int.Parse(Console.ReadLine());

            // Boucle sur la répartitions des H, M, S
            for (int i = secondes; i > 0; i--)
            {
                SECONDES++;

                if (SECONDES > 59)
                {
                    MINUTES++;
                    SECONDES = 0;
                }
                if (MINUTES > 59)
                {
                    HEURES++;
                    MINUTES = 0;
                }
            }

            // Affichage des secondes converties au bon format
            Console.WriteLine($"{HEURES.ToString(format)}:" +
                              $"{MINUTES.ToString(format)}:" +
                              $"{SECONDES.ToString(format)}");
        }
    }
}

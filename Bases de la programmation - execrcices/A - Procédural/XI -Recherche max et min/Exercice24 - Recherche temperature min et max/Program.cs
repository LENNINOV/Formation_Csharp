/*
*=================================================================================+
* Exercce24 :  Le programme permet de saisir 10 températures (neg ou pos, sans    |
*              bornes fixes). Affichage de la plus petite et la plus grande temp. |
*                                                                                 |
* Author     : LENINOV                                                            |
*                                                                                 |
* Date       : 09 / 12 / 2021                                                     |
* ================================================================================+
*/
using System;

namespace Exercice24
{
    class Program
    {
        static void Main(string[] args)
        {
            // Déclaration des variables.
            int TempMax = 0, TempMin = 0;

            // Instruction à effectuer
            Console.WriteLine("Veuillez saisir 10 températures.");

            // Boucle sur les 10 temp à saisir.
            for (int i=0; i<10; i++)
            {
                Console.Write($"Température {i + 1} : ");
                int température = int.Parse(Console.ReadLine());

                if (TempMax < température)
                {
                    TempMax = température;
                }
                else
                {
                    TempMin = température;
                }
            }

            // Affichage de la température min et max.
            Console.WriteLine($"La température minimale enregistrée est de {TempMin} °C.");
            Console.WriteLine($"La température maximale enregistrée est de {TempMax} °C.");
        }
    }
}

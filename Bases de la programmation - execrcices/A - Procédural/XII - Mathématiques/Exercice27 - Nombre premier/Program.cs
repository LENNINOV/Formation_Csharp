/*
*=================================================================================+
* Exercce27 :  Le programme permet de saisir un entier et de dire s'il est premier|
*              ou non. Un nombre est premier s'il ne peut être divisé que par un  |
*              et par lui même. Plusieurs entiers peuvent être testés, pour       |  
*              stopper la saisie saisir 0.                                        |
*                                                                                 |  
* Author     : LENINOV                                                            |
*                                                                                 |
* Date       : 16 / 12 / 2021                                                     |
* ================================================================================+
*/

using System;

namespace Exercice27
{
    class Program
    {
        static void Main(string[] args)
        {
            // VARIABLES \\
            int entier, modulo;
            double racineN;

            // Saisie de la première valeur 
            Console.Write("Veuillez saisir un entier (0 pour stopper la saisie) : ");
            entier = int.Parse(Console.ReadLine());

            while (entier != 0)
            {
                // 1ere initialisation
                bool premier = true;

                if (entier > 3)
                {
                    // Calcul du nombre de diviseur à tester
                    racineN = Math.Sqrt(entier);

                    // 1 et l'entier lui même sont obligatoirement des diviseurs de entier
                    for (int i = 2; i <= racineN; i++)
                    {
                        // calcul du modulo
                        modulo = entier % i;

                        // un modulo égale à zéro signifie que le nombre n'est pas premier
                        if (modulo == 0)
                        {
                            // Arrêt de la boucle dès que modulo vaut 0
                            premier = false;
                            break;
                        }
                    }
                }

                if (!premier)
                {
                    Console.WriteLine($"{entier} n'est pas un nombre premier.");
                    // réinitialisation du booléen
                    premier = true;
                }
                else
                {
                    Console.WriteLine($"{entier} est un nombre premier.");
                }

                // Saisie de la première valeur 
                Console.Write("Veuillez saisir un entier (0 pour stopper la saisie) : ");
                entier = int.Parse(Console.ReadLine());
                
            }
        }
    }
}

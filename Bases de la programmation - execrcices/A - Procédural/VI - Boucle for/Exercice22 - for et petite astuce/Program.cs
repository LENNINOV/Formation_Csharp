/*
*=================================================================================+
* Exercce22 :  Le programme permet de saisir 10 notes et afficher le nb de > 10,  |
*              et ou égale à la moyenne (10) et le nombre de notes inférieures à  |
*              Le control de la saisie n'est pas nécessaire.                      |
*                                                                                 |
* Author     : LENINOV                                                            |
*                                                                                 |
* Date       : 09 / 12 / 2021                                                     |
* ================================================================================+
*/
using System;
using System.Collections.Generic;

namespace Exercice22
{
    class Program
    {
        static void Main(string[] args)
        {
            // Déclarations des listes
            int nbSEG10 = 0;
            // Saisie des 10 notes
            Console.WriteLine("Veuillez saisir 10 notes (comprises entre 0 et 20 inclus) : ");

            // Saisie en boucle des notes 
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Note n° {i+1} : ");
                int note = int.Parse(Console.ReadLine());

                // Tri des notes 
                if(note >= 10)
                {
                    nbSEG10++;
                }
            }
            Console.WriteLine($"Nombre de notes supérieures ou égales à la moyenne = {nbSEG10}");
            Console.WriteLine($"Nombre de notes inférieures à la moyenne = {10 - nbSEG10}");
        }
    }
}

/**
* ==================================================================================+
* Exercice12 : Affichage de la table de 3 sous forme 3 x 0 = 0, 3x1 = 1, ...        |
* Author     : LENINOV                                                              |
* Date       : 27/11/2021                                                           |
* ==================================================================================+
*/
using System;

namespace Exercice12
{
    class Program
    {
        static void Main(string[] args)
        {
            // Déclaration de la constante et des variable 
            int table = 3;
            Console.WriteLine($"Table de multiplication de {table} : ");

            // Boucle for pour chaque ligne de la table de 3
            for (int i = 0; i < 11; i++)
            {
                int résultat = table * i;
                Console.WriteLine($"{table} x {i} = {résultat}");
            }
        }
    }
}

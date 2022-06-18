/*
*===================================================================================+
* Exercice18 : Le pgm permet de saisir 3 double et afficher le plus petit, sans if. |
*                                                                                   |
* Author     : LENINOV                                                              |
*                                                                                   |
* Date       : 04 / 12 / 2021                                                       |
* ================================================================================== +
*/

using System;
using System.Collections.Generic;

namespace Exercice18
{
    class Program
    {
        static void Main(string[] args)
        {
            // Saisi des trois nombres
            Console.WriteLine("Veuillez saisir 3 nombre : ");
            double n1 = double.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine());
            double n3 = double.Parse(Console.ReadLine());

            // Affichage du nombre le plus petit avec la fonction Math.Min(double1, double2)
            Console.Write($"Le plus petit nombre saisi est : {Math.Min(n1, Math.Min(n2, n3))}");
        }
    }
}

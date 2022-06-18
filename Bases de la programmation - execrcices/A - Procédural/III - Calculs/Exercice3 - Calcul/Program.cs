/**
* =================================================================================+
* Exercice3 : Saisie d'une somme de notes et le nombre. Et affichage de la moyenne |
* Author : LENINOV                                                                 |
* Date : 11/11/2021                                                                |
* =================================================================================+
*/
using System;

namespace Exercice3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Déclaration des variables
            double somme;
            double nombre;

            // Saisie de la somme et du nombre de notes
            Console.Write("Entrez la somme des notes = ");
            somme = double.Parse(Console.ReadLine());
            Console.Write("Entrez le nombre de notes = ");
            nombre = double.Parse(Console.ReadLine());

            double moyenne = somme / nombre;

            // Affichage de la moyenne
            Console.WriteLine($"La moyenne de ses {nombre} notes est : {moyenne}");
        }
    }
}

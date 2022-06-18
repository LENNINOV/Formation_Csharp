/**
* ==================================================================================+
* Exercice13 : Saisi d'un entier compris entre 1 et 9 (controle de la saisie) et    |
*              afficher la table de multiplication de cette entier.                 |
* Author     : LENINOV                                                              |
* Date       : 27/11/2021                                                           |
* ==================================================================================+
*/
using System;

namespace Exercice13
{
    class Program
    {
        static void Main(string[] args)
        {
            // Déclaration de la constante.
            int table;

            // Affichage la selection de la table
            Console.Write("Quelle table de multiplication (de 1 à 9) voulez vous afficher ? -> ");
            table = int.Parse(Console.ReadLine());

            // Tant que l'utilisateur n'a pas saisie un multiple compris entre 1 et 9
            while (!(table >= 1 && table <= 9))
            {
                Console.Write("vauillez saisir une table de multiplication comprise entre 1 et 9 !");
                table = int.Parse(Console.ReadLine());
            }

            // Affichage du choix de la table 
            Console.WriteLine($"Table de multiplication de {table} : ");

            // Boucle for pour chaque ligne de la table séléctionnée
            for (int i = 0; i < 11; i++)
            {
                int résultat = table * i;
                Console.WriteLine($"{table} x {i} = {résultat}");
            }
        }
    }
}

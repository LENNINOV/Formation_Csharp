/**
* =================================================================================+
* Exercice8 : Le programme saisit un prix tant que l'utilisateur renseigne qu'il en|
*             a à saisir. Puis affichage de la somme de ceux là.                   |            
* Author : LENINOV                                                                 |
* Date : 20/11/2021                                                                |
* =================================================================================+
*/
using System;

namespace Exercice8
{
    class Program
    {
        static void Main(string[] args)
        {
            // Déclaration des variables 
            float prix, total = 0;

            // Choix : un prix est à saisir ou non
            Console.WriteLine("Avez vous un prix à saisir ? (O/N) : ");
            ConsoleKeyInfo choix = Console.ReadKey(true);

            while(choix.Key == ConsoleKey.O)
            {
                // Saisi d'un prix par l'utilisateur
                Console.Write("Veuillez saisir un prix : ");
                prix = float.Parse(Console.ReadLine());

                // Ajout du prix à la totalité
                total = total + prix;

                // Nouveau choix de l'utilisateur
                Console.WriteLine("Avez vous un autre prix à saisir ? (O/N) : ");
                choix = Console.ReadKey(true);
            }

            // Affichage du montant total des prix saisis. 
            Console.WriteLine($"Le montant total des prix saisis est de : {total}e.");
        }
    }
}

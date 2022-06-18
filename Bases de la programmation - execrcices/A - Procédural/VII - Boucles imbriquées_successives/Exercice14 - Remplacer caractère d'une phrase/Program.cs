/**
* ==================================================================================+
* Exercice14 : Evolution de 13 avec affichages de plusieurs tables :                |
*             - Une fois la 1ere table afficher -> demandez                         |
*             - "Voulez vous afficher une nouvelle table de multiplication ? (O/N)" |
*             - Test a faire a chaque fin d'affichage                               |
*             - Le test doit aussi être fait pour uniquement O ou N                 |
*             - L'écran est éffacé entre deux affichges                             |
*                                                                                   |
* Author     : LENINOV                                                              |
*                                                                                   |
* Date       : 27/11/2021                                                           |
* ==================================================================================+
*/
using System;

namespace Exercice14
{
    class Program
    {
        static void Main(string[] args)
        {
            // Déclaration des variables.
            int table;
            char choix;

            // saisie du choix d'afficher ou non une table
            Console.Write("Voulez vous afficher une table de multiplication ? (O/N) : ");
            choix = Console.ReadKey().KeyChar;

            // Si l'utilisateur saisie une autre valeur que O ou N 
            while (choix != 'O' && choix != 'o' && choix != 'N' && choix != 'n')
            {
                Console.Write("\nVeuillez saisir O ou N.");
                choix = Console.ReadKey().KeyChar;

                if (choix == 'N' || choix == 'n')
                {
                    // Sortie de boucle avec saisie n
                    Console.WriteLine("\nAucune table de multiplication à afficher.");
                    break;
                }
            }

            // Si l'utilisateur décide de ne pas afficher de table.
            if (choix == 'N' || choix == 'n')
            {
                // Sortie de boucle avec saisie n
                Console.WriteLine("\nAucune table de multiplication à afficher.");
            }

            // Boucle générale : tant que l'utilisateur veut afficher faire
            while (choix == 'O' || choix == 'o')
            {
                // Saisir la table à afficher
                Console.Write("\nQuelle table de multiplication (de 1 à 9) voulez vous afficher ? -> ");
                table = int.Parse(Console.ReadLine());

                // Tant que l'utilisateur n'a pas saisie un multiple compris entre 1 et 9
                while (!(table >= 1 && table <= 9))
                {
                    Console.Write("\nVeuillez saisir une table de multiplication comprise entre 1 et 9 !");
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

                Console.Write("\nVoulez vous afficher une nouvelle table de multiplication ? (O/N) : ");
                choix = Console.ReadKey().KeyChar;
                // Efface l'affichage précédent 
                Console.Clear();

                // Si il décide de ne pas afficher de table sortir de la boucle
                if (choix == 'N' || choix == 'n')
                {
                    // Sortie de boucle avec saisie n
                    Console.WriteLine("\nPlus de tables de multiplication à afficher.");
                    break;
                }
            }
        }
    }
}

/**************************************************************************\
 * Description : Saisie le nom et la moyenne des étudiants. Puis afficher  |
 *               les noms des étudiants au dessus de la moyenne de la      |
 *               classe.                                                   |
 *               Le nombre d'étudiants doit être saisi dès le début du pgm |
 *               et servira de dimension au tableau.                       |
 *                                                                         | 
 * Author : LENINOV                                                        | 
 *                                                                         | 
 * Date : 23/12/2021                                                       | 
/**************************************************************************/
using System;

namespace Exercice32
{
    class Program
    {
        // Déclaration de la structure
        struct StrEtudiant
        {
            public string nom;
            public float moyenne;
        }

        static void Main(string[] args)
        {
            // Variables
            float moyenneClasse = 0;

            // Saisie du nombre d'étudiants 
            Console.Write("Nombre de moyenne à saisir : ");
            int nb = int.Parse(Console.ReadLine());

            // Déclaration du tableau
            StrEtudiant[] etudiant = new StrEtudiant[nb];

            // Saisie des noms et moyennes des étudiants
            for (int i = 0; i<nb; i++)
            {
                // Saisie du nom 
                Console.Write($"Etudiant n°{i + 1}, nom : ");
                etudiant[i].nom = Console.ReadLine();

                // Saisie de la moyenne 
                Console.Write($"Etudiant n°{i + 1}, moyenne : ");
                etudiant[i].moyenne = float.Parse(Console.ReadLine());
                moyenneClasse = moyenneClasse + etudiant[i].moyenne;
            }

            // Calcul de la moyenne de la classe 
            moyenneClasse = moyenneClasse / nb;

            foreach (var etud in etudiant)
            {
                if (etud.moyenne > moyenneClasse)
                {
                    Console.WriteLine($"{etud.nom} dépasse la moyenne de classe ({moyenneClasse}/20) avec {etud.moyenne}/20.");
                }
            }
        }
    }
}

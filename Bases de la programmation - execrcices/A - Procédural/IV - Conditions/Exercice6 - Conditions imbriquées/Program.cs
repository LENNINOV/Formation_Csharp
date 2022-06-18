/**
* =================================================================================+
* Exercice6 : Saisie d'une moyenne avec retour de message selon la valeur :        |
*             Mention très bien pour x > 16, bien x >= 14, assez bien >= 12,       |
*             recalé x < 10.                                                       |
* Author : LENINOV                                                                 |
* Date : 13/11/2021                                                                |
* =================================================================================+
*/
using System;

namespace Exercice6
{
    class Program
    {
        static void Main(string[] args)
        {
            // Déclaration des variables 
            float moyenne;

            // Saisie de la moyenne 
            Console.Write("Bonjour veuillez saisir la moyenne de l'élève : ");
            moyenne = float.Parse(Console.ReadLine());

            // Test de moyenne 
            if (moyenne >= 16)
            {// mention très bien.
                Console.Write($"Mention Très bien, l'élève est admis avec {moyenne} de moyenne générale.");
            }
            else if (moyenne >= 14 && moyenne < 16)
            {// mention bien.
                Console.Write($"Mention Bien, l'élève est admis avec {moyenne} de moyenne générale.");
            }
            else if (moyenne >= 12 && moyenne < 14)
            {// mention assez bien.
                Console.Write($"Mention Assez bien, l'élève est admis avec {moyenne} de moyenne générale.");
            }
            else if (moyenne >= 10 && moyenne < 12)
            {// Passable.
                Console.Write($"L'élève a obtenu {moyenne} de moyenne générale. Et est admis.");
            }
            else
            {// Recalé
                Console.Write($"L'élève a obtenu {moyenne} de moyenne générale. Et est recalé.");
            }
        }
    }
}

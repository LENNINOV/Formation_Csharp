/**
* ==================================================================================+
* Exercice15 : le pgm doit permettre à l'utilisateur de saisir une phrase et de la  |
*              retourner en remplaçant les espaces par des tirats.                  | 
*                                                                                   |
* Author     : LENINOV                                                              |
*                                                                                   |
* Date       : 29/11/2021                                                           |
* ==================================================================================+
*/
using System;

namespace Exercice15
{
    class Program
    {
        static void Main(string[] args)
        {
            // Déclaration des variables 
            string phrase;

            // Saisie de la phrase d'origine 
            Console.WriteLine("Veuillez saisir une phrase.");
            phrase = Console.ReadLine();

            // Remplacement des espace par des tirets 
            Console.WriteLine(phrase.Replace(' ', '-'));
        }
    }
}

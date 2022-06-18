/*
*=================================================================================+
* Exercce23 :  Le programme permet de saisir n notes (entre 0 et 20 compris)      |
*              décidé par l'utilisateur. Puis afficher la note la plus grande et  |
*              la plus petite. Le control de la saisie n'est pas nécessaire.      |
*                                                                                 |
* Author     : LENINOV                                                            |
*                                                                                 |
* Date       : 09 / 12 / 2021                                                     |
* ================================================================================+
*/
using System;

namespace Exercice23
{
    class Program
    {
        static void Main(string[] args)
        {
            // Déclaration des variables
            int noteMin = 0, noteMax = 0;

            // Demande du nombre de notes à saisir 
            Console.Write("Combien de notes avez vous à saisir ? : ");
            int nombreNotes = int.Parse(Console.ReadLine());

            // Boucle sur le nombre de notes
            for (int i = 0; i < nombreNotes; i++)
            {
                Console.Write($"Note n°{i + 1} : ");
                int note = int.Parse(Console.ReadLine());

                if (note > noteMax || note == noteMax)
                {
                    noteMax = note;
                }
                else
                {
                    noteMin = note;
                }
            }

            // Affichage de la note max et de la min
            if (nombreNotes > 0)
            {
                Console.WriteLine($"La meilleure note saisie est {noteMax}.");
                Console.WriteLine($"La pire note saisie est {noteMin}.");
            }
            else
            {
                Console.WriteLine("Vous n'avez pas saisie de notes.");
            }
        }
    }
}

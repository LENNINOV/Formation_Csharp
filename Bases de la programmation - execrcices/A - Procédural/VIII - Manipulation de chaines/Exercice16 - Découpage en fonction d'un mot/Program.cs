/**
* ==================================================================================+
* Exercice16 : le pgm doit permettre à l'utilisateur de saisir une phrase et puis   |
*              un mot. Si le mot est présent dans la phrase, la restituer à partir  | 
*              du mot saisi, sinon signaler par un message                          |
* Author     : LENINOV                                                              |
*                                                                                   |
* Date       : 02/12/2021                                                           |
* ==================================================================================+
*/
using System;

namespace Exercice16
{
    class Program
    {
        static void Main(string[] args)
        {
            // Déclaration des variable 
            string u_phrase, u_mot;

            // Saisi de la phrase
            Console.WriteLine("Veuillez saisir une phrase : ");
            u_phrase = Console.ReadLine();
            // Saisi du mot
            Console.WriteLine("Veuillez saisir un mot : ");
            u_mot = Console.ReadLine();

            // Recherche de l'index du mot dans la phrase
                            // Si il n'y a pas de correspondance le int = -1 par défaut
            int indexMot = u_phrase.IndexOf(u_mot);
            
            // Test de correspondance entre le mot et la phrase 
            if (indexMot != -1)
            {
                // Affichage de la phrase à partir de ce mot 
                Console.WriteLine($"{u_phrase.Substring(indexMot)}");
            }

            else
            {
                Console.WriteLine("Le mot que vous avez saisit ne se trouve pas dans la phrase.");
            }

        }
    }
}

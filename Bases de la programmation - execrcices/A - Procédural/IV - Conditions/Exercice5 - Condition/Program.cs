/**
* =================================================================================+
* Exercice5 : Saisie d'un age, affichage majeur pour +=18 sinon mineur avec différ-|
*             ence d'années avant sa majorité.                                     |
* Author : LENINOV                                                                 |
* Date : 13/11/2021                                                                |
* =================================================================================+
*/
using System;

namespace Exercice5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Déclaration des variables du pgm.
            int age;

            // Saisie de l'age par l'utilisateur.
            Console.Write("Bonjour, veuillez saisir votre age : ");
            age = int.Parse(Console.ReadLine());

            // Test de majorité.
            if (age >= 18)
            {// affichage du message de majorité.
                Console.Write("Vous êtes majeur.");
            }
            else
            {// affichage de la différence d'années avant la majorité.
                Console.Write("Vous êtes mineur. Votre majorité est dans : " + (18 - age) + " an(s).");
            }
        }
    }
}

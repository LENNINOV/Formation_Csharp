/**
* ==================================================================================+
* Exercice10 : Le programme permet la saisie du sexe de l'individu (forme H ou F),  |
*              afficher Bonjour Monsieur ou madame, et controler la saisie.         |            
* Author     : LENINOV                                                              |
* Date       : 27/11/2021                                                           |
* ==================================================================================+
*/
using System;

namespace Exercice10
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaration des variables 
            char sexe;

            // saisie du sexe contrôlée
            Console.Write("Bonjour, veuillez saisir votre sexe (F/H) : ");
            sexe = Console.ReadKey().KeyChar;

            do
            {// Boucle sur la saisie de l'utilisateur

                //Si la première saisie est correcte stopper la boucle
                if (sexe == 'H' || sexe == 'F')
                {
                    break;
                }
                
                //Sinon continuer la boucle 
                else
                {
                    Console.Write("\nVeuillez saisir votre sexe (F/H) : ");
                    sexe = Console.ReadKey().KeyChar;
                }

            } while (!(sexe == 'H' || sexe == 'F'));

            // Sortie de boucle et test de condition
            // Affichage personnalisé : si la saise est H = Monsieur sinon = Madame
            if (sexe == 'H')
            {
                Console.WriteLine("\nBonjour Monsieur.");
            }

            else
            {
                Console.WriteLine("\nBonjour Madame."); 
            }
        }
    }
}


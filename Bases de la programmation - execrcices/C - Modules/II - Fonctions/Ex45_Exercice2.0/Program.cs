/*
* ==================================================================================+
* Exercice10 : Le programme permet la saisie du sexe de l'individu (forme H ou F),  |
*              afficher Bonjour Monsieur ou madame, et controler la saisie.         |            
* Author     : LENINOV                                                              |
* Date       : 27/11/2021                                                           |
*                                                                                   |
* ==================================================================================+
* Exercice45 : Le programme permet la saisie du sexe de l'individu (forme H ou F),  |
*              afficher Bonjour Monsieur ou madame, et controler la saisie.         |            
* Author     : LENINOV                                                              |
* Date       : 12/02/2022                                                           |
* ==================================================================================+
*/
using System;

namespace Ex45_Exercice2._0
{
    class Program
    {
        /***********************************************
         * Saisie d'une réponse parmis deux caractères.*
         ***********************************************/
        static char saisie(string message, char H, char F)
        {
            char réponse;
            //Avez vous un prix à saisir ?
            do
            {
                // Choix : un prix est à saisir ou non
                Console.Write($"\n{message} ({H}/{F}) : ");
                réponse = Console.ReadKey().KeyChar;
            } while (réponse != H && réponse != F);
            return réponse;
        }

        static void Main(string[] args)
        {
            // Declaration des variables 
            char sexeDde, sexeH = 'H', sexeF = 'F';
            string message = "Bonjour, veuillez saisir votre sexe";

            // saisie du sexe contrôlé
            sexeDde = saisie(message, sexeH, sexeF);

            // Affichage personnalisé : si la saise est H = Monsieur sinon = Madame
            if (sexeDde == sexeH)
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

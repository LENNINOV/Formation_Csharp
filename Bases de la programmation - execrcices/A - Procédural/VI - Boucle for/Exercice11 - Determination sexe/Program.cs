/**
* ==================================================================================+
* Exercice11 : Le programme permet la saisie de 5 valeurs puis afficher leur moyenne|
* Author     : LENINOV                                                              |
* Date       : 27/11/2021                                                           |
* ==================================================================================+
*/
using System;

namespace Exercice11
{
    class Program
    {
        static void Main(string[] args)
        {
            // Déclaration des variables 
            float valeur, moyenne, somme = 0, n = 0;

            // Affichage de la consigne du programme
            Console.WriteLine("Veuillez saisir 5 valeurs.");

            for (int i = 1; i < 6; i++)
            {
                // Saisie de chaque valeur avec leur indice
                valeur = float.Parse(Console.ReadLine());
                Console.WriteLine($"Note {i} = {valeur}");

                // Calcul de la somme a chaque tour de boucle
                somme = valeur + somme;
                // Incrémentation du nombre de valeur
                n = i;
            }

            // A la fin de boucle :
            // Calcul de la moyenne a chaque tour de boucle 
            moyenne = somme / n;
            // Affichage la moyenne
            Console.WriteLine($"La moyenne de ces 5 valeurs est de : {moyenne}");
        }
    }
}


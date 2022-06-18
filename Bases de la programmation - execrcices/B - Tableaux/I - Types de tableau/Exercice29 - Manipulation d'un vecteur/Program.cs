/*************************************************************************\
 * Description : Saisie de 365 températures et afficher le nombre au       | 
 *               dessus de la moyenne. Les tests ne doivent pas dépasser   | 
 *               10 températures.                                          | 
 *               Initialisation d'une taille de 365. Utilisé a chaque fois |
 *               pour la valeur 365.                                       | 
 *               Pour le test passer à 10 en taille.                       | 
 *                                                                         | 
 * Author : LENINOV                                                        | 
 *                                                                         | 
 * Date : 20/12/2021                                                       | 
/**************************************************************************/
using System;

namespace Exercice29
{
    class Program
    {
        static void Main(string[] args)
        {
            // Déclaration variables 
            int nbTemp, xbarre, somme = 0, count = 0;

            // initilisation de la taille du tableau 
            Console.WriteLine("Combien de températures voulez-vous saisair ? : ");
            nbTemp = int.Parse(Console.ReadLine());
            
            // Alimentation du tableau 
            Console.WriteLine($"Veuillez entrez {nbTemp} températures : ");
            
            int[] températures = new int[nbTemp];
            for(int i = 0; i<températures.Length; i++)
            {
                températures[i] = int.Parse(Console.ReadLine());
                somme = somme + températures[i];
            }

            // Calcul de la moyenne des températures saisies 
            xbarre = somme / nbTemp;

            // Comparaison entre les températures et la moyennes
            foreach (var température in températures)
            {
                if (température > xbarre)
                {
                    count ++;
                }
            }

            // Affichage nb de température au dessus de la moyenne 
            Console.WriteLine($"{count} température(s) dépasse(nt) la moyenne ({xbarre}°C).");
        }
    }
}

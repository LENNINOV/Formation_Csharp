/****************************************************************************************
 * Description : Saisi d'un nombre de villes, puis les saisir en les rengeant dans un   |
 *               vecteur (dimensionné par rapport au nombre à saisir).                  |
 *               Après la saisie, appel d'une PROCEDURE avec en paramètres : le vecteur |
 *               et la ville saisie.                                                    |
 *               La PROCEDURE doit chercher la ville dans le vecteur et si elle est     |
 *               présente, elle doit être supprimée.                                    |
 *               La suppression se fait en déclant les cases suivantes pour ne pas avoir|
 *               de case vide dans le vecteur. Une fois le décalage fait, la dernière   |
 *               case sera vidée avec " ".                                              |
 *               Affichage du vecteur par le MAIN, sans la case vide si elle l'a été.   |
 *               Affichage également de l'indice à la saisie et à l'affichage du vecteur|
 *               -----------------------------------------------------------------------+
 * Author      : LENNINOV                                                               |
 * Date        : /02/2022                                                             |
 * =====================================================================================+
 */
using System;

namespace Ex53
{
    class Program
    {
        /*
         * Alimentation en boucle d'un vecteur de taille definie 
         * avec suppression des doublons
         */
        static void saisieVilles(string[] pVect)
        {
            // Alimentation du vecteur 
            for (int i = 0; i < pVect.Length; i++)
            {
                Console.Write($"Ville n°{i + 1} : ");
                pVect[i] = Console.ReadLine();
            }
        }

        /*
         * Suppression d'une case dans un vecteur 
         * en fonction d'une valeur  
         */
        static int supprVec(string[] pVect, string pValeur)
        {
            // Parcours du vecteur => recherche de la valeur 
            int j = 0;
            while (j < pVect.Length - 1 && pValeur != pVect[j])
            {
                j++;
            }
            // Contrôle en sortie de boule (valeur trouvée ?)
            if (pValeur == pVect[j])
            {
                // Suppression de la case contenant la valeur 
                for (int k = j; k < pVect.Length - 1; k++)
                {
                    pVect[k] = pVect[k + 1];
                }
                pVect[pVect.Length - 1] = "";

                // retour de la nouvelle taille du vecteur 
                return pVect.Length - 1;
            }
            // Retour de la taille du vecteur 
            return pVect.Length;
        }

        static void affichageVille(string[] pVect, int pTaille)
        {

            for (int i = 0; i < pTaille; i++)
            {
                Console.Write($"\nVille n°{i + 1}   : {pVect[i]}");
            }
        }

        static void Main(string[] args)
        {
            // Saisie de la limite du vecteur
            Console.Write("Combien de ville(s) devez vous saisir ? ");
            int n = int.Parse(Console.ReadLine());

            // Initialisation du vecteur 
            string[] Villes = new string[n];

            // Alimentation du vecteur 
            saisieVilles(Villes);

            // Saisie de la ville à Supprimer 
            Console.Write("Ville à supprimer : ");
            string ville = Console.ReadLine();

            // Tentative de suppression de la ville dans le vecteur 
            int newTaille = supprVec(Villes, ville);

            // Affichage du vecteur saisi (sans doublons)
            affichageVille(Villes, newTaille);
        }
    }
}

/******************************************************************************************
 * Description : Jeu du nombre caché (nouvelle verison)                                   *   
 * Author      : LENINOV                                                                  *  
 * Date        : 08/02/2022                                                               *
 *                                                                                        *  
 ******************************************************************************************
 * Description : Exemple de fonction. Remplacer les procédures par des fonctions.         * 
 * Author      : LENINOV                                                                  * 
 * Date        : 09/02/2022                                                               * 
 *                                                                                        *  
 ******************************************************************************************
 * Description : Exemple de fonction avec paramètres. Ajouter des paramètres aux nouvelles*
 *               fonctions                                                                *  
 * Author      : LENINOV                                                                  * 
 * Date        : 10/02/2022                                                               * 
 *                                                                                        *  
 *****************************************************************************************/

using System;

namespace ExempleModuleNbCache
{
    class Program
    {
        /*******************************************************
        * saisie d'un nombre entre 2 bornes (inf et sup)
        *******************************************************/

        static int saisie(string message, int inf, int sup)
        {
            int nombre;
            do
            {
                // saisie du premier essai
                Console.Write($"{message} (entre {inf} et {sup}) : ");
                nombre = int.Parse(Console.ReadLine());

            } while (nombre < inf || nombre > sup);
            return nombre;
        }

        static void Main(string[] args)
        {
            // déclaration 
            int valeur, essai, nbre = 1,
                Mini = 0, Maxi = 100;
            
            string valMsg = "Entrez le nombre à chercher",
                   essMsg = "Entrez un éssai";

            // saisie du nombre à chercher
            valeur = saisie(valMsg, Mini, Maxi);
            Console.Clear();

            // saisie du premier essai
            essai = saisie(essMsg, Mini, Maxi);

            // boucle sur les essais
            while (essai != valeur)
            {
                //test entre l'essai par rapport à la valeur à chercher
                if (essai > valeur)
                {
                    Console.WriteLine("Essai saisi trop grand !");
                }
                else
                {
                    Console.WriteLine("Essai saisi trop petit !");
                }

                // Saisie d'un nouvel essai
                essai = saisie(essMsg, Mini, Maxi);

                // incrémentation du compteur d'essais
                nbre++;
            }

            // en sortie de boucle, la valeur a été trouvée 
            Console.WriteLine($"Vous avez trouvé en {nbre} éssai(s)");
        }
    }
}

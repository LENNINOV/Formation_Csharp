/**************************************************************************\
 * Description : Saisie d'un vecteur de n cases puis d'une valeur à        |
 *               chercher. Cette dernière se fait de manière séquentielle. |
 *               Un message doit préciser si la valeur a été trouvée ou non| 
 *               Si elle est trouvée, renvoyer sa position dans le vecteur.|
 *                                                                         | 
 * Author : LENINOV                                                        | 
 *                                                                         | 
 * Date : 10/01/2022                                                       | 
/**************************************************************************/
using System;

namespace Exercice36
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variables 
            int count = 0;
            // Initialisation du vecteur
            Console.Write("Veuillez saisir la taille du tableau : ");
            int n = int.Parse(Console.ReadLine());

            // Paramétrage du vecteur 
            int[] vecteur = new int[n];

            // Alimentation du vecteur 
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Indice n°{i + 1} : ");
                vecteur[i] = int.Parse(Console.ReadLine());
            }

            // Saisie de la valeur à chercher
            Console.Write("Saisir une valeur : ");
            int valeur = int.Parse(Console.ReadLine());
            // Recherche de la saisie dans le vecteur 
            for (int i = 0; i < n; i++)
            {
                // La valeur à rechercher est présente dans le vecteur 
                if (vecteur[i] == valeur)
                {
                    Console.WriteLine($"La valeur {valeur} a été trouvée à la position {i+1} du vecteur.");
                    count++;
                }

            }
            // Si le conteur est à 0 affichage de la non similarité
            if (count == 0)
            {
                Console.WriteLine("Aucune(s) de cette(ces) valeur(s) ne se trouve(nt) dans le vecteur.");
            }
        }
    }
}

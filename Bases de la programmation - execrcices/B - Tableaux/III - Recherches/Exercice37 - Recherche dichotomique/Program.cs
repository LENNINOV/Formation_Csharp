/**************************************************************************\
 * Description : Saisie d'un vecteur de n cases puis d'une valeur à        |
 *               chercher. Cette dernière se fait de manière DICHOTOMIQUE. |
 *               Un message doit préciser si la valeur a été trouvée ou non| 
 *               Si elle est trouvée, renvoyer sa position dans le vecteur.|
 *                                                                         | 
 * Author : LENINOV                                                        | 
 *                                                                         | 
 * Date : 19/01/2022                                                       | 
/**************************************************************************/
using System;

namespace Exercice37
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variables 
            bool correspondance = false;

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

            // Variables pour positions crochets du vecteur
            int a = 0;
            int b = vecteur.Length - 1;
            int m = (a + b) / 2;

            while (a < b && !correspondance)
            {
                if (vecteur[m] == valeur)
                {
                    correspondance = true;
                }
                else if (vecteur[m] > valeur)
                {
                    b = m - 1;
                }
                else
                {
                    a = m + 1;
                    m = (a + b) / 2;
                }
            } 

            if (!correspondance)
                Console.WriteLine($"{valeur} n'a pas été trouvé dans le vecteur.");
            else
                Console.WriteLine($"{valeur} trouvé à l'indice {m + 1} du vecteur.");
        }
    }
}

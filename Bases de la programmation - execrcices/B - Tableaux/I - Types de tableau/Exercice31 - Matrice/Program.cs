/**************************************************************************\
 * Description : Saisie d'une matrice en 2D et afficher son determinant.    |
 *               LA saisie des éléments doit être :                         |
 *               "Entrez la valeur de la ligne 1, colonne 2 : "             |
 *               /!\ manipulation des indices, la valeur de L1 C2 doit être |
 *               placée en [0, 1] de la matrice.                            |
 *               Pour calculer le determinant :                             |
 *                              | a  b |                                    |
 *                              |      | = ad - bc                          |
 *                              | c  d |                                    |
 *                                                                          | 
 * Author : LENINOV                                                         | 
 *                                                                          | 
 * Date : 22/12/2021                                                        | 
/**************************************************************************/
using System;

namespace Exercice31
{
    class Program
    {
        static void Main(string[] args)
        {
            // Déclaration des variables 
            int determinant;

            int[,] matrice = new int[2, 2];

            // Alimentation en boucle du tableau 
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write($"Entrez la valeur de la ligne {i + 1}, colonne {j + 1} : ");
                    matrice[i, j] = int.Parse(Console.ReadLine());
                }
            }

            // Calcul et affichage du determinant 
            determinant = (matrice[0, 0] * matrice[1, 1]) - (matrice[0, 1] * matrice[1, 0]);
            Console.WriteLine($"Le déterminant de votre matrice est {determinant}.");
        }
    }
}

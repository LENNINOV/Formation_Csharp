/****************************************************************************************
 * Description : Saisi d'un nombre de notes, puis les saisir en les rengeant dans un    |
 *               vecteur (dimensionné par rapport au nombre à saisir).                  |
 *               Puis affichage de la moyenne en appelant une fonction avec en paramètre|
 *               double, le vecteur et retourne la moyenne.                             |
 *               -----------------------------------------------------------------------+
 *               Obtenir la taille du vecteur = nom_du_vecteur.Lenght.                  |
 *               -----------------------------------------------------------------------+
 * Author      : LENNINOV                                                               |
 * Date        : 20/02/2022                                                             |
 * =====================================================================================+
 */
using System;

namespace Ex52
{
    class Program
    {
        /*
         * Saisi d'un vecteur dimensionné 
         */
        static void saisieNotes(double[] array)
        {
            // Saisi des notes dans le tableau 
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"Note n°{i + 1} = ");
                array[i] = double.Parse(Console.ReadLine());
            }
        }

        /*
         * Calcul de la moyenne d'un vecteur alimenté 
         * et retourne l'affichage 
         */
        static double Moyenne(double[] pNotes)
        {
            double somme = 0;
            
            // Somme des notes saisie dans le tableau 
            for (int i = 0; i < pNotes.Length; i++)
            {
               somme =+ pNotes[i];
            }
            return (somme/pNotes.Length);
        }


        static void Main(string[] args)
        {
            // Saisie de la taille du vecteur 
            Console.Write("Combien de notes devez vous saisir ? : ");
            int n = int.Parse(Console.ReadLine());

            // Initialisation du tableau 
            double[] Notes = new double[n];

            // Remplissage du tableau 
            saisieNotes(Notes);

            // Calcul et affichage de la moyenne 
            Console.WriteLine($"La moyenne est de {Moyenne(Notes)}");
        }
    }
}

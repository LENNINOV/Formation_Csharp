/*
*===================================================================================+
* Exercice20 : Le pgm permet de saisir un nom de ville et un nombre d'habitants     |
*              puis d'afficher le résultat :                                        |
*              "Grasse possède 35000 habitants."                                    |
*                                                                                   |
* Author     : LENINOV                                                              |
*                                                                                   |
* Date       : 05 / 12 / 2021                                                       |
* ================================================================================== +
*/
using System;

namespace Exercice20
{
    class Program
    {
        static void Main(string[] args)
        {
            // saisie du nom de la ville 
            Console.Write("Veuillez saisir un nom de ville : ");
            string ville = Console.ReadLine();
            // saisie du nombre d'habitants
            Console.Write("Veuillez saisir un nombre d'habitants : ");
            int habitants = int.Parse(Console.ReadLine());

            // Affichage du message personnalisé
            Console.Write($"{ville} possède {habitants} habitants.");
        }
    }
}

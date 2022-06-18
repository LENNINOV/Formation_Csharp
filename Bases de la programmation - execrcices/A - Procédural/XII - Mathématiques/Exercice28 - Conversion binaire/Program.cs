/*
*=================================================================================+
* Exercce28  : Le pgm permet de convertir un nb entier en binaire.                |
*              Boucler sur les conversion (arret de saisie avec 0).               |  
*              E.g : 43(10) = 101011(2) :                                         |  
*               - Diviser n(10), successivement par 2 div (div entières) et       |  
*                 récupérer les restes des div en les concaténant dans le sens    |
*                 inverse.                                                        |  
*              => 43/2 = 21 + 1                                                   |  
*                 21/2 = 10 + 1                                                   |  
*                 10/2 =  5 + 0                                                   |  
*                  5/2 =  2 + 1                                                   |  
*                  2/2 =  1 + 0                                                   |  
*                  1/2 =  0 + 1                                                   |  
*                                                                                 |  
*              Concaténation des restes dans une variable chaïne, et à l'envers = |
*               ajout du nouveau reste à chaque fois au début de la chaine.       |  
*                                                                                 |  
* Author     : LENINOV                                                            |
*                                                                                 |
* Date       :  / 12 / 2021                                                     |
* ================================================================================+
*/
using System;

namespace Exercice28
{
    class Program
    {
        static void Main(string[] args)
        {
            // Déclaration des variables 
            int base10;
            

            // Première saisie du nombre entier 
            Console.Write("Veuillez saisir un entier à convertir en binaire (0 pour arrêter la saisie) : ");
            base10 = int.Parse(Console.ReadLine());


            // Boucle tant que l'entier n'est pas 0
            while (base10 != 0)
            {
                // Conversion en binaire
                string base2 = "";
                while (base10 != 0)
                {
                    int reste = base10 % 2;
                    base2 = reste + base2;
                    base10 = base10 / 2;
                }

                // Affichage de la conversion 
                Console.WriteLine($"{base10} vaut en binaire {base2}");

                // Saisie d'un autre entier à convertir
                Console.Write("Veuillez saisir un entier à convertir en binaire (0 pour arrêter la saisie) : ");
                base10 = int.Parse(Console.ReadLine());
            }
        }
    }
}

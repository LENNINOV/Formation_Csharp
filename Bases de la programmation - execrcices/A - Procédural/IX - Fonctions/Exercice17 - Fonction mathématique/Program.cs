/**
* ==================================================================================+
* Exercice17 : Le pgm permet de saisir un nombre et de demander sa racine. Si c'est |
*              la bonne réponse "bravo" sinon "trompé et afficher la bonne réponse  | 
*              sous la forme :"Erreur, la racine carrée de 9 est 3"                 |
*                                                                                   |
* Author     : LENINOV                                                              |
*                                                                                   |
* Date       : 04/12/2021                                                           |
* ==================================================================================+
*/
using System;

namespace Exercice17
{
    class Program
    {
        static void Main(string[] args)
        {
            // Saisi du nombre
            Console.Write("Veuillez saisir un nombre : ");
            int nombre = int.Parse(Console.ReadLine());

            // Saisie de la racine carrée
            Console.Write("Veuillez saisir la racine carrée : ");
            double racine = double.Parse(Console.ReadLine());

            // Comparaison entre la racine et le nombre
            if(racine == Math.Sqrt(nombre))
            {
                Console.WriteLine("Bravo vous avez la bonne réponse !!!!");
            }
            else
            {
                Console.WriteLine($"Erreur, la racine carrée de {nombre} est {Math.Sqrt(nombre)}");
            }
        }
    }
}

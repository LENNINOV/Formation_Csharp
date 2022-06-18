/**
 * ===================================+
 * Exercice1 : affichage personnalisé |
 * Author : LENINOV                   |  
 * Date : 11/11/2021                  |  
 * ===================================+
 */

using System;

namespace Exercice1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Déclarations de 3 variables : nom, prénom, age
            string nom, prénom;
            int age;

            // initialisation des variables avec les valeurs de l'utilisateur
            Console.Write("Bonjour, \nVeuillez saisir votre NOM : ");
            nom = Console.ReadLine();
            Console.Write("Veuillez saisir votre Prénom : ");
            prénom = Console.ReadLine();
            Console.Write("Veuillez saisir votre age : ");
            age = int.Parse(Console.ReadLine());

            //Affichage d'un messsage forme (Bonjour + prénom + nom + age)
            Console.WriteLine($"Bonjour {prénom} {nom}, vous avez {age} ans.");
        }
    }
}

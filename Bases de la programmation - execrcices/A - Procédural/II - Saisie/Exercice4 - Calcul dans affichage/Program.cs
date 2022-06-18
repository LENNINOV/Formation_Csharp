/**
* =================================================================================+
* Exercice4 : Saisie d'un prix HT, un taux de TVA, affichage du prix TTC           |
* Author : LENINOV                                                                 |
* Date : 12/11/2021                                                                |
* =================================================================================+
*/
using System;

namespace Exercice4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Déclaration des variables 
            float prixHT;
            float TVA;

            //Saisie des variables 
            Console.Write("Veuillez saisir un prix hors taxes : ");
            prixHT = float.Parse(Console.ReadLine());
            Console.Write("Veuillez saisir un taux de TVA : ");
            TVA = float.Parse(Console.ReadLine());

            //Calcul avec affichage du prix TTC
            Console.Write("Le prix TTC pour cet article est de : " + (prixHT)*(1+(TVA/100)) + "e");

        }
    }
}

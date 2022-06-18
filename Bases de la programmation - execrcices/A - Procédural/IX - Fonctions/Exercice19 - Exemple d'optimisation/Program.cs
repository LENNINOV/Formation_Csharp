/*
*===================================================================================+
* Exercice19 : Le pgm permet de saisir un montant. Si il est > 40e, la remise est de|
*              10%. De 20 à 40 de 5%. Le taux de remise et le montant à payer       |
*              doivent être affichés sous la forme :                                |
*              "Montant = 45,5 avec une remise de 10 %"                             |
*              Le code à optimiser est en annexe                                    |
*                                                                                   |
* Author     : LENINOV                                                              |
*                                                                                   |
* Date       : 05 / 12 / 2021                                                       |
* ================================================================================== +
*/
using System;

namespace Exercice19
{
    class Program
    {
        static void Main(string[] args)
        {
            // Saisi du montant 
            Console.Write("Entrez un montant : ");
            float montant = float.Parse(Console.ReadLine());

            // calcul de la remise 
            float remise = 0;
            if (montant > 40)
            {
                remise = 10;
            }
            else if (montant >= 20)
            {
                remise = 5;
            }

            // Affichage du nouveau montant et de la remise
            montant = montant * (1 - remise / 100);
            Console.WriteLine($"Montant = {montant } avec une remise de {remise}%.");
        }
    }
}

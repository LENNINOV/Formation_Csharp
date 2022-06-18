using System;

namespace Exercice50
{
    class Program
    {
        /*static int abs(int n)
        {
            /*
             ****************************************************
             * FONTION >>> Converti un nombre en valeur absolue *
             ****************************************************
            if (n < 0)
            {
                return -n;
            }

            else
            {
                return n;
            }

        }*/

        /*
         * PROCEDURE >>> Converti un nombre en valeur absolue 
         */
        static void abs(int n, ref int result)
        {
            if (n < 0)
            {
                result = -n;
            }
            else
            {
                result = n;
            }
        }

        static void Main(string[] args)
        {
            Console.Write("Saisir un nombre : ");
            int nombre = int.Parse(Console.ReadLine());

            // Récupération de la valeur absolue par procédure 
            int valAbs = 0;
            abs(nombre, ref valAbs);

            //Affichage de la valeur absolue par procédure 
            Console.WriteLine($"Valeur absolue : {valAbs}.");

            // Afffichage en utilisant la fonction 
            //Console.WriteLine($"{nombre} vaut : {abs(nombre)}.");
        }
    }
}

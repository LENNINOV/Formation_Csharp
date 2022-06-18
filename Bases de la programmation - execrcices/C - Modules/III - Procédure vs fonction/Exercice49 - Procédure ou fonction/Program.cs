using System;


namespace Exercice49
{
    class Program
    {
        /* PROCEDURE >>> Calcul distance entre deux entier et 
         *               renvoie un résultat positif        */
        /*static void distance(int val1, int val2, ref int result)
        {
            if (val1 > val2)
            {
                result = val1 - val2;
            }
            else
            {
                result = val2 - val1;
            }
        }*/

        static int distance(int val1, int val2)
        {
            int result;
            if (val1 > val2)
            {
                result = val1 - val2;
            }
            else
            {
                result = val2 - val1;
            }
            return result;
        }

            static void Main(string[] args)
        {
            // saisie des 2 nombres
            Console.Write("Entrez le premier nombre entier = ");
            int nb1 = int.Parse(Console.ReadLine());
            Console.Write("Entrez le deuxième nombre entier = ");
            int nb2 = int.Parse(Console.ReadLine());

            /* calcul de la distance avec procédure 
            * int différence = 0;
            * distance(nb1, nb2, ref différence);
            */

            // affichage de la distance 
            Console.WriteLine($"Distance entre {nb1} et {nb2} = {distance(nb1, nb2)}");
            Console.ReadLine();
        }
    }
}

/****************************************************************************************
 * Description : Deux entiers sont dits amis si les sommes des chiffres les composant   |
 *               sont identiques.                                                       |
 *               Exemples : 43 et 205 sont amis car 4+3=7 et 2+0+5=7.                   |   
 *               Ecrire une fonction booléenne 'amis' qui reçoit en paramètre 2 nombres |
 *               entiers et retourne vrai si ils sont amis.                             |
 *               -----------------------------------------------------------------------+
 *               Avant d'écrire la fonction, il est conseillé d'écrire une fonction qui |
 *               reçoit en paramètre un nombre et qui retourne la somme des chiffres qui|
 *               constituent ce nombre.                                                 |
 *               -----------------------------------------------------------------------+
 *               Pour faire la somme des chiffres d'un nombre, il faut séparer les      |
 *               chiffres, ce qui est possible en récupérant les restes de divisions    |
 *               successives par 10.                                                    |
 *               -----------------------------------------------------------------------+
 *               Le pgm permet de boucler sur la saisie de deux nombres et de dire à    |
 *               chaque fois si les 2 nombres sont amis, en exploitant la fonction.     |
 *               Entre les saisie, demander si continuer ou non.                        |
 *               -----------------------------------------------------------------------+
 * Author      : LENNINOV                                                               |
 * Date        : 14/02/2022                                                             |
 * =====================================================================================+
 */


using System;

namespace Ex46_FonctionsParamétrées
{
    class Program
    {
        /*=============================================================================*
         *____ Saisie d'une réponse parmis O ou N ____                                 * 
         *=============================================================================*/
        static char saisie(string message, char O, char N)
        {
            char réponse;
            //Avez vous un prix à saisir ?
            do
            {
                // Choix : un prix est à saisir ou non
                Console.Write($"\n{message} ({O}/{N}) : ");
                réponse = Console.ReadKey().KeyChar;
            } while (réponse != O && réponse != N);

            return réponse;
        }

        /*============================================================================*
        *____ Somme des chiffres qui composent un nombre ____                         * 
        *=============================================================================*/
        static int sommeChiffres(int nombre)
        {
            int somme = 0;
            while (nombre != 0)
            {
                somme += nombre % 10;
                nombre /= 10;
            }
            return somme;
        }

        /*=============================================================================*
         *____ Somme des chiffres d'un entier saisi ____                               * 
         *=============================================================================*/
        static bool Amis(int nb1, int nb2)
        {
            return (sommeChiffres(nb1) == sommeChiffres(nb2));
        }

        /*=============================================================================*
         *___MAIN___                                                                   * 
         *=============================================================================*/
        static void Main(string[] args)
        {
            // Déclaration constantes//
            string message = "Veuillez saisir deux nombres entiers : ",
                   question = "Voulez vous continuer ? ";
            char O = 'O', N = 'N', continuer;

            // Déclaration variables// 
            int entier1, entier2;

            do
            {
                // Saisie d'un nombre entier 
                Console.WriteLine(message);
                entier1 = int.Parse(Console.ReadLine());
                entier2 = int.Parse(Console.ReadLine());

                Console.WriteLine("----------------------------------------------------");
                if (Amis(entier1, entier2))
                {
                    Console.WriteLine($"{entier1} et {entier2} sont amis !");
                }
                else
                {
                    Console.WriteLine($"{entier1} et {entier2} ne sont pas amis !");
                }
                continuer = saisie(question, O, N);

            } while (continuer == O);
        }
    }
}

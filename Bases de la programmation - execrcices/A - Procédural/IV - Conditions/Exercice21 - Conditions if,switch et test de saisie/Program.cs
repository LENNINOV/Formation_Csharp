/*
*=================================================================================+
* Exercce21 :  Le pgm permet de récupérer une couleur de feu (offcellement par un |
*              capteur, sous forme de sase R = rouge, O = orange, V = vert) et    |
*              affcher l'ordre qu dot être exécutée : "s'arrêter", "ralentr",     |
*              "passer". la sase de la couleur dot être contrôlée.                |
*              Deux versons du pgm dovent être crées :                            |
*                                                       - Avec f mbrqués.         | 
*                                                       - Avec swtch .            |
*                                                                                 |
* Author     : LENINOV                                                            |
*                                                                                 |
* Date       : 08 / 12 / 2021                                                     |
* ================================================================================+
*/
using System;

namespace Exercce21
{
    class Program
    {
        static void Main(string[] args)
        {
            /****************************************
             *     if imbriqués                     * 
             * **************************************/

            // Déclaration des variable
            char feu;

            // Saisie de la couleur du feu  
            do
            {
                Console.Write("Couleur du feu (R/O/V) : ");
                feu = Console.ReadKey().KeyChar;

            } while (feu != 'R' && feu != 'O' && feu != 'V');

            // Affichage de l'ordre correspondant
            if (feu == 'R')
            {
                Console.WriteLine("s'arrêter");
            }
            else
            {
                if (feu == 'O')
                {
                    Console.WriteLine("ralentir");
                }
                else
                {
                    Console.WriteLine("passer");
                }
            }

            /****************************************
             *     switchs                          * 
             * **************************************/

            // Déclaraton de l'enregstrement du capteur 
            Console.Write("Capteur2 : ");
            string capteur2 = Console.ReadLine();

            // Test de la couleur du feu avec f mbrqués :
            switch (capteur2)
            {
                case "V":
                    // Vert => ordre = passer
                    Console.WriteLine("passer");
                    break;

                case "O":
                    // Orange => ralentr 
                    Console.WriteLine("ralentir");
                    break;

                default:
                    // Dans tous les autres cas => s'arrêter
                    Console.WriteLine("s'arrêter");
                    break;
            }
        }
    }
}

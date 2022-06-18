/**************************************************************************\
 * Description : EX 42 => Saisie de plusieurs prix et affichage du total.  |
 *               Contrôle de saisie avec "Avez-vous un prix à saisir ?     |
 *               (O/N) " avec un seul caractère sans valider, avec contrôle|
 *               de O ou N. Si saisi de N, total des prix affiché et FIN.  |
 * Author      : LENINOV                                                   | 
 * Date        : 08/02/2022                                                | 
 *                                                                         | 
 * ************************************************************************|
 * Description : Exercice 43 => transformer la procédure de Ex42 en fction.|
 * Author      : LENINOV                                                   | 
 * Date        : 09/02/2022                                                | 
 *                                                                         |  
 * ************************************************************************|
 * Description : Exercice 44 => Modifier la fonction saisie dans Ex43 pour |
 *               qu'elle reçoive 3 paramètres :                            |
 *                - Le début du message à afficher (jusqu'au "?" inclus)   |
 *                - 2 caractères à contrôler.                              |
 *               Modifier le contenu de la fonction pour prendre en compte |
 *               ces paramètres.                                           | 
 *               Modifier le contenu de la fonction (dans Main) pour       |
 *               envoyer les bonnes valeurs.                               | 
 *                                                                         | 
 * Author      : LENINOV                                                   | 
 * Date        : 11/02/2022                                                | 
 *                                                                         | 
/**************************************************************************/

using System;

namespace Ex42_PremModule
{
    class Program
    {
        static char saisie(string message, char O, char N)
        {
            char choix;
            //Avez vous un prix à saisir ?
            do
            {
                // Choix : un prix est à saisir ou non
                Console.Write($"{message} ({O}/{N}) : ");
                choix = Console.ReadKey().KeyChar;
            } while (choix != O && choix != N);
            return choix;
        }


        static void Main(string[] args)
        {
            char question, O = 'O', N = 'N';
            string message = "Avez vous un prix à saisir ?";
            float prix, total = 0;

            question = saisie(message, O, N);

            while (question == O)
            {
                // Saisi d'un prix par l'utilisateur
                Console.Write("\nVeuillez saisir un prix : ");
                prix = float.Parse(Console.ReadLine());
                // Ajout du prix à la totalité
                total = total + prix;
                // Nouveau choix de l'utilisateur
                question = saisie(message, O, N);
            }

            // Affichage du montant total des prix saisis. 
            Console.WriteLine( "\n- - - - - - - - - - - - - - - - - - - - - - - - - ");
            Console.WriteLine($"\nLe montant total des prix saisis est de : {total}e.");

        }
    }
}

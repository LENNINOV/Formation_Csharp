/**************************************************************************************************************************************\
 * Description : Saisie en boucle de calcul en notation polonaise et affichage du résultat. Une fonction paramétrée qui renvoie le     |
 *               résultat.                                                                                                             | 
 *               Le main boucle sur la saisie de la formule polonaise (en posant le question pour arrêter). La saisie de la notation   |
 *               polonaise doit se faire en séparant les différentes valeurs et signes d'opération par des espaces. Par exemple :      |
 *               / 7 * + 4 3 - 10 8 => l'expression 4+3 se note + 4 3 (se lit "addition de 4 et 3")                                    | 
 *                                  => l'expression (4+3)*5 se note * + 4 3 5 (multiplication de l'addition de 4 et 3, par 5)          |     
 *                                  => l'expression 7/((4+3)*(10-8)) se note / 7 * + 4 3 - 10 8 (division de 7 par la multiplication   |
 *                                     de, l'addition de 4 et 3, par, la soustraction de 10 et 8).                                     |      
 *               Déclarer un vecteur de chaine de 100 cases. Chaque case contient une chaine (qui est soit un des 4 signes des         |
 *               mathématiques, soit un nombre au format chaine).                                                                      | 
 *                                                                                                                                     | 
 * Author      : LENINOV                                                                                                               |                     
 * Date        :  /03/2022                                                                                                             | 
 **************************************************************************************************************************************/

using System;
using System.Linq;

namespace Ex55_EcriturePolonaise
{
    class Program
    {
        /*===============================================FONCTION======================*
         *>>>> Saisie d'une réponse parmis O ou N >>>>                                 * 
         *===============================================FONCTION======================*/
        static char Saisie(string pMessage, char pO, char pN)
        {
            char réponse;

            do
            {
                Console.WriteLine($"{pMessage} ({pO} / {pN})");
                réponse = Console.ReadKey().KeyChar;

                if (réponse != pO && réponse != pN)
                {
                    Console.WriteLine("Veuillez saisir O ou N pour valider votre réponse !");
                }

            } while (réponse != pO && réponse != pN);

            return réponse;
        }

        /*===============================================FONCTION======================*
         *>>>> Saisie d'une formule mathématique au format string >>>>                 * 
         *===============================================FONCTION======================*/
        static string SaisieFormule(string pMessage)
        {
            Console.Write(pMessage);
            string formule = Console.ReadLine();
            return formule;
        }

        /*===============================================FONCTION======================*
         *>>>> Décompose une formule de string à un vecteur de valeurs >>>>            * 
         *===============================================FONCTION======================*/
        static float EcriturePolonaise(String pFormule)
        {
            // Découpage à chaque espace du paramètre d'entrée
            string[] Valeurs = pFormule.Split(' ');

            // Nombre de case remplie 
            int Longueur = Valeurs.Length;

            // Boucle tant qu'il reste plus d'une case
            while (Longueur > 1)
            {
                // Recherche d'un signe depuis la fin du vecteur
                int i = Longueur - 1;
                while (i>0 && Valeurs[i] != "+" && Valeurs[i] != "-"
                           && Valeurs[i] != "*" && Valeurs[i] != "/")
                {
                    i--;
                }

                // Assignation des valeurs
                float nb1 = float.Parse(Valeurs[i + 1]);
                float nb2 = float.Parse(Valeurs[i + 2]);
                float résultat = 0;

                switch (Valeurs[i])
                {
                    case "+":
                        résultat = nb1 + nb2;
                        break;

                    case "-":
                        résultat = nb1 - nb2;
                        break;

                    case "*":
                        résultat = nb1 * nb2;
                        résultat = nb1 * nb2;
                        break;

                    case "/":
                        résultat = nb1 / nb2;
                        break;

                    default:
                        break;
                }

                // Stockage du résultat 
                Valeurs[i] = résultat.ToString();

                // Décallage de 2 cases pour la suite du vecteur (supp 2 cases)
                for (int j = i + 1; j < Longueur - 2; j++)
                {
                    Valeurs[i] = Valeurs[j + 2]; 
                }
                Longueur -= 2;
            }

            // Retourner le résultat
            return float.Parse(Valeurs[0]);
        }

        static void Main(string[] args)
        {
            //>>> Constantes >>>//
            char continuer = 'O', arret = 'N', stop;
            string CtrlSaisie = "Continuer ?";
            string Consigne = "Entrez votre formule (format écriture polonaise et séparé par un espace) : ";

            //>>> Début pgm principal >>>//

            do
            {
                // Saisie de la formule pour envoie à la fonction de calcul
                string formule = SaisieFormule(Consigne);

                // Affichage du résultat 
                Console.WriteLine($"Résultat : {EcriturePolonaise(formule)}");

                stop = Saisie(CtrlSaisie, continuer, arret);


            } while (stop != arret);

        }
    }
}

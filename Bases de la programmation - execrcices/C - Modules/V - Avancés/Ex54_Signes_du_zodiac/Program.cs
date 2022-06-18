/**************************************************************************************************************************************\
 * Description :Saisie en boucle de la saisie d'un jour et d'un mois (controle de saisie suivante), et affichage du signe du zodiaque  |
 *              correspondant.                                                                                                         |     
 *              Une FONCTION reçoit en paramètre UN JOUR et UN MOIS, qui retourne le signe correspondant.                              |
 *                                                                                                                                     |      
 *              Aide : Le tableau doit être rempli case par case en séparant chaque élément de la structure. Donc 12*3 = 36 lignes,    |
 *              (12 signes, 3 éléments dans la structure). Le remplissage doit être dans l'ordre des dates.                            | 
 *                                                                                                                                     | 
 * Author      : LENINOV                                                                                                               |                     
 * Date        : 06/03/2022                                                                                                            | 
 **************************************************************************************************************************************/
using System;

namespace Ex54_Signes_du_zodiac
{
    class Program
    {

        /*===============================================STRUCTURE=====================*
         *>>>> Strucutre des signes du zodiaque >>>>                                   * 
         *===============================================STRUCTURE=====================*/
        public struct StrSignes
        {
            public string signe;
            public int jour;
            public int mois;
        }


        /*===============================================FONCTION======================*
         *>>>> Saisie d'une réponse parmis O ou N >>>>                                 * 
         *===============================================FONCTION======================*/
        static char saisie(string pMessage, char pO, char pN)
        {
            char réponse;
            
            // Début de boucle 
            do
            {
                
                Console.Write($"\n{pMessage} ({pO}/{pN}) : ");
                réponse = Console.ReadKey().KeyChar;

                // Controle de la saisie, boucle tant que différent de O ou 
            } while (réponse != pO && réponse != pN);

            // Retrour de la fonction : Oui ou Non (O / N)
            return réponse;
        }

        /*===============================================FONCTION======================*
         *>>>> Renvoie le signe astrologique en fonction d'un jour et mois >>>>        * 
         *===============================================FONCTION======================*/
        static string signeAstrologique (int pJour, int pMois)
        {
            // Paramétrage du tableau
            StrSignes[] signes = new StrSignes[12];

            // Remplissage du tableau 
            signes[0].signe = "Bélier";     signes[0].jour = 21;  signes[0].mois = 3;
            signes[1].signe = "Taureau";    signes[1].jour = 20;  signes[1].mois = 4;
            signes[2].signe = "Gémeaux";    signes[2].jour = 21;  signes[2].mois = 5;
            signes[3].signe = "Cancer";     signes[3].jour = 22;  signes[3].mois = 6;
            signes[4].signe = "Lion";       signes[4].jour = 23;  signes[4].mois = 7;
            signes[5].signe = "Vierge";     signes[5].jour = 23;  signes[5].mois = 8;
            signes[6].signe = "Balance";    signes[6].jour = 23;  signes[6].mois = 9;
            signes[7].signe = "Scorpion";   signes[7].jour = 24;  signes[7].mois = 10;
            signes[8].signe = "Sagittaire"; signes[8].jour = 23;  signes[8].mois = 11;
            signes[9].signe = "Capricorne"; signes[9].jour = 23;  signes[9].mois = 12;
            signes[10].signe = "Verseau";   signes[10].jour = 21; signes[10].mois = 1;
            signes[11].signe = "Poissons";  signes[11].jour = 20; signes[11].mois = 2;

            string signe = signes[0].signe;

            for (int i = 1; i < 12; i++)
            {
                if (signes[i].mois == pMois)
                {
                    signe = signes[i].signe;

                    if (pJour < signes[i].jour)
                    {
                        signe = signes[i - 1].signe;
                    }
                }
            }

            return signe;
        }

        /*=============================================================================*
         *___MAIN___                                                                   * 
         *=============================================================================*/
        static void Main(string[] args)
        {
            // Déclaration constantes//
            string message = "\nVeuillez saisir une date : ",
                   question = "Avez-vous une date à saisir ? ";
            char O = 'O', N = 'N', continuer;

            // Déclaration variables// 
            int jour, mois;

            do
            {
                // Saisie d'un nombre entier 
                Console.WriteLine(message);
                jour = int.Parse(Console.ReadLine());
                mois = int.Parse(Console.ReadLine());

                // Appel de la fonction permettant de savoir le signe avec parametres saisis
                Console.WriteLine($"Votre signe astrologique est : {signeAstrologique(jour,mois)}");

                // Permet de boucler sur la saisie de date
                continuer = saisie(question, O, N);

            } while (continuer == O);
        }
    }
}

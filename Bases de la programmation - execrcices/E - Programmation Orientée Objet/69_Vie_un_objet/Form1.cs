/*************************************************************************
 * Description : Création d'un personnage dont le login est "EMDS", puis *
 *				 de faire avancer de 100 pas le personnage, un pas à la  *
 *				 fois en le faisant tourner alternativement à gauche ou à*
 *				 droite à chaque fois qu'il n'a pas pu avancer, bloqué   *
 *				 par un mur 											 *
 *																		 *
 * Author      : LENNINOV                                                *
 *                                                                       *
 * Date        :                                                         *
 *************************************************************************/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _69_Vie_un_objet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public class Personnage
        {
            private string login;
            private int vie;
            /**
             * Constructeur 
             * Valorise le login et initialise la vie à 10
             */
            
            public Personnage(string login) { }
            /**
             * Permet de faire avancer le joueur 
             * retourne faux s'il a été bloqué par un mur 
             * et n'a pas pu avancer jusqu'au bout 
             */
            
            public bool avancer(int distance) { return true; }
            /**
             * Permet de faire pivoter le personnage d'un quart de tour 
             * vers la gauche si direction = 'G'
             * vers la droite si direction = 'D'
             */
           
            public void tourner(char direction) { }
        }

        /**
         * Clic sur btnCreer 
         * Cree le personnage et le fait avancer
         */
        private void btnCreer_Click(object sender, EventArgs e)
        {
            // création du personnage 
            Personnage perso = new Personnage("Emds");

            // déclaration pour tourner 
            bool gauche = true;

            // boucle pour faire avancer le personnage
            int i = 0;
            while (i<100)
            {
                // Tente d'avancer 
                if(perso.avancer(1))
                {
                    // le personnage a pu avncer
                    i++;
                }
                else
                {
                    // bloquer par un mur 
                    if(gauche)
                    {
                        perso.tourner('G');
                    }
                    else
                    {
                        perso.tourner('D');
                    }
                    // Changer de direction
                    gauche = !gauche;
                }
            }
        }
    }
}

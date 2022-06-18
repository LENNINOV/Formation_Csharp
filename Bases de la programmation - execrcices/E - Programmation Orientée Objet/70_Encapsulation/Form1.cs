/*************************************************************************
 * Description : Création d'un tableau d'objets de type Personnage.      *
 *				 A chaque saisie d'un nouveau login, un personnage est   *
 *				 créé et ajouté dans le tableau. Sa vie est afffcihée    *
 *				 ainsi qu'un message avec son login suivi soit de sa vie *
 *				 soit de "est mort" si la vie est à 0. Le personnage est *
 *				 aussi ajouté dans la liste, suivi de sa vie entre       *
 *				 parenthèses, et il est automatiquement affiché tout en  *
 *				 bas.													 *
 *				 il est possible de cahnger la vie d'un personnage sélec-*
 *				 tioné dans la liste, avec l'objet graphique de type     *
 *				 NumberUpDown. Dans ce cas la vie est aussi mise à jour  *
 *				 dans le tableau, dans la liste, et une nouvelle         *
 *				 recherche est faite pour le login et celui qui a le plus*
 *				 de vie.												 *		
 *  																	 *
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

namespace _70_Encapsulation
{
    public partial class frmPerso : Form
    {
        public class Personnage
        {
            private string login;
            private int vie;

            /**
             * Constructeur 
             * valorise le login 
             * et initialise la vie aléatoirement entre 0 et 5
             */
            public Personnage(string login)
            {
                this.login = login;
                Random nbAlea = new Random();
                this.vie = nbAlea.Next(0, 5);
            }

            /**
             * Getter sur vie
             */
            public int getVie()
            {
                return vie;
            }

            /**
             * setter sur vie
             */
            public void setVie(int vie)
            {
                this.vie = vie;
            }

            /**
             * getter sur login
             */
            public string getLogin()
            {
                return login;
            }
        }

        public frmPerso()
        {
            InitializeComponent();
        }

        // Création du tableau de personnages
        private Personnage[] tabPersonnages = new Personnage[100];
        private int nbPerso = 0;

        /**Méthode 
         * affichage du login suivie de la vie 
         * ou de "est mort"
         */
        private void afficheMessagePerso(Personnage pPersonnage)
        {
            if(pPersonnage.getVie() == 0)
            {
                txtEtatperso.Text = $"{pPersonnage.getLogin()} est mort";
            }
            else
            {
                txtEtatperso.Text = $"{pPersonnage.getLogin()} : {pPersonnage.getVie()}";
            }
        }

        /**Méthode 
         * Mise a joour de la liste des personnages 
         */
        private void majListePersonnages(int pLigneActive)
        {
            // Vider la liste 
            lsbPersonnages.Items.Clear();
            // Remplir avec le tableau de personnages 
            for(int i = 0; i < nbPerso; i++)
            {
                lsbPersonnages.Items.Add($"{tabPersonnages[i].getLogin()} ({tabPersonnages[i].getVie()})");
            }

            // Positionnement sur la ligne active 
            if(lsbPersonnages.Items.Count > 0 && pLigneActive < nbPerso)
            {
                lsbPersonnages.SelectedIndex = pLigneActive;
            }
        }

        /**Méthode 
         * Recherche du login avec la vie maximale 
         */
        private void recherchePersoMaxVie()
        {
            // Contrôle s'il y a au moins un perosnnage 
            if (nbPerso == 0)
            {
                txtPersoMaxVie.Text = "";
            }
            else
            {
                // Recherche de l'index de la vie max 
                int max = 0;
                for (int i = 1; i < nbPerso; i++)
                {
                    if (tabPersonnages[i].getVie() > tabPersonnages[max].getVie())
                    {
                        max = i;
                    }
                }
                txtPersoMaxVie.Text = tabPersonnages[max].getLogin();
            }
        }

        /**Méthode 
         * Changement de vie 
         */
        private void changeViePerso(int pIndex)
        {
            // Affichage du message perso 
            afficheMessagePerso(tabPersonnages[pIndex]);

            // Mise a jour de la liste des perosnnages 
            majListePersonnages(pIndex);

            // Affichage du login de la vie max 
            recherchePersoMaxVie();
        }

        /**Evènement 
         * Touche appuyé sur txtLogin
         * Controle de la validation
         * Création d'un nouvgeau personnage
         */
        private void txtLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Contrôle si validation 
            if (e.KeyChar == (char)Keys.Enter)
            {
                // Incrémentation du nombre de personnage 
                nbPerso++;
                // Création du personnage 
                Personnage creaPerso = new Personnage(txtLogin.Text);
                // Ajout du personnage dans le tableau 
                tabPersonnages[nbPerso - 1] = creaPerso;
                // Maj de tous les affichages 
                changeViePerso(nbPerso - 1);
                // Purge de la zone de saisie et repositionnement dessus
                txtLogin.Text = "";
                txtLogin.Focus();
            }
        }

        /**Evènement 
         * Séléction d'une ligne dans la liste des personnages
         */
        private void lsbPersonnages_SelectedIndexChanged(object sender, EventArgs e)
        {
            numVie.Value = tabPersonnages[lsbPersonnages.SelectedIndex].getVie();
        }

        /**Evènement 
         * Changement de la vie sur numVie 
         */
        private void numVie_ValueChanged(object sender, EventArgs e)
        {
            // Contrôle de la selection d'une ligne 
            if (lsbPersonnages.SelectedIndex >= 0)
            {
                // Récupération du personnage séléctionné 
                Personnage idPerso = tabPersonnages[lsbPersonnages.SelectedIndex];
                // Modification de la vie du personnage 
                idPerso.setVie((int)numVie.Value);
                changeViePerso(lsbPersonnages.SelectedIndex);
            }
        }
    }
}

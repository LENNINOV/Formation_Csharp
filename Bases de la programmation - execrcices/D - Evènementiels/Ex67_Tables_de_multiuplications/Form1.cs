/*************************************************************************
 * Description : Résultat à donner de la multiplication de nombre        *	
 *				 aléatoires. si résultat correcte la case s'allume en 	 *	
 *				 vert au contraire en rouge. 							 * 	
 *				 Seule la zone de saisie est disponible pour ecrire      *
 *																		 *
 * Author      : LENNINOV                                                *
 *                                                                       *
 * Date        : 24/05/2022                                              *
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

namespace Ex67_Tables_de_multiuplications
{
    public partial class frmTestCalcul : Form
    {
        /**Variables / Constantes globale
         */
        private int SolutionMultiplication,
                    Chiffre,
                    Multipl,
                    Réponse,
                    NbQuestion,
                    NbRepOK;

        public frmTestCalcul()
        {
            InitializeComponent();
        }



        /**Procédure 
         * Génération aléatoire d'un chiffre et d'un multiplicateur
         */
        private void EnnonceOperation()
        {
            Random aleatoire = new Random(); 
            Chiffre = aleatoire.Next(11); //Génère un entier compris entre 0 et 10
            Multipl = aleatoire.Next(11);

            SolutionMultiplication = Chiffre * Multipl;

            txtChiffre.Text = Chiffre.ToString();
            txtMultiplicateur.Text = Multipl.ToString();
        }

        /**Procédure 
         * Mise a jour des labels avec la note,
         * incrémentation des compteurs 
         */
        private void MajProg()
        {

            if (Réponse == SolutionMultiplication)
            {
                lblRepProb.Text = "Bravo ! \nBonne réponse";
                txtRéponse.BackColor = Color.Green;
                NbRepOK++;
            }
            else
            {
                lblRepProb.Text = $"{Chiffre} x {Multipl} = {SolutionMultiplication}";
                txtRéponse.BackColor = Color.Red;
            }

            MajLabels();

            txtRéponse.Focus();
        }

        /**Procédure 
         * Mise a jour des labels avec la note,
         * incrémentation des compteurs 
         */
        private void MajLabels()
        {
            gpbQuestion.Text = $"Question n°{NbQuestion}/20";
            txtNumQuest.Text = $"{NbRepOK.ToString()}";
            txtNbQuest.Text = $"{NbQuestion.ToString()}";
        }

        /**Procédure 
         * Initialisation des compteurs 
         * Initialisation des labels du group box question 
         */
        private void InitProg()
        {
            Réponse = 0;
            NbQuestion = 1;
            NbRepOK = 0;

            MajLabels();

            txtRéponse.Text = "";
            lblRepProb.Text = "";
            gpbQuestion.Text = "Question n°1/20";

        }

        /**Evenement 
         * Chargement de la fenêtre applicative 
         * Initialisation des variables 
         */
        private void frmTestCalcul_Load(object sender, EventArgs e)
        {
            InitProg();

            // Appel premiere fois procédure pour énnoncé
            EnnonceOperation();

            txtRéponse.Focus();
        }

        /**Evenement 
         * Saisie de la réponse au 
         */
        private void txtRéponse_TextChanged(object sender, EventArgs e)
        { 
        }

        /**Evenement 
          * Clic sur le btn question suivante  
          */
        private void btnSuivante_Click(object sender, EventArgs e)
        {
            if (NbQuestion <= 19)
            {
                try
                {
                    // Utilisateur saisie sa réponse 
                    Réponse = int.Parse(txtRéponse.Text);

                    NbQuestion++;

                    MajProg();

                    EnnonceOperation();
                }
                catch(Exception ex)
                {
                    lblRepProb.Text = "Saisir une \n réponse !";
                }
            }
            else
            {
                btnSuivante.Enabled = false;
                btnRelfaire.Focus();
            }

            txtRéponse.Text = "";

        }

        /**Evenement 
         * Appuis sur entrer   
         */

        private void txtRéponse_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Cast de la keys en char
            if (e.KeyChar == (char)Keys.Return)
            {
                // envoie null aux deux paramètres de l'évènement
                btnSuivante_Click(null, null);
            }
        }

        /**Evenement 
         * Clic sur le btn refaire le test  
         */
        private void btnRelfaire_Click(object sender, EventArgs e)
        {
            frmTestCalcul_Load(null, null);
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex57_Jeu_ou_
{
    public partial class frmNombreCache : Form
    {
        private int NbEssai = 1;
        private int NbCaché = 0;
        private int phase;

        public int Essai = 0;

        public frmNombreCache()
        {
            InitializeComponent();
        }

        /* Evènement
         * Permet de vider la zone de saisie et repositionne le curseur 
         */
        private void efface()
        {
            txtValeur.Text = "";
            // Repositionne le curseur 
            txtValeur.Focus();
        }


        /* Evènement
         * Click sur Ok 
         * phase 1 : contrôle le nombre (entre 1 et 100) et passage en phase 2
         * phase 2 : contrôle de l'essai et affichage des messages
         */
        private void btnValider_Click(object sender, EventArgs e)
        {
            // Capture erreur et va dans le catch
            try
            {
                int valeur = int.Parse(txtValeur.Text);
                // Contrôle de la valeur 
                if (valeur >= 1 && valeur <= 100)
                {
                    // Positionnement sur la phase du jeu 
                    if (phase == 1)
                    {
                        // le premier joueur a saisi la valeur 
                        NbCaché = valeur;
                        phase = 2;
                        NbEssai = 0;
                        grpValeur.Text = "Essai (entre 1 et 100)";
                        efface();
                    }
                    else
                    {
                        // le second joueur a saisi un essai 
                        if (valeur == NbCaché)
                        {
                            lblMessage.Text = $"Félicitations ! Le nombre à trouver était {NbCaché}";
                            efface();
                            // Focus sur le bouton rejouer 
                            btnRejouer.Focus();
                            grpValeur.Enabled = false;
                        }
                        else
                        {
                            if (valeur > NbCaché)
                            {
                                lblMessage.Text = $"{valeur} est trop grand";
                            }
                            else
                            {
                                lblMessage.Text = $"{valeur} est trop petit";
                            }
                        }
                        // affichage du message et du nombre d'essais
                        NbEssai++;
                        grpReponse.Text = $"Essai n°{NbEssai}";
                        grpReponse.Visible = true;
                    }
                }
                else
                {
                }
                efface();
            }
            catch (Exception ex)
            {
                efface();
            }

        }

        /* Evènement 
         * Click sur quitter pour fermer l'appli
         */
        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /* Procédure
         * Initialisation d'un nouveau jeu 
         */
        private void initialisation()
        {
            phase = 1;
            grpValeur.Text = "Saisissez le nombre à trouver (entre 1 et 100)";
            // Permet de rendre le groupe réponse masqué 
            grpReponse.Visible = false;
            grpValeur.Enabled = true;
            efface();
        }

        /* Evènement 
         * Click sur rejouer
         */
        private void btnRejouer_Click(object sender, EventArgs e)
        {
            initialisation();
        }

        /* Evènement 
         * Chargement de la fenêtre
         * Initialisation pour démarrer la phase I 
         */
        private void frmNombreCache_Load(object sender, EventArgs e)
        {
            initialisation();
        }

        /*
         * Saisie d'une touche dans la zone de saisie 
         * Pareil que click sur ok si validation 
         */
        private void txtValeur_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Cast de la keys en char
            if (e.KeyChar == (char)Keys.Return)
            {
                // envoie null aux deux paramètres de l'évènement
                btnValider_Click(null, null);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PremierExempleGraphique
{
    // Partiel car partie du code généré quand ajout de btn etc...
    public partial class Opérations : Form
    {
        // Constructeur : se construit se créé dans la partie caché
        public Opérations()
        {
            InitializeComponent();
        }

        /* Méthode générée quand créer le bouton : en dessous s'execute quand clic sur bouton
         *
         * Clic sur bouton : ajouter pour faire la somme de deux nombres
         */
        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Capture d'erreur 
            try
            {

                // L'opération doit être convertie en string 
                //               Conversion de la val1 (text) en float, pareil pour la deuxième
                txtResult.Text = (float.Parse(txtValeur1.Text) + float.Parse(txtValeur2.Text)).ToString();
                lblOperation.Text = "+";
            }
            catch(Exception ex) { };
        }

        /* Méthode générée quand créer le bouton : en dessous s'execute quand clic sur bouton
         *
         * Clic sur bouton : ajouter pour faire la somme de deux nombres
         */
        private void btnMultiplication_Click(object sender, EventArgs e)
        {
            // Capture d'errreur 
            try
            {
                // L'opération doit être convertie en string 
                //               Conversion de la val1 (text) en float, pareil pour la deuxième
                txtResult.Text = (float.Parse(txtValeur1.Text) * float.Parse(txtValeur2.Text)).ToString();
                lblOperation.Text = "x";
            }
            catch(Exception ex) { };
        }

        /* Méthode générée quand créer le bouton : en dessous s'execute quand clic sur bouton
        *
        * Clic sur bouton : Vide les deux nombre
        */
        private void btnErase_Click(object sender, EventArgs e)
        {
            txtValeur1.Text = "";
            txtValeur2.Text = "";
            txtResult.Text = "";
            lblOperation.Text = "";
        }

        /* Méthode générée quand créer le bouton : en dessous s'execute quand clic sur bouton
         *
         * Clic sur bouton : Ferme l'application
         */
        private void btnShutdown_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /**
         * Changement de txtVal1
         * Vider le résultat
         */
        private void txtValeur1_TextChanged(object sender, EventArgs e)
        {
            txtResult.Text = "";
        }

        /**
        * Changement de txtVal2
        * Vider le résultat
        */
        private void txtValeur2_TextChanged(object sender, EventArgs e)
        {
            txtResult.Text = "";
        }
    }
}

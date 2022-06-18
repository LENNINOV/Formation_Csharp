/*************************************************************************
 * Description : Programme de conversion monnétaire (euro vers autre).   *
 *				 Déclaration et remplissage d'un tableau de structure :  *  
 *				 	- Nom 												 *
 *					- Valeur/indice										 *	
 *                  - Symbole											 *
 *               														 *	
 *				 Alimentation directe dans le code.						 *
 *               Dès le chargement le combo se rempli grâce au tableau de*
 *				 structure, et la première monnaie doit s'afficher. Ainsi*
 *				 que txtEuro initialisé à 1.							 * 
 *      		 Le controle de saisie doit être fait 					 *	
 *				 														 *
 * Author      : LENNINOV                                                *
 *                                                                       *
 * Date        : 20/05/2022                                              *
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

namespace Ex66_ConvertisseurMonnaies
{

    public partial class frmConvertisseur : Form
    {
        /**Tableau de structure pour la monnaie
         * Nom de la monnaie 
         * Valeur/indice de la monnaie 
         * Symbole de la monnaie 
         * >>> Exemple de déclaration Monnaie[i].nom
         */
        struct StrMonnaie
        {
            
            public string nom;
            public float valeur;
            public string symbole;
        }

        /**Proprité
         * Déclaration de la table de structure 
         */
        private static int nbMonnaie = 6;
        private StrMonnaie[] tMonnaie = new StrMonnaie[nbMonnaie];

        public frmConvertisseur()
        {
            InitializeComponent();
        }

        /**Procédure 
         * Mise à jour des information contenue dans 
         * Label monnaie et valeur monnaie 
         */
        private void majInformations(float pValeurEuro)
        {
            // Variables locales 
            //-- Index de l'item dans la table
            int index = cboMonnaie.SelectedIndex;

            lblMonnaie.Text = tMonnaie[index].symbole;
            txtValeur.Text = tMonnaie[index].valeur.ToString();
            txtMonnaie.Text = (pValeurEuro * tMonnaie[index].valeur).ToString();
        }


        /**Evènement
         * Chargement au démarrage de la fenêtre 
         * Initialisation de : le combo avec le tableu de structure 
         *                     affichage de la premiere monnaie 
         *                     txtEuro à 1
         */
        private void frmConvertisseur_Load(object sender, EventArgs e)
        {
            // Initialisation du tableau de structure contenant les monnaies  
            //>>> Dollar US <<<
            tMonnaie[0].nom = "Dollar américain";
            tMonnaie[0].valeur = 1.06185f;
            tMonnaie[0].symbole = "$";
            //>>> Dollar canadien <<<
            tMonnaie[1].nom = "Dollar canadien";
            tMonnaie[1].valeur = 1.35061f;
            tMonnaie[1].symbole = "$";
            //>>> Livre sterling <<<
            tMonnaie[2].nom = "Livre sterling";
            tMonnaie[2].valeur = 0.88707f;
            tMonnaie[2].symbole = "£";
            //>>> Yen <<<
            tMonnaie[3].nom = "Yen";
            tMonnaie[3].valeur = 134.7841f;
            tMonnaie[3].symbole = "¥";
            //>>> Franc Suisse <<<
            tMonnaie[4].nom = "Franc Suisse";
            tMonnaie[4].valeur = 1.03645f;
            tMonnaie[4].symbole = "CHF";
            //>>> Yuan chinois <<<
            tMonnaie[5].nom = "Yuan chinois";
            tMonnaie[5].valeur = 7.07512f;
            tMonnaie[5].symbole = "¥";

            // Alimentation du comboListe
            for (int i = 0; i < nbMonnaie; i++)
            {
                cboMonnaie.Items.Add(tMonnaie[i].nom);
            }

            // --- Intialisation --- //
            // Afficahge de la première monnaie 
            cboMonnaie.Text = tMonnaie[0].nom;
            // Zone de saisie à 1
            txtEuro.Text = 1.ToString();
        }

        /**Evenement
         * Clic sur cboMonnaie 
         * Mise à jour du label et de la valeur 
         */
        private void cboMonnaie_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Déclaration des variables locales
            int index = cboMonnaie.SelectedIndex;

            // Permet de controler la valeur saisie 
            txtEuro_TextChanged(null, null);
        }

        /**Evenement
         * Saisie de la valeur en euros dans la box  
         */
        private void txtEuro_TextChanged(object sender, EventArgs e)
        {
            // Variables locales 
            //-- Index de la monnaie sélectionnée
            int index = cboMonnaie.SelectedIndex;
            try
            {
                float valEuro = float.Parse(txtEuro.Text);
                // Conversion dans la monanie sélectionné
                majInformations(valEuro);
            }
            catch (Exception del_Saisie)
            {
                // Zone de saisie éffacé = réinitialisation 
                majInformations(0);
            }
        }
    }
}

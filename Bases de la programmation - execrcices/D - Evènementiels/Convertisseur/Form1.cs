using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Convertisseur
{
    public partial class frmConvertisseur : Form
    {
        /* Initialisation du code source */
        public frmConvertisseur()
        {
            InitializeComponent();
        }

        /******************************************************
         * Méthode :                                          *   
         * Retourne: True si paramètre contient que "0" ou "1"*
         *         : False si c'est l'inverse                 *   
         ******************************************************/
        private bool isBinaire(string texte)
        {
            int i = 0;
            while (i < texte.Length && 
                  (texte.Substring(i,1) == "0" || texte.Substring(i,1) == "1"))
            {
                i++;
            }
            /* Autre exemple d'écriture  
             * Equivalent du if ci dessous : 
             * return (k==texte.Lenght); => si ce test est vrai alors il retourne automatiquement vrai
             */
            if (i==texte.Length)
            {
                return true;
            }
            else
            {
                return false;
            }

            
        }

        /***********************************************
         * Méthode :                                   *   
         * Conversion d'un nombre de décimal à binaire *
         ***********************************************/
        private string conversionBase10ToBase2(int base10)
        {
            string base2 = "";

            // Boucle tant que l'entier n'est pas 0
            while (base10 != 0)
            {
                base2 = (base10 % 2) + base2;
                base10 /= 2;
            }

            // cas particulier de base10 contenant 0
            if (base2 == "")
            {
                base2 = "0";
            }
            return base2;
        }

        /***********************************************
         * Méthode :                                   *   
         * Conversion d'un nombre de binaire à décimal *
         ***********************************************/
        private int conversionBase2Tobase10(string base2)
        {
            // Appelle de la méthode de contrôle d'une saisie au format binaire 
            isBinaire(base2);

            // Si contrôle valide 
            if (isBinaire(base2))
            {
                // Conversion par multiplication successive par exp 2
                int base10 = 0;
                for (int i = 0; i < base2.Length; i++)
                {
                    base10 += int.Parse(base2.Substring(base2.Length - 1 - i, 1)) * (int)Math.Pow(2, i);
                }
                return base10;
            }
            // Conversion impossible 
            // retourne -1
            else 
            {
                return -1;
            }
            
        }

        /*******************************************************************************
         * Evènement :                                                                 *   
         * Saisie un nombre en base 10 et appelle la méthode de conversion en binaire  *
         *******************************************************************************/
        private void txtBase10_TextChanged(object sender, EventArgs e)
        {
            try
            {
                // Récupération du contenu dans txtBase10
                int base10 = int.Parse(txtBase10.Text);
                // affichage en binaire 
                txtBase2.Text = conversionBase10ToBase2(base10);
            }
            catch (Exception ex)
            {
                // erreur : saisie décimale incorrecte 
                txtBase10.Text = "";
                txtBase2.Text = "";
            }
        }

        /******************************************************************************
         * Evènement :                                                                *   
         * Saisie un nombre en base 2 et appelle la méthode de conversion en décimal  *
         ******************************************************************************/
        private void txtBase2_TextChanged(object sender, EventArgs e)
        {
            // Récupération du contenu converti en décimal
            int base10 = conversionBase2Tobase10(txtBase2.Text);
            // Controle de la conversion 
            if (base10 != -1)
            {
                txtBase10.Text = base10.ToString();
            }
            else
            {
                // Vider les zones 
                txtBase10.Text = "";
                txtBase2.Text = "";
            }
        }
    }
}

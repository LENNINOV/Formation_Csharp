/*************************************************************************
 * Description : Programme de calcul du poids idéal selon la formule de  *
 *			     CREFF.													 *
 *     			 Poids idéal = (taille en cm - 100 +(age / 10)) * 0,9	 *
 *               Large = + 10%            						         *
 *               Gracile = - 10%									     * 
 *																		 * 	
 * Author      : LENNINOV                                                *
 *                                                                       *
 * Date        : 01/05/2022                                              *
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

namespace Ex64_Poids_Idéal
{
    public partial class frmCREFF : Form
    {
        
        // Variables globales //
        private DateTime dateJour = DateTime.Today;
        private bool continuer;

        public frmCREFF()
        {
            InitializeComponent();
        }

        /** Méthode 
         *  Controle la date de naissance 
         *  Retourne vrai si inférieure à celle du jour  
         */
        private bool NaissanceValide(DateTime pDateNaissance)
        {
            bool valide = false;
            if (dtpNaissance.Value < dateJour)
            {
                valide = true;
            }
            else
            {
                txtPoidsIdeal.Text = "Date incorrecte !";
            }
            return valide;
        }

        /** Méthode 
          *  Fais la différence entre la date saisie et la date du jour 
          *  Retourne l'âge sous forme entier 
          */
        private int CalculAge(DateTime pDateNaissance)
        {
            int nbJours = (dateJour - pDateNaissance).Days;
            int age = nbJours / 365;
            return age;
        }


        /** Méthode 
          *  Fais la différence entre la date saisie et la date du jour 
          *  Retourne l'âge sous forme entier 
          */
        private float FormuleDeCREFF(int pTaille, int pAge)
        {

            float pdsIdéal = (float)((pTaille - 100 + (pAge / 10)) * 0.9);

            if (grbGracile.Checked == true)
            {
                float pdsIdéalGracile = (float)(pdsIdéal * 0.9);
                pdsIdéal = pdsIdéalGracile;
            }
            else if (grbLarge.Checked == true)
            {
                float pdsIdéalLarge = (float)(pdsIdéal * 1.10);
                pdsIdéal = pdsIdéalLarge;
            }
            return pdsIdéal;
        }

        /** Evènement 
          *  Clic btnCalculer : Appel module calcul age 
          */
        private void cmdCalcul_Click(object sender, EventArgs e)
        {
            int taille = int.Parse(txtTaille.Text);

            continuer = NaissanceValide(dtpNaissance.Value);

            if (continuer)
            {
                int age = CalculAge(dtpNaissance.Value);
                float pdsIdéal = FormuleDeCREFF(taille, age);

                txtPoidsIdeal.Text = pdsIdéal.ToString("0.00");
            }
        }

        /** Evènement 
         *  Clic btnCalculer : Appel module calcul age 
         */
        private void grbGracile_CheckedChanged(object sender, EventArgs e)
        {
            continuer = NaissanceValide(dtpNaissance.Value);

            if (continuer)
            {
                cmdCalcul_Click(null, null);
            }
            
        }

        /** Evènement 
         *  Clic btnCalculer : Appel module calcul age 
         */
        private void grbLarge_CheckedChanged(object sender, EventArgs e)
        {
            continuer = NaissanceValide(dtpNaissance.Value);

            if (continuer)
            {
                cmdCalcul_Click(null, null);
            }
        }
    }
}
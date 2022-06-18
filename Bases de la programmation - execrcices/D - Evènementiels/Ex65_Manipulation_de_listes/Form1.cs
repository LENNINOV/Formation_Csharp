/*************************************************************************
 * Description : Programme de récupération de fichier dans un dossier,   *
 *				 et transfère dans une autre liste, un par un ou en tot  *
 *				 ainsi que suppression de fichiers sélectionnés          *
 *				                                                         *
 * Author      : LENNINOV                                                *
 *                                                                       *
 * Date        : 17/05/2022                                              *
 *************************************************************************/
using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex65_Manipulation_de_listes
{
    public partial class frmFichiers : Form
    {
        /*************************************
         * Déclaration des variables globales 
         ************************************/
        private string dossier;
        

        //------------------------------------------------------------------------------//

        public frmFichiers()
        {
            InitializeComponent();
        }

        //------------------------------------------------------------------------------//

        /**
         * Procédure 
         * Mise à jour des labels de nombres
         */
        private void majLabelNb()
        {
            lblNbFichiers.Text = $"{lsbFichiers.Items.Count} fichier(s) dans le dossier";
            lblNbSelection.Text = $"{lsbSelection.Items.Count} fichier(s) sélectionné";
        }

        /** Evenement
         * Chargement de la fenêtre 
         * Mise à jour des lables 
         */
        private void frmFichiers_Load(object sender, EventArgs e)
        {
            majLabelNb();
        }


        /** Evenement
         * Clic sur btnRechercher : Sélectionner un dossier et  
         * remplir la liste fichiers avec le nom des fichiers
         */
        private void btnRecherche_Click(object sender, EventArgs e)
        {
            // boite de dialogue pour sélection du dossier
            FolderBrowserDialog rechercheDossier;
            rechercheDossier = new FolderBrowserDialog();
            rechercheDossier.Description = "Sélectionner un dossier.";
            DialogResult choix = rechercheDossier.ShowDialog();

            // Si selection d'un dossier 
            if (choix == DialogResult.OK)
            {
                // Récupération du chemin d'accès dossier 
                dossier = rechercheDossier.SelectedPath;

                // Boucle sur les fichiers du dossier pour remplir la liste 
                lsbFichiers.Items.Clear();
                foreach (string fichier in Directory.GetFiles(dossier))
                {
                    string nomFichier = Path.GetFileName(fichier);
                    lsbFichiers.Items.Add(nomFichier);
                }

                majLabelNb();
            }
        }

        /** Evènement
         *  Clic qur le bouton >>
         *  Copie de tous les noms de gauche à droite
         */
        private void btnTransfertAll_Click(object sender, EventArgs e)
        {
            // Vider la liste de droite 
            lsbSelection.Items.Clear();
            // Copie de tous les noms de gauche à droite 
            foreach (string fichier in lsbFichiers.Items)
            {
                // ajout à la liste de la selection 
                lsbSelection.Items.Add(fichier);
            }
            majLabelNb();
        }

        /** Evènement
         *  Clic sur > Copie du fichier sélectionné
         */
        private void btnTransfert_Click(object sender, EventArgs e)
        {
            // Déclarations des variables locales
            object FicSelect = lsbFichiers.SelectedItem;
            int fichierSelectionne = lsbFichiers.SelectedIndex;

            // Controle si un nom est sélectionné à gauche
            if (fichierSelectionne >= 0)
            {
                // Contrôle si le nom n'est pas déjà dans la lsite de droite 
                if (lsbSelection.FindStringExact(FicSelect.ToString()) < 0)
                {
                    // Ajout dans la liste des fichiers selectionnés, le fichier selectionne du dossier maitre
                    lsbSelection.Items.Add(FicSelect);
                    majLabelNb();
                }
            }
        }
        
        /** Evenement
         *  Clic sur le bouton del 
         *  Suppression du nom sélectionné à droite si sélection
         */
        private void btnDelet_Click(object sender, EventArgs e)
        {
            // Déclarations des variables locales
            int fichierSelectionne = lsbSelection.SelectedIndex;

            // Contreole d'un nom selectionné à droite 
            if (fichierSelectionne >= 0)
            {
                // Suppression de lélément (nom selectionné)
                lsbSelection.Items.RemoveAt(fichierSelectionne);
                majLabelNb();
            }
        }

        /** Evenement
         *  Clic sur le bouton clear all 
         *  Vide la liste de droite 
         */
        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            lsbSelection.Items.Clear();
            majLabelNb();
        }


    }
}

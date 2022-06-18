/*************************************************************************
 * Description : Application permettant la sélection sur le disque       *
 *               et affiche dans une liste les noms des fichiers         *
 *               présents dedans. Sur la sélection d'un nom dans la      *
 *               liste, si le fichier est une image, il faut l'afficher. * 
 *               Un bouton doit aussi permettre de faire pivoter l'image *
 *               à volonté d'1/4 de tour.                                *
 *                                                                       *
 * Author      : LENNINOV                                                *
 *                                                                       *
 * Date        : 28/04/2022                                              *
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
using System.IO;

namespace Ex63_GalerieDePhotos
{
    public partial class Form1 : Form
    {
        // Propriétés globales 
        private string dossier;

        public Form1()
        {
            InitializeComponent();
        }

        /** Evenement
         * Clic sur btnDossier : permet de sélectionner un dossier sur le disque 
         * et remplir la liste avec les fichiers du dossier
         */
        private void btnDossier_Click(object sender, EventArgs e)
        {
            // boite de dialogue pour sélection du dossier
            FolderBrowserDialog rechercheDossier;
            rechercheDossier = new FolderBrowserDialog();
            rechercheDossier.Description = "Sélectionner un dossier de photos.";
            DialogResult choix = rechercheDossier.ShowDialog();

            // Si selection d'un dossier 
            if (choix == DialogResult.OK)
            {
                // Récupération du chemin d'accès dossier 
                dossier = rechercheDossier.SelectedPath;

                // Boucle sur les fichiers du dossier pour remplir la liste 
                lstPhoto.Items.Clear();
                foreach(string fichier in Directory.GetFiles(dossier))
                {
                    string nomFichier = Path.GetFileName(fichier);
                    lstPhoto.Items.Add(nomFichier);
                }

                // Sélection du 1er élément de la liste 
                if(lstPhoto.Items.Count > 0)
                {
                    lstPhoto.SelectedIndex = 0;
                    lstPhoto_SelectedIndexChanged(null, null);
                }
            }
        }

        /** Evènement
         *  Changement de sélection dans lstPhoto
         *  Afficher la photo si possible 
         */
        private void lstPhoto_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string fichier = dossier + "\\" + lstPhoto.SelectedItem;
                pctPhotos.Image = Image.FromFile(fichier);
            }

            catch (Exception ex)
            {
                // Si le fichier n'est pas une image 
                pctPhotos.Image = null;
            }

        }

        /** Evènement
         *  Clic de btnRotation
         *  Permet de faire pivoter l'image
         */
        private void btnRotation_Click(object sender, EventArgs e)
        {
            try
            {
                pctPhotos.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                pctPhotos.Refresh();
            }
            catch (Exception ex)
            {

            }
        }
    }
}

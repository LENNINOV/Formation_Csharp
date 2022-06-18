using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _73_Polymorphisme_et_abstraction
{
    public partial class frmPersonnage : Form
    {
        public abstract class Personnage
        {
            // Propriétés 
            protected string login = "inconnu";

            public Personnage() { }

            public Personnage(string pLogin)
            {
                this.login = pLogin;
            }

            /**
             * Permet de retourner les informations du personnage 
             */
            public abstract string info();
        }

        public class Humain : Personnage
        {
            // propriétés
            private int vie;

            public Humain(int pVie)
            {
                this.vie = pVie;
            }

            public Humain(string pLogin, int pVie): base(pLogin)
            {
                this.vie = pVie;
            }

            /**
             * Retourne le login et la vie 
             */
            public override string info()
            {
                return $"Humain : {login} ({vie})";
            }
        }

        public class Xmen : Personnage
        {
            // Propriétés 
            private string pouvoir; 

            public Xmen(string pPouvoir)
            {
                this.pouvoir = pPouvoir;
            }

            public Xmen(string pLogin, string pPouvoir) : base(pLogin)
            {
                this.pouvoir = pPouvoir;
            }

            /**
             * Retourne le login et le pouvoir 
             */
            public override string info()
            {
                return $"Xmen : {login} ({pouvoir})";
            }
        }

        public frmPersonnage()
        {
            InitializeComponent();
        }

        // Propriétés
        //private Personnage[] Tabpersonnages = new Personnage[100];
        //private int nbPerso = 0;

        private List<Personnage> ListPersonnage = new List<Personnage>();

        /**Procédure
         * Change affichage de l'application 
         */
        private void swapAffichage(bool pHumain)
        {
            lblPouvoir.Visible = !pHumain;
            cboPouvoir.Visible = !pHumain;
            lblVie.Visible = pHumain;
            nupVie.Visible = pHumain;
        }

        /**Procédure
         * Mise a jour de la liste a partir du tableau 
         */
        private void MajListe()
        {
            // Vider la liste 
            lsbPersonnage.Items.Clear();
            
            // Remplissage de la liste 
            /**for (int i = 0; i < nbPerso; i++)
            {
                lsbPersonnage.Items.Add(Tabpersonnages[i].info());
            }*/
            
            for (int i = 0; i < ListPersonnage.Count; i++)
            {
                lsbPersonnage.Items.Add(ListPersonnage[i].info());
            }
        }

        /**Evenement
         * Selection du bouton radio Humain 
         * Modification de l'affichage 
         */
            private void radHumain_CheckedChanged(object sender, EventArgs e)
        {
            swapAffichage(true);
        }

        /**Evenement
         * Selection du bouton radio X men 
         * Modification de l'affichage 
         */
        private void radXmen_CheckedChanged(object sender, EventArgs e)
        {
            swapAffichage(false);
        }

        /**Evenement
         * Chargement de la fenêtre
         */
        private void frmPersonnage_Load(object sender, EventArgs e)
        {
            radHumain.Checked = true;
            swapAffichage(true);
            cboPouvoir.SelectedItem = 0;
            txtLogin.Focus();
        }

        /**Evenement
         * Clic sur btn Ajouter 
         */
        private void btnAjouter_Click(object sender, EventArgs e)
        {
            // Ajout du personnage dans le tableau 
            //nbPerso++;
            if (radHumain.Checked)
            {
                // Ajout d'un humain 
                if (txtLogin.Text == "")
                {
                    //Tabpersonnages[nbPerso - 1] = new Humain((int)nupVie.Value);
                    ListPersonnage.Add(new Humain((int)nupVie.Value));
                }
                else
                {
                    //Tabpersonnages[nbPerso - 1] = new Humain(txtLogin.Text, (int)nupVie.Value);
                    ListPersonnage.Add(new Humain(txtLogin.Text, (int)nupVie.Value));
                }

            }
            else
            {
                // Ajout d'un X men
                if (txtLogin.Text == "")
                {
                    //Tabpersonnages[nbPerso - 1] = new Xmen(cboPouvoir.SelectedItem.ToString());
                    ListPersonnage.Add(new Xmen(cboPouvoir.SelectedItem.ToString()));
                }
                else
                {
                    //Tabpersonnages[nbPerso - 1] = new Xmen(txtLogin.Text, cboPouvoir.SelectedItem.ToString());
                    ListPersonnage.Add(new Xmen(txtLogin.Text, cboPouvoir.SelectedItem.ToString()));
                }
            }
            // Mise a jour de la liste
            MajListe();
            // Repositionnement sur login 
            txtLogin.Text = "";
            txtLogin.Focus();
        }
    }
}

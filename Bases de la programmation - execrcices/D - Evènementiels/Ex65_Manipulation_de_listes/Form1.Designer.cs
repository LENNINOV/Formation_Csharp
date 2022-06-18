
namespace Ex65_Manipulation_de_listes
{
    partial class frmFichiers
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFichiers));
            this.lsbFichiers = new System.Windows.Forms.ListBox();
            this.lblFichiersDossier = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRecherche = new System.Windows.Forms.Button();
            this.lblNbFichiers = new System.Windows.Forms.Label();
            this.lsbSelection = new System.Windows.Forms.ListBox();
            this.lblNbSelection = new System.Windows.Forms.Label();
            this.btnTransfert = new System.Windows.Forms.Button();
            this.btnTransfertAll = new System.Windows.Forms.Button();
            this.btnDeleteAll = new System.Windows.Forms.Button();
            this.btnDelet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lsbFichiers
            // 
            this.lsbFichiers.FormattingEnabled = true;
            this.lsbFichiers.ItemHeight = 15;
            this.lsbFichiers.Location = new System.Drawing.Point(12, 34);
            this.lsbFichiers.Name = "lsbFichiers";
            this.lsbFichiers.Size = new System.Drawing.Size(214, 379);
            this.lsbFichiers.TabIndex = 0;
            // 
            // lblFichiersDossier
            // 
            this.lblFichiersDossier.AutoSize = true;
            this.lblFichiersDossier.Location = new System.Drawing.Point(12, 9);
            this.lblFichiersDossier.Name = "lblFichiersDossier";
            this.lblFichiersDossier.Size = new System.Drawing.Size(108, 15);
            this.lblFichiersDossier.TabIndex = 1;
            this.lblFichiersDossier.Text = "fichiers du dossier :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(319, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "fichiers sélectionnés :";
            // 
            // btnRecherche
            // 
            this.btnRecherche.Location = new System.Drawing.Point(151, 5);
            this.btnRecherche.Name = "btnRecherche";
            this.btnRecherche.Size = new System.Drawing.Size(75, 23);
            this.btnRecherche.TabIndex = 3;
            this.btnRecherche.Text = "rechercher";
            this.btnRecherche.UseVisualStyleBackColor = true;
            this.btnRecherche.Click += new System.EventHandler(this.btnRecherche_Click);
            // 
            // lblNbFichiers
            // 
            this.lblNbFichiers.AutoSize = true;
            this.lblNbFichiers.Location = new System.Drawing.Point(12, 426);
            this.lblNbFichiers.Name = "lblNbFichiers";
            this.lblNbFichiers.Size = new System.Drawing.Size(142, 15);
            this.lblNbFichiers.TabIndex = 4;
            this.lblNbFichiers.Text = "0 fichier(s) dans le dossier";
            // 
            // lsbSelection
            // 
            this.lsbSelection.FormattingEnabled = true;
            this.lsbSelection.ItemHeight = 15;
            this.lsbSelection.Location = new System.Drawing.Point(319, 34);
            this.lsbSelection.Name = "lsbSelection";
            this.lsbSelection.Size = new System.Drawing.Size(214, 379);
            this.lsbSelection.TabIndex = 5;
            this.lsbSelection.DataSourceChanged += new System.EventHandler(this.btnTransfertAll_Click);
            // 
            // lblNbSelection
            // 
            this.lblNbSelection.AutoSize = true;
            this.lblNbSelection.Location = new System.Drawing.Point(319, 426);
            this.lblNbSelection.Name = "lblNbSelection";
            this.lblNbSelection.Size = new System.Drawing.Size(138, 15);
            this.lblNbSelection.TabIndex = 6;
            this.lblNbSelection.Text = "0 fichier(s) sélectionné(s)";
            // 
            // btnTransfert
            // 
            this.btnTransfert.Font = new System.Drawing.Font("Comic Sans MS", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTransfert.Location = new System.Drawing.Point(246, 146);
            this.btnTransfert.Name = "btnTransfert";
            this.btnTransfert.Size = new System.Drawing.Size(50, 50);
            this.btnTransfert.TabIndex = 7;
            this.btnTransfert.Text = ">";
            this.btnTransfert.UseVisualStyleBackColor = true;
            this.btnTransfert.Click += new System.EventHandler(this.btnTransfert_Click);
            // 
            // btnTransfertAll
            // 
            this.btnTransfertAll.Font = new System.Drawing.Font("Comic Sans MS", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTransfertAll.Location = new System.Drawing.Point(246, 213);
            this.btnTransfertAll.Name = "btnTransfertAll";
            this.btnTransfertAll.Size = new System.Drawing.Size(50, 50);
            this.btnTransfertAll.TabIndex = 8;
            this.btnTransfertAll.Text = ">>";
            this.btnTransfertAll.UseVisualStyleBackColor = true;
            this.btnTransfertAll.Click += new System.EventHandler(this.btnTransfertAll_Click);
            // 
            // btnDeleteAll
            // 
            this.btnDeleteAll.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteAll.Image")));
            this.btnDeleteAll.Location = new System.Drawing.Point(549, 213);
            this.btnDeleteAll.Name = "btnDeleteAll";
            this.btnDeleteAll.Size = new System.Drawing.Size(53, 50);
            this.btnDeleteAll.TabIndex = 10;
            this.btnDeleteAll.UseVisualStyleBackColor = true;
            this.btnDeleteAll.Click += new System.EventHandler(this.btnDeleteAll_Click);
            // 
            // btnDelet
            // 
            this.btnDelet.Image = global::Ex65_Manipulation_de_listes.Properties.Resources._415_4153477_house_in_which_sb_was_murdered_or_died_by_violence_clear_all1;
            this.btnDelet.Location = new System.Drawing.Point(549, 146);
            this.btnDelet.Name = "btnDelet";
            this.btnDelet.Size = new System.Drawing.Size(53, 50);
            this.btnDelet.TabIndex = 9;
            this.btnDelet.UseVisualStyleBackColor = true;
            this.btnDelet.Click += new System.EventHandler(this.btnDelet_Click);
            // 
            // frmFichiers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 450);
            this.Controls.Add(this.btnDeleteAll);
            this.Controls.Add(this.btnDelet);
            this.Controls.Add(this.btnTransfertAll);
            this.Controls.Add(this.btnTransfert);
            this.Controls.Add(this.lblNbSelection);
            this.Controls.Add(this.lsbSelection);
            this.Controls.Add(this.lblNbFichiers);
            this.Controls.Add(this.btnRecherche);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblFichiersDossier);
            this.Controls.Add(this.lsbFichiers);
            this.Name = "frmFichiers";
            this.Text = "Fichiers";
            this.Load += new System.EventHandler(this.frmFichiers_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lsbFichiers;
        private System.Windows.Forms.Label lblFichiersDossier;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRecherche;
        private System.Windows.Forms.Label lblNbFichiers;
        private System.Windows.Forms.ListBox lsbSelection;
        private System.Windows.Forms.Label lblNbSelection;
        private System.Windows.Forms.Button btnTransfert;
        private System.Windows.Forms.Button btnTransfertAll;
        private System.Windows.Forms.Button btnDeleteAll;
        private System.Windows.Forms.Button btnDelet;
    }
}


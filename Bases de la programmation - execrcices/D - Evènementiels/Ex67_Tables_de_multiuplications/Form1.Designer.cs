
namespace Ex67_Tables_de_multiuplications
{
    partial class frmTestCalcul
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
            this.gpbQuestion = new System.Windows.Forms.GroupBox();
            this.btnSuivante = new System.Windows.Forms.Button();
            this.lblRepProb = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRéponse = new System.Windows.Forms.TextBox();
            this.txtMultiplicateur = new System.Windows.Forms.TextBox();
            this.txtChiffre = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNbQuest = new System.Windows.Forms.TextBox();
            this.txtNumQuest = new System.Windows.Forms.TextBox();
            this.btnRelfaire = new System.Windows.Forms.Button();
            this.gpbQuestion.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbQuestion
            // 
            this.gpbQuestion.Controls.Add(this.btnSuivante);
            this.gpbQuestion.Controls.Add(this.lblRepProb);
            this.gpbQuestion.Controls.Add(this.label2);
            this.gpbQuestion.Controls.Add(this.label1);
            this.gpbQuestion.Controls.Add(this.txtRéponse);
            this.gpbQuestion.Controls.Add(this.txtMultiplicateur);
            this.gpbQuestion.Controls.Add(this.txtChiffre);
            this.gpbQuestion.Location = new System.Drawing.Point(12, 12);
            this.gpbQuestion.Name = "gpbQuestion";
            this.gpbQuestion.Size = new System.Drawing.Size(175, 100);
            this.gpbQuestion.TabIndex = 0;
            this.gpbQuestion.TabStop = false;
            this.gpbQuestion.Text = "Question n°3/20";
            // 
            // btnSuivante
            // 
            this.btnSuivante.Location = new System.Drawing.Point(80, 60);
            this.btnSuivante.Name = "btnSuivante";
            this.btnSuivante.Size = new System.Drawing.Size(75, 23);
            this.btnSuivante.TabIndex = 7;
            this.btnSuivante.Text = "suivante";
            this.btnSuivante.UseVisualStyleBackColor = true;
            this.btnSuivante.Click += new System.EventHandler(this.btnSuivante_Click);
            // 
            // lblRepProb
            // 
            this.lblRepProb.AutoSize = true;
            this.lblRepProb.Location = new System.Drawing.Point(6, 64);
            this.lblRepProb.Name = "lblRepProb";
            this.lblRepProb.Size = new System.Drawing.Size(57, 15);
            this.lblRepProb.TabIndex = 6;
            this.lblRepProb.Text = "5 x 3 = 15";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(100, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "=";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(42, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "x";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtRéponse
            // 
            this.txtRéponse.Location = new System.Drawing.Point(125, 22);
            this.txtRéponse.Name = "txtRéponse";
            this.txtRéponse.Size = new System.Drawing.Size(30, 23);
            this.txtRéponse.TabIndex = 4;
            this.txtRéponse.TextChanged += new System.EventHandler(this.txtRéponse_TextChanged);
            this.txtRéponse.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRéponse_KeyPress);
            // 
            // txtMultiplicateur
            // 
            this.txtMultiplicateur.Enabled = false;
            this.txtMultiplicateur.Location = new System.Drawing.Point(64, 22);
            this.txtMultiplicateur.Name = "txtMultiplicateur";
            this.txtMultiplicateur.Size = new System.Drawing.Size(30, 23);
            this.txtMultiplicateur.TabIndex = 3;
            // 
            // txtChiffre
            // 
            this.txtChiffre.Enabled = false;
            this.txtChiffre.Location = new System.Drawing.Point(6, 22);
            this.txtChiffre.Name = "txtChiffre";
            this.txtChiffre.Size = new System.Drawing.Size(30, 23);
            this.txtChiffre.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtNbQuest);
            this.groupBox2.Controls.Add(this.txtNumQuest);
            this.groupBox2.Location = new System.Drawing.Point(12, 118);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(107, 56);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Note";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(43, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "/";
            // 
            // txtNbQuest
            // 
            this.txtNbQuest.Enabled = false;
            this.txtNbQuest.Location = new System.Drawing.Point(64, 22);
            this.txtNbQuest.Name = "txtNbQuest";
            this.txtNbQuest.Size = new System.Drawing.Size(30, 23);
            this.txtNbQuest.TabIndex = 5;
            // 
            // txtNumQuest
            // 
            this.txtNumQuest.Enabled = false;
            this.txtNumQuest.Location = new System.Drawing.Point(6, 22);
            this.txtNumQuest.Name = "txtNumQuest";
            this.txtNumQuest.Size = new System.Drawing.Size(30, 23);
            this.txtNumQuest.TabIndex = 4;
            // 
            // btnRelfaire
            // 
            this.btnRelfaire.Location = new System.Drawing.Point(135, 127);
            this.btnRelfaire.Name = "btnRelfaire";
            this.btnRelfaire.Size = new System.Drawing.Size(52, 46);
            this.btnRelfaire.TabIndex = 8;
            this.btnRelfaire.Text = "Refaire le test";
            this.btnRelfaire.UseVisualStyleBackColor = true;
            this.btnRelfaire.Click += new System.EventHandler(this.btnRelfaire_Click);
            // 
            // frmTestCalcul
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(197, 181);
            this.Controls.Add(this.btnRelfaire);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gpbQuestion);
            this.Name = "frmTestCalcul";
            this.Text = "Test Calcul ";
            this.Load += new System.EventHandler(this.frmTestCalcul_Load);
            this.gpbQuestion.ResumeLayout(false);
            this.gpbQuestion.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbQuestion;
        private System.Windows.Forms.Button btnSuivante;
        private System.Windows.Forms.Label lblRepProb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRéponse;
        private System.Windows.Forms.TextBox txtMultiplicateur;
        private System.Windows.Forms.TextBox txtChiffre;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNbQuest;
        private System.Windows.Forms.TextBox txtNumQuest;
        private System.Windows.Forms.Button btnRelfaire;
    }
}


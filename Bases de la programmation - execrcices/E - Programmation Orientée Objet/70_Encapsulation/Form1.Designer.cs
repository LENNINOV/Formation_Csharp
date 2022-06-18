
namespace _70_Encapsulation
{
    partial class frmPerso
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.txtEtatperso = new System.Windows.Forms.TextBox();
            this.txtPersoMaxVie = new System.Windows.Forms.TextBox();
            this.numVie = new System.Windows.Forms.NumericUpDown();
            this.lsbPersonnages = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.numVie)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "login :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Personnages  :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 310);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Personnage ayant le plus de vie :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "vie :";
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(58, 6);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(132, 23);
            this.txtLogin.TabIndex = 4;
            this.txtLogin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLogin_KeyPress);
            // 
            // txtEtatperso
            // 
            this.txtEtatperso.Location = new System.Drawing.Point(12, 72);
            this.txtEtatperso.Name = "txtEtatperso";
            this.txtEtatperso.Size = new System.Drawing.Size(178, 23);
            this.txtEtatperso.TabIndex = 5;
            // 
            // txtPersoMaxVie
            // 
            this.txtPersoMaxVie.Location = new System.Drawing.Point(12, 328);
            this.txtPersoMaxVie.Name = "txtPersoMaxVie";
            this.txtPersoMaxVie.Size = new System.Drawing.Size(178, 23);
            this.txtPersoMaxVie.TabIndex = 6;
            // 
            // numVie
            // 
            this.numVie.Location = new System.Drawing.Point(58, 43);
            this.numVie.Name = "numVie";
            this.numVie.ReadOnly = true;
            this.numVie.Size = new System.Drawing.Size(72, 23);
            this.numVie.TabIndex = 7;
            this.numVie.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numVie.ValueChanged += new System.EventHandler(this.numVie_ValueChanged);
            // 
            // lsbPersonnages
            // 
            this.lsbPersonnages.FormattingEnabled = true;
            this.lsbPersonnages.ItemHeight = 15;
            this.lsbPersonnages.Location = new System.Drawing.Point(12, 128);
            this.lsbPersonnages.Name = "lsbPersonnages";
            this.lsbPersonnages.Size = new System.Drawing.Size(178, 169);
            this.lsbPersonnages.TabIndex = 8;
            this.lsbPersonnages.SelectedIndexChanged += new System.EventHandler(this.lsbPersonnages_SelectedIndexChanged);
            // 
            // frmPerso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(205, 366);
            this.Controls.Add(this.lsbPersonnages);
            this.Controls.Add(this.numVie);
            this.Controls.Add(this.txtPersoMaxVie);
            this.Controls.Add(this.txtEtatperso);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmPerso";
            this.Text = "Perso";
            ((System.ComponentModel.ISupportInitialize)(this.numVie)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.TextBox txtEtatperso;
        private System.Windows.Forms.TextBox txtPersoMaxVie;
        private System.Windows.Forms.NumericUpDown numVie;
        private System.Windows.Forms.ListBox lsbPersonnages;
    }
}


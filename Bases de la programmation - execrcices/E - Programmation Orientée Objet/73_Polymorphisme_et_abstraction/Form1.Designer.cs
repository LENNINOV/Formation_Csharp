
namespace _73_Polymorphisme_et_abstraction
{
    partial class frmPersonnage
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboPouvoir = new System.Windows.Forms.ComboBox();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.nupVie = new System.Windows.Forms.NumericUpDown();
            this.radXmen = new System.Windows.Forms.RadioButton();
            this.radHumain = new System.Windows.Forms.RadioButton();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.lblVie = new System.Windows.Forms.Label();
            this.lblPouvoir = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lsbPersonnage = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupVie)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboPouvoir);
            this.groupBox1.Controls.Add(this.btnAjouter);
            this.groupBox1.Controls.Add(this.nupVie);
            this.groupBox1.Controls.Add(this.radXmen);
            this.groupBox1.Controls.Add(this.radHumain);
            this.groupBox1.Controls.Add(this.txtLogin);
            this.groupBox1.Controls.Add(this.lblVie);
            this.groupBox1.Controls.Add(this.lblPouvoir);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(392, 106);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Créer un personnage";
            // 
            // cboPouvoir
            // 
            this.cboPouvoir.FormattingEnabled = true;
            this.cboPouvoir.Items.AddRange(new object[] {
            "Magnétisme",
            "Energie",
            "Lévitation",
            "Force",
            "Eau",
            "Feu"});
            this.cboPouvoir.Location = new System.Drawing.Point(66, 42);
            this.cboPouvoir.Name = "cboPouvoir";
            this.cboPouvoir.Size = new System.Drawing.Size(230, 23);
            this.cboPouvoir.TabIndex = 9;
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(312, 71);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(75, 23);
            this.btnAjouter.TabIndex = 8;
            this.btnAjouter.Text = "ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // nupVie
            // 
            this.nupVie.Location = new System.Drawing.Point(66, 71);
            this.nupVie.Name = "nupVie";
            this.nupVie.ReadOnly = true;
            this.nupVie.Size = new System.Drawing.Size(62, 23);
            this.nupVie.TabIndex = 7;
            this.nupVie.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // radXmen
            // 
            this.radXmen.AutoSize = true;
            this.radXmen.Location = new System.Drawing.Point(321, 46);
            this.radXmen.Name = "radXmen";
            this.radXmen.Size = new System.Drawing.Size(58, 19);
            this.radXmen.TabIndex = 6;
            this.radXmen.TabStop = true;
            this.radXmen.Text = "x men";
            this.radXmen.UseVisualStyleBackColor = true;
            this.radXmen.CheckedChanged += new System.EventHandler(this.radXmen_CheckedChanged);
            // 
            // radHumain
            // 
            this.radHumain.AutoSize = true;
            this.radHumain.Location = new System.Drawing.Point(321, 20);
            this.radHumain.Name = "radHumain";
            this.radHumain.Size = new System.Drawing.Size(66, 19);
            this.radHumain.TabIndex = 5;
            this.radHumain.TabStop = true;
            this.radHumain.Text = "humain";
            this.radHumain.UseVisualStyleBackColor = true;
            this.radHumain.CheckedChanged += new System.EventHandler(this.radHumain_CheckedChanged);
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(66, 16);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(230, 23);
            this.txtLogin.TabIndex = 3;
            // 
            // lblVie
            // 
            this.lblVie.AutoSize = true;
            this.lblVie.Location = new System.Drawing.Point(6, 73);
            this.lblVie.Name = "lblVie";
            this.lblVie.Size = new System.Drawing.Size(28, 15);
            this.lblVie.TabIndex = 2;
            this.lblVie.Text = "vie :";
            // 
            // lblPouvoir
            // 
            this.lblPouvoir.AutoSize = true;
            this.lblPouvoir.Location = new System.Drawing.Point(6, 45);
            this.lblPouvoir.Name = "lblPouvoir";
            this.lblPouvoir.Size = new System.Drawing.Size(54, 15);
            this.lblPouvoir.TabIndex = 1;
            this.lblPouvoir.Text = "pouvoir :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "login :";
            // 
            // lsbPersonnage
            // 
            this.lsbPersonnage.FormattingEnabled = true;
            this.lsbPersonnage.ItemHeight = 15;
            this.lsbPersonnage.Location = new System.Drawing.Point(12, 124);
            this.lsbPersonnage.Name = "lsbPersonnage";
            this.lsbPersonnage.Size = new System.Drawing.Size(392, 304);
            this.lsbPersonnage.TabIndex = 1;
            // 
            // frmPersonnage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 443);
            this.Controls.Add(this.lsbPersonnage);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmPersonnage";
            this.Text = "Jeu";
            this.Load += new System.EventHandler(this.frmPersonnage_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupVie)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboPouvoir;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.NumericUpDown nupVie;
        private System.Windows.Forms.RadioButton radXmen;
        private System.Windows.Forms.RadioButton radHumain;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Label lblVie;
        private System.Windows.Forms.Label lblPouvoir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lsbPersonnage;
    }
}



namespace Ex66_ConvertisseurMonnaies
{
    partial class frmConvertisseur
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
            this.lblMonnaie = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEuro = new System.Windows.Forms.TextBox();
            this.txtValeur = new System.Windows.Forms.TextBox();
            this.txtMonnaie = new System.Windows.Forms.TextBox();
            this.cboMonnaie = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Monnaie";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMonnaie
            // 
            this.lblMonnaie.AutoSize = true;
            this.lblMonnaie.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMonnaie.Location = new System.Drawing.Point(177, 87);
            this.lblMonnaie.Name = "lblMonnaie";
            this.lblMonnaie.Size = new System.Drawing.Size(19, 21);
            this.lblMonnaie.TabIndex = 1;
            this.lblMonnaie.Text = "$";
            this.lblMonnaie.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(177, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Valeur";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(177, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "€";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtEuro
            // 
            this.txtEuro.Location = new System.Drawing.Point(12, 56);
            this.txtEuro.Name = "txtEuro";
            this.txtEuro.Size = new System.Drawing.Size(159, 23);
            this.txtEuro.TabIndex = 4;
            this.txtEuro.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtEuro.TextChanged += new System.EventHandler(this.txtEuro_TextChanged);
            // 
            // txtValeur
            // 
            this.txtValeur.Enabled = false;
            this.txtValeur.Location = new System.Drawing.Point(177, 27);
            this.txtValeur.Name = "txtValeur";
            this.txtValeur.Size = new System.Drawing.Size(158, 23);
            this.txtValeur.TabIndex = 5;
            this.txtValeur.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtMonnaie
            // 
            this.txtMonnaie.Enabled = false;
            this.txtMonnaie.Location = new System.Drawing.Point(12, 85);
            this.txtMonnaie.Name = "txtMonnaie";
            this.txtMonnaie.Size = new System.Drawing.Size(159, 23);
            this.txtMonnaie.TabIndex = 6;
            this.txtMonnaie.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cboMonnaie
            // 
            this.cboMonnaie.FormattingEnabled = true;
            this.cboMonnaie.Location = new System.Drawing.Point(12, 27);
            this.cboMonnaie.Name = "cboMonnaie";
            this.cboMonnaie.Size = new System.Drawing.Size(159, 23);
            this.cboMonnaie.TabIndex = 7;
            this.cboMonnaie.SelectedIndexChanged += new System.EventHandler(this.cboMonnaie_SelectedIndexChanged);
            // 
            // frmConvertisseur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 119);
            this.Controls.Add(this.cboMonnaie);
            this.Controls.Add(this.txtMonnaie);
            this.Controls.Add(this.txtValeur);
            this.Controls.Add(this.txtEuro);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblMonnaie);
            this.Controls.Add(this.label1);
            this.Name = "frmConvertisseur";
            this.Text = "Convertisseur";
            this.Load += new System.EventHandler(this.frmConvertisseur_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMonnaie;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEuro;
        private System.Windows.Forms.TextBox txtValeur;
        private System.Windows.Forms.TextBox txtMonnaie;
        private System.Windows.Forms.ComboBox cboMonnaie;
    }
}


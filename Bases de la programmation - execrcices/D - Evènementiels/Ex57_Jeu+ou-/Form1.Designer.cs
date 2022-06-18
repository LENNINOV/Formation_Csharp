
namespace Ex57_Jeu_ou_
{
    partial class frmNombreCache
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
            this.grpValeur = new System.Windows.Forms.GroupBox();
            this.btnValider = new System.Windows.Forms.Button();
            this.txtValeur = new System.Windows.Forms.TextBox();
            this.grpReponse = new System.Windows.Forms.GroupBox();
            this.lblMessage = new System.Windows.Forms.Label();
            this.btnRejouer = new System.Windows.Forms.Button();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.grpValeur.SuspendLayout();
            this.grpReponse.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpValeur
            // 
            this.grpValeur.Controls.Add(this.btnValider);
            this.grpValeur.Controls.Add(this.txtValeur);
            this.grpValeur.Location = new System.Drawing.Point(12, 12);
            this.grpValeur.Name = "grpValeur";
            this.grpValeur.Size = new System.Drawing.Size(274, 57);
            this.grpValeur.TabIndex = 0;
            this.grpValeur.TabStop = false;
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(227, 22);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(41, 23);
            this.btnValider.TabIndex = 2;
            this.btnValider.Text = "OK";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // txtValeur
            // 
            this.txtValeur.Location = new System.Drawing.Point(6, 22);
            this.txtValeur.Name = "txtValeur";
            this.txtValeur.Size = new System.Drawing.Size(215, 23);
            this.txtValeur.TabIndex = 0;
            this.txtValeur.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtValeur.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValeur_KeyPress);
            // 
            // grpReponse
            // 
            this.grpReponse.Controls.Add(this.lblMessage);
            this.grpReponse.Location = new System.Drawing.Point(12, 75);
            this.grpReponse.Name = "grpReponse";
            this.grpReponse.Size = new System.Drawing.Size(274, 57);
            this.grpReponse.TabIndex = 1;
            this.grpReponse.TabStop = false;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(6, 19);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(0, 15);
            this.lblMessage.TabIndex = 2;
            // 
            // btnRejouer
            // 
            this.btnRejouer.Image = global::Ex57_Jeu_ou_.Properties.Resources.button_restart;
            this.btnRejouer.Location = new System.Drawing.Point(307, 12);
            this.btnRejouer.Name = "btnRejouer";
            this.btnRejouer.Size = new System.Drawing.Size(60, 57);
            this.btnRejouer.TabIndex = 2;
            this.btnRejouer.UseVisualStyleBackColor = true;
            this.btnRejouer.Click += new System.EventHandler(this.btnRejouer_Click);
            // 
            // btnQuitter
            // 
            this.btnQuitter.Image = global::Ex57_Jeu_ou_.Properties.Resources.Shutdown;
            this.btnQuitter.Location = new System.Drawing.Point(307, 75);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(60, 57);
            this.btnQuitter.TabIndex = 3;
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // frmNombreCache
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 142);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.btnRejouer);
            this.Controls.Add(this.grpReponse);
            this.Controls.Add(this.grpValeur);
            this.Name = "frmNombreCache";
            this.Text = "Nombre caché";
            this.Load += new System.EventHandler(this.frmNombreCache_Load);
            this.grpValeur.ResumeLayout(false);
            this.grpValeur.PerformLayout();
            this.grpReponse.ResumeLayout(false);
            this.grpReponse.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpValeur;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.TextBox txtValeur;
        private System.Windows.Forms.GroupBox grpReponse;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Button btnRejouer;
        private System.Windows.Forms.Button btnQuitter;
    }
}



namespace Ex64_Poids_Idéal
{
    partial class frmCREFF
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
            this.lblTaille = new System.Windows.Forms.Label();
            this.lblNaissance = new System.Windows.Forms.Label();
            this.txtTaille = new System.Windows.Forms.TextBox();
            this.dtpNaissance = new System.Windows.Forms.DateTimePicker();
            this.grbMorphologie = new System.Windows.Forms.GroupBox();
            this.grbLarge = new System.Windows.Forms.RadioButton();
            this.grbGracile = new System.Windows.Forms.RadioButton();
            this.grbNormale = new System.Windows.Forms.RadioButton();
            this.cmdCalcul = new System.Windows.Forms.Button();
            this.txtPoidsIdeal = new System.Windows.Forms.TextBox();
            this.lblPoidsIdeal = new System.Windows.Forms.Label();
            this.grbMorphologie.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTaille
            // 
            this.lblTaille.AutoSize = true;
            this.lblTaille.Location = new System.Drawing.Point(12, 9);
            this.lblTaille.Name = "lblTaille";
            this.lblTaille.Size = new System.Drawing.Size(82, 15);
            this.lblTaille.TabIndex = 0;
            this.lblTaille.Text = "taille (en cm) :";
            // 
            // lblNaissance
            // 
            this.lblNaissance.AutoSize = true;
            this.lblNaissance.Location = new System.Drawing.Point(12, 41);
            this.lblNaissance.Name = "lblNaissance";
            this.lblNaissance.Size = new System.Drawing.Size(85, 15);
            this.lblNaissance.TabIndex = 1;
            this.lblNaissance.Text = "date naisance :";
            // 
            // txtTaille
            // 
            this.txtTaille.Location = new System.Drawing.Point(103, 6);
            this.txtTaille.Name = "txtTaille";
            this.txtTaille.Size = new System.Drawing.Size(110, 23);
            this.txtTaille.TabIndex = 2;
            this.txtTaille.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // dtpNaissance
            // 
            this.dtpNaissance.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNaissance.Location = new System.Drawing.Point(103, 35);
            this.dtpNaissance.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpNaissance.Name = "dtpNaissance";
            this.dtpNaissance.Size = new System.Drawing.Size(110, 23);
            this.dtpNaissance.TabIndex = 3;
            // 
            // grbMorphologie
            // 
            this.grbMorphologie.Controls.Add(this.grbLarge);
            this.grbMorphologie.Controls.Add(this.grbGracile);
            this.grbMorphologie.Controls.Add(this.grbNormale);
            this.grbMorphologie.Location = new System.Drawing.Point(12, 64);
            this.grbMorphologie.Name = "grbMorphologie";
            this.grbMorphologie.Size = new System.Drawing.Size(201, 58);
            this.grbMorphologie.TabIndex = 4;
            this.grbMorphologie.TabStop = false;
            this.grbMorphologie.Text = "morphologie";
            // 
            // grbLarge
            // 
            this.grbLarge.AutoSize = true;
            this.grbLarge.Location = new System.Drawing.Point(147, 22);
            this.grbLarge.Name = "grbLarge";
            this.grbLarge.Size = new System.Drawing.Size(51, 19);
            this.grbLarge.TabIndex = 7;
            this.grbLarge.TabStop = true;
            this.grbLarge.Text = "large";
            this.grbLarge.UseVisualStyleBackColor = true;
            this.grbLarge.CheckedChanged += new System.EventHandler(this.grbLarge_CheckedChanged);
            // 
            // grbGracile
            // 
            this.grbGracile.AutoSize = true;
            this.grbGracile.Location = new System.Drawing.Point(6, 22);
            this.grbGracile.Name = "grbGracile";
            this.grbGracile.Size = new System.Drawing.Size(60, 19);
            this.grbGracile.TabIndex = 5;
            this.grbGracile.Text = "gracile";
            this.grbGracile.UseVisualStyleBackColor = true;
            this.grbGracile.CheckedChanged += new System.EventHandler(this.grbGracile_CheckedChanged);
            // 
            // grbNormale
            // 
            this.grbNormale.AutoSize = true;
            this.grbNormale.Checked = true;
            this.grbNormale.Location = new System.Drawing.Point(72, 22);
            this.grbNormale.Name = "grbNormale";
            this.grbNormale.Size = new System.Drawing.Size(69, 19);
            this.grbNormale.TabIndex = 6;
            this.grbNormale.TabStop = true;
            this.grbNormale.Text = "normale";
            this.grbNormale.UseVisualStyleBackColor = true;
            // 
            // cmdCalcul
            // 
            this.cmdCalcul.Location = new System.Drawing.Point(78, 128);
            this.cmdCalcul.Name = "cmdCalcul";
            this.cmdCalcul.Size = new System.Drawing.Size(75, 23);
            this.cmdCalcul.TabIndex = 5;
            this.cmdCalcul.Text = "calculer";
            this.cmdCalcul.UseVisualStyleBackColor = true;
            this.cmdCalcul.Click += new System.EventHandler(this.cmdCalcul_Click);
            // 
            // txtPoidsIdeal
            // 
            this.txtPoidsIdeal.Enabled = false;
            this.txtPoidsIdeal.Location = new System.Drawing.Point(88, 162);
            this.txtPoidsIdeal.Name = "txtPoidsIdeal";
            this.txtPoidsIdeal.Size = new System.Drawing.Size(125, 23);
            this.txtPoidsIdeal.TabIndex = 6;
            this.txtPoidsIdeal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblPoidsIdeal
            // 
            this.lblPoidsIdeal.AutoSize = true;
            this.lblPoidsIdeal.Location = new System.Drawing.Point(12, 170);
            this.lblPoidsIdeal.Name = "lblPoidsIdeal";
            this.lblPoidsIdeal.Size = new System.Drawing.Size(70, 15);
            this.lblPoidsIdeal.TabIndex = 8;
            this.lblPoidsIdeal.Text = "poids idéal :";
            // 
            // frmCREFF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(226, 194);
            this.Controls.Add(this.lblPoidsIdeal);
            this.Controls.Add(this.txtPoidsIdeal);
            this.Controls.Add(this.cmdCalcul);
            this.Controls.Add(this.grbMorphologie);
            this.Controls.Add(this.dtpNaissance);
            this.Controls.Add(this.txtTaille);
            this.Controls.Add(this.lblNaissance);
            this.Controls.Add(this.lblTaille);
            this.Name = "frmCREFF";
            this.Text = "CREFF";
            this.grbMorphologie.ResumeLayout(false);
            this.grbMorphologie.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTaille;
        private System.Windows.Forms.Label lblNaissance;
        private System.Windows.Forms.TextBox txtTaille;
        private System.Windows.Forms.DateTimePicker dtpNaissance;
        private System.Windows.Forms.GroupBox grbMorphologie;
        private System.Windows.Forms.RadioButton grbLarge;
        private System.Windows.Forms.RadioButton grbGracile;
        private System.Windows.Forms.RadioButton grbNormale;
        private System.Windows.Forms.Button cmdCalcul;
        private System.Windows.Forms.TextBox txtPoidsIdeal;
        private System.Windows.Forms.Label lblPoidsIdeal;
    }
}


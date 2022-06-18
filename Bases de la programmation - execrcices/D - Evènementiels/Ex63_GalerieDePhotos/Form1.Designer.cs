
namespace Ex63_GalerieDePhotos
{
    partial class Form1
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
            this.lstPhoto = new System.Windows.Forms.ListBox();
            this.btnDossier = new System.Windows.Forms.Button();
            this.btnRotation = new System.Windows.Forms.Button();
            this.pctPhotos = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctPhotos)).BeginInit();
            this.SuspendLayout();
            // 
            // lstPhoto
            // 
            this.lstPhoto.FormattingEnabled = true;
            this.lstPhoto.HorizontalScrollbar = true;
            this.lstPhoto.ItemHeight = 15;
            this.lstPhoto.Location = new System.Drawing.Point(12, 12);
            this.lstPhoto.Name = "lstPhoto";
            this.lstPhoto.Size = new System.Drawing.Size(166, 319);
            this.lstPhoto.TabIndex = 0;
            this.lstPhoto.SelectedIndexChanged += new System.EventHandler(this.lstPhoto_SelectedIndexChanged);
            // 
            // btnDossier
            // 
            this.btnDossier.Image = global::Ex63_GalerieDePhotos.Properties.Resources.Folder;
            this.btnDossier.Location = new System.Drawing.Point(12, 332);
            this.btnDossier.Name = "btnDossier";
            this.btnDossier.Size = new System.Drawing.Size(80, 80);
            this.btnDossier.TabIndex = 1;
            this.btnDossier.UseVisualStyleBackColor = true;
            this.btnDossier.Click += new System.EventHandler(this.btnDossier_Click);
            // 
            // btnRotation
            // 
            this.btnRotation.BackColor = System.Drawing.Color.White;
            this.btnRotation.Image = global::Ex63_GalerieDePhotos.Properties.Resources.Rotate1;
            this.btnRotation.Location = new System.Drawing.Point(98, 332);
            this.btnRotation.Name = "btnRotation";
            this.btnRotation.Size = new System.Drawing.Size(80, 80);
            this.btnRotation.TabIndex = 2;
            this.btnRotation.UseVisualStyleBackColor = false;
            this.btnRotation.Click += new System.EventHandler(this.btnRotation_Click);
            // 
            // pctPhotos
            // 
            this.pctPhotos.Location = new System.Drawing.Point(184, 12);
            this.pctPhotos.Name = "pctPhotos";
            this.pctPhotos.Size = new System.Drawing.Size(400, 400);
            this.pctPhotos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctPhotos.TabIndex = 3;
            this.pctPhotos.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 421);
            this.Controls.Add(this.pctPhotos);
            this.Controls.Add(this.btnRotation);
            this.Controls.Add(this.btnDossier);
            this.Controls.Add(this.lstPhoto);
            this.Name = "Form1";
            this.Text = "Galerie photos";
            ((System.ComponentModel.ISupportInitialize)(this.pctPhotos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstPhoto;
        private System.Windows.Forms.Button btnDossier;
        private System.Windows.Forms.Button btnRotation;
        private System.Windows.Forms.PictureBox pctPhotos;
    }
}


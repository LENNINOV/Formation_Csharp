
namespace Convertisseur
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
            this.grpBase10 = new System.Windows.Forms.GroupBox();
            this.txtBase10 = new System.Windows.Forms.TextBox();
            this.txtBase2 = new System.Windows.Forms.TextBox();
            this.grpBase2 = new System.Windows.Forms.GroupBox();
            this.grpBase10.SuspendLayout();
            this.grpBase2.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBase10
            // 
            this.grpBase10.Controls.Add(this.txtBase10);
            this.grpBase10.Location = new System.Drawing.Point(12, 12);
            this.grpBase10.Name = "grpBase10";
            this.grpBase10.Size = new System.Drawing.Size(375, 55);
            this.grpBase10.TabIndex = 0;
            this.grpBase10.TabStop = false;
            this.grpBase10.Text = "Base 10";
            // 
            // txtBase10
            // 
            this.txtBase10.Location = new System.Drawing.Point(7, 23);
            this.txtBase10.Name = "txtBase10";
            this.txtBase10.Size = new System.Drawing.Size(362, 23);
            this.txtBase10.TabIndex = 0;
            this.txtBase10.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtBase10.TextChanged += new System.EventHandler(this.txtBase10_TextChanged);
            // 
            // txtBase2
            // 
            this.txtBase2.Location = new System.Drawing.Point(6, 22);
            this.txtBase2.Name = "txtBase2";
            this.txtBase2.Size = new System.Drawing.Size(362, 23);
            this.txtBase2.TabIndex = 0;
            this.txtBase2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtBase2.TextChanged += new System.EventHandler(this.txtBase2_TextChanged);
            // 
            // grpBase2
            // 
            this.grpBase2.Controls.Add(this.txtBase2);
            this.grpBase2.Location = new System.Drawing.Point(12, 82);
            this.grpBase2.Name = "grpBase2";
            this.grpBase2.Size = new System.Drawing.Size(375, 55);
            this.grpBase2.TabIndex = 1;
            this.grpBase2.TabStop = false;
            this.grpBase2.Text = "Base 2";
            // 
            // frmConvertisseur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 150);
            this.Controls.Add(this.grpBase2);
            this.Controls.Add(this.grpBase10);
            this.Name = "frmConvertisseur";
            this.Text = "Convertisseur";
            this.grpBase10.ResumeLayout(false);
            this.grpBase10.PerformLayout();
            this.grpBase2.ResumeLayout(false);
            this.grpBase2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBase10;
        private System.Windows.Forms.TextBox txtBase10;
        private System.Windows.Forms.TextBox txtBase2;
        private System.Windows.Forms.GroupBox grpBase2;
    }
}


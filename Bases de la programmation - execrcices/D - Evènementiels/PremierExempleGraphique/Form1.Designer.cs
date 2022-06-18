
namespace PremierExempleGraphique
{
    partial class Opérations
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnMultiplication = new System.Windows.Forms.Button();
            this.btnErase = new System.Windows.Forms.Button();
            this.btnShutdown = new System.Windows.Forms.Button();
            this.txtValeur1 = new System.Windows.Forms.TextBox();
            this.txtValeur2 = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblOperation = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAdd.Location = new System.Drawing.Point(175, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(60, 60);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnMultiplication
            // 
            this.btnMultiplication.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMultiplication.Location = new System.Drawing.Point(175, 69);
            this.btnMultiplication.Name = "btnMultiplication";
            this.btnMultiplication.Size = new System.Drawing.Size(60, 60);
            this.btnMultiplication.TabIndex = 1;
            this.btnMultiplication.Text = "x";
            this.btnMultiplication.UseVisualStyleBackColor = true;
            this.btnMultiplication.Click += new System.EventHandler(this.btnMultiplication_Click);
            // 
            // btnErase
            // 
            this.btnErase.Image = global::PremierExempleGraphique.Properties.Resources.eraser3;
            this.btnErase.Location = new System.Drawing.Point(256, 4);
            this.btnErase.Name = "btnErase";
            this.btnErase.Size = new System.Drawing.Size(60, 60);
            this.btnErase.TabIndex = 2;
            this.btnErase.UseVisualStyleBackColor = true;
            this.btnErase.Click += new System.EventHandler(this.btnErase_Click);
            // 
            // btnShutdown
            // 
            this.btnShutdown.Image = global::PremierExempleGraphique.Properties.Resources.Shutdown1;
            this.btnShutdown.Location = new System.Drawing.Point(256, 69);
            this.btnShutdown.Name = "btnShutdown";
            this.btnShutdown.Size = new System.Drawing.Size(60, 60);
            this.btnShutdown.TabIndex = 3;
            this.btnShutdown.UseVisualStyleBackColor = true;
            this.btnShutdown.Click += new System.EventHandler(this.btnShutdown_Click);
            // 
            // txtValeur1
            // 
            this.txtValeur1.Location = new System.Drawing.Point(39, 12);
            this.txtValeur1.Name = "txtValeur1";
            this.txtValeur1.Size = new System.Drawing.Size(118, 23);
            this.txtValeur1.TabIndex = 4;
            this.txtValeur1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtValeur1.TextChanged += new System.EventHandler(this.txtValeur1_TextChanged);
            // 
            // txtValeur2
            // 
            this.txtValeur2.Location = new System.Drawing.Point(39, 41);
            this.txtValeur2.Name = "txtValeur2";
            this.txtValeur2.Size = new System.Drawing.Size(118, 23);
            this.txtValeur2.TabIndex = 5;
            this.txtValeur2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtValeur2.TextChanged += new System.EventHandler(this.txtValeur2_TextChanged);
            // 
            // txtResult
            // 
            this.txtResult.Enabled = false;
            this.txtResult.Location = new System.Drawing.Point(39, 103);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(118, 23);
            this.txtResult.TabIndex = 6;
            this.txtResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblResult.Location = new System.Drawing.Point(3, 95);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(30, 31);
            this.lblResult.TabIndex = 8;
            this.lblResult.Text = "=";
            // 
            // lblOperation
            // 
            this.lblOperation.AutoSize = true;
            this.lblOperation.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblOperation.Location = new System.Drawing.Point(3, 37);
            this.lblOperation.Name = "lblOperation";
            this.lblOperation.Size = new System.Drawing.Size(35, 31);
            this.lblOperation.TabIndex = 9;
            this.lblOperation.Text = "   ";
            this.lblOperation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Opérations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 136);
            this.Controls.Add(this.lblOperation);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.txtValeur2);
            this.Controls.Add(this.txtValeur1);
            this.Controls.Add(this.btnShutdown);
            this.Controls.Add(this.btnErase);
            this.Controls.Add(this.btnMultiplication);
            this.Controls.Add(this.btnAdd);
            this.Name = "Opérations";
            this.Text = "Opérations";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnMultiplication;
        private System.Windows.Forms.Button btnErase;
        private System.Windows.Forms.Button btnShutdown;
        private System.Windows.Forms.TextBox txtValeur1;
        private System.Windows.Forms.TextBox txtValeur2;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblOperation;
    }
}


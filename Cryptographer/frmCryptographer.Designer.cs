namespace Cryptographer
{
    partial class frmCryptographer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCaezar = new System.Windows.Forms.Button();
            this.btnVigenere = new System.Windows.Forms.Button();
            this.btnPlayfair = new System.Windows.Forms.Button();
            this.btnDiffieHellman = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCaezar
            // 
            this.btnCaezar.Location = new System.Drawing.Point(16, 45);
            this.btnCaezar.Name = "btnCaezar";
            this.btnCaezar.Size = new System.Drawing.Size(100, 23);
            this.btnCaezar.TabIndex = 0;
            this.btnCaezar.Text = "Caesar cipher";
            this.btnCaezar.UseVisualStyleBackColor = true;
            this.btnCaezar.Click += new System.EventHandler(this.btnCaezar_Click);
            // 
            // btnVigenere
            // 
            this.btnVigenere.Location = new System.Drawing.Point(16, 90);
            this.btnVigenere.Name = "btnVigenere";
            this.btnVigenere.Size = new System.Drawing.Size(100, 23);
            this.btnVigenere.TabIndex = 1;
            this.btnVigenere.Text = "Vigenere cipher";
            this.btnVigenere.UseVisualStyleBackColor = true;
            this.btnVigenere.Click += new System.EventHandler(this.btnVigenere_Click);
            // 
            // btnPlayfair
            // 
            this.btnPlayfair.Location = new System.Drawing.Point(16, 135);
            this.btnPlayfair.Name = "btnPlayfair";
            this.btnPlayfair.Size = new System.Drawing.Size(100, 23);
            this.btnPlayfair.TabIndex = 2;
            this.btnPlayfair.Text = "Playfair cipher";
            this.btnPlayfair.UseVisualStyleBackColor = true;
            this.btnPlayfair.Click += new System.EventHandler(this.btnPlayfair_Click);
            // 
            // btnDiffieHellman
            // 
            this.btnDiffieHellman.Location = new System.Drawing.Point(16, 178);
            this.btnDiffieHellman.Name = "btnDiffieHellman";
            this.btnDiffieHellman.Size = new System.Drawing.Size(100, 23);
            this.btnDiffieHellman.TabIndex = 3;
            this.btnDiffieHellman.Text = "Diffie-Hellman";
            this.btnDiffieHellman.UseVisualStyleBackColor = true;
            this.btnDiffieHellman.Click += new System.EventHandler(this.btnDiffieHellman_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(12, 9);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(227, 20);
            this.lblWelcome.TabIndex = 4;
            this.lblWelcome.Text = "Welcome to Cryptographer!";
            // 
            // frmCryptographer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 341);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.btnDiffieHellman);
            this.Controls.Add(this.btnPlayfair);
            this.Controls.Add(this.btnVigenere);
            this.Controls.Add(this.btnCaezar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmCryptographer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Cryptographer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCaezar;
        private System.Windows.Forms.Button btnVigenere;
        private System.Windows.Forms.Button btnPlayfair;
        private System.Windows.Forms.Button btnDiffieHellman;
        private System.Windows.Forms.Label lblWelcome;
    }
}


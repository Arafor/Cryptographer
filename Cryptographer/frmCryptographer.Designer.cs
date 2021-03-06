﻿namespace Cryptographer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCryptographer));
            this.btnCaesar = new System.Windows.Forms.Button();
            this.btnVigenere = new System.Windows.Forms.Button();
            this.btnPlayfair = new System.Windows.Forms.Button();
            this.btnDiffieHellman = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnDES = new System.Windows.Forms.Button();
            this.btnAES = new System.Windows.Forms.Button();
            this.btnRSA = new System.Windows.Forms.Button();
            this.btnRSASignature = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCaesar
            // 
            this.btnCaesar.Location = new System.Drawing.Point(42, 61);
            this.btnCaesar.Name = "btnCaesar";
            this.btnCaesar.Size = new System.Drawing.Size(100, 23);
            this.btnCaesar.TabIndex = 0;
            this.btnCaesar.Text = "Caesar cipher";
            this.btnCaesar.UseVisualStyleBackColor = true;
            this.btnCaesar.Click += new System.EventHandler(this.btnCaesar_Click);
            // 
            // btnVigenere
            // 
            this.btnVigenere.Location = new System.Drawing.Point(42, 101);
            this.btnVigenere.Name = "btnVigenere";
            this.btnVigenere.Size = new System.Drawing.Size(100, 23);
            this.btnVigenere.TabIndex = 1;
            this.btnVigenere.Text = "Vigenere cipher";
            this.btnVigenere.UseVisualStyleBackColor = true;
            this.btnVigenere.Click += new System.EventHandler(this.btnVigenere_Click);
            // 
            // btnPlayfair
            // 
            this.btnPlayfair.Location = new System.Drawing.Point(42, 141);
            this.btnPlayfair.Name = "btnPlayfair";
            this.btnPlayfair.Size = new System.Drawing.Size(100, 23);
            this.btnPlayfair.TabIndex = 2;
            this.btnPlayfair.Text = "Playfair cipher";
            this.btnPlayfair.UseVisualStyleBackColor = true;
            this.btnPlayfair.Click += new System.EventHandler(this.btnPlayfair_Click);
            // 
            // btnDiffieHellman
            // 
            this.btnDiffieHellman.Location = new System.Drawing.Point(42, 341);
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
            this.lblWelcome.Location = new System.Drawing.Point(25, 9);
            this.lblWelcome.MaximumSize = new System.Drawing.Size(170, 0);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(128, 40);
            this.lblWelcome.TabIndex = 4;
            this.lblWelcome.Text = "Welcome to Cryptographer!";
            this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnDES
            // 
            this.btnDES.Location = new System.Drawing.Point(42, 181);
            this.btnDES.Name = "btnDES";
            this.btnDES.Size = new System.Drawing.Size(100, 23);
            this.btnDES.TabIndex = 5;
            this.btnDES.Text = "DES cipher";
            this.btnDES.UseVisualStyleBackColor = true;
            this.btnDES.Click += new System.EventHandler(this.btnDES_Click);
            // 
            // btnAES
            // 
            this.btnAES.Location = new System.Drawing.Point(42, 221);
            this.btnAES.Name = "btnAES";
            this.btnAES.Size = new System.Drawing.Size(100, 23);
            this.btnAES.TabIndex = 6;
            this.btnAES.Text = "AES cipher";
            this.btnAES.UseVisualStyleBackColor = true;
            this.btnAES.Click += new System.EventHandler(this.btnAES_Click);
            // 
            // btnRSA
            // 
            this.btnRSA.Location = new System.Drawing.Point(42, 261);
            this.btnRSA.Name = "btnRSA";
            this.btnRSA.Size = new System.Drawing.Size(100, 23);
            this.btnRSA.TabIndex = 7;
            this.btnRSA.Text = "RSA cipher";
            this.btnRSA.UseVisualStyleBackColor = true;
            this.btnRSA.Click += new System.EventHandler(this.btnRSA_Click);
            // 
            // btnRSASignature
            // 
            this.btnRSASignature.Location = new System.Drawing.Point(42, 301);
            this.btnRSASignature.Name = "btnRSASignature";
            this.btnRSASignature.Size = new System.Drawing.Size(100, 23);
            this.btnRSASignature.TabIndex = 8;
            this.btnRSASignature.Text = "RSA Signature";
            this.btnRSASignature.UseVisualStyleBackColor = true;
            this.btnRSASignature.Click += new System.EventHandler(this.btnRSASignature_Click);
            // 
            // frmCryptographer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(184, 381);
            this.Controls.Add(this.btnRSASignature);
            this.Controls.Add(this.btnRSA);
            this.Controls.Add(this.btnAES);
            this.Controls.Add(this.btnDES);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.btnDiffieHellman);
            this.Controls.Add(this.btnPlayfair);
            this.Controls.Add(this.btnVigenere);
            this.Controls.Add(this.btnCaesar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmCryptographer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Load += new System.EventHandler(this.frmCryptographer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCaesar;
        private System.Windows.Forms.Button btnVigenere;
        private System.Windows.Forms.Button btnPlayfair;
        private System.Windows.Forms.Button btnDiffieHellman;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnDES;
        private System.Windows.Forms.Button btnAES;
        private System.Windows.Forms.Button btnRSA;
        private System.Windows.Forms.Button btnRSASignature;
    }
}


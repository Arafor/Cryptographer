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
            this.SuspendLayout();
            // 
            // btnCaezar
            // 
            this.btnCaezar.Location = new System.Drawing.Point(76, 62);
            this.btnCaezar.Name = "btnCaezar";
            this.btnCaezar.Size = new System.Drawing.Size(75, 23);
            this.btnCaezar.TabIndex = 0;
            this.btnCaezar.Text = "Caesar cipher";
            this.btnCaezar.UseVisualStyleBackColor = true;
            this.btnCaezar.Click += new System.EventHandler(this.btnCaezar_Click);
            // 
            // btnVigenere
            // 
            this.btnVigenere.Location = new System.Drawing.Point(76, 111);
            this.btnVigenere.Name = "btnVigenere";
            this.btnVigenere.Size = new System.Drawing.Size(75, 23);
            this.btnVigenere.TabIndex = 1;
            this.btnVigenere.Text = "Vigenere cipher";
            this.btnVigenere.UseVisualStyleBackColor = true;
            this.btnVigenere.Click += new System.EventHandler(this.btnVigenere_Click);
            // 
            // btnPlayfair
            // 
            this.btnPlayfair.Location = new System.Drawing.Point(76, 160);
            this.btnPlayfair.Name = "btnPlayfair";
            this.btnPlayfair.Size = new System.Drawing.Size(75, 23);
            this.btnPlayfair.TabIndex = 2;
            this.btnPlayfair.Text = "Playfair cipher";
            this.btnPlayfair.UseVisualStyleBackColor = true;
            this.btnPlayfair.Click += new System.EventHandler(this.btnPlayfair_Click);
            // 
            // frmCryptographer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btnPlayfair);
            this.Controls.Add(this.btnVigenere);
            this.Controls.Add(this.btnCaezar);
            this.Name = "frmCryptographer";
            this.Text = "Cryptographer";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCaezar;
        private System.Windows.Forms.Button btnVigenere;
        private System.Windows.Forms.Button btnPlayfair;
    }
}


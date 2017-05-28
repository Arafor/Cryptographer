namespace Cryptographer
{
    partial class frmDiffieHellmanInfo
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
            this.btnDiffieHellman = new System.Windows.Forms.Button();
            this.lblDescription0 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSharedSecret
            // 
            this.lblSharedSecret.Location = new System.Drawing.Point(196, 274);
            // 
            // txtSharedSecret
            // 
            this.txtSharedSecret.Location = new System.Drawing.Point(199, 290);
            // 
            // lblOtherSecret
            // 
            this.lblOtherSecret.Location = new System.Drawing.Point(9, 274);
            // 
            // lblSecret
            // 
            this.lblSecret.Location = new System.Drawing.Point(196, 210);
            // 
            // txtOtherSecret
            // 
            this.txtOtherSecret.Location = new System.Drawing.Point(12, 290);
            // 
            // txtSecret
            // 
            this.txtSecret.Location = new System.Drawing.Point(199, 226);
            // 
            // lblSecretNumber
            // 
            this.lblSecretNumber.Location = new System.Drawing.Point(9, 210);
            // 
            // txtSecretNumber
            // 
            this.txtSecretNumber.Location = new System.Drawing.Point(12, 226);
            // 
            // lblPrimitiveRoot
            // 
            this.lblPrimitiveRoot.Location = new System.Drawing.Point(196, 130);
            // 
            // txtPrimitiveRoot
            // 
            this.txtPrimitiveRoot.Location = new System.Drawing.Point(199, 146);
            // 
            // lblPrimeNumber
            // 
            this.lblPrimeNumber.Location = new System.Drawing.Point(9, 130);
            // 
            // txtPrimeNumber
            // 
            this.cmbPrimeNumber.Location = new System.Drawing.Point(12, 146);
            // 
            // btnDiffieHellman
            // 
            this.btnDiffieHellman.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiffieHellman.Location = new System.Drawing.Point(265, 12);
            this.btnDiffieHellman.Name = "btnDiffieHellman";
            this.btnDiffieHellman.Size = new System.Drawing.Size(47, 23);
            this.btnDiffieHellman.TabIndex = 67;
            this.btnDiffieHellman.Text = "Back";
            this.btnDiffieHellman.UseVisualStyleBackColor = true;
            this.btnDiffieHellman.Click += new System.EventHandler(this.btnDiffieHellman_Click);
            // 
            // lblDescription0
            // 
            this.lblDescription0.AutoSize = true;
            this.lblDescription0.Location = new System.Drawing.Point(9, 58);
            this.lblDescription0.MaximumSize = new System.Drawing.Size(300, 0);
            this.lblDescription0.Name = "lblDescription0";
            this.lblDescription0.Size = new System.Drawing.Size(295, 26);
            this.lblDescription0.TabIndex = 68;
            this.lblDescription0.Text = "The Diffie-Hellman algorithm is used for key exchanging over long distances and i" +
    "n public chanels.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 94);
            this.label1.MaximumSize = new System.Drawing.Size(300, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 26);
            this.label1.TabIndex = 69;
            this.label1.Text = "To begin we first choose a prime number. From this prime number we also get the p" +
    "rimitive root.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 169);
            this.label2.MaximumSize = new System.Drawing.Size(300, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(296, 39);
            this.label2.TabIndex = 70;
            this.label2.Text = "Next we choose a number. We keep this number secret and use it to calculate numbe" +
    "rs to send to other parties as well as to calculate the secret key.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 249);
            this.label3.MaximumSize = new System.Drawing.Size(300, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(264, 26);
            this.label3.TabIndex = 71;
            this.label3.Text = "Lastly we input the other parties calculated secret and calculate our secret key." +
    "";
            // 
            // frmDiffieHellmanInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 321);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDescription0);
            this.Controls.Add(this.btnDiffieHellman);
            this.Name = "frmDiffieHellmanInfo";
            this.Text = "Diffie-Hellman cipher info";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmDiffieHellmanInfo_FormClosing);
            this.Load += new System.EventHandler(this.frmDiffieHellmanInfo_Load);
            this.Controls.SetChildIndex(this.cmbPrimeNumber, 0);
            this.Controls.SetChildIndex(this.lblPrimeNumber, 0);
            this.Controls.SetChildIndex(this.txtPrimitiveRoot, 0);
            this.Controls.SetChildIndex(this.lblPrimitiveRoot, 0);
            this.Controls.SetChildIndex(this.txtSecretNumber, 0);
            this.Controls.SetChildIndex(this.lblSecretNumber, 0);
            this.Controls.SetChildIndex(this.txtSecret, 0);
            this.Controls.SetChildIndex(this.txtOtherSecret, 0);
            this.Controls.SetChildIndex(this.lblSecret, 0);
            this.Controls.SetChildIndex(this.lblOtherSecret, 0);
            this.Controls.SetChildIndex(this.txtSharedSecret, 0);
            this.Controls.SetChildIndex(this.lblSharedSecret, 0);
            this.Controls.SetChildIndex(this.lblWarning, 0);
            this.Controls.SetChildIndex(this.btnDiffieHellman, 0);
            this.Controls.SetChildIndex(this.lblDescription0, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDiffieHellman;
        private System.Windows.Forms.Label lblDescription0;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}
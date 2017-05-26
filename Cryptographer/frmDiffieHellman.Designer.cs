namespace Cryptographer
{
    partial class frmDiffieHellman
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
            this.btnDiffieHellmanInfo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDiffieHellmanInfo
            // 
            this.btnDiffieHellmanInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiffieHellmanInfo.Location = new System.Drawing.Point(283, 12);
            this.btnDiffieHellmanInfo.Name = "btnDiffieHellmanInfo";
            this.btnDiffieHellmanInfo.Size = new System.Drawing.Size(22, 23);
            this.btnDiffieHellmanInfo.TabIndex = 66;
            this.btnDiffieHellmanInfo.Text = "?";
            this.btnDiffieHellmanInfo.UseVisualStyleBackColor = true;
            this.btnDiffieHellmanInfo.Click += new System.EventHandler(this.btnDiffieHellmanInfo_Click);
            // 
            // frmDiffieHellman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 221);
            this.Controls.Add(this.btnDiffieHellmanInfo);
            this.Name = "frmDiffieHellman";
            this.Text = "Diffie-Hellman cipher";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmDiffieHellman_FormClosing);
            this.Load += new System.EventHandler(this.frmDiffieHellman_Load);
            this.Controls.SetChildIndex(this.txtPrimeNumber, 0);
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
            this.Controls.SetChildIndex(this.btnDiffieHellmanInfo, 0);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDiffieHellmanInfo;
    }
}
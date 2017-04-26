namespace Cryptographer
{
    partial class frmDiffieHellmanBase
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
            this.lblWarning = new System.Windows.Forms.Label();
            this.lblSharedSecret = new System.Windows.Forms.Label();
            this.txtSharedSecret = new System.Windows.Forms.TextBox();
            this.lblOtherSecret = new System.Windows.Forms.Label();
            this.lblSecret = new System.Windows.Forms.Label();
            this.txtOtherSecret = new System.Windows.Forms.TextBox();
            this.txtSecret = new System.Windows.Forms.TextBox();
            this.lblSecretNumber = new System.Windows.Forms.Label();
            this.txtSecretNumber = new System.Windows.Forms.TextBox();
            this.lblPrimitiveRoot = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblPrimeNumber = new System.Windows.Forms.Label();
            this.txtPrimeNumber = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblWarning
            // 
            this.lblWarning.AutoSize = true;
            this.lblWarning.ForeColor = System.Drawing.Color.Red;
            this.lblWarning.Location = new System.Drawing.Point(24, 177);
            this.lblWarning.Name = "lblWarning";
            this.lblWarning.Size = new System.Drawing.Size(295, 26);
            this.lblWarning.TabIndex = 25;
            this.lblWarning.Text = "Do not expose your personal secret number or your shared \r\nsecret number. Doing o" +
    "therwise will make your key unsecure.";
            // 
            // lblSharedSecret
            // 
            this.lblSharedSecret.AutoSize = true;
            this.lblSharedSecret.Location = new System.Drawing.Point(211, 123);
            this.lblSharedSecret.Name = "lblSharedSecret";
            this.lblSharedSecret.Size = new System.Drawing.Size(109, 13);
            this.lblSharedSecret.TabIndex = 24;
            this.lblSharedSecret.Text = "Your shared secret is:";
            // 
            // txtSharedSecret
            // 
            this.txtSharedSecret.Location = new System.Drawing.Point(214, 139);
            this.txtSharedSecret.Name = "txtSharedSecret";
            this.txtSharedSecret.ReadOnly = true;
            this.txtSharedSecret.Size = new System.Drawing.Size(100, 20);
            this.txtSharedSecret.TabIndex = 18;
            // 
            // lblOtherSecret
            // 
            this.lblOtherSecret.AutoSize = true;
            this.lblOtherSecret.Location = new System.Drawing.Point(24, 123);
            this.lblOtherSecret.Name = "lblOtherSecret";
            this.lblOtherSecret.Size = new System.Drawing.Size(122, 13);
            this.lblOtherSecret.TabIndex = 23;
            this.lblOtherSecret.Text = "The other parties secret:";
            // 
            // lblSecret
            // 
            this.lblSecret.AutoSize = true;
            this.lblSecret.Location = new System.Drawing.Point(211, 71);
            this.lblSecret.Name = "lblSecret";
            this.lblSecret.Size = new System.Drawing.Size(74, 13);
            this.lblSecret.TabIndex = 22;
            this.lblSecret.Text = "Your secret is:";
            // 
            // txtOtherSecret
            // 
            this.txtOtherSecret.Location = new System.Drawing.Point(27, 139);
            this.txtOtherSecret.Name = "txtOtherSecret";
            this.txtOtherSecret.Size = new System.Drawing.Size(100, 20);
            this.txtOtherSecret.TabIndex = 17;
            // 
            // txtSecret
            // 
            this.txtSecret.Location = new System.Drawing.Point(214, 87);
            this.txtSecret.Name = "txtSecret";
            this.txtSecret.ReadOnly = true;
            this.txtSecret.Size = new System.Drawing.Size(100, 20);
            this.txtSecret.TabIndex = 16;
            // 
            // lblSecretNumber
            // 
            this.lblSecretNumber.AutoSize = true;
            this.lblSecretNumber.Location = new System.Drawing.Point(24, 71);
            this.lblSecretNumber.Name = "lblSecretNumber";
            this.lblSecretNumber.Size = new System.Drawing.Size(136, 13);
            this.lblSecretNumber.TabIndex = 21;
            this.lblSecretNumber.Text = "Choose your secret number";
            // 
            // txtSecretNumber
            // 
            this.txtSecretNumber.Location = new System.Drawing.Point(27, 87);
            this.txtSecretNumber.Name = "txtSecretNumber";
            this.txtSecretNumber.Size = new System.Drawing.Size(100, 20);
            this.txtSecretNumber.TabIndex = 15;
            // 
            // lblPrimitiveRoot
            // 
            this.lblPrimitiveRoot.AutoSize = true;
            this.lblPrimitiveRoot.Location = new System.Drawing.Point(211, 18);
            this.lblPrimitiveRoot.Name = "lblPrimitiveRoot";
            this.lblPrimitiveRoot.Size = new System.Drawing.Size(104, 13);
            this.lblPrimitiveRoot.TabIndex = 20;
            this.lblPrimitiveRoot.Text = "Your primitive root is:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(214, 34);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 14;
            // 
            // lblPrimeNumber
            // 
            this.lblPrimeNumber.AutoSize = true;
            this.lblPrimeNumber.Location = new System.Drawing.Point(24, 18);
            this.lblPrimeNumber.Name = "lblPrimeNumber";
            this.lblPrimeNumber.Size = new System.Drawing.Size(152, 13);
            this.lblPrimeNumber.TabIndex = 19;
            this.lblPrimeNumber.Text = "Choose a mutual prime number";
            // 
            // txtPrimeNumber
            // 
            this.txtPrimeNumber.Location = new System.Drawing.Point(27, 34);
            this.txtPrimeNumber.Name = "txtPrimeNumber";
            this.txtPrimeNumber.Size = new System.Drawing.Size(100, 20);
            this.txtPrimeNumber.TabIndex = 13;
            this.txtPrimeNumber.TextChanged += new System.EventHandler(this.txtPrimeNumber_TextChanged);
            // 
            // frmDiffieHellmanBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(344, 221);
            this.Controls.Add(this.lblWarning);
            this.Controls.Add(this.lblSharedSecret);
            this.Controls.Add(this.txtSharedSecret);
            this.Controls.Add(this.lblOtherSecret);
            this.Controls.Add(this.lblSecret);
            this.Controls.Add(this.txtOtherSecret);
            this.Controls.Add(this.txtSecret);
            this.Controls.Add(this.lblSecretNumber);
            this.Controls.Add(this.txtSecretNumber);
            this.Controls.Add(this.lblPrimitiveRoot);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblPrimeNumber);
            this.Controls.Add(this.txtPrimeNumber);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmDiffieHellmanBase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Cryptographer- Diffie-Hellman cipher";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWarning;
        private System.Windows.Forms.Label lblSharedSecret;
        private System.Windows.Forms.TextBox txtSharedSecret;
        private System.Windows.Forms.Label lblOtherSecret;
        private System.Windows.Forms.Label lblSecret;
        private System.Windows.Forms.TextBox txtOtherSecret;
        private System.Windows.Forms.TextBox txtSecret;
        private System.Windows.Forms.Label lblSecretNumber;
        private System.Windows.Forms.TextBox txtSecretNumber;
        private System.Windows.Forms.Label lblPrimitiveRoot;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblPrimeNumber;
        private System.Windows.Forms.TextBox txtPrimeNumber;
    }
}
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
            this.components = new System.ComponentModel.Container();
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
            this.txtPrimitiveRoot = new System.Windows.Forms.TextBox();
            this.lblPrimeNumber = new System.Windows.Forms.Label();
            this.txtPrimeNumber = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblWarning
            // 
            this.lblWarning.AutoSize = true;
            this.lblWarning.ForeColor = System.Drawing.Color.Red;
            this.lblWarning.Location = new System.Drawing.Point(9, 9);
            this.lblWarning.MaximumSize = new System.Drawing.Size(250, 0);
            this.lblWarning.Name = "lblWarning";
            this.lblWarning.Size = new System.Drawing.Size(242, 39);
            this.lblWarning.TabIndex = 25;
            this.lblWarning.Text = "Do not expose your secret number or your shared secret key. Doing otherwise will " +
    "make your key unsecure.";
            // 
            // lblSharedSecret
            // 
            this.lblSharedSecret.AutoSize = true;
            this.lblSharedSecret.Location = new System.Drawing.Point(196, 165);
            this.lblSharedSecret.Name = "lblSharedSecret";
            this.lblSharedSecret.Size = new System.Drawing.Size(97, 13);
            this.lblSharedSecret.TabIndex = 24;
            this.lblSharedSecret.Text = "Your shared key is:";
            // 
            // txtSharedSecret
            // 
            this.txtSharedSecret.Location = new System.Drawing.Point(199, 181);
            this.txtSharedSecret.Name = "txtSharedSecret";
            this.txtSharedSecret.ReadOnly = true;
            this.txtSharedSecret.Size = new System.Drawing.Size(100, 20);
            this.txtSharedSecret.TabIndex = 5;
            // 
            // lblOtherSecret
            // 
            this.lblOtherSecret.AutoSize = true;
            this.lblOtherSecret.Location = new System.Drawing.Point(9, 165);
            this.lblOtherSecret.Name = "lblOtherSecret";
            this.lblOtherSecret.Size = new System.Drawing.Size(128, 13);
            this.lblOtherSecret.TabIndex = 23;
            this.lblOtherSecret.Text = "The other parties number:";
            // 
            // lblSecret
            // 
            this.lblSecret.AutoSize = true;
            this.lblSecret.Location = new System.Drawing.Point(196, 113);
            this.lblSecret.Name = "lblSecret";
            this.lblSecret.Size = new System.Drawing.Size(80, 13);
            this.lblSecret.TabIndex = 22;
            this.lblSecret.Text = "Your number is:";
            // 
            // txtOtherSecret
            // 
            this.txtOtherSecret.Location = new System.Drawing.Point(12, 181);
            this.txtOtherSecret.Name = "txtOtherSecret";
            this.txtOtherSecret.Size = new System.Drawing.Size(100, 20);
            this.txtOtherSecret.TabIndex = 2;
            this.txtOtherSecret.TextChanged += new System.EventHandler(this.txtOtherSecret_TextChanged);
            // 
            // txtSecret
            // 
            this.txtSecret.Location = new System.Drawing.Point(199, 129);
            this.txtSecret.Name = "txtSecret";
            this.txtSecret.ReadOnly = true;
            this.txtSecret.Size = new System.Drawing.Size(100, 20);
            this.txtSecret.TabIndex = 4;
            this.txtSecret.TextChanged += new System.EventHandler(this.txtSecret_TextChanged);
            // 
            // lblSecretNumber
            // 
            this.lblSecretNumber.AutoSize = true;
            this.lblSecretNumber.Location = new System.Drawing.Point(9, 113);
            this.lblSecretNumber.Name = "lblSecretNumber";
            this.lblSecretNumber.Size = new System.Drawing.Size(136, 13);
            this.lblSecretNumber.TabIndex = 21;
            this.lblSecretNumber.Text = "Choose your secret number";
            // 
            // txtSecretNumber
            // 
            this.txtSecretNumber.Location = new System.Drawing.Point(12, 129);
            this.txtSecretNumber.Name = "txtSecretNumber";
            this.txtSecretNumber.Size = new System.Drawing.Size(100, 20);
            this.txtSecretNumber.TabIndex = 1;
            this.txtSecretNumber.TextChanged += new System.EventHandler(this.txtSecretNumber_TextChanged);
            // 
            // lblPrimitiveRoot
            // 
            this.lblPrimitiveRoot.AutoSize = true;
            this.lblPrimitiveRoot.Location = new System.Drawing.Point(196, 60);
            this.lblPrimitiveRoot.Name = "lblPrimitiveRoot";
            this.lblPrimitiveRoot.Size = new System.Drawing.Size(104, 13);
            this.lblPrimitiveRoot.TabIndex = 20;
            this.lblPrimitiveRoot.Text = "Your primitive root is:";
            // 
            // txtPrimitiveRoot
            // 
            this.txtPrimitiveRoot.Location = new System.Drawing.Point(199, 76);
            this.txtPrimitiveRoot.Name = "txtPrimitiveRoot";
            this.txtPrimitiveRoot.ReadOnly = true;
            this.txtPrimitiveRoot.Size = new System.Drawing.Size(100, 20);
            this.txtPrimitiveRoot.TabIndex = 3;
            this.txtPrimitiveRoot.TextChanged += new System.EventHandler(this.txtPrimitiveRoot_TextChanged);
            // 
            // lblPrimeNumber
            // 
            this.lblPrimeNumber.AutoSize = true;
            this.lblPrimeNumber.Location = new System.Drawing.Point(9, 60);
            this.lblPrimeNumber.Name = "lblPrimeNumber";
            this.lblPrimeNumber.Size = new System.Drawing.Size(152, 13);
            this.lblPrimeNumber.TabIndex = 19;
            this.lblPrimeNumber.Text = "Choose a mutual prime number";
            // 
            // txtPrimeNumber
            // 
            this.txtPrimeNumber.Location = new System.Drawing.Point(12, 76);
            this.txtPrimeNumber.Name = "txtPrimeNumber";
            this.txtPrimeNumber.Size = new System.Drawing.Size(100, 20);
            this.txtPrimeNumber.TabIndex = 0;
            this.txtPrimeNumber.TextChanged += new System.EventHandler(this.txtPrimeNumber_TextChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
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
            this.Controls.Add(this.txtPrimitiveRoot);
            this.Controls.Add(this.lblPrimeNumber);
            this.Controls.Add(this.txtPrimeNumber);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmDiffieHellmanBase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Cryptographer- Diffie-Hellman cipher";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.Label lblWarning;
        protected System.Windows.Forms.Label lblSharedSecret;
        protected System.Windows.Forms.TextBox txtSharedSecret;
        protected System.Windows.Forms.Label lblOtherSecret;
        protected System.Windows.Forms.Label lblSecret;
        protected System.Windows.Forms.TextBox txtOtherSecret;
        protected System.Windows.Forms.TextBox txtSecret;
        protected System.Windows.Forms.Label lblSecretNumber;
        protected System.Windows.Forms.TextBox txtSecretNumber;
        protected System.Windows.Forms.Label lblPrimitiveRoot;
        protected System.Windows.Forms.TextBox txtPrimitiveRoot;
        protected System.Windows.Forms.Label lblPrimeNumber;
        protected System.Windows.Forms.TextBox txtPrimeNumber;
        protected System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
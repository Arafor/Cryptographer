namespace Cryptographer
{
    partial class frmRSASignatureBase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRSASignatureBase));
            this.rdoBinary = new System.Windows.Forms.RadioButton();
            this.rdoHexadecimal = new System.Windows.Forms.RadioButton();
            this.grpDisplayVlaueMode = new System.Windows.Forms.GroupBox();
            this.btnCipher = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblKey = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.rdoBtnEncrypt = new System.Windows.Forms.RadioButton();
            this.rdoBtnDecrypt = new System.Windows.Forms.RadioButton();
            this.grpCipher = new System.Windows.Forms.GroupBox();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.grpDisplayVlaueMode.SuspendLayout();
            this.grpCipher.SuspendLayout();
            this.SuspendLayout();
            // 
            // rdoBinary
            // 
            this.rdoBinary.AutoSize = true;
            this.rdoBinary.Checked = true;
            this.rdoBinary.Location = new System.Drawing.Point(6, 19);
            this.rdoBinary.Name = "rdoBinary";
            this.rdoBinary.Size = new System.Drawing.Size(54, 17);
            this.rdoBinary.TabIndex = 6;
            this.rdoBinary.TabStop = true;
            this.rdoBinary.Text = "Binary";
            this.rdoBinary.UseVisualStyleBackColor = true;
            this.rdoBinary.CheckedChanged += new System.EventHandler(this.grpValueDisplayMode_CheckedChanged);
            // 
            // rdoHexadecimal
            // 
            this.rdoHexadecimal.AutoSize = true;
            this.rdoHexadecimal.Location = new System.Drawing.Point(6, 42);
            this.rdoHexadecimal.Name = "rdoHexadecimal";
            this.rdoHexadecimal.Size = new System.Drawing.Size(86, 17);
            this.rdoHexadecimal.TabIndex = 7;
            this.rdoHexadecimal.Text = "Hexadecimal";
            this.rdoHexadecimal.UseVisualStyleBackColor = true;
            // 
            // grpDisplayVlaueMode
            // 
            this.grpDisplayVlaueMode.Controls.Add(this.rdoBinary);
            this.grpDisplayVlaueMode.Controls.Add(this.rdoHexadecimal);
            this.grpDisplayVlaueMode.Location = new System.Drawing.Point(12, 12);
            this.grpDisplayVlaueMode.Name = "grpDisplayVlaueMode";
            this.grpDisplayVlaueMode.Size = new System.Drawing.Size(161, 71);
            this.grpDisplayVlaueMode.TabIndex = 67;
            this.grpDisplayVlaueMode.TabStop = false;
            this.grpDisplayVlaueMode.Text = "Choose how to display values";
            // 
            // btnCipher
            // 
            this.btnCipher.Location = new System.Drawing.Point(379, 346);
            this.btnCipher.Name = "btnCipher";
            this.btnCipher.Size = new System.Drawing.Size(75, 23);
            this.btnCipher.TabIndex = 65;
            this.btnCipher.Text = "Start";
            this.btnCipher.UseVisualStyleBackColor = true;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(12, 370);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(37, 13);
            this.lblResult.TabIndex = 71;
            this.lblResult.Text = "Result";
            // 
            // lblKey
            // 
            this.lblKey.AutoSize = true;
            this.lblKey.Location = new System.Drawing.Point(12, 240);
            this.lblKey.Name = "lblKey";
            this.lblKey.Size = new System.Drawing.Size(25, 13);
            this.lblKey.TabIndex = 70;
            this.lblKey.Text = "Key";
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(12, 91);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(50, 13);
            this.lblMessage.TabIndex = 69;
            this.lblMessage.Text = "Message";
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(12, 386);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResult.Size = new System.Drawing.Size(455, 120);
            this.txtResult.TabIndex = 66;
            // 
            // rdoBtnEncrypt
            // 
            this.rdoBtnEncrypt.AutoSize = true;
            this.rdoBtnEncrypt.Location = new System.Drawing.Point(6, 19);
            this.rdoBtnEncrypt.Name = "rdoBtnEncrypt";
            this.rdoBtnEncrypt.Size = new System.Drawing.Size(61, 17);
            this.rdoBtnEncrypt.TabIndex = 8;
            this.rdoBtnEncrypt.Text = "Encrypt";
            this.rdoBtnEncrypt.UseVisualStyleBackColor = true;
            // 
            // rdoBtnDecrypt
            // 
            this.rdoBtnDecrypt.AutoSize = true;
            this.rdoBtnDecrypt.Location = new System.Drawing.Point(6, 42);
            this.rdoBtnDecrypt.Name = "rdoBtnDecrypt";
            this.rdoBtnDecrypt.Size = new System.Drawing.Size(62, 17);
            this.rdoBtnDecrypt.TabIndex = 9;
            this.rdoBtnDecrypt.Text = "Decrypt";
            this.rdoBtnDecrypt.UseVisualStyleBackColor = true;
            // 
            // grpCipher
            // 
            this.grpCipher.Controls.Add(this.rdoBtnEncrypt);
            this.grpCipher.Controls.Add(this.rdoBtnDecrypt);
            this.grpCipher.Location = new System.Drawing.Point(373, 256);
            this.grpCipher.Name = "grpCipher";
            this.grpCipher.Size = new System.Drawing.Size(97, 71);
            this.grpCipher.TabIndex = 68;
            this.grpCipher.TabStop = false;
            this.grpCipher.Text = "Cipher";
            // 
            // txtKey
            // 
            this.txtKey.Location = new System.Drawing.Point(12, 256);
            this.txtKey.Multiline = true;
            this.txtKey.Name = "txtKey";
            this.txtKey.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtKey.Size = new System.Drawing.Size(352, 100);
            this.txtKey.TabIndex = 64;
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(12, 107);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMessage.Size = new System.Drawing.Size(455, 120);
            this.txtMessage.TabIndex = 63;
            // 
            // frmRSASignatureBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(484, 561);
            this.Controls.Add(this.grpDisplayVlaueMode);
            this.Controls.Add(this.btnCipher);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblKey);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.grpCipher);
            this.Controls.Add(this.txtKey);
            this.Controls.Add(this.txtMessage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmRSASignatureBase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Cryptographer- RSA signature base form";
            this.grpDisplayVlaueMode.ResumeLayout(false);
            this.grpDisplayVlaueMode.PerformLayout();
            this.grpCipher.ResumeLayout(false);
            this.grpCipher.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.RadioButton rdoBinary;
        protected System.Windows.Forms.RadioButton rdoHexadecimal;
        protected System.Windows.Forms.GroupBox grpDisplayVlaueMode;
        protected System.Windows.Forms.Button btnCipher;
        protected System.Windows.Forms.Label lblResult;
        protected System.Windows.Forms.Label lblKey;
        protected System.Windows.Forms.Label lblMessage;
        protected System.Windows.Forms.TextBox txtResult;
        protected System.Windows.Forms.RadioButton rdoBtnEncrypt;
        protected System.Windows.Forms.RadioButton rdoBtnDecrypt;
        protected System.Windows.Forms.GroupBox grpCipher;
        protected System.Windows.Forms.TextBox txtKey;
        protected System.Windows.Forms.TextBox txtMessage;
    }
}
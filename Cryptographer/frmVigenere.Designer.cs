namespace Cryptographer
{
    partial class frmVigenere
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
            this.lblResult = new System.Windows.Forms.Label();
            this.lblKey = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.btnSaveToClipboard = new System.Windows.Forms.Button();
            this.btnVigenereInfo = new System.Windows.Forms.Button();
            this.btnCipher = new System.Windows.Forms.Button();
            this.grpCipher = new System.Windows.Forms.GroupBox();
            this.rdoBtnEncrypt = new System.Windows.Forms.RadioButton();
            this.rdoBtnDecrypt = new System.Windows.Forms.RadioButton();
            this.grpCipher.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(12, 299);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(37, 13);
            this.lblResult.TabIndex = 13;
            this.lblResult.Text = "Result";
            // 
            // lblKey
            // 
            this.lblKey.AutoSize = true;
            this.lblKey.Location = new System.Drawing.Point(12, 163);
            this.lblKey.Name = "lblKey";
            this.lblKey.Size = new System.Drawing.Size(25, 13);
            this.lblKey.TabIndex = 12;
            this.lblKey.Text = "Key";
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(12, 18);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(50, 13);
            this.lblMessage.TabIndex = 11;
            this.lblMessage.Text = "Message";
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(12, 315);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResult.Size = new System.Drawing.Size(455, 120);
            this.txtResult.TabIndex = 5;
            // 
            // txtKey
            // 
            this.txtKey.Location = new System.Drawing.Point(12, 179);
            this.txtKey.Multiline = true;
            this.txtKey.Name = "txtKey";
            this.txtKey.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtKey.Size = new System.Drawing.Size(352, 100);
            this.txtKey.TabIndex = 2;
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(12, 34);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMessage.Size = new System.Drawing.Size(455, 120);
            this.txtMessage.TabIndex = 1;
            // 
            // btnSaveToClipboard
            // 
            this.btnSaveToClipboard.Image = global::Cryptographer.Properties.Resources.Editing_Clipboard_icon30;
            this.btnSaveToClipboard.Location = new System.Drawing.Point(427, 269);
            this.btnSaveToClipboard.Name = "btnSaveToClipboard";
            this.btnSaveToClipboard.Size = new System.Drawing.Size(40, 40);
            this.btnSaveToClipboard.TabIndex = 28;
            this.btnSaveToClipboard.UseVisualStyleBackColor = true;
            this.btnSaveToClipboard.Click += new System.EventHandler(this.btnSaveToClipboard_Click);
            // 
            // btnVigenereInfo
            // 
            this.btnVigenereInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVigenereInfo.Location = new System.Drawing.Point(445, 5);
            this.btnVigenereInfo.Name = "btnVigenereInfo";
            this.btnVigenereInfo.Size = new System.Drawing.Size(22, 23);
            this.btnVigenereInfo.TabIndex = 29;
            this.btnVigenereInfo.Text = "i";
            this.btnVigenereInfo.UseVisualStyleBackColor = true;
            this.btnVigenereInfo.Click += new System.EventHandler(this.btnVigenereInfo_Click);
            // 
            // btnCipher
            // 
            this.btnCipher.Location = new System.Drawing.Point(395, 240);
            this.btnCipher.Name = "btnCipher";
            this.btnCipher.Size = new System.Drawing.Size(75, 23);
            this.btnCipher.TabIndex = 33;
            this.btnCipher.Text = "Cipher";
            this.btnCipher.UseVisualStyleBackColor = true;
            this.btnCipher.Click += new System.EventHandler(this.btnCipher_Click);
            // 
            // grpCipher
            // 
            this.grpCipher.Controls.Add(this.rdoBtnEncrypt);
            this.grpCipher.Controls.Add(this.rdoBtnDecrypt);
            this.grpCipher.Location = new System.Drawing.Point(370, 163);
            this.grpCipher.Name = "grpCipher";
            this.grpCipher.Size = new System.Drawing.Size(97, 71);
            this.grpCipher.TabIndex = 32;
            this.grpCipher.TabStop = false;
            this.grpCipher.Text = "Cipher";
            // 
            // rdoBtnEncrypt
            // 
            this.rdoBtnEncrypt.AutoSize = true;
            this.rdoBtnEncrypt.Location = new System.Drawing.Point(6, 19);
            this.rdoBtnEncrypt.Name = "rdoBtnEncrypt";
            this.rdoBtnEncrypt.Size = new System.Drawing.Size(61, 17);
            this.rdoBtnEncrypt.TabIndex = 26;
            this.rdoBtnEncrypt.Text = "Encrypt";
            this.rdoBtnEncrypt.UseVisualStyleBackColor = true;
            this.rdoBtnEncrypt.CheckedChanged += new System.EventHandler(this.cipherRadioButtonChanged);
            // 
            // rdoBtnDecrypt
            // 
            this.rdoBtnDecrypt.AutoSize = true;
            this.rdoBtnDecrypt.Location = new System.Drawing.Point(6, 42);
            this.rdoBtnDecrypt.Name = "rdoBtnDecrypt";
            this.rdoBtnDecrypt.Size = new System.Drawing.Size(62, 17);
            this.rdoBtnDecrypt.TabIndex = 27;
            this.rdoBtnDecrypt.Text = "Decrypt";
            this.rdoBtnDecrypt.UseVisualStyleBackColor = true;
            this.rdoBtnDecrypt.CheckedChanged += new System.EventHandler(this.cipherRadioButtonChanged);
            // 
            // frmVigenere
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(484, 451);
            this.Controls.Add(this.btnCipher);
            this.Controls.Add(this.grpCipher);
            this.Controls.Add(this.btnVigenereInfo);
            this.Controls.Add(this.btnSaveToClipboard);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblKey);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.txtKey);
            this.Controls.Add(this.txtMessage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmVigenere";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Cryptographer - Vigenere cipher";
            this.Load += new System.EventHandler(this.frmVigenere_Load);
            this.grpCipher.ResumeLayout(false);
            this.grpCipher.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblKey;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Button btnSaveToClipboard;
        private System.Windows.Forms.Button btnVigenereInfo;
        private System.Windows.Forms.Button btnCipher;
        private System.Windows.Forms.GroupBox grpCipher;
        private System.Windows.Forms.RadioButton rdoBtnEncrypt;
        private System.Windows.Forms.RadioButton rdoBtnDecrypt;
    }
}
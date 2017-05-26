namespace Cryptographer
{
    partial class frmAESInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAESInfo));
            this.btnSaveToClipboard = new System.Windows.Forms.Button();
            this.btnAES = new System.Windows.Forms.Button();
            this.lblDescription2 = new System.Windows.Forms.Label();
            this.lblDescription1 = new System.Windows.Forms.Label();
            this.lblDescription0 = new System.Windows.Forms.Label();
            this.lblDescription3 = new System.Windows.Forms.Label();
            this.lblDescription6 = new System.Windows.Forms.Label();
            this.lblDescription5 = new System.Windows.Forms.Label();
            this.lblDescription4 = new System.Windows.Forms.Label();
            this.lblDescription8 = new System.Windows.Forms.Label();
            this.lblDescription7 = new System.Windows.Forms.Label();
            this.lblDescription9 = new System.Windows.Forms.Label();
            this.grpDisplayVlaueMode.SuspendLayout();
            this.grpMode.SuspendLayout();
            this.grpCipher.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblIV
            // 
            this.lblIV.Location = new System.Drawing.Point(12, 719);
            // 
            // grpDisplayVlaueMode
            // 
            this.grpDisplayVlaueMode.Location = new System.Drawing.Point(12, 135);
            // 
            // txtIV
            // 
            this.txtIV.Location = new System.Drawing.Point(12, 735);
            // 
            // grpMode
            // 
            this.grpMode.Location = new System.Drawing.Point(373, 735);
            // 
            // btnCipher
            // 
            this.btnCipher.Location = new System.Drawing.Point(379, 828);
            this.btnCipher.Click += new System.EventHandler(this.btnCipher_Click);
            // 
            // lblResult
            // 
            this.lblResult.Location = new System.Drawing.Point(12, 882);
            // 
            // lblKey
            // 
            this.lblKey.Location = new System.Drawing.Point(15, 471);
            // 
            // lblMessage
            // 
            this.lblMessage.Location = new System.Drawing.Point(15, 238);
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(12, 898);
            // 
            // rdoBtnEncrypt
            // 
            this.rdoBtnEncrypt.CheckedChanged += new System.EventHandler(this.cipherRadioButtonChanged);
            // 
            // rdoBtnDecrypt
            // 
            this.rdoBtnDecrypt.CheckedChanged += new System.EventHandler(this.cipherRadioButtonChanged);
            // 
            // grpCipher
            // 
            this.grpCipher.Location = new System.Drawing.Point(376, 487);
            // 
            // txtKey
            // 
            this.txtKey.Location = new System.Drawing.Point(15, 487);
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(15, 254);
            // 
            // btnSaveToClipboard
            // 
            this.btnSaveToClipboard.Image = global::Cryptographer.Properties.Resources.Editing_Clipboard_icon30;
            this.btnSaveToClipboard.Location = new System.Drawing.Point(432, 1024);
            this.btnSaveToClipboard.Name = "btnSaveToClipboard";
            this.btnSaveToClipboard.Size = new System.Drawing.Size(40, 40);
            this.btnSaveToClipboard.TabIndex = 64;
            this.btnSaveToClipboard.UseVisualStyleBackColor = true;
            this.btnSaveToClipboard.Click += new System.EventHandler(this.btnSaveToClipboard_Click);
            // 
            // btnAES
            // 
            this.btnAES.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAES.Location = new System.Drawing.Point(425, 12);
            this.btnAES.Name = "btnAES";
            this.btnAES.Size = new System.Drawing.Size(47, 23);
            this.btnAES.TabIndex = 66;
            this.btnAES.Text = "Back";
            this.btnAES.UseVisualStyleBackColor = true;
            this.btnAES.Click += new System.EventHandler(this.btnAES_Click);
            // 
            // lblDescription2
            // 
            this.lblDescription2.AutoSize = true;
            this.lblDescription2.Location = new System.Drawing.Point(12, 80);
            this.lblDescription2.MaximumSize = new System.Drawing.Size(390, 0);
            this.lblDescription2.Name = "lblDescription2";
            this.lblDescription2.Size = new System.Drawing.Size(389, 52);
            this.lblDescription2.TabIndex = 69;
            this.lblDescription2.Text = resources.GetString("lblDescription2.Text");
            // 
            // lblDescription1
            // 
            this.lblDescription1.AutoSize = true;
            this.lblDescription1.Location = new System.Drawing.Point(12, 44);
            this.lblDescription1.MaximumSize = new System.Drawing.Size(390, 0);
            this.lblDescription1.Name = "lblDescription1";
            this.lblDescription1.Size = new System.Drawing.Size(372, 26);
            this.lblDescription1.TabIndex = 68;
            this.lblDescription1.Text = "AES is also a symmetric algorithm. Meaning that the same key is used to both encr" +
    "ypt and decrypt the message.";
            // 
            // lblDescription0
            // 
            this.lblDescription0.AutoSize = true;
            this.lblDescription0.Location = new System.Drawing.Point(12, 9);
            this.lblDescription0.MaximumSize = new System.Drawing.Size(390, 0);
            this.lblDescription0.Name = "lblDescription0";
            this.lblDescription0.Size = new System.Drawing.Size(388, 26);
            this.lblDescription0.TabIndex = 67;
            this.lblDescription0.Text = "AES is a block cipher. Meaning that the message is devided into multiple blocks. " +
    "In AES each block of our message is 128 bits in length.";
            // 
            // lblDescription3
            // 
            this.lblDescription3.AutoSize = true;
            this.lblDescription3.Location = new System.Drawing.Point(15, 209);
            this.lblDescription3.MaximumSize = new System.Drawing.Size(390, 0);
            this.lblDescription3.Name = "lblDescription3";
            this.lblDescription3.Size = new System.Drawing.Size(370, 26);
            this.lblDescription3.TabIndex = 70;
            this.lblDescription3.Text = "Next we should choose a message. This would be our plaintext if we want to encryp" +
    "t or our ciphertext if we wish to decrypt.\r\n";
            // 
            // lblDescription6
            // 
            this.lblDescription6.AutoSize = true;
            this.lblDescription6.Location = new System.Drawing.Point(374, 411);
            this.lblDescription6.MaximumSize = new System.Drawing.Size(97, 0);
            this.lblDescription6.Name = "lblDescription6";
            this.lblDescription6.Size = new System.Drawing.Size(97, 65);
            this.lblDescription6.TabIndex = 73;
            this.lblDescription6.Text = "We also need to specify whether we want to encrypt or decrypt our message.";
            // 
            // lblDescription5
            // 
            this.lblDescription5.AutoSize = true;
            this.lblDescription5.Location = new System.Drawing.Point(17, 411);
            this.lblDescription5.MaximumSize = new System.Drawing.Size(352, 0);
            this.lblDescription5.Name = "lblDescription5";
            this.lblDescription5.Size = new System.Drawing.Size(352, 52);
            this.lblDescription5.TabIndex = 72;
            this.lblDescription5.Text = resources.GetString("lblDescription5.Text");
            // 
            // lblDescription4
            // 
            this.lblDescription4.AutoSize = true;
            this.lblDescription4.Location = new System.Drawing.Point(15, 377);
            this.lblDescription4.MaximumSize = new System.Drawing.Size(390, 0);
            this.lblDescription4.Name = "lblDescription4";
            this.lblDescription4.Size = new System.Drawing.Size(388, 26);
            this.lblDescription4.TabIndex = 71;
            this.lblDescription4.Text = "Next we need a key. AES uses a 128-bit, 192-bit or a  256-bit key for encryption." +
    " In this example we use a 256-bit key.";
            // 
            // lblDescription8
            // 
            this.lblDescription8.AutoSize = true;
            this.lblDescription8.Location = new System.Drawing.Point(12, 660);
            this.lblDescription8.MaximumSize = new System.Drawing.Size(450, 0);
            this.lblDescription8.Name = "lblDescription8";
            this.lblDescription8.Size = new System.Drawing.Size(448, 52);
            this.lblDescription8.TabIndex = 75;
            this.lblDescription8.Text = resources.GetString("lblDescription8.Text");
            // 
            // lblDescription7
            // 
            this.lblDescription7.AutoSize = true;
            this.lblDescription7.Location = new System.Drawing.Point(12, 599);
            this.lblDescription7.MaximumSize = new System.Drawing.Size(450, 0);
            this.lblDescription7.Name = "lblDescription7";
            this.lblDescription7.Size = new System.Drawing.Size(448, 52);
            this.lblDescription7.TabIndex = 74;
            this.lblDescription7.Text = resources.GetString("lblDescription7.Text");
            // 
            // lblDescription9
            // 
            this.lblDescription9.AutoSize = true;
            this.lblDescription9.Location = new System.Drawing.Point(9, 849);
            this.lblDescription9.MaximumSize = new System.Drawing.Size(400, 0);
            this.lblDescription9.Name = "lblDescription9";
            this.lblDescription9.Size = new System.Drawing.Size(365, 26);
            this.lblDescription9.TabIndex = 76;
            this.lblDescription9.Text = "Now that everything is finally set up we can start enrypting or decrypting our me" +
    "ssage.";
            // 
            // frmAESInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 741);
            this.Controls.Add(this.lblDescription9);
            this.Controls.Add(this.lblDescription8);
            this.Controls.Add(this.lblDescription7);
            this.Controls.Add(this.lblDescription6);
            this.Controls.Add(this.lblDescription5);
            this.Controls.Add(this.lblDescription4);
            this.Controls.Add(this.lblDescription3);
            this.Controls.Add(this.lblDescription2);
            this.Controls.Add(this.lblDescription1);
            this.Controls.Add(this.lblDescription0);
            this.Controls.Add(this.btnAES);
            this.Controls.Add(this.btnSaveToClipboard);
            this.Name = "frmAESInfo";
            this.Text = "AES cipher info ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAESInfo_FormClosing);
            this.Load += new System.EventHandler(this.frmAESInfo_Load);
            this.Controls.SetChildIndex(this.txtMessage, 0);
            this.Controls.SetChildIndex(this.txtKey, 0);
            this.Controls.SetChildIndex(this.grpCipher, 0);
            this.Controls.SetChildIndex(this.txtResult, 0);
            this.Controls.SetChildIndex(this.lblMessage, 0);
            this.Controls.SetChildIndex(this.lblKey, 0);
            this.Controls.SetChildIndex(this.lblResult, 0);
            this.Controls.SetChildIndex(this.btnCipher, 0);
            this.Controls.SetChildIndex(this.grpMode, 0);
            this.Controls.SetChildIndex(this.txtIV, 0);
            this.Controls.SetChildIndex(this.grpDisplayVlaueMode, 0);
            this.Controls.SetChildIndex(this.lblIV, 0);
            this.Controls.SetChildIndex(this.btnSaveToClipboard, 0);
            this.Controls.SetChildIndex(this.btnAES, 0);
            this.Controls.SetChildIndex(this.lblDescription0, 0);
            this.Controls.SetChildIndex(this.lblDescription1, 0);
            this.Controls.SetChildIndex(this.lblDescription2, 0);
            this.Controls.SetChildIndex(this.lblDescription3, 0);
            this.Controls.SetChildIndex(this.lblDescription4, 0);
            this.Controls.SetChildIndex(this.lblDescription5, 0);
            this.Controls.SetChildIndex(this.lblDescription6, 0);
            this.Controls.SetChildIndex(this.lblDescription7, 0);
            this.Controls.SetChildIndex(this.lblDescription8, 0);
            this.Controls.SetChildIndex(this.lblDescription9, 0);
            this.grpDisplayVlaueMode.ResumeLayout(false);
            this.grpDisplayVlaueMode.PerformLayout();
            this.grpMode.ResumeLayout(false);
            this.grpMode.PerformLayout();
            this.grpCipher.ResumeLayout(false);
            this.grpCipher.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSaveToClipboard;
        private System.Windows.Forms.Button btnAES;
        private System.Windows.Forms.Label lblDescription2;
        private System.Windows.Forms.Label lblDescription1;
        private System.Windows.Forms.Label lblDescription0;
        private System.Windows.Forms.Label lblDescription3;
        private System.Windows.Forms.Label lblDescription6;
        private System.Windows.Forms.Label lblDescription5;
        private System.Windows.Forms.Label lblDescription4;
        private System.Windows.Forms.Label lblDescription8;
        private System.Windows.Forms.Label lblDescription7;
        private System.Windows.Forms.Label lblDescription9;
    }
}
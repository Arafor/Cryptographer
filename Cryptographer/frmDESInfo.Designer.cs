namespace Cryptographer
{
    partial class frmDESInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDESInfo));
            this.btnDES = new System.Windows.Forms.Button();
            this.btnSaveToClipboard = new System.Windows.Forms.Button();
            this.lblDescription0 = new System.Windows.Forms.Label();
            this.lblDescription1 = new System.Windows.Forms.Label();
            this.lblDescription2 = new System.Windows.Forms.Label();
            this.lblDescription3 = new System.Windows.Forms.Label();
            this.lblDescription4 = new System.Windows.Forms.Label();
            this.lblDescription5 = new System.Windows.Forms.Label();
            this.lblDescription6 = new System.Windows.Forms.Label();
            this.lblDescription7 = new System.Windows.Forms.Label();
            this.lblDescription8 = new System.Windows.Forms.Label();
            this.lblDescription9 = new System.Windows.Forms.Label();
            this.grpCipher.SuspendLayout();
            this.grpMode.SuspendLayout();
            this.grpDisplayVlaueMode.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCipher
            // 
            this.btnCipher.Location = new System.Drawing.Point(379, 873);
            this.btnCipher.Click += new System.EventHandler(this.btnCipher_Click);
            // 
            // grpCipher
            // 
            this.grpCipher.Location = new System.Drawing.Point(367, 519);
            // 
            // rdoBtnEncrypt
            // 
            this.rdoBtnEncrypt.CheckedChanged += new System.EventHandler(this.cipherRadioButtonChanged);
            // 
            // rdoBtnDecrypt
            // 
            this.rdoBtnDecrypt.CheckedChanged += new System.EventHandler(this.cipherRadioButtonChanged);
            // 
            // lblResult
            // 
            this.lblResult.Location = new System.Drawing.Point(9, 904);
            // 
            // lblKey
            // 
            this.lblKey.Location = new System.Drawing.Point(9, 503);
            // 
            // lblMessage
            // 
            this.lblMessage.Location = new System.Drawing.Point(9, 252);
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(9, 920);
            // 
            // txtKey
            // 
            this.txtKey.Location = new System.Drawing.Point(9, 519);
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(9, 268);
            // 
            // grpMode
            // 
            this.grpMode.Location = new System.Drawing.Point(373, 770);
            // 
            // grpDisplayVlaueMode
            // 
            this.grpDisplayVlaueMode.Location = new System.Drawing.Point(9, 144);
            // 
            // txtIV
            // 
            this.txtIV.Location = new System.Drawing.Point(9, 770);
            // 
            // lblIV
            // 
            this.lblIV.Location = new System.Drawing.Point(9, 754);
            // 
            // btnDES
            // 
            this.btnDES.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDES.Location = new System.Drawing.Point(425, 12);
            this.btnDES.Name = "btnDES";
            this.btnDES.Size = new System.Drawing.Size(47, 23);
            this.btnDES.TabIndex = 52;
            this.btnDES.Text = "Back";
            this.btnDES.UseVisualStyleBackColor = true;
            this.btnDES.Click += new System.EventHandler(this.btnDES_Click);
            // 
            // btnSaveToClipboard
            // 
            this.btnSaveToClipboard.Image = global::Cryptographer.Properties.Resources.Editing_Clipboard_icon30;
            this.btnSaveToClipboard.Location = new System.Drawing.Point(424, 1046);
            this.btnSaveToClipboard.Name = "btnSaveToClipboard";
            this.btnSaveToClipboard.Size = new System.Drawing.Size(40, 40);
            this.btnSaveToClipboard.TabIndex = 8;
            this.btnSaveToClipboard.UseVisualStyleBackColor = true;
            this.btnSaveToClipboard.Click += new System.EventHandler(this.btnSaveToClipboard_Click);
            // 
            // lblDescription0
            // 
            this.lblDescription0.AutoSize = true;
            this.lblDescription0.Location = new System.Drawing.Point(6, 9);
            this.lblDescription0.MaximumSize = new System.Drawing.Size(390, 0);
            this.lblDescription0.Name = "lblDescription0";
            this.lblDescription0.Size = new System.Drawing.Size(389, 26);
            this.lblDescription0.TabIndex = 53;
            this.lblDescription0.Text = "DES is a block cipher. Meaning that the message is devided into multiple blocks. " +
    "In DES each block of our message is 64 bits in length.\r\n";
            // 
            // lblDescription1
            // 
            this.lblDescription1.AutoSize = true;
            this.lblDescription1.Location = new System.Drawing.Point(6, 44);
            this.lblDescription1.MaximumSize = new System.Drawing.Size(390, 0);
            this.lblDescription1.Name = "lblDescription1";
            this.lblDescription1.Size = new System.Drawing.Size(373, 26);
            this.lblDescription1.TabIndex = 54;
            this.lblDescription1.Text = "DES is also a symmetric algorithm. Meaning that the same key is used to both encr" +
    "ypt and decrypt the message.\r\n";
            // 
            // lblDescription2
            // 
            this.lblDescription2.AutoSize = true;
            this.lblDescription2.Location = new System.Drawing.Point(6, 80);
            this.lblDescription2.MaximumSize = new System.Drawing.Size(390, 0);
            this.lblDescription2.Name = "lblDescription2";
            this.lblDescription2.Size = new System.Drawing.Size(390, 52);
            this.lblDescription2.TabIndex = 55;
            this.lblDescription2.Text = resources.GetString("lblDescription2.Text");
            // 
            // lblDescription3
            // 
            this.lblDescription3.AutoSize = true;
            this.lblDescription3.Location = new System.Drawing.Point(6, 218);
            this.lblDescription3.MaximumSize = new System.Drawing.Size(390, 0);
            this.lblDescription3.Name = "lblDescription3";
            this.lblDescription3.Size = new System.Drawing.Size(371, 26);
            this.lblDescription3.TabIndex = 56;
            this.lblDescription3.Text = "Next we should choose a message. This would be our Plaintext if we want to encryp" +
    "t or our Ciphertext if we wish to decrypt.\r\n";
            // 
            // lblDescription4
            // 
            this.lblDescription4.AutoSize = true;
            this.lblDescription4.Location = new System.Drawing.Point(6, 391);
            this.lblDescription4.MaximumSize = new System.Drawing.Size(390, 0);
            this.lblDescription4.Name = "lblDescription4";
            this.lblDescription4.Size = new System.Drawing.Size(375, 39);
            this.lblDescription4.TabIndex = 57;
            this.lblDescription4.Text = resources.GetString("lblDescription4.Text");
            // 
            // lblDescription5
            // 
            this.lblDescription5.AutoSize = true;
            this.lblDescription5.Location = new System.Drawing.Point(6, 441);
            this.lblDescription5.MaximumSize = new System.Drawing.Size(352, 0);
            this.lblDescription5.Name = "lblDescription5";
            this.lblDescription5.Size = new System.Drawing.Size(352, 52);
            this.lblDescription5.TabIndex = 58;
            this.lblDescription5.Text = resources.GetString("lblDescription5.Text");
            // 
            // lblDescription6
            // 
            this.lblDescription6.AutoSize = true;
            this.lblDescription6.Location = new System.Drawing.Point(363, 441);
            this.lblDescription6.MaximumSize = new System.Drawing.Size(97, 0);
            this.lblDescription6.Name = "lblDescription6";
            this.lblDescription6.Size = new System.Drawing.Size(97, 65);
            this.lblDescription6.TabIndex = 59;
            this.lblDescription6.Text = "We also need to specify whether we want to encrypt or decrypt our message.";
            // 
            // lblDescription7
            // 
            this.lblDescription7.AutoSize = true;
            this.lblDescription7.Location = new System.Drawing.Point(6, 631);
            this.lblDescription7.MaximumSize = new System.Drawing.Size(450, 0);
            this.lblDescription7.Name = "lblDescription7";
            this.lblDescription7.Size = new System.Drawing.Size(448, 52);
            this.lblDescription7.TabIndex = 60;
            this.lblDescription7.Text = resources.GetString("lblDescription7.Text");
            // 
            // lblDescription8
            // 
            this.lblDescription8.AutoSize = true;
            this.lblDescription8.Location = new System.Drawing.Point(6, 692);
            this.lblDescription8.MaximumSize = new System.Drawing.Size(450, 0);
            this.lblDescription8.Name = "lblDescription8";
            this.lblDescription8.Size = new System.Drawing.Size(448, 52);
            this.lblDescription8.TabIndex = 61;
            this.lblDescription8.Text = resources.GetString("lblDescription8.Text");
            // 
            // lblDescription9
            // 
            this.lblDescription9.AutoSize = true;
            this.lblDescription9.Location = new System.Drawing.Point(6, 873);
            this.lblDescription9.MaximumSize = new System.Drawing.Size(400, 0);
            this.lblDescription9.Name = "lblDescription9";
            this.lblDescription9.Size = new System.Drawing.Size(365, 26);
            this.lblDescription9.TabIndex = 62;
            this.lblDescription9.Text = "Now that everything is finally set up we can start enrypting or decrypting our me" +
    "ssage.";
            // 
            // frmDESInfo
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
            this.Controls.Add(this.btnSaveToClipboard);
            this.Controls.Add(this.btnDES);
            this.Name = "frmDESInfo";
            this.Text = "Cryptographer- DES info cipher ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmDESInfo_FormClosing);
            this.Load += new System.EventHandler(this.frmDESInfo_Load);
            this.Controls.SetChildIndex(this.btnDES, 0);
            this.Controls.SetChildIndex(this.txtMessage, 0);
            this.Controls.SetChildIndex(this.txtKey, 0);
            this.Controls.SetChildIndex(this.txtResult, 0);
            this.Controls.SetChildIndex(this.lblMessage, 0);
            this.Controls.SetChildIndex(this.lblKey, 0);
            this.Controls.SetChildIndex(this.lblResult, 0);
            this.Controls.SetChildIndex(this.grpCipher, 0);
            this.Controls.SetChildIndex(this.btnCipher, 0);
            this.Controls.SetChildIndex(this.grpMode, 0);
            this.Controls.SetChildIndex(this.grpDisplayVlaueMode, 0);
            this.Controls.SetChildIndex(this.txtIV, 0);
            this.Controls.SetChildIndex(this.lblIV, 0);
            this.Controls.SetChildIndex(this.btnSaveToClipboard, 0);
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
            this.grpCipher.ResumeLayout(false);
            this.grpCipher.PerformLayout();
            this.grpMode.ResumeLayout(false);
            this.grpMode.PerformLayout();
            this.grpDisplayVlaueMode.ResumeLayout(false);
            this.grpDisplayVlaueMode.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDES;
        private System.Windows.Forms.Button btnSaveToClipboard;
        private System.Windows.Forms.Label lblDescription0;
        private System.Windows.Forms.Label lblDescription1;
        private System.Windows.Forms.Label lblDescription2;
        private System.Windows.Forms.Label lblDescription3;
        private System.Windows.Forms.Label lblDescription4;
        private System.Windows.Forms.Label lblDescription5;
        private System.Windows.Forms.Label lblDescription6;
        private System.Windows.Forms.Label lblDescription7;
        private System.Windows.Forms.Label lblDescription8;
        private System.Windows.Forms.Label lblDescription9;
    }
}
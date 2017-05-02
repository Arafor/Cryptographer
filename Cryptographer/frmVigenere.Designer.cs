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
            this.btnSaveToClipboard = new System.Windows.Forms.Button();
            this.btnVigenereInfo = new System.Windows.Forms.Button();
            this.grpCipher.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCipher
            // 
            this.btnCipher.TabIndex = 4;
            this.btnCipher.Click += new System.EventHandler(this.btnCipher_Click);
            // 
            // grpCipher
            // 
            this.grpCipher.TabIndex = 2;
            // 
            // rdoBtnEncrypt
            // 
            this.rdoBtnEncrypt.TabIndex = 2;
            this.rdoBtnEncrypt.CheckedChanged += new System.EventHandler(this.cipherRadioButtonChanged);
            // 
            // rdoBtnDecrypt
            // 
            this.rdoBtnDecrypt.TabIndex = 3;
            this.rdoBtnDecrypt.CheckedChanged += new System.EventHandler(this.cipherRadioButtonChanged);
            // 
            // txtResult
            // 
            this.txtResult.TabIndex = 6;
            // 
            // txtKey
            // 
            this.txtKey.TabIndex = 1;
            // 
            // txtMessage
            // 
            this.txtMessage.TabIndex = 0;
            // 
            // btnSaveToClipboard
            // 
            this.btnSaveToClipboard.Image = global::Cryptographer.Properties.Resources.Editing_Clipboard_icon30;
            this.btnSaveToClipboard.Location = new System.Drawing.Point(427, 269);
            this.btnSaveToClipboard.Name = "btnSaveToClipboard";
            this.btnSaveToClipboard.Size = new System.Drawing.Size(40, 40);
            this.btnSaveToClipboard.TabIndex = 5;
            this.btnSaveToClipboard.UseVisualStyleBackColor = true;
            this.btnSaveToClipboard.Click += new System.EventHandler(this.btnSaveToClipboard_Click);
            // 
            // btnVigenereInfo
            // 
            this.btnVigenereInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVigenereInfo.Location = new System.Drawing.Point(445, 5);
            this.btnVigenereInfo.Name = "btnVigenereInfo";
            this.btnVigenereInfo.Size = new System.Drawing.Size(22, 23);
            this.btnVigenereInfo.TabIndex = 7;
            this.btnVigenereInfo.Text = "?";
            this.btnVigenereInfo.UseVisualStyleBackColor = true;
            this.btnVigenereInfo.Click += new System.EventHandler(this.btnVigenereInfo_Click);
            // 
            // frmVigenere
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 451);
            this.Controls.Add(this.btnVigenereInfo);
            this.Controls.Add(this.btnSaveToClipboard);
            this.Name = "frmVigenere";
            this.Text = "Cryptographer - Vigenere cipher";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmVigenere_FormClosing);
            this.Load += new System.EventHandler(this.frmVigenere_Load);
            this.Controls.SetChildIndex(this.btnSaveToClipboard, 0);
            this.Controls.SetChildIndex(this.btnVigenereInfo, 0);
            this.Controls.SetChildIndex(this.txtMessage, 0);
            this.Controls.SetChildIndex(this.txtKey, 0);
            this.Controls.SetChildIndex(this.txtResult, 0);
            this.Controls.SetChildIndex(this.lblMessage, 0);
            this.Controls.SetChildIndex(this.lblKey, 0);
            this.Controls.SetChildIndex(this.lblResult, 0);
            this.Controls.SetChildIndex(this.grpCipher, 0);
            this.Controls.SetChildIndex(this.btnCipher, 0);
            this.grpCipher.ResumeLayout(false);
            this.grpCipher.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSaveToClipboard;
        private System.Windows.Forms.Button btnVigenereInfo;
    }
}
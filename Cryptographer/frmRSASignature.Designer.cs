namespace Cryptographer
{
    partial class frmRSASignature
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
            this.btnRSASignatureInfo = new System.Windows.Forms.Button();
            this.grpDisplayVlaueMode.SuspendLayout();
            this.grpCipher.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCipher
            // 
            this.btnCipher.Click += new System.EventHandler(this.btnCipher_Click);
            // 
            // rdoBtnEncrypt
            // 
            this.rdoBtnEncrypt.CheckedChanged += new System.EventHandler(this.cipherRadioButtonChanged);
            // 
            // rdoBtnDecrypt
            // 
            this.rdoBtnDecrypt.CheckedChanged += new System.EventHandler(this.cipherRadioButtonChanged);
            // 
            // btnSaveToClipboard
            // 
            this.btnSaveToClipboard.Image = global::Cryptographer.Properties.Resources.Editing_Clipboard_icon30;
            this.btnSaveToClipboard.Location = new System.Drawing.Point(432, 512);
            this.btnSaveToClipboard.Name = "btnSaveToClipboard";
            this.btnSaveToClipboard.Size = new System.Drawing.Size(40, 40);
            this.btnSaveToClipboard.TabIndex = 72;
            this.btnSaveToClipboard.UseVisualStyleBackColor = true;
            this.btnSaveToClipboard.Click += new System.EventHandler(this.btnSaveToClipboard_Click);
            // 
            // btnRSASignatureInfo
            // 
            this.btnRSASignatureInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRSASignatureInfo.Location = new System.Drawing.Point(450, 12);
            this.btnRSASignatureInfo.Name = "btnRSASignatureInfo";
            this.btnRSASignatureInfo.Size = new System.Drawing.Size(22, 23);
            this.btnRSASignatureInfo.TabIndex = 73;
            this.btnRSASignatureInfo.Text = "?";
            this.btnRSASignatureInfo.UseVisualStyleBackColor = true;
            this.btnRSASignatureInfo.Click += new System.EventHandler(this.btnRSASignatureInfo_Click);
            // 
            // frmRSASignature
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 561);
            this.Controls.Add(this.btnSaveToClipboard);
            this.Controls.Add(this.btnRSASignatureInfo);
            this.Name = "frmRSASignature";
            this.Text = "Cryptographer- RSA signature form";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmRSASignature_FormClosing);
            this.Load += new System.EventHandler(this.frmRSASignature_Load);
            this.Controls.SetChildIndex(this.txtMessage, 0);
            this.Controls.SetChildIndex(this.txtKey, 0);
            this.Controls.SetChildIndex(this.grpCipher, 0);
            this.Controls.SetChildIndex(this.txtResult, 0);
            this.Controls.SetChildIndex(this.lblMessage, 0);
            this.Controls.SetChildIndex(this.lblKey, 0);
            this.Controls.SetChildIndex(this.lblResult, 0);
            this.Controls.SetChildIndex(this.btnCipher, 0);
            this.Controls.SetChildIndex(this.grpDisplayVlaueMode, 0);
            this.Controls.SetChildIndex(this.btnRSASignatureInfo, 0);
            this.Controls.SetChildIndex(this.btnSaveToClipboard, 0);
            this.grpDisplayVlaueMode.ResumeLayout(false);
            this.grpDisplayVlaueMode.PerformLayout();
            this.grpCipher.ResumeLayout(false);
            this.grpCipher.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSaveToClipboard;
        private System.Windows.Forms.Button btnRSASignatureInfo;
    }
}
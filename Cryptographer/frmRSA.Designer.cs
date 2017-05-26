namespace Cryptographer
{
    partial class frmRSA
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
            this.btnRSAInfo = new System.Windows.Forms.Button();
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
            this.rdoBtnEncrypt.Click += new System.EventHandler(this.cipherRadioButtonChanged);
            // 
            // rdoBtnDecrypt
            // 
            this.rdoBtnDecrypt.Click += new System.EventHandler(this.cipherRadioButtonChanged);
            // 
            // btnSaveToClipboard
            // 
            this.btnSaveToClipboard.Image = global::Cryptographer.Properties.Resources.Editing_Clipboard_icon30;
            this.btnSaveToClipboard.Location = new System.Drawing.Point(432, 512);
            this.btnSaveToClipboard.Name = "btnSaveToClipboard";
            this.btnSaveToClipboard.Size = new System.Drawing.Size(40, 40);
            this.btnSaveToClipboard.TabIndex = 64;
            this.btnSaveToClipboard.UseVisualStyleBackColor = true;
            this.btnSaveToClipboard.Click += new System.EventHandler(this.btnSaveToClipboard_Click);
            // 
            // btnRSAInfo
            // 
            this.btnRSAInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRSAInfo.Location = new System.Drawing.Point(450, 12);
            this.btnRSAInfo.Name = "btnRSAInfo";
            this.btnRSAInfo.Size = new System.Drawing.Size(22, 23);
            this.btnRSAInfo.TabIndex = 65;
            this.btnRSAInfo.Text = "?";
            this.btnRSAInfo.UseVisualStyleBackColor = true;
            this.btnRSAInfo.Click += new System.EventHandler(this.btnRSAInfo_Click);
            // 
            // frmRSA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 561);
            this.Controls.Add(this.btnSaveToClipboard);
            this.Controls.Add(this.btnRSAInfo);
            this.Name = "frmRSA";
            this.Text = "RSA cipher";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmRSA_FormClosing);
            this.Load += new System.EventHandler(this.frmRSA_Load);
            this.Controls.SetChildIndex(this.txtMessage, 0);
            this.Controls.SetChildIndex(this.txtKey, 0);
            this.Controls.SetChildIndex(this.grpCipher, 0);
            this.Controls.SetChildIndex(this.txtResult, 0);
            this.Controls.SetChildIndex(this.lblMessage, 0);
            this.Controls.SetChildIndex(this.lblKey, 0);
            this.Controls.SetChildIndex(this.lblResult, 0);
            this.Controls.SetChildIndex(this.btnCipher, 0);
            this.Controls.SetChildIndex(this.grpDisplayVlaueMode, 0);
            this.Controls.SetChildIndex(this.btnRSAInfo, 0);
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
        private System.Windows.Forms.Button btnRSAInfo;
    }
}
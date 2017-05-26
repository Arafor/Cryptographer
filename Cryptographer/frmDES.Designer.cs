namespace Cryptographer
{
    partial class frmDES
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
            this.btnCaesarInfo = new System.Windows.Forms.Button();
            this.btnSaveToClipboard = new System.Windows.Forms.Button();
            this.grpCipher.SuspendLayout();
            this.grpMode.SuspendLayout();
            this.grpDisplayVlaueMode.SuspendLayout();
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
            // btnCaesarInfo
            // 
            this.btnCaesarInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCaesarInfo.Location = new System.Drawing.Point(445, 12);
            this.btnCaesarInfo.Name = "btnCaesarInfo";
            this.btnCaesarInfo.Size = new System.Drawing.Size(22, 23);
            this.btnCaesarInfo.TabIndex = 13;
            this.btnCaesarInfo.Text = "?";
            this.btnCaesarInfo.UseVisualStyleBackColor = true;
            this.btnCaesarInfo.Click += new System.EventHandler(this.btnDESInfo_Click);
            // 
            // btnSaveToClipboard
            // 
            this.btnSaveToClipboard.Image = global::Cryptographer.Properties.Resources.Editing_Clipboard_icon30;
            this.btnSaveToClipboard.Location = new System.Drawing.Point(427, 643);
            this.btnSaveToClipboard.Name = "btnSaveToClipboard";
            this.btnSaveToClipboard.Size = new System.Drawing.Size(40, 40);
            this.btnSaveToClipboard.TabIndex = 5;
            this.btnSaveToClipboard.UseVisualStyleBackColor = true;
            this.btnSaveToClipboard.Click += new System.EventHandler(this.btnSaveToClipboard_Click);
            // 
            // frmDES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 691);
            this.Controls.Add(this.btnSaveToClipboard);
            this.Controls.Add(this.btnCaesarInfo);
            this.Name = "frmDES";
            this.Text = "DES cipher ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmDES_FormClosing);
            this.Load += new System.EventHandler(this.frmDES_Load);
            this.Controls.SetChildIndex(this.txtIV, 0);
            this.Controls.SetChildIndex(this.lblIV, 0);
            this.Controls.SetChildIndex(this.grpDisplayVlaueMode, 0);
            this.Controls.SetChildIndex(this.grpMode, 0);
            this.Controls.SetChildIndex(this.txtMessage, 0);
            this.Controls.SetChildIndex(this.txtKey, 0);
            this.Controls.SetChildIndex(this.txtResult, 0);
            this.Controls.SetChildIndex(this.lblMessage, 0);
            this.Controls.SetChildIndex(this.lblKey, 0);
            this.Controls.SetChildIndex(this.lblResult, 0);
            this.Controls.SetChildIndex(this.grpCipher, 0);
            this.Controls.SetChildIndex(this.btnCipher, 0);
            this.Controls.SetChildIndex(this.btnCaesarInfo, 0);
            this.Controls.SetChildIndex(this.btnSaveToClipboard, 0);
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

        private System.Windows.Forms.Button btnCaesarInfo;
        private System.Windows.Forms.Button btnSaveToClipboard;
    }
}
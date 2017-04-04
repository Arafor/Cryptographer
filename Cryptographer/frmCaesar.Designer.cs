namespace Cryptographer
{
    partial class frmCaesar
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
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblKey = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.btnSaveToClipboard = new System.Windows.Forms.Button();
            this.btnCaesarInfo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Location = new System.Drawing.Point(389, 208);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(75, 23);
            this.btnDecrypt.TabIndex = 23;
            this.btnDecrypt.Text = "Decrypt";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Location = new System.Drawing.Point(389, 179);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(75, 23);
            this.btnEncrypt.TabIndex = 22;
            this.btnEncrypt.Text = "Encrypt";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(12, 289);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(37, 13);
            this.lblResult.TabIndex = 21;
            this.lblResult.Text = "Result";
            // 
            // lblKey
            // 
            this.lblKey.AutoSize = true;
            this.lblKey.Location = new System.Drawing.Point(12, 163);
            this.lblKey.Name = "lblKey";
            this.lblKey.Size = new System.Drawing.Size(25, 13);
            this.lblKey.TabIndex = 20;
            this.lblKey.Text = "Key";
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(12, 18);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(50, 13);
            this.lblMessage.TabIndex = 19;
            this.lblMessage.Text = "Message";
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(12, 305);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResult.Size = new System.Drawing.Size(455, 120);
            this.txtResult.TabIndex = 18;
            // 
            // txtKey
            // 
            this.txtKey.Location = new System.Drawing.Point(12, 179);
            this.txtKey.Multiline = true;
            this.txtKey.Name = "txtKey";
            this.txtKey.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtKey.Size = new System.Drawing.Size(370, 100);
            this.txtKey.TabIndex = 17;
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(12, 34);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMessage.Size = new System.Drawing.Size(455, 120);
            this.txtMessage.TabIndex = 16;
            // 
            // btnSaveToClipboard
            // 
            this.btnSaveToClipboard.Image = global::Cryptographer.Properties.Resources.Editing_Clipboard_icon30;
            this.btnSaveToClipboard.Location = new System.Drawing.Point(424, 262);
            this.btnSaveToClipboard.Name = "btnSaveToClipboard";
            this.btnSaveToClipboard.Size = new System.Drawing.Size(40, 40);
            this.btnSaveToClipboard.TabIndex = 29;
            this.btnSaveToClipboard.UseVisualStyleBackColor = true;
            this.btnSaveToClipboard.Click += new System.EventHandler(this.btnSaveToClipboard_Click);
            // 
            // btnCaesarInfo
            // 
            this.btnCaesarInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCaesarInfo.Location = new System.Drawing.Point(445, 5);
            this.btnCaesarInfo.Name = "btnCaesarInfo";
            this.btnCaesarInfo.Size = new System.Drawing.Size(22, 23);
            this.btnCaesarInfo.TabIndex = 30;
            this.btnCaesarInfo.Text = "i";
            this.btnCaesarInfo.UseVisualStyleBackColor = true;
            this.btnCaesarInfo.Click += new System.EventHandler(this.btnCaesarInfo_Click);
            // 
            // frmCaesar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(484, 431);
            this.Controls.Add(this.btnCaesarInfo);
            this.Controls.Add(this.btnSaveToClipboard);
            this.Controls.Add(this.btnDecrypt);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblKey);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.txtKey);
            this.Controls.Add(this.txtMessage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmCaesar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Cryptographer- Caesar cipher";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblKey;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Button btnSaveToClipboard;
        private System.Windows.Forms.Button btnCaesarInfo;
    }
}
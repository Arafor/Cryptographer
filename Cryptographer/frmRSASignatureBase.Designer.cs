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
            this.lblSignedData = new System.Windows.Forms.Label();
            this.rdoBtnSign = new System.Windows.Forms.RadioButton();
            this.rdoBtnVerify = new System.Windows.Forms.RadioButton();
            this.grpCipher = new System.Windows.Forms.GroupBox();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.txtSignedData = new System.Windows.Forms.TextBox();
            this.lblSignature = new System.Windows.Forms.Label();
            this.txtSignature = new System.Windows.Forms.TextBox();
            this.lblValidSignature = new System.Windows.Forms.Label();
            this.btnImport = new System.Windows.Forms.Button();
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
            this.lblResult.Location = new System.Drawing.Point(9, 521);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(40, 13);
            this.lblResult.TabIndex = 71;
            this.lblResult.Text = "Result:";
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
            // lblSignedData
            // 
            this.lblSignedData.AutoSize = true;
            this.lblSignedData.Location = new System.Drawing.Point(12, 91);
            this.lblSignedData.Name = "lblSignedData";
            this.lblSignedData.Size = new System.Drawing.Size(66, 13);
            this.lblSignedData.TabIndex = 69;
            this.lblSignedData.Text = "Signed Data";
            // 
            // rdoBtnSign
            // 
            this.rdoBtnSign.AutoSize = true;
            this.rdoBtnSign.Location = new System.Drawing.Point(6, 19);
            this.rdoBtnSign.Name = "rdoBtnSign";
            this.rdoBtnSign.Size = new System.Drawing.Size(46, 17);
            this.rdoBtnSign.TabIndex = 8;
            this.rdoBtnSign.Text = "Sign";
            this.rdoBtnSign.UseVisualStyleBackColor = true;
            // 
            // rdoBtnVerify
            // 
            this.rdoBtnVerify.AutoSize = true;
            this.rdoBtnVerify.Location = new System.Drawing.Point(6, 42);
            this.rdoBtnVerify.Name = "rdoBtnVerify";
            this.rdoBtnVerify.Size = new System.Drawing.Size(51, 17);
            this.rdoBtnVerify.TabIndex = 9;
            this.rdoBtnVerify.Text = "Verify";
            this.rdoBtnVerify.UseVisualStyleBackColor = true;
            // 
            // grpCipher
            // 
            this.grpCipher.Controls.Add(this.rdoBtnSign);
            this.grpCipher.Controls.Add(this.rdoBtnVerify);
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
            // txtSignedData
            // 
            this.txtSignedData.Location = new System.Drawing.Point(12, 107);
            this.txtSignedData.Multiline = true;
            this.txtSignedData.Name = "txtSignedData";
            this.txtSignedData.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSignedData.Size = new System.Drawing.Size(455, 120);
            this.txtSignedData.TabIndex = 63;
            // 
            // lblSignature
            // 
            this.lblSignature.AutoSize = true;
            this.lblSignature.Location = new System.Drawing.Point(12, 370);
            this.lblSignature.Name = "lblSignature";
            this.lblSignature.Size = new System.Drawing.Size(52, 13);
            this.lblSignature.TabIndex = 73;
            this.lblSignature.Text = "Signature";
            // 
            // txtSignature
            // 
            this.txtSignature.Location = new System.Drawing.Point(12, 386);
            this.txtSignature.Multiline = true;
            this.txtSignature.Name = "txtSignature";
            this.txtSignature.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSignature.Size = new System.Drawing.Size(455, 120);
            this.txtSignature.TabIndex = 72;
            // 
            // lblValidSignature
            // 
            this.lblValidSignature.AutoSize = true;
            this.lblValidSignature.Location = new System.Drawing.Point(55, 521);
            this.lblValidSignature.Name = "lblValidSignature";
            this.lblValidSignature.Size = new System.Drawing.Size(53, 13);
            this.lblValidSignature.TabIndex = 74;
            this.lblValidSignature.Text = "Unknown";
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(379, 78);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(75, 23);
            this.btnImport.TabIndex = 75;
            this.btnImport.Text = "Browse...";
            this.btnImport.UseVisualStyleBackColor = true;
            // 
            // frmRSASignatureBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(484, 561);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.lblValidSignature);
            this.Controls.Add(this.lblSignature);
            this.Controls.Add(this.txtSignature);
            this.Controls.Add(this.grpDisplayVlaueMode);
            this.Controls.Add(this.btnCipher);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblKey);
            this.Controls.Add(this.lblSignedData);
            this.Controls.Add(this.grpCipher);
            this.Controls.Add(this.txtKey);
            this.Controls.Add(this.txtSignedData);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmRSASignatureBase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "RSA signature base";
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
        protected System.Windows.Forms.Label lblSignedData;
        protected System.Windows.Forms.RadioButton rdoBtnSign;
        protected System.Windows.Forms.RadioButton rdoBtnVerify;
        protected System.Windows.Forms.GroupBox grpCipher;
        protected System.Windows.Forms.TextBox txtKey;
        protected System.Windows.Forms.TextBox txtSignedData;
        protected System.Windows.Forms.Label lblSignature;
        protected System.Windows.Forms.TextBox txtSignature;
        protected System.Windows.Forms.Label lblValidSignature;
        protected System.Windows.Forms.Button btnImport;
    }
}
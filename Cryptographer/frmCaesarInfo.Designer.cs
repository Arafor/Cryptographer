namespace Cryptographer
{
    partial class frmCaesarInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCaesarInfo));
            this.label2 = new System.Windows.Forms.Label();
            this.lblDescription1 = new System.Windows.Forms.Label();
            this.lblDescription2 = new System.Windows.Forms.Label();
            this.lblDescription0 = new System.Windows.Forms.Label();
            this.lstFormula = new System.Windows.Forms.ListBox();
            this.btnCipher = new System.Windows.Forms.Button();
            this.lblFormula = new System.Windows.Forms.Label();
            this.grpCipher = new System.Windows.Forms.GroupBox();
            this.rdoBtnEncrypt = new System.Windows.Forms.RadioButton();
            this.rdoBtnDecrypt = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAlphabet = new System.Windows.Forms.Label();
            this.lstAlphabet = new System.Windows.Forms.ListBox();
            this.lblMessageParsed = new System.Windows.Forms.Label();
            this.txtMessageParsed = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblKey = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.grpCipher.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 456);
            this.label2.MaximumSize = new System.Drawing.Size(500, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(499, 45);
            this.label2.TabIndex = 59;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // lblDescription1
            // 
            this.lblDescription1.AutoSize = true;
            this.lblDescription1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription1.Location = new System.Drawing.Point(12, 53);
            this.lblDescription1.MaximumSize = new System.Drawing.Size(500, 0);
            this.lblDescription1.Name = "lblDescription1";
            this.lblDescription1.Size = new System.Drawing.Size(280, 15);
            this.lblDescription1.TabIndex = 57;
            this.lblDescription1.Text = "To start off you must choose a message and a key.";
            // 
            // lblDescription2
            // 
            this.lblDescription2.AutoSize = true;
            this.lblDescription2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription2.Location = new System.Drawing.Point(12, 171);
            this.lblDescription2.MaximumSize = new System.Drawing.Size(500, 0);
            this.lblDescription2.Name = "lblDescription2";
            this.lblDescription2.Size = new System.Drawing.Size(477, 30);
            this.lblDescription2.TabIndex = 56;
            this.lblDescription2.Text = "After that we need to parse the message to make sure the text contains letters fr" +
    "om the english alphabet.";
            // 
            // lblDescription0
            // 
            this.lblDescription0.AutoSize = true;
            this.lblDescription0.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription0.Location = new System.Drawing.Point(12, 9);
            this.lblDescription0.MaximumSize = new System.Drawing.Size(500, 0);
            this.lblDescription0.Name = "lblDescription0";
            this.lblDescription0.Size = new System.Drawing.Size(499, 30);
            this.lblDescription0.TabIndex = 55;
            this.lblDescription0.Text = "The Caesar cipher is a quite simplistic cipher that uses text values both for its" +
    " message and its key.";
            // 
            // lstFormula
            // 
            this.lstFormula.FormattingEnabled = true;
            this.lstFormula.Location = new System.Drawing.Point(15, 528);
            this.lstFormula.Name = "lstFormula";
            this.lstFormula.Size = new System.Drawing.Size(350, 95);
            this.lstFormula.TabIndex = 54;
            // 
            // btnCipher
            // 
            this.btnCipher.Location = new System.Drawing.Point(437, 605);
            this.btnCipher.Name = "btnCipher";
            this.btnCipher.Size = new System.Drawing.Size(75, 23);
            this.btnCipher.TabIndex = 53;
            this.btnCipher.Text = "Cipher";
            this.btnCipher.UseVisualStyleBackColor = true;
            this.btnCipher.Click += new System.EventHandler(this.btnCipher_Click);
            // 
            // lblFormula
            // 
            this.lblFormula.AutoSize = true;
            this.lblFormula.Location = new System.Drawing.Point(15, 512);
            this.lblFormula.Name = "lblFormula";
            this.lblFormula.Size = new System.Drawing.Size(44, 13);
            this.lblFormula.TabIndex = 52;
            this.lblFormula.Text = "Formula";
            // 
            // grpCipher
            // 
            this.grpCipher.Controls.Add(this.rdoBtnEncrypt);
            this.grpCipher.Controls.Add(this.rdoBtnDecrypt);
            this.grpCipher.Location = new System.Drawing.Point(412, 528);
            this.grpCipher.Name = "grpCipher";
            this.grpCipher.Size = new System.Drawing.Size(97, 71);
            this.grpCipher.TabIndex = 51;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 302);
            this.label1.MaximumSize = new System.Drawing.Size(500, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(497, 30);
            this.label1.TabIndex = 58;
            this.label1.Text = "You then translate each letter to its numerical number value based on the order o" +
    "f where it is located within the alphabet e.g. A => 0, C => 2.";
            // 
            // lblAlphabet
            // 
            this.lblAlphabet.AutoSize = true;
            this.lblAlphabet.Location = new System.Drawing.Point(15, 342);
            this.lblAlphabet.Name = "lblAlphabet";
            this.lblAlphabet.Size = new System.Drawing.Size(49, 13);
            this.lblAlphabet.TabIndex = 50;
            this.lblAlphabet.Text = "Alphabet";
            // 
            // lstAlphabet
            // 
            this.lstAlphabet.FormattingEnabled = true;
            this.lstAlphabet.Location = new System.Drawing.Point(15, 358);
            this.lstAlphabet.Name = "lstAlphabet";
            this.lstAlphabet.Size = new System.Drawing.Size(120, 95);
            this.lstAlphabet.TabIndex = 49;
            // 
            // lblMessageParsed
            // 
            this.lblMessageParsed.AutoSize = true;
            this.lblMessageParsed.Location = new System.Drawing.Point(15, 212);
            this.lblMessageParsed.Name = "lblMessageParsed";
            this.lblMessageParsed.Size = new System.Drawing.Size(85, 13);
            this.lblMessageParsed.TabIndex = 47;
            this.lblMessageParsed.Text = "Parsed message";
            // 
            // txtMessageParsed
            // 
            this.txtMessageParsed.Location = new System.Drawing.Point(15, 228);
            this.txtMessageParsed.Multiline = true;
            this.txtMessageParsed.Name = "txtMessageParsed";
            this.txtMessageParsed.ReadOnly = true;
            this.txtMessageParsed.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMessageParsed.Size = new System.Drawing.Size(506, 67);
            this.txtMessageParsed.TabIndex = 45;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(15, 633);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(37, 13);
            this.lblResult.TabIndex = 44;
            this.lblResult.Text = "Result";
            // 
            // lblKey
            // 
            this.lblKey.AutoSize = true;
            this.lblKey.Location = new System.Drawing.Point(371, 75);
            this.lblKey.Name = "lblKey";
            this.lblKey.Size = new System.Drawing.Size(25, 13);
            this.lblKey.TabIndex = 43;
            this.lblKey.Text = "Key";
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(15, 75);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(50, 13);
            this.lblMessage.TabIndex = 42;
            this.lblMessage.Text = "Message";
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(15, 649);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResult.Size = new System.Drawing.Size(497, 77);
            this.txtResult.TabIndex = 41;
            // 
            // txtKey
            // 
            this.txtKey.Location = new System.Drawing.Point(371, 91);
            this.txtKey.Multiline = true;
            this.txtKey.Name = "txtKey";
            this.txtKey.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtKey.Size = new System.Drawing.Size(150, 67);
            this.txtKey.TabIndex = 40;
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(15, 91);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMessage.Size = new System.Drawing.Size(350, 67);
            this.txtMessage.TabIndex = 39;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(15, 9);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(0, 13);
            this.lblDescription.TabIndex = 38;
            // 
            // frmCaesarInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(534, 741);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblDescription1);
            this.Controls.Add(this.lblDescription2);
            this.Controls.Add(this.lblDescription0);
            this.Controls.Add(this.lstFormula);
            this.Controls.Add(this.btnCipher);
            this.Controls.Add(this.lblFormula);
            this.Controls.Add(this.grpCipher);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblAlphabet);
            this.Controls.Add(this.lstAlphabet);
            this.Controls.Add(this.lblMessageParsed);
            this.Controls.Add(this.txtMessageParsed);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblKey);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.txtKey);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.lblDescription);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmCaesarInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Cryptographer - Caezar cipher info";
            this.Load += new System.EventHandler(this.frmCaesarInfo_Load);
            this.grpCipher.ResumeLayout(false);
            this.grpCipher.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDescription1;
        private System.Windows.Forms.Label lblDescription2;
        private System.Windows.Forms.Label lblDescription0;
        private System.Windows.Forms.ListBox lstFormula;
        private System.Windows.Forms.Button btnCipher;
        private System.Windows.Forms.Label lblFormula;
        private System.Windows.Forms.GroupBox grpCipher;
        private System.Windows.Forms.RadioButton rdoBtnEncrypt;
        private System.Windows.Forms.RadioButton rdoBtnDecrypt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAlphabet;
        private System.Windows.Forms.ListBox lstAlphabet;
        private System.Windows.Forms.Label lblMessageParsed;
        private System.Windows.Forms.TextBox txtMessageParsed;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblKey;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Label lblDescription;
    }
}
namespace Cryptographer
{
    partial class frmVigenereInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVigenereInfo));
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblKeyParsed = new System.Windows.Forms.Label();
            this.lblMessageParsed = new System.Windows.Forms.Label();
            this.txtKeyParsed = new System.Windows.Forms.TextBox();
            this.txtMessageParsed = new System.Windows.Forms.TextBox();
            this.lstAlphabet = new System.Windows.Forms.ListBox();
            this.lblAlphabet = new System.Windows.Forms.Label();
            this.lblFormula = new System.Windows.Forms.Label();
            this.lstFormula = new System.Windows.Forms.ListBox();
            this.lblDescription0 = new System.Windows.Forms.Label();
            this.lblDescription2 = new System.Windows.Forms.Label();
            this.lblDescription1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnVigenere = new System.Windows.Forms.Button();
            this.grpCipher.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCipher
            // 
            this.btnCipher.Location = new System.Drawing.Point(434, 624);
            this.btnCipher.TabIndex = 4;
            this.btnCipher.Click += new System.EventHandler(this.btnCipher_Click);
            // 
            // grpCipher
            // 
            this.grpCipher.Location = new System.Drawing.Point(409, 547);
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
            // lblResult
            // 
            this.lblResult.Location = new System.Drawing.Point(12, 658);
            // 
            // lblKey
            // 
            this.lblKey.Location = new System.Drawing.Point(368, 75);
            // 
            // lblMessage
            // 
            this.lblMessage.Location = new System.Drawing.Point(12, 75);
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(12, 674);
            this.txtResult.Size = new System.Drawing.Size(497, 77);
            this.txtResult.TabIndex = 6;
            // 
            // txtKey
            // 
            this.txtKey.Location = new System.Drawing.Point(368, 91);
            this.txtKey.Size = new System.Drawing.Size(150, 67);
            this.txtKey.TabIndex = 1;
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(12, 91);
            this.txtMessage.Size = new System.Drawing.Size(350, 67);
            this.txtMessage.TabIndex = 0;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(12, 9);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(0, 13);
            this.lblDescription.TabIndex = 0;
            // 
            // lblKeyParsed
            // 
            this.lblKeyParsed.AutoSize = true;
            this.lblKeyParsed.Location = new System.Drawing.Point(368, 239);
            this.lblKeyParsed.Name = "lblKeyParsed";
            this.lblKeyParsed.Size = new System.Drawing.Size(60, 13);
            this.lblKeyParsed.TabIndex = 23;
            this.lblKeyParsed.Text = "Parsed key";
            // 
            // lblMessageParsed
            // 
            this.lblMessageParsed.AutoSize = true;
            this.lblMessageParsed.Location = new System.Drawing.Point(12, 239);
            this.lblMessageParsed.Name = "lblMessageParsed";
            this.lblMessageParsed.Size = new System.Drawing.Size(85, 13);
            this.lblMessageParsed.TabIndex = 22;
            this.lblMessageParsed.Text = "Parsed message";
            // 
            // txtKeyParsed
            // 
            this.txtKeyParsed.Location = new System.Drawing.Point(368, 255);
            this.txtKeyParsed.Multiline = true;
            this.txtKeyParsed.Name = "txtKeyParsed";
            this.txtKeyParsed.ReadOnly = true;
            this.txtKeyParsed.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtKeyParsed.Size = new System.Drawing.Size(150, 67);
            this.txtKeyParsed.TabIndex = 9;
            // 
            // txtMessageParsed
            // 
            this.txtMessageParsed.Location = new System.Drawing.Point(12, 255);
            this.txtMessageParsed.Multiline = true;
            this.txtMessageParsed.Name = "txtMessageParsed";
            this.txtMessageParsed.ReadOnly = true;
            this.txtMessageParsed.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMessageParsed.Size = new System.Drawing.Size(350, 67);
            this.txtMessageParsed.TabIndex = 8;
            // 
            // lstAlphabet
            // 
            this.lstAlphabet.FormattingEnabled = true;
            this.lstAlphabet.Location = new System.Drawing.Point(12, 390);
            this.lstAlphabet.Name = "lstAlphabet";
            this.lstAlphabet.Size = new System.Drawing.Size(120, 95);
            this.lstAlphabet.TabIndex = 10;
            // 
            // lblAlphabet
            // 
            this.lblAlphabet.AutoSize = true;
            this.lblAlphabet.Location = new System.Drawing.Point(12, 374);
            this.lblAlphabet.Name = "lblAlphabet";
            this.lblAlphabet.Size = new System.Drawing.Size(49, 13);
            this.lblAlphabet.TabIndex = 25;
            this.lblAlphabet.Text = "Alphabet";
            // 
            // lblFormula
            // 
            this.lblFormula.AutoSize = true;
            this.lblFormula.Location = new System.Drawing.Point(12, 531);
            this.lblFormula.Name = "lblFormula";
            this.lblFormula.Size = new System.Drawing.Size(44, 13);
            this.lblFormula.TabIndex = 29;
            this.lblFormula.Text = "Formula";
            // 
            // lstFormula
            // 
            this.lstFormula.FormattingEnabled = true;
            this.lstFormula.Location = new System.Drawing.Point(12, 547);
            this.lstFormula.Name = "lstFormula";
            this.lstFormula.Size = new System.Drawing.Size(350, 95);
            this.lstFormula.TabIndex = 11;
            // 
            // lblDescription0
            // 
            this.lblDescription0.AutoSize = true;
            this.lblDescription0.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription0.Location = new System.Drawing.Point(9, 9);
            this.lblDescription0.MaximumSize = new System.Drawing.Size(460, 0);
            this.lblDescription0.Name = "lblDescription0";
            this.lblDescription0.Size = new System.Drawing.Size(436, 30);
            this.lblDescription0.TabIndex = 33;
            this.lblDescription0.Text = "The Vigenere cipher is an old simplistic cipher that uses text values both for th" +
    "e message and key.";
            // 
            // lblDescription2
            // 
            this.lblDescription2.AutoSize = true;
            this.lblDescription2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription2.Location = new System.Drawing.Point(9, 171);
            this.lblDescription2.MaximumSize = new System.Drawing.Size(500, 0);
            this.lblDescription2.Name = "lblDescription2";
            this.lblDescription2.Size = new System.Drawing.Size(477, 60);
            this.lblDescription2.TabIndex = 34;
            this.lblDescription2.Text = resources.GetString("lblDescription2.Text");
            // 
            // lblDescription1
            // 
            this.lblDescription1.AutoSize = true;
            this.lblDescription1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription1.Location = new System.Drawing.Point(9, 53);
            this.lblDescription1.MaximumSize = new System.Drawing.Size(500, 0);
            this.lblDescription1.Name = "lblDescription1";
            this.lblDescription1.Size = new System.Drawing.Size(280, 15);
            this.lblDescription1.TabIndex = 35;
            this.lblDescription1.Text = "To start off you must choose a message and a key.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 334);
            this.label1.MaximumSize = new System.Drawing.Size(500, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(497, 30);
            this.label1.TabIndex = 36;
            this.label1.Text = "You then translate each letter to its numerical number value based on the order o" +
    "f where it is located within the alphabet e.g. A => 0, C => 2.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 497);
            this.label2.MaximumSize = new System.Drawing.Size(500, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(499, 30);
            this.label2.TabIndex = 37;
            this.label2.Text = "After that we can begin encrypting or decrypting our message. Based on what we ch" +
    "ose the formulas for  encrypting and decrypting slightly differs.";
            // 
            // btnVigenere
            // 
            this.btnVigenere.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVigenere.Location = new System.Drawing.Point(475, 12);
            this.btnVigenere.Name = "btnVigenere";
            this.btnVigenere.Size = new System.Drawing.Size(47, 23);
            this.btnVigenere.TabIndex = 7;
            this.btnVigenere.Text = "Back";
            this.btnVigenere.UseVisualStyleBackColor = true;
            this.btnVigenere.Click += new System.EventHandler(this.btnVigenere_Click);
            // 
            // frmVigenereInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 761);
            this.Controls.Add(this.btnVigenere);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDescription1);
            this.Controls.Add(this.lblDescription2);
            this.Controls.Add(this.lblDescription0);
            this.Controls.Add(this.lstFormula);
            this.Controls.Add(this.lblFormula);
            this.Controls.Add(this.lblAlphabet);
            this.Controls.Add(this.lstAlphabet);
            this.Controls.Add(this.lblKeyParsed);
            this.Controls.Add(this.lblMessageParsed);
            this.Controls.Add(this.txtKeyParsed);
            this.Controls.Add(this.txtMessageParsed);
            this.Controls.Add(this.lblDescription);
            this.Name = "frmVigenereInfo";
            this.Text = "Cryptographer - Vigenere cipher info";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmVigenereInfo_FormClosing);
            this.Load += new System.EventHandler(this.frmVigenereInfo_Load);
            this.Controls.SetChildIndex(this.lblDescription, 0);
            this.Controls.SetChildIndex(this.txtMessageParsed, 0);
            this.Controls.SetChildIndex(this.txtKeyParsed, 0);
            this.Controls.SetChildIndex(this.lblMessageParsed, 0);
            this.Controls.SetChildIndex(this.lblKeyParsed, 0);
            this.Controls.SetChildIndex(this.lstAlphabet, 0);
            this.Controls.SetChildIndex(this.lblAlphabet, 0);
            this.Controls.SetChildIndex(this.lblFormula, 0);
            this.Controls.SetChildIndex(this.lstFormula, 0);
            this.Controls.SetChildIndex(this.lblDescription0, 0);
            this.Controls.SetChildIndex(this.lblDescription2, 0);
            this.Controls.SetChildIndex(this.lblDescription1, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.txtMessage, 0);
            this.Controls.SetChildIndex(this.txtKey, 0);
            this.Controls.SetChildIndex(this.txtResult, 0);
            this.Controls.SetChildIndex(this.lblMessage, 0);
            this.Controls.SetChildIndex(this.lblKey, 0);
            this.Controls.SetChildIndex(this.lblResult, 0);
            this.Controls.SetChildIndex(this.grpCipher, 0);
            this.Controls.SetChildIndex(this.btnCipher, 0);
            this.Controls.SetChildIndex(this.btnVigenere, 0);
            this.grpCipher.ResumeLayout(false);
            this.grpCipher.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblKeyParsed;
        private System.Windows.Forms.Label lblMessageParsed;
        private System.Windows.Forms.TextBox txtKeyParsed;
        private System.Windows.Forms.TextBox txtMessageParsed;
        private System.Windows.Forms.ListBox lstAlphabet;
        private System.Windows.Forms.Label lblAlphabet;
        private System.Windows.Forms.Label lblFormula;
        private System.Windows.Forms.ListBox lstFormula;
        private System.Windows.Forms.Label lblDescription0;
        private System.Windows.Forms.Label lblDescription2;
        private System.Windows.Forms.Label lblDescription1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnVigenere;
    }
}
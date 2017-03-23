﻿namespace Cryptographer
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
            this.lblResult = new System.Windows.Forms.Label();
            this.lblKey = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.lblKeyParsed = new System.Windows.Forms.Label();
            this.lblMessageParsed = new System.Windows.Forms.Label();
            this.txtKeyParsed = new System.Windows.Forms.TextBox();
            this.txtMessageParsed = new System.Windows.Forms.TextBox();
            this.lstAlphabet = new System.Windows.Forms.ListBox();
            this.lblAlphabet = new System.Windows.Forms.Label();
            this.rdoBtnEncrypt = new System.Windows.Forms.RadioButton();
            this.rdoBtnDecrypt = new System.Windows.Forms.RadioButton();
            this.grpCipher = new System.Windows.Forms.GroupBox();
            this.lblFormula = new System.Windows.Forms.Label();
            this.btnCipher = new System.Windows.Forms.Button();
            this.lstFormula = new System.Windows.Forms.ListBox();
            this.lblDescription0 = new System.Windows.Forms.Label();
            this.lblDescription2 = new System.Windows.Forms.Label();
            this.lblDescription1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grpCipher.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(12, 9);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(0, 13);
            this.lblDescription.TabIndex = 0;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(12, 658);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(37, 13);
            this.lblResult.TabIndex = 19;
            this.lblResult.Text = "Result";
            // 
            // lblKey
            // 
            this.lblKey.AutoSize = true;
            this.lblKey.Location = new System.Drawing.Point(291, 75);
            this.lblKey.Name = "lblKey";
            this.lblKey.Size = new System.Drawing.Size(25, 13);
            this.lblKey.TabIndex = 18;
            this.lblKey.Text = "Key";
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(12, 75);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(50, 13);
            this.lblMessage.TabIndex = 17;
            this.lblMessage.Text = "Message";
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(12, 674);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(497, 77);
            this.txtResult.TabIndex = 16;
            // 
            // txtKey
            // 
            this.txtKey.Location = new System.Drawing.Point(291, 91);
            this.txtKey.Multiline = true;
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(115, 20);
            this.txtKey.TabIndex = 15;
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(12, 91);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(273, 67);
            this.txtMessage.TabIndex = 14;
            // 
            // lblKeyParsed
            // 
            this.lblKeyParsed.AutoSize = true;
            this.lblKeyParsed.Location = new System.Drawing.Point(320, 239);
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
            this.txtKeyParsed.Location = new System.Drawing.Point(320, 255);
            this.txtKeyParsed.Multiline = true;
            this.txtKeyParsed.Name = "txtKeyParsed";
            this.txtKeyParsed.ReadOnly = true;
            this.txtKeyParsed.Size = new System.Drawing.Size(115, 20);
            this.txtKeyParsed.TabIndex = 21;
            // 
            // txtMessageParsed
            // 
            this.txtMessageParsed.Location = new System.Drawing.Point(12, 255);
            this.txtMessageParsed.Multiline = true;
            this.txtMessageParsed.Name = "txtMessageParsed";
            this.txtMessageParsed.ReadOnly = true;
            this.txtMessageParsed.Size = new System.Drawing.Size(302, 67);
            this.txtMessageParsed.TabIndex = 20;
            // 
            // lstAlphabet
            // 
            this.lstAlphabet.FormattingEnabled = true;
            this.lstAlphabet.Location = new System.Drawing.Point(12, 390);
            this.lstAlphabet.Name = "lstAlphabet";
            this.lstAlphabet.Size = new System.Drawing.Size(120, 95);
            this.lstAlphabet.TabIndex = 24;
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
            // 
            // grpCipher
            // 
            this.grpCipher.Controls.Add(this.rdoBtnEncrypt);
            this.grpCipher.Controls.Add(this.rdoBtnDecrypt);
            this.grpCipher.Location = new System.Drawing.Point(409, 547);
            this.grpCipher.Name = "grpCipher";
            this.grpCipher.Size = new System.Drawing.Size(97, 71);
            this.grpCipher.TabIndex = 28;
            this.grpCipher.TabStop = false;
            this.grpCipher.Text = "Cipher";
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
            // btnCipher
            // 
            this.btnCipher.Location = new System.Drawing.Point(434, 624);
            this.btnCipher.Name = "btnCipher";
            this.btnCipher.Size = new System.Drawing.Size(75, 23);
            this.btnCipher.TabIndex = 31;
            this.btnCipher.Text = "Cipher";
            this.btnCipher.UseVisualStyleBackColor = true;
            this.btnCipher.Click += new System.EventHandler(this.btnCipher_Click);
            // 
            // lstFormula
            // 
            this.lstFormula.FormattingEnabled = true;
            this.lstFormula.Location = new System.Drawing.Point(12, 547);
            this.lstFormula.Name = "lstFormula";
            this.lstFormula.Size = new System.Drawing.Size(349, 95);
            this.lstFormula.TabIndex = 32;
            // 
            // lblDescription0
            // 
            this.lblDescription0.AutoSize = true;
            this.lblDescription0.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription0.Location = new System.Drawing.Point(9, 9);
            this.lblDescription0.MaximumSize = new System.Drawing.Size(500, 0);
            this.lblDescription0.Name = "lblDescription0";
            this.lblDescription0.Size = new System.Drawing.Size(500, 30);
            this.lblDescription0.TabIndex = 33;
            this.lblDescription0.Text = "The Vigenere cipher is a an old simplistic cipher that uses text values both for " +
    "the message and key.";
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
            // frmVigenereInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 762);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDescription1);
            this.Controls.Add(this.lblDescription2);
            this.Controls.Add(this.lblDescription0);
            this.Controls.Add(this.lstFormula);
            this.Controls.Add(this.btnCipher);
            this.Controls.Add(this.lblFormula);
            this.Controls.Add(this.grpCipher);
            this.Controls.Add(this.lblAlphabet);
            this.Controls.Add(this.lstAlphabet);
            this.Controls.Add(this.lblKeyParsed);
            this.Controls.Add(this.lblMessageParsed);
            this.Controls.Add(this.txtKeyParsed);
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
            this.Name = "frmVigenereInfo";
            this.Text = "Cryptographer - Vigenere cipher info";
            this.Load += new System.EventHandler(this.frmVigenereInfo_Load);
            this.grpCipher.ResumeLayout(false);
            this.grpCipher.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblKey;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Label lblKeyParsed;
        private System.Windows.Forms.Label lblMessageParsed;
        private System.Windows.Forms.TextBox txtKeyParsed;
        private System.Windows.Forms.TextBox txtMessageParsed;
        private System.Windows.Forms.ListBox lstAlphabet;
        private System.Windows.Forms.Label lblAlphabet;
        private System.Windows.Forms.RadioButton rdoBtnEncrypt;
        private System.Windows.Forms.RadioButton rdoBtnDecrypt;
        private System.Windows.Forms.GroupBox grpCipher;
        private System.Windows.Forms.Label lblFormula;
        private System.Windows.Forms.Button btnCipher;
        private System.Windows.Forms.ListBox lstFormula;
        private System.Windows.Forms.Label lblDescription0;
        private System.Windows.Forms.Label lblDescription2;
        private System.Windows.Forms.Label lblDescription1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
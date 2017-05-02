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
            this.lblFormula = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAlphabet = new System.Windows.Forms.Label();
            this.lstAlphabet = new System.Windows.Forms.ListBox();
            this.lblMessageParsed = new System.Windows.Forms.Label();
            this.txtMessageParsed = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.btnCaesar = new System.Windows.Forms.Button();
            this.grpCipher.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCipher
            // 
            this.btnCipher.Location = new System.Drawing.Point(437, 605);
            this.btnCipher.TabIndex = 4;
            this.btnCipher.Click += new System.EventHandler(this.btnCipher_Click);
            // 
            // grpCipher
            // 
            this.grpCipher.Location = new System.Drawing.Point(412, 528);
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
            this.lblResult.Location = new System.Drawing.Point(15, 633);
            // 
            // lblKey
            // 
            this.lblKey.Location = new System.Drawing.Point(371, 75);
            // 
            // lblMessage
            // 
            this.lblMessage.Location = new System.Drawing.Point(15, 75);
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(15, 649);
            this.txtResult.Size = new System.Drawing.Size(497, 77);
            this.txtResult.TabIndex = 6;
            // 
            // txtKey
            // 
            this.txtKey.Location = new System.Drawing.Point(371, 91);
            this.txtKey.Size = new System.Drawing.Size(150, 67);
            this.txtKey.TabIndex = 1;
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(15, 91);
            this.txtMessage.Size = new System.Drawing.Size(350, 67);
            this.txtMessage.TabIndex = 0;
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
            this.lblDescription0.MaximumSize = new System.Drawing.Size(460, 0);
            this.lblDescription0.Name = "lblDescription0";
            this.lblDescription0.Size = new System.Drawing.Size(424, 30);
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
            this.lstFormula.TabIndex = 10;
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
            this.lstAlphabet.TabIndex = 9;
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
            this.txtMessageParsed.Location = new System.Drawing.Point(6, 228);
            this.txtMessageParsed.Multiline = true;
            this.txtMessageParsed.Name = "txtMessageParsed";
            this.txtMessageParsed.ReadOnly = true;
            this.txtMessageParsed.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMessageParsed.Size = new System.Drawing.Size(506, 67);
            this.txtMessageParsed.TabIndex = 8;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(15, 9);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(0, 13);
            this.lblDescription.TabIndex = 38;
            // 
            // btnCaesar
            // 
            this.btnCaesar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCaesar.Location = new System.Drawing.Point(475, 12);
            this.btnCaesar.Name = "btnCaesar";
            this.btnCaesar.Size = new System.Drawing.Size(47, 23);
            this.btnCaesar.TabIndex = 7;
            this.btnCaesar.Text = "Back";
            this.btnCaesar.UseVisualStyleBackColor = true;
            this.btnCaesar.Click += new System.EventHandler(this.btnCaesarInfo_Click);
            // 
            // frmCaesarInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 741);
            this.Controls.Add(this.btnCaesar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblDescription1);
            this.Controls.Add(this.lblDescription2);
            this.Controls.Add(this.lblDescription0);
            this.Controls.Add(this.lstFormula);
            this.Controls.Add(this.lblFormula);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblAlphabet);
            this.Controls.Add(this.lstAlphabet);
            this.Controls.Add(this.lblMessageParsed);
            this.Controls.Add(this.txtMessageParsed);
            this.Controls.Add(this.lblDescription);
            this.Name = "frmCaesarInfo";
            this.Text = "Cryptographer - Caezar cipher info";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCaesarInfo_FormClosing);
            this.Load += new System.EventHandler(this.frmCaesarInfo_Load);
            this.Controls.SetChildIndex(this.lblDescription, 0);
            this.Controls.SetChildIndex(this.txtMessageParsed, 0);
            this.Controls.SetChildIndex(this.lblMessageParsed, 0);
            this.Controls.SetChildIndex(this.lstAlphabet, 0);
            this.Controls.SetChildIndex(this.lblAlphabet, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.lblFormula, 0);
            this.Controls.SetChildIndex(this.lstFormula, 0);
            this.Controls.SetChildIndex(this.lblDescription0, 0);
            this.Controls.SetChildIndex(this.lblDescription2, 0);
            this.Controls.SetChildIndex(this.lblDescription1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.txtMessage, 0);
            this.Controls.SetChildIndex(this.txtKey, 0);
            this.Controls.SetChildIndex(this.txtResult, 0);
            this.Controls.SetChildIndex(this.lblMessage, 0);
            this.Controls.SetChildIndex(this.lblKey, 0);
            this.Controls.SetChildIndex(this.lblResult, 0);
            this.Controls.SetChildIndex(this.grpCipher, 0);
            this.Controls.SetChildIndex(this.btnCipher, 0);
            this.Controls.SetChildIndex(this.btnCaesar, 0);
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
        private System.Windows.Forms.Label lblFormula;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAlphabet;
        private System.Windows.Forms.ListBox lstAlphabet;
        private System.Windows.Forms.Label lblMessageParsed;
        private System.Windows.Forms.TextBox txtMessageParsed;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Button btnCaesar;
    }
}
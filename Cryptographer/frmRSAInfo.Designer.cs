namespace Cryptographer
{
    partial class frmRSAInfo
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
            this.btnRSA = new System.Windows.Forms.Button();
            this.btnSaveToClipboard = new System.Windows.Forms.Button();
            this.lblDescription1 = new System.Windows.Forms.Label();
            this.lblDescription2 = new System.Windows.Forms.Label();
            this.lblDescription3 = new System.Windows.Forms.Label();
            this.lblDescription4 = new System.Windows.Forms.Label();
            this.lstFormula = new System.Windows.Forms.ListBox();
            this.lblDescription5 = new System.Windows.Forms.Label();
            this.lblP = new System.Windows.Forms.Label();
            this.txtP = new System.Windows.Forms.TextBox();
            this.lblQ = new System.Windows.Forms.Label();
            this.txtQ = new System.Windows.Forms.TextBox();
            this.lblN = new System.Windows.Forms.Label();
            this.txtN = new System.Windows.Forms.TextBox();
            this.lblD = new System.Windows.Forms.Label();
            this.txtD = new System.Windows.Forms.TextBox();
            this.lblE = new System.Windows.Forms.Label();
            this.txtE = new System.Windows.Forms.TextBox();
            this.lblDescription6 = new System.Windows.Forms.Label();
            this.lblDescription7 = new System.Windows.Forms.Label();
            this.grpDisplayVlaueMode.SuspendLayout();
            this.grpCipher.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpDisplayVlaueMode
            // 
            this.grpDisplayVlaueMode.Location = new System.Drawing.Point(12, 28);
            // 
            // btnCipher
            // 
            this.btnCipher.Location = new System.Drawing.Point(379, 398);
            this.btnCipher.Click += new System.EventHandler(this.btnCipher_Click);
            // 
            // lblResult
            // 
            this.lblResult.Location = new System.Drawing.Point(12, 1019);
            // 
            // lblKey
            // 
            this.lblKey.Location = new System.Drawing.Point(12, 292);
            // 
            // lblMessage
            // 
            this.lblMessage.Location = new System.Drawing.Point(12, 120);
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(12, 1035);
            // 
            // rdoBtnEncrypt
            // 
            this.rdoBtnEncrypt.Click += new System.EventHandler(this.cipherRadioButtonChanged);
            // 
            // rdoBtnDecrypt
            // 
            this.rdoBtnDecrypt.Click += new System.EventHandler(this.cipherRadioButtonChanged);
            // 
            // grpCipher
            // 
            this.grpCipher.Location = new System.Drawing.Point(373, 308);
            // 
            // txtKey
            // 
            this.txtKey.Location = new System.Drawing.Point(12, 308);
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(12, 136);
            // 
            // btnRSA
            // 
            this.btnRSA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRSA.Location = new System.Drawing.Point(425, 12);
            this.btnRSA.Name = "btnRSA";
            this.btnRSA.Size = new System.Drawing.Size(47, 23);
            this.btnRSA.TabIndex = 67;
            this.btnRSA.Text = "Back";
            this.btnRSA.UseVisualStyleBackColor = true;
            this.btnRSA.Click += new System.EventHandler(this.btnRSA_Click);
            // 
            // btnSaveToClipboard
            // 
            this.btnSaveToClipboard.Image = global::Cryptographer.Properties.Resources.Editing_Clipboard_icon30;
            this.btnSaveToClipboard.Location = new System.Drawing.Point(432, 1161);
            this.btnSaveToClipboard.Name = "btnSaveToClipboard";
            this.btnSaveToClipboard.Size = new System.Drawing.Size(40, 40);
            this.btnSaveToClipboard.TabIndex = 68;
            this.btnSaveToClipboard.UseVisualStyleBackColor = true;
            this.btnSaveToClipboard.Click += new System.EventHandler(this.btnSaveToClipboard_Click);
            // 
            // lblDescription1
            // 
            this.lblDescription1.AutoSize = true;
            this.lblDescription1.Location = new System.Drawing.Point(9, 12);
            this.lblDescription1.MaximumSize = new System.Drawing.Size(390, 0);
            this.lblDescription1.Name = "lblDescription1";
            this.lblDescription1.Size = new System.Drawing.Size(284, 13);
            this.lblDescription1.TabIndex = 69;
            this.lblDescription1.Text = "First let us choose how we wish for the output data to look.";
            // 
            // lblDescription2
            // 
            this.lblDescription2.AutoSize = true;
            this.lblDescription2.Location = new System.Drawing.Point(9, 102);
            this.lblDescription2.MaximumSize = new System.Drawing.Size(460, 0);
            this.lblDescription2.Name = "lblDescription2";
            this.lblDescription2.Size = new System.Drawing.Size(314, 13);
            this.lblDescription2.TabIndex = 70;
            this.lblDescription2.Text = "To encrypt or decrypt we need some data. Let\'s enter some data.";
            // 
            // lblDescription3
            // 
            this.lblDescription3.AutoSize = true;
            this.lblDescription3.Location = new System.Drawing.Point(9, 259);
            this.lblDescription3.MaximumSize = new System.Drawing.Size(350, 0);
            this.lblDescription3.Name = "lblDescription3";
            this.lblDescription3.Size = new System.Drawing.Size(338, 26);
            this.lblDescription3.TabIndex = 71;
            this.lblDescription3.Text = "The key text box must contain an xml of all the information required for the key." +
    " (If left blank the key will be generated)";
            // 
            // lblDescription4
            // 
            this.lblDescription4.AutoSize = true;
            this.lblDescription4.Location = new System.Drawing.Point(370, 259);
            this.lblDescription4.MaximumSize = new System.Drawing.Size(100, 0);
            this.lblDescription4.Name = "lblDescription4";
            this.lblDescription4.Size = new System.Drawing.Size(95, 39);
            this.lblDescription4.TabIndex = 72;
            this.lblDescription4.Text = "Let\'s choose if we want to encrypt or decrypt or data.";
            // 
            // lstFormula
            // 
            this.lstFormula.FormattingEnabled = true;
            this.lstFormula.Location = new System.Drawing.Point(12, 443);
            this.lstFormula.Name = "lstFormula";
            this.lstFormula.Size = new System.Drawing.Size(453, 108);
            this.lstFormula.TabIndex = 73;
            // 
            // lblDescription5
            // 
            this.lblDescription5.AutoSize = true;
            this.lblDescription5.Location = new System.Drawing.Point(9, 427);
            this.lblDescription5.MaximumSize = new System.Drawing.Size(460, 0);
            this.lblDescription5.Name = "lblDescription5";
            this.lblDescription5.Size = new System.Drawing.Size(238, 13);
            this.lblDescription5.TabIndex = 74;
            this.lblDescription5.Text = "To cipher our data we use the following formulas:";
            // 
            // lblP
            // 
            this.lblP.AutoSize = true;
            this.lblP.Location = new System.Drawing.Point(12, 577);
            this.lblP.Name = "lblP";
            this.lblP.Size = new System.Drawing.Size(14, 13);
            this.lblP.TabIndex = 76;
            this.lblP.Text = "P";
            // 
            // txtP
            // 
            this.txtP.Location = new System.Drawing.Point(12, 593);
            this.txtP.Multiline = true;
            this.txtP.Name = "txtP";
            this.txtP.ReadOnly = true;
            this.txtP.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtP.Size = new System.Drawing.Size(220, 120);
            this.txtP.TabIndex = 75;
            // 
            // lblQ
            // 
            this.lblQ.AutoSize = true;
            this.lblQ.Location = new System.Drawing.Point(245, 577);
            this.lblQ.Name = "lblQ";
            this.lblQ.Size = new System.Drawing.Size(15, 13);
            this.lblQ.TabIndex = 78;
            this.lblQ.Text = "Q";
            // 
            // txtQ
            // 
            this.txtQ.Location = new System.Drawing.Point(245, 593);
            this.txtQ.Multiline = true;
            this.txtQ.Name = "txtQ";
            this.txtQ.ReadOnly = true;
            this.txtQ.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtQ.Size = new System.Drawing.Size(220, 120);
            this.txtQ.TabIndex = 77;
            // 
            // lblN
            // 
            this.lblN.AutoSize = true;
            this.lblN.Location = new System.Drawing.Point(12, 715);
            this.lblN.Name = "lblN";
            this.lblN.Size = new System.Drawing.Size(15, 13);
            this.lblN.TabIndex = 80;
            this.lblN.Text = "N";
            // 
            // txtN
            // 
            this.txtN.Location = new System.Drawing.Point(12, 731);
            this.txtN.Multiline = true;
            this.txtN.Name = "txtN";
            this.txtN.ReadOnly = true;
            this.txtN.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtN.Size = new System.Drawing.Size(220, 120);
            this.txtN.TabIndex = 79;
            // 
            // lblD
            // 
            this.lblD.AutoSize = true;
            this.lblD.Location = new System.Drawing.Point(245, 860);
            this.lblD.Name = "lblD";
            this.lblD.Size = new System.Drawing.Size(15, 13);
            this.lblD.TabIndex = 84;
            this.lblD.Text = "D";
            // 
            // txtD
            // 
            this.txtD.Location = new System.Drawing.Point(245, 876);
            this.txtD.Multiline = true;
            this.txtD.Name = "txtD";
            this.txtD.ReadOnly = true;
            this.txtD.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtD.Size = new System.Drawing.Size(220, 120);
            this.txtD.TabIndex = 83;
            // 
            // lblE
            // 
            this.lblE.AutoSize = true;
            this.lblE.Location = new System.Drawing.Point(12, 860);
            this.lblE.Name = "lblE";
            this.lblE.Size = new System.Drawing.Size(14, 13);
            this.lblE.TabIndex = 82;
            this.lblE.Text = "E";
            // 
            // txtE
            // 
            this.txtE.Location = new System.Drawing.Point(12, 876);
            this.txtE.Multiline = true;
            this.txtE.Name = "txtE";
            this.txtE.ReadOnly = true;
            this.txtE.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtE.Size = new System.Drawing.Size(220, 120);
            this.txtE.TabIndex = 81;
            // 
            // lblDescription6
            // 
            this.lblDescription6.AutoSize = true;
            this.lblDescription6.Location = new System.Drawing.Point(9, 554);
            this.lblDescription6.MaximumSize = new System.Drawing.Size(460, 0);
            this.lblDescription6.Name = "lblDescription6";
            this.lblDescription6.Size = new System.Drawing.Size(114, 13);
            this.lblDescription6.TabIndex = 85;
            this.lblDescription6.Text = "Here are our variables:";
            // 
            // lblDescription7
            // 
            this.lblDescription7.AutoSize = true;
            this.lblDescription7.Location = new System.Drawing.Point(9, 999);
            this.lblDescription7.MaximumSize = new System.Drawing.Size(460, 0);
            this.lblDescription7.Name = "lblDescription7";
            this.lblDescription7.Size = new System.Drawing.Size(94, 13);
            this.lblDescription7.TabIndex = 86;
            this.lblDescription7.Text = "Here is our Result:";
            // 
            // frmRSAInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 733);
            this.Controls.Add(this.lblDescription7);
            this.Controls.Add(this.lblDescription6);
            this.Controls.Add(this.lblD);
            this.Controls.Add(this.txtD);
            this.Controls.Add(this.lblE);
            this.Controls.Add(this.txtE);
            this.Controls.Add(this.lblN);
            this.Controls.Add(this.txtN);
            this.Controls.Add(this.lblQ);
            this.Controls.Add(this.txtQ);
            this.Controls.Add(this.lblP);
            this.Controls.Add(this.txtP);
            this.Controls.Add(this.lblDescription5);
            this.Controls.Add(this.lstFormula);
            this.Controls.Add(this.lblDescription4);
            this.Controls.Add(this.lblDescription3);
            this.Controls.Add(this.lblDescription2);
            this.Controls.Add(this.lblDescription1);
            this.Controls.Add(this.btnSaveToClipboard);
            this.Controls.Add(this.btnRSA);
            this.Name = "frmRSAInfo";
            this.Text = "RSA cipher info";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmRSAInfo_FormClosing);
            this.Load += new System.EventHandler(this.frmRSAInfo_Load);
            this.Controls.SetChildIndex(this.txtMessage, 0);
            this.Controls.SetChildIndex(this.txtKey, 0);
            this.Controls.SetChildIndex(this.grpCipher, 0);
            this.Controls.SetChildIndex(this.txtResult, 0);
            this.Controls.SetChildIndex(this.lblMessage, 0);
            this.Controls.SetChildIndex(this.lblKey, 0);
            this.Controls.SetChildIndex(this.lblResult, 0);
            this.Controls.SetChildIndex(this.btnCipher, 0);
            this.Controls.SetChildIndex(this.grpDisplayVlaueMode, 0);
            this.Controls.SetChildIndex(this.btnRSA, 0);
            this.Controls.SetChildIndex(this.btnSaveToClipboard, 0);
            this.Controls.SetChildIndex(this.lblDescription1, 0);
            this.Controls.SetChildIndex(this.lblDescription2, 0);
            this.Controls.SetChildIndex(this.lblDescription3, 0);
            this.Controls.SetChildIndex(this.lblDescription4, 0);
            this.Controls.SetChildIndex(this.lstFormula, 0);
            this.Controls.SetChildIndex(this.lblDescription5, 0);
            this.Controls.SetChildIndex(this.txtP, 0);
            this.Controls.SetChildIndex(this.lblP, 0);
            this.Controls.SetChildIndex(this.txtQ, 0);
            this.Controls.SetChildIndex(this.lblQ, 0);
            this.Controls.SetChildIndex(this.txtN, 0);
            this.Controls.SetChildIndex(this.lblN, 0);
            this.Controls.SetChildIndex(this.txtE, 0);
            this.Controls.SetChildIndex(this.lblE, 0);
            this.Controls.SetChildIndex(this.txtD, 0);
            this.Controls.SetChildIndex(this.lblD, 0);
            this.Controls.SetChildIndex(this.lblDescription6, 0);
            this.Controls.SetChildIndex(this.lblDescription7, 0);
            this.grpDisplayVlaueMode.ResumeLayout(false);
            this.grpDisplayVlaueMode.PerformLayout();
            this.grpCipher.ResumeLayout(false);
            this.grpCipher.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRSA;
        private System.Windows.Forms.Button btnSaveToClipboard;
        private System.Windows.Forms.Label lblDescription1;
        private System.Windows.Forms.Label lblDescription2;
        private System.Windows.Forms.Label lblDescription3;
        private System.Windows.Forms.Label lblDescription4;
        private System.Windows.Forms.ListBox lstFormula;
        private System.Windows.Forms.Label lblDescription5;
        protected System.Windows.Forms.Label lblP;
        protected System.Windows.Forms.TextBox txtP;
        protected System.Windows.Forms.Label lblQ;
        protected System.Windows.Forms.TextBox txtQ;
        protected System.Windows.Forms.Label lblN;
        protected System.Windows.Forms.TextBox txtN;
        protected System.Windows.Forms.Label lblD;
        protected System.Windows.Forms.TextBox txtD;
        protected System.Windows.Forms.Label lblE;
        protected System.Windows.Forms.TextBox txtE;
        private System.Windows.Forms.Label lblDescription6;
        private System.Windows.Forms.Label lblDescription7;
    }
}
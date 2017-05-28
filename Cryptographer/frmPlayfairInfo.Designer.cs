namespace Cryptographer
{
    partial class frmPlayfairInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPlayfairInfo));
            this.lblDescription1 = new System.Windows.Forms.Label();
            this.lblDescription3 = new System.Windows.Forms.Label();
            this.lblDescription0 = new System.Windows.Forms.Label();
            this.btnCipher = new System.Windows.Forms.Button();
            this.grpCipher = new System.Windows.Forms.GroupBox();
            this.rdoBtnEncrypt = new System.Windows.Forms.RadioButton();
            this.rdoBtnDecrypt = new System.Windows.Forms.RadioButton();
            this.lblDescription4 = new System.Windows.Forms.Label();
            this.lblPairs = new System.Windows.Forms.Label();
            this.lstPairs = new System.Windows.Forms.ListBox();
            this.lblMessageParsedPairs = new System.Windows.Forms.Label();
            this.lblMessageParsed = new System.Windows.Forms.Label();
            this.txtMessageParsedPairs = new System.Windows.Forms.TextBox();
            this.txtMessageParsed = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblKey = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.btnPlayfair = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblDescription2 = new System.Windows.Forms.Label();
            this.grpCipher.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAutoFill
            // 
            this.btnAutoFill.Location = new System.Drawing.Point(445, 312);
            // 
            // btnClearAll
            // 
            this.btnManualFill.Location = new System.Drawing.Point(325, 312);
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(15, 1084);
            this.txtResult.Size = new System.Drawing.Size(525, 100);
            this.txtResult.TabIndex = 32;
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(15, 91);
            this.txtMessage.Size = new System.Drawing.Size(525, 130);
            // 
            // lblDescription1
            // 
            this.lblDescription1.AutoSize = true;
            this.lblDescription1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription1.Location = new System.Drawing.Point(13, 53);
            this.lblDescription1.MaximumSize = new System.Drawing.Size(500, 0);
            this.lblDescription1.Name = "lblDescription1";
            this.lblDescription1.Size = new System.Drawing.Size(225, 15);
            this.lblDescription1.TabIndex = 57;
            this.lblDescription1.Text = "To start off you must choose a message.";
            // 
            // lblDescription3
            // 
            this.lblDescription3.AutoSize = true;
            this.lblDescription3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription3.Location = new System.Drawing.Point(13, 510);
            this.lblDescription3.MaximumSize = new System.Drawing.Size(525, 0);
            this.lblDescription3.Name = "lblDescription3";
            this.lblDescription3.Size = new System.Drawing.Size(522, 105);
            this.lblDescription3.TabIndex = 56;
            this.lblDescription3.Text = resources.GetString("lblDescription3.Text");
            // 
            // lblDescription0
            // 
            this.lblDescription0.AutoSize = true;
            this.lblDescription0.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription0.Location = new System.Drawing.Point(13, 9);
            this.lblDescription0.MaximumSize = new System.Drawing.Size(420, 0);
            this.lblDescription0.Name = "lblDescription0";
            this.lblDescription0.Size = new System.Drawing.Size(402, 30);
            this.lblDescription0.TabIndex = 55;
            this.lblDescription0.Text = "The Playfair cipher uses symbols for its message. And a key containing a 5x5 arra" +
    "y of latin alphabet symbols.";
            // 
            // btnCipher
            // 
            this.btnCipher.Location = new System.Drawing.Point(468, 1036);
            this.btnCipher.Name = "btnCipher";
            this.btnCipher.Size = new System.Drawing.Size(75, 23);
            this.btnCipher.TabIndex = 28;
            this.btnCipher.Text = "Start";
            this.btnCipher.UseVisualStyleBackColor = true;
            this.btnCipher.Click += new System.EventHandler(this.btnCipher_Click);
            // 
            // grpCipher
            // 
            this.grpCipher.Controls.Add(this.rdoBtnEncrypt);
            this.grpCipher.Controls.Add(this.rdoBtnDecrypt);
            this.grpCipher.Location = new System.Drawing.Point(443, 959);
            this.grpCipher.Name = "grpCipher";
            this.grpCipher.Size = new System.Drawing.Size(97, 71);
            this.grpCipher.TabIndex = 26;
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
            // lblDescription4
            // 
            this.lblDescription4.AutoSize = true;
            this.lblDescription4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription4.Location = new System.Drawing.Point(12, 771);
            this.lblDescription4.MaximumSize = new System.Drawing.Size(500, 0);
            this.lblDescription4.Name = "lblDescription4";
            this.lblDescription4.Size = new System.Drawing.Size(498, 45);
            this.lblDescription4.TabIndex = 58;
            this.lblDescription4.Text = "After that we devide our parsed message into blocks of two symbols. And start enc" +
    "rypting or decrypting our message by swapping the pairs of symbols in our messag" +
    "e based on our table. E.g. ";
            // 
            // lblPairs
            // 
            this.lblPairs.AutoSize = true;
            this.lblPairs.Location = new System.Drawing.Point(14, 943);
            this.lblPairs.Name = "lblPairs";
            this.lblPairs.Size = new System.Drawing.Size(207, 13);
            this.lblPairs.TabIndex = 50;
            this.lblPairs.Text = "List of pairs and their swapped equivalents";
            // 
            // lstPairs
            // 
            this.lstPairs.FormattingEnabled = true;
            this.lstPairs.Location = new System.Drawing.Point(15, 959);
            this.lstPairs.MultiColumn = true;
            this.lstPairs.Name = "lstPairs";
            this.lstPairs.Size = new System.Drawing.Size(422, 95);
            this.lstPairs.TabIndex = 38;
            // 
            // lblMessageParsedPairs
            // 
            this.lblMessageParsedPairs.AutoSize = true;
            this.lblMessageParsedPairs.Location = new System.Drawing.Point(10, 824);
            this.lblMessageParsedPairs.Name = "lblMessageParsedPairs";
            this.lblMessageParsedPairs.Size = new System.Drawing.Size(181, 13);
            this.lblMessageParsedPairs.TabIndex = 48;
            this.lblMessageParsedPairs.Text = "Parsed message with its pairs split up";
            // 
            // lblMessageParsed
            // 
            this.lblMessageParsed.AutoSize = true;
            this.lblMessageParsed.Location = new System.Drawing.Point(10, 622);
            this.lblMessageParsed.Name = "lblMessageParsed";
            this.lblMessageParsed.Size = new System.Drawing.Size(85, 13);
            this.lblMessageParsed.TabIndex = 47;
            this.lblMessageParsed.Text = "Parsed message";
            // 
            // txtMessageParsedPairs
            // 
            this.txtMessageParsedPairs.Location = new System.Drawing.Point(10, 840);
            this.txtMessageParsedPairs.Multiline = true;
            this.txtMessageParsedPairs.Name = "txtMessageParsedPairs";
            this.txtMessageParsedPairs.ReadOnly = true;
            this.txtMessageParsedPairs.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMessageParsedPairs.Size = new System.Drawing.Size(525, 100);
            this.txtMessageParsedPairs.TabIndex = 37;
            // 
            // txtMessageParsed
            // 
            this.txtMessageParsed.Location = new System.Drawing.Point(10, 638);
            this.txtMessageParsed.Multiline = true;
            this.txtMessageParsed.Name = "txtMessageParsed";
            this.txtMessageParsed.ReadOnly = true;
            this.txtMessageParsed.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMessageParsed.Size = new System.Drawing.Size(525, 130);
            this.txtMessageParsed.TabIndex = 36;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(15, 1064);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(37, 13);
            this.lblResult.TabIndex = 44;
            this.lblResult.Text = "Result";
            // 
            // lblKey
            // 
            this.lblKey.AutoSize = true;
            this.lblKey.Location = new System.Drawing.Point(13, 188);
            this.lblKey.Name = "lblKey";
            this.lblKey.Size = new System.Drawing.Size(25, 13);
            this.lblKey.TabIndex = 43;
            this.lblKey.Text = "Key";
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(16, 75);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(50, 13);
            this.lblMessage.TabIndex = 42;
            this.lblMessage.Text = "Message";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(16, 9);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(0, 13);
            this.lblDescription.TabIndex = 38;
            // 
            // btnPlayfair
            // 
            this.btnPlayfair.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlayfair.Location = new System.Drawing.Point(493, 9);
            this.btnPlayfair.Name = "btnPlayfair";
            this.btnPlayfair.Size = new System.Drawing.Size(48, 23);
            this.btnPlayfair.TabIndex = 35;
            this.btnPlayfair.Text = "Back";
            this.btnPlayfair.UseVisualStyleBackColor = true;
            this.btnPlayfair.Click += new System.EventHandler(this.btnVigenere_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 334);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 61;
            // 
            // lblDescription2
            // 
            this.lblDescription2.AutoSize = true;
            this.lblDescription2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription2.Location = new System.Drawing.Point(16, 230);
            this.lblDescription2.MaximumSize = new System.Drawing.Size(450, 0);
            this.lblDescription2.Name = "lblDescription2";
            this.lblDescription2.Size = new System.Drawing.Size(437, 15);
            this.lblDescription2.TabIndex = 62;
            this.lblDescription2.Text = "Then we fill the key with symbols from the latin alphabet (except the symbol \"J\")" +
    ".";
            // 
            // frmPlayfairInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 741);
            this.Controls.Add(this.lblDescription2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnPlayfair);
            this.Controls.Add(this.lblDescription1);
            this.Controls.Add(this.lblDescription3);
            this.Controls.Add(this.lblDescription0);
            this.Controls.Add(this.btnCipher);
            this.Controls.Add(this.grpCipher);
            this.Controls.Add(this.lblDescription4);
            this.Controls.Add(this.lblPairs);
            this.Controls.Add(this.lstPairs);
            this.Controls.Add(this.lblMessageParsedPairs);
            this.Controls.Add(this.lblMessageParsed);
            this.Controls.Add(this.txtMessageParsedPairs);
            this.Controls.Add(this.txtMessageParsed);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblKey);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.lblDescription);
            this.Name = "frmPlayfairInfo";
            this.Text = "Playfair cipher info";
            this.Load += new System.EventHandler(this.frmPlayfairInfo_Load);
            this.Controls.SetChildIndex(this.lblDescription, 0);
            this.Controls.SetChildIndex(this.lblMessage, 0);
            this.Controls.SetChildIndex(this.lblKey, 0);
            this.Controls.SetChildIndex(this.lblResult, 0);
            this.Controls.SetChildIndex(this.txtMessageParsed, 0);
            this.Controls.SetChildIndex(this.txtMessageParsedPairs, 0);
            this.Controls.SetChildIndex(this.lblMessageParsed, 0);
            this.Controls.SetChildIndex(this.lblMessageParsedPairs, 0);
            this.Controls.SetChildIndex(this.lstPairs, 0);
            this.Controls.SetChildIndex(this.lblPairs, 0);
            this.Controls.SetChildIndex(this.lblDescription4, 0);
            this.Controls.SetChildIndex(this.grpCipher, 0);
            this.Controls.SetChildIndex(this.btnCipher, 0);
            this.Controls.SetChildIndex(this.lblDescription0, 0);
            this.Controls.SetChildIndex(this.lblDescription3, 0);
            this.Controls.SetChildIndex(this.lblDescription1, 0);
            this.Controls.SetChildIndex(this.txtMessage, 0);
            this.Controls.SetChildIndex(this.txtResult, 0);
            this.Controls.SetChildIndex(this.btnManualFill, 0);
            this.Controls.SetChildIndex(this.btnAutoFill, 0);
            this.Controls.SetChildIndex(this.btnPlayfair, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.lblDescription2, 0);
            this.grpCipher.ResumeLayout(false);
            this.grpCipher.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblDescription1;
        private System.Windows.Forms.Label lblDescription3;
        private System.Windows.Forms.Label lblDescription0;
        private System.Windows.Forms.Button btnCipher;
        private System.Windows.Forms.GroupBox grpCipher;
        private System.Windows.Forms.RadioButton rdoBtnEncrypt;
        private System.Windows.Forms.RadioButton rdoBtnDecrypt;
        private System.Windows.Forms.Label lblDescription4;
        private System.Windows.Forms.Label lblPairs;
        private System.Windows.Forms.ListBox lstPairs;
        private System.Windows.Forms.Label lblMessageParsedPairs;
        private System.Windows.Forms.Label lblMessageParsed;
        private System.Windows.Forms.TextBox txtMessageParsedPairs;
        private System.Windows.Forms.TextBox txtMessageParsed;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblKey;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Button btnPlayfair;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblDescription2;
    }
}
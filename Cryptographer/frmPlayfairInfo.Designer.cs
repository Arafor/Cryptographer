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
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(331, 427);
            this.btnImport.TabIndex = 28;
            // 
            // btnAutoFill
            // 
            this.btnAutoFill.Location = new System.Drawing.Point(464, 362);
            this.btnAutoFill.TabIndex = 27;
            // 
            // btnClearAll
            // 
            this.btnClearAll.Location = new System.Drawing.Point(331, 362);
            this.btnClearAll.TabIndex = 26;
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(464, 427);
            this.btnExport.TabIndex = 29;
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(16, 1386);
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(15, 91);
            this.txtMessage.Size = new System.Drawing.Size(525, 130);
            this.txtMessage.TabIndex = 0;
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
            this.lblDescription3.Location = new System.Drawing.Point(13, 560);
            this.lblDescription3.MaximumSize = new System.Drawing.Size(525, 0);
            this.lblDescription3.Name = "lblDescription3";
            this.lblDescription3.Size = new System.Drawing.Size(524, 90);
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
            this.lblDescription0.Size = new System.Drawing.Size(415, 30);
            this.lblDescription0.TabIndex = 55;
            this.lblDescription0.Text = "The Playfair cipher is an old simplistic cipher that uses text values for its mes" +
    "sage and a table containing letters from the english alphabet as its key.";
            // 
            // btnCipher
            // 
            this.btnCipher.Location = new System.Drawing.Point(438, 1332);
            this.btnCipher.Name = "btnCipher";
            this.btnCipher.Size = new System.Drawing.Size(75, 23);
            this.btnCipher.TabIndex = 32;
            this.btnCipher.Text = "Cipher";
            this.btnCipher.UseVisualStyleBackColor = true;
            this.btnCipher.Click += new System.EventHandler(this.btnCipher_Click);
            // 
            // grpCipher
            // 
            this.grpCipher.Controls.Add(this.rdoBtnEncrypt);
            this.grpCipher.Controls.Add(this.rdoBtnDecrypt);
            this.grpCipher.Location = new System.Drawing.Point(413, 1255);
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
            this.rdoBtnEncrypt.TabIndex = 30;
            this.rdoBtnEncrypt.Text = "Encrypt";
            this.rdoBtnEncrypt.UseVisualStyleBackColor = true;
            // 
            // rdoBtnDecrypt
            // 
            this.rdoBtnDecrypt.AutoSize = true;
            this.rdoBtnDecrypt.Location = new System.Drawing.Point(6, 42);
            this.rdoBtnDecrypt.Name = "rdoBtnDecrypt";
            this.rdoBtnDecrypt.Size = new System.Drawing.Size(62, 17);
            this.rdoBtnDecrypt.TabIndex = 31;
            this.rdoBtnDecrypt.Text = "Decrypt";
            this.rdoBtnDecrypt.UseVisualStyleBackColor = true;
            // 
            // lblDescription4
            // 
            this.lblDescription4.AutoSize = true;
            this.lblDescription4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription4.Location = new System.Drawing.Point(13, 822);
            this.lblDescription4.MaximumSize = new System.Drawing.Size(500, 0);
            this.lblDescription4.Name = "lblDescription4";
            this.lblDescription4.Size = new System.Drawing.Size(499, 30);
            this.lblDescription4.TabIndex = 58;
            this.lblDescription4.Text = "After that we devide our parsed message in pairs of two. And start swapping the l" +
    "etters from our message based on our table. E.g. ";
            // 
            // lblPairs
            // 
            this.lblPairs.AutoSize = true;
            this.lblPairs.Location = new System.Drawing.Point(15, 994);
            this.lblPairs.Name = "lblPairs";
            this.lblPairs.Size = new System.Drawing.Size(207, 13);
            this.lblPairs.TabIndex = 50;
            this.lblPairs.Text = "List of pairs and their swapped equivalents";
            // 
            // lstPairs
            // 
            this.lstPairs.FormattingEnabled = true;
            this.lstPairs.Location = new System.Drawing.Point(16, 1010);
            this.lstPairs.MultiColumn = true;
            this.lstPairs.Name = "lstPairs";
            this.lstPairs.Size = new System.Drawing.Size(525, 95);
            this.lstPairs.TabIndex = 52;
            // 
            // lblMessageParsedPairs
            // 
            this.lblMessageParsedPairs.AutoSize = true;
            this.lblMessageParsedPairs.Location = new System.Drawing.Point(16, 862);
            this.lblMessageParsedPairs.Name = "lblMessageParsedPairs";
            this.lblMessageParsedPairs.Size = new System.Drawing.Size(175, 13);
            this.lblMessageParsedPairs.TabIndex = 48;
            this.lblMessageParsedPairs.Text = "Parsed message with its pairs slit up";
            // 
            // lblMessageParsed
            // 
            this.lblMessageParsed.AutoSize = true;
            this.lblMessageParsed.Location = new System.Drawing.Point(16, 663);
            this.lblMessageParsed.Name = "lblMessageParsed";
            this.lblMessageParsed.Size = new System.Drawing.Size(85, 13);
            this.lblMessageParsed.TabIndex = 47;
            this.lblMessageParsed.Text = "Parsed message";
            // 
            // txtMessageParsedPairs
            // 
            this.txtMessageParsedPairs.Location = new System.Drawing.Point(16, 878);
            this.txtMessageParsedPairs.Multiline = true;
            this.txtMessageParsedPairs.Name = "txtMessageParsedPairs";
            this.txtMessageParsedPairs.ReadOnly = true;
            this.txtMessageParsedPairs.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMessageParsedPairs.Size = new System.Drawing.Size(525, 100);
            this.txtMessageParsedPairs.TabIndex = 50;
            // 
            // txtMessageParsed
            // 
            this.txtMessageParsed.Location = new System.Drawing.Point(16, 679);
            this.txtMessageParsed.Multiline = true;
            this.txtMessageParsed.Name = "txtMessageParsed";
            this.txtMessageParsed.ReadOnly = true;
            this.txtMessageParsed.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMessageParsed.Size = new System.Drawing.Size(525, 130);
            this.txtMessageParsed.TabIndex = 50;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(16, 1366);
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
            this.btnPlayfair.Location = new System.Drawing.Point(482, 12);
            this.btnPlayfair.Name = "btnPlayfair";
            this.btnPlayfair.Size = new System.Drawing.Size(70, 23);
            this.btnPlayfair.TabIndex = 60;
            this.btnPlayfair.Text = "<= Back";
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
            this.lblDescription2.Location = new System.Drawing.Point(16, 247);
            this.lblDescription2.MaximumSize = new System.Drawing.Size(450, 0);
            this.lblDescription2.Name = "lblDescription2";
            this.lblDescription2.Size = new System.Drawing.Size(439, 15);
            this.lblDescription2.TabIndex = 62;
            this.lblDescription2.Text = "Then we fill the table with letters from the english alphabet (except the letter " +
    "\"J\").";
            // 
            // frmPlayfairInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 961);
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
            this.Text = "Cryptographer - Playfair cipher info";
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
            this.Controls.SetChildIndex(this.btnExport, 0);
            this.Controls.SetChildIndex(this.btnClearAll, 0);
            this.Controls.SetChildIndex(this.btnAutoFill, 0);
            this.Controls.SetChildIndex(this.btnImport, 0);
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
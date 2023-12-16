namespace RSAproject
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            btnGeneratePrime = new Button();
            tbPrimeNumberQ = new TextBox();
            tbPrimeNumberP = new TextBox();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            tbPrivateKey = new TextBox();
            tbPublicKey = new TextBox();
            tbPhiN = new TextBox();
            tbRSAmodulusN = new TextBox();
            groupBox3 = new GroupBox();
            label11 = new Label();
            rdoNumber = new RadioButton();
            rdoText = new RadioButton();
            label10 = new Label();
            label3 = new Label();
            tbOutput = new TextBox();
            tbInput = new TextBox();
            btnEncrypt = new Button();
            btnDecrypt = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnGeneratePrime);
            groupBox1.Controls.Add(tbPrimeNumberQ);
            groupBox1.Controls.Add(tbPrimeNumberP);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(613, 85);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Prime number entry";
            // 
            // btnGeneratePrime
            // 
            btnGeneratePrime.Location = new Point(433, 33);
            btnGeneratePrime.Name = "btnGeneratePrime";
            btnGeneratePrime.Size = new Size(162, 23);
            btnGeneratePrime.TabIndex = 4;
            btnGeneratePrime.Text = "Generate prime numbers ...";
            btnGeneratePrime.UseVisualStyleBackColor = true;
            btnGeneratePrime.Click += btnGeneratePrime_Click;
            // 
            // tbPrimeNumberQ
            // 
            tbPrimeNumberQ.BackColor = SystemColors.ButtonHighlight;
            tbPrimeNumberQ.Location = new Point(153, 49);
            tbPrimeNumberQ.Name = "tbPrimeNumberQ";
            tbPrimeNumberQ.Size = new Size(263, 23);
            tbPrimeNumberQ.TabIndex = 3;
            tbPrimeNumberQ.TextChanged += tbPrimeNumberQ_TextChanged;
            // 
            // tbPrimeNumberP
            // 
            tbPrimeNumberP.BackColor = SystemColors.ButtonHighlight;
            tbPrimeNumberP.Location = new Point(153, 24);
            tbPrimeNumberP.Name = "tbPrimeNumberP";
            tbPrimeNumberP.Size = new Size(263, 23);
            tbPrimeNumberP.TabIndex = 2;
            tbPrimeNumberP.TextChanged += tbPrimeNumberP_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 52);
            label2.Name = "label2";
            label2.Size = new Size(93, 15);
            label2.TabIndex = 1;
            label2.Text = "Prime number q";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 24);
            label1.Name = "label1";
            label1.Size = new Size(93, 15);
            label1.TabIndex = 0;
            label1.Text = "Prime number p";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(tbPrivateKey);
            groupBox2.Controls.Add(tbPublicKey);
            groupBox2.Controls.Add(tbPhiN);
            groupBox2.Controls.Add(tbRSAmodulusN);
            groupBox2.Location = new Point(12, 103);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(613, 195);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "RSA parameters";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(430, 79);
            label9.Name = "label9";
            label9.Size = new Size(46, 15);
            label9.TabIndex = 9;
            label9.Text = "(secret)";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(430, 41);
            label8.Name = "label8";
            label8.Size = new Size(48, 15);
            label8.TabIndex = 8;
            label8.Text = "(public)";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(35, 157);
            label7.Name = "label7";
            label7.Size = new Size(74, 15);
            label7.TabIndex = 7;
            label7.Text = "Private key d";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(35, 119);
            label6.Name = "label6";
            label6.Size = new Size(70, 15);
            label6.TabIndex = 6;
            label6.Text = "Public key e";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(35, 79);
            label5.Name = "label5";
            label5.Size = new Size(106, 15);
            label5.TabIndex = 5;
            label5.Text = "phi(N)=(p-1)*(q-1)";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(35, 41);
            label4.Name = "label4";
            label4.Size = new Size(90, 15);
            label4.TabIndex = 4;
            label4.Text = "RSA modulus N";
            // 
            // tbPrivateKey
            // 
            tbPrivateKey.BackColor = SystemColors.ButtonHighlight;
            tbPrivateKey.Location = new Point(153, 154);
            tbPrivateKey.Name = "tbPrivateKey";
            tbPrivateKey.ReadOnly = true;
            tbPrivateKey.Size = new Size(263, 23);
            tbPrivateKey.TabIndex = 3;
            // 
            // tbPublicKey
            // 
            tbPublicKey.BackColor = SystemColors.ButtonHighlight;
            tbPublicKey.Location = new Point(153, 116);
            tbPublicKey.Name = "tbPublicKey";
            tbPublicKey.Size = new Size(263, 23);
            tbPublicKey.TabIndex = 2;
            tbPublicKey.Text = "65537";
            // 
            // tbPhiN
            // 
            tbPhiN.BackColor = SystemColors.ButtonHighlight;
            tbPhiN.Location = new Point(153, 76);
            tbPhiN.Name = "tbPhiN";
            tbPhiN.ReadOnly = true;
            tbPhiN.Size = new Size(263, 23);
            tbPhiN.TabIndex = 1;
            // 
            // tbRSAmodulusN
            // 
            tbRSAmodulusN.BackColor = SystemColors.ButtonHighlight;
            tbRSAmodulusN.Location = new Point(153, 38);
            tbRSAmodulusN.Name = "tbRSAmodulusN";
            tbRSAmodulusN.ReadOnly = true;
            tbRSAmodulusN.Size = new Size(263, 23);
            tbRSAmodulusN.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label11);
            groupBox3.Controls.Add(rdoNumber);
            groupBox3.Controls.Add(rdoText);
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(tbOutput);
            groupBox3.Controls.Add(tbInput);
            groupBox3.Location = new Point(12, 304);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(613, 197);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "RSA encryption";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(64, 28);
            label11.Name = "label11";
            label11.Size = new Size(49, 15);
            label11.TabIndex = 6;
            label11.Text = "Input as";
            // 
            // rdoNumber
            // 
            rdoNumber.AutoSize = true;
            rdoNumber.Location = new Point(219, 26);
            rdoNumber.Name = "rdoNumber";
            rdoNumber.Size = new Size(74, 19);
            rdoNumber.TabIndex = 5;
            rdoNumber.Text = "Numbers";
            rdoNumber.UseVisualStyleBackColor = true;
            // 
            // rdoText
            // 
            rdoText.AutoSize = true;
            rdoText.Checked = true;
            rdoText.Location = new Point(153, 26);
            rdoText.Name = "rdoText";
            rdoText.Size = new Size(46, 19);
            rdoText.TabIndex = 4;
            rdoText.TabStop = true;
            rdoText.Text = "Text";
            rdoText.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(65, 99);
            label10.Name = "label10";
            label10.Size = new Size(45, 15);
            label10.TabIndex = 3;
            label10.Text = "Output";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(64, 50);
            label3.Name = "label3";
            label3.Size = new Size(35, 15);
            label3.TabIndex = 2;
            label3.Text = "Input";
            // 
            // tbOutput
            // 
            tbOutput.Location = new Point(64, 117);
            tbOutput.Name = "tbOutput";
            tbOutput.Size = new Size(495, 23);
            tbOutput.TabIndex = 1;
            // 
            // tbInput
            // 
            tbInput.Location = new Point(64, 68);
            tbInput.Name = "tbInput";
            tbInput.Size = new Size(495, 23);
            tbInput.TabIndex = 0;
            // 
            // btnEncrypt
            // 
            btnEncrypt.Location = new Point(165, 507);
            btnEncrypt.Name = "btnEncrypt";
            btnEncrypt.Size = new Size(75, 23);
            btnEncrypt.TabIndex = 4;
            btnEncrypt.Text = "Encrypt";
            btnEncrypt.UseVisualStyleBackColor = true;
            btnEncrypt.Click += btnEncrypt_Click;
            // 
            // btnDecrypt
            // 
            btnDecrypt.Location = new Point(413, 507);
            btnDecrypt.Name = "btnDecrypt";
            btnDecrypt.Size = new Size(75, 23);
            btnDecrypt.TabIndex = 5;
            btnDecrypt.Text = "Decrypt";
            btnDecrypt.UseVisualStyleBackColor = true;
            btnDecrypt.Click += btnDecrypt_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(649, 538);
            Controls.Add(btnDecrypt);
            Controls.Add(btnEncrypt);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            MaximizeBox = false;
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Label label2;
        private Label label1;
        private Button btnGeneratePrime;
        private TextBox tbPrimeNumberQ;
        private TextBox tbPrimeNumberP;
        private TextBox tbPrivateKey;
        private TextBox tbPublicKey;
        private TextBox tbPhiN;
        private TextBox tbRSAmodulusN;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label9;
        private Label label8;
        private TextBox tbOutput;
        private TextBox tbInput;
        private Label label11;
        private RadioButton rdoNumber;
        private RadioButton rdoText;
        private Label label10;
        private Label label3;
        private Button btnEncrypt;
        private Button btnDecrypt;
    }
}

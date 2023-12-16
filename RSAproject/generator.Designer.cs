namespace RSAproject
{
    partial class generator
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
            groupBox1 = new GroupBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tbResp = new TextBox();
            tbULp = new TextBox();
            tbLLp = new TextBox();
            groupBox2 = new GroupBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            tbResq = new TextBox();
            tbULq = new TextBox();
            tbLLq = new TextBox();
            btnGenerate = new Button();
            btnApply = new Button();
            btnCancel = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(tbResp);
            groupBox1.Controls.Add(tbULp);
            groupBox1.Controls.Add(tbLLp);
            groupBox1.Location = new Point(26, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(215, 221);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Prime number p";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(0, 170);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 5;
            label3.Text = "Result";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(0, 107);
            label2.Name = "label2";
            label2.Size = new Size(71, 15);
            label2.TabIndex = 4;
            label2.Text = "Upper limits";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(0, 43);
            label1.Name = "label1";
            label1.Size = new Size(71, 15);
            label1.TabIndex = 3;
            label1.Text = "Lower limits";
            // 
            // tbResp
            // 
            tbResp.Location = new Point(52, 167);
            tbResp.Name = "tbResp";
            tbResp.ReadOnly = true;
            tbResp.Size = new Size(157, 23);
            tbResp.TabIndex = 2;
            // 
            // tbULp
            // 
            tbULp.Location = new Point(77, 104);
            tbULp.Name = "tbULp";
            tbULp.Size = new Size(130, 23);
            tbULp.TabIndex = 1;
            tbULp.Text = "10000";
            // 
            // tbLLp
            // 
            tbLLp.Location = new Point(77, 40);
            tbLLp.Name = "tbLLp";
            tbLLp.Size = new Size(130, 23);
            tbLLp.TabIndex = 0;
            tbLLp.Text = "2";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(tbResq);
            groupBox2.Controls.Add(tbULq);
            groupBox2.Controls.Add(tbLLq);
            groupBox2.Location = new Point(261, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(215, 221);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "Prime number q";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(0, 170);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 5;
            label4.Text = "Result";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(0, 107);
            label5.Name = "label5";
            label5.Size = new Size(71, 15);
            label5.TabIndex = 4;
            label5.Text = "Upper limits";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(0, 43);
            label6.Name = "label6";
            label6.Size = new Size(71, 15);
            label6.TabIndex = 3;
            label6.Text = "Lower limits";
            // 
            // tbResq
            // 
            tbResq.Location = new Point(52, 167);
            tbResq.Name = "tbResq";
            tbResq.ReadOnly = true;
            tbResq.Size = new Size(157, 23);
            tbResq.TabIndex = 2;
            // 
            // tbULq
            // 
            tbULq.Location = new Point(77, 104);
            tbULq.Name = "tbULq";
            tbULq.Size = new Size(130, 23);
            tbULq.TabIndex = 1;
            tbULq.Text = "10000";
            // 
            // tbLLq
            // 
            tbLLq.Location = new Point(77, 40);
            tbLLq.Name = "tbLLq";
            tbLLq.Size = new Size(130, 23);
            tbLLq.TabIndex = 0;
            tbLLq.Text = "2";
            // 
            // btnGenerate
            // 
            btnGenerate.Location = new Point(26, 259);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(148, 23);
            btnGenerate.TabIndex = 7;
            btnGenerate.Text = "Generate prime numbers";
            btnGenerate.UseVisualStyleBackColor = true;
            btnGenerate.Click += btnGenerate_Click;
            // 
            // btnApply
            // 
            btnApply.Location = new Point(184, 259);
            btnApply.Name = "btnApply";
            btnApply.Size = new Size(148, 23);
            btnApply.TabIndex = 8;
            btnApply.Text = "Apply primes";
            btnApply.UseVisualStyleBackColor = true;
            btnApply.Click += btnApply_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(347, 259);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(102, 23);
            btnCancel.TabIndex = 9;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // generator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(488, 294);
            Controls.Add(btnCancel);
            Controls.Add(btnApply);
            Controls.Add(btnGenerate);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            MaximizeBox = false;
            Name = "generator";
            Text = "generator";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox tbResp;
        private TextBox tbULp;
        private TextBox tbLLp;
        private GroupBox groupBox2;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox tbResq;
        private TextBox tbULq;
        private TextBox tbLLq;
        private Button btnGenerate;
        private Button btnApply;
        private Button btnCancel;
    }
}
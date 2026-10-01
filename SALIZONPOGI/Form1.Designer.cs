namespace SALIZONPOGI
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            label4 = new Label();
            button2 = new Button();
            comboBox1 = new ComboBox();
            label5 = new Label();
            panel1 = new Panel();
            button4 = new Button();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            button3 = new Button();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            button5 = new Button();
            textBox5 = new TextBox();
            label9 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(77, 138);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(192, 31);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(77, 202);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(192, 31);
            textBox2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(31, 41);
            label1.Name = "label1";
            label1.Size = new Size(288, 45);
            label1.TabIndex = 2;
            label1.Text = "ACCOUNT LOG IN";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(82, 110);
            label2.Name = "label2";
            label2.Size = new Size(91, 25);
            label2.TabIndex = 3;
            label2.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(82, 174);
            label3.Name = "label3";
            label3.Size = new Size(87, 25);
            label3.TabIndex = 4;
            label3.Text = "Password";
            label3.Click += label3_Click;
            // 
            // button1
            // 
            button1.Location = new Point(120, 310);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 5;
            button1.Text = "Log In";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(77, 382);
            label4.Name = "label4";
            label4.Size = new Size(197, 25);
            label4.TabIndex = 6;
            label4.Text = "Don't have an account?";
            // 
            // button2
            // 
            button2.Location = new Point(120, 410);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 7;
            button2.Text = "SIGN IN";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "STUDENT", "FACULTY", "ADMIN" });
            comboBox1.Location = new Point(82, 271);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(182, 33);
            comboBox1.TabIndex = 8;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(82, 243);
            label5.Name = "label5";
            label5.Size = new Size(46, 25);
            label5.TabIndex = 9;
            label5.Text = "Role";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDark;
            panel1.Controls.Add(label9);
            panel1.Controls.Add(textBox5);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(textBox4);
            panel1.Location = new Point(31, 41);
            panel1.Name = "panel1";
            panel1.Size = new Size(288, 403);
            panel1.TabIndex = 10;
            panel1.Visible = false;
            // 
            // button4
            // 
            button4.Location = new Point(87, 336);
            button4.Name = "button4";
            button4.Size = new Size(112, 34);
            button4.TabIndex = 12;
            button4.Text = "BACK";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(51, 151);
            label6.Name = "label6";
            label6.Size = new Size(87, 25);
            label6.TabIndex = 11;
            label6.Text = "Password";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(51, 89);
            label7.Name = "label7";
            label7.Size = new Size(91, 25);
            label7.TabIndex = 10;
            label7.Text = "Username";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(70, 45);
            label8.Name = "label8";
            label8.Size = new Size(129, 38);
            label8.TabIndex = 9;
            label8.Text = "SIGN UP";
            // 
            // button3
            // 
            button3.Location = new Point(87, 284);
            button3.Name = "button3";
            button3.Size = new Size(112, 34);
            button3.TabIndex = 8;
            button3.Text = "Sign up ";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(51, 178);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(177, 31);
            textBox3.TabIndex = 7;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(51, 117);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(177, 31);
            textBox4.TabIndex = 6;
            // 
            // button5
            // 
            button5.Location = new Point(177, 156);
            button5.Name = "button5";
            button5.Size = new Size(8, 8);
            button5.TabIndex = 13;
            button5.Text = "button5";
            button5.UseVisualStyleBackColor = true;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(51, 240);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(177, 31);
            textBox5.TabIndex = 14;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(51, 212);
            label9.Name = "label9";
            label9.Size = new Size(156, 25);
            label9.TabIndex = 15;
            label9.Text = "Confirm Password";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(350, 472);
            Controls.Add(panel1);
            Controls.Add(label5);
            Controls.Add(comboBox1);
            Controls.Add(button2);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private Label label4;
        private Button button2;
        private ComboBox comboBox1;
        private Label label5;
        private Panel panel1;
        private Label label6;
        private Label label7;
        private Label label8;
        private Button button3;
        private TextBox textBox3;
        private TextBox textBox4;
        private Button button4;
        private Label label9;
        private TextBox textBox5;
        private Button button5;
    }
}

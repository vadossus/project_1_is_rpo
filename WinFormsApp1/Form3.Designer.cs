namespace WinFormsApp1
{
    partial class Form3
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(46, 34);
            label1.Name = "label1";
            label1.Size = new Size(91, 25);
            label1.TabIndex = 0;
            label1.Text = "Фамилия";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F);
            label2.Location = new Point(85, 76);
            label2.Name = "label2";
            label2.Size = new Size(49, 25);
            label2.TabIndex = 1;
            label2.Text = "Имя";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F);
            label3.Location = new Point(71, 119);
            label3.Name = "label3";
            label3.Size = new Size(65, 25);
            label3.TabIndex = 2;
            label3.Text = "Логин";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F);
            label4.Location = new Point(59, 164);
            label4.Name = "label4";
            label4.Size = new Size(78, 25);
            label4.TabIndex = 4;
            label4.Text = "Пароль";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F);
            label5.Location = new Point(71, 212);
            label5.Name = "label5";
            label5.Size = new Size(66, 25);
            label5.TabIndex = 3;
            label5.Text = "Почта";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(156, 34);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(245, 23);
            textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(156, 78);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(245, 23);
            textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(156, 164);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(245, 23);
            textBox3.TabIndex = 8;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(156, 120);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(245, 23);
            textBox4.TabIndex = 7;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(156, 212);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(245, 23);
            textBox5.TabIndex = 9;
            // 
            // button1
            // 
            button1.Location = new Point(140, 265);
            button1.Name = "button1";
            button1.Size = new Size(204, 43);
            button1.TabIndex = 10;
            button1.Text = "Создать";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(489, 330);
            Controls.Add(button1);
            Controls.Add(textBox5);
            Controls.Add(textBox3);
            Controls.Add(textBox4);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form3";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private Button button1;
    }
}
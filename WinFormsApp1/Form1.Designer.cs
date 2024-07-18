namespace WinFormsApp1
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
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button2 = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(172, 156);
            button1.Name = "button1";
            button1.Size = new Size(120, 48);
            button1.TabIndex = 0;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(102, 48);
            label1.Name = "label1";
            label1.Size = new Size(64, 24);
            label1.TabIndex = 1;
            label1.Text = "user：";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(56, 101);
            label2.Name = "label2";
            label2.Size = new Size(110, 24);
            label2.TabIndex = 2;
            label2.Text = "password：";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(172, 45);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "用户名不能为空";
            textBox1.Size = new Size(289, 30);
            textBox1.TabIndex = 3;
            textBox1.ImeMode = ImeMode.Disable;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(172, 98);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(289, 30);
            textBox2.TabIndex = 3;
            textBox2.UseSystemPasswordChar = true;
            textBox2.TextChanged += textBox2_TextChanged;
            textBox1.ImeMode = ImeMode.Disable;
            // 
            // button2
            // 
            button2.Location = new Point(341, 156);
            button2.Name = "button2";
            button2.Size = new Size(120, 48);
            button2.TabIndex = 0;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(56, 9);
            label3.Name = "label3";
            label3.Size = new Size(63, 24);
            label3.TabIndex = 4;
            label3.Text = "label3";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(607, 268);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            ForeColor = SystemColors.ActiveCaptionText;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button2;
        private Label label3;
    }
}
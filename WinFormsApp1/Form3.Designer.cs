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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            timer1 = new System.Windows.Forms.Timer(components);
            label2 = new Label();
            panel1 = new Panel();
            checkBox2 = new CheckBox();
            checkBox1 = new CheckBox();
            panel2 = new Panel();
            checkBox3 = new CheckBox();
            checkBox4 = new CheckBox();
            button1 = new Button();
            checkBox5 = new CheckBox();
            checkBox6 = new CheckBox();
            checkBox7 = new CheckBox();
            checkBox8 = new CheckBox();
            statusStrip1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("微软雅黑", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(18, 16);
            label1.Name = "label1";
            label1.Size = new Size(54, 27);
            label1.TabIndex = 0;
            label1.Text = "JM1";
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(24, 24);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1 });
            statusStrip1.Location = new Point(0, 472);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(901, 31);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(195, 24);
            toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("微软雅黑", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(18, 14);
            label2.Name = "label2";
            label2.Size = new Size(54, 27);
            label2.TabIndex = 0;
            label2.Text = "JM2";
            // 
            // panel1
            // 
            panel1.Controls.Add(checkBox6);
            panel1.Controls.Add(checkBox5);
            panel1.Controls.Add(checkBox2);
            panel1.Controls.Add(checkBox1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(35, 31);
            panel1.Name = "panel1";
            panel1.Size = new Size(816, 53);
            panel1.TabIndex = 2;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(338, 15);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(127, 28);
            checkBox2.TabIndex = 1;
            checkBox2.Text = "checkBox2";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(184, 15);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(127, 28);
            checkBox1.TabIndex = 1;
            checkBox1.Text = "checkBox1";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(checkBox7);
            panel2.Controls.Add(checkBox8);
            panel2.Controls.Add(checkBox3);
            panel2.Controls.Add(checkBox4);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(35, 90);
            panel2.Name = "panel2";
            panel2.Size = new Size(816, 53);
            panel2.TabIndex = 2;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(338, 13);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(127, 28);
            checkBox3.TabIndex = 1;
            checkBox3.Text = "checkBox3";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(184, 14);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(127, 28);
            checkBox4.TabIndex = 1;
            checkBox4.Text = "checkBox4";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(39, 209);
            button1.Name = "button1";
            button1.Size = new Size(182, 54);
            button1.TabIndex = 3;
            button1.Text = "勾选的项";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // checkBox5
            // 
            checkBox5.AutoSize = true;
            checkBox5.Location = new Point(484, 15);
            checkBox5.Name = "checkBox5";
            checkBox5.Size = new Size(127, 28);
            checkBox5.TabIndex = 1;
            checkBox5.Text = "checkBox5";
            checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            checkBox6.AutoSize = true;
            checkBox6.Location = new Point(632, 15);
            checkBox6.Name = "checkBox6";
            checkBox6.Size = new Size(127, 28);
            checkBox6.TabIndex = 1;
            checkBox6.Text = "checkBox6";
            checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox7
            // 
            checkBox7.AutoSize = true;
            checkBox7.Location = new Point(484, 13);
            checkBox7.Name = "checkBox7";
            checkBox7.Size = new Size(127, 28);
            checkBox7.TabIndex = 1;
            checkBox7.Text = "checkBox7";
            checkBox7.UseVisualStyleBackColor = true;
            // 
            // checkBox8
            // 
            checkBox8.AutoSize = true;
            checkBox8.Location = new Point(632, 14);
            checkBox8.Name = "checkBox8";
            checkBox8.Size = new Size(127, 28);
            checkBox8.TabIndex = 1;
            checkBox8.Text = "checkBox8";
            checkBox8.UseVisualStyleBackColor = true;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(901, 503);
            Controls.Add(button1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(statusStrip1);
            Name = "Form3";
            Text = "Form3";
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Label label1;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Timer timer1;
        public Label label2;
        private Panel panel1;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private Panel panel2;
        private CheckBox checkBox3;
        private CheckBox checkBox4;
        private CheckBox checkBox6;
        private CheckBox checkBox5;
        private CheckBox checkBox7;
        private CheckBox checkBox8;
        private Button button1;
    }
}
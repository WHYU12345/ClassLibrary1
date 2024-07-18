namespace WinFormsApp1
{
    partial class Form2
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
            menuStrip1 = new MenuStrip();
            jMToolStripMenuItem = new ToolStripMenuItem();
            jM1ToolStripMenuItem = new ToolStripMenuItem();
            jM2ToolStripMenuItem = new ToolStripMenuItem();
            contextMenuStrip1 = new ContextMenuStrip(components);
            我是右键菜单ToolStripMenuItem = new ToolStripMenuItem();
            右键菜单1ToolStripMenuItem = new ToolStripMenuItem();
            右键菜单2ToolStripMenuItem = new ToolStripMenuItem();
            复制ToolStripMenuItem = new ToolStripMenuItem();
            粘贴ToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { jMToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 32);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // jMToolStripMenuItem
            // 
            jMToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { jM1ToolStripMenuItem, jM2ToolStripMenuItem });
            jMToolStripMenuItem.Name = "jMToolStripMenuItem";
            jMToolStripMenuItem.Size = new Size(51, 28);
            jMToolStripMenuItem.Text = "JM";
            // 
            // jM1ToolStripMenuItem
            // 
            jM1ToolStripMenuItem.Name = "jM1ToolStripMenuItem";
            jM1ToolStripMenuItem.Size = new Size(146, 34);
            jM1ToolStripMenuItem.Text = "JM1";
            jM1ToolStripMenuItem.Click += jM1ToolStripMenuItem_Click;
            // 
            // jM2ToolStripMenuItem
            // 
            jM2ToolStripMenuItem.Name = "jM2ToolStripMenuItem";
            jM2ToolStripMenuItem.Size = new Size(146, 34);
            jM2ToolStripMenuItem.Text = "JM2";
            jM2ToolStripMenuItem.Click += jM1ToolStripMenuItem_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(24, 24);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { 我是右键菜单ToolStripMenuItem, 复制ToolStripMenuItem, 粘贴ToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(189, 94);
            // 
            // 我是右键菜单ToolStripMenuItem
            // 
            我是右键菜单ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { 右键菜单1ToolStripMenuItem, 右键菜单2ToolStripMenuItem });
            我是右键菜单ToolStripMenuItem.Name = "我是右键菜单ToolStripMenuItem";
            我是右键菜单ToolStripMenuItem.Size = new Size(240, 30);
            我是右键菜单ToolStripMenuItem.Text = "我是右键菜单";
            // 
            // 右键菜单1ToolStripMenuItem
            // 
            右键菜单1ToolStripMenuItem.Name = "右键菜单1ToolStripMenuItem";
            右键菜单1ToolStripMenuItem.Size = new Size(270, 34);
            右键菜单1ToolStripMenuItem.Text = "右键菜单1";
            右键菜单1ToolStripMenuItem.Click += jM1ToolStripMenuItem_Click;
            // 
            // 右键菜单2ToolStripMenuItem
            // 
            右键菜单2ToolStripMenuItem.Name = "右键菜单2ToolStripMenuItem";
            右键菜单2ToolStripMenuItem.Size = new Size(270, 34);
            右键菜单2ToolStripMenuItem.Text = "右键菜单2";
            右键菜单2ToolStripMenuItem.Click += jM1ToolStripMenuItem_Click;
            // 
            // 复制ToolStripMenuItem
            // 
            复制ToolStripMenuItem.Name = "复制ToolStripMenuItem";
            复制ToolStripMenuItem.Size = new Size(240, 30);
            复制ToolStripMenuItem.Text = "复制";
            // 
            // 粘贴ToolStripMenuItem
            // 
            粘贴ToolStripMenuItem.Name = "粘贴ToolStripMenuItem";
            粘贴ToolStripMenuItem.Size = new Size(240, 30);
            粘贴ToolStripMenuItem.Text = "粘贴";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            ContextMenuStrip = contextMenuStrip1;
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "Form2";
            Text = "Form2";
            FormClosing += Form2_FormClosing;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem jMToolStripMenuItem;
        private ToolStripMenuItem jM1ToolStripMenuItem;
        private ToolStripMenuItem jM2ToolStripMenuItem;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem 我是右键菜单ToolStripMenuItem;
        private ToolStripMenuItem 右键菜单1ToolStripMenuItem;
        private ToolStripMenuItem 右键菜单2ToolStripMenuItem;
        private ToolStripMenuItem 复制ToolStripMenuItem;
        private ToolStripMenuItem 粘贴ToolStripMenuItem;
    }
}
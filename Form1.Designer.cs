using System.Drawing;
using System.Windows.Forms;

namespace HogmuraAudioTester
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            buttonLeft = new Button();
            buttonRight = new Button();
            buttonCenter = new Button();
            menuStrip1 = new MenuStrip();
            toolStripMenuItem1 = new ToolStripMenuItem();
            keepOpenInTrayToolStripMenuItem = new ToolStripMenuItem();
            playRandomHogsToolStripMenuItem = new ToolStripMenuItem();
            quitToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // buttonLeft
            // 
            buttonLeft.BackgroundImage = Properties.Resources.hogmura;
            buttonLeft.BackgroundImageLayout = ImageLayout.Stretch;
            buttonLeft.Dock = DockStyle.Left;
            buttonLeft.Location = new Point(0, 24);
            buttonLeft.Name = "buttonLeft";
            buttonLeft.Size = new Size(80, 137);
            buttonLeft.TabIndex = 0;
            buttonLeft.Text = "LEFT";
            buttonLeft.TextAlign = ContentAlignment.BottomCenter;
            buttonLeft.UseVisualStyleBackColor = true;
            buttonLeft.Click += buttonLeft_Click;
            // 
            // buttonRight
            // 
            buttonRight.BackgroundImage = Properties.Resources.hogmura;
            buttonRight.BackgroundImageLayout = ImageLayout.Stretch;
            buttonRight.Dock = DockStyle.Right;
            buttonRight.Location = new Point(304, 24);
            buttonRight.Name = "buttonRight";
            buttonRight.Size = new Size(80, 137);
            buttonRight.TabIndex = 1;
            buttonRight.Text = "RIGHT";
            buttonRight.TextAlign = ContentAlignment.BottomCenter;
            buttonRight.UseVisualStyleBackColor = true;
            buttonRight.Click += buttonRight_Click;
            // 
            // buttonCenter
            // 
            buttonCenter.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttonCenter.BackgroundImage = Properties.Resources.hogmura;
            buttonCenter.BackgroundImageLayout = ImageLayout.Stretch;
            buttonCenter.Dock = DockStyle.Fill;
            buttonCenter.Location = new Point(0, 24);
            buttonCenter.Name = "buttonCenter";
            buttonCenter.Size = new Size(384, 137);
            buttonCenter.TabIndex = 2;
            buttonCenter.Text = "CENTER";
            buttonCenter.TextAlign = ContentAlignment.BottomCenter;
            buttonCenter.UseVisualStyleBackColor = true;
            buttonCenter.Click += buttonCenter_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(384, 24);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { keepOpenInTrayToolStripMenuItem, playRandomHogsToolStripMenuItem, quitToolStripMenuItem });
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(61, 20);
            toolStripMenuItem1.Text = "Settings";
            // 
            // keepOpenInTrayToolStripMenuItem
            // 
            keepOpenInTrayToolStripMenuItem.CheckOnClick = true;
            keepOpenInTrayToolStripMenuItem.Name = "keepOpenInTrayToolStripMenuItem";
            keepOpenInTrayToolStripMenuItem.Size = new Size(184, 22);
            keepOpenInTrayToolStripMenuItem.Text = "keep Open in  Tray..,";
            keepOpenInTrayToolStripMenuItem.Click += keepOpenInTrayToolStripMenuItem_Click;
            // 
            // playRandomHogsToolStripMenuItem
            // 
            playRandomHogsToolStripMenuItem.CheckOnClick = true;
            playRandomHogsToolStripMenuItem.Name = "playRandomHogsToolStripMenuItem";
            playRandomHogsToolStripMenuItem.Size = new Size(184, 22);
            playRandomHogsToolStripMenuItem.Text = "play Random,,  Hogs";
            playRandomHogsToolStripMenuItem.Click += playRandomHogsToolStripMenuItem_Click;
            // 
            // quitToolStripMenuItem
            // 
            quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            quitToolStripMenuItem.Size = new Size(184, 22);
            quitToolStripMenuItem.Text = "Terminate the Hogs,,";
            quitToolStripMenuItem.Click += quitToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 161);
            Controls.Add(buttonLeft);
            Controls.Add(buttonRight);
            Controls.Add(buttonCenter);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Hogmura Audio Test Suite 2024";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonLeft;
        private Button buttonRight;
        private Button buttonCenter;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem keepOpenInTrayToolStripMenuItem;
        private ToolStripMenuItem quitToolStripMenuItem;
        private ToolStripMenuItem playRandomHogsToolStripMenuItem;
    }
}

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
            SuspendLayout();
            // 
            // buttonLeft
            // 
            buttonLeft.BackgroundImage = Properties.Resources.hogmura;
            buttonLeft.BackgroundImageLayout = ImageLayout.Stretch;
            buttonLeft.Dock = DockStyle.Left;
            buttonLeft.Location = new Point(0, 0);
            buttonLeft.Name = "buttonLeft";
            buttonLeft.Size = new Size(80, 161);
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
            buttonRight.Location = new Point(304, 0);
            buttonRight.Name = "buttonRight";
            buttonRight.Size = new Size(80, 161);
            buttonRight.TabIndex = 1;
            buttonRight.Text = "RIGHT";
            buttonRight.TextAlign = ContentAlignment.BottomCenter;
            buttonRight.UseVisualStyleBackColor = true;
            buttonRight.Click += buttonRight_Click;
            // 
            // buttonCenter
            // 
            buttonCenter.BackgroundImage = Properties.Resources.hogmura;
            buttonCenter.BackgroundImageLayout = ImageLayout.Stretch;
            buttonCenter.Dock = DockStyle.Fill;
            buttonCenter.Location = new Point(0, 0);
            buttonCenter.Name = "buttonCenter";
            buttonCenter.Size = new Size(384, 161);
            buttonCenter.TabIndex = 2;
            buttonCenter.Text = "CENTER";
            buttonCenter.TextAlign = ContentAlignment.BottomCenter;
            buttonCenter.UseVisualStyleBackColor = true;
            buttonCenter.Click += buttonCenter_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 161);
            Controls.Add(buttonLeft);
            Controls.Add(buttonRight);
            Controls.Add(buttonCenter);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Hogmura Audio Test Suite 2024";
            ResumeLayout(false);
        }

        #endregion

        private Button buttonLeft;
        private Button buttonRight;
        private Button buttonCenter;
    }
}

using System.Drawing;
using System.Windows.Forms;

namespace PJM_methodology_picker
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.basePanel = new System.Windows.Forms.Panel();
            this.logoBox = new System.Windows.Forms.PictureBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.viewDbBtn = new System.Windows.Forms.Button();
            this.quitBtn = new System.Windows.Forms.Button();
            this.startBtn = new System.Windows.Forms.Button();
            this.basePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoBox)).BeginInit();
            this.SuspendLayout();
            // 
            // basePanel
            // 
            this.basePanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("basePanel.BackgroundImage")));
            this.basePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.basePanel.Controls.Add(this.logoBox);
            this.basePanel.Controls.Add(this.titleLabel);
            this.basePanel.Controls.Add(this.viewDbBtn);
            this.basePanel.Controls.Add(this.quitBtn);
            this.basePanel.Controls.Add(this.startBtn);
            this.basePanel.Location = new System.Drawing.Point(1, 2);
            this.basePanel.Name = "basePanel";
            this.basePanel.Size = new System.Drawing.Size(641, 373);
            this.basePanel.TabIndex = 0;
            // 
            // logoBox
            // 
            this.logoBox.BackgroundImage = global::PJM_methodology_picker.Properties.Resources.LogoNexus1;
            this.logoBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logoBox.BackColor = Color.Transparent;
            this.logoBox.Location = new System.Drawing.Point(11, 10);
            this.logoBox.Name = "logoBox";
            this.logoBox.Size = new System.Drawing.Size(112, 103);
            this.logoBox.TabIndex = 4;
            this.logoBox.TabStop = false;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.BackColor = Color.Transparent;
            this.titleLabel.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(0)))), ((int)(((byte)(139)))));
            this.titleLabel.Location = new System.Drawing.Point(14, 116);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(108, 39);
            this.titleLabel.TabIndex = 3;
            this.titleLabel.Text = "Nexus";
            // 
            // viewDbBtn
            // 
            this.viewDbBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(0)))), ((int)(((byte)(139)))));
            this.viewDbBtn.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewDbBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.viewDbBtn.Location = new System.Drawing.Point(123, 249);
            this.viewDbBtn.Name = "viewDbBtn";
            this.viewDbBtn.Size = new System.Drawing.Size(284, 46);
            this.viewDbBtn.TabIndex = 2;
            this.viewDbBtn.Text = "Vezi Baza de Date";
            this.viewDbBtn.UseVisualStyleBackColor = false;
            this.viewDbBtn.Click += new System.EventHandler(this.viewDbBtn_Click);
            // 
            // quitBtn
            // 
            this.quitBtn.BackColor = System.Drawing.Color.YellowGreen;
            this.quitBtn.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quitBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.quitBtn.Location = new System.Drawing.Point(219, 301);
            this.quitBtn.Name = "quitBtn";
            this.quitBtn.Size = new System.Drawing.Size(284, 44);
            this.quitBtn.TabIndex = 1;
            this.quitBtn.Text = "Iesire";
            this.quitBtn.UseVisualStyleBackColor = false;
            this.quitBtn.Click += new System.EventHandler(this.quitBtn_Click);
            // 
            // startBtn
            // 
            this.startBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(0)))), ((int)(((byte)(130)))));
            this.startBtn.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.startBtn.Location = new System.Drawing.Point(41, 193);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(283, 46);
            this.startBtn.TabIndex = 0;
            this.startBtn.Text = "Incepe Evaluarea Proiectului\r\n";
            this.startBtn.UseVisualStyleBackColor = false;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 375);
            this.Controls.Add(this.basePanel);
            this.Name = "Menu";
            this.Text = "Nexus";
            this.basePanel.ResumeLayout(false);
            this.basePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel basePanel;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Button viewDbBtn;
        private System.Windows.Forms.Button quitBtn;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.PictureBox logoBox;
    }
}
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.viewDbBtn = new System.Windows.Forms.Button();
            this.quitBtn = new System.Windows.Forms.Button();
            this.startBtn = new System.Windows.Forms.Button();
            this.basePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // basePanel
            // 
            this.basePanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("basePanel.BackgroundImage")));
            this.basePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.basePanel.Controls.Add(this.titleLabel);
            this.basePanel.Controls.Add(this.viewDbBtn);
            this.basePanel.Controls.Add(this.quitBtn);
            this.basePanel.Controls.Add(this.startBtn);
            this.basePanel.Location = new System.Drawing.Point(1, 2);
            this.basePanel.Margin = new System.Windows.Forms.Padding(4);
            this.basePanel.Name = "basePanel";
            this.basePanel.Size = new System.Drawing.Size(855, 459);
            this.basePanel.TabIndex = 0;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(0)))), ((int)(((byte)(139)))));
            this.titleLabel.Location = new System.Drawing.Point(3, 7);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(293, 46);
            this.titleLabel.TabIndex = 3;
            this.titleLabel.Text = "Titlul Aplicatiei";
            // 
            // viewDbBtn
            // 
            this.viewDbBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(0)))), ((int)(((byte)(139)))));
            this.viewDbBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewDbBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.viewDbBtn.Location = new System.Drawing.Point(164, 306);
            this.viewDbBtn.Margin = new System.Windows.Forms.Padding(4);
            this.viewDbBtn.Name = "viewDbBtn";
            this.viewDbBtn.Size = new System.Drawing.Size(378, 56);
            this.viewDbBtn.TabIndex = 2;
            this.viewDbBtn.Text = "Vezi Baza de Date";
            this.viewDbBtn.UseVisualStyleBackColor = false;
            this.viewDbBtn.Click += new System.EventHandler(this.viewDbBtn_Click);
            // 
            // quitBtn
            // 
            this.quitBtn.BackColor = System.Drawing.Color.YellowGreen;
            this.quitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quitBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.quitBtn.Location = new System.Drawing.Point(292, 370);
            this.quitBtn.Margin = new System.Windows.Forms.Padding(4);
            this.quitBtn.Name = "quitBtn";
            this.quitBtn.Size = new System.Drawing.Size(378, 54);
            this.quitBtn.TabIndex = 1;
            this.quitBtn.Text = "Iesire";
            this.quitBtn.UseVisualStyleBackColor = false;
            this.quitBtn.Click += new System.EventHandler(this.quitBtn_Click);
            // 
            // startBtn
            // 
            this.startBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(0)))), ((int)(((byte)(130)))));
            this.startBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.startBtn.Location = new System.Drawing.Point(55, 237);
            this.startBtn.Margin = new System.Windows.Forms.Padding(4);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(377, 57);
            this.startBtn.TabIndex = 0;
            this.startBtn.Text = "Incepe Evaluarea Proiectului\r\n";
            this.startBtn.UseVisualStyleBackColor = false;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 462);
            this.Controls.Add(this.basePanel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Menu";
            this.Text = "Numele Aplicatiei";
            this.basePanel.ResumeLayout(false);
            this.basePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel basePanel;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Button viewDbBtn;
        private System.Windows.Forms.Button quitBtn;
        private System.Windows.Forms.Label titleLabel;
    }
}
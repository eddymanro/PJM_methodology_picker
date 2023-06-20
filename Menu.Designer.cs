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
            this.panel1 = new System.Windows.Forms.Panel();
            this.startBtn = new System.Windows.Forms.Button();
            this.quitBtn = new System.Windows.Forms.Button();
            this.viewDbBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.viewDbBtn);
            this.panel1.Controls.Add(this.quitBtn);
            this.panel1.Controls.Add(this.startBtn);
            this.panel1.Location = new System.Drawing.Point(1, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(641, 373);
            this.panel1.TabIndex = 0;
            // 
            // startBtn
            // 
            this.startBtn.BackColor = System.Drawing.Color.DodgerBlue;
            this.startBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.startBtn.Location = new System.Drawing.Point(122, 117);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(422, 59);
            this.startBtn.TabIndex = 0;
            this.startBtn.Text = "Start Project Evaluation";
            this.startBtn.UseVisualStyleBackColor = false;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // quitBtn
            // 
            this.quitBtn.BackColor = System.Drawing.Color.DodgerBlue;
            this.quitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quitBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.quitBtn.Location = new System.Drawing.Point(122, 247);
            this.quitBtn.Name = "quitBtn";
            this.quitBtn.Size = new System.Drawing.Size(422, 59);
            this.quitBtn.TabIndex = 1;
            this.quitBtn.Text = "Quit";
            this.quitBtn.UseVisualStyleBackColor = false;
            this.quitBtn.Click += new System.EventHandler(this.quitBtn_Click);
            // 
            // viewDbBtn
            // 
            this.viewDbBtn.BackColor = System.Drawing.Color.DodgerBlue;
            this.viewDbBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewDbBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.viewDbBtn.Location = new System.Drawing.Point(122, 182);
            this.viewDbBtn.Name = "viewDbBtn";
            this.viewDbBtn.Size = new System.Drawing.Size(422, 59);
            this.viewDbBtn.TabIndex = 2;
            this.viewDbBtn.Text = "View Database";
            this.viewDbBtn.UseVisualStyleBackColor = false;
            this.viewDbBtn.Click += new System.EventHandler(this.viewDbBtn_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 375);
            this.Controls.Add(this.panel1);
            this.Name = "Menu";
            this.Text = "Menu";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Button viewDbBtn;
        private System.Windows.Forms.Button quitBtn;
    }
}
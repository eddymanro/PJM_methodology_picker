namespace PJM_methodology_picker
{
    partial class ViewResultGraphs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewResultGraphs));
            this.basePanel = new System.Windows.Forms.Panel();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.inchideBtn = new System.Windows.Forms.Button();
            this.panA_aggile = new System.Windows.Forms.Panel();
            this.basePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // basePanel
            // 
            this.basePanel.BackColor = System.Drawing.Color.White;
            this.basePanel.Controls.Add(this.panA_aggile);
            this.basePanel.Controls.Add(this.pictureBox);
            this.basePanel.Controls.Add(this.inchideBtn);
            this.basePanel.Location = new System.Drawing.Point(0, 1);
            this.basePanel.Name = "basePanel";
            this.basePanel.Size = new System.Drawing.Size(1340, 611);
            this.basePanel.TabIndex = 0;
            // 
            // pictureBox
            // 
            this.pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox.Image")));
            this.pictureBox.Location = new System.Drawing.Point(3, 3);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(1334, 551);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 3;
            this.pictureBox.TabStop = false;
            // 
            // inchideBtn
            // 
            this.inchideBtn.BackColor = System.Drawing.Color.DodgerBlue;
            this.inchideBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inchideBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.inchideBtn.Location = new System.Drawing.Point(453, 561);
            this.inchideBtn.Margin = new System.Windows.Forms.Padding(4);
            this.inchideBtn.Name = "inchideBtn";
            this.inchideBtn.Size = new System.Drawing.Size(409, 46);
            this.inchideBtn.TabIndex = 2;
            this.inchideBtn.Text = "Inchide";
            this.inchideBtn.UseVisualStyleBackColor = false;
            this.inchideBtn.Click += new System.EventHandler(this.inchideBtn_Click);
            // 
            // panA_aggile
            // 
            this.panA_aggile.BackColor = System.Drawing.Color.DarkOrange;
            this.panA_aggile.Location = new System.Drawing.Point(125, 55);
            this.panA_aggile.Name = "panA_aggile";
            this.panA_aggile.Size = new System.Drawing.Size(63, 363);
            this.panA_aggile.TabIndex = 4;
            // 
            // ViewResultGraphs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1336, 612);
            this.Controls.Add(this.basePanel);
            this.Name = "ViewResultGraphs";
            this.Text = "ViewResultGraphs";
            this.basePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel basePanel;
        private System.Windows.Forms.Button inchideBtn;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Panel panA_aggile;
    }
}
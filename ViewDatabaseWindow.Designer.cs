namespace PJM_methodology_picker
{
    partial class ViewDatabaseWindow
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
            this.dataGridV = new System.Windows.Forms.DataGridView();
            this.quitBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.quitBtn);
            this.panel1.Controls.Add(this.dataGridV);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1072, 553);
            this.panel1.TabIndex = 0;
            // 
            // dataGridV
            // 
            this.dataGridV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridV.Location = new System.Drawing.Point(12, 11);
            this.dataGridV.Name = "dataGridV";
            this.dataGridV.RowHeadersWidth = 51;
            this.dataGridV.RowTemplate.Height = 24;
            this.dataGridV.Size = new System.Drawing.Size(1043, 438);
            this.dataGridV.TabIndex = 0;
            // 
            // quitBtn
            // 
            this.quitBtn.BackColor = System.Drawing.Color.DodgerBlue;
            this.quitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quitBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.quitBtn.Location = new System.Drawing.Point(389, 475);
            this.quitBtn.Margin = new System.Windows.Forms.Padding(4);
            this.quitBtn.Name = "quitBtn";
            this.quitBtn.Size = new System.Drawing.Size(221, 53);
            this.quitBtn.TabIndex = 2;
            this.quitBtn.Text = "Inapoi";
            this.quitBtn.UseVisualStyleBackColor = false;
            this.quitBtn.Click += new System.EventHandler(this.quitBtn_Click);
            // 
            // ViewDatabaseWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ViewDatabaseWindow";
            this.Text = "ViewDatabaseWindow";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridV;
        private System.Windows.Forms.Button quitBtn;
    }
}
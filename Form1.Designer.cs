namespace Car_Park_Software
{
    partial class FrmMain
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
            this.NumUp1 = new System.Windows.Forms.NumericUpDown();
            this.NumUp2 = new System.Windows.Forms.NumericUpDown();
            this.LblHeading1 = new System.Windows.Forms.Label();
            this.LblHeading2 = new System.Windows.Forms.Label();
            this.LblHeading3 = new System.Windows.Forms.Label();
            this.NumUp3 = new System.Windows.Forms.NumericUpDown();
            this.Lbltitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NumUp1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUp2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUp3)).BeginInit();
            this.SuspendLayout();
            // 
            // NumUp1
            // 
            this.NumUp1.Location = new System.Drawing.Point(168, 530);
            this.NumUp1.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.NumUp1.Name = "NumUp1";
            this.NumUp1.Size = new System.Drawing.Size(230, 31);
            this.NumUp1.TabIndex = 0;
            // 
            // NumUp2
            // 
            this.NumUp2.Location = new System.Drawing.Point(1088, 530);
            this.NumUp2.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.NumUp2.Name = "NumUp2";
            this.NumUp2.Size = new System.Drawing.Size(253, 31);
            this.NumUp2.TabIndex = 1;
            // 
            // LblHeading1
            // 
            this.LblHeading1.AutoSize = true;
            this.LblHeading1.Enabled = false;
            this.LblHeading1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblHeading1.Location = new System.Drawing.Point(60, 485);
            this.LblHeading1.Name = "LblHeading1";
            this.LblHeading1.Size = new System.Drawing.Size(535, 31);
            this.LblHeading1.TabIndex = 2;
            this.LblHeading1.Text = "Total Spaces Available In The Car Park:";
            // 
            // LblHeading2
            // 
            this.LblHeading2.AutoSize = true;
            this.LblHeading2.Enabled = false;
            this.LblHeading2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblHeading2.Location = new System.Drawing.Point(911, 485);
            this.LblHeading2.Name = "LblHeading2";
            this.LblHeading2.Size = new System.Drawing.Size(539, 31);
            this.LblHeading2.TabIndex = 3;
            this.LblHeading2.Text = "Total Spaces Occupied In The Car Park:";
            // 
            // LblHeading3
            // 
            this.LblHeading3.AutoSize = true;
            this.LblHeading3.Enabled = false;
            this.LblHeading3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblHeading3.Location = new System.Drawing.Point(524, 712);
            this.LblHeading3.Name = "LblHeading3";
            this.LblHeading3.Size = new System.Drawing.Size(515, 31);
            this.LblHeading3.TabIndex = 4;
            this.LblHeading3.Text = "Total Spaces In The Car Park In Total:";
            // 
            // NumUp3
            // 
            this.NumUp3.Location = new System.Drawing.Point(626, 762);
            this.NumUp3.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.NumUp3.Name = "NumUp3";
            this.NumUp3.Size = new System.Drawing.Size(281, 31);
            this.NumUp3.TabIndex = 5;
            this.NumUp3.ValueChanged += new System.EventHandler(this.NumUp3_ValueChanged);
            // 
            // Lbltitle
            // 
            this.Lbltitle.AutoSize = true;
            this.Lbltitle.Enabled = false;
            this.Lbltitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbltitle.Location = new System.Drawing.Point(497, 63);
            this.Lbltitle.Name = "Lbltitle";
            this.Lbltitle.Size = new System.Drawing.Size(491, 51);
            this.Lbltitle.TabIndex = 6;
            this.Lbltitle.Text = "Car Park Space Logger";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1504, 1058);
            this.Controls.Add(this.Lbltitle);
            this.Controls.Add(this.NumUp3);
            this.Controls.Add(this.LblHeading3);
            this.Controls.Add(this.LblHeading2);
            this.Controls.Add(this.LblHeading1);
            this.Controls.Add(this.NumUp2);
            this.Controls.Add(this.NumUp1);
            this.Name = "FrmMain";
            this.Text = "Car Park Spaces";
            ((System.ComponentModel.ISupportInitialize)(this.NumUp1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUp2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUp3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown NumUp1;
        private System.Windows.Forms.NumericUpDown NumUp2;
        private System.Windows.Forms.Label LblHeading1;
        private System.Windows.Forms.Label LblHeading2;
        private System.Windows.Forms.Label LblHeading3;
        private System.Windows.Forms.NumericUpDown NumUp3;
        private System.Windows.Forms.Label Lbltitle;
    }
}


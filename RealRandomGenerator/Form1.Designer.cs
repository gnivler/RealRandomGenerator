namespace RealRandomGenerator
{
    partial class Form1
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
            this.Go = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.max = new System.Windows.Forms.Label();
            this.min = new System.Windows.Forms.Label();
            this.avg = new System.Windows.Forms.Label();
            this.lblAvg = new System.Windows.Forms.Label();
            this.lblDrops = new System.Windows.Forms.Label();
            this.lblmin = new System.Windows.Forms.Label();
            this.drops = new System.Windows.Forms.Label();
            this.lblMax = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Go
            // 
            this.Go.Location = new System.Drawing.Point(13, 12);
            this.Go.Name = "Go";
            this.Go.Size = new System.Drawing.Size(120, 23);
            this.Go.TabIndex = 0;
            this.Go.Text = "Go";
            this.Go.UseVisualStyleBackColor = true;
            this.Go.Click += new System.EventHandler(this.Go_click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 42);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(120, 168);
            this.textBox1.TabIndex = 5;
            // 
            // max
            // 
            this.max.AutoSize = true;
            this.max.Location = new System.Drawing.Point(59, 68);
            this.max.Name = "max";
            this.max.Size = new System.Drawing.Size(13, 13);
            this.max.TabIndex = 3;
            this.max.Text = "0";
            // 
            // min
            // 
            this.min.AutoSize = true;
            this.min.Location = new System.Drawing.Point(59, 29);
            this.min.Name = "min";
            this.min.Size = new System.Drawing.Size(13, 13);
            this.min.TabIndex = 3;
            this.min.Text = "0";
            // 
            // avg
            // 
            this.avg.AutoSize = true;
            this.avg.Location = new System.Drawing.Point(59, 102);
            this.avg.Name = "avg";
            this.avg.Size = new System.Drawing.Size(13, 13);
            this.avg.TabIndex = 3;
            this.avg.Text = "0";
            // 
            // lblAvg
            // 
            this.lblAvg.AutoSize = true;
            this.lblAvg.Location = new System.Drawing.Point(6, 102);
            this.lblAvg.Name = "lblAvg";
            this.lblAvg.Size = new System.Drawing.Size(47, 13);
            this.lblAvg.TabIndex = 2;
            this.lblAvg.Text = "Average";
            // 
            // lblDrops
            // 
            this.lblDrops.AutoSize = true;
            this.lblDrops.Location = new System.Drawing.Point(6, 141);
            this.lblDrops.Name = "lblDrops";
            this.lblDrops.Size = new System.Drawing.Size(35, 13);
            this.lblDrops.TabIndex = 4;
            this.lblDrops.Text = "Drops";
            // 
            // lblmin
            // 
            this.lblmin.AutoSize = true;
            this.lblmin.Location = new System.Drawing.Point(6, 29);
            this.lblmin.Name = "lblmin";
            this.lblmin.Size = new System.Drawing.Size(24, 13);
            this.lblmin.TabIndex = 2;
            this.lblmin.Text = "Min";
            // 
            // drops
            // 
            this.drops.AutoSize = true;
            this.drops.Location = new System.Drawing.Point(59, 141);
            this.drops.Name = "drops";
            this.drops.Size = new System.Drawing.Size(13, 13);
            this.drops.TabIndex = 4;
            this.drops.Text = "0";
            // 
            // lblMax
            // 
            this.lblMax.AutoSize = true;
            this.lblMax.Location = new System.Drawing.Point(6, 68);
            this.lblMax.Name = "lblMax";
            this.lblMax.Size = new System.Drawing.Size(27, 13);
            this.lblMax.TabIndex = 2;
            this.lblMax.Text = "Max";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblMax);
            this.groupBox1.Controls.Add(this.drops);
            this.groupBox1.Controls.Add(this.lblmin);
            this.groupBox1.Controls.Add(this.lblDrops);
            this.groupBox1.Controls.Add(this.lblAvg);
            this.groupBox1.Controls.Add(this.avg);
            this.groupBox1.Controls.Add(this.min);
            this.groupBox1.Controls.Add(this.max);
            this.groupBox1.Location = new System.Drawing.Point(142, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(234, 168);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Statistics";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 226);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Go);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Real RNG";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Go;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label max;
        private System.Windows.Forms.Label min;
        private System.Windows.Forms.Label avg;
        private System.Windows.Forms.Label lblAvg;
        private System.Windows.Forms.Label lblDrops;
        private System.Windows.Forms.Label lblmin;
        private System.Windows.Forms.Label drops;
        private System.Windows.Forms.Label lblMax;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}


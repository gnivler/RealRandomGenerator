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
            this.avg = new System.Windows.Forms.Label();
            this.lblAvg = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblDrops = new System.Windows.Forms.Label();
            this.badAvg = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblMaxRolls = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblRAND_MAX = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Go
            // 
            this.Go.Location = new System.Drawing.Point(13, 12);
            this.Go.Name = "Go";
            this.Go.Size = new System.Drawing.Size(120, 40);
            this.Go.TabIndex = 0;
            this.Go.Text = "Go";
            this.Go.UseVisualStyleBackColor = true;
            this.Go.Click += new System.EventHandler(this.Go_click);
            // 
            // avg
            // 
            this.avg.AutoSize = true;
            this.avg.Location = new System.Drawing.Point(446, 39);
            this.avg.Name = "avg";
            this.avg.Size = new System.Drawing.Size(13, 13);
            this.avg.TabIndex = 3;
            this.avg.Text = "0";
            // 
            // lblAvg
            // 
            this.lblAvg.AutoSize = true;
            this.lblAvg.Location = new System.Drawing.Point(393, 39);
            this.lblAvg.Name = "lblAvg";
            this.lblAvg.Size = new System.Drawing.Size(50, 13);
            this.lblAvg.TabIndex = 2;
            this.lblAvg.Text = "Average:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(148, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Non-random:";
            // 
            // lblDrops
            // 
            this.lblDrops.AutoSize = true;
            this.lblDrops.Location = new System.Drawing.Point(222, 39);
            this.lblDrops.Name = "lblDrops";
            this.lblDrops.Size = new System.Drawing.Size(13, 13);
            this.lblDrops.TabIndex = 4;
            this.lblDrops.Text = "0";
            // 
            // badAvg
            // 
            this.badAvg.AutoSize = true;
            this.badAvg.Location = new System.Drawing.Point(342, 39);
            this.badAvg.Name = "badAvg";
            this.badAvg.Size = new System.Drawing.Size(13, 13);
            this.badAvg.TabIndex = 3;
            this.badAvg.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(267, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Bad Average:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(148, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Rolls done:";
            // 
            // lblMaxRolls
            // 
            this.lblMaxRolls.AutoSize = true;
            this.lblMaxRolls.Location = new System.Drawing.Point(222, 17);
            this.lblMaxRolls.Name = "lblMaxRolls";
            this.lblMaxRolls.Size = new System.Drawing.Size(13, 13);
            this.lblMaxRolls.TabIndex = 3;
            this.lblMaxRolls.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(266, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "RAND_MAX:";
            // 
            // lblRAND_MAX
            // 
            this.lblRAND_MAX.AutoSize = true;
            this.lblRAND_MAX.Location = new System.Drawing.Point(342, 17);
            this.lblRAND_MAX.Name = "lblRAND_MAX";
            this.lblRAND_MAX.Size = new System.Drawing.Size(13, 13);
            this.lblRAND_MAX.TabIndex = 3;
            this.lblRAND_MAX.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 73);
            this.Controls.Add(this.lblDrops);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Go);
            this.Controls.Add(this.badAvg);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblAvg);
            this.Controls.Add(this.avg);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblRAND_MAX);
            this.Controls.Add(this.lblMaxRolls);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Real RNG";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Go;
        private System.Windows.Forms.Label avg;
        private System.Windows.Forms.Label lblAvg;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblDrops;
        private System.Windows.Forms.Label badAvg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblMaxRolls;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblRAND_MAX;
    }
}


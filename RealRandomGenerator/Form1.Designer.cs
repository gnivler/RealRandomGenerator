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
            this.myAvg = new System.Windows.Forms.Label();
            this.lblAvg = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblDrops = new System.Windows.Forms.Label();
            this.dotNetAvg = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblRollsDone = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblRAND_MAX = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblRolls = new System.Windows.Forms.Label();
            this.lblMaxRolls = new System.Windows.Forms.Label();
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
            // myAvg
            // 
            this.myAvg.AutoSize = true;
            this.myAvg.Location = new System.Drawing.Point(222, 90);
            this.myAvg.Name = "myAvg";
            this.myAvg.Size = new System.Drawing.Size(13, 13);
            this.myAvg.TabIndex = 3;
            this.myAvg.Text = "0";
            // 
            // lblAvg
            // 
            this.lblAvg.AutoSize = true;
            this.lblAvg.Location = new System.Drawing.Point(148, 90);
            this.lblAvg.Name = "lblAvg";
            this.lblAvg.Size = new System.Drawing.Size(46, 13);
            this.lblAvg.TabIndex = 2;
            this.lblAvg.Text = "My Avg:";
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
            // dotNetAvg
            // 
            this.dotNetAvg.AutoSize = true;
            this.dotNetAvg.Location = new System.Drawing.Point(222, 68);
            this.dotNetAvg.Name = "dotNetAvg";
            this.dotNetAvg.Size = new System.Drawing.Size(13, 13);
            this.dotNetAvg.TabIndex = 3;
            this.dotNetAvg.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(148, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = ".NET Avg:";
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
            // lblRollsDone
            // 
            this.lblRollsDone.AutoSize = true;
            this.lblRollsDone.Location = new System.Drawing.Point(222, 17);
            this.lblRollsDone.Name = "lblRollsDone";
            this.lblRollsDone.Size = new System.Drawing.Size(13, 13);
            this.lblRollsDone.TabIndex = 3;
            this.lblRollsDone.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(302, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "RAND_MAX:";
            // 
            // lblRAND_MAX
            // 
            this.lblRAND_MAX.AutoSize = true;
            this.lblRAND_MAX.Location = new System.Drawing.Point(378, 39);
            this.lblRAND_MAX.Name = "lblRAND_MAX";
            this.lblRAND_MAX.Size = new System.Drawing.Size(13, 13);
            this.lblRAND_MAX.TabIndex = 3;
            this.lblRAND_MAX.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(302, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Roll bound:";
            // 
            // lblRolls
            // 
            this.lblRolls.AutoSize = true;
            this.lblRolls.Location = new System.Drawing.Point(378, 17);
            this.lblRolls.Name = "lblRolls";
            this.lblRolls.Size = new System.Drawing.Size(13, 13);
            this.lblRolls.TabIndex = 3;
            this.lblRolls.Text = "0";
            // 
            // lblMaxRolls
            // 
            this.lblMaxRolls.AutoSize = true;
            this.lblMaxRolls.Location = new System.Drawing.Point(13, 68);
            this.lblMaxRolls.Name = "lblMaxRolls";
            this.lblMaxRolls.Size = new System.Drawing.Size(0, 13);
            this.lblMaxRolls.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 112);
            this.Controls.Add(this.lblMaxRolls);
            this.Controls.Add(this.lblDrops);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Go);
            this.Controls.Add(this.dotNetAvg);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblAvg);
            this.Controls.Add(this.myAvg);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblRolls);
            this.Controls.Add(this.lblRAND_MAX);
            this.Controls.Add(this.lblRollsDone);
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
        private System.Windows.Forms.Label myAvg;
        private System.Windows.Forms.Label lblAvg;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblDrops;
        private System.Windows.Forms.Label dotNetAvg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblRollsDone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblRAND_MAX;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblRolls;
        private System.Windows.Forms.Label lblMaxRolls;
    }
}


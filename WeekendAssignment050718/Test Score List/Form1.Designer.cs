namespace Test_Score_List
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
            this.testScoresListBox = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.labAvg = new System.Windows.Forms.Label();
            this.labAbove = new System.Windows.Forms.Label();
            this.labBelow = new System.Windows.Forms.Label();
            this.averageLabel = new System.Windows.Forms.Label();
            this.aboveAverageLabel = new System.Windows.Forms.Label();
            this.belowAverageLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // testScoresListBox
            // 
            this.testScoresListBox.FormattingEnabled = true;
            this.testScoresListBox.Location = new System.Drawing.Point(27, 26);
            this.testScoresListBox.Name = "testScoresListBox";
            this.testScoresListBox.Size = new System.Drawing.Size(125, 147);
            this.testScoresListBox.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(189, 150);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Get Scores";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(341, 150);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Exit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // labAvg
            // 
            this.labAvg.AutoSize = true;
            this.labAvg.Location = new System.Drawing.Point(235, 26);
            this.labAvg.Name = "labAvg";
            this.labAvg.Size = new System.Drawing.Size(78, 13);
            this.labAvg.TabIndex = 3;
            this.labAvg.Text = "Average Score";
            // 
            // labAbove
            // 
            this.labAbove.AutoSize = true;
            this.labAbove.Location = new System.Drawing.Point(167, 67);
            this.labAbove.Name = "labAbove";
            this.labAbove.Size = new System.Drawing.Size(169, 13);
            this.labAbove.TabIndex = 4;
            this.labAbove.Text = "Number of Scores Above Average";
            // 
            // labBelow
            // 
            this.labBelow.AutoSize = true;
            this.labBelow.Location = new System.Drawing.Point(167, 108);
            this.labBelow.Name = "labBelow";
            this.labBelow.Size = new System.Drawing.Size(167, 13);
            this.labBelow.TabIndex = 5;
            this.labBelow.Text = "Number of Scores Below Average";
            // 
            // averageLabel
            // 
            this.averageLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.averageLabel.Location = new System.Drawing.Point(341, 25);
            this.averageLabel.Name = "averageLabel";
            this.averageLabel.Size = new System.Drawing.Size(156, 23);
            this.averageLabel.TabIndex = 6;
            // 
            // aboveAverageLabel
            // 
            this.aboveAverageLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.aboveAverageLabel.Location = new System.Drawing.Point(341, 66);
            this.aboveAverageLabel.Name = "aboveAverageLabel";
            this.aboveAverageLabel.Size = new System.Drawing.Size(156, 23);
            this.aboveAverageLabel.TabIndex = 7;
            // 
            // belowAverageLabel
            // 
            this.belowAverageLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.belowAverageLabel.Location = new System.Drawing.Point(341, 107);
            this.belowAverageLabel.Name = "belowAverageLabel";
            this.belowAverageLabel.Size = new System.Drawing.Size(156, 23);
            this.belowAverageLabel.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 200);
            this.Controls.Add(this.belowAverageLabel);
            this.Controls.Add(this.aboveAverageLabel);
            this.Controls.Add(this.averageLabel);
            this.Controls.Add(this.labBelow);
            this.Controls.Add(this.labAbove);
            this.Controls.Add(this.labAvg);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.testScoresListBox);
            this.Name = "Form1";
            this.Text = "Test Score List";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox testScoresListBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label labAvg;
        private System.Windows.Forms.Label labAbove;
        private System.Windows.Forms.Label labBelow;
        private System.Windows.Forms.Label averageLabel;
        private System.Windows.Forms.Label aboveAverageLabel;
        private System.Windows.Forms.Label belowAverageLabel;
    }
}


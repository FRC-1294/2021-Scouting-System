namespace _1294_Scouting.Scouting
{
    partial class LeTester
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
            this.Robot = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SendMatch = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Match = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Robot
            // 
            this.Robot.Location = new System.Drawing.Point(65, 52);
            this.Robot.Name = "Robot";
            this.Robot.Size = new System.Drawing.Size(152, 20);
            this.Robot.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Robot";
            // 
            // SendMatch
            // 
            this.SendMatch.Location = new System.Drawing.Point(239, 152);
            this.SendMatch.Name = "SendMatch";
            this.SendMatch.Size = new System.Drawing.Size(141, 58);
            this.SendMatch.TabIndex = 2;
            this.SendMatch.Text = "button1";
            this.SendMatch.UseVisualStyleBackColor = true;
            this.SendMatch.Click += new System.EventHandler(this.SendMatch_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(288, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Match";
            // 
            // Match
            // 
            this.Match.Location = new System.Drawing.Point(265, 60);
            this.Match.Name = "Match";
            this.Match.Size = new System.Drawing.Size(100, 20);
            this.Match.TabIndex = 4;
            // 
            // Debug_Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Match);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SendMatch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Robot);
            this.Name = "Debug_Server";
            this.Text = "Debug_Server";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Robot;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SendMatch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Match;
    }
}
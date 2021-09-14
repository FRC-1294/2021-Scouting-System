
namespace _1294_Scouting
{
    partial class Scout
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
            this.autoBox = new System.Windows.Forms.GroupBox();
            this.autoNo = new System.Windows.Forms.RadioButton();
            this.autoMove = new System.Windows.Forms.RadioButton();
            this.autoScore = new System.Windows.Forms.RadioButton();
            this.climbBox = new System.Windows.Forms.GroupBox();
            this.climbNo = new System.Windows.Forms.RadioButton();
            this.climbYes = new System.Windows.Forms.RadioButton();
            this.climbBalance = new System.Windows.Forms.RadioButton();
            this.debugLabel = new System.Windows.Forms.Label();
            this.autoBox.SuspendLayout();
            this.climbBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // autoBox
            // 
            this.autoBox.Controls.Add(this.autoScore);
            this.autoBox.Controls.Add(this.autoMove);
            this.autoBox.Controls.Add(this.autoNo);
            this.autoBox.Location = new System.Drawing.Point(35, 39);
            this.autoBox.Name = "autoBox";
            this.autoBox.Size = new System.Drawing.Size(116, 99);
            this.autoBox.TabIndex = 0;
            this.autoBox.TabStop = false;
            this.autoBox.Text = "Autonomous";
            // 
            // autoNo
            // 
            this.autoNo.AutoSize = true;
            this.autoNo.Location = new System.Drawing.Point(6, 19);
            this.autoNo.Name = "autoNo";
            this.autoNo.Size = new System.Drawing.Size(39, 17);
            this.autoNo.TabIndex = 0;
            this.autoNo.Text = "No";
            this.autoNo.UseVisualStyleBackColor = true;
            this.autoNo.CheckedChanged += new System.EventHandler(this.UpdateData);
            // 
            // autoMove
            // 
            this.autoMove.AutoSize = true;
            this.autoMove.Location = new System.Drawing.Point(7, 43);
            this.autoMove.Name = "autoMove";
            this.autoMove.Size = new System.Drawing.Size(92, 17);
            this.autoMove.TabIndex = 1;
            this.autoMove.Text = "Moved off line";
            this.autoMove.UseVisualStyleBackColor = true;
            this.autoMove.CheckedChanged += new System.EventHandler(this.UpdateData);
            // 
            // autoScore
            // 
            this.autoScore.AutoSize = true;
            this.autoScore.Location = new System.Drawing.Point(7, 67);
            this.autoScore.Name = "autoScore";
            this.autoScore.Size = new System.Drawing.Size(91, 17);
            this.autoScore.TabIndex = 2;
            this.autoScore.Text = "Scored Points";
            this.autoScore.UseVisualStyleBackColor = true;
            this.autoScore.CheckedChanged += new System.EventHandler(this.UpdateData);
            // 
            // climbBox
            // 
            this.climbBox.Controls.Add(this.climbBalance);
            this.climbBox.Controls.Add(this.climbYes);
            this.climbBox.Controls.Add(this.climbNo);
            this.climbBox.Location = new System.Drawing.Point(35, 169);
            this.climbBox.Name = "climbBox";
            this.climbBox.Size = new System.Drawing.Size(116, 99);
            this.climbBox.TabIndex = 1;
            this.climbBox.TabStop = false;
            this.climbBox.Text = "Climb";
            // 
            // climbNo
            // 
            this.climbNo.AutoSize = true;
            this.climbNo.Location = new System.Drawing.Point(7, 20);
            this.climbNo.Name = "climbNo";
            this.climbNo.Size = new System.Drawing.Size(39, 17);
            this.climbNo.TabIndex = 0;
            this.climbNo.TabStop = true;
            this.climbNo.Text = "No";
            this.climbNo.UseVisualStyleBackColor = true;
            this.climbNo.CheckedChanged += new System.EventHandler(this.UpdateData);
            // 
            // climbYes
            // 
            this.climbYes.AutoSize = true;
            this.climbYes.Location = new System.Drawing.Point(7, 44);
            this.climbYes.Name = "climbYes";
            this.climbYes.Size = new System.Drawing.Size(43, 17);
            this.climbYes.TabIndex = 1;
            this.climbYes.TabStop = true;
            this.climbYes.Text = "Yes";
            this.climbYes.UseVisualStyleBackColor = true;
            this.climbYes.CheckedChanged += new System.EventHandler(this.UpdateData);
            // 
            // climbBalance
            // 
            this.climbBalance.AutoSize = true;
            this.climbBalance.Location = new System.Drawing.Point(7, 68);
            this.climbBalance.Name = "climbBalance";
            this.climbBalance.Size = new System.Drawing.Size(64, 17);
            this.climbBalance.TabIndex = 2;
            this.climbBalance.TabStop = true;
            this.climbBalance.Text = "Balance";
            this.climbBalance.UseVisualStyleBackColor = true;
            this.climbBalance.CheckedChanged += new System.EventHandler(this.UpdateData);
            // 
            // debugLabel
            // 
            this.debugLabel.AutoSize = true;
            this.debugLabel.Location = new System.Drawing.Point(409, 189);
            this.debugLabel.Name = "debugLabel";
            this.debugLabel.Size = new System.Drawing.Size(48, 13);
            this.debugLabel.TabIndex = 2;
            this.debugLabel.Text = "DEBUG:";
            // 
            // Scout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.debugLabel);
            this.Controls.Add(this.climbBox);
            this.Controls.Add(this.autoBox);
            this.Name = "Scout";
            this.Text = "Scout";
            this.autoBox.ResumeLayout(false);
            this.autoBox.PerformLayout();
            this.climbBox.ResumeLayout(false);
            this.climbBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox autoBox;
        private System.Windows.Forms.RadioButton autoNo;
        private System.Windows.Forms.RadioButton autoScore;
        private System.Windows.Forms.RadioButton autoMove;
        private System.Windows.Forms.GroupBox climbBox;
        private System.Windows.Forms.RadioButton climbBalance;
        private System.Windows.Forms.RadioButton climbYes;
        private System.Windows.Forms.RadioButton climbNo;
        private System.Windows.Forms.Label debugLabel;
    }
}
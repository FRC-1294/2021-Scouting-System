
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
            this.autoScore = new System.Windows.Forms.RadioButton();
            this.autoMove = new System.Windows.Forms.RadioButton();
            this.autoNo = new System.Windows.Forms.RadioButton();
            this.climbBox = new System.Windows.Forms.GroupBox();
            this.climbYes = new System.Windows.Forms.RadioButton();
            this.climbNo = new System.Windows.Forms.RadioButton();
            this.debugLabel = new System.Windows.Forms.Label();
            this.colorWheelBox = new System.Windows.Forms.GroupBox();
            this.wheelMatch = new System.Windows.Forms.CheckBox();
            this.wheelSpin = new System.Windows.Forms.CheckBox();
            this.powerCellsTopLabel = new System.Windows.Forms.Label();
            this.powerCellTopAdd = new System.Windows.Forms.Button();
            this.powerCellsTopSubtract = new System.Windows.Forms.Button();
            this.powerCellsTop = new System.Windows.Forms.TextBox();
            this.powerCellsTopBox = new System.Windows.Forms.Panel();
            this.powerCellsBottomBox = new System.Windows.Forms.Panel();
            this.powerCellsBottom = new System.Windows.Forms.TextBox();
            this.powerCellsBottomSubtract = new System.Windows.Forms.Button();
            this.powerCellsBottomAdd = new System.Windows.Forms.Button();
            this.powerCellsBottomLabel = new System.Windows.Forms.Label();
            this.powerCellsGroupBox = new System.Windows.Forms.GroupBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.scoutingControlPanel = new System.Windows.Forms.Panel();
            this.currentRobotLabel = new System.Windows.Forms.Label();
            this.currentRobot = new System.Windows.Forms.TextBox();
            this.statusBar = new System.Windows.Forms.ProgressBar();
            this.autoBox.SuspendLayout();
            this.climbBox.SuspendLayout();
            this.colorWheelBox.SuspendLayout();
            this.powerCellsTopBox.SuspendLayout();
            this.powerCellsBottomBox.SuspendLayout();
            this.powerCellsGroupBox.SuspendLayout();
            this.scoutingControlPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // autoBox
            // 
            this.autoBox.Controls.Add(this.autoScore);
            this.autoBox.Controls.Add(this.autoMove);
            this.autoBox.Controls.Add(this.autoNo);
            this.autoBox.Location = new System.Drawing.Point(305, 15);
            this.autoBox.Name = "autoBox";
            this.autoBox.Size = new System.Drawing.Size(116, 99);
            this.autoBox.TabIndex = 0;
            this.autoBox.TabStop = false;
            this.autoBox.Text = "Autonomous";
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
            // autoNo
            // 
            this.autoNo.AutoSize = true;
            this.autoNo.Checked = true;
            this.autoNo.Location = new System.Drawing.Point(6, 19);
            this.autoNo.Name = "autoNo";
            this.autoNo.Size = new System.Drawing.Size(39, 17);
            this.autoNo.TabIndex = 0;
            this.autoNo.TabStop = true;
            this.autoNo.Text = "No";
            this.autoNo.UseVisualStyleBackColor = true;
            this.autoNo.CheckedChanged += new System.EventHandler(this.UpdateData);
            // 
            // climbBox
            // 
            this.climbBox.Controls.Add(this.climbYes);
            this.climbBox.Controls.Add(this.climbNo);
            this.climbBox.Location = new System.Drawing.Point(305, 120);
            this.climbBox.Name = "climbBox";
            this.climbBox.Size = new System.Drawing.Size(116, 73);
            this.climbBox.TabIndex = 1;
            this.climbBox.TabStop = false;
            this.climbBox.Text = "Climb";
            // 
            // climbYes
            // 
            this.climbYes.AutoSize = true;
            this.climbYes.Location = new System.Drawing.Point(7, 44);
            this.climbYes.Name = "climbYes";
            this.climbYes.Size = new System.Drawing.Size(43, 17);
            this.climbYes.TabIndex = 1;
            this.climbYes.Text = "Yes";
            this.climbYes.UseVisualStyleBackColor = true;
            this.climbYes.CheckedChanged += new System.EventHandler(this.UpdateData);
            // 
            // climbNo
            // 
            this.climbNo.AutoSize = true;
            this.climbNo.Checked = true;
            this.climbNo.Location = new System.Drawing.Point(7, 20);
            this.climbNo.Name = "climbNo";
            this.climbNo.Size = new System.Drawing.Size(39, 17);
            this.climbNo.TabIndex = 0;
            this.climbNo.TabStop = true;
            this.climbNo.Text = "No";
            this.climbNo.UseVisualStyleBackColor = true;
            this.climbNo.CheckedChanged += new System.EventHandler(this.UpdateData);
            // 
            // debugLabel
            // 
            this.debugLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.debugLabel.AutoSize = true;
            this.debugLabel.Location = new System.Drawing.Point(677, 391);
            this.debugLabel.Name = "debugLabel";
            this.debugLabel.Size = new System.Drawing.Size(48, 13);
            this.debugLabel.TabIndex = 2;
            this.debugLabel.Text = "DEBUG:";
            // 
            // colorWheelBox
            // 
            this.colorWheelBox.Controls.Add(this.wheelMatch);
            this.colorWheelBox.Controls.Add(this.wheelSpin);
            this.colorWheelBox.Location = new System.Drawing.Point(305, 199);
            this.colorWheelBox.Name = "colorWheelBox";
            this.colorWheelBox.Size = new System.Drawing.Size(97, 76);
            this.colorWheelBox.TabIndex = 3;
            this.colorWheelBox.TabStop = false;
            this.colorWheelBox.Text = "Color Wheel";
            // 
            // wheelMatch
            // 
            this.wheelMatch.AutoSize = true;
            this.wheelMatch.Location = new System.Drawing.Point(7, 44);
            this.wheelMatch.Name = "wheelMatch";
            this.wheelMatch.Size = new System.Drawing.Size(83, 17);
            this.wheelMatch.TabIndex = 1;
            this.wheelMatch.Text = "Match Color";
            this.wheelMatch.UseVisualStyleBackColor = true;
            this.wheelMatch.CheckedChanged += new System.EventHandler(this.UpdateData);
            // 
            // wheelSpin
            // 
            this.wheelSpin.AutoSize = true;
            this.wheelSpin.Location = new System.Drawing.Point(7, 20);
            this.wheelSpin.Name = "wheelSpin";
            this.wheelSpin.Size = new System.Drawing.Size(47, 17);
            this.wheelSpin.TabIndex = 0;
            this.wheelSpin.Text = "Spin";
            this.wheelSpin.UseVisualStyleBackColor = true;
            this.wheelSpin.CheckedChanged += new System.EventHandler(this.UpdateData);
            // 
            // powerCellsTopLabel
            // 
            this.powerCellsTopLabel.AutoSize = true;
            this.powerCellsTopLabel.Location = new System.Drawing.Point(63, 19);
            this.powerCellsTopLabel.Name = "powerCellsTopLabel";
            this.powerCellsTopLabel.Size = new System.Drawing.Size(106, 13);
            this.powerCellsTopLabel.TabIndex = 4;
            this.powerCellsTopLabel.Text = "Power Cells Top Port";
            // 
            // powerCellTopAdd
            // 
            this.powerCellTopAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.powerCellTopAdd.Location = new System.Drawing.Point(172, 49);
            this.powerCellTopAdd.Name = "powerCellTopAdd";
            this.powerCellTopAdd.Size = new System.Drawing.Size(48, 50);
            this.powerCellTopAdd.TabIndex = 6;
            this.powerCellTopAdd.Text = "+";
            this.powerCellTopAdd.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.powerCellTopAdd.UseVisualStyleBackColor = true;
            this.powerCellTopAdd.Click += new System.EventHandler(this.powerCellTopAdd_Click);
            // 
            // powerCellsTopSubtract
            // 
            this.powerCellsTopSubtract.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.powerCellsTopSubtract.Location = new System.Drawing.Point(25, 52);
            this.powerCellsTopSubtract.Name = "powerCellsTopSubtract";
            this.powerCellsTopSubtract.Size = new System.Drawing.Size(48, 48);
            this.powerCellsTopSubtract.TabIndex = 7;
            this.powerCellsTopSubtract.Text = "-";
            this.powerCellsTopSubtract.UseVisualStyleBackColor = true;
            this.powerCellsTopSubtract.Click += new System.EventHandler(this.powerCellsTopSubtract_Click);
            // 
            // powerCellsTop
            // 
            this.powerCellsTop.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.powerCellsTop.Location = new System.Drawing.Point(89, 44);
            this.powerCellsTop.Multiline = true;
            this.powerCellsTop.Name = "powerCellsTop";
            this.powerCellsTop.Size = new System.Drawing.Size(68, 59);
            this.powerCellsTop.TabIndex = 8;
            this.powerCellsTop.Text = "0";
            this.powerCellsTop.TextChanged += new System.EventHandler(this.powerCellsTop_TextChanged);
            // 
            // powerCellsTopBox
            // 
            this.powerCellsTopBox.Controls.Add(this.powerCellsTop);
            this.powerCellsTopBox.Controls.Add(this.powerCellsTopSubtract);
            this.powerCellsTopBox.Controls.Add(this.powerCellTopAdd);
            this.powerCellsTopBox.Controls.Add(this.powerCellsTopLabel);
            this.powerCellsTopBox.Location = new System.Drawing.Point(12, 13);
            this.powerCellsTopBox.Name = "powerCellsTopBox";
            this.powerCellsTopBox.Size = new System.Drawing.Size(248, 129);
            this.powerCellsTopBox.TabIndex = 9;
            // 
            // powerCellsBottomBox
            // 
            this.powerCellsBottomBox.Controls.Add(this.powerCellsBottom);
            this.powerCellsBottomBox.Controls.Add(this.powerCellsBottomSubtract);
            this.powerCellsBottomBox.Controls.Add(this.powerCellsBottomAdd);
            this.powerCellsBottomBox.Controls.Add(this.powerCellsBottomLabel);
            this.powerCellsBottomBox.Location = new System.Drawing.Point(12, 168);
            this.powerCellsBottomBox.Name = "powerCellsBottomBox";
            this.powerCellsBottomBox.Size = new System.Drawing.Size(248, 129);
            this.powerCellsBottomBox.TabIndex = 10;
            // 
            // powerCellsBottom
            // 
            this.powerCellsBottom.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.powerCellsBottom.Location = new System.Drawing.Point(89, 44);
            this.powerCellsBottom.Multiline = true;
            this.powerCellsBottom.Name = "powerCellsBottom";
            this.powerCellsBottom.Size = new System.Drawing.Size(68, 59);
            this.powerCellsBottom.TabIndex = 8;
            this.powerCellsBottom.Text = "0";
            this.powerCellsBottom.TextChanged += new System.EventHandler(this.powerCellsBottom_TextChanged);
            // 
            // powerCellsBottomSubtract
            // 
            this.powerCellsBottomSubtract.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.powerCellsBottomSubtract.Location = new System.Drawing.Point(25, 52);
            this.powerCellsBottomSubtract.Name = "powerCellsBottomSubtract";
            this.powerCellsBottomSubtract.Size = new System.Drawing.Size(48, 48);
            this.powerCellsBottomSubtract.TabIndex = 7;
            this.powerCellsBottomSubtract.Text = "-";
            this.powerCellsBottomSubtract.UseVisualStyleBackColor = true;
            this.powerCellsBottomSubtract.Click += new System.EventHandler(this.powerCellsBottomSubtract_Click);
            // 
            // powerCellsBottomAdd
            // 
            this.powerCellsBottomAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.powerCellsBottomAdd.Location = new System.Drawing.Point(172, 49);
            this.powerCellsBottomAdd.Name = "powerCellsBottomAdd";
            this.powerCellsBottomAdd.Size = new System.Drawing.Size(48, 50);
            this.powerCellsBottomAdd.TabIndex = 6;
            this.powerCellsBottomAdd.Text = "+";
            this.powerCellsBottomAdd.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.powerCellsBottomAdd.UseVisualStyleBackColor = true;
            this.powerCellsBottomAdd.Click += new System.EventHandler(this.powerCellsBottomAdd_Click);
            // 
            // powerCellsBottomLabel
            // 
            this.powerCellsBottomLabel.AutoSize = true;
            this.powerCellsBottomLabel.Location = new System.Drawing.Point(63, 19);
            this.powerCellsBottomLabel.Name = "powerCellsBottomLabel";
            this.powerCellsBottomLabel.Size = new System.Drawing.Size(120, 13);
            this.powerCellsBottomLabel.TabIndex = 4;
            this.powerCellsBottomLabel.Text = "Power Cells Bottom Port";
            // 
            // powerCellsGroupBox
            // 
            this.powerCellsGroupBox.Controls.Add(this.powerCellsBottomBox);
            this.powerCellsGroupBox.Controls.Add(this.powerCellsTopBox);
            this.powerCellsGroupBox.Location = new System.Drawing.Point(14, 15);
            this.powerCellsGroupBox.Name = "powerCellsGroupBox";
            this.powerCellsGroupBox.Size = new System.Drawing.Size(271, 315);
            this.powerCellsGroupBox.TabIndex = 11;
            this.powerCellsGroupBox.TabStop = false;
            this.powerCellsGroupBox.Text = "Power Cells";
            // 
            // submitButton
            // 
            this.submitButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.submitButton.Location = new System.Drawing.Point(184, 391);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(476, 56);
            this.submitButton.TabIndex = 13;
            this.submitButton.Text = "Submit Data";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // scoutingControlPanel
            // 
            this.scoutingControlPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.scoutingControlPanel.Controls.Add(this.currentRobotLabel);
            this.scoutingControlPanel.Controls.Add(this.currentRobot);
            this.scoutingControlPanel.Controls.Add(this.powerCellsGroupBox);
            this.scoutingControlPanel.Controls.Add(this.colorWheelBox);
            this.scoutingControlPanel.Controls.Add(this.climbBox);
            this.scoutingControlPanel.Controls.Add(this.autoBox);
            this.scoutingControlPanel.Location = new System.Drawing.Point(22, 40);
            this.scoutingControlPanel.Name = "scoutingControlPanel";
            this.scoutingControlPanel.Size = new System.Drawing.Size(766, 342);
            this.scoutingControlPanel.TabIndex = 14;
            // 
            // currentRobotLabel
            // 
            this.currentRobotLabel.AutoSize = true;
            this.currentRobotLabel.Location = new System.Drawing.Point(557, 49);
            this.currentRobotLabel.Name = "currentRobotLabel";
            this.currentRobotLabel.Size = new System.Drawing.Size(76, 13);
            this.currentRobotLabel.TabIndex = 13;
            this.currentRobotLabel.Text = "Current Robot:";
            // 
            // currentRobot
            // 
            this.currentRobot.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentRobot.Location = new System.Drawing.Point(560, 65);
            this.currentRobot.Name = "currentRobot";
            this.currentRobot.ReadOnly = true;
            this.currentRobot.Size = new System.Drawing.Size(69, 38);
            this.currentRobot.TabIndex = 12;
            this.currentRobot.Text = "1294";
            // 
            // statusBar
            // 
            this.statusBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.statusBar.Location = new System.Drawing.Point(22, 6);
            this.statusBar.MarqueeAnimationSpeed = 2;
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(766, 28);
            this.statusBar.TabIndex = 15;
            this.statusBar.Value = 100;
            // 
            // Scout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.scoutingControlPanel);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.debugLabel);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "Scout";
            this.Text = "Scout";
            this.autoBox.ResumeLayout(false);
            this.autoBox.PerformLayout();
            this.climbBox.ResumeLayout(false);
            this.climbBox.PerformLayout();
            this.colorWheelBox.ResumeLayout(false);
            this.colorWheelBox.PerformLayout();
            this.powerCellsTopBox.ResumeLayout(false);
            this.powerCellsTopBox.PerformLayout();
            this.powerCellsBottomBox.ResumeLayout(false);
            this.powerCellsBottomBox.PerformLayout();
            this.powerCellsGroupBox.ResumeLayout(false);
            this.scoutingControlPanel.ResumeLayout(false);
            this.scoutingControlPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox autoBox;
        private System.Windows.Forms.RadioButton autoNo;
        private System.Windows.Forms.RadioButton autoScore;
        private System.Windows.Forms.RadioButton autoMove;
        private System.Windows.Forms.GroupBox climbBox;
        private System.Windows.Forms.RadioButton climbYes;
        private System.Windows.Forms.RadioButton climbNo;
        private System.Windows.Forms.Label debugLabel;
        private System.Windows.Forms.GroupBox colorWheelBox;
        private System.Windows.Forms.CheckBox wheelMatch;
        private System.Windows.Forms.CheckBox wheelSpin;
        private System.Windows.Forms.Label powerCellsTopLabel;
        private System.Windows.Forms.Button powerCellTopAdd;
        private System.Windows.Forms.Button powerCellsTopSubtract;
        private System.Windows.Forms.TextBox powerCellsTop;
        private System.Windows.Forms.Panel powerCellsTopBox;
        private System.Windows.Forms.Panel powerCellsBottomBox;
        private System.Windows.Forms.TextBox powerCellsBottom;
        private System.Windows.Forms.Button powerCellsBottomSubtract;
        private System.Windows.Forms.Button powerCellsBottomAdd;
        private System.Windows.Forms.Label powerCellsBottomLabel;
        private System.Windows.Forms.GroupBox powerCellsGroupBox;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Panel scoutingControlPanel;
        private System.Windows.Forms.Label currentRobotLabel;
        private System.Windows.Forms.TextBox currentRobot;
        private System.Windows.Forms.ProgressBar statusBar;
    }
}
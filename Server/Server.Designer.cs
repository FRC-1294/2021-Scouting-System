
namespace _1294_Scouting
{
    partial class Server
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.teamTable = new System.Windows.Forms.TableLayoutPanel();
            this.r1Label = new System.Windows.Forms.Label();
            this.r1Team = new System.Windows.Forms.Label();
            this.r2Input = new System.Windows.Forms.TextBox();
            this.r3Input = new System.Windows.Forms.TextBox();
            this.b1Input = new System.Windows.Forms.TextBox();
            this.b2Input = new System.Windows.Forms.TextBox();
            this.b3Input = new System.Windows.Forms.TextBox();
            this.r2Label = new System.Windows.Forms.Label();
            this.r3Label = new System.Windows.Forms.Label();
            this.b1Label = new System.Windows.Forms.Label();
            this.b2Label = new System.Windows.Forms.Label();
            this.b3Label = new System.Windows.Forms.Label();
            this.r2Team = new System.Windows.Forms.Label();
            this.r3Team = new System.Windows.Forms.Label();
            this.b1Team = new System.Windows.Forms.Label();
            this.b2Team = new System.Windows.Forms.Label();
            this.b3Team = new System.Windows.Forms.Label();
            this.r1Input = new System.Windows.Forms.TextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.progressBar3 = new System.Windows.Forms.ProgressBar();
            this.progressBar4 = new System.Windows.Forms.ProgressBar();
            this.progressBar5 = new System.Windows.Forms.ProgressBar();
            this.progressBar6 = new System.Windows.Forms.ProgressBar();
            this.sendButton = new System.Windows.Forms.Button();
            this.sendArm = new System.Windows.Forms.CheckBox();
            this.nextMatchBox = new System.Windows.Forms.GroupBox();
            this.aggregateButton = new System.Windows.Forms.Button();
            this.aggregationResult = new System.Windows.Forms.Label();
            this.teamTable.SuspendLayout();
            this.nextMatchBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(589, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(143, 20);
            this.textBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(475, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 44);
            this.button1.TabIndex = 2;
            this.button1.Text = "Get Data for This Team:";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // teamTable
            // 
            this.teamTable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.teamTable.ColumnCount = 4;
            this.teamTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 57F));
            this.teamTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 76F));
            this.teamTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 128F));
            this.teamTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140F));
            this.teamTable.Controls.Add(this.r1Label, 0, 0);
            this.teamTable.Controls.Add(this.r1Team, 1, 0);
            this.teamTable.Controls.Add(this.r2Input, 2, 1);
            this.teamTable.Controls.Add(this.r3Input, 2, 2);
            this.teamTable.Controls.Add(this.b1Input, 2, 3);
            this.teamTable.Controls.Add(this.b2Input, 2, 4);
            this.teamTable.Controls.Add(this.b3Input, 2, 5);
            this.teamTable.Controls.Add(this.r2Label, 0, 1);
            this.teamTable.Controls.Add(this.r3Label, 0, 2);
            this.teamTable.Controls.Add(this.b1Label, 0, 3);
            this.teamTable.Controls.Add(this.b2Label, 0, 4);
            this.teamTable.Controls.Add(this.b3Label, 0, 5);
            this.teamTable.Controls.Add(this.r2Team, 1, 1);
            this.teamTable.Controls.Add(this.r3Team, 1, 2);
            this.teamTable.Controls.Add(this.b1Team, 1, 3);
            this.teamTable.Controls.Add(this.b2Team, 1, 4);
            this.teamTable.Controls.Add(this.b3Team, 1, 5);
            this.teamTable.Controls.Add(this.r1Input, 2, 0);
            this.teamTable.Controls.Add(this.progressBar1, 3, 0);
            this.teamTable.Controls.Add(this.progressBar2, 3, 1);
            this.teamTable.Controls.Add(this.progressBar3, 3, 2);
            this.teamTable.Controls.Add(this.progressBar4, 3, 3);
            this.teamTable.Controls.Add(this.progressBar5, 3, 4);
            this.teamTable.Controls.Add(this.progressBar6, 3, 5);
            this.teamTable.Location = new System.Drawing.Point(6, 19);
            this.teamTable.Name = "teamTable";
            this.teamTable.RowCount = 6;
            this.teamTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.teamTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.teamTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.teamTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.teamTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.teamTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.teamTable.Size = new System.Drawing.Size(401, 224);
            this.teamTable.TabIndex = 3;
            // 
            // r1Label
            // 
            this.r1Label.AutoSize = true;
            this.r1Label.Location = new System.Drawing.Point(3, 0);
            this.r1Label.Name = "r1Label";
            this.r1Label.Size = new System.Drawing.Size(36, 13);
            this.r1Label.TabIndex = 4;
            this.r1Label.Text = "Red 1";
            // 
            // r1Team
            // 
            this.r1Team.AutoSize = true;
            this.r1Team.Location = new System.Drawing.Point(60, 0);
            this.r1Team.Name = "r1Team";
            this.r1Team.Size = new System.Drawing.Size(38, 13);
            this.r1Team.TabIndex = 5;
            this.r1Team.Text = "NONE";
            // 
            // r2Input
            // 
            this.r2Input.Location = new System.Drawing.Point(136, 40);
            this.r2Input.Name = "r2Input";
            this.r2Input.Size = new System.Drawing.Size(100, 20);
            this.r2Input.TabIndex = 6;
            // 
            // r3Input
            // 
            this.r3Input.Location = new System.Drawing.Point(136, 77);
            this.r3Input.Name = "r3Input";
            this.r3Input.Size = new System.Drawing.Size(100, 20);
            this.r3Input.TabIndex = 7;
            // 
            // b1Input
            // 
            this.b1Input.Location = new System.Drawing.Point(136, 114);
            this.b1Input.Name = "b1Input";
            this.b1Input.Size = new System.Drawing.Size(100, 20);
            this.b1Input.TabIndex = 8;
            // 
            // b2Input
            // 
            this.b2Input.Location = new System.Drawing.Point(136, 151);
            this.b2Input.Name = "b2Input";
            this.b2Input.Size = new System.Drawing.Size(100, 20);
            this.b2Input.TabIndex = 9;
            // 
            // b3Input
            // 
            this.b3Input.Location = new System.Drawing.Point(136, 188);
            this.b3Input.Name = "b3Input";
            this.b3Input.Size = new System.Drawing.Size(100, 20);
            this.b3Input.TabIndex = 10;
            // 
            // r2Label
            // 
            this.r2Label.AutoSize = true;
            this.r2Label.Location = new System.Drawing.Point(3, 37);
            this.r2Label.Name = "r2Label";
            this.r2Label.Size = new System.Drawing.Size(36, 13);
            this.r2Label.TabIndex = 11;
            this.r2Label.Text = "Red 2";
            // 
            // r3Label
            // 
            this.r3Label.AutoSize = true;
            this.r3Label.Location = new System.Drawing.Point(3, 74);
            this.r3Label.Name = "r3Label";
            this.r3Label.Size = new System.Drawing.Size(36, 13);
            this.r3Label.TabIndex = 12;
            this.r3Label.Text = "Red 3";
            // 
            // b1Label
            // 
            this.b1Label.AutoSize = true;
            this.b1Label.Location = new System.Drawing.Point(3, 111);
            this.b1Label.Name = "b1Label";
            this.b1Label.Size = new System.Drawing.Size(37, 13);
            this.b1Label.TabIndex = 13;
            this.b1Label.Text = "Blue 1";
            // 
            // b2Label
            // 
            this.b2Label.AutoSize = true;
            this.b2Label.Location = new System.Drawing.Point(3, 148);
            this.b2Label.Name = "b2Label";
            this.b2Label.Size = new System.Drawing.Size(37, 13);
            this.b2Label.TabIndex = 14;
            this.b2Label.Text = "Blue 2";
            // 
            // b3Label
            // 
            this.b3Label.AutoSize = true;
            this.b3Label.Location = new System.Drawing.Point(3, 185);
            this.b3Label.Name = "b3Label";
            this.b3Label.Size = new System.Drawing.Size(37, 13);
            this.b3Label.TabIndex = 15;
            this.b3Label.Text = "Blue 3";
            // 
            // r2Team
            // 
            this.r2Team.AutoSize = true;
            this.r2Team.Location = new System.Drawing.Point(60, 37);
            this.r2Team.Name = "r2Team";
            this.r2Team.Size = new System.Drawing.Size(38, 13);
            this.r2Team.TabIndex = 16;
            this.r2Team.Text = "NONE";
            // 
            // r3Team
            // 
            this.r3Team.AutoSize = true;
            this.r3Team.Location = new System.Drawing.Point(60, 74);
            this.r3Team.Name = "r3Team";
            this.r3Team.Size = new System.Drawing.Size(38, 13);
            this.r3Team.TabIndex = 17;
            this.r3Team.Text = "NONE";
            // 
            // b1Team
            // 
            this.b1Team.AutoSize = true;
            this.b1Team.Location = new System.Drawing.Point(60, 111);
            this.b1Team.Name = "b1Team";
            this.b1Team.Size = new System.Drawing.Size(38, 13);
            this.b1Team.TabIndex = 18;
            this.b1Team.Text = "NONE";
            // 
            // b2Team
            // 
            this.b2Team.AutoSize = true;
            this.b2Team.Location = new System.Drawing.Point(60, 148);
            this.b2Team.Name = "b2Team";
            this.b2Team.Size = new System.Drawing.Size(38, 13);
            this.b2Team.TabIndex = 19;
            this.b2Team.Text = "NONE";
            // 
            // b3Team
            // 
            this.b3Team.AutoSize = true;
            this.b3Team.Location = new System.Drawing.Point(60, 185);
            this.b3Team.Name = "b3Team";
            this.b3Team.Size = new System.Drawing.Size(38, 13);
            this.b3Team.TabIndex = 20;
            this.b3Team.Text = "NONE";
            // 
            // r1Input
            // 
            this.r1Input.Location = new System.Drawing.Point(136, 3);
            this.r1Input.Name = "r1Input";
            this.r1Input.Size = new System.Drawing.Size(100, 20);
            this.r1Input.TabIndex = 0;
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.Location = new System.Drawing.Point(264, 3);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(134, 23);
            this.progressBar1.TabIndex = 21;
            // 
            // progressBar2
            // 
            this.progressBar2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar2.Location = new System.Drawing.Point(264, 40);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(134, 23);
            this.progressBar2.TabIndex = 22;
            // 
            // progressBar3
            // 
            this.progressBar3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar3.Location = new System.Drawing.Point(264, 77);
            this.progressBar3.Name = "progressBar3";
            this.progressBar3.Size = new System.Drawing.Size(134, 23);
            this.progressBar3.TabIndex = 23;
            // 
            // progressBar4
            // 
            this.progressBar4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar4.Location = new System.Drawing.Point(264, 114);
            this.progressBar4.Name = "progressBar4";
            this.progressBar4.Size = new System.Drawing.Size(134, 23);
            this.progressBar4.TabIndex = 24;
            // 
            // progressBar5
            // 
            this.progressBar5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar5.Location = new System.Drawing.Point(264, 151);
            this.progressBar5.Name = "progressBar5";
            this.progressBar5.Size = new System.Drawing.Size(134, 23);
            this.progressBar5.TabIndex = 25;
            // 
            // progressBar6
            // 
            this.progressBar6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar6.Location = new System.Drawing.Point(264, 188);
            this.progressBar6.Name = "progressBar6";
            this.progressBar6.Size = new System.Drawing.Size(134, 23);
            this.progressBar6.TabIndex = 26;
            // 
            // sendButton
            // 
            this.sendButton.Enabled = false;
            this.sendButton.Location = new System.Drawing.Point(6, 286);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(261, 79);
            this.sendButton.TabIndex = 4;
            this.sendButton.Text = "disarmed";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // sendArm
            // 
            this.sendArm.AutoSize = true;
            this.sendArm.Location = new System.Drawing.Point(6, 263);
            this.sendArm.Name = "sendArm";
            this.sendArm.Size = new System.Drawing.Size(89, 17);
            this.sendArm.TabIndex = 5;
            this.sendArm.Text = "Check to arm";
            this.sendArm.UseVisualStyleBackColor = true;
            this.sendArm.CheckedChanged += new System.EventHandler(this.SendArm_CheckedChanged);
            // 
            // nextMatchBox
            // 
            this.nextMatchBox.Controls.Add(this.sendArm);
            this.nextMatchBox.Controls.Add(this.sendButton);
            this.nextMatchBox.Controls.Add(this.teamTable);
            this.nextMatchBox.Location = new System.Drawing.Point(12, 12);
            this.nextMatchBox.Name = "nextMatchBox";
            this.nextMatchBox.Size = new System.Drawing.Size(413, 377);
            this.nextMatchBox.TabIndex = 6;
            this.nextMatchBox.TabStop = false;
            this.nextMatchBox.Text = "Next Match";
            // 
            // aggregateButton
            // 
            this.aggregateButton.Location = new System.Drawing.Point(547, 131);
            this.aggregateButton.Name = "aggregateButton";
            this.aggregateButton.Size = new System.Drawing.Size(116, 23);
            this.aggregateButton.TabIndex = 7;
            this.aggregateButton.Text = "AGGREGATE";
            this.aggregateButton.UseVisualStyleBackColor = true;
            this.aggregateButton.Click += new System.EventHandler(this.AggregateButton_Click);
            // 
            // aggregationResult
            // 
            this.aggregationResult.AutoSize = true;
            this.aggregationResult.Location = new System.Drawing.Point(547, 161);
            this.aggregationResult.Name = "aggregationResult";
            this.aggregationResult.Size = new System.Drawing.Size(35, 13);
            this.aggregationResult.TabIndex = 8;
            this.aggregationResult.Text = "label1";
            // 
            // Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1121, 617);
            this.Controls.Add(this.aggregationResult);
            this.Controls.Add(this.aggregateButton);
            this.Controls.Add(this.nextMatchBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Name = "Server";
            this.Text = "Server";
            this.teamTable.ResumeLayout(false);
            this.teamTable.PerformLayout();
            this.nextMatchBox.ResumeLayout(false);
            this.nextMatchBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TableLayoutPanel teamTable;
        private System.Windows.Forms.Label r1Label;
        private System.Windows.Forms.Label r1Team;
        private System.Windows.Forms.TextBox r2Input;
        private System.Windows.Forms.TextBox r3Input;
        private System.Windows.Forms.TextBox b1Input;
        private System.Windows.Forms.TextBox b2Input;
        private System.Windows.Forms.TextBox b3Input;
        private System.Windows.Forms.Label r2Label;
        private System.Windows.Forms.Label r3Label;
        private System.Windows.Forms.Label b1Label;
        private System.Windows.Forms.Label b2Label;
        private System.Windows.Forms.Label b3Label;
        private System.Windows.Forms.Label r2Team;
        private System.Windows.Forms.Label r3Team;
        private System.Windows.Forms.Label b1Team;
        private System.Windows.Forms.Label b2Team;
        private System.Windows.Forms.Label b3Team;
        private System.Windows.Forms.TextBox r1Input;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.CheckBox sendArm;
        private System.Windows.Forms.GroupBox nextMatchBox;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.ProgressBar progressBar3;
        private System.Windows.Forms.ProgressBar progressBar4;
        private System.Windows.Forms.ProgressBar progressBar5;
        private System.Windows.Forms.ProgressBar progressBar6;
        private System.Windows.Forms.Button aggregateButton;
        private System.Windows.Forms.Label aggregationResult;
    }
}
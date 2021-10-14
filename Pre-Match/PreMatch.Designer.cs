namespace _1294_Scouting.Pre_Match
{
    partial class PreMatch
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
            this.otherComments = new System.Windows.Forms.TextBox();
            this.commentsBoxLabel = new System.Windows.Forms.Label();
            this.submitData = new System.Windows.Forms.Button();
            this.currentTeamBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.autoReliableBox = new System.Windows.Forms.ComboBox();
            this.autoGroup = new System.Windows.Forms.GroupBox();
            this.autoTypeBox = new System.Windows.Forms.ComboBox();
            this.autoFixBox = new System.Windows.Forms.CheckBox();
            this.powerCellsTypeBox = new System.Windows.Forms.ComboBox();
            this.powerCellsReliable = new System.Windows.Forms.ComboBox();
            this.powerCellsFix = new System.Windows.Forms.CheckBox();
            this.powerCellsGroup = new System.Windows.Forms.GroupBox();
            this.autoGroup.SuspendLayout();
            this.powerCellsGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // otherComments
            // 
            this.otherComments.Location = new System.Drawing.Point(525, 278);
            this.otherComments.Multiline = true;
            this.otherComments.Name = "otherComments";
            this.otherComments.Size = new System.Drawing.Size(267, 106);
            this.otherComments.TabIndex = 0;
            // 
            // commentsBoxLabel
            // 
            this.commentsBoxLabel.AutoSize = true;
            this.commentsBoxLabel.Location = new System.Drawing.Point(522, 253);
            this.commentsBoxLabel.Name = "commentsBoxLabel";
            this.commentsBoxLabel.Size = new System.Drawing.Size(88, 13);
            this.commentsBoxLabel.TabIndex = 1;
            this.commentsBoxLabel.Text = "Other Comments:";
            // 
            // submitData
            // 
            this.submitData.Location = new System.Drawing.Point(239, 399);
            this.submitData.Name = "submitData";
            this.submitData.Size = new System.Drawing.Size(292, 39);
            this.submitData.TabIndex = 2;
            this.submitData.Text = "Submit Data";
            this.submitData.UseVisualStyleBackColor = true;
            // 
            // currentTeamBox
            // 
            this.currentTeamBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentTeamBox.Location = new System.Drawing.Point(293, 25);
            this.currentTeamBox.Name = "currentTeamBox";
            this.currentTeamBox.Size = new System.Drawing.Size(102, 53);
            this.currentTeamBox.TabIndex = 3;
            this.currentTeamBox.Text = "1234";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(290, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Currently Scouting:";
            // 
            // autoReliableBox
            // 
            this.autoReliableBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.autoReliableBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.autoReliableBox.FormattingEnabled = true;
            this.autoReliableBox.Items.AddRange(new object[] {
            "Very Reliable",
            "Mostly Reliable",
            "Not Reliable"});
            this.autoReliableBox.Location = new System.Drawing.Point(17, 46);
            this.autoReliableBox.Name = "autoReliableBox";
            this.autoReliableBox.Size = new System.Drawing.Size(121, 21);
            this.autoReliableBox.TabIndex = 5;
            // 
            // autoGroup
            // 
            this.autoGroup.Controls.Add(this.autoFixBox);
            this.autoGroup.Controls.Add(this.autoTypeBox);
            this.autoGroup.Controls.Add(this.autoReliableBox);
            this.autoGroup.Location = new System.Drawing.Point(39, 88);
            this.autoGroup.Name = "autoGroup";
            this.autoGroup.Size = new System.Drawing.Size(151, 103);
            this.autoGroup.TabIndex = 6;
            this.autoGroup.TabStop = false;
            this.autoGroup.Text = "Autonomous";
            // 
            // autoTypeBox
            // 
            this.autoTypeBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.autoTypeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.autoTypeBox.FormattingEnabled = true;
            this.autoTypeBox.Items.AddRange(new object[] {
            "None",
            "Move",
            "Score",
            "Score a lot"});
            this.autoTypeBox.Location = new System.Drawing.Point(17, 19);
            this.autoTypeBox.Name = "autoTypeBox";
            this.autoTypeBox.Size = new System.Drawing.Size(121, 21);
            this.autoTypeBox.TabIndex = 6;
            // 
            // autoFixBox
            // 
            this.autoFixBox.AutoSize = true;
            this.autoFixBox.Location = new System.Drawing.Point(17, 73);
            this.autoFixBox.Name = "autoFixBox";
            this.autoFixBox.Size = new System.Drawing.Size(103, 17);
            this.autoFixBox.TabIndex = 7;
            this.autoFixBox.Text = "Working on a fix";
            this.autoFixBox.UseVisualStyleBackColor = true;
            // 
            // powerCellsTypeBox
            // 
            this.powerCellsTypeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.powerCellsTypeBox.FormattingEnabled = true;
            this.powerCellsTypeBox.Items.AddRange(new object[] {
            "Neither",
            "Top",
            "Bottom",
            "Both"});
            this.powerCellsTypeBox.Location = new System.Drawing.Point(6, 19);
            this.powerCellsTypeBox.Name = "powerCellsTypeBox";
            this.powerCellsTypeBox.Size = new System.Drawing.Size(121, 21);
            this.powerCellsTypeBox.TabIndex = 7;
            // 
            // powerCellsReliable
            // 
            this.powerCellsReliable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.powerCellsReliable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.powerCellsReliable.FormattingEnabled = true;
            this.powerCellsReliable.Items.AddRange(new object[] {
            "Very Reliable",
            "Mostly Reliable",
            "Not Reliable"});
            this.powerCellsReliable.Location = new System.Drawing.Point(6, 46);
            this.powerCellsReliable.Name = "powerCellsReliable";
            this.powerCellsReliable.Size = new System.Drawing.Size(121, 21);
            this.powerCellsReliable.TabIndex = 8;
            // 
            // powerCellsFix
            // 
            this.powerCellsFix.AutoSize = true;
            this.powerCellsFix.Location = new System.Drawing.Point(6, 73);
            this.powerCellsFix.Name = "powerCellsFix";
            this.powerCellsFix.Size = new System.Drawing.Size(103, 17);
            this.powerCellsFix.TabIndex = 8;
            this.powerCellsFix.Text = "Working on a fix";
            this.powerCellsFix.UseVisualStyleBackColor = true;
            // 
            // powerCellsGroup
            // 
            this.powerCellsGroup.Controls.Add(this.powerCellsReliable);
            this.powerCellsGroup.Controls.Add(this.powerCellsFix);
            this.powerCellsGroup.Controls.Add(this.powerCellsTypeBox);
            this.powerCellsGroup.Location = new System.Drawing.Point(196, 88);
            this.powerCellsGroup.Name = "powerCellsGroup";
            this.powerCellsGroup.Size = new System.Drawing.Size(151, 103);
            this.powerCellsGroup.TabIndex = 9;
            this.powerCellsGroup.TabStop = false;
            this.powerCellsGroup.Text = "Power Cells";
            // 
            // PreMatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.powerCellsGroup);
            this.Controls.Add(this.autoGroup);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.currentTeamBox);
            this.Controls.Add(this.submitData);
            this.Controls.Add(this.commentsBoxLabel);
            this.Controls.Add(this.otherComments);
            this.Name = "PreMatch";
            this.Text = "PreMatch";
            this.autoGroup.ResumeLayout(false);
            this.autoGroup.PerformLayout();
            this.powerCellsGroup.ResumeLayout(false);
            this.powerCellsGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox otherComments;
        private System.Windows.Forms.Label commentsBoxLabel;
        private System.Windows.Forms.Button submitData;
        private System.Windows.Forms.TextBox currentTeamBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox autoReliableBox;
        private System.Windows.Forms.GroupBox autoGroup;
        private System.Windows.Forms.ComboBox autoTypeBox;
        private System.Windows.Forms.CheckBox autoFixBox;
        private System.Windows.Forms.ComboBox powerCellsTypeBox;
        private System.Windows.Forms.ComboBox powerCellsReliable;
        private System.Windows.Forms.CheckBox powerCellsFix;
        private System.Windows.Forms.GroupBox powerCellsGroup;
    }
}
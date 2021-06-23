namespace TimeStamper
{
    partial class TimeStamperGUI
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
            this.txtPathToXml = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBrowseFolder = new System.Windows.Forms.Button();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.nudHours = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.nudMinutes = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.btnProcess = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_ChannelId = new System.Windows.Forms.Label();
            this.txtChannelId = new System.Windows.Forms.TextBox();
            this.btnOpenTarget = new System.Windows.Forms.Button();
            this.btnAcceptPath = new System.Windows.Forms.Button();
            this.Events = new System.Windows.Forms.Label();
            this.lstEvents = new System.Windows.Forms.ListBox();
            this.btnSelectEvent = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.nudMaxFiles = new System.Windows.Forms.NumericUpDown();
            this.nudIntervalInSecs = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.btnShowFirstItem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudHours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxFiles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudIntervalInSecs)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPathToXml
            // 
            this.txtPathToXml.Location = new System.Drawing.Point(8, 22);
            this.txtPathToXml.Margin = new System.Windows.Forms.Padding(2);
            this.txtPathToXml.Name = "txtPathToXml";
            this.txtPathToXml.ReadOnly = true;
            this.txtPathToXml.Size = new System.Drawing.Size(249, 20);
            this.txtPathToXml.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Path to XML source:";
            // 
            // btnBrowseFolder
            // 
            this.btnBrowseFolder.Location = new System.Drawing.Point(266, 22);
            this.btnBrowseFolder.Margin = new System.Windows.Forms.Padding(2);
            this.btnBrowseFolder.Name = "btnBrowseFolder";
            this.btnBrowseFolder.Size = new System.Drawing.Size(38, 21);
            this.btnBrowseFolder.TabIndex = 2;
            this.btnBrowseFolder.Text = "...";
            this.btnBrowseFolder.UseVisualStyleBackColor = true;
            this.btnBrowseFolder.Click += new System.EventHandler(this.btnBrowseFolder_Click);
            // 
            // datePicker
            // 
            this.datePicker.Location = new System.Drawing.Point(8, 308);
            this.datePicker.Margin = new System.Windows.Forms.Padding(2);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(148, 20);
            this.datePicker.TabIndex = 3;
            // 
            // nudHours
            // 
            this.nudHours.Location = new System.Drawing.Point(174, 308);
            this.nudHours.Margin = new System.Windows.Forms.Padding(2);
            this.nudHours.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.nudHours.Name = "nudHours";
            this.nudHours.Size = new System.Drawing.Size(60, 20);
            this.nudHours.TabIndex = 4;
            this.nudHours.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(171, 289);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Hours";
            // 
            // nudMinutes
            // 
            this.nudMinutes.Location = new System.Drawing.Point(237, 308);
            this.nudMinutes.Margin = new System.Windows.Forms.Padding(2);
            this.nudMinutes.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.nudMinutes.Name = "nudMinutes";
            this.nudMinutes.Size = new System.Drawing.Size(60, 20);
            this.nudMinutes.TabIndex = 4;
            this.nudMinutes.Value = new decimal(new int[] {
            34,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(235, 289);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Minutes";
            // 
            // btnProcess
            // 
            this.btnProcess.Location = new System.Drawing.Point(8, 465);
            this.btnProcess.Margin = new System.Windows.Forms.Padding(2);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(296, 47);
            this.btnProcess.TabIndex = 6;
            this.btnProcess.Text = "GO!";
            this.btnProcess.UseVisualStyleBackColor = true;
            this.btnProcess.Click += new System.EventHandler(this.BtnProcess_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 289);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Set new date";
            // 
            // lbl_ChannelId
            // 
            this.lbl_ChannelId.AutoSize = true;
            this.lbl_ChannelId.Location = new System.Drawing.Point(5, 341);
            this.lbl_ChannelId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_ChannelId.Name = "lbl_ChannelId";
            this.lbl_ChannelId.Size = new System.Drawing.Size(91, 13);
            this.lbl_ChannelId.TabIndex = 7;
            this.lbl_ChannelId.Text = "Set ChannelID to:";
            // 
            // txtChannelId
            // 
            this.txtChannelId.Location = new System.Drawing.Point(8, 356);
            this.txtChannelId.Margin = new System.Windows.Forms.Padding(2);
            this.txtChannelId.Name = "txtChannelId";
            this.txtChannelId.ReadOnly = true;
            this.txtChannelId.Size = new System.Drawing.Size(289, 20);
            this.txtChannelId.TabIndex = 8;
            // 
            // btnOpenTarget
            // 
            this.btnOpenTarget.Location = new System.Drawing.Point(9, 523);
            this.btnOpenTarget.Name = "btnOpenTarget";
            this.btnOpenTarget.Size = new System.Drawing.Size(101, 23);
            this.btnOpenTarget.TabIndex = 9;
            this.btnOpenTarget.Text = "Open target folder";
            this.btnOpenTarget.UseVisualStyleBackColor = true;
            this.btnOpenTarget.Click += new System.EventHandler(this.BtnOpenExplorer_Click);
            // 
            // btnAcceptPath
            // 
            this.btnAcceptPath.Location = new System.Drawing.Point(229, 47);
            this.btnAcceptPath.Name = "btnAcceptPath";
            this.btnAcceptPath.Size = new System.Drawing.Size(75, 23);
            this.btnAcceptPath.TabIndex = 11;
            this.btnAcceptPath.Text = "Set Path";
            this.btnAcceptPath.UseVisualStyleBackColor = true;
            this.btnAcceptPath.Click += new System.EventHandler(this.AcceptPath_Click);
            // 
            // Events
            // 
            this.Events.AutoSize = true;
            this.Events.Location = new System.Drawing.Point(6, 84);
            this.Events.Name = "Events";
            this.Events.Size = new System.Drawing.Size(116, 13);
            this.Events.TabIndex = 12;
            this.Events.Text = "Events Found in Folder";
            // 
            // lstEvents
            // 
            this.lstEvents.FormattingEnabled = true;
            this.lstEvents.Location = new System.Drawing.Point(8, 101);
            this.lstEvents.Name = "lstEvents";
            this.lstEvents.Size = new System.Drawing.Size(296, 134);
            this.lstEvents.TabIndex = 13;
            // 
            // btnSelectEvent
            // 
            this.btnSelectEvent.Location = new System.Drawing.Point(230, 241);
            this.btnSelectEvent.Name = "btnSelectEvent";
            this.btnSelectEvent.Size = new System.Drawing.Size(75, 23);
            this.btnSelectEvent.TabIndex = 14;
            this.btnSelectEvent.Text = "Select";
            this.btnSelectEvent.UseVisualStyleBackColor = true;
            this.btnSelectEvent.Click += new System.EventHandler(this.btnSelectEvent_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(105, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Set path to populate list";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 391);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Max number of files";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 428);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Interval between files (sec)";
            // 
            // nudMaxFiles
            // 
            this.nudMaxFiles.Location = new System.Drawing.Point(108, 389);
            this.nudMaxFiles.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudMaxFiles.Name = "nudMaxFiles";
            this.nudMaxFiles.Size = new System.Drawing.Size(126, 20);
            this.nudMaxFiles.TabIndex = 18;
            // 
            // nudIntervalInMin
            // 
            this.nudIntervalInSecs.Location = new System.Drawing.Point(143, 426);
            this.nudIntervalInSecs.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudIntervalInSecs.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudIntervalInSecs.Name = "nudIntervalInMin";
            this.nudIntervalInSecs.Size = new System.Drawing.Size(91, 20);
            this.nudIntervalInSecs.TabIndex = 19;
            this.nudIntervalInSecs.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(241, 391);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "(0 = no limit)";
            // 
            // btnShowFirstItem
            // 
            this.btnShowFirstItem.Location = new System.Drawing.Point(9, 241);
            this.btnShowFirstItem.Name = "btnShowFirstItem";
            this.btnShowFirstItem.Size = new System.Drawing.Size(101, 23);
            this.btnShowFirstItem.TabIndex = 21;
            this.btnShowFirstItem.Text = "Show first in set";
            this.btnShowFirstItem.UseVisualStyleBackColor = true;
            this.btnShowFirstItem.Click += new System.EventHandler(this.btnShowFirstItem_Click);
            // 
            // TimeStamperGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 554);
            this.Controls.Add(this.btnShowFirstItem);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.nudIntervalInSecs);
            this.Controls.Add(this.nudMaxFiles);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnSelectEvent);
            this.Controls.Add(this.lstEvents);
            this.Controls.Add(this.Events);
            this.Controls.Add(this.btnAcceptPath);
            this.Controls.Add(this.btnOpenTarget);
            this.Controls.Add(this.txtChannelId);
            this.Controls.Add(this.lbl_ChannelId);
            this.Controls.Add(this.btnProcess);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nudMinutes);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nudHours);
            this.Controls.Add(this.datePicker);
            this.Controls.Add(this.btnBrowseFolder);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPathToXml);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "TimeStamperGUI";
            this.Text = "BDF Time ReStamper";
            ((System.ComponentModel.ISupportInitialize)(this.nudHours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxFiles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudIntervalInSecs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPathToXml;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBrowseFolder;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.NumericUpDown nudHours;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudMinutes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_ChannelId;
        private System.Windows.Forms.TextBox txtChannelId;
        private System.Windows.Forms.Button btnOpenTarget;
        private System.Windows.Forms.Button btnAcceptPath;
        private System.Windows.Forms.Label Events;
        private System.Windows.Forms.ListBox lstEvents;
        private System.Windows.Forms.Button btnSelectEvent;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nudMaxFiles;
        private System.Windows.Forms.NumericUpDown nudIntervalInSecs;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnShowFirstItem;
    }
}


namespace TimeStamper
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
            this.txtPathToXml = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBrowseFolder = new System.Windows.Forms.Button();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.nudHours = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.nudMinutes = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.btnProcess = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudHours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinutes)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPathToXml
            // 
            this.txtPathToXml.Location = new System.Drawing.Point(17, 43);
            this.txtPathToXml.Name = "txtPathToXml";
            this.txtPathToXml.Size = new System.Drawing.Size(494, 31);
            this.txtPathToXml.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Path to xml file:";
            // 
            // btnBrowseFolder
            // 
            this.btnBrowseFolder.Location = new System.Drawing.Point(532, 43);
            this.btnBrowseFolder.Name = "btnBrowseFolder";
            this.btnBrowseFolder.Size = new System.Drawing.Size(75, 40);
            this.btnBrowseFolder.TabIndex = 2;
            this.btnBrowseFolder.Text = "...";
            this.btnBrowseFolder.UseVisualStyleBackColor = true;
            this.btnBrowseFolder.Click += new System.EventHandler(this.btnBrowseFolder_Click);
            // 
            // datePicker
            // 
            this.datePicker.Location = new System.Drawing.Point(17, 102);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(292, 31);
            this.datePicker.TabIndex = 3;
            // 
            // nudHours
            // 
            this.nudHours.Location = new System.Drawing.Point(18, 199);
            this.nudHours.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.nudHours.Name = "nudHours";
            this.nudHours.Size = new System.Drawing.Size(120, 31);
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
            this.label2.Location = new System.Drawing.Point(13, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Timer";
            // 
            // nudMinutes
            // 
            this.nudMinutes.Location = new System.Drawing.Point(145, 199);
            this.nudMinutes.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.nudMinutes.Name = "nudMinutes";
            this.nudMinutes.Size = new System.Drawing.Size(120, 31);
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
            this.label3.Location = new System.Drawing.Point(140, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Minutter";
            // 
            // btnProcess
            // 
            this.btnProcess.Location = new System.Drawing.Point(435, 257);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(172, 47);
            this.btnProcess.TabIndex = 6;
            this.btnProcess.Text = "GO!";
            this.btnProcess.UseVisualStyleBackColor = true;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 316);
            this.Controls.Add(this.btnProcess);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nudMinutes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nudHours);
            this.Controls.Add(this.datePicker);
            this.Controls.Add(this.btnBrowseFolder);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPathToXml);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nudHours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinutes)).EndInit();
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
    }
}



namespace barcodeLogParser
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
            this.ModeSelectionGroup = new System.Windows.Forms.GroupBox();
            this.FtpFileCheckBox = new System.Windows.Forms.CheckBox();
            this.LocalFileCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ParsingBtn = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.FtpGroup = new System.Windows.Forms.GroupBox();
            this.LocalGroup = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.ModeSelectionGroup.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.FtpGroup.SuspendLayout();
            this.LocalGroup.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // ModeSelectionGroup
            // 
            this.ModeSelectionGroup.Controls.Add(this.FtpFileCheckBox);
            this.ModeSelectionGroup.Controls.Add(this.LocalFileCheckBox);
            this.ModeSelectionGroup.Location = new System.Drawing.Point(38, 68);
            this.ModeSelectionGroup.Name = "ModeSelectionGroup";
            this.ModeSelectionGroup.Size = new System.Drawing.Size(132, 127);
            this.ModeSelectionGroup.TabIndex = 0;
            this.ModeSelectionGroup.TabStop = false;
            this.ModeSelectionGroup.Text = "Mode selection";
            // 
            // FtpFileCheckBox
            // 
            this.FtpFileCheckBox.AutoSize = true;
            this.FtpFileCheckBox.Location = new System.Drawing.Point(45, 73);
            this.FtpFileCheckBox.Name = "FtpFileCheckBox";
            this.FtpFileCheckBox.Size = new System.Drawing.Size(62, 17);
            this.FtpFileCheckBox.TabIndex = 1;
            this.FtpFileCheckBox.Text = "FTP file";
            this.FtpFileCheckBox.UseVisualStyleBackColor = true;
            this.FtpFileCheckBox.Click += new System.EventHandler(this.FtpFile_Click);
            // 
            // LocalFileCheckBox
            // 
            this.LocalFileCheckBox.AutoSize = true;
            this.LocalFileCheckBox.Checked = true;
            this.LocalFileCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.LocalFileCheckBox.Location = new System.Drawing.Point(45, 49);
            this.LocalFileCheckBox.Name = "LocalFileCheckBox";
            this.LocalFileCheckBox.Size = new System.Drawing.Size(68, 17);
            this.LocalFileCheckBox.TabIndex = 0;
            this.LocalFileCheckBox.Text = "Local file";
            this.LocalFileCheckBox.UseVisualStyleBackColor = true;
            this.LocalFileCheckBox.Click += new System.EventHandler(this.LocalFileCheckBox_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ParsingBtn);
            this.groupBox2.Location = new System.Drawing.Point(199, 68);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(267, 127);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Actions button";
            // 
            // ParsingBtn
            // 
            this.ParsingBtn.Location = new System.Drawing.Point(45, 49);
            this.ParsingBtn.Name = "ParsingBtn";
            this.ParsingBtn.Size = new System.Drawing.Size(173, 23);
            this.ParsingBtn.TabIndex = 0;
            this.ParsingBtn.Text = "Click to parse";
            this.ParsingBtn.UseVisualStyleBackColor = true;
            this.ParsingBtn.Click += new System.EventHandler(this.ParsingBtn_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Location = new System.Drawing.Point(6, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(428, 57);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "File path (SOURCE)";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 29);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(416, 20);
            this.textBox1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Location = new System.Drawing.Point(6, 82);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(428, 57);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "File path (DESTINATION)";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(6, 29);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(416, 20);
            this.textBox2.TabIndex = 0;
            // 
            // FtpGroup
            // 
            this.FtpGroup.Controls.Add(this.groupBox3);
            this.FtpGroup.Controls.Add(this.groupBox1);
            this.FtpGroup.Location = new System.Drawing.Point(123, 218);
            this.FtpGroup.Name = "FtpGroup";
            this.FtpGroup.Size = new System.Drawing.Size(442, 152);
            this.FtpGroup.TabIndex = 4;
            this.FtpGroup.TabStop = false;
            this.FtpGroup.Text = "FTP file";
            // 
            // LocalGroup
            // 
            this.LocalGroup.Controls.Add(this.groupBox5);
            this.LocalGroup.Controls.Add(this.groupBox6);
            this.LocalGroup.Location = new System.Drawing.Point(121, 218);
            this.LocalGroup.Name = "LocalGroup";
            this.LocalGroup.Size = new System.Drawing.Size(442, 152);
            this.LocalGroup.TabIndex = 5;
            this.LocalGroup.TabStop = false;
            this.LocalGroup.Text = "Local file";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.textBox3);
            this.groupBox5.Location = new System.Drawing.Point(6, 19);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(428, 57);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "File path (SOURCE)";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(6, 29);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(416, 20);
            this.textBox3.TabIndex = 0;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.textBox4);
            this.groupBox6.Location = new System.Drawing.Point(6, 82);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(428, 57);
            this.groupBox6.TabIndex = 3;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "File path (DESTINATION)";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(6, 29);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(416, 20);
            this.textBox4.TabIndex = 0;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(701, 410);
            this.Controls.Add(this.LocalGroup);
            this.Controls.Add(this.FtpGroup);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.ModeSelectionGroup);
            this.Name = "Form1";
            this.ModeSelectionGroup.ResumeLayout(false);
            this.ModeSelectionGroup.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.FtpGroup.ResumeLayout(false);
            this.LocalGroup.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox ModeSelectionGroup;
        private System.Windows.Forms.CheckBox FtpFileCheckBox;
        private System.Windows.Forms.CheckBox LocalFileCheckBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button ParsingBtn;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.GroupBox FtpGroup;
        private System.Windows.Forms.GroupBox LocalGroup;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox textBox4;
    }
}


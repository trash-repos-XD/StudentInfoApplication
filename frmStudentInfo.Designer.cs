﻿
namespace StudentInfoApplication
{
    partial class frmStudentInfo
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.studentId = new System.Windows.Forms.TextBox();
            this.lastName = new System.Windows.Forms.TextBox();
            this.firstName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.submitButton = new System.Windows.Forms.Button();
            this.studentIds = new System.Windows.Forms.ListBox();
            this.firstNames = new System.Windows.Forms.ListBox();
            this.lastNames = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // studentId
            // 
            this.studentId.Location = new System.Drawing.Point(13, 48);
            this.studentId.Name = "studentId";
            this.studentId.Size = new System.Drawing.Size(227, 23);
            this.studentId.TabIndex = 0;
            // 
            // lastName
            // 
            this.lastName.Location = new System.Drawing.Point(287, 48);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(227, 23);
            this.lastName.TabIndex = 1;
            // 
            // firstName
            // 
            this.firstName.Location = new System.Drawing.Point(561, 48);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(227, 23);
            this.firstName.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Student ID*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(287, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Last Name*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(561, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "First Name*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Student ID List";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(287, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "First Name List";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(561, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "Last Name List";
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(712, 78);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 23);
            this.submitButton.TabIndex = 12;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // studentIds
            // 
            this.studentIds.FormattingEnabled = true;
            this.studentIds.ItemHeight = 15;
            this.studentIds.Location = new System.Drawing.Point(12, 155);
            this.studentIds.Name = "studentIds";
            this.studentIds.Size = new System.Drawing.Size(227, 274);
            this.studentIds.TabIndex = 13;
            // 
            // firstNames
            // 
            this.firstNames.FormattingEnabled = true;
            this.firstNames.ItemHeight = 15;
            this.firstNames.Location = new System.Drawing.Point(287, 155);
            this.firstNames.Name = "firstNames";
            this.firstNames.Size = new System.Drawing.Size(227, 274);
            this.firstNames.TabIndex = 14;
            // 
            // lastNames
            // 
            this.lastNames.FormattingEnabled = true;
            this.lastNames.ItemHeight = 15;
            this.lastNames.Location = new System.Drawing.Point(560, 155);
            this.lastNames.Name = "lastNames";
            this.lastNames.Size = new System.Drawing.Size(227, 274);
            this.lastNames.TabIndex = 15;
            // 
            // frmStudentInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lastNames);
            this.Controls.Add(this.firstNames);
            this.Controls.Add(this.studentIds);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.firstName);
            this.Controls.Add(this.lastName);
            this.Controls.Add(this.studentId);
            this.Name = "frmStudentInfo";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox studentId;
        private System.Windows.Forms.TextBox lastName;
        private System.Windows.Forms.TextBox firstName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.ListBox studentIds;
        private System.Windows.Forms.ListBox firstNames;
        private System.Windows.Forms.ListBox lastNames;
    }
}


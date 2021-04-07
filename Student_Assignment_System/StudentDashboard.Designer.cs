﻿namespace Student_Assignment_System
{
    partial class StudentDashboard
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
            this.tcStudentDash = new System.Windows.Forms.TabControl();
            this.tbStudentDashboard = new System.Windows.Forms.TabPage();
            this.txtStudentAssignmentNum = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtStudentClassgroup = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtStudentCourse = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblStudentWelcome = new System.Windows.Forms.Label();
            this.tpStudentAssignments = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lvStudentAssignments = new System.Windows.Forms.ListView();
            this.chModule = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chLecturer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tpStudentLogout = new System.Windows.Forms.TabPage();
            this.tcStudentDash.SuspendLayout();
            this.tbStudentDashboard.SuspendLayout();
            this.tpStudentAssignments.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcStudentDash
            // 
            this.tcStudentDash.Controls.Add(this.tbStudentDashboard);
            this.tcStudentDash.Controls.Add(this.tpStudentAssignments);
            this.tcStudentDash.Controls.Add(this.tpStudentLogout);
            this.tcStudentDash.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcStudentDash.Location = new System.Drawing.Point(12, 12);
            this.tcStudentDash.Name = "tcStudentDash";
            this.tcStudentDash.SelectedIndex = 0;
            this.tcStudentDash.Size = new System.Drawing.Size(776, 426);
            this.tcStudentDash.TabIndex = 0;
            this.tcStudentDash.SelectedIndexChanged += new System.EventHandler(this.StudentFormIndexChange);
            // 
            // tbStudentDashboard
            // 
            this.tbStudentDashboard.Controls.Add(this.txtStudentAssignmentNum);
            this.tbStudentDashboard.Controls.Add(this.label5);
            this.tbStudentDashboard.Controls.Add(this.txtStudentClassgroup);
            this.tbStudentDashboard.Controls.Add(this.label4);
            this.tbStudentDashboard.Controls.Add(this.txtStudentCourse);
            this.tbStudentDashboard.Controls.Add(this.label3);
            this.tbStudentDashboard.Controls.Add(this.listBox1);
            this.tbStudentDashboard.Controls.Add(this.label1);
            this.tbStudentDashboard.Controls.Add(this.lblStudentWelcome);
            this.tbStudentDashboard.Location = new System.Drawing.Point(4, 29);
            this.tbStudentDashboard.Name = "tbStudentDashboard";
            this.tbStudentDashboard.Padding = new System.Windows.Forms.Padding(3);
            this.tbStudentDashboard.Size = new System.Drawing.Size(768, 393);
            this.tbStudentDashboard.TabIndex = 0;
            this.tbStudentDashboard.Text = "Dashboard";
            this.tbStudentDashboard.UseVisualStyleBackColor = true;
            // 
            // txtStudentAssignmentNum
            // 
            this.txtStudentAssignmentNum.Location = new System.Drawing.Point(250, 209);
            this.txtStudentAssignmentNum.Name = "txtStudentAssignmentNum";
            this.txtStudentAssignmentNum.Size = new System.Drawing.Size(189, 26);
            this.txtStudentAssignmentNum.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(36, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(208, 26);
            this.label5.TabIndex = 10;
            this.label5.Text = "No. of Assignments:";
            // 
            // txtStudentClassgroup
            // 
            this.txtStudentClassgroup.Location = new System.Drawing.Point(250, 167);
            this.txtStudentClassgroup.Name = "txtStudentClassgroup";
            this.txtStudentClassgroup.Size = new System.Drawing.Size(189, 26);
            this.txtStudentClassgroup.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(116, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 26);
            this.label4.TabIndex = 8;
            this.label4.Text = "Classgroup:";
            // 
            // txtStudentCourse
            // 
            this.txtStudentCourse.Location = new System.Drawing.Point(250, 127);
            this.txtStudentCourse.Name = "txtStudentCourse";
            this.txtStudentCourse.Size = new System.Drawing.Size(189, 26);
            this.txtStudentCourse.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(156, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 26);
            this.label3.TabIndex = 6;
            this.label3.Text = "Course:";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(545, 82);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(217, 304);
            this.listBox1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(605, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Deadlines";
            // 
            // lblStudentWelcome
            // 
            this.lblStudentWelcome.AutoSize = true;
            this.lblStudentWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentWelcome.Location = new System.Drawing.Point(35, 21);
            this.lblStudentWelcome.Name = "lblStudentWelcome";
            this.lblStudentWelcome.Size = new System.Drawing.Size(238, 31);
            this.lblStudentWelcome.TabIndex = 0;
            this.lblStudentWelcome.Text = "Welcome, { User } ";
            // 
            // tpStudentAssignments
            // 
            this.tpStudentAssignments.Controls.Add(this.button1);
            this.tpStudentAssignments.Controls.Add(this.textBox9);
            this.tpStudentAssignments.Controls.Add(this.label10);
            this.tpStudentAssignments.Controls.Add(this.textBox8);
            this.tpStudentAssignments.Controls.Add(this.label9);
            this.tpStudentAssignments.Controls.Add(this.textBox7);
            this.tpStudentAssignments.Controls.Add(this.label8);
            this.tpStudentAssignments.Controls.Add(this.textBox6);
            this.tpStudentAssignments.Controls.Add(this.label7);
            this.tpStudentAssignments.Controls.Add(this.textBox5);
            this.tpStudentAssignments.Controls.Add(this.label6);
            this.tpStudentAssignments.Controls.Add(this.lvStudentAssignments);
            this.tpStudentAssignments.Location = new System.Drawing.Point(4, 29);
            this.tpStudentAssignments.Name = "tpStudentAssignments";
            this.tpStudentAssignments.Padding = new System.Windows.Forms.Padding(3);
            this.tpStudentAssignments.Size = new System.Drawing.Size(768, 393);
            this.tpStudentAssignments.TabIndex = 1;
            this.tpStudentAssignments.Text = "Assignments";
            this.tpStudentAssignments.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(373, 344);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 32);
            this.button1.TabIndex = 11;
            this.button1.Text = "Complete";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(537, 258);
            this.textBox9.Multiline = true;
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(199, 118);
            this.textBox9.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(434, 261);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 20);
            this.label10.TabIndex = 9;
            this.label10.Text = "Description :";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(538, 203);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(199, 26);
            this.textBox8.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(455, 206);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 20);
            this.label9.TabIndex = 7;
            this.label9.Text = "Lecturer :";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(537, 150);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(200, 26);
            this.textBox7.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(445, 153);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 20);
            this.label8.TabIndex = 5;
            this.label8.Text = "Date Due :";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(537, 98);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(199, 26);
            this.textBox6.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(472, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 20);
            this.label7.TabIndex = 3;
            this.label7.Text = "Name :";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(537, 43);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(200, 26);
            this.textBox5.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(441, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Module ID :";
            // 
            // lvStudentAssignments
            // 
            this.lvStudentAssignments.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chModule,
            this.chName,
            this.chLecturer});
            this.lvStudentAssignments.GridLines = true;
            this.lvStudentAssignments.HideSelection = false;
            this.lvStudentAssignments.Location = new System.Drawing.Point(6, 18);
            this.lvStudentAssignments.Name = "lvStudentAssignments";
            this.lvStudentAssignments.Size = new System.Drawing.Size(361, 358);
            this.lvStudentAssignments.TabIndex = 0;
            this.lvStudentAssignments.UseCompatibleStateImageBehavior = false;
            this.lvStudentAssignments.View = System.Windows.Forms.View.Details;
            // 
            // chModule
            // 
            this.chModule.Text = "Module";
            this.chModule.Width = 110;
            // 
            // chName
            // 
            this.chName.Text = "Name";
            this.chName.Width = 110;
            // 
            // chLecturer
            // 
            this.chLecturer.Text = "Lecturer";
            this.chLecturer.Width = 135;
            // 
            // tpStudentLogout
            // 
            this.tpStudentLogout.Location = new System.Drawing.Point(4, 29);
            this.tpStudentLogout.Name = "tpStudentLogout";
            this.tpStudentLogout.Size = new System.Drawing.Size(768, 393);
            this.tpStudentLogout.TabIndex = 2;
            this.tpStudentLogout.Text = "Logout";
            this.tpStudentLogout.UseVisualStyleBackColor = true;
            // 
            // StudentDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tcStudentDash);
            this.Name = "StudentDashboard";
            this.Text = "StudentDashboard";
            this.tcStudentDash.ResumeLayout(false);
            this.tbStudentDashboard.ResumeLayout(false);
            this.tbStudentDashboard.PerformLayout();
            this.tpStudentAssignments.ResumeLayout(false);
            this.tpStudentAssignments.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcStudentDash;
        private System.Windows.Forms.TabPage tbStudentDashboard;
        private System.Windows.Forms.TabPage tpStudentAssignments;
        private System.Windows.Forms.TextBox txtStudentAssignmentNum;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtStudentClassgroup;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtStudentCourse;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblStudentWelcome;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListView lvStudentAssignments;
        private System.Windows.Forms.ColumnHeader chModule;
        private System.Windows.Forms.ColumnHeader chName;
        private System.Windows.Forms.ColumnHeader chLecturer;
        private System.Windows.Forms.TabPage tpStudentLogout;
    }
}
namespace Reminder
{
    partial class SettingNode
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbPriority = new System.Windows.Forms.Label();
            this.lbTime = new System.Windows.Forms.Label();
            this.lbContent = new System.Windows.Forms.Label();
            this.lbTitle = new System.Windows.Forms.Label();
            this.btnDontNeedTime = new System.Windows.Forms.Button();
            this.btnDone = new System.Windows.Forms.Button();
            this.txtContent = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbxBeforeMinutes = new System.Windows.Forms.ComboBox();
            this.cbxBeforeHours = new System.Windows.Forms.ComboBox();
            this.cbxBeforeDays = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxYear = new System.Windows.Forms.ComboBox();
            this.cbxMinute = new System.Windows.Forms.ComboBox();
            this.cbxMonth = new System.Windows.Forms.ComboBox();
            this.cbxHour = new System.Windows.Forms.ComboBox();
            this.cbxDay = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cbxPriority = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.cbxPriority);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.lbPriority);
            this.panel1.Controls.Add(this.lbTime);
            this.panel1.Controls.Add(this.lbContent);
            this.panel1.Controls.Add(this.lbTitle);
            this.panel1.Controls.Add(this.btnDontNeedTime);
            this.panel1.Controls.Add(this.btnDone);
            this.panel1.Controls.Add(this.txtContent);
            this.panel1.Controls.Add(this.txtTitle);
            this.panel1.Location = new System.Drawing.Point(13, 17);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(659, 591);
            this.panel1.TabIndex = 0;
            // 
            // lbPriority
            // 
            this.lbPriority.AutoSize = true;
            this.lbPriority.ForeColor = System.Drawing.Color.Red;
            this.lbPriority.Location = new System.Drawing.Point(265, 490);
            this.lbPriority.Name = "lbPriority";
            this.lbPriority.Size = new System.Drawing.Size(72, 19);
            this.lbPriority.TabIndex = 22;
            this.lbPriority.Text = "       ";
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.Location = new System.Drawing.Point(31, 362);
            this.lbTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(72, 19);
            this.lbTime.TabIndex = 20;
            this.lbTime.Text = "       ";
            // 
            // lbContent
            // 
            this.lbContent.AutoSize = true;
            this.lbContent.Location = new System.Drawing.Point(33, 110);
            this.lbContent.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbContent.Name = "lbContent";
            this.lbContent.Size = new System.Drawing.Size(63, 19);
            this.lbContent.TabIndex = 19;
            this.lbContent.Text = "      ";
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Location = new System.Drawing.Point(31, 23);
            this.lbTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(81, 19);
            this.lbTitle.TabIndex = 18;
            this.lbTitle.Text = "        ";
            // 
            // btnDontNeedTime
            // 
            this.btnDontNeedTime.Location = new System.Drawing.Point(74, 526);
            this.btnDontNeedTime.Margin = new System.Windows.Forms.Padding(6);
            this.btnDontNeedTime.Name = "btnDontNeedTime";
            this.btnDontNeedTime.Size = new System.Drawing.Size(168, 47);
            this.btnDontNeedTime.TabIndex = 16;
            this.btnDontNeedTime.Text = "Don\'t need time";
            this.btnDontNeedTime.UseVisualStyleBackColor = true;
            this.btnDontNeedTime.Click += new System.EventHandler(this.btnDontNeedTime_Click);
            // 
            // btnDone
            // 
            this.btnDone.Location = new System.Drawing.Point(302, 526);
            this.btnDone.Margin = new System.Windows.Forms.Padding(6);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(150, 47);
            this.btnDone.TabIndex = 15;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // txtContent
            // 
            this.txtContent.Location = new System.Drawing.Point(31, 135);
            this.txtContent.Margin = new System.Windows.Forms.Padding(6);
            this.txtContent.Multiline = true;
            this.txtContent.Name = "txtContent";
            this.txtContent.Size = new System.Drawing.Size(536, 210);
            this.txtContent.TabIndex = 14;
            this.txtContent.Text = "Content";
            this.txtContent.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtContent_MouseClick);
            this.txtContent.MouseLeave += new System.EventHandler(this.txtContent_MouseLeave);
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(31, 53);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(6);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(536, 26);
            this.txtTitle.TabIndex = 13;
            this.txtTitle.Text = "Title";
            this.txtTitle.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtTitle_MouseClick);
            this.txtTitle.MouseLeave += new System.EventHandler(this.txtTitle_MouseLeave);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cbxBeforeMinutes);
            this.panel2.Controls.Add(this.cbxBeforeHours);
            this.panel2.Controls.Add(this.cbxBeforeDays);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.cbxYear);
            this.panel2.Controls.Add(this.cbxMinute);
            this.panel2.Controls.Add(this.cbxMonth);
            this.panel2.Controls.Add(this.cbxHour);
            this.panel2.Controls.Add(this.cbxDay);
            this.panel2.Location = new System.Drawing.Point(31, 383);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(589, 98);
            this.panel2.TabIndex = 24;
            // 
            // cbxBeforeMinutes
            // 
            this.cbxBeforeMinutes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxBeforeMinutes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxBeforeMinutes.FormattingEnabled = true;
            this.cbxBeforeMinutes.Location = new System.Drawing.Point(334, 58);
            this.cbxBeforeMinutes.MaxDropDownItems = 5;
            this.cbxBeforeMinutes.Name = "cbxBeforeMinutes";
            this.cbxBeforeMinutes.Size = new System.Drawing.Size(52, 27);
            this.cbxBeforeMinutes.TabIndex = 9;
            // 
            // cbxBeforeHours
            // 
            this.cbxBeforeHours.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxBeforeHours.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxBeforeHours.FormattingEnabled = true;
            this.cbxBeforeHours.Location = new System.Drawing.Point(230, 58);
            this.cbxBeforeHours.MaxDropDownItems = 5;
            this.cbxBeforeHours.Name = "cbxBeforeHours";
            this.cbxBeforeHours.Size = new System.Drawing.Size(53, 27);
            this.cbxBeforeHours.TabIndex = 8;
            // 
            // cbxBeforeDays
            // 
            this.cbxBeforeDays.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxBeforeDays.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxBeforeDays.FormattingEnabled = true;
            this.cbxBeforeDays.Location = new System.Drawing.Point(129, 58);
            this.cbxBeforeDays.MaxDropDownItems = 5;
            this.cbxBeforeDays.Name = "cbxBeforeDays";
            this.cbxBeforeDays.Size = new System.Drawing.Size(53, 27);
            this.cbxBeforeDays.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(392, 61);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 19);
            this.label9.TabIndex = 20;
            this.label9.Text = "Minutes";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(280, 61);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 19);
            this.label8.TabIndex = 19;
            this.label8.Text = "Hours";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(184, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 19);
            this.label7.TabIndex = 18;
            this.label7.Text = "Days";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 19);
            this.label6.TabIndex = 17;
            this.label6.Text = "Alarm before";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(451, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 19);
            this.label5.TabIndex = 16;
            this.label5.Text = "Minute";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(341, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 19);
            this.label4.TabIndex = 15;
            this.label4.Text = "Hour";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(243, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 19);
            this.label3.TabIndex = 14;
            this.label3.Text = "Day";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 19);
            this.label2.TabIndex = 13;
            this.label2.Text = "Month";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 19);
            this.label1.TabIndex = 12;
            this.label1.Text = "Year";
            // 
            // cbxYear
            // 
            this.cbxYear.BackColor = System.Drawing.SystemColors.Window;
            this.cbxYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxYear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxYear.FormattingEnabled = true;
            this.cbxYear.Location = new System.Drawing.Point(39, 6);
            this.cbxYear.Margin = new System.Windows.Forms.Padding(4);
            this.cbxYear.Name = "cbxYear";
            this.cbxYear.Size = new System.Drawing.Size(63, 27);
            this.cbxYear.TabIndex = 2;
            // 
            // cbxMinute
            // 
            this.cbxMinute.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cbxMinute.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMinute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxMinute.FormattingEnabled = true;
            this.cbxMinute.Location = new System.Drawing.Point(514, 6);
            this.cbxMinute.Margin = new System.Windows.Forms.Padding(4);
            this.cbxMinute.Name = "cbxMinute";
            this.cbxMinute.Size = new System.Drawing.Size(55, 27);
            this.cbxMinute.TabIndex = 6;
            // 
            // cbxMonth
            // 
            this.cbxMonth.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cbxMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMonth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxMonth.FormattingEnabled = true;
            this.cbxMonth.Location = new System.Drawing.Point(179, 6);
            this.cbxMonth.Margin = new System.Windows.Forms.Padding(4);
            this.cbxMonth.Name = "cbxMonth";
            this.cbxMonth.Size = new System.Drawing.Size(57, 27);
            this.cbxMonth.TabIndex = 3;
            // 
            // cbxHour
            // 
            this.cbxHour.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cbxHour.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxHour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxHour.FormattingEnabled = true;
            this.cbxHour.Location = new System.Drawing.Point(393, 6);
            this.cbxHour.Margin = new System.Windows.Forms.Padding(4);
            this.cbxHour.Name = "cbxHour";
            this.cbxHour.Size = new System.Drawing.Size(51, 27);
            this.cbxHour.TabIndex = 5;
            // 
            // cbxDay
            // 
            this.cbxDay.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cbxDay.DropDownHeight = 100;
            this.cbxDay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxDay.FormattingEnabled = true;
            this.cbxDay.IntegralHeight = false;
            this.cbxDay.Location = new System.Drawing.Point(286, 6);
            this.cbxDay.Margin = new System.Windows.Forms.Padding(4);
            this.cbxDay.Name = "cbxDay";
            this.cbxDay.Size = new System.Drawing.Size(48, 27);
            this.cbxDay.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(37, 493);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 19);
            this.label10.TabIndex = 27;
            this.label10.Text = "Priority";
            // 
            // cbxPriority
            // 
            this.cbxPriority.BackColor = System.Drawing.SystemColors.Window;
            this.cbxPriority.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPriority.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxPriority.FormattingEnabled = true;
            this.cbxPriority.Location = new System.Drawing.Point(124, 490);
            this.cbxPriority.Name = "cbxPriority";
            this.cbxPriority.Size = new System.Drawing.Size(57, 27);
            this.cbxPriority.TabIndex = 26;
            // 
            // SettingNode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 615);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SettingNode";
            this.Text = "SettingNode";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDontNeedTime;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.TextBox txtContent;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.Label lbContent;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Label lbPriority;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cbxBeforeMinutes;
        private System.Windows.Forms.ComboBox cbxBeforeHours;
        private System.Windows.Forms.ComboBox cbxBeforeDays;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxYear;
        private System.Windows.Forms.ComboBox cbxMinute;
        private System.Windows.Forms.ComboBox cbxMonth;
        private System.Windows.Forms.ComboBox cbxHour;
        private System.Windows.Forms.ComboBox cbxDay;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbxPriority;
    }
}
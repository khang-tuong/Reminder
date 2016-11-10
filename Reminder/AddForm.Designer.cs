namespace Reminder
{
    partial class AddForm
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
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtContent = new System.Windows.Forms.TextBox();
            this.cbxYear = new System.Windows.Forms.ComboBox();
            this.cbxMonth = new System.Windows.Forms.ComboBox();
            this.cbxDay = new System.Windows.Forms.ComboBox();
            this.btnDone = new System.Windows.Forms.Button();
            this.lbTitle = new System.Windows.Forms.Label();
            this.lbContent = new System.Windows.Forms.Label();
            this.lbTime = new System.Windows.Forms.Label();
            this.btnDontNeedTime = new System.Windows.Forms.Button();
            this.cbxHour = new System.Windows.Forms.ComboBox();
            this.cbxMinute = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbxPriority = new System.Windows.Forms.ComboBox();
            this.lbPriority = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cbxBeforeDays = new System.Windows.Forms.ComboBox();
            this.cbxBeforeHours = new System.Windows.Forms.ComboBox();
            this.cbxBeforeMinutes = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(16, 17);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(4);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(291, 25);
            this.txtTitle.TabIndex = 0;
            this.txtTitle.Text = "Title";
            this.txtTitle.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtTitle_MouseClick);
            this.txtTitle.Leave += new System.EventHandler(this.txtTitle_Leave);
            // 
            // txtContent
            // 
            this.txtContent.Location = new System.Drawing.Point(16, 97);
            this.txtContent.Margin = new System.Windows.Forms.Padding(4);
            this.txtContent.Multiline = true;
            this.txtContent.Name = "txtContent";
            this.txtContent.Size = new System.Drawing.Size(536, 201);
            this.txtContent.TabIndex = 1;
            this.txtContent.Text = "Content";
            this.txtContent.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBox2_MouseClick);
            this.txtContent.Leave += new System.EventHandler(this.txtContent_Leave);
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
            this.cbxYear.Size = new System.Drawing.Size(63, 26);
            this.cbxYear.TabIndex = 2;
            // 
            // cbxMonth
            // 
            this.cbxMonth.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cbxMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMonth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxMonth.FormattingEnabled = true;
            this.cbxMonth.Location = new System.Drawing.Point(154, 6);
            this.cbxMonth.Margin = new System.Windows.Forms.Padding(4);
            this.cbxMonth.Name = "cbxMonth";
            this.cbxMonth.Size = new System.Drawing.Size(57, 26);
            this.cbxMonth.TabIndex = 3;
            // 
            // cbxDay
            // 
            this.cbxDay.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cbxDay.DropDownHeight = 100;
            this.cbxDay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxDay.FormattingEnabled = true;
            this.cbxDay.IntegralHeight = false;
            this.cbxDay.Location = new System.Drawing.Point(253, 6);
            this.cbxDay.Margin = new System.Windows.Forms.Padding(4);
            this.cbxDay.Name = "cbxDay";
            this.cbxDay.Size = new System.Drawing.Size(48, 26);
            this.cbxDay.TabIndex = 4;
            this.cbxDay.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cbxDay_MouseClick);
            // 
            // btnDone
            // 
            this.btnDone.Location = new System.Drawing.Point(352, 504);
            this.btnDone.Margin = new System.Windows.Forms.Padding(4);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(100, 32);
            this.btnDone.TabIndex = 12;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Location = new System.Drawing.Point(317, 25);
            this.lbTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(0, 18);
            this.lbTitle.TabIndex = 6;
            // 
            // lbContent
            // 
            this.lbContent.AutoSize = true;
            this.lbContent.Location = new System.Drawing.Point(16, 75);
            this.lbContent.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbContent.Name = "lbContent";
            this.lbContent.Size = new System.Drawing.Size(0, 18);
            this.lbContent.TabIndex = 7;
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.Location = new System.Drawing.Point(19, 327);
            this.lbTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(0, 18);
            this.lbTime.TabIndex = 8;
            // 
            // btnDontNeedTime
            // 
            this.btnDontNeedTime.Location = new System.Drawing.Point(101, 504);
            this.btnDontNeedTime.Margin = new System.Windows.Forms.Padding(4);
            this.btnDontNeedTime.Name = "btnDontNeedTime";
            this.btnDontNeedTime.Size = new System.Drawing.Size(160, 32);
            this.btnDontNeedTime.TabIndex = 11;
            this.btnDontNeedTime.Text = "Don\'t need time";
            this.btnDontNeedTime.UseVisualStyleBackColor = true;
            this.btnDontNeedTime.Click += new System.EventHandler(this.btnDontNeedTime_Click);
            // 
            // cbxHour
            // 
            this.cbxHour.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cbxHour.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxHour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxHour.FormattingEnabled = true;
            this.cbxHour.Location = new System.Drawing.Point(346, 6);
            this.cbxHour.Margin = new System.Windows.Forms.Padding(4);
            this.cbxHour.Name = "cbxHour";
            this.cbxHour.Size = new System.Drawing.Size(51, 26);
            this.cbxHour.TabIndex = 5;
            // 
            // cbxMinute
            // 
            this.cbxMinute.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cbxMinute.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMinute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxMinute.FormattingEnabled = true;
            this.cbxMinute.Location = new System.Drawing.Point(467, 6);
            this.cbxMinute.Margin = new System.Windows.Forms.Padding(4);
            this.cbxMinute.Name = "cbxMinute";
            this.cbxMinute.Size = new System.Drawing.Size(55, 26);
            this.cbxMinute.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbxBeforeMinutes);
            this.panel1.Controls.Add(this.cbxBeforeHours);
            this.panel1.Controls.Add(this.cbxBeforeDays);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cbxYear);
            this.panel1.Controls.Add(this.cbxMinute);
            this.panel1.Controls.Add(this.cbxMonth);
            this.panel1.Controls.Add(this.cbxHour);
            this.panel1.Controls.Add(this.cbxDay);
            this.panel1.Location = new System.Drawing.Point(16, 348);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(536, 98);
            this.panel1.TabIndex = 12;
            // 
            // cbxPriority
            // 
            this.cbxPriority.BackColor = System.Drawing.SystemColors.Window;
            this.cbxPriority.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPriority.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxPriority.FormattingEnabled = true;
            this.cbxPriority.Location = new System.Drawing.Point(92, 462);
            this.cbxPriority.Name = "cbxPriority";
            this.cbxPriority.Size = new System.Drawing.Size(57, 26);
            this.cbxPriority.TabIndex = 10;
            // 
            // lbPriority
            // 
            this.lbPriority.AutoSize = true;
            this.lbPriority.ForeColor = System.Drawing.Color.Red;
            this.lbPriority.Location = new System.Drawing.Point(283, 465);
            this.lbPriority.Name = "lbPriority";
            this.lbPriority.Size = new System.Drawing.Size(64, 18);
            this.lbPriority.TabIndex = 24;
            this.lbPriority.Text = "       ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 18);
            this.label1.TabIndex = 12;
            this.label1.Text = "Year";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(109, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 18);
            this.label2.TabIndex = 13;
            this.label2.Text = "Month";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(218, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 18);
            this.label3.TabIndex = 14;
            this.label3.Text = "Day";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(308, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 18);
            this.label4.TabIndex = 15;
            this.label4.Text = "Hour";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(404, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 18);
            this.label5.TabIndex = 16;
            this.label5.Text = "Minute";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 18);
            this.label6.TabIndex = 17;
            this.label6.Text = "Alarm before";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(171, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 18);
            this.label7.TabIndex = 18;
            this.label7.Text = "Days";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(267, 61);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 18);
            this.label8.TabIndex = 19;
            this.label8.Text = "Hours";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(379, 61);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 18);
            this.label9.TabIndex = 20;
            this.label9.Text = "Minutes";
            // 
            // cbxBeforeDays
            // 
            this.cbxBeforeDays.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxBeforeDays.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxBeforeDays.FormattingEnabled = true;
            this.cbxBeforeDays.Location = new System.Drawing.Point(116, 58);
            this.cbxBeforeDays.MaxDropDownItems = 5;
            this.cbxBeforeDays.Name = "cbxBeforeDays";
            this.cbxBeforeDays.Size = new System.Drawing.Size(53, 26);
            this.cbxBeforeDays.TabIndex = 7;
            // 
            // cbxBeforeHours
            // 
            this.cbxBeforeHours.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxBeforeHours.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxBeforeHours.FormattingEnabled = true;
            this.cbxBeforeHours.Location = new System.Drawing.Point(217, 58);
            this.cbxBeforeHours.MaxDropDownItems = 5;
            this.cbxBeforeHours.Name = "cbxBeforeHours";
            this.cbxBeforeHours.Size = new System.Drawing.Size(53, 26);
            this.cbxBeforeHours.TabIndex = 8;
            // 
            // cbxBeforeMinutes
            // 
            this.cbxBeforeMinutes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxBeforeMinutes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxBeforeMinutes.FormattingEnabled = true;
            this.cbxBeforeMinutes.Location = new System.Drawing.Point(321, 58);
            this.cbxBeforeMinutes.MaxDropDownItems = 5;
            this.cbxBeforeMinutes.Name = "cbxBeforeMinutes";
            this.cbxBeforeMinutes.Size = new System.Drawing.Size(52, 26);
            this.cbxBeforeMinutes.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(19, 465);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 18);
            this.label10.TabIndex = 25;
            this.label10.Text = "Priority";
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 549);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cbxPriority);
            this.Controls.Add(this.lbPriority);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnDontNeedTime);
            this.Controls.Add(this.lbTime);
            this.Controls.Add(this.lbContent);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.txtContent);
            this.Controls.Add(this.txtTitle);
            this.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddForm";
            this.Text = "AddForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtContent;
        private System.Windows.Forms.ComboBox cbxYear;
        private System.Windows.Forms.ComboBox cbxMonth;
        private System.Windows.Forms.ComboBox cbxDay;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Label lbContent;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.Button btnDontNeedTime;
        private System.Windows.Forms.ComboBox cbxHour;
        private System.Windows.Forms.ComboBox cbxMinute;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbxPriority;
        private System.Windows.Forms.Label lbPriority;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbxBeforeMinutes;
        private System.Windows.Forms.ComboBox cbxBeforeHours;
        private System.Windows.Forms.ComboBox cbxBeforeDays;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
    }
}
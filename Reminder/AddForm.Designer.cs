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
            this.btnDone = new System.Windows.Forms.Button();
            this.lbTitle = new System.Windows.Forms.Label();
            this.lbContent = new System.Windows.Forms.Label();
            this.lbTime = new System.Windows.Forms.Label();
            this.btnDontNeedTime = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbxSnoozeNeed = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSnoozeTime = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxPriority = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbNotification = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
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
            this.txtContent.Location = new System.Drawing.Point(16, 50);
            this.txtContent.Margin = new System.Windows.Forms.Padding(4);
            this.txtContent.Multiline = true;
            this.txtContent.Name = "txtContent";
            this.txtContent.Size = new System.Drawing.Size(536, 201);
            this.txtContent.TabIndex = 1;
            this.txtContent.Text = "Content";
            this.txtContent.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBox2_MouseClick);
            this.txtContent.Leave += new System.EventHandler(this.txtContent_Leave);
            // 
            // btnDone
            // 
            this.btnDone.Location = new System.Drawing.Point(350, 433);
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
            this.btnDontNeedTime.Location = new System.Drawing.Point(99, 433);
            this.btnDontNeedTime.Margin = new System.Windows.Forms.Padding(4);
            this.btnDontNeedTime.Name = "btnDontNeedTime";
            this.btnDontNeedTime.Size = new System.Drawing.Size(160, 32);
            this.btnDontNeedTime.TabIndex = 11;
            this.btnDontNeedTime.Text = "Don\'t need time";
            this.btnDontNeedTime.UseVisualStyleBackColor = true;
            this.btnDontNeedTime.Click += new System.EventHandler(this.btnDontNeedTime_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.cbxSnoozeNeed);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtSnoozeTime);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(16, 317);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(536, 52);
            this.panel1.TabIndex = 12;
            // 
            // cbxSnoozeNeed
            // 
            this.cbxSnoozeNeed.AutoSize = true;
            this.cbxSnoozeNeed.Location = new System.Drawing.Point(120, 17);
            this.cbxSnoozeNeed.Name = "cbxSnoozeNeed";
            this.cbxSnoozeNeed.Size = new System.Drawing.Size(15, 14);
            this.cbxSnoozeNeed.TabIndex = 24;
            this.cbxSnoozeNeed.UseVisualStyleBackColor = true;
            this.cbxSnoozeNeed.CheckedChanged += new System.EventHandler(this.cbxSnoozeNeed_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(337, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 18);
            this.label2.TabIndex = 23;
            this.label2.Text = "minute(s)";
            // 
            // txtSnoozeTime
            // 
            this.txtSnoozeTime.Enabled = false;
            this.txtSnoozeTime.Location = new System.Drawing.Point(231, 11);
            this.txtSnoozeTime.Name = "txtSnoozeTime";
            this.txtSnoozeTime.Size = new System.Drawing.Size(100, 25);
            this.txtSnoozeTime.TabIndex = 22;
            this.txtSnoozeTime.Text = "0";
            this.txtSnoozeTime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSnoozeTime_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 18);
            this.label1.TabIndex = 21;
            this.label1.Text = "Snooze";
            // 
            // cbxPriority
            // 
            this.cbxPriority.BackColor = System.Drawing.SystemColors.Window;
            this.cbxPriority.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPriority.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxPriority.FormattingEnabled = true;
            this.cbxPriority.Location = new System.Drawing.Point(120, 9);
            this.cbxPriority.Name = "cbxPriority";
            this.cbxPriority.Size = new System.Drawing.Size(297, 26);
            this.cbxPriority.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(19, 12);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 18);
            this.label10.TabIndex = 25;
            this.label10.Text = "Priority";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.dateTimePicker);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Location = new System.Drawing.Point(16, 258);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(536, 53);
            this.panel2.TabIndex = 26;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker.Location = new System.Drawing.Point(120, 10);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(297, 25);
            this.dateTimePicker.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(14, 10);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(88, 18);
            this.label11.TabIndex = 0;
            this.label11.Text = "Alarm when";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.cbxPriority);
            this.panel3.Location = new System.Drawing.Point(16, 375);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(536, 43);
            this.panel3.TabIndex = 27;
            // 
            // lbNotification
            // 
            this.lbNotification.AutoSize = true;
            this.lbNotification.BackColor = System.Drawing.Color.White;
            this.lbNotification.ForeColor = System.Drawing.Color.Red;
            this.lbNotification.Location = new System.Drawing.Point(22, 475);
            this.lbNotification.Name = "lbNotification";
            this.lbNotification.Size = new System.Drawing.Size(56, 18);
            this.lbNotification.TabIndex = 28;
            this.lbNotification.Text = "label3";
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 500);
            this.Controls.Add(this.lbNotification);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
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
            this.Text = "Create an alarm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtContent;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Label lbContent;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.Button btnDontNeedTime;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbxPriority;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox cbxSnoozeNeed;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSnoozeTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbNotification;
    }
}
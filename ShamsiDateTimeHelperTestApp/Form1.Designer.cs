namespace ShamsiDateTimeHelperTestApp
{
    partial class Form1
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
            this.btnNow = new System.Windows.Forms.Button();
            this.txtInputGregorian = new System.Windows.Forms.TextBox();
            this.btnDateTimeNow = new System.Windows.Forms.Button();
            this.btnToday = new System.Windows.Forms.Button();
            this.rbGregorian = new System.Windows.Forms.RadioButton();
            this.rbShamsi = new System.Windows.Forms.RadioButton();
            this.rbParts = new System.Windows.Forms.RadioButton();
            this.txtInputShamsi = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.txtMonth = new System.Windows.Forms.TextBox();
            this.txtDay = new System.Windows.Forms.TextBox();
            this.txtHour = new System.Windows.Forms.TextBox();
            this.txtMinute = new System.Windows.Forms.TextBox();
            this.txtSecond = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gbConstructors = new System.Windows.Forms.GroupBox();
            this.btnTimeStringWithoutLeadingZero = new System.Windows.Forms.Button();
            this.btnTimeString = new System.Windows.Forms.Button();
            this.btnDateTimeStringWithoutLeadingZero = new System.Windows.Forms.Button();
            this.btnDateStringWithoutLeadingZero = new System.Windows.Forms.Button();
            this.btnDateTimeString = new System.Windows.Forms.Button();
            this.btnDateString = new System.Windows.Forms.Button();
            this.gbStaticMembers = new System.Windows.Forms.GroupBox();
            this.gbConstructors.SuspendLayout();
            this.gbStaticMembers.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNow
            // 
            this.btnNow.Location = new System.Drawing.Point(14, 22);
            this.btnNow.Name = "btnNow";
            this.btnNow.Size = new System.Drawing.Size(334, 23);
            this.btnNow.TabIndex = 0;
            this.btnNow.Text = "Now";
            this.btnNow.UseVisualStyleBackColor = true;
            this.btnNow.Click += new System.EventHandler(this.btnNow_Click);
            // 
            // txtInputGregorian
            // 
            this.txtInputGregorian.Location = new System.Drawing.Point(95, 30);
            this.txtInputGregorian.Name = "txtInputGregorian";
            this.txtInputGregorian.Size = new System.Drawing.Size(190, 23);
            this.txtInputGregorian.TabIndex = 1;
            // 
            // btnDateTimeNow
            // 
            this.btnDateTimeNow.Location = new System.Drawing.Point(293, 30);
            this.btnDateTimeNow.Name = "btnDateTimeNow";
            this.btnDateTimeNow.Size = new System.Drawing.Size(57, 23);
            this.btnDateTimeNow.TabIndex = 2;
            this.btnDateTimeNow.Text = "<- Now";
            this.btnDateTimeNow.UseVisualStyleBackColor = true;
            this.btnDateTimeNow.Click += new System.EventHandler(this.btnDateTimeNow_Click);
            // 
            // btnToday
            // 
            this.btnToday.Location = new System.Drawing.Point(14, 51);
            this.btnToday.Name = "btnToday";
            this.btnToday.Size = new System.Drawing.Size(334, 23);
            this.btnToday.TabIndex = 0;
            this.btnToday.Text = "Today";
            this.btnToday.UseVisualStyleBackColor = true;
            this.btnToday.Click += new System.EventHandler(this.btnToday_Click);
            // 
            // rbGregorian
            // 
            this.rbGregorian.AutoSize = true;
            this.rbGregorian.Checked = true;
            this.rbGregorian.Location = new System.Drawing.Point(6, 32);
            this.rbGregorian.Name = "rbGregorian";
            this.rbGregorian.Size = new System.Drawing.Size(83, 19);
            this.rbGregorian.TabIndex = 4;
            this.rbGregorian.TabStop = true;
            this.rbGregorian.Text = "Gregorian :";
            this.rbGregorian.UseVisualStyleBackColor = true;
            // 
            // rbShamsi
            // 
            this.rbShamsi.AutoSize = true;
            this.rbShamsi.Location = new System.Drawing.Point(6, 68);
            this.rbShamsi.Name = "rbShamsi";
            this.rbShamsi.Size = new System.Drawing.Size(119, 19);
            this.rbShamsi.TabIndex = 5;
            this.rbShamsi.Text = "ShamsiDateTime :";
            this.rbShamsi.UseVisualStyleBackColor = true;
            // 
            // rbParts
            // 
            this.rbParts.AutoSize = true;
            this.rbParts.Location = new System.Drawing.Point(6, 104);
            this.rbParts.Name = "rbParts";
            this.rbParts.Size = new System.Drawing.Size(78, 19);
            this.rbParts.TabIndex = 6;
            this.rbParts.Text = "Date Parts";
            this.rbParts.UseVisualStyleBackColor = true;
            // 
            // txtInputShamsi
            // 
            this.txtInputShamsi.Location = new System.Drawing.Point(131, 66);
            this.txtInputShamsi.Name = "txtInputShamsi";
            this.txtInputShamsi.Size = new System.Drawing.Size(219, 23);
            this.txtInputShamsi.TabIndex = 7;
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(86, 102);
            this.txtYear.Name = "txtYear";
            this.txtYear.PlaceholderText = "YYYY";
            this.txtYear.Size = new System.Drawing.Size(39, 23);
            this.txtYear.TabIndex = 8;
            this.txtYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMonth
            // 
            this.txtMonth.Location = new System.Drawing.Point(141, 102);
            this.txtMonth.Name = "txtMonth";
            this.txtMonth.PlaceholderText = "MM";
            this.txtMonth.Size = new System.Drawing.Size(29, 23);
            this.txtMonth.TabIndex = 9;
            this.txtMonth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDay
            // 
            this.txtDay.Location = new System.Drawing.Point(186, 102);
            this.txtDay.Name = "txtDay";
            this.txtDay.PlaceholderText = "DD";
            this.txtDay.Size = new System.Drawing.Size(29, 23);
            this.txtDay.TabIndex = 10;
            this.txtDay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtHour
            // 
            this.txtHour.Location = new System.Drawing.Point(231, 102);
            this.txtHour.Name = "txtHour";
            this.txtHour.PlaceholderText = "HH";
            this.txtHour.Size = new System.Drawing.Size(29, 23);
            this.txtHour.TabIndex = 11;
            this.txtHour.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMinute
            // 
            this.txtMinute.Location = new System.Drawing.Point(276, 102);
            this.txtMinute.Name = "txtMinute";
            this.txtMinute.PlaceholderText = "MM";
            this.txtMinute.Size = new System.Drawing.Size(29, 23);
            this.txtMinute.TabIndex = 12;
            this.txtMinute.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSecond
            // 
            this.txtSecond.Location = new System.Drawing.Point(321, 102);
            this.txtSecond.Name = "txtSecond";
            this.txtSecond.PlaceholderText = "SS";
            this.txtSecond.Size = new System.Drawing.Size(29, 23);
            this.txtSecond.TabIndex = 13;
            this.txtSecond.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(127, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(12, 15);
            this.label1.TabIndex = 14;
            this.label1.Text = "/";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(172, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(12, 15);
            this.label2.TabIndex = 14;
            this.label2.Text = "/";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(263, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(10, 15);
            this.label3.TabIndex = 14;
            this.label3.Text = ":";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(308, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(10, 15);
            this.label4.TabIndex = 14;
            this.label4.Text = ":";
            // 
            // gbConstructors
            // 
            this.gbConstructors.Controls.Add(this.btnTimeStringWithoutLeadingZero);
            this.gbConstructors.Controls.Add(this.btnTimeString);
            this.gbConstructors.Controls.Add(this.btnDateTimeStringWithoutLeadingZero);
            this.gbConstructors.Controls.Add(this.btnDateStringWithoutLeadingZero);
            this.gbConstructors.Controls.Add(this.btnDateTimeString);
            this.gbConstructors.Controls.Add(this.btnDateString);
            this.gbConstructors.Controls.Add(this.rbGregorian);
            this.gbConstructors.Controls.Add(this.label4);
            this.gbConstructors.Controls.Add(this.btnDateTimeNow);
            this.gbConstructors.Controls.Add(this.label3);
            this.gbConstructors.Controls.Add(this.txtInputGregorian);
            this.gbConstructors.Controls.Add(this.label2);
            this.gbConstructors.Controls.Add(this.rbShamsi);
            this.gbConstructors.Controls.Add(this.label1);
            this.gbConstructors.Controls.Add(this.rbParts);
            this.gbConstructors.Controls.Add(this.txtSecond);
            this.gbConstructors.Controls.Add(this.txtInputShamsi);
            this.gbConstructors.Controls.Add(this.txtMinute);
            this.gbConstructors.Controls.Add(this.txtYear);
            this.gbConstructors.Controls.Add(this.txtHour);
            this.gbConstructors.Controls.Add(this.txtMonth);
            this.gbConstructors.Controls.Add(this.txtDay);
            this.gbConstructors.Location = new System.Drawing.Point(19, 110);
            this.gbConstructors.Name = "gbConstructors";
            this.gbConstructors.Size = new System.Drawing.Size(365, 334);
            this.gbConstructors.TabIndex = 15;
            this.gbConstructors.TabStop = false;
            this.gbConstructors.Text = "Initialized Members";
            // 
            // btnTimeStringWithoutLeadingZero
            // 
            this.btnTimeStringWithoutLeadingZero.BackColor = System.Drawing.Color.Azure;
            this.btnTimeStringWithoutLeadingZero.Location = new System.Drawing.Point(12, 293);
            this.btnTimeStringWithoutLeadingZero.Name = "btnTimeStringWithoutLeadingZero";
            this.btnTimeStringWithoutLeadingZero.Size = new System.Drawing.Size(336, 23);
            this.btnTimeStringWithoutLeadingZero.TabIndex = 15;
            this.btnTimeStringWithoutLeadingZero.Text = "TimeStringWithoutLeadingZero";
            this.btnTimeStringWithoutLeadingZero.UseVisualStyleBackColor = false;
            this.btnTimeStringWithoutLeadingZero.Click += new System.EventHandler(this.btnTimeStringWithoutLeadingZero_Click);
            // 
            // btnTimeString
            // 
            this.btnTimeString.BackColor = System.Drawing.Color.Azure;
            this.btnTimeString.Location = new System.Drawing.Point(12, 264);
            this.btnTimeString.Name = "btnTimeString";
            this.btnTimeString.Size = new System.Drawing.Size(336, 23);
            this.btnTimeString.TabIndex = 16;
            this.btnTimeString.Text = "TimeString";
            this.btnTimeString.UseVisualStyleBackColor = false;
            this.btnTimeString.Click += new System.EventHandler(this.btnTimeString_Click);
            // 
            // btnDateTimeStringWithoutLeadingZero
            // 
            this.btnDateTimeStringWithoutLeadingZero.BackColor = System.Drawing.Color.Linen;
            this.btnDateTimeStringWithoutLeadingZero.Location = new System.Drawing.Point(13, 177);
            this.btnDateTimeStringWithoutLeadingZero.Name = "btnDateTimeStringWithoutLeadingZero";
            this.btnDateTimeStringWithoutLeadingZero.Size = new System.Drawing.Size(336, 23);
            this.btnDateTimeStringWithoutLeadingZero.TabIndex = 17;
            this.btnDateTimeStringWithoutLeadingZero.Text = "DateTimeStringWithoutLeadingZero";
            this.btnDateTimeStringWithoutLeadingZero.UseVisualStyleBackColor = false;
            this.btnDateTimeStringWithoutLeadingZero.Click += new System.EventHandler(this.btnDateTimeStringWithoutLeadingZero_Click);
            // 
            // btnDateStringWithoutLeadingZero
            // 
            this.btnDateStringWithoutLeadingZero.BackColor = System.Drawing.Color.Honeydew;
            this.btnDateStringWithoutLeadingZero.Location = new System.Drawing.Point(12, 235);
            this.btnDateStringWithoutLeadingZero.Name = "btnDateStringWithoutLeadingZero";
            this.btnDateStringWithoutLeadingZero.Size = new System.Drawing.Size(336, 23);
            this.btnDateStringWithoutLeadingZero.TabIndex = 18;
            this.btnDateStringWithoutLeadingZero.Text = "DateStringWithoutLeadingZero";
            this.btnDateStringWithoutLeadingZero.UseVisualStyleBackColor = false;
            this.btnDateStringWithoutLeadingZero.Click += new System.EventHandler(this.btnDateStringWithoutLeadingZero_Click);
            // 
            // btnDateTimeString
            // 
            this.btnDateTimeString.BackColor = System.Drawing.Color.Linen;
            this.btnDateTimeString.Location = new System.Drawing.Point(14, 148);
            this.btnDateTimeString.Name = "btnDateTimeString";
            this.btnDateTimeString.Size = new System.Drawing.Size(336, 23);
            this.btnDateTimeString.TabIndex = 19;
            this.btnDateTimeString.Text = "DateTimeString";
            this.btnDateTimeString.UseVisualStyleBackColor = false;
            this.btnDateTimeString.Click += new System.EventHandler(this.btnDateTimeString_Click);
            // 
            // btnDateString
            // 
            this.btnDateString.BackColor = System.Drawing.Color.Honeydew;
            this.btnDateString.Location = new System.Drawing.Point(13, 206);
            this.btnDateString.Name = "btnDateString";
            this.btnDateString.Size = new System.Drawing.Size(336, 23);
            this.btnDateString.TabIndex = 20;
            this.btnDateString.Text = "DateString";
            this.btnDateString.UseVisualStyleBackColor = false;
            this.btnDateString.Click += new System.EventHandler(this.btnDateString_Click);
            // 
            // gbStaticMembers
            // 
            this.gbStaticMembers.Controls.Add(this.btnToday);
            this.gbStaticMembers.Controls.Add(this.btnNow);
            this.gbStaticMembers.Location = new System.Drawing.Point(19, 4);
            this.gbStaticMembers.Name = "gbStaticMembers";
            this.gbStaticMembers.Size = new System.Drawing.Size(365, 100);
            this.gbStaticMembers.TabIndex = 21;
            this.gbStaticMembers.TabStop = false;
            this.gbStaticMembers.Text = "Static Members";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 473);
            this.Controls.Add(this.gbStaticMembers);
            this.Controls.Add(this.gbConstructors);
            this.Name = "Form1";
            this.Text = "ShamsiDateTimeTester";
            this.gbConstructors.ResumeLayout(false);
            this.gbConstructors.PerformLayout();
            this.gbStaticMembers.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnNow;
        private TextBox txtInputGregorian;
        private Button btnDateTimeNow;
        private Button btnToday;
        private RadioButton rbGregorian;
        private RadioButton rbShamsi;
        private RadioButton rbParts;
        private TextBox txtInputShamsi;
        private TextBox txtYear;
        private TextBox txtMonth;
        private TextBox txtDay;
        private TextBox txtHour;
        private TextBox txtMinute;
        private TextBox txtSecond;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private GroupBox gbConstructors;
        private Button btnTimeStringWithoutLeadingZero;
        private Button btnTimeString;
        private Button btnDateTimeStringWithoutLeadingZero;
        private Button btnDateStringWithoutLeadingZero;
        private Button btnDateTimeString;
        private Button btnDateString;
        private GroupBox gbStaticMembers;
    }
}
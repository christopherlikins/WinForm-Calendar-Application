
namespace clikinsCalendar
{
    partial class ModifyAppointment
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
            this.label3 = new System.Windows.Forms.Label();
            this.CustomerSelectComboBox = new System.Windows.Forms.ComboBox();
            this.CurrentUserIdTextArea = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AppointmentTypeComboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Button_SaveAppointment = new System.Windows.Forms.Button();
            this.Button_CancelToAppointmentList = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.AppointmentEndDatePicker = new System.Windows.Forms.DateTimePicker();
            this.AppointmentStartDatePicker = new System.Windows.Forms.DateTimePicker();
            this.AppointmentStartTimePicker = new System.Windows.Forms.DateTimePicker();
            this.AppointmentEndTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.CurrentAppointmentStartTimeLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.CurrentAppointmentEndTimeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Select a Customer";
            // 
            // CustomerSelectComboBox
            // 
            this.CustomerSelectComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CustomerSelectComboBox.FormattingEnabled = true;
            this.CustomerSelectComboBox.Location = new System.Drawing.Point(26, 77);
            this.CustomerSelectComboBox.Name = "CustomerSelectComboBox";
            this.CustomerSelectComboBox.Size = new System.Drawing.Size(197, 21);
            this.CustomerSelectComboBox.TabIndex = 12;
            // 
            // CurrentUserIdTextArea
            // 
            this.CurrentUserIdTextArea.AutoSize = true;
            this.CurrentUserIdTextArea.Location = new System.Drawing.Point(100, 24);
            this.CurrentUserIdTextArea.Name = "CurrentUserIdTextArea";
            this.CurrentUserIdTextArea.Size = new System.Drawing.Size(33, 13);
            this.CurrentUserIdTextArea.TabIndex = 11;
            this.CurrentUserIdTextArea.Text = "blank";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Your User ID:";
            // 
            // AppointmentTypeComboBox
            // 
            this.AppointmentTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AppointmentTypeComboBox.FormattingEnabled = true;
            this.AppointmentTypeComboBox.Location = new System.Drawing.Point(26, 141);
            this.AppointmentTypeComboBox.Name = "AppointmentTypeComboBox";
            this.AppointmentTypeComboBox.Size = new System.Drawing.Size(197, 21);
            this.AppointmentTypeComboBox.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Select Appointment Type";
            // 
            // Button_SaveAppointment
            // 
            this.Button_SaveAppointment.Location = new System.Drawing.Point(144, 502);
            this.Button_SaveAppointment.Name = "Button_SaveAppointment";
            this.Button_SaveAppointment.Size = new System.Drawing.Size(79, 34);
            this.Button_SaveAppointment.TabIndex = 19;
            this.Button_SaveAppointment.Text = "Save";
            this.Button_SaveAppointment.UseVisualStyleBackColor = true;
            this.Button_SaveAppointment.Click += new System.EventHandler(this.Button_SaveAppointment_Click_1);
            // 
            // Button_CancelToAppointmentList
            // 
            this.Button_CancelToAppointmentList.Location = new System.Drawing.Point(29, 513);
            this.Button_CancelToAppointmentList.Name = "Button_CancelToAppointmentList";
            this.Button_CancelToAppointmentList.Size = new System.Drawing.Size(75, 23);
            this.Button_CancelToAppointmentList.TabIndex = 18;
            this.Button_CancelToAppointmentList.Text = "Cancel";
            this.Button_CancelToAppointmentList.UseVisualStyleBackColor = true;
            this.Button_CancelToAppointmentList.Click += new System.EventHandler(this.Button_CancelToAppointmentList_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 408);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Time/Date - Appointment End";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 318);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Time/Date - Appointment Start";
            // 
            // AppointmentEndDatePicker
            // 
            this.AppointmentEndDatePicker.Location = new System.Drawing.Point(26, 457);
            this.AppointmentEndDatePicker.Name = "AppointmentEndDatePicker";
            this.AppointmentEndDatePicker.Size = new System.Drawing.Size(200, 20);
            this.AppointmentEndDatePicker.TabIndex = 15;
            // 
            // AppointmentStartDatePicker
            // 
            this.AppointmentStartDatePicker.Location = new System.Drawing.Point(26, 368);
            this.AppointmentStartDatePicker.Name = "AppointmentStartDatePicker";
            this.AppointmentStartDatePicker.Size = new System.Drawing.Size(200, 20);
            this.AppointmentStartDatePicker.TabIndex = 14;
            // 
            // AppointmentStartTimePicker
            // 
            this.AppointmentStartTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.AppointmentStartTimePicker.Location = new System.Drawing.Point(26, 342);
            this.AppointmentStartTimePicker.Name = "AppointmentStartTimePicker";
            this.AppointmentStartTimePicker.Size = new System.Drawing.Size(200, 20);
            this.AppointmentStartTimePicker.TabIndex = 22;
            // 
            // AppointmentEndTimePicker
            // 
            this.AppointmentEndTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.AppointmentEndTimePicker.Location = new System.Drawing.Point(26, 430);
            this.AppointmentEndTimePicker.Name = "AppointmentEndTimePicker";
            this.AppointmentEndTimePicker.Size = new System.Drawing.Size(200, 20);
            this.AppointmentEndTimePicker.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(54, 288);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "New Appointment Time";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(54, 179);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(153, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "Current Appointment Time";
            // 
            // CurrentAppointmentStartTimeLabel
            // 
            this.CurrentAppointmentStartTimeLabel.AutoSize = true;
            this.CurrentAppointmentStartTimeLabel.Location = new System.Drawing.Point(73, 211);
            this.CurrentAppointmentStartTimeLabel.Name = "CurrentAppointmentStartTimeLabel";
            this.CurrentAppointmentStartTimeLabel.Size = new System.Drawing.Size(27, 13);
            this.CurrentAppointmentStartTimeLabel.TabIndex = 26;
            this.CurrentAppointmentStartTimeLabel.Text = "start";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(34, 211);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 13);
            this.label8.TabIndex = 27;
            this.label8.Text = "From:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(37, 243);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(23, 13);
            this.label9.TabIndex = 28;
            this.label9.Text = "To:";
            // 
            // CurrentAppointmentEndTimeLabel
            // 
            this.CurrentAppointmentEndTimeLabel.AutoSize = true;
            this.CurrentAppointmentEndTimeLabel.Location = new System.Drawing.Point(73, 243);
            this.CurrentAppointmentEndTimeLabel.Name = "CurrentAppointmentEndTimeLabel";
            this.CurrentAppointmentEndTimeLabel.Size = new System.Drawing.Size(25, 13);
            this.CurrentAppointmentEndTimeLabel.TabIndex = 29;
            this.CurrentAppointmentEndTimeLabel.Text = "end";
            // 
            // ModifyAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 590);
            this.Controls.Add(this.CurrentAppointmentEndTimeLabel);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.CurrentAppointmentStartTimeLabel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AppointmentEndTimePicker);
            this.Controls.Add(this.AppointmentStartTimePicker);
            this.Controls.Add(this.AppointmentTypeComboBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Button_SaveAppointment);
            this.Controls.Add(this.Button_CancelToAppointmentList);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.AppointmentEndDatePicker);
            this.Controls.Add(this.AppointmentStartDatePicker);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CustomerSelectComboBox);
            this.Controls.Add(this.CurrentUserIdTextArea);
            this.Controls.Add(this.label1);
            this.Name = "ModifyAppointment";
            this.Text = "ModifyAppointment";
            this.Load += new System.EventHandler(this.ModifyAppointment_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CustomerSelectComboBox;
        private System.Windows.Forms.Label CurrentUserIdTextArea;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox AppointmentTypeComboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Button_SaveAppointment;
        private System.Windows.Forms.Button Button_CancelToAppointmentList;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker AppointmentEndDatePicker;
        private System.Windows.Forms.DateTimePicker AppointmentStartDatePicker;
        private System.Windows.Forms.DateTimePicker AppointmentStartTimePicker;
        private System.Windows.Forms.DateTimePicker AppointmentEndTimePicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label CurrentAppointmentStartTimeLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label CurrentAppointmentEndTimeLabel;
    }
}
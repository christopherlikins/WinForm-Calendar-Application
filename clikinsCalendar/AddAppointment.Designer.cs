
namespace clikinsCalendar
{
    partial class AddAppointment
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
            this.label1 = new System.Windows.Forms.Label();
            this.CurrentUserIdTextArea = new System.Windows.Forms.Label();
            this.CustomerSelectComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Button_CancelToAppointmentList = new System.Windows.Forms.Button();
            this.Button_SaveAppointment = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.AppointmentTypeComboBox = new System.Windows.Forms.ComboBox();
            this.AppointmentEndTimePicker = new System.Windows.Forms.DateTimePicker();
            this.AppointmentStartTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.AppointmentEndDatePicker = new System.Windows.Forms.DateTimePicker();
            this.AppointmentStartDatePicker = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Your User ID:";
            // 
            // CurrentUserIdTextArea
            // 
            this.CurrentUserIdTextArea.AutoSize = true;
            this.CurrentUserIdTextArea.Location = new System.Drawing.Point(100, 24);
            this.CurrentUserIdTextArea.Name = "CurrentUserIdTextArea";
            this.CurrentUserIdTextArea.Size = new System.Drawing.Size(33, 13);
            this.CurrentUserIdTextArea.TabIndex = 1;
            this.CurrentUserIdTextArea.Text = "blank";
            // 
            // CustomerSelectComboBox
            // 
            this.CustomerSelectComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CustomerSelectComboBox.FormattingEnabled = true;
            this.CustomerSelectComboBox.Location = new System.Drawing.Point(26, 77);
            this.CustomerSelectComboBox.Name = "CustomerSelectComboBox";
            this.CustomerSelectComboBox.Size = new System.Drawing.Size(197, 21);
            this.CustomerSelectComboBox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Select a Customer";
            // 
            // Button_CancelToAppointmentList
            // 
            this.Button_CancelToAppointmentList.Location = new System.Drawing.Point(29, 394);
            this.Button_CancelToAppointmentList.Name = "Button_CancelToAppointmentList";
            this.Button_CancelToAppointmentList.Size = new System.Drawing.Size(75, 23);
            this.Button_CancelToAppointmentList.TabIndex = 8;
            this.Button_CancelToAppointmentList.Text = "Cancel";
            this.Button_CancelToAppointmentList.UseVisualStyleBackColor = true;
            this.Button_CancelToAppointmentList.Click += new System.EventHandler(this.Button_CancelToAppointmentList_Click);
            // 
            // Button_SaveAppointment
            // 
            this.Button_SaveAppointment.Location = new System.Drawing.Point(144, 383);
            this.Button_SaveAppointment.Name = "Button_SaveAppointment";
            this.Button_SaveAppointment.Size = new System.Drawing.Size(79, 34);
            this.Button_SaveAppointment.TabIndex = 9;
            this.Button_SaveAppointment.Text = "Save";
            this.Button_SaveAppointment.UseVisualStyleBackColor = true;
            this.Button_SaveAppointment.Click += new System.EventHandler(this.Button_SaveAppointment_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Select Appointment Type";
            // 
            // AppointmentTypeComboBox
            // 
            this.AppointmentTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AppointmentTypeComboBox.FormattingEnabled = true;
            this.AppointmentTypeComboBox.Location = new System.Drawing.Point(26, 141);
            this.AppointmentTypeComboBox.Name = "AppointmentTypeComboBox";
            this.AppointmentTypeComboBox.Size = new System.Drawing.Size(197, 21);
            this.AppointmentTypeComboBox.TabIndex = 11;
            // 
            // AppointmentEndTimePicker
            // 
            this.AppointmentEndTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.AppointmentEndTimePicker.Location = new System.Drawing.Point(26, 305);
            this.AppointmentEndTimePicker.Name = "AppointmentEndTimePicker";
            this.AppointmentEndTimePicker.Size = new System.Drawing.Size(200, 20);
            this.AppointmentEndTimePicker.TabIndex = 29;
            // 
            // AppointmentStartTimePicker
            // 
            this.AppointmentStartTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.AppointmentStartTimePicker.Location = new System.Drawing.Point(26, 217);
            this.AppointmentStartTimePicker.Name = "AppointmentStartTimePicker";
            this.AppointmentStartTimePicker.Size = new System.Drawing.Size(200, 20);
            this.AppointmentStartTimePicker.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 283);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "Time/Date - Appointment End";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Time/Date - Appointment Start";
            // 
            // AppointmentEndDatePicker
            // 
            this.AppointmentEndDatePicker.Location = new System.Drawing.Point(26, 332);
            this.AppointmentEndDatePicker.Name = "AppointmentEndDatePicker";
            this.AppointmentEndDatePicker.Size = new System.Drawing.Size(200, 20);
            this.AppointmentEndDatePicker.TabIndex = 25;
            // 
            // AppointmentStartDatePicker
            // 
            this.AppointmentStartDatePicker.Location = new System.Drawing.Point(26, 243);
            this.AppointmentStartDatePicker.Name = "AppointmentStartDatePicker";
            this.AppointmentStartDatePicker.Size = new System.Drawing.Size(200, 20);
            this.AppointmentStartDatePicker.TabIndex = 24;
            // 
            // AddAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 446);
            this.Controls.Add(this.AppointmentEndTimePicker);
            this.Controls.Add(this.AppointmentStartTimePicker);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.AppointmentEndDatePicker);
            this.Controls.Add(this.AppointmentStartDatePicker);
            this.Controls.Add(this.AppointmentTypeComboBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Button_SaveAppointment);
            this.Controls.Add(this.Button_CancelToAppointmentList);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CustomerSelectComboBox);
            this.Controls.Add(this.CurrentUserIdTextArea);
            this.Controls.Add(this.label1);
            this.Name = "AddAppointment";
            this.Text = "AddAppointment";
            this.Load += new System.EventHandler(this.AddAppointment_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label CurrentUserIdTextArea;
        private System.Windows.Forms.ComboBox CustomerSelectComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Button_CancelToAppointmentList;
        private System.Windows.Forms.Button Button_SaveAppointment;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox AppointmentTypeComboBox;
        private System.Windows.Forms.DateTimePicker AppointmentEndTimePicker;
        private System.Windows.Forms.DateTimePicker AppointmentStartTimePicker;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker AppointmentEndDatePicker;
        private System.Windows.Forms.DateTimePicker AppointmentStartDatePicker;
    }
}
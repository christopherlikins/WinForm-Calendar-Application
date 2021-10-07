
namespace clikinsCalendar
{
    partial class AppointmentList
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
            this.Button_ReturnToLoggedInScreen = new System.Windows.Forms.Button();
            this.Button_ModifySelectedAppointment = new System.Windows.Forms.Button();
            this.Button_ToAddAppointmentScreen = new System.Windows.Forms.Button();
            this.Button_DeleteSelectedAppointment = new System.Windows.Forms.Button();
            this.SearchAppointmentTextBox = new System.Windows.Forms.TextBox();
            this.AppointmentDataGridView = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.MonthlyReportButton = new System.Windows.Forms.Button();
            this.CustomerAppointmentListComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.NumberOfAppointmentsButton = new System.Windows.Forms.Button();
            this.CalendarByWeekMonthAllComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.AppointmentDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Appointments:";
            // 
            // Button_ReturnToLoggedInScreen
            // 
            this.Button_ReturnToLoggedInScreen.Location = new System.Drawing.Point(306, 244);
            this.Button_ReturnToLoggedInScreen.Name = "Button_ReturnToLoggedInScreen";
            this.Button_ReturnToLoggedInScreen.Size = new System.Drawing.Size(179, 53);
            this.Button_ReturnToLoggedInScreen.TabIndex = 14;
            this.Button_ReturnToLoggedInScreen.Text = "Back to Main";
            this.Button_ReturnToLoggedInScreen.UseVisualStyleBackColor = true;
            this.Button_ReturnToLoggedInScreen.Click += new System.EventHandler(this.Button_ReturnToLoggedInScreen_Click);
            // 
            // Button_ModifySelectedAppointment
            // 
            this.Button_ModifySelectedAppointment.Location = new System.Drawing.Point(575, 108);
            this.Button_ModifySelectedAppointment.Name = "Button_ModifySelectedAppointment";
            this.Button_ModifySelectedAppointment.Size = new System.Drawing.Size(75, 23);
            this.Button_ModifySelectedAppointment.TabIndex = 13;
            this.Button_ModifySelectedAppointment.Text = "Modify";
            this.Button_ModifySelectedAppointment.UseVisualStyleBackColor = true;
            this.Button_ModifySelectedAppointment.Click += new System.EventHandler(this.Button_ModifySelectedAppointment_Click);
            // 
            // Button_ToAddAppointmentScreen
            // 
            this.Button_ToAddAppointmentScreen.Location = new System.Drawing.Point(575, 79);
            this.Button_ToAddAppointmentScreen.Name = "Button_ToAddAppointmentScreen";
            this.Button_ToAddAppointmentScreen.Size = new System.Drawing.Size(75, 23);
            this.Button_ToAddAppointmentScreen.TabIndex = 12;
            this.Button_ToAddAppointmentScreen.Text = "Add";
            this.Button_ToAddAppointmentScreen.UseVisualStyleBackColor = true;
            this.Button_ToAddAppointmentScreen.Click += new System.EventHandler(this.Button_ToAddAppointmentScreen_Click);
            // 
            // Button_DeleteSelectedAppointment
            // 
            this.Button_DeleteSelectedAppointment.Location = new System.Drawing.Point(575, 137);
            this.Button_DeleteSelectedAppointment.Name = "Button_DeleteSelectedAppointment";
            this.Button_DeleteSelectedAppointment.Size = new System.Drawing.Size(75, 23);
            this.Button_DeleteSelectedAppointment.TabIndex = 11;
            this.Button_DeleteSelectedAppointment.Text = "Delete";
            this.Button_DeleteSelectedAppointment.UseVisualStyleBackColor = true;
            this.Button_DeleteSelectedAppointment.Click += new System.EventHandler(this.Button_DeleteSelectedAppointment_Click);
            // 
            // SearchAppointmentTextBox
            // 
            this.SearchAppointmentTextBox.Location = new System.Drawing.Point(110, 18);
            this.SearchAppointmentTextBox.Name = "SearchAppointmentTextBox";
            this.SearchAppointmentTextBox.Size = new System.Drawing.Size(190, 20);
            this.SearchAppointmentTextBox.TabIndex = 9;
            this.SearchAppointmentTextBox.TextChanged += new System.EventHandler(this.SearchAppointmentTextBox_TextChanged);
            // 
            // AppointmentDataGridView
            // 
            this.AppointmentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AppointmentDataGridView.Location = new System.Drawing.Point(27, 79);
            this.AppointmentDataGridView.Name = "AppointmentDataGridView";
            this.AppointmentDataGridView.Size = new System.Drawing.Size(542, 150);
            this.AppointmentDataGridView.TabIndex = 8;
            this.AppointmentDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AppointmentDataGridView_CellClick);
            this.AppointmentDataGridView.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.AppointmentDataGridView_ColumnHeaderMouseClick);
            this.AppointmentDataGridView.ColumnHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.AppointmentDataGridView_ColumnHeaderMouseDoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Search";
            // 
            // MonthlyReportButton
            // 
            this.MonthlyReportButton.Location = new System.Drawing.Point(30, 258);
            this.MonthlyReportButton.Name = "MonthlyReportButton";
            this.MonthlyReportButton.Size = new System.Drawing.Size(132, 23);
            this.MonthlyReportButton.TabIndex = 17;
            this.MonthlyReportButton.Text = "Monthly Report";
            this.MonthlyReportButton.UseVisualStyleBackColor = true;
            this.MonthlyReportButton.Click += new System.EventHandler(this.MonthlyReportButton_Click);
            // 
            // CustomerAppointmentListComboBox
            // 
            this.CustomerAppointmentListComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CustomerAppointmentListComboBox.FormattingEnabled = true;
            this.CustomerAppointmentListComboBox.Location = new System.Drawing.Point(458, 17);
            this.CustomerAppointmentListComboBox.Name = "CustomerAppointmentListComboBox";
            this.CustomerAppointmentListComboBox.Size = new System.Drawing.Size(192, 21);
            this.CustomerAppointmentListComboBox.TabIndex = 18;
            this.CustomerAppointmentListComboBox.SelectedIndexChanged += new System.EventHandler(this.CustomerAppointmentListComboBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(341, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "View appointments for";
            // 
            // NumberOfAppointmentsButton
            // 
            this.NumberOfAppointmentsButton.Location = new System.Drawing.Point(168, 258);
            this.NumberOfAppointmentsButton.Name = "NumberOfAppointmentsButton";
            this.NumberOfAppointmentsButton.Size = new System.Drawing.Size(132, 23);
            this.NumberOfAppointmentsButton.TabIndex = 20;
            this.NumberOfAppointmentsButton.Text = "Appointments Report";
            this.NumberOfAppointmentsButton.UseVisualStyleBackColor = true;
            this.NumberOfAppointmentsButton.Click += new System.EventHandler(this.NumberOfAppointmentsButton_Click);
            // 
            // CalendarByWeekMonthAllComboBox
            // 
            this.CalendarByWeekMonthAllComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CalendarByWeekMonthAllComboBox.FormattingEnabled = true;
            this.CalendarByWeekMonthAllComboBox.Location = new System.Drawing.Point(514, 260);
            this.CalendarByWeekMonthAllComboBox.Name = "CalendarByWeekMonthAllComboBox";
            this.CalendarByWeekMonthAllComboBox.Size = new System.Drawing.Size(136, 21);
            this.CalendarByWeekMonthAllComboBox.TabIndex = 21;
            this.CalendarByWeekMonthAllComboBox.SelectedIndexChanged += new System.EventHandler(this.CalendarByWeekMonthAllComboBox_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(553, 244);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Appointments View";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(572, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Use the dropdown";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(572, 185);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "below to view";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(572, 200);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "appointments by";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(572, 215);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 13);
            this.label8.TabIndex = 26;
            this.label8.Text = "Week or Month";
            // 
            // AppointmentList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 309);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CalendarByWeekMonthAllComboBox);
            this.Controls.Add(this.NumberOfAppointmentsButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CustomerAppointmentListComboBox);
            this.Controls.Add(this.MonthlyReportButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Button_ReturnToLoggedInScreen);
            this.Controls.Add(this.Button_ModifySelectedAppointment);
            this.Controls.Add(this.Button_ToAddAppointmentScreen);
            this.Controls.Add(this.Button_DeleteSelectedAppointment);
            this.Controls.Add(this.SearchAppointmentTextBox);
            this.Controls.Add(this.AppointmentDataGridView);
            this.Name = "AppointmentList";
            this.Text = "AppointmentList";
            this.Load += new System.EventHandler(this.AppointmentList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AppointmentDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Button_ReturnToLoggedInScreen;
        private System.Windows.Forms.Button Button_ModifySelectedAppointment;
        private System.Windows.Forms.Button Button_ToAddAppointmentScreen;
        private System.Windows.Forms.Button Button_DeleteSelectedAppointment;
        private System.Windows.Forms.TextBox SearchAppointmentTextBox;
        private System.Windows.Forms.DataGridView AppointmentDataGridView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button MonthlyReportButton;
        private System.Windows.Forms.ComboBox CustomerAppointmentListComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button NumberOfAppointmentsButton;
        private System.Windows.Forms.ComboBox CalendarByWeekMonthAllComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}
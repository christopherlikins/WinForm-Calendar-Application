
namespace clikinsCalendar
{
    partial class LoggedIn
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
            this.Button_ExitProgram = new System.Windows.Forms.Button();
            this.Button_ToCustomerListScreen = new System.Windows.Forms.Button();
            this.Button_ToAppointmentListScreen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Button_ExitProgram
            // 
            this.Button_ExitProgram.Location = new System.Drawing.Point(142, 207);
            this.Button_ExitProgram.Name = "Button_ExitProgram";
            this.Button_ExitProgram.Size = new System.Drawing.Size(179, 23);
            this.Button_ExitProgram.TabIndex = 14;
            this.Button_ExitProgram.Text = "Exit Program";
            this.Button_ExitProgram.UseVisualStyleBackColor = true;
            this.Button_ExitProgram.Click += new System.EventHandler(this.Button_ExitProgram_Click);
            // 
            // Button_ToCustomerListScreen
            // 
            this.Button_ToCustomerListScreen.Location = new System.Drawing.Point(257, 59);
            this.Button_ToCustomerListScreen.Name = "Button_ToCustomerListScreen";
            this.Button_ToCustomerListScreen.Size = new System.Drawing.Size(179, 60);
            this.Button_ToCustomerListScreen.TabIndex = 9;
            this.Button_ToCustomerListScreen.Text = "Customers";
            this.Button_ToCustomerListScreen.UseVisualStyleBackColor = true;
            this.Button_ToCustomerListScreen.Click += new System.EventHandler(this.Button_ToCustomerListScreen_Click);
            // 
            // Button_ToAppointmentListScreen
            // 
            this.Button_ToAppointmentListScreen.Location = new System.Drawing.Point(27, 59);
            this.Button_ToAppointmentListScreen.Name = "Button_ToAppointmentListScreen";
            this.Button_ToAppointmentListScreen.Size = new System.Drawing.Size(179, 60);
            this.Button_ToAppointmentListScreen.TabIndex = 8;
            this.Button_ToAppointmentListScreen.Text = "Appointments";
            this.Button_ToAppointmentListScreen.UseVisualStyleBackColor = true;
            this.Button_ToAppointmentListScreen.Click += new System.EventHandler(this.Button_ToAppointmentListScreen_Click);
            // 
            // LoggedIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 261);
            this.Controls.Add(this.Button_ExitProgram);
            this.Controls.Add(this.Button_ToCustomerListScreen);
            this.Controls.Add(this.Button_ToAppointmentListScreen);
            this.Name = "LoggedIn";
            this.Text = "LoggedIn";
            this.Load += new System.EventHandler(this.LoggedIn_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Button_ExitProgram;
        private System.Windows.Forms.Button Button_ToCustomerListScreen;
        private System.Windows.Forms.Button Button_ToAppointmentListScreen;
    }
}
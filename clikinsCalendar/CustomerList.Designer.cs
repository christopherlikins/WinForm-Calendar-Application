
namespace clikinsCalendar
{
    partial class CustomerList
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
            this.Button_ModifySelectedCustomer = new System.Windows.Forms.Button();
            this.Button_ToAddCustomerScreen = new System.Windows.Forms.Button();
            this.Button_DeleteSelectedCustomer = new System.Windows.Forms.Button();
            this.SearchCustomerTextBox = new System.Windows.Forms.TextBox();
            this.CustomerDataGridView = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Customers:";
            // 
            // Button_ReturnToLoggedInScreen
            // 
            this.Button_ReturnToLoggedInScreen.Location = new System.Drawing.Point(306, 246);
            this.Button_ReturnToLoggedInScreen.Name = "Button_ReturnToLoggedInScreen";
            this.Button_ReturnToLoggedInScreen.Size = new System.Drawing.Size(179, 49);
            this.Button_ReturnToLoggedInScreen.TabIndex = 24;
            this.Button_ReturnToLoggedInScreen.Text = "Back to Main";
            this.Button_ReturnToLoggedInScreen.UseVisualStyleBackColor = true;
            this.Button_ReturnToLoggedInScreen.Click += new System.EventHandler(this.Button_ReturnToLoggedInScreen_Click);
            // 
            // Button_ModifySelectedCustomer
            // 
            this.Button_ModifySelectedCustomer.Location = new System.Drawing.Point(575, 108);
            this.Button_ModifySelectedCustomer.Name = "Button_ModifySelectedCustomer";
            this.Button_ModifySelectedCustomer.Size = new System.Drawing.Size(75, 23);
            this.Button_ModifySelectedCustomer.TabIndex = 23;
            this.Button_ModifySelectedCustomer.Text = "Modify";
            this.Button_ModifySelectedCustomer.UseVisualStyleBackColor = true;
            this.Button_ModifySelectedCustomer.Click += new System.EventHandler(this.Button_ModifySelectedCustomer_Click);
            // 
            // Button_ToAddCustomerScreen
            // 
            this.Button_ToAddCustomerScreen.Location = new System.Drawing.Point(575, 79);
            this.Button_ToAddCustomerScreen.Name = "Button_ToAddCustomerScreen";
            this.Button_ToAddCustomerScreen.Size = new System.Drawing.Size(75, 23);
            this.Button_ToAddCustomerScreen.TabIndex = 22;
            this.Button_ToAddCustomerScreen.Text = "Add";
            this.Button_ToAddCustomerScreen.UseVisualStyleBackColor = true;
            this.Button_ToAddCustomerScreen.Click += new System.EventHandler(this.Button_ToAddCustomerScreen_Click);
            // 
            // Button_DeleteSelectedCustomer
            // 
            this.Button_DeleteSelectedCustomer.Location = new System.Drawing.Point(575, 137);
            this.Button_DeleteSelectedCustomer.Name = "Button_DeleteSelectedCustomer";
            this.Button_DeleteSelectedCustomer.Size = new System.Drawing.Size(75, 23);
            this.Button_DeleteSelectedCustomer.TabIndex = 21;
            this.Button_DeleteSelectedCustomer.Text = "Delete";
            this.Button_DeleteSelectedCustomer.UseVisualStyleBackColor = true;
            this.Button_DeleteSelectedCustomer.Click += new System.EventHandler(this.Button_DeleteSelectedCustomer_Click);
            // 
            // SearchCustomerTextBox
            // 
            this.SearchCustomerTextBox.Location = new System.Drawing.Point(268, 22);
            this.SearchCustomerTextBox.Name = "SearchCustomerTextBox";
            this.SearchCustomerTextBox.Size = new System.Drawing.Size(190, 20);
            this.SearchCustomerTextBox.TabIndex = 19;
            this.SearchCustomerTextBox.TextChanged += new System.EventHandler(this.SearchCustomerTextBox_TextChanged);
            // 
            // CustomerDataGridView
            // 
            this.CustomerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CustomerDataGridView.Location = new System.Drawing.Point(27, 79);
            this.CustomerDataGridView.Name = "CustomerDataGridView";
            this.CustomerDataGridView.Size = new System.Drawing.Size(542, 150);
            this.CustomerDataGridView.TabIndex = 18;
            this.CustomerDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CustomerDataGridView_CellClick);
            this.CustomerDataGridView.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.CustomerDataGridView_ColumnHeaderMouseClick);
            this.CustomerDataGridView.ColumnHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.CustomerDataGridView_ColumnHeaderMouseDoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(221, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Search";
            // 
            // CustomerList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 309);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Button_ReturnToLoggedInScreen);
            this.Controls.Add(this.Button_ModifySelectedCustomer);
            this.Controls.Add(this.Button_ToAddCustomerScreen);
            this.Controls.Add(this.Button_DeleteSelectedCustomer);
            this.Controls.Add(this.SearchCustomerTextBox);
            this.Controls.Add(this.CustomerDataGridView);
            this.Name = "CustomerList";
            this.Text = "CustomerList";
            this.Load += new System.EventHandler(this.CustomerList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CustomerDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Button_ReturnToLoggedInScreen;
        private System.Windows.Forms.Button Button_ModifySelectedCustomer;
        private System.Windows.Forms.Button Button_ToAddCustomerScreen;
        private System.Windows.Forms.Button Button_DeleteSelectedCustomer;
        private System.Windows.Forms.TextBox SearchCustomerTextBox;
        private System.Windows.Forms.DataGridView CustomerDataGridView;
        private System.Windows.Forms.Label label2;
    }
}
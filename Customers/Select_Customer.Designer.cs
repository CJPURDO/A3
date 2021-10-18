
namespace Customers
{
    partial class Select_Customer
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
            this.btn_backmm2 = new System.Windows.Forms.Button();
            this.btn_SearchCustomer2 = new System.Windows.Forms.Button();
            this.searchCustTextBox2 = new System.Windows.Forms.TextBox();
            this.btnManageCustAcc = new System.Windows.Forms.Button();
            this.listCustomers2 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btn_backmm2
            // 
            this.btn_backmm2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_backmm2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_backmm2.Location = new System.Drawing.Point(517, 535);
            this.btn_backmm2.Name = "btn_backmm2";
            this.btn_backmm2.Size = new System.Drawing.Size(208, 62);
            this.btn_backmm2.TabIndex = 11;
            this.btn_backmm2.Text = "<< Return to Main Menu";
            this.btn_backmm2.UseVisualStyleBackColor = false;
            this.btn_backmm2.Click += new System.EventHandler(this.btn_backmm2_Click);
            // 
            // btn_SearchCustomer2
            // 
            this.btn_SearchCustomer2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btn_SearchCustomer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SearchCustomer2.Location = new System.Drawing.Point(348, 135);
            this.btn_SearchCustomer2.Name = "btn_SearchCustomer2";
            this.btn_SearchCustomer2.Size = new System.Drawing.Size(114, 33);
            this.btn_SearchCustomer2.TabIndex = 9;
            this.btn_SearchCustomer2.Text = "Search";
            this.btn_SearchCustomer2.UseVisualStyleBackColor = false;
            // 
            // searchCustTextBox2
            // 
            this.searchCustTextBox2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.searchCustTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchCustTextBox2.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.searchCustTextBox2.Location = new System.Drawing.Point(80, 135);
            this.searchCustTextBox2.Multiline = true;
            this.searchCustTextBox2.Name = "searchCustTextBox2";
            this.searchCustTextBox2.Size = new System.Drawing.Size(236, 33);
            this.searchCustTextBox2.TabIndex = 8;
            this.searchCustTextBox2.Text = "Enter Customer ID...";
            this.searchCustTextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnManageCustAcc
            // 
            this.btnManageCustAcc.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnManageCustAcc.Location = new System.Drawing.Point(517, 193);
            this.btnManageCustAcc.Name = "btnManageCustAcc";
            this.btnManageCustAcc.Size = new System.Drawing.Size(208, 62);
            this.btnManageCustAcc.TabIndex = 10;
            this.btnManageCustAcc.Text = "Manage Customer Accounts";
            this.btnManageCustAcc.UseVisualStyleBackColor = false;
            this.btnManageCustAcc.Click += new System.EventHandler(this.btnManageCustAcc_Click);
            // 
            // listCustomers2
            // 
            this.listCustomers2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listCustomers2.FormattingEnabled = true;
            this.listCustomers2.ItemHeight = 25;
            this.listCustomers2.Location = new System.Drawing.Point(80, 193);
            this.listCustomers2.Name = "listCustomers2";
            this.listCustomers2.Size = new System.Drawing.Size(382, 404);
            this.listCustomers2.TabIndex = 7;
            // 
            // CustomerAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(783, 684);
            this.Controls.Add(this.btn_backmm2);
            this.Controls.Add(this.btn_SearchCustomer2);
            this.Controls.Add(this.searchCustTextBox2);
            this.Controls.Add(this.btnManageCustAcc);
            this.Controls.Add(this.listCustomers2);
            this.Name = "CustomerAccount";
            this.Text = "Customer Accounts";
            this.Controls.SetChildIndex(this.listCustomers2, 0);
            this.Controls.SetChildIndex(this.btnManageCustAcc, 0);
            this.Controls.SetChildIndex(this.searchCustTextBox2, 0);
            this.Controls.SetChildIndex(this.btn_SearchCustomer2, 0);
            this.Controls.SetChildIndex(this.btn_backmm2, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_backmm2;
        private System.Windows.Forms.Button btn_SearchCustomer2;
        private System.Windows.Forms.TextBox searchCustTextBox2;
        private System.Windows.Forms.Button btnManageCustAcc;
        private System.Windows.Forms.ListBox listCustomers2;
    }
}

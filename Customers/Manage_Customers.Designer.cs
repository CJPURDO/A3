
namespace Customers
{
    partial class Manage_Customers
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
            this.listCustomers = new System.Windows.Forms.ListBox();
            this.btnCreateCust = new System.Windows.Forms.Button();
            this.editCustomerBtn = new System.Windows.Forms.Button();
            this.deleteCustomerBtn = new System.Windows.Forms.Button();
            this.searchCustTextBox = new System.Windows.Forms.TextBox();
            this.btn_SearchCustomer = new System.Windows.Forms.Button();
            this.btn_backmm = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listCustomers
            // 
            this.listCustomers.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listCustomers.FormattingEnabled = true;
            this.listCustomers.ItemHeight = 25;
            this.listCustomers.Location = new System.Drawing.Point(80, 199);
            this.listCustomers.Name = "listCustomers";
            this.listCustomers.Size = new System.Drawing.Size(382, 404);
            this.listCustomers.TabIndex = 0;
            // 
            // btnCreateCust
            // 
            this.btnCreateCust.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnCreateCust.Location = new System.Drawing.Point(517, 199);
            this.btnCreateCust.Name = "btnCreateCust";
            this.btnCreateCust.Size = new System.Drawing.Size(208, 62);
            this.btnCreateCust.TabIndex = 2;
            this.btnCreateCust.Text = "Create Customer";
            this.btnCreateCust.UseVisualStyleBackColor = false;
            this.btnCreateCust.Click += new System.EventHandler(this.btnCreateCust_Click);
            // 
            // editCustomerBtn
            // 
            this.editCustomerBtn.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.editCustomerBtn.Location = new System.Drawing.Point(517, 335);
            this.editCustomerBtn.Name = "editCustomerBtn";
            this.editCustomerBtn.Size = new System.Drawing.Size(208, 62);
            this.editCustomerBtn.TabIndex = 3;
            this.editCustomerBtn.Text = "Update Customer";
            this.editCustomerBtn.UseVisualStyleBackColor = false;
            this.editCustomerBtn.Click += new System.EventHandler(this.editCustomerBtn_Click);
            // 
            // deleteCustomerBtn
            // 
            this.deleteCustomerBtn.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.deleteCustomerBtn.Location = new System.Drawing.Point(517, 403);
            this.deleteCustomerBtn.Name = "deleteCustomerBtn";
            this.deleteCustomerBtn.Size = new System.Drawing.Size(208, 62);
            this.deleteCustomerBtn.TabIndex = 4;
            this.deleteCustomerBtn.Text = "Delete Customer";
            this.deleteCustomerBtn.UseVisualStyleBackColor = false;
            this.deleteCustomerBtn.Click += new System.EventHandler(this.deleteCustomerBtn_Click);
            // 
            // searchCustTextBox
            // 
            this.searchCustTextBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.searchCustTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchCustTextBox.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.searchCustTextBox.Location = new System.Drawing.Point(80, 141);
            this.searchCustTextBox.Multiline = true;
            this.searchCustTextBox.Name = "searchCustTextBox";
            this.searchCustTextBox.Size = new System.Drawing.Size(236, 33);
            this.searchCustTextBox.TabIndex = 1;
            this.searchCustTextBox.Text = "Enter Customer ID...";
            this.searchCustTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.searchCustTextBox.Enter += new System.EventHandler(this.searchEnter);
            this.searchCustTextBox.Leave += new System.EventHandler(this.searchLeave);
            // 
            // btn_SearchCustomer
            // 
            this.btn_SearchCustomer.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btn_SearchCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SearchCustomer.Location = new System.Drawing.Point(348, 141);
            this.btn_SearchCustomer.Name = "btn_SearchCustomer";
            this.btn_SearchCustomer.Size = new System.Drawing.Size(114, 33);
            this.btn_SearchCustomer.TabIndex = 2;
            this.btn_SearchCustomer.Text = "Search";
            this.btn_SearchCustomer.UseVisualStyleBackColor = false;
            this.btn_SearchCustomer.Click += new System.EventHandler(this.btn_SearchCustomer_Click);
            // 
            // btn_backmm
            // 
            this.btn_backmm.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_backmm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_backmm.Location = new System.Drawing.Point(517, 541);
            this.btn_backmm.Name = "btn_backmm";
            this.btn_backmm.Size = new System.Drawing.Size(208, 62);
            this.btn_backmm.TabIndex = 6;
            this.btn_backmm.Text = "<< Return to Main Menu";
            this.btn_backmm.UseVisualStyleBackColor = false;
            this.btn_backmm.Click += new System.EventHandler(this.btn_backmm_Click);
            // 
            // btnView
            // 
            this.btnView.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnView.Location = new System.Drawing.Point(517, 267);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(208, 62);
            this.btnView.TabIndex = 7;
            this.btnView.Text = "View Customer";
            this.btnView.UseVisualStyleBackColor = false;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // Manage_Customers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(828, 666);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.btn_backmm);
            this.Controls.Add(this.btn_SearchCustomer);
            this.Controls.Add(this.searchCustTextBox);
            this.Controls.Add(this.deleteCustomerBtn);
            this.Controls.Add(this.editCustomerBtn);
            this.Controls.Add(this.btnCreateCust);
            this.Controls.Add(this.listCustomers);
            this.Name = "Manage_Customers";
            this.Text = "Manage Customers";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ManageCust_FormClosing);
            this.Controls.SetChildIndex(this.listCustomers, 0);
            this.Controls.SetChildIndex(this.btnCreateCust, 0);
            this.Controls.SetChildIndex(this.editCustomerBtn, 0);
            this.Controls.SetChildIndex(this.deleteCustomerBtn, 0);
            this.Controls.SetChildIndex(this.searchCustTextBox, 0);
            this.Controls.SetChildIndex(this.btn_SearchCustomer, 0);
            this.Controls.SetChildIndex(this.btn_backmm, 0);
            this.Controls.SetChildIndex(this.btnView, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listCustomers;
        private System.Windows.Forms.Button btnCreateCust;
        private System.Windows.Forms.Button editCustomerBtn;
        private System.Windows.Forms.Button deleteCustomerBtn;
        private System.Windows.Forms.TextBox searchCustTextBox;
        private System.Windows.Forms.Button btn_SearchCustomer;
        private System.Windows.Forms.Button btn_backmm;
        private System.Windows.Forms.Button btnView;
    }
}

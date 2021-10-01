
namespace Customers
{
    partial class AcManagement
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
            this.btn_backCustAcc = new System.Windows.Forms.Button();
            this.comboAccount = new System.Windows.Forms.ComboBox();
            this.listAccInfo = new System.Windows.Forms.ListBox();
            this.amountLabel = new System.Windows.Forms.Label();
            this.amountInputBox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.clearInfoBtn = new System.Windows.Forms.Button();
            this.addInterestBtn = new System.Windows.Forms.Button();
            this.accountInfoBtn = new System.Windows.Forms.Button();
            this.withdrawBtn = new System.Windows.Forms.Button();
            this.depositBtn = new System.Windows.Forms.Button();
            this.listSelectAcc = new System.Windows.Forms.ListBox();
            this.btnCreateAcc = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_backCustAcc
            // 
            this.btn_backCustAcc.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_backCustAcc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_backCustAcc.Location = new System.Drawing.Point(14, 761);
            this.btn_backCustAcc.Name = "btn_backCustAcc";
            this.btn_backCustAcc.Size = new System.Drawing.Size(358, 41);
            this.btn_backCustAcc.TabIndex = 30;
            this.btn_backCustAcc.Text = "<< Return to Customer Accounts";
            this.btn_backCustAcc.UseVisualStyleBackColor = false;
            this.btn_backCustAcc.Click += new System.EventHandler(this.btn_backCustAcc_Click);
            // 
            // comboAccount
            // 
            this.comboAccount.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.comboAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboAccount.ForeColor = System.Drawing.SystemColors.InfoText;
            this.comboAccount.FormattingEnabled = true;
            this.comboAccount.Items.AddRange(new object[] {
            "Everyday",
            "Investment",
            "Omni"});
            this.comboAccount.Location = new System.Drawing.Point(14, 146);
            this.comboAccount.Name = "comboAccount";
            this.comboAccount.Size = new System.Drawing.Size(240, 32);
            this.comboAccount.TabIndex = 26;
            this.comboAccount.Text = "Select Account";
            // 
            // listAccInfo
            // 
            this.listAccInfo.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listAccInfo.FormattingEnabled = true;
            this.listAccInfo.ItemHeight = 23;
            this.listAccInfo.Location = new System.Drawing.Point(507, 222);
            this.listAccInfo.Name = "listAccInfo";
            this.listAccInfo.ScrollAlwaysVisible = true;
            this.listAccInfo.Size = new System.Drawing.Size(452, 533);
            this.listAccInfo.TabIndex = 23;
            // 
            // amountLabel
            // 
            this.amountLabel.AutoSize = true;
            this.amountLabel.BackColor = System.Drawing.Color.White;
            this.amountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.amountLabel.Location = new System.Drawing.Point(34, 35);
            this.amountLabel.Name = "amountLabel";
            this.amountLabel.Size = new System.Drawing.Size(109, 25);
            this.amountLabel.TabIndex = 11;
            this.amountLabel.Text = "Amount  $";
            // 
            // amountInputBox
            // 
            this.amountInputBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountInputBox.Location = new System.Drawing.Point(145, 35);
            this.amountInputBox.Multiline = true;
            this.amountInputBox.Name = "amountInputBox";
            this.amountInputBox.Size = new System.Drawing.Size(143, 66);
            this.amountInputBox.TabIndex = 10;
            this.amountInputBox.Text = "0.00";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Silver;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(1022, 136);
            this.button2.Name = "button2";
            this.button2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button2.Size = new System.Drawing.Size(188, 85);
            this.button2.TabIndex = 28;
            this.button2.Text = "Check Balance";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Silver;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1022, 459);
            this.button1.Name = "button1";
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button1.Size = new System.Drawing.Size(188, 85);
            this.button1.TabIndex = 27;
            this.button1.Text = "Calculate Interest";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.amountLabel);
            this.groupBox1.Controls.Add(this.amountInputBox);
            this.groupBox1.Location = new System.Drawing.Point(662, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(321, 122);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            // 
            // clearInfoBtn
            // 
            this.clearInfoBtn.BackColor = System.Drawing.Color.Silver;
            this.clearInfoBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearInfoBtn.Location = new System.Drawing.Point(1022, 670);
            this.clearInfoBtn.Name = "clearInfoBtn";
            this.clearInfoBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.clearInfoBtn.Size = new System.Drawing.Size(188, 85);
            this.clearInfoBtn.TabIndex = 24;
            this.clearInfoBtn.Text = "Clear";
            this.clearInfoBtn.UseVisualStyleBackColor = false;
            // 
            // addInterestBtn
            // 
            this.addInterestBtn.BackColor = System.Drawing.Color.Silver;
            this.addInterestBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addInterestBtn.Location = new System.Drawing.Point(1022, 565);
            this.addInterestBtn.Name = "addInterestBtn";
            this.addInterestBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.addInterestBtn.Size = new System.Drawing.Size(188, 85);
            this.addInterestBtn.TabIndex = 22;
            this.addInterestBtn.Text = "Add Interest";
            this.addInterestBtn.UseVisualStyleBackColor = false;
            // 
            // accountInfoBtn
            // 
            this.accountInfoBtn.BackColor = System.Drawing.Color.Silver;
            this.accountInfoBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountInfoBtn.Location = new System.Drawing.Point(1022, 30);
            this.accountInfoBtn.Name = "accountInfoBtn";
            this.accountInfoBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.accountInfoBtn.Size = new System.Drawing.Size(188, 85);
            this.accountInfoBtn.TabIndex = 21;
            this.accountInfoBtn.Text = "Account Information";
            this.accountInfoBtn.UseVisualStyleBackColor = false;
            // 
            // withdrawBtn
            // 
            this.withdrawBtn.BackColor = System.Drawing.Color.Silver;
            this.withdrawBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.withdrawBtn.Location = new System.Drawing.Point(1022, 353);
            this.withdrawBtn.Name = "withdrawBtn";
            this.withdrawBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.withdrawBtn.Size = new System.Drawing.Size(188, 85);
            this.withdrawBtn.TabIndex = 20;
            this.withdrawBtn.Text = "Withdraw";
            this.withdrawBtn.UseVisualStyleBackColor = false;
            // 
            // depositBtn
            // 
            this.depositBtn.BackColor = System.Drawing.Color.Silver;
            this.depositBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depositBtn.Location = new System.Drawing.Point(1022, 245);
            this.depositBtn.Name = "depositBtn";
            this.depositBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.depositBtn.Size = new System.Drawing.Size(188, 85);
            this.depositBtn.TabIndex = 19;
            this.depositBtn.Text = "Deposit";
            this.depositBtn.UseVisualStyleBackColor = false;
            // 
            // listSelectAcc
            // 
            this.listSelectAcc.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listSelectAcc.FormattingEnabled = true;
            this.listSelectAcc.ItemHeight = 23;
            this.listSelectAcc.Location = new System.Drawing.Point(41, 213);
            this.listSelectAcc.Name = "listSelectAcc";
            this.listSelectAcc.ScrollAlwaysVisible = true;
            this.listSelectAcc.Size = new System.Drawing.Size(213, 533);
            this.listSelectAcc.TabIndex = 31;
            // 
            // btnCreateAcc
            // 
            this.btnCreateAcc.BackColor = System.Drawing.Color.Silver;
            this.btnCreateAcc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateAcc.Location = new System.Drawing.Point(468, 131);
            this.btnCreateAcc.Name = "btnCreateAcc";
            this.btnCreateAcc.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnCreateAcc.Size = new System.Drawing.Size(188, 85);
            this.btnCreateAcc.TabIndex = 32;
            this.btnCreateAcc.Text = "Create Account";
            this.btnCreateAcc.UseVisualStyleBackColor = false;
            this.btnCreateAcc.Click += new System.EventHandler(this.btnCreateAcc_Click);
            // 
            // AcManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1264, 836);
            this.Controls.Add(this.btnCreateAcc);
            this.Controls.Add(this.listSelectAcc);
            this.Controls.Add(this.btn_backCustAcc);
            this.Controls.Add(this.comboAccount);
            this.Controls.Add(this.listAccInfo);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.clearInfoBtn);
            this.Controls.Add(this.addInterestBtn);
            this.Controls.Add(this.accountInfoBtn);
            this.Controls.Add(this.withdrawBtn);
            this.Controls.Add(this.depositBtn);
            this.Name = "AcManagement";
            this.Text = "Account Management";
            this.Controls.SetChildIndex(this.depositBtn, 0);
            this.Controls.SetChildIndex(this.withdrawBtn, 0);
            this.Controls.SetChildIndex(this.accountInfoBtn, 0);
            this.Controls.SetChildIndex(this.addInterestBtn, 0);
            this.Controls.SetChildIndex(this.clearInfoBtn, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.button2, 0);
            this.Controls.SetChildIndex(this.listAccInfo, 0);
            this.Controls.SetChildIndex(this.comboAccount, 0);
            this.Controls.SetChildIndex(this.btn_backCustAcc, 0);
            this.Controls.SetChildIndex(this.listSelectAcc, 0);
            this.Controls.SetChildIndex(this.btnCreateAcc, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_backCustAcc;
        private System.Windows.Forms.ComboBox comboAccount;
        private System.Windows.Forms.ListBox listAccInfo;
        private System.Windows.Forms.Label amountLabel;
        private System.Windows.Forms.TextBox amountInputBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button clearInfoBtn;
        private System.Windows.Forms.Button addInterestBtn;
        private System.Windows.Forms.Button accountInfoBtn;
        private System.Windows.Forms.Button withdrawBtn;
        private System.Windows.Forms.Button depositBtn;
        private System.Windows.Forms.ListBox listSelectAcc;
        private System.Windows.Forms.Button btnCreateAcc;
    }
}


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
            this.listAccInfo = new System.Windows.Forms.ListBox();
            this.amountLabel = new System.Windows.Forms.Label();
            this.amountInputBox = new System.Windows.Forms.TextBox();
            this.btnChkBal = new System.Windows.Forms.Button();
            this.btnCalcInt = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.clearInfoBtn = new System.Windows.Forms.Button();
            this.addInterestBtn = new System.Windows.Forms.Button();
            this.accountInfoBtn = new System.Windows.Forms.Button();
            this.withdrawBtn = new System.Windows.Forms.Button();
            this.depositBtn = new System.Windows.Forms.Button();
            this.listSelectAcc = new System.Windows.Forms.ListBox();
            this.btnCreateAcc = new System.Windows.Forms.Button();
            this.btnDelAcc = new System.Windows.Forms.Button();
            this.btn_SearchAccount = new System.Windows.Forms.Button();
            this.searchAccTextBox = new System.Windows.Forms.TextBox();
            this.btnViewAcc = new System.Windows.Forms.Button();
            this.btnUpdateAcc = new System.Windows.Forms.Button();
            this.btnTransfer = new System.Windows.Forms.Button();
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
            // listAccInfo
            // 
            this.listAccInfo.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listAccInfo.FormattingEnabled = true;
            this.listAccInfo.ItemHeight = 23;
            this.listAccInfo.Location = new System.Drawing.Point(354, 222);
            this.listAccInfo.Name = "listAccInfo";
            this.listAccInfo.ScrollAlwaysVisible = true;
            this.listAccInfo.Size = new System.Drawing.Size(921, 533);
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
            // btnChkBal
            // 
            this.btnChkBal.BackColor = System.Drawing.Color.Silver;
            this.btnChkBal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChkBal.Location = new System.Drawing.Point(1292, 136);
            this.btnChkBal.Name = "btnChkBal";
            this.btnChkBal.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnChkBal.Size = new System.Drawing.Size(188, 85);
            this.btnChkBal.TabIndex = 28;
            this.btnChkBal.Text = "Check Balance";
            this.btnChkBal.UseVisualStyleBackColor = false;
            this.btnChkBal.Click += new System.EventHandler(this.btnChkBal_Click);
            // 
            // btnCalcInt
            // 
            this.btnCalcInt.BackColor = System.Drawing.Color.Silver;
            this.btnCalcInt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcInt.Location = new System.Drawing.Point(1292, 459);
            this.btnCalcInt.Name = "btnCalcInt";
            this.btnCalcInt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnCalcInt.Size = new System.Drawing.Size(188, 85);
            this.btnCalcInt.TabIndex = 27;
            this.btnCalcInt.Text = "Calculate Interest";
            this.btnCalcInt.UseVisualStyleBackColor = false;
            this.btnCalcInt.Click += new System.EventHandler(this.btnCalcInt_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.amountLabel);
            this.groupBox1.Controls.Add(this.amountInputBox);
            this.groupBox1.Location = new System.Drawing.Point(917, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(321, 122);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            // 
            // clearInfoBtn
            // 
            this.clearInfoBtn.BackColor = System.Drawing.Color.Silver;
            this.clearInfoBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearInfoBtn.Location = new System.Drawing.Point(1292, 670);
            this.clearInfoBtn.Name = "clearInfoBtn";
            this.clearInfoBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.clearInfoBtn.Size = new System.Drawing.Size(188, 85);
            this.clearInfoBtn.TabIndex = 24;
            this.clearInfoBtn.Text = "Clear";
            this.clearInfoBtn.UseVisualStyleBackColor = false;
            this.clearInfoBtn.Click += new System.EventHandler(this.clearInfoBtn_Click);
            // 
            // addInterestBtn
            // 
            this.addInterestBtn.BackColor = System.Drawing.Color.Silver;
            this.addInterestBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addInterestBtn.Location = new System.Drawing.Point(1292, 565);
            this.addInterestBtn.Name = "addInterestBtn";
            this.addInterestBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.addInterestBtn.Size = new System.Drawing.Size(188, 85);
            this.addInterestBtn.TabIndex = 22;
            this.addInterestBtn.Text = "Add Interest";
            this.addInterestBtn.UseVisualStyleBackColor = false;
            this.addInterestBtn.Click += new System.EventHandler(this.addInterestBtn_Click);
            // 
            // accountInfoBtn
            // 
            this.accountInfoBtn.BackColor = System.Drawing.Color.Silver;
            this.accountInfoBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountInfoBtn.Location = new System.Drawing.Point(1292, 30);
            this.accountInfoBtn.Name = "accountInfoBtn";
            this.accountInfoBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.accountInfoBtn.Size = new System.Drawing.Size(188, 85);
            this.accountInfoBtn.TabIndex = 21;
            this.accountInfoBtn.Text = "Account Information";
            this.accountInfoBtn.UseVisualStyleBackColor = false;
            this.accountInfoBtn.Click += new System.EventHandler(this.accountInfoBtn_Click);
            // 
            // withdrawBtn
            // 
            this.withdrawBtn.BackColor = System.Drawing.Color.Silver;
            this.withdrawBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.withdrawBtn.Location = new System.Drawing.Point(1292, 353);
            this.withdrawBtn.Name = "withdrawBtn";
            this.withdrawBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.withdrawBtn.Size = new System.Drawing.Size(188, 85);
            this.withdrawBtn.TabIndex = 20;
            this.withdrawBtn.Text = "Withdraw";
            this.withdrawBtn.UseVisualStyleBackColor = false;
            this.withdrawBtn.Click += new System.EventHandler(this.withdrawBtn_Click);
            // 
            // depositBtn
            // 
            this.depositBtn.BackColor = System.Drawing.Color.Silver;
            this.depositBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depositBtn.Location = new System.Drawing.Point(1292, 245);
            this.depositBtn.Name = "depositBtn";
            this.depositBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.depositBtn.Size = new System.Drawing.Size(188, 85);
            this.depositBtn.TabIndex = 19;
            this.depositBtn.Text = "Deposit";
            this.depositBtn.UseVisualStyleBackColor = false;
            this.depositBtn.Click += new System.EventHandler(this.depositBtn_Click);
            // 
            // listSelectAcc
            // 
            this.listSelectAcc.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listSelectAcc.FormattingEnabled = true;
            this.listSelectAcc.ItemHeight = 23;
            this.listSelectAcc.Location = new System.Drawing.Point(14, 213);
            this.listSelectAcc.Name = "listSelectAcc";
            this.listSelectAcc.ScrollAlwaysVisible = true;
            this.listSelectAcc.Size = new System.Drawing.Size(232, 533);
            this.listSelectAcc.TabIndex = 31;
            // 
            // btnCreateAcc
            // 
            this.btnCreateAcc.BackColor = System.Drawing.Color.Silver;
            this.btnCreateAcc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateAcc.Location = new System.Drawing.Point(252, 213);
            this.btnCreateAcc.Name = "btnCreateAcc";
            this.btnCreateAcc.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnCreateAcc.Size = new System.Drawing.Size(86, 85);
            this.btnCreateAcc.TabIndex = 32;
            this.btnCreateAcc.Text = "Create Account";
            this.btnCreateAcc.UseVisualStyleBackColor = false;
            this.btnCreateAcc.Click += new System.EventHandler(this.btnCreateAcc_Click);
            // 
            // btnDelAcc
            // 
            this.btnDelAcc.BackColor = System.Drawing.Color.Silver;
            this.btnDelAcc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelAcc.Location = new System.Drawing.Point(252, 304);
            this.btnDelAcc.Name = "btnDelAcc";
            this.btnDelAcc.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnDelAcc.Size = new System.Drawing.Size(86, 85);
            this.btnDelAcc.TabIndex = 33;
            this.btnDelAcc.Text = "Delete Account";
            this.btnDelAcc.UseVisualStyleBackColor = false;
            this.btnDelAcc.Click += new System.EventHandler(this.btnDelAcc_Click);
            // 
            // btn_SearchAccount
            // 
            this.btn_SearchAccount.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btn_SearchAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SearchAccount.Location = new System.Drawing.Point(309, 145);
            this.btn_SearchAccount.Name = "btn_SearchAccount";
            this.btn_SearchAccount.Size = new System.Drawing.Size(114, 33);
            this.btn_SearchAccount.TabIndex = 35;
            this.btn_SearchAccount.Text = "Search";
            this.btn_SearchAccount.UseVisualStyleBackColor = false;
            this.btn_SearchAccount.Click += new System.EventHandler(this.btn_SearchAccount_Click);
            // 
            // searchAccTextBox
            // 
            this.searchAccTextBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.searchAccTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchAccTextBox.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.searchAccTextBox.Location = new System.Drawing.Point(41, 145);
            this.searchAccTextBox.Multiline = true;
            this.searchAccTextBox.Name = "searchAccTextBox";
            this.searchAccTextBox.Size = new System.Drawing.Size(236, 33);
            this.searchAccTextBox.TabIndex = 34;
            this.searchAccTextBox.Text = "Enter Account ID...";
            this.searchAccTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.searchAccTextBox.Enter += new System.EventHandler(this.searchAccEnter);
            // 
            // btnViewAcc
            // 
            this.btnViewAcc.BackColor = System.Drawing.Color.Silver;
            this.btnViewAcc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewAcc.Location = new System.Drawing.Point(252, 395);
            this.btnViewAcc.Name = "btnViewAcc";
            this.btnViewAcc.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnViewAcc.Size = new System.Drawing.Size(86, 85);
            this.btnViewAcc.TabIndex = 36;
            this.btnViewAcc.Text = "View Account";
            this.btnViewAcc.UseVisualStyleBackColor = false;
            // 
            // btnUpdateAcc
            // 
            this.btnUpdateAcc.BackColor = System.Drawing.Color.Silver;
            this.btnUpdateAcc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateAcc.Location = new System.Drawing.Point(252, 486);
            this.btnUpdateAcc.Name = "btnUpdateAcc";
            this.btnUpdateAcc.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnUpdateAcc.Size = new System.Drawing.Size(86, 85);
            this.btnUpdateAcc.TabIndex = 37;
            this.btnUpdateAcc.Text = "Update Account";
            this.btnUpdateAcc.UseVisualStyleBackColor = false;
            // 
            // btnTransfer
            // 
            this.btnTransfer.BackColor = System.Drawing.Color.Silver;
            this.btnTransfer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransfer.Location = new System.Drawing.Point(252, 577);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnTransfer.Size = new System.Drawing.Size(86, 85);
            this.btnTransfer.TabIndex = 38;
            this.btnTransfer.Text = "Bank Transfer";
            this.btnTransfer.UseVisualStyleBackColor = false;
            this.btnTransfer.Click += new System.EventHandler(this.btnTransfer_Click);
            // 
            // AcManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1493, 836);
            this.Controls.Add(this.btnTransfer);
            this.Controls.Add(this.btnUpdateAcc);
            this.Controls.Add(this.btnViewAcc);
            this.Controls.Add(this.btn_SearchAccount);
            this.Controls.Add(this.searchAccTextBox);
            this.Controls.Add(this.btnDelAcc);
            this.Controls.Add(this.btnCreateAcc);
            this.Controls.Add(this.listSelectAcc);
            this.Controls.Add(this.btn_backCustAcc);
            this.Controls.Add(this.listAccInfo);
            this.Controls.Add(this.btnChkBal);
            this.Controls.Add(this.btnCalcInt);
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
            this.Controls.SetChildIndex(this.btnCalcInt, 0);
            this.Controls.SetChildIndex(this.btnChkBal, 0);
            this.Controls.SetChildIndex(this.listAccInfo, 0);
            this.Controls.SetChildIndex(this.btn_backCustAcc, 0);
            this.Controls.SetChildIndex(this.listSelectAcc, 0);
            this.Controls.SetChildIndex(this.btnCreateAcc, 0);
            this.Controls.SetChildIndex(this.btnDelAcc, 0);
            this.Controls.SetChildIndex(this.searchAccTextBox, 0);
            this.Controls.SetChildIndex(this.btn_SearchAccount, 0);
            this.Controls.SetChildIndex(this.btnViewAcc, 0);
            this.Controls.SetChildIndex(this.btnUpdateAcc, 0);
            this.Controls.SetChildIndex(this.btnTransfer, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_backCustAcc;
        private System.Windows.Forms.ListBox listAccInfo;
        private System.Windows.Forms.Label amountLabel;
        private System.Windows.Forms.TextBox amountInputBox;
        private System.Windows.Forms.Button btnChkBal;
        private System.Windows.Forms.Button btnCalcInt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button clearInfoBtn;
        private System.Windows.Forms.Button addInterestBtn;
        private System.Windows.Forms.Button accountInfoBtn;
        private System.Windows.Forms.Button withdrawBtn;
        private System.Windows.Forms.Button depositBtn;
        private System.Windows.Forms.ListBox listSelectAcc;
        private System.Windows.Forms.Button btnCreateAcc;
        private System.Windows.Forms.Button btnDelAcc;
        private System.Windows.Forms.Button btn_SearchAccount;
        private System.Windows.Forms.TextBox searchAccTextBox;
        private System.Windows.Forms.Button btnViewAcc;
        private System.Windows.Forms.Button btnUpdateAcc;
        private System.Windows.Forms.Button btnTransfer;
    }
}

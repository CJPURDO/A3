
namespace Customers
{
    partial class CreateAccount
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
            this.inputFee = new System.Windows.Forms.TextBox();
            this.feeLabel = new System.Windows.Forms.Label();
            this.newAccLabel = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAddAcc = new System.Windows.Forms.Button();
            this.intRateLabel = new System.Windows.Forms.Label();
            this.balanceLabel = new System.Windows.Forms.Label();
            this.inputInt = new System.Windows.Forms.TextBox();
            this.inputBal = new System.Windows.Forms.TextBox();
            this.comAcc = new System.Windows.Forms.ComboBox();
            this.inputOver = new System.Windows.Forms.TextBox();
            this.overLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // inputFee
            // 
            this.inputFee.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputFee.Location = new System.Drawing.Point(213, 321);
            this.inputFee.Multiline = true;
            this.inputFee.Name = "inputFee";
            this.inputFee.Size = new System.Drawing.Size(236, 38);
            this.inputFee.TabIndex = 14;
            // 
            // feeLabel
            // 
            this.feeLabel.BackColor = System.Drawing.SystemColors.Desktop;
            this.feeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.feeLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.feeLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.feeLabel.Location = new System.Drawing.Point(55, 321);
            this.feeLabel.Name = "feeLabel";
            this.feeLabel.Size = new System.Drawing.Size(152, 52);
            this.feeLabel.TabIndex = 11;
            this.feeLabel.Text = "Fee $";
            this.feeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // newAccLabel
            // 
            this.newAccLabel.BackColor = System.Drawing.SystemColors.ControlText;
            this.newAccLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newAccLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.newAccLabel.Location = new System.Drawing.Point(169, 123);
            this.newAccLabel.Name = "newAccLabel";
            this.newAccLabel.Size = new System.Drawing.Size(305, 41);
            this.newAccLabel.TabIndex = 17;
            this.newAccLabel.Text = "Create New Account";
            this.newAccLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(367, 420);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(148, 51);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnAddAcc
            // 
            this.btnAddAcc.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnAddAcc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAcc.Location = new System.Drawing.Point(213, 420);
            this.btnAddAcc.Name = "btnAddAcc";
            this.btnAddAcc.Size = new System.Drawing.Size(148, 51);
            this.btnAddAcc.TabIndex = 15;
            this.btnAddAcc.Text = "Save New Account";
            this.btnAddAcc.UseVisualStyleBackColor = false;
            this.btnAddAcc.Click += new System.EventHandler(this.btnAddAcc_Click);
            // 
            // intRateLabel
            // 
            this.intRateLabel.BackColor = System.Drawing.SystemColors.Desktop;
            this.intRateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.intRateLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.intRateLabel.Location = new System.Drawing.Point(55, 277);
            this.intRateLabel.Name = "intRateLabel";
            this.intRateLabel.Size = new System.Drawing.Size(152, 52);
            this.intRateLabel.TabIndex = 20;
            this.intRateLabel.Text = "Interest Rate %";
            this.intRateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // balanceLabel
            // 
            this.balanceLabel.BackColor = System.Drawing.SystemColors.ControlText;
            this.balanceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.balanceLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.balanceLabel.Location = new System.Drawing.Point(58, 225);
            this.balanceLabel.Name = "balanceLabel";
            this.balanceLabel.Size = new System.Drawing.Size(152, 52);
            this.balanceLabel.TabIndex = 19;
            this.balanceLabel.Text = "Open Balance";
            this.balanceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // inputInt
            // 
            this.inputInt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputInt.Location = new System.Drawing.Point(213, 277);
            this.inputInt.Multiline = true;
            this.inputInt.Name = "inputInt";
            this.inputInt.Size = new System.Drawing.Size(236, 38);
            this.inputInt.TabIndex = 13;
            // 
            // inputBal
            // 
            this.inputBal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputBal.Location = new System.Drawing.Point(213, 233);
            this.inputBal.Multiline = true;
            this.inputBal.Name = "inputBal";
            this.inputBal.Size = new System.Drawing.Size(236, 38);
            this.inputBal.TabIndex = 12;
            // 
            // comAcc
            // 
            this.comAcc.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.comAcc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comAcc.ForeColor = System.Drawing.SystemColors.InfoText;
            this.comAcc.FormattingEnabled = true;
            this.comAcc.Items.AddRange(new object[] {
            "Everyday",
            "Investment",
            "Omni"});
            this.comAcc.Location = new System.Drawing.Point(213, 175);
            this.comAcc.Name = "comAcc";
            this.comAcc.Size = new System.Drawing.Size(240, 32);
            this.comAcc.TabIndex = 34;
            this.comAcc.Text = "Select Account";
            // 
            // inputOver
            // 
            this.inputOver.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputOver.Location = new System.Drawing.Point(213, 365);
            this.inputOver.Multiline = true;
            this.inputOver.Name = "inputOver";
            this.inputOver.Size = new System.Drawing.Size(236, 38);
            this.inputOver.TabIndex = 36;
            // 
            // overLabel
            // 
            this.overLabel.BackColor = System.Drawing.SystemColors.Desktop;
            this.overLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.overLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.overLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.overLabel.Location = new System.Drawing.Point(55, 365);
            this.overLabel.Name = "overLabel";
            this.overLabel.Size = new System.Drawing.Size(152, 52);
            this.overLabel.TabIndex = 35;
            this.overLabel.Text = "Overdraft $";
            this.overLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CreateAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(593, 617);
            this.Controls.Add(this.inputOver);
            this.Controls.Add(this.overLabel);
            this.Controls.Add(this.comAcc);
            this.Controls.Add(this.inputFee);
            this.Controls.Add(this.feeLabel);
            this.Controls.Add(this.newAccLabel);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAddAcc);
            this.Controls.Add(this.intRateLabel);
            this.Controls.Add(this.balanceLabel);
            this.Controls.Add(this.inputInt);
            this.Controls.Add(this.inputBal);
            this.Name = "CreateAccount";
            this.Text = "Create Account";
            this.Controls.SetChildIndex(this.inputBal, 0);
            this.Controls.SetChildIndex(this.inputInt, 0);
            this.Controls.SetChildIndex(this.balanceLabel, 0);
            this.Controls.SetChildIndex(this.intRateLabel, 0);
            this.Controls.SetChildIndex(this.btnAddAcc, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.newAccLabel, 0);
            this.Controls.SetChildIndex(this.feeLabel, 0);
            this.Controls.SetChildIndex(this.inputFee, 0);
            this.Controls.SetChildIndex(this.comAcc, 0);
            this.Controls.SetChildIndex(this.overLabel, 0);
            this.Controls.SetChildIndex(this.inputOver, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox inputFee;
        private System.Windows.Forms.Label feeLabel;
        private System.Windows.Forms.Label newAccLabel;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAddAcc;
        private System.Windows.Forms.Label intRateLabel;
        private System.Windows.Forms.Label balanceLabel;
        private System.Windows.Forms.TextBox inputInt;
        private System.Windows.Forms.TextBox inputBal;
        private System.Windows.Forms.ComboBox comAcc;
        private System.Windows.Forms.TextBox inputOver;
        private System.Windows.Forms.Label overLabel;
    }
}

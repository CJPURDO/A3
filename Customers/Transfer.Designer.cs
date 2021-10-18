
namespace Customers
{
    partial class Transfer
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
            this.amountLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.transferAmount = new System.Windows.Forms.TextBox();
            this.amountInputBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnTransfer = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.listFrom = new System.Windows.Forms.ListBox();
            this.listTo = new System.Windows.Forms.ListBox();
            this.textCustName2 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // amountLabel
            // 
            this.amountLabel.AutoSize = true;
            this.amountLabel.BackColor = System.Drawing.Color.White;
            this.amountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.amountLabel.Location = new System.Drawing.Point(6, 12);
            this.amountLabel.Name = "amountLabel";
            this.amountLabel.Size = new System.Drawing.Size(109, 25);
            this.amountLabel.TabIndex = 11;
            this.amountLabel.Text = "Amount  $";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.transferAmount);
            this.groupBox1.Controls.Add(this.amountLabel);
            this.groupBox1.Location = new System.Drawing.Point(152, 369);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(286, 58);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            // 
            // transferAmount
            // 
            this.transferAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transferAmount.Location = new System.Drawing.Point(109, 9);
            this.transferAmount.Multiline = true;
            this.transferAmount.Name = "transferAmount";
            this.transferAmount.Size = new System.Drawing.Size(145, 42);
            this.transferAmount.TabIndex = 12;
            this.transferAmount.Text = "0.00";
            // 
            // amountInputBox
            // 
            this.amountInputBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountInputBox.Location = new System.Drawing.Point(121, 12);
            this.amountInputBox.Multiline = true;
            this.amountInputBox.Name = "amountInputBox";
            this.amountInputBox.Size = new System.Drawing.Size(143, 37);
            this.amountInputBox.TabIndex = 10;
            this.amountInputBox.Text = "0.00";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ControlText;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(47, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(240, 41);
            this.label3.TabIndex = 21;
            this.label3.Text = "FROM";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(306, 443);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(148, 51);
            this.btnCancel.TabIndex = 20;
            this.btnCancel.Text = "<< BACK";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnTransfer
            // 
            this.btnTransfer.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnTransfer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransfer.Location = new System.Drawing.Point(152, 443);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Size = new System.Drawing.Size(148, 51);
            this.btnTransfer.TabIndex = 19;
            this.btnTransfer.Text = "Confirm Transfer";
            this.btnTransfer.UseVisualStyleBackColor = false;
            this.btnTransfer.Click += new System.EventHandler(this.btnTransfer_Click);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ControlText;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(311, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(245, 41);
            this.label4.TabIndex = 22;
            this.label4.Text = "TO";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.ControlText;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(109, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(329, 63);
            this.label5.TabIndex = 23;
            this.label5.Text = "TRANSFER FUNDS";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listFrom
            // 
            this.listFrom.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listFrom.FormattingEnabled = true;
            this.listFrom.ItemHeight = 23;
            this.listFrom.Location = new System.Drawing.Point(47, 250);
            this.listFrom.Name = "listFrom";
            this.listFrom.ScrollAlwaysVisible = true;
            this.listFrom.Size = new System.Drawing.Size(232, 96);
            this.listFrom.TabIndex = 32;
            // 
            // listTo
            // 
            this.listTo.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listTo.FormattingEnabled = true;
            this.listTo.ItemHeight = 23;
            this.listTo.Location = new System.Drawing.Point(315, 250);
            this.listTo.Name = "listTo";
            this.listTo.ScrollAlwaysVisible = true;
            this.listTo.Size = new System.Drawing.Size(232, 96);
            this.listTo.TabIndex = 33;
            // 
            // textCustName2
            // 
            this.textCustName2.BackColor = System.Drawing.SystemColors.InfoText;
            this.textCustName2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textCustName2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textCustName2.ForeColor = System.Drawing.SystemColors.Info;
            this.textCustName2.Location = new System.Drawing.Point(105, 170);
            this.textCustName2.Multiline = true;
            this.textCustName2.Name = "textCustName2";
            this.textCustName2.Size = new System.Drawing.Size(357, 33);
            this.textCustName2.TabIndex = 40;
            // 
            // Transfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(611, 544);
            this.Controls.Add(this.textCustName2);
            this.Controls.Add(this.listTo);
            this.Controls.Add(this.listFrom);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnTransfer);
            this.Controls.Add(this.groupBox1);
            this.Name = "Transfer";
            this.Text = "Transfer Funds";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Transfer_FormClosing);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.btnTransfer, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.listFrom, 0);
            this.Controls.SetChildIndex(this.listTo, 0);
            this.Controls.SetChildIndex(this.textCustName2, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label amountLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox amountInputBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnTransfer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox listFrom;
        private System.Windows.Forms.ListBox listTo;
        private System.Windows.Forms.TextBox transferAmount;
        private System.Windows.Forms.TextBox textCustName2;
    }
}

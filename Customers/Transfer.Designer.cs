
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
            this.amountInputBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAddCust = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.listFrom = new System.Windows.Forms.ListBox();
            this.listTo = new System.Windows.Forms.ListBox();
            this.transferAmount = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.accBinding)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accBinding2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
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
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Location = new System.Drawing.Point(47, 316);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(240, 35);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(4, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Balance  $";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(89, 3);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(145, 27);
            this.textBox1.TabIndex = 10;
            this.textBox1.Text = "0.00";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ControlText;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(47, 176);
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
            // btnAddCust
            // 
            this.btnAddCust.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnAddCust.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCust.Location = new System.Drawing.Point(152, 443);
            this.btnAddCust.Name = "btnAddCust";
            this.btnAddCust.Size = new System.Drawing.Size(148, 51);
            this.btnAddCust.TabIndex = 19;
            this.btnAddCust.Text = "Confirm Transfer";
            this.btnAddCust.UseVisualStyleBackColor = false;
            this.btnAddCust.Click += new System.EventHandler(this.btnAddCust_Click);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ControlText;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(311, 176);
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
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.White;
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.textBox2);
            this.groupBox3.Location = new System.Drawing.Point(316, 316);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(240, 35);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(4, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Balance  $";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(89, 3);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(145, 27);
            this.textBox2.TabIndex = 10;
            this.textBox2.Text = "0.00";
            // 
            // listFrom
            // 
            this.listFrom.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listFrom.FormattingEnabled = true;
            this.listFrom.ItemHeight = 23;
            this.listFrom.Location = new System.Drawing.Point(47, 211);
            this.listFrom.Name = "listFrom";
            this.listFrom.ScrollAlwaysVisible = true;
            this.listFrom.Size = new System.Drawing.Size(232, 50);
            this.listFrom.TabIndex = 32;
            // 
            // listTo
            // 
            this.listTo.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listTo.FormattingEnabled = true;
            this.listTo.ItemHeight = 23;
            this.listTo.Location = new System.Drawing.Point(315, 211);
            this.listTo.Name = "listTo";
            this.listTo.ScrollAlwaysVisible = true;
            this.listTo.Size = new System.Drawing.Size(232, 50);
            this.listTo.TabIndex = 33;
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
            // Transfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(611, 544);
            this.Controls.Add(this.listTo);
            this.Controls.Add(this.listFrom);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAddCust);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Transfer";
            this.Text = "Transfer Funds";
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.Controls.SetChildIndex(this.btnAddCust, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.groupBox3, 0);
            this.Controls.SetChildIndex(this.listFrom, 0);
            this.Controls.SetChildIndex(this.listTo, 0);
            ((System.ComponentModel.ISupportInitialize)(this.accBinding)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accBinding2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label amountLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox amountInputBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAddCust;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ListBox listFrom;
        private System.Windows.Forms.ListBox listTo;
        private System.Windows.Forms.TextBox transferAmount;
    }
}

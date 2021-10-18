
namespace Customers
{
    partial class Create_Account
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
            this.newAccLabel = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAddAcc = new System.Windows.Forms.Button();
            this.comAcc = new System.Windows.Forms.ComboBox();
            this.inputOver = new System.Windows.Forms.TextBox();
            this.overLabel = new System.Windows.Forms.Label();
            this.textCustName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // newAccLabel
            // 
            this.newAccLabel.BackColor = System.Drawing.SystemColors.ControlText;
            this.newAccLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newAccLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.newAccLabel.Location = new System.Drawing.Point(80, 127);
            this.newAccLabel.Name = "newAccLabel";
            this.newAccLabel.Size = new System.Drawing.Size(368, 77);
            this.newAccLabel.TabIndex = 17;
            this.newAccLabel.Text = "Create New Account";
            this.newAccLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(328, 433);
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
            this.btnAddAcc.Location = new System.Drawing.Point(174, 433);
            this.btnAddAcc.Name = "btnAddAcc";
            this.btnAddAcc.Size = new System.Drawing.Size(148, 51);
            this.btnAddAcc.TabIndex = 15;
            this.btnAddAcc.Text = "Save New Account";
            this.btnAddAcc.UseVisualStyleBackColor = false;
            this.btnAddAcc.Click += new System.EventHandler(this.btnAddAcc_Click);
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
            this.comAcc.Location = new System.Drawing.Point(170, 283);
            this.comAcc.Name = "comAcc";
            this.comAcc.Size = new System.Drawing.Size(240, 32);
            this.comAcc.TabIndex = 34;
            this.comAcc.Text = "Select Account";
            // 
            // inputOver
            // 
            this.inputOver.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputOver.Location = new System.Drawing.Point(174, 378);
            this.inputOver.Multiline = true;
            this.inputOver.Name = "inputOver";
            this.inputOver.Size = new System.Drawing.Size(148, 38);
            this.inputOver.TabIndex = 36;
            // 
            // overLabel
            // 
            this.overLabel.BackColor = System.Drawing.SystemColors.Desktop;
            this.overLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.overLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.overLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.overLabel.Location = new System.Drawing.Point(16, 354);
            this.overLabel.Name = "overLabel";
            this.overLabel.Size = new System.Drawing.Size(152, 106);
            this.overLabel.TabIndex = 35;
            this.overLabel.Text = "Overdraft -$ (Omni) ";
            this.overLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textCustName
            // 
            this.textCustName.BackColor = System.Drawing.SystemColors.InfoText;
            this.textCustName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textCustName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textCustName.ForeColor = System.Drawing.SystemColors.Info;
            this.textCustName.Location = new System.Drawing.Point(85, 219);
            this.textCustName.Multiline = true;
            this.textCustName.Name = "textCustName";
            this.textCustName.Size = new System.Drawing.Size(402, 33);
            this.textCustName.TabIndex = 40;
            // 
            // Create_Account
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(593, 617);
            this.Controls.Add(this.textCustName);
            this.Controls.Add(this.inputOver);
            this.Controls.Add(this.overLabel);
            this.Controls.Add(this.comAcc);
            this.Controls.Add(this.newAccLabel);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAddAcc);
            this.Name = "Create_Account";
            this.Text = "Create Account";
            this.Controls.SetChildIndex(this.btnAddAcc, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.newAccLabel, 0);
            this.Controls.SetChildIndex(this.comAcc, 0);
            this.Controls.SetChildIndex(this.overLabel, 0);
            this.Controls.SetChildIndex(this.inputOver, 0);
            this.Controls.SetChildIndex(this.textCustName, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label newAccLabel;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAddAcc;
        private System.Windows.Forms.ComboBox comAcc;
        private System.Windows.Forms.TextBox inputOver;
        private System.Windows.Forms.Label overLabel;
        private System.Windows.Forms.TextBox textCustName;
    }
}

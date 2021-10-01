
namespace Customers
{
    partial class Update_Customer
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
            this.fName = new System.Windows.Forms.TextBox();
            this.lName = new System.Windows.Forms.TextBox();
            this.btn_saveClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lNameLabel = new System.Windows.Forms.Label();
            this.fNameLabel = new System.Windows.Forms.Label();
            this.phone = new System.Windows.Forms.Label();
            this.phoneInput = new System.Windows.Forms.TextBox();
            this.comboType = new System.Windows.Forms.ComboBox();
            this.type = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // fName
            // 
            this.fName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fName.Location = new System.Drawing.Point(186, 243);
            this.fName.Multiline = true;
            this.fName.Name = "fName";
            this.fName.Size = new System.Drawing.Size(298, 33);
            this.fName.TabIndex = 1;
            // 
            // lName
            // 
            this.lName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lName.Location = new System.Drawing.Point(186, 283);
            this.lName.Multiline = true;
            this.lName.Name = "lName";
            this.lName.Size = new System.Drawing.Size(298, 33);
            this.lName.TabIndex = 2;
            // 
            // btn_saveClose
            // 
            this.btn_saveClose.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btn_saveClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_saveClose.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_saveClose.Location = new System.Drawing.Point(186, 380);
            this.btn_saveClose.Name = "btn_saveClose";
            this.btn_saveClose.Size = new System.Drawing.Size(144, 51);
            this.btn_saveClose.TabIndex = 4;
            this.btn_saveClose.Text = "Save and Close";
            this.btn_saveClose.UseVisualStyleBackColor = false;
            this.btn_saveClose.Click += new System.EventHandler(this.btn_saveClose_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ControlText;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(181, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(305, 41);
            this.label1.TabIndex = 6;
            this.label1.Text = "Update Existing Customer";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCancel.Location = new System.Drawing.Point(340, 380);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(144, 51);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lNameLabel
            // 
            this.lNameLabel.BackColor = System.Drawing.SystemColors.ControlText;
            this.lNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNameLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lNameLabel.Location = new System.Drawing.Point(31, 272);
            this.lNameLabel.Name = "lNameLabel";
            this.lNameLabel.Size = new System.Drawing.Size(152, 52);
            this.lNameLabel.TabIndex = 9;
            this.lNameLabel.Text = "Last Name";
            this.lNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // fNameLabel
            // 
            this.fNameLabel.BackColor = System.Drawing.SystemColors.ControlText;
            this.fNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fNameLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.fNameLabel.Location = new System.Drawing.Point(31, 235);
            this.fNameLabel.Name = "fNameLabel";
            this.fNameLabel.Size = new System.Drawing.Size(152, 52);
            this.fNameLabel.TabIndex = 8;
            this.fNameLabel.Text = "First Name";
            this.fNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // phone
            // 
            this.phone.BackColor = System.Drawing.SystemColors.ControlText;
            this.phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phone.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.phone.Location = new System.Drawing.Point(31, 313);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(152, 52);
            this.phone.TabIndex = 10;
            this.phone.Text = "Phone";
            this.phone.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // phoneInput
            // 
            this.phoneInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneInput.Location = new System.Drawing.Point(186, 324);
            this.phoneInput.Multiline = true;
            this.phoneInput.Name = "phoneInput";
            this.phoneInput.Size = new System.Drawing.Size(298, 33);
            this.phoneInput.TabIndex = 3;
            // 
            // comboType
            // 
            this.comboType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboType.FormattingEnabled = true;
            this.comboType.Items.AddRange(new object[] {
            "Customer",
            "Bank Staff"});
            this.comboType.Location = new System.Drawing.Point(186, 184);
            this.comboType.Name = "comboType";
            this.comboType.Size = new System.Drawing.Size(144, 28);
            this.comboType.TabIndex = 0;
            // 
            // type
            // 
            this.type.BackColor = System.Drawing.SystemColors.ControlText;
            this.type.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.type.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.type.Location = new System.Drawing.Point(28, 171);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(152, 52);
            this.type.TabIndex = 7;
            this.type.Text = "Type";
            this.type.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Update_Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(578, 498);
            this.Controls.Add(this.type);
            this.Controls.Add(this.comboType);
            this.Controls.Add(this.phoneInput);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.lNameLabel);
            this.Controls.Add(this.fNameLabel);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_saveClose);
            this.Controls.Add(this.lName);
            this.Controls.Add(this.fName);
            this.Name = "Update_Customer";
            this.Text = "Update Customer";
            this.Controls.SetChildIndex(this.fName, 0);
            this.Controls.SetChildIndex(this.lName, 0);
            this.Controls.SetChildIndex(this.btn_saveClose, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.fNameLabel, 0);
            this.Controls.SetChildIndex(this.lNameLabel, 0);
            this.Controls.SetChildIndex(this.phone, 0);
            this.Controls.SetChildIndex(this.phoneInput, 0);
            this.Controls.SetChildIndex(this.comboType, 0);
            this.Controls.SetChildIndex(this.type, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox fName;
        private System.Windows.Forms.TextBox lName;
        private System.Windows.Forms.Button btn_saveClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lNameLabel;
        private System.Windows.Forms.Label fNameLabel;
        private System.Windows.Forms.Label phone;
        private System.Windows.Forms.TextBox phoneInput;
        private System.Windows.Forms.ComboBox comboType;
        private System.Windows.Forms.Label type;
    }
}

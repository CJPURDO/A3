
namespace Customers
{
    partial class Delete_Customer
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
            this.yesDelete = new System.Windows.Forms.Button();
            this.noDelete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.infoLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // yesDelete
            // 
            this.yesDelete.Location = new System.Drawing.Point(82, 307);
            this.yesDelete.Name = "yesDelete";
            this.yesDelete.Size = new System.Drawing.Size(85, 34);
            this.yesDelete.TabIndex = 3;
            this.yesDelete.Text = "Yes";
            this.yesDelete.UseVisualStyleBackColor = true;
            this.yesDelete.Click += new System.EventHandler(this.yesDelete_Click);
            // 
            // noDelete
            // 
            this.noDelete.Location = new System.Drawing.Point(173, 307);
            this.noDelete.Name = "noDelete";
            this.noDelete.Size = new System.Drawing.Size(85, 34);
            this.noDelete.TabIndex = 4;
            this.noDelete.Text = "Cancel";
            this.noDelete.UseVisualStyleBackColor = true;
            this.noDelete.Click += new System.EventHandler(this.noDelete_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.MenuText;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label1.Location = new System.Drawing.Point(58, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(360, 42);
            this.label1.TabIndex = 5;
            this.label1.Text = "Are you sure you want to delete this customer?";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // infoLabel
            // 
            this.infoLabel.BackColor = System.Drawing.SystemColors.ControlText;
            this.infoLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.infoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.infoLabel.Location = new System.Drawing.Point(78, 206);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(307, 82);
            this.infoLabel.TabIndex = 6;
            // 
            // Delete_Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(496, 425);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.noDelete);
            this.Controls.Add(this.yesDelete);
            this.Name = "Delete_Customer";
            this.Text = "Delete Customer";
            this.Controls.SetChildIndex(this.yesDelete, 0);
            this.Controls.SetChildIndex(this.noDelete, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.infoLabel, 0);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button yesDelete;
        private System.Windows.Forms.Button noDelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label infoLabel;
    }
}

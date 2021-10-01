
namespace Customers
{
    partial class View_Customer
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
            this.viewLabel = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // viewLabel
            // 
            this.viewLabel.BackColor = System.Drawing.SystemColors.ControlText;
            this.viewLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.viewLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.viewLabel.Location = new System.Drawing.Point(80, 144);
            this.viewLabel.Name = "viewLabel";
            this.viewLabel.Size = new System.Drawing.Size(307, 146);
            this.viewLabel.TabIndex = 8;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(84, 308);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(85, 34);
            this.btnBack.TabIndex = 7;
            this.btnBack.Text = "<< Return";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // View_Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(511, 593);
            this.Controls.Add(this.viewLabel);
            this.Controls.Add(this.btnBack);
            this.Name = "View_Customer";
            this.Text = "View Customer";
            this.Controls.SetChildIndex(this.btnBack, 0);
            this.Controls.SetChildIndex(this.viewLabel, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label viewLabel;
        private System.Windows.Forms.Button btnBack;
    }
}

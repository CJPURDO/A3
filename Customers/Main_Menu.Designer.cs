
namespace Customers
{
    partial class Main_Menu
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
            this.mangeCustBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // mangeCustBtn
            // 
            this.mangeCustBtn.Location = new System.Drawing.Point(304, 187);
            this.mangeCustBtn.Name = "mangeCustBtn";
            this.mangeCustBtn.Size = new System.Drawing.Size(158, 51);
            this.mangeCustBtn.TabIndex = 2;
            this.mangeCustBtn.Text = "Manage Customers";
            this.mangeCustBtn.UseVisualStyleBackColor = true;
            this.mangeCustBtn.Click += new System.EventHandler(this.mangeCustBtn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(304, 244);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 51);
            this.button1.TabIndex = 3;
            this.button1.Text = "Manage Accounts";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pictureBox3.Image = global::Customers.Properties.Resources.customers;
            this.pictureBox3.Location = new System.Drawing.Point(0, 110);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(841, 383);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // Main_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 493);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.mangeCustBtn);
            this.Controls.Add(this.pictureBox3);
            this.Name = "Main_Menu";
            this.Text = "Main Menu";
            this.Controls.SetChildIndex(this.pictureBox3, 0);
            this.Controls.SetChildIndex(this.mangeCustBtn, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button mangeCustBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}
namespace WindowsFormsApp2
{
    partial class MainPageManager
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
            this.AddAdminBtn = new System.Windows.Forms.Button();
            this.viewReportsBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AddAdminBtn
            // 
            this.AddAdminBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F);
            this.AddAdminBtn.Location = new System.Drawing.Point(99, 150);
            this.AddAdminBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AddAdminBtn.Name = "AddAdminBtn";
            this.AddAdminBtn.Size = new System.Drawing.Size(131, 47);
            this.AddAdminBtn.TabIndex = 0;
            this.AddAdminBtn.Text = "Add Admin";
            this.AddAdminBtn.UseVisualStyleBackColor = true;
            this.AddAdminBtn.Click += new System.EventHandler(this.AddAdminBtn_Click);
            // 
            // viewReportsBtn
            // 
            this.viewReportsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F);
            this.viewReportsBtn.Location = new System.Drawing.Point(436, 150);
            this.viewReportsBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.viewReportsBtn.Name = "viewReportsBtn";
            this.viewReportsBtn.Size = new System.Drawing.Size(159, 47);
            this.viewReportsBtn.TabIndex = 1;
            this.viewReportsBtn.Text = "View Users";
            this.viewReportsBtn.UseVisualStyleBackColor = true;
            this.viewReportsBtn.Click += new System.EventHandler(this.viewReportsBtn_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F);
            this.button1.Location = new System.Drawing.Point(99, 262);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(181, 47);
            this.button1.TabIndex = 2;
            this.button1.Text = "View Event Types";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F);
            this.button2.Location = new System.Drawing.Point(436, 262);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(181, 47);
            this.button2.TabIndex = 3;
            this.button2.Text = "View Events";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(244, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Manager Main Page";
            // 
            // MainPageManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 475);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.viewReportsBtn);
            this.Controls.Add(this.AddAdminBtn);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MainPageManager";
            this.Text = "MainPageManager";
            this.Load += new System.EventHandler(this.MainPageManager_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddAdminBtn;
        private System.Windows.Forms.Button viewReportsBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
    }
}
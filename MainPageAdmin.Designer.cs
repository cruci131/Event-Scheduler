namespace WindowsFormsApp2
{
    partial class MainPageAdmin
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
            this.AdminCheckAvailableEvents = new System.Windows.Forms.Button();
            this.ManipulateLocationBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AdminCheckAvailableEvents
            // 
            this.AdminCheckAvailableEvents.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F);
            this.AdminCheckAvailableEvents.Location = new System.Drawing.Point(324, 200);
            this.AdminCheckAvailableEvents.Name = "AdminCheckAvailableEvents";
            this.AdminCheckAvailableEvents.Size = new System.Drawing.Size(339, 61);
            this.AdminCheckAvailableEvents.TabIndex = 0;
            this.AdminCheckAvailableEvents.Text = "Check Available Events";
            this.AdminCheckAvailableEvents.UseVisualStyleBackColor = true;
            this.AdminCheckAvailableEvents.Click += new System.EventHandler(this.AdminCheckAvailableEvents_Click);
            // 
            // ManipulateLocationBtn
            // 
            this.ManipulateLocationBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F);
            this.ManipulateLocationBtn.Location = new System.Drawing.Point(324, 316);
            this.ManipulateLocationBtn.Name = "ManipulateLocationBtn";
            this.ManipulateLocationBtn.Size = new System.Drawing.Size(339, 61);
            this.ManipulateLocationBtn.TabIndex = 1;
            this.ManipulateLocationBtn.Text = "Manipulate Locations";
            this.ManipulateLocationBtn.UseVisualStyleBackColor = true;
            this.ManipulateLocationBtn.Click += new System.EventHandler(this.ManipulateLocationBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(350, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "Admin Main Page";
            // 
            // MainPageAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 591);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ManipulateLocationBtn);
            this.Controls.Add(this.AdminCheckAvailableEvents);
            this.Name = "MainPageAdmin";
            this.Text = "MainPageAdmin";
            this.Load += new System.EventHandler(this.MainPageAdmin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AdminCheckAvailableEvents;
        private System.Windows.Forms.Button ManipulateLocationBtn;
        private System.Windows.Forms.Label label1;
    }
}
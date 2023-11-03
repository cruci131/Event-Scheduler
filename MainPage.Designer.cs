namespace WindowsFormsApp2
{
    partial class MainPageClient
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
            this.label1 = new System.Windows.Forms.Label();
            this.eventRegBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(255, 67);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Client Main Page";
            // 
            // eventRegBtn
            // 
            this.eventRegBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F);
            this.eventRegBtn.Location = new System.Drawing.Point(242, 217);
            this.eventRegBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.eventRegBtn.Name = "eventRegBtn";
            this.eventRegBtn.Size = new System.Drawing.Size(207, 47);
            this.eventRegBtn.TabIndex = 1;
            this.eventRegBtn.Text = "Event Registeration";
            this.eventRegBtn.UseVisualStyleBackColor = true;
            this.eventRegBtn.Click += new System.EventHandler(this.eventRegBtn_Click);
            // 
            // MainPageClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 442);
            this.Controls.Add(this.eventRegBtn);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MainPageClient";
            this.Text = "MainPage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button eventRegBtn;
    }
}
namespace WindowsFormsApp2
{
    partial class CheckAvailibility
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
            this.pendingGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.ApproveEventBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pendingGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // pendingGridView
            // 
            this.pendingGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pendingGridView.Location = new System.Drawing.Point(88, 144);
            this.pendingGridView.Name = "pendingGridView";
            this.pendingGridView.RowHeadersWidth = 82;
            this.pendingGridView.RowTemplate.Height = 33;
            this.pendingGridView.Size = new System.Drawing.Size(1163, 426);
            this.pendingGridView.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(532, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pending Events";
            // 
            // ApproveEventBtn
            // 
            this.ApproveEventBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F);
            this.ApproveEventBtn.Location = new System.Drawing.Point(503, 674);
            this.ApproveEventBtn.Name = "ApproveEventBtn";
            this.ApproveEventBtn.Size = new System.Drawing.Size(255, 93);
            this.ApproveEventBtn.TabIndex = 2;
            this.ApproveEventBtn.Text = "Save Status";
            this.ApproveEventBtn.UseVisualStyleBackColor = true;
            this.ApproveEventBtn.Click += new System.EventHandler(this.SaveStatustBtn_Click);
            // 
            // CheckAvailibility
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1378, 843);
            this.Controls.Add(this.ApproveEventBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pendingGridView);
            this.Name = "CheckAvailibility";
            this.Text = "CheckAvailibility";
            this.Load += new System.EventHandler(this.CheckAvailibility_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pendingGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView pendingGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ApproveEventBtn;
    }
}
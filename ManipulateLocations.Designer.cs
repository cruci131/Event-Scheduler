namespace WindowsFormsApp2
{
    partial class ManipulateLocations
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
            this.locationGridview = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.locationGridview)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.875F);
            this.label1.Location = new System.Drawing.Point(616, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "List of Locations";
            // 
            // locationGridview
            // 
            this.locationGridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.locationGridview.Location = new System.Drawing.Point(48, 162);
            this.locationGridview.Name = "locationGridview";
            this.locationGridview.RowHeadersWidth = 82;
            this.locationGridview.RowTemplate.Height = 33;
            this.locationGridview.Size = new System.Drawing.Size(1377, 513);
            this.locationGridview.TabIndex = 1;
            this.locationGridview.AllowUserToDeleteRowsChanged += new System.EventHandler(this.locationGridview_AllowUserToDeleteRowsChanged);
            this.locationGridview.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.locationGridview_CellClick);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F);
            this.button1.Location = new System.Drawing.Point(277, 747);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(329, 50);
            this.button1.TabIndex = 2;
            this.button1.Text = "Save New Location";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F);
            this.DeleteBtn.Location = new System.Drawing.Point(938, 747);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(265, 50);
            this.DeleteBtn.TabIndex = 3;
            this.DeleteBtn.Text = "Delete Location";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // ManipulateLocations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1630, 839);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.locationGridview);
            this.Controls.Add(this.label1);
            this.Name = "ManipulateLocations";
            this.Text = "ManipulateLocations";
            this.Load += new System.EventHandler(this.ManipulateLocations_Load);
            ((System.ComponentModel.ISupportInitialize)(this.locationGridview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView locationGridview;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button DeleteBtn;
    }
}
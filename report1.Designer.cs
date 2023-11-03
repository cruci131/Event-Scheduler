
namespace WindowsFormsApp2
{
    partial class report1
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
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.Reprots2 = new WindowsFormsApp2.Reprots();
            this.Reprots1 = new WindowsFormsApp2.Reprots();
            this.label1 = new System.Windows.Forms.Label();
            this.creationDateBox = new System.Windows.Forms.ComboBox();
            this.GenerateReportBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = 0;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 111);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.ReportSource = this.Reprots2;
            this.crystalReportViewer1.Size = new System.Drawing.Size(1262, 798);
            this.crystalReportViewer1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F);
            this.label1.Location = new System.Drawing.Point(279, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Creation Date";
            // 
            // creationDateBox
            // 
            this.creationDateBox.FormattingEnabled = true;
            this.creationDateBox.Location = new System.Drawing.Point(508, 34);
            this.creationDateBox.Name = "creationDateBox";
            this.creationDateBox.Size = new System.Drawing.Size(213, 33);
            this.creationDateBox.TabIndex = 2;
            // 
            // GenerateReportBtn
            // 
            this.GenerateReportBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F);
            this.GenerateReportBtn.Location = new System.Drawing.Point(821, 56);
            this.GenerateReportBtn.Name = "GenerateReportBtn";
            this.GenerateReportBtn.Size = new System.Drawing.Size(289, 49);
            this.GenerateReportBtn.TabIndex = 3;
            this.GenerateReportBtn.Text = "Generate Report";
            this.GenerateReportBtn.UseVisualStyleBackColor = true;
            this.GenerateReportBtn.Click += new System.EventHandler(this.GenerateReportBtn_Click);
            // 
            // report1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 909);
            this.Controls.Add(this.GenerateReportBtn);
            this.Controls.Add(this.creationDateBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.crystalReportViewer1);
            this.Name = "report1";
            this.Text = "report1";
            this.Load += new System.EventHandler(this.report1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private Reprots Reprots1;
        private Reprots Reprots2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox creationDateBox;
        private System.Windows.Forms.Button GenerateReportBtn;
    }
}
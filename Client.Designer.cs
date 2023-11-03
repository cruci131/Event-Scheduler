namespace WindowsFormsApp2
{
    partial class Client
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.EditEventClient = new System.Windows.Forms.Panel();
            this.editEventGridView = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.RegEventBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.l_capacity_text = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.l_budget_text = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.l_name_box = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Locations_list = new System.Windows.Forms.FlowLayoutPanel();
            this.selection = new System.Windows.Forms.Panel();
            this.user_dateSelection = new System.Windows.Forms.TextBox();
            this.Time_formula = new System.Windows.Forms.Label();
            this.user_TimeText = new System.Windows.Forms.TextBox();
            this.user_time = new System.Windows.Forms.Label();
            this.user_title = new System.Windows.Forms.Label();
            this.user_date = new System.Windows.Forms.Label();
            this.user_area = new System.Windows.Forms.Label();
            this.user_AreaCombox = new System.Windows.Forms.ComboBox();
            this.user_budgetText = new System.Windows.Forms.TextBox();
            this.user_budget = new System.Windows.Forms.Label();
            this.user_capacityText = new System.Windows.Forms.TextBox();
            this.user_capacity = new System.Windows.Forms.Label();
            this.user_eventType = new System.Windows.Forms.Label();
            this.user_eventTypeCombox = new System.Windows.Forms.ComboBox();
            this.user_search = new System.Windows.Forms.Button();
            this.EditEventClient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.editEventGridView)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.selection.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // EditEventClient
            // 
            this.EditEventClient.Controls.Add(this.editEventGridView);
            this.EditEventClient.Controls.Add(this.button1);
            this.EditEventClient.Location = new System.Drawing.Point(2, -3);
            this.EditEventClient.Name = "EditEventClient";
            this.EditEventClient.Size = new System.Drawing.Size(1196, 709);
            this.EditEventClient.TabIndex = 17;
            this.EditEventClient.Paint += new System.Windows.Forms.PaintEventHandler(this.EditEventClient_Paint);
            // 
            // editEventGridView
            // 
            this.editEventGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.editEventGridView.Location = new System.Drawing.Point(84, 79);
            this.editEventGridView.Name = "editEventGridView";
            this.editEventGridView.RowHeadersWidth = 82;
            this.editEventGridView.RowTemplate.Height = 33;
            this.editEventGridView.Size = new System.Drawing.Size(1034, 456);
            this.editEventGridView.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F);
            this.button1.Location = new System.Drawing.Point(484, 598);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(196, 46);
            this.button1.TabIndex = 0;
            this.button1.Text = "Edit Event";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel2);
            this.panel4.Controls.Add(this.panel1);
            this.panel4.Controls.Add(this.user_search);
            this.panel4.Location = new System.Drawing.Point(10, 5);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1196, 709);
            this.panel4.TabIndex = 18;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.RegEventBtn);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.l_capacity_text);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.l_budget_text);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.l_name_box);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 309);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1196, 400);
            this.panel2.TabIndex = 4;
            // 
            // RegEventBtn
            // 
            this.RegEventBtn.Location = new System.Drawing.Point(475, 277);
            this.RegEventBtn.Name = "RegEventBtn";
            this.RegEventBtn.Size = new System.Drawing.Size(184, 49);
            this.RegEventBtn.TabIndex = 6;
            this.RegEventBtn.Text = "Register Event";
            this.RegEventBtn.UseVisualStyleBackColor = true;
            this.RegEventBtn.Click += new System.EventHandler(this.RegEventBtn_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(422, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(312, 37);
            this.label2.TabIndex = 4;
            this.label2.Text = "Locations Available";
            // 
            // l_capacity_text
            // 
            this.l_capacity_text.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.l_capacity_text.Location = new System.Drawing.Point(916, 140);
            this.l_capacity_text.Name = "l_capacity_text";
            this.l_capacity_text.ReadOnly = true;
            this.l_capacity_text.Size = new System.Drawing.Size(100, 31);
            this.l_capacity_text.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(802, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Capacity: ";
            // 
            // l_budget_text
            // 
            this.l_budget_text.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.l_budget_text.Location = new System.Drawing.Point(614, 140);
            this.l_budget_text.Name = "l_budget_text";
            this.l_budget_text.ReadOnly = true;
            this.l_budget_text.Size = new System.Drawing.Size(95, 31);
            this.l_budget_text.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(515, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Budget: ";
            // 
            // l_name_box
            // 
            this.l_name_box.FormattingEnabled = true;
            this.l_name_box.Location = new System.Drawing.Point(209, 139);
            this.l_name_box.Name = "l_name_box";
            this.l_name_box.Size = new System.Drawing.Size(189, 33);
            this.l_name_box.TabIndex = 1;
            this.l_name_box.SelectedIndexChanged += new System.EventHandler(this.l_name_box_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Location Name";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Locations_list);
            this.panel1.Controls.Add(this.selection);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1196, 259);
            this.panel1.TabIndex = 3;
            // 
            // Locations_list
            // 
            this.Locations_list.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Locations_list.Location = new System.Drawing.Point(0, 303);
            this.Locations_list.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Locations_list.Name = "Locations_list";
            this.Locations_list.Size = new System.Drawing.Size(1196, 0);
            this.Locations_list.TabIndex = 15;
            // 
            // selection
            // 
            this.selection.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.selection.Controls.Add(this.user_dateSelection);
            this.selection.Controls.Add(this.Time_formula);
            this.selection.Controls.Add(this.user_TimeText);
            this.selection.Controls.Add(this.user_time);
            this.selection.Controls.Add(this.user_title);
            this.selection.Controls.Add(this.user_date);
            this.selection.Controls.Add(this.user_area);
            this.selection.Controls.Add(this.user_AreaCombox);
            this.selection.Controls.Add(this.user_budgetText);
            this.selection.Controls.Add(this.user_budget);
            this.selection.Controls.Add(this.user_capacityText);
            this.selection.Controls.Add(this.user_capacity);
            this.selection.Controls.Add(this.user_eventType);
            this.selection.Controls.Add(this.user_eventTypeCombox);
            this.selection.Dock = System.Windows.Forms.DockStyle.Top;
            this.selection.Location = new System.Drawing.Point(0, 0);
            this.selection.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.selection.Name = "selection";
            this.selection.Size = new System.Drawing.Size(1196, 303);
            this.selection.TabIndex = 16;
            // 
            // user_dateSelection
            // 
            this.user_dateSelection.Location = new System.Drawing.Point(928, 154);
            this.user_dateSelection.Name = "user_dateSelection";
            this.user_dateSelection.Size = new System.Drawing.Size(210, 31);
            this.user_dateSelection.TabIndex = 15;
            // 
            // Time_formula
            // 
            this.Time_formula.AutoSize = true;
            this.Time_formula.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Time_formula.Location = new System.Drawing.Point(583, 125);
            this.Time_formula.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Time_formula.Name = "Time_formula";
            this.Time_formula.Size = new System.Drawing.Size(77, 25);
            this.Time_formula.TabIndex = 14;
            this.Time_formula.Text = "hr:min";
            // 
            // user_TimeText
            // 
            this.user_TimeText.Location = new System.Drawing.Point(548, 151);
            this.user_TimeText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.user_TimeText.Name = "user_TimeText";
            this.user_TimeText.Size = new System.Drawing.Size(148, 31);
            this.user_TimeText.TabIndex = 13;
            // 
            // user_time
            // 
            this.user_time.AutoSize = true;
            this.user_time.Location = new System.Drawing.Point(436, 157);
            this.user_time.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.user_time.Name = "user_time";
            this.user_time.Size = new System.Drawing.Size(59, 25);
            this.user_time.TabIndex = 12;
            this.user_time.Text = "Time";
            // 
            // user_title
            // 
            this.user_title.AutoSize = true;
            this.user_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_title.Location = new System.Drawing.Point(480, 8);
            this.user_title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.user_title.Name = "user_title";
            this.user_title.Size = new System.Drawing.Size(216, 37);
            this.user_title.TabIndex = 10;
            this.user_title.Text = "Event Details";
            // 
            // user_date
            // 
            this.user_date.AutoSize = true;
            this.user_date.Location = new System.Drawing.Point(798, 160);
            this.user_date.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.user_date.Name = "user_date";
            this.user_date.Size = new System.Drawing.Size(57, 25);
            this.user_date.TabIndex = 9;
            this.user_date.Text = "Date";
            // 
            // user_area
            // 
            this.user_area.AutoSize = true;
            this.user_area.Location = new System.Drawing.Point(85, 157);
            this.user_area.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.user_area.Name = "user_area";
            this.user_area.Size = new System.Drawing.Size(57, 25);
            this.user_area.TabIndex = 7;
            this.user_area.Text = "Area";
            // 
            // user_AreaCombox
            // 
            this.user_AreaCombox.FormattingEnabled = true;
            this.user_AreaCombox.Location = new System.Drawing.Point(201, 149);
            this.user_AreaCombox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.user_AreaCombox.Name = "user_AreaCombox";
            this.user_AreaCombox.Size = new System.Drawing.Size(180, 33);
            this.user_AreaCombox.TabIndex = 6;
            // 
            // user_budgetText
            // 
            this.user_budgetText.Location = new System.Drawing.Point(928, 72);
            this.user_budgetText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.user_budgetText.Name = "user_budgetText";
            this.user_budgetText.Size = new System.Drawing.Size(148, 31);
            this.user_budgetText.TabIndex = 5;
            // 
            // user_budget
            // 
            this.user_budget.AutoSize = true;
            this.user_budget.Location = new System.Drawing.Point(798, 78);
            this.user_budget.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.user_budget.Name = "user_budget";
            this.user_budget.Size = new System.Drawing.Size(80, 25);
            this.user_budget.TabIndex = 4;
            this.user_budget.Text = "Budget";
            // 
            // user_capacityText
            // 
            this.user_capacityText.Location = new System.Drawing.Point(548, 72);
            this.user_capacityText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.user_capacityText.Name = "user_capacityText";
            this.user_capacityText.Size = new System.Drawing.Size(148, 31);
            this.user_capacityText.TabIndex = 3;
            // 
            // user_capacity
            // 
            this.user_capacity.AutoSize = true;
            this.user_capacity.Location = new System.Drawing.Point(436, 78);
            this.user_capacity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.user_capacity.Name = "user_capacity";
            this.user_capacity.Size = new System.Drawing.Size(96, 25);
            this.user_capacity.TabIndex = 2;
            this.user_capacity.Text = "Capacity";
            // 
            // user_eventType
            // 
            this.user_eventType.AutoSize = true;
            this.user_eventType.Location = new System.Drawing.Point(52, 78);
            this.user_eventType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.user_eventType.Name = "user_eventType";
            this.user_eventType.Size = new System.Drawing.Size(125, 25);
            this.user_eventType.TabIndex = 1;
            this.user_eventType.Text = "Event types";
            // 
            // user_eventTypeCombox
            // 
            this.user_eventTypeCombox.FormattingEnabled = true;
            this.user_eventTypeCombox.Location = new System.Drawing.Point(201, 70);
            this.user_eventTypeCombox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.user_eventTypeCombox.Name = "user_eventTypeCombox";
            this.user_eventTypeCombox.Size = new System.Drawing.Size(180, 33);
            this.user_eventTypeCombox.TabIndex = 0;
            // 
            // user_search
            // 
            this.user_search.Location = new System.Drawing.Point(505, 251);
            this.user_search.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.user_search.Name = "user_search";
            this.user_search.Size = new System.Drawing.Size(121, 50);
            this.user_search.TabIndex = 11;
            this.user_search.Text = "Search";
            this.user_search.UseVisualStyleBackColor = true;
            this.user_search.Click += new System.EventHandler(this.user_search_Click);
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 703);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.EditEventClient);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Client";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Client_Load_1);
            this.EditEventClient.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.editEventGridView)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.selection.ResumeLayout(false);
            this.selection.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Panel EditEventClient;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button RegEventBtn;
        private System.Windows.Forms.TextBox l_capacity_text;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox l_budget_text;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox l_name_box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel Locations_list;
        private System.Windows.Forms.Panel selection;
        private System.Windows.Forms.TextBox user_dateSelection;
        private System.Windows.Forms.Label Time_formula;
        private System.Windows.Forms.TextBox user_TimeText;
        private System.Windows.Forms.Label user_time;
        private System.Windows.Forms.Button user_search;
        private System.Windows.Forms.Label user_title;
        private System.Windows.Forms.Label user_date;
        private System.Windows.Forms.Label user_area;
        private System.Windows.Forms.ComboBox user_AreaCombox;
        private System.Windows.Forms.TextBox user_budgetText;
        private System.Windows.Forms.Label user_budget;
        private System.Windows.Forms.TextBox user_capacityText;
        private System.Windows.Forms.Label user_capacity;
        private System.Windows.Forms.Label user_eventType;
        private System.Windows.Forms.ComboBox user_eventTypeCombox;
        private System.Windows.Forms.DataGridView editEventGridView;
    }
}
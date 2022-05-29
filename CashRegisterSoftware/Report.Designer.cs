namespace CashRegisterSoftware
{
    partial class Report
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
            this.reportTypeComboBox = new System.Windows.Forms.ComboBox();
            this.ReportTypeLabel = new System.Windows.Forms.Label();
            this.timePeriodLabel = new System.Windows.Forms.Label();
            this.fromDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.toDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.fromTimePeriodLabel = new System.Windows.Forms.Label();
            this.toTimePeriodLabel = new System.Windows.Forms.Label();
            this.reportDataGridView = new System.Windows.Forms.DataGridView();
            this.reportGroupBox = new System.Windows.Forms.GroupBox();
            this.selectReportbutton = new System.Windows.Forms.Button();
            this.cashRegisterToolStripLabelRS = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.maintainanceToolStripLabelRS = new System.Windows.Forms.ToolStripLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            ((System.ComponentModel.ISupportInitialize)(this.reportDataGridView)).BeginInit();
            this.reportGroupBox.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // reportTypeComboBox
            // 
            this.reportTypeComboBox.FormattingEnabled = true;
            this.reportTypeComboBox.Items.AddRange(new object[] {
            "Total Sales",
            "10 Most Sold Items"});
            this.reportTypeComboBox.Location = new System.Drawing.Point(93, 23);
            this.reportTypeComboBox.Name = "reportTypeComboBox";
            this.reportTypeComboBox.Size = new System.Drawing.Size(179, 24);
            this.reportTypeComboBox.TabIndex = 0;
            // 
            // ReportTypeLabel
            // 
            this.ReportTypeLabel.AutoSize = true;
            this.ReportTypeLabel.Location = new System.Drawing.Point(1, 23);
            this.ReportTypeLabel.Name = "ReportTypeLabel";
            this.ReportTypeLabel.Size = new System.Drawing.Size(87, 16);
            this.ReportTypeLabel.TabIndex = 2;
            this.ReportTypeLabel.Text = "Report Type:";
            // 
            // timePeriodLabel
            // 
            this.timePeriodLabel.AutoSize = true;
            this.timePeriodLabel.Location = new System.Drawing.Point(290, 23);
            this.timePeriodLabel.Name = "timePeriodLabel";
            this.timePeriodLabel.Size = new System.Drawing.Size(85, 16);
            this.timePeriodLabel.TabIndex = 3;
            this.timePeriodLabel.Text = "Time Period:";
            // 
            // fromDateTimePicker
            // 
            this.fromDateTimePicker.Location = new System.Drawing.Point(381, 42);
            this.fromDateTimePicker.Name = "fromDateTimePicker";
            this.fromDateTimePicker.Size = new System.Drawing.Size(179, 22);
            this.fromDateTimePicker.TabIndex = 4;
            this.fromDateTimePicker.ValueChanged += new System.EventHandler(this.fromDateTimePicker_ValueChanged);
            this.fromDateTimePicker.Enter += new System.EventHandler(this.fromDateTimePicker_Enter);
            // 
            // toDateTimePicker
            // 
            this.toDateTimePicker.Location = new System.Drawing.Point(582, 42);
            this.toDateTimePicker.Name = "toDateTimePicker";
            this.toDateTimePicker.Size = new System.Drawing.Size(179, 22);
            this.toDateTimePicker.TabIndex = 5;
            this.toDateTimePicker.Enter += new System.EventHandler(this.toDateTimePicker_Enter);
            // 
            // fromTimePeriodLabel
            // 
            this.fromTimePeriodLabel.AutoSize = true;
            this.fromTimePeriodLabel.Location = new System.Drawing.Point(446, 23);
            this.fromTimePeriodLabel.Name = "fromTimePeriodLabel";
            this.fromTimePeriodLabel.Size = new System.Drawing.Size(42, 16);
            this.fromTimePeriodLabel.TabIndex = 6;
            this.fromTimePeriodLabel.Text = "From:";
            // 
            // toTimePeriodLabel
            // 
            this.toTimePeriodLabel.AutoSize = true;
            this.toTimePeriodLabel.Location = new System.Drawing.Point(658, 23);
            this.toTimePeriodLabel.Name = "toTimePeriodLabel";
            this.toTimePeriodLabel.Size = new System.Drawing.Size(25, 16);
            this.toTimePeriodLabel.TabIndex = 7;
            this.toTimePeriodLabel.Text = "To";
            // 
            // reportDataGridView
            // 
            this.reportDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reportDataGridView.Location = new System.Drawing.Point(12, 120);
            this.reportDataGridView.Name = "reportDataGridView";
            this.reportDataGridView.Size = new System.Drawing.Size(777, 318);
            this.reportDataGridView.TabIndex = 9;
            // 
            // reportGroupBox
            // 
            this.reportGroupBox.Controls.Add(this.selectReportbutton);
            this.reportGroupBox.Controls.Add(this.toTimePeriodLabel);
            this.reportGroupBox.Controls.Add(this.fromTimePeriodLabel);
            this.reportGroupBox.Controls.Add(this.toDateTimePicker);
            this.reportGroupBox.Controls.Add(this.fromDateTimePicker);
            this.reportGroupBox.Controls.Add(this.timePeriodLabel);
            this.reportGroupBox.Controls.Add(this.ReportTypeLabel);
            this.reportGroupBox.Controls.Add(this.reportTypeComboBox);
            this.reportGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportGroupBox.Location = new System.Drawing.Point(12, 28);
            this.reportGroupBox.Name = "reportGroupBox";
            this.reportGroupBox.Size = new System.Drawing.Size(776, 86);
            this.reportGroupBox.TabIndex = 10;
            this.reportGroupBox.TabStop = false;
            this.reportGroupBox.Text = "Select and generate report";
            // 
            // selectReportbutton
            // 
            this.selectReportbutton.Location = new System.Drawing.Point(140, 53);
            this.selectReportbutton.Name = "selectReportbutton";
            this.selectReportbutton.Size = new System.Drawing.Size(75, 23);
            this.selectReportbutton.TabIndex = 8;
            this.selectReportbutton.Text = "Select";
            this.selectReportbutton.UseVisualStyleBackColor = true;
            this.selectReportbutton.Click += new System.EventHandler(this.selectReportbutton_Click);
            // 
            // cashRegisterToolStripLabelRS
            // 
            this.cashRegisterToolStripLabelRS.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashRegisterToolStripLabelRS.Name = "cashRegisterToolStripLabelRS";
            this.cashRegisterToolStripLabelRS.Size = new System.Drawing.Size(115, 22);
            this.cashRegisterToolStripLabelRS.Text = "Cash Register";
            this.cashRegisterToolStripLabelRS.Click += new System.EventHandler(this.cashRegisterToolStripLabelRS_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // maintainanceToolStripLabelRS
            // 
            this.maintainanceToolStripLabelRS.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maintainanceToolStripLabelRS.Name = "maintainanceToolStripLabelRS";
            this.maintainanceToolStripLabelRS.Size = new System.Drawing.Size(107, 22);
            this.maintainanceToolStripLabelRS.Text = "Maintainance";
            this.maintainanceToolStripLabelRS.Click += new System.EventHandler(this.maintainanceToolStripLabelRS_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cashRegisterToolStripLabelRS,
            this.toolStripSeparator4,
            this.toolStripSeparator1,
            this.maintainanceToolStripLabelRS});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 8;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportGroupBox);
            this.Controls.Add(this.reportDataGridView);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Report";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Report";
            this.Load += new System.EventHandler(this.report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reportDataGridView)).EndInit();
            this.reportGroupBox.ResumeLayout(false);
            this.reportGroupBox.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox reportTypeComboBox;
        private System.Windows.Forms.Label ReportTypeLabel;
        private System.Windows.Forms.Label timePeriodLabel;
        private System.Windows.Forms.DateTimePicker fromDateTimePicker;
        private System.Windows.Forms.DateTimePicker toDateTimePicker;
        private System.Windows.Forms.Label fromTimePeriodLabel;
        private System.Windows.Forms.Label toTimePeriodLabel;
        private System.Windows.Forms.DataGridView reportDataGridView;
        private System.Windows.Forms.GroupBox reportGroupBox;
        private System.Windows.Forms.ToolStripLabel cashRegisterToolStripLabelRS;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel maintainanceToolStripLabelRS;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Button selectReportbutton;
    }
}
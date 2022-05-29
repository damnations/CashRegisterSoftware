namespace CashRegisterSoftware
{
    partial class CashRegister
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.reportToolStripLabelCRS = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.maintainanceToolStripLabelCRS = new System.Windows.Forms.ToolStripLabel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBoxCR = new System.Windows.Forms.GroupBox();
            this.totalTextBoxCR = new System.Windows.Forms.TextBox();
            this.cancelButtonCR = new System.Windows.Forms.Button();
            this.checkoutButtonCR = new System.Windows.Forms.Button();
            this.productNameComboBoxCR = new System.Windows.Forms.ComboBox();
            this.produtNameLabelCR = new System.Windows.Forms.Label();
            this.totalLabelCR = new System.Windows.Forms.Label();
            this.numberSoldLabelCR = new System.Windows.Forms.Label();
            this.finalPriceabelCR = new System.Windows.Forms.Label();
            this.numberSoldTextBoxCR = new System.Windows.Forms.TextBox();
            this.finalPriceTextBoxCR = new System.Windows.Forms.TextBox();
            this.dataGridViewCR = new System.Windows.Forms.DataGridView();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBoxCR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCR)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reportToolStripLabelCRS,
            this.toolStripSeparator3,
            this.toolStripSeparator2,
            this.maintainanceToolStripLabelCRS});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // reportToolStripLabelCRS
            // 
            this.reportToolStripLabelCRS.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportToolStripLabelCRS.Name = "reportToolStripLabelCRS";
            this.reportToolStripLabelCRS.Size = new System.Drawing.Size(59, 22);
            this.reportToolStripLabelCRS.Text = "Report";
            this.reportToolStripLabelCRS.Click += new System.EventHandler(this.reportToolStripLabelCRS_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // maintainanceToolStripLabelCRS
            // 
            this.maintainanceToolStripLabelCRS.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maintainanceToolStripLabelCRS.Name = "maintainanceToolStripLabelCRS";
            this.maintainanceToolStripLabelCRS.Size = new System.Drawing.Size(107, 22);
            this.maintainanceToolStripLabelCRS.Text = "Maintainance";
            this.maintainanceToolStripLabelCRS.Click += new System.EventHandler(this.maintainanceToolStripLabelCRS_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 25);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBoxCR);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridViewCR);
            this.splitContainer1.Size = new System.Drawing.Size(800, 425);
            this.splitContainer1.SplitterDistance = 266;
            this.splitContainer1.TabIndex = 1;
            // 
            // groupBoxCR
            // 
            this.groupBoxCR.Controls.Add(this.totalTextBoxCR);
            this.groupBoxCR.Controls.Add(this.cancelButtonCR);
            this.groupBoxCR.Controls.Add(this.checkoutButtonCR);
            this.groupBoxCR.Controls.Add(this.productNameComboBoxCR);
            this.groupBoxCR.Controls.Add(this.produtNameLabelCR);
            this.groupBoxCR.Controls.Add(this.totalLabelCR);
            this.groupBoxCR.Controls.Add(this.numberSoldLabelCR);
            this.groupBoxCR.Controls.Add(this.finalPriceabelCR);
            this.groupBoxCR.Controls.Add(this.numberSoldTextBoxCR);
            this.groupBoxCR.Controls.Add(this.finalPriceTextBoxCR);
            this.groupBoxCR.Location = new System.Drawing.Point(12, 19);
            this.groupBoxCR.Name = "groupBoxCR";
            this.groupBoxCR.Size = new System.Drawing.Size(242, 385);
            this.groupBoxCR.TabIndex = 12;
            this.groupBoxCR.TabStop = false;
            this.groupBoxCR.Text = "Cash Register";
            // 
            // totalTextBoxCR
            // 
            this.totalTextBoxCR.Location = new System.Drawing.Point(38, 299);
            this.totalTextBoxCR.Name = "totalTextBoxCR";
            this.totalTextBoxCR.ReadOnly = true;
            this.totalTextBoxCR.Size = new System.Drawing.Size(167, 20);
            this.totalTextBoxCR.TabIndex = 1;
            // 
            // cancelButtonCR
            // 
            this.cancelButtonCR.Location = new System.Drawing.Point(128, 351);
            this.cancelButtonCR.Name = "cancelButtonCR";
            this.cancelButtonCR.Size = new System.Drawing.Size(106, 25);
            this.cancelButtonCR.TabIndex = 11;
            this.cancelButtonCR.Text = "Cancel";
            this.cancelButtonCR.UseVisualStyleBackColor = true;
            this.cancelButtonCR.Click += new System.EventHandler(this.cancelButtonCR_Click);
            // 
            // checkoutButtonCR
            // 
            this.checkoutButtonCR.Location = new System.Drawing.Point(9, 351);
            this.checkoutButtonCR.Name = "checkoutButtonCR";
            this.checkoutButtonCR.Size = new System.Drawing.Size(106, 25);
            this.checkoutButtonCR.TabIndex = 10;
            this.checkoutButtonCR.Text = "Checkout";
            this.checkoutButtonCR.UseVisualStyleBackColor = true;
            this.checkoutButtonCR.Click += new System.EventHandler(this.checkoutButtonCR_Click);
            // 
            // productNameComboBoxCR
            // 
            this.productNameComboBoxCR.FormattingEnabled = true;
            this.productNameComboBoxCR.Items.AddRange(new object[] {
            ""});
            this.productNameComboBoxCR.Location = new System.Drawing.Point(37, 57);
            this.productNameComboBoxCR.Name = "productNameComboBoxCR";
            this.productNameComboBoxCR.Size = new System.Drawing.Size(168, 21);
            this.productNameComboBoxCR.TabIndex = 1;
            // 
            // produtNameLabelCR
            // 
            this.produtNameLabelCR.AutoSize = true;
            this.produtNameLabelCR.Location = new System.Drawing.Point(75, 30);
            this.produtNameLabelCR.Name = "produtNameLabelCR";
            this.produtNameLabelCR.Size = new System.Drawing.Size(78, 13);
            this.produtNameLabelCR.TabIndex = 2;
            this.produtNameLabelCR.Text = "Product Name:";
            // 
            // totalLabelCR
            // 
            this.totalLabelCR.AutoSize = true;
            this.totalLabelCR.Location = new System.Drawing.Point(94, 273);
            this.totalLabelCR.Name = "totalLabelCR";
            this.totalLabelCR.Size = new System.Drawing.Size(34, 13);
            this.totalLabelCR.TabIndex = 1;
            this.totalLabelCR.Text = "Total:";
            // 
            // numberSoldLabelCR
            // 
            this.numberSoldLabelCR.AutoSize = true;
            this.numberSoldLabelCR.Location = new System.Drawing.Point(94, 194);
            this.numberSoldLabelCR.Name = "numberSoldLabelCR";
            this.numberSoldLabelCR.Size = new System.Drawing.Size(71, 13);
            this.numberSoldLabelCR.TabIndex = 3;
            this.numberSoldLabelCR.Text = "Number Sold:";
            // 
            // finalPriceabelCR
            // 
            this.finalPriceabelCR.AutoSize = true;
            this.finalPriceabelCR.Location = new System.Drawing.Point(94, 110);
            this.finalPriceabelCR.Name = "finalPriceabelCR";
            this.finalPriceabelCR.Size = new System.Drawing.Size(59, 13);
            this.finalPriceabelCR.TabIndex = 1;
            this.finalPriceabelCR.Text = "Final Price:";
            // 
            // numberSoldTextBoxCR
            // 
            this.numberSoldTextBoxCR.Location = new System.Drawing.Point(38, 220);
            this.numberSoldTextBoxCR.Name = "numberSoldTextBoxCR";
            this.numberSoldTextBoxCR.Size = new System.Drawing.Size(168, 20);
            this.numberSoldTextBoxCR.TabIndex = 1;
            this.numberSoldTextBoxCR.TextChanged += new System.EventHandler(this.numberSoldTextBoxCR_TextChanged);
            this.numberSoldTextBoxCR.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numberSoldTextBoxCR_KeyPress);
            // 
            // finalPriceTextBoxCR
            // 
            this.finalPriceTextBoxCR.Location = new System.Drawing.Point(38, 135);
            this.finalPriceTextBoxCR.Name = "finalPriceTextBoxCR";
            this.finalPriceTextBoxCR.Size = new System.Drawing.Size(168, 20);
            this.finalPriceTextBoxCR.TabIndex = 1;
            this.finalPriceTextBoxCR.TextChanged += new System.EventHandler(this.finalPriceTextBoxCR_TextChanged);
            this.finalPriceTextBoxCR.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.finalPriceTextBoxCR_KeyPress);
            // 
            // dataGridViewCR
            // 
            this.dataGridViewCR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewCR.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewCR.Name = "dataGridViewCR";
            this.dataGridViewCR.Size = new System.Drawing.Size(530, 425);
            this.dataGridViewCR.TabIndex = 0;
            // 
            // CashRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "CashRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CashRegister";
            this.Load += new System.EventHandler(this.CashRegister_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBoxCR.ResumeLayout(false);
            this.groupBoxCR.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel reportToolStripLabelCRS;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel maintainanceToolStripLabelCRS;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dataGridViewCR;
        private System.Windows.Forms.Label produtNameLabelCR;
        private System.Windows.Forms.Label numberSoldLabelCR;
        private System.Windows.Forms.Label finalPriceabelCR;
        private System.Windows.Forms.TextBox numberSoldTextBoxCR;
        private System.Windows.Forms.TextBox finalPriceTextBoxCR;
        private System.Windows.Forms.Label totalLabelCR;
        private System.Windows.Forms.ComboBox productNameComboBoxCR;
        private System.Windows.Forms.Button cancelButtonCR;
        private System.Windows.Forms.Button checkoutButtonCR;
        private System.Windows.Forms.GroupBox groupBoxCR;
        private System.Windows.Forms.TextBox totalTextBoxCR;
    }
}
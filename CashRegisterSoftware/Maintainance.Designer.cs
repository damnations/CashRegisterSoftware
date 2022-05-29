namespace CashRegisterSoftware
{
    partial class Maintainance
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
            this.cashRegisterToolStripLabelMS = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.reportToolStripLabelMS = new System.Windows.Forms.ToolStripLabel();
            this.maintainanceTabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cancelButtonAdd = new System.Windows.Forms.Button();
            this.saveButtonAdd = new System.Windows.Forms.Button();
            this.stockTextBoxAdd = new System.Windows.Forms.TextBox();
            this.productPriceTextBoxAdd = new System.Windows.Forms.TextBox();
            this.availabilityComboBoxAdd = new System.Windows.Forms.ComboBox();
            this.productNameTextBoxAdd = new System.Windows.Forms.TextBox();
            this.availabilityLabelAdd = new System.Windows.Forms.Label();
            this.stockLabelAdd = new System.Windows.Forms.Label();
            this.productPriceLabelAdd = new System.Windows.Forms.Label();
            this.productNameLabelAdd = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.searchGroupBox = new System.Windows.Forms.GroupBox();
            this.productIDSearchTextBox = new System.Windows.Forms.TextBox();
            this.productIDSearchLabel = new System.Windows.Forms.Label();
            this.productNameSearchLabel = new System.Windows.Forms.Label();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.cancelButtonEdit = new System.Windows.Forms.Button();
            this.addButtonEdit = new System.Windows.Forms.Button();
            this.stockTextBoxEdit = new System.Windows.Forms.TextBox();
            this.productPriceTextBoxEdit = new System.Windows.Forms.TextBox();
            this.availabilityComboBoxEdit = new System.Windows.Forms.ComboBox();
            this.productNameTextBoxEdit = new System.Windows.Forms.TextBox();
            this.availabilityLabelEdit = new System.Windows.Forms.Label();
            this.stockLabelEdit = new System.Windows.Forms.Label();
            this.productPriceLabelEdit = new System.Windows.Forms.Label();
            this.productNameLabelEdit = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.maintainanceTabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.searchGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cashRegisterToolStripLabelMS,
            this.toolStripSeparator4,
            this.toolStripSeparator1,
            this.reportToolStripLabelMS});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // cashRegisterToolStripLabelMS
            // 
            this.cashRegisterToolStripLabelMS.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashRegisterToolStripLabelMS.Name = "cashRegisterToolStripLabelMS";
            this.cashRegisterToolStripLabelMS.Size = new System.Drawing.Size(115, 22);
            this.cashRegisterToolStripLabelMS.Text = "Cash Register";
            this.cashRegisterToolStripLabelMS.Click += new System.EventHandler(this.cashRegisterToolStripLabelMS_Click);
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
            // reportToolStripLabelMS
            // 
            this.reportToolStripLabelMS.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportToolStripLabelMS.Name = "reportToolStripLabelMS";
            this.reportToolStripLabelMS.Size = new System.Drawing.Size(59, 22);
            this.reportToolStripLabelMS.Text = "Report";
            this.reportToolStripLabelMS.Click += new System.EventHandler(this.reportToolStripLabelMS_Click);
            // 
            // maintainanceTabControl
            // 
            this.maintainanceTabControl.Controls.Add(this.tabPage1);
            this.maintainanceTabControl.Controls.Add(this.tabPage2);
            this.maintainanceTabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maintainanceTabControl.Location = new System.Drawing.Point(12, 28);
            this.maintainanceTabControl.Multiline = true;
            this.maintainanceTabControl.Name = "maintainanceTabControl";
            this.maintainanceTabControl.SelectedIndex = 0;
            this.maintainanceTabControl.Size = new System.Drawing.Size(776, 410);
            this.maintainanceTabControl.TabIndex = 1;
            this.maintainanceTabControl.Tag = "";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.cancelButtonAdd);
            this.tabPage1.Controls.Add(this.saveButtonAdd);
            this.tabPage1.Controls.Add(this.stockTextBoxAdd);
            this.tabPage1.Controls.Add(this.productPriceTextBoxAdd);
            this.tabPage1.Controls.Add(this.availabilityComboBoxAdd);
            this.tabPage1.Controls.Add(this.productNameTextBoxAdd);
            this.tabPage1.Controls.Add(this.availabilityLabelAdd);
            this.tabPage1.Controls.Add(this.stockLabelAdd);
            this.tabPage1.Controls.Add(this.productPriceLabelAdd);
            this.tabPage1.Controls.Add(this.productNameLabelAdd);
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 379);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Add Product";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // cancelButtonAdd
            // 
            this.cancelButtonAdd.Location = new System.Drawing.Point(435, 316);
            this.cancelButtonAdd.Name = "cancelButtonAdd";
            this.cancelButtonAdd.Size = new System.Drawing.Size(106, 25);
            this.cancelButtonAdd.TabIndex = 9;
            this.cancelButtonAdd.Text = "Cancel";
            this.cancelButtonAdd.UseVisualStyleBackColor = true;
            this.cancelButtonAdd.Click += new System.EventHandler(this.cancelButtonAdd_Click);
            // 
            // saveButtonAdd
            // 
            this.saveButtonAdd.Location = new System.Drawing.Point(313, 316);
            this.saveButtonAdd.Name = "saveButtonAdd";
            this.saveButtonAdd.Size = new System.Drawing.Size(106, 25);
            this.saveButtonAdd.TabIndex = 8;
            this.saveButtonAdd.Text = "Save";
            this.saveButtonAdd.UseVisualStyleBackColor = true;
            this.saveButtonAdd.Click += new System.EventHandler(this.saveButtonAdd_Click);
            // 
            // stockTextBoxAdd
            // 
            this.stockTextBoxAdd.Location = new System.Drawing.Point(313, 166);
            this.stockTextBoxAdd.Name = "stockTextBoxAdd";
            this.stockTextBoxAdd.Size = new System.Drawing.Size(228, 24);
            this.stockTextBoxAdd.TabIndex = 7;
            this.stockTextBoxAdd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.stockTextBoxAdd_KeyPress);
            // 
            // productPriceTextBoxAdd
            // 
            this.productPriceTextBoxAdd.Location = new System.Drawing.Point(313, 109);
            this.productPriceTextBoxAdd.Name = "productPriceTextBoxAdd";
            this.productPriceTextBoxAdd.Size = new System.Drawing.Size(228, 24);
            this.productPriceTextBoxAdd.TabIndex = 6;
            this.productPriceTextBoxAdd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.productPriceTextBoxAdd_KeyPress);
            // 
            // availabilityComboBoxAdd
            // 
            this.availabilityComboBoxAdd.FormattingEnabled = true;
            this.availabilityComboBoxAdd.Items.AddRange(new object[] {
            "Available",
            "Discontinued"});
            this.availabilityComboBoxAdd.Location = new System.Drawing.Point(313, 233);
            this.availabilityComboBoxAdd.Name = "availabilityComboBoxAdd";
            this.availabilityComboBoxAdd.Size = new System.Drawing.Size(228, 26);
            this.availabilityComboBoxAdd.TabIndex = 5;
            // 
            // productNameTextBoxAdd
            // 
            this.productNameTextBoxAdd.Location = new System.Drawing.Point(313, 47);
            this.productNameTextBoxAdd.Name = "productNameTextBoxAdd";
            this.productNameTextBoxAdd.Size = new System.Drawing.Size(228, 24);
            this.productNameTextBoxAdd.TabIndex = 4;
            // 
            // availabilityLabelAdd
            // 
            this.availabilityLabelAdd.AutoSize = true;
            this.availabilityLabelAdd.Location = new System.Drawing.Point(193, 236);
            this.availabilityLabelAdd.Name = "availabilityLabelAdd";
            this.availabilityLabelAdd.Size = new System.Drawing.Size(78, 18);
            this.availabilityLabelAdd.TabIndex = 3;
            this.availabilityLabelAdd.Text = "Availability:";
            // 
            // stockLabelAdd
            // 
            this.stockLabelAdd.AutoSize = true;
            this.stockLabelAdd.Location = new System.Drawing.Point(193, 169);
            this.stockLabelAdd.Name = "stockLabelAdd";
            this.stockLabelAdd.Size = new System.Drawing.Size(51, 18);
            this.stockLabelAdd.TabIndex = 2;
            this.stockLabelAdd.Text = "Stock:";
            // 
            // productPriceLabelAdd
            // 
            this.productPriceLabelAdd.AutoSize = true;
            this.productPriceLabelAdd.Location = new System.Drawing.Point(193, 112);
            this.productPriceLabelAdd.Name = "productPriceLabelAdd";
            this.productPriceLabelAdd.Size = new System.Drawing.Size(102, 18);
            this.productPriceLabelAdd.TabIndex = 1;
            this.productPriceLabelAdd.Text = "Product Price:";
            // 
            // productNameLabelAdd
            // 
            this.productNameLabelAdd.AutoSize = true;
            this.productNameLabelAdd.Location = new System.Drawing.Point(193, 50);
            this.productNameLabelAdd.Name = "productNameLabelAdd";
            this.productNameLabelAdd.Size = new System.Drawing.Size(108, 18);
            this.productNameLabelAdd.TabIndex = 0;
            this.productNameLabelAdd.Text = "Product Name:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.searchGroupBox);
            this.tabPage2.Controls.Add(this.cancelButtonEdit);
            this.tabPage2.Controls.Add(this.addButtonEdit);
            this.tabPage2.Controls.Add(this.stockTextBoxEdit);
            this.tabPage2.Controls.Add(this.productPriceTextBoxEdit);
            this.tabPage2.Controls.Add(this.availabilityComboBoxEdit);
            this.tabPage2.Controls.Add(this.productNameTextBoxEdit);
            this.tabPage2.Controls.Add(this.availabilityLabelEdit);
            this.tabPage2.Controls.Add(this.stockLabelEdit);
            this.tabPage2.Controls.Add(this.productPriceLabelEdit);
            this.tabPage2.Controls.Add(this.productNameLabelEdit);
            this.tabPage2.Location = new System.Drawing.Point(4, 27);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 379);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Edit Product";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // searchGroupBox
            // 
            this.searchGroupBox.Controls.Add(this.productIDSearchTextBox);
            this.searchGroupBox.Controls.Add(this.productIDSearchLabel);
            this.searchGroupBox.Controls.Add(this.productNameSearchLabel);
            this.searchGroupBox.Controls.Add(this.searchTextBox);
            this.searchGroupBox.Controls.Add(this.searchButton);
            this.searchGroupBox.Location = new System.Drawing.Point(6, 6);
            this.searchGroupBox.Name = "searchGroupBox";
            this.searchGroupBox.Size = new System.Drawing.Size(756, 49);
            this.searchGroupBox.TabIndex = 22;
            this.searchGroupBox.TabStop = false;
            this.searchGroupBox.Text = "Search and edit";
            // 
            // productIDSearchTextBox
            // 
            this.productIDSearchTextBox.Location = new System.Drawing.Point(508, 14);
            this.productIDSearchTextBox.Name = "productIDSearchTextBox";
            this.productIDSearchTextBox.Size = new System.Drawing.Size(125, 24);
            this.productIDSearchTextBox.TabIndex = 25;
            this.productIDSearchTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.productIDSearchTextBox_KeyPress);
            // 
            // productIDSearchLabel
            // 
            this.productIDSearchLabel.AutoSize = true;
            this.productIDSearchLabel.Location = new System.Drawing.Point(418, 17);
            this.productIDSearchLabel.Name = "productIDSearchLabel";
            this.productIDSearchLabel.Size = new System.Drawing.Size(82, 18);
            this.productIDSearchLabel.TabIndex = 24;
            this.productIDSearchLabel.Text = "Product ID:";
            // 
            // productNameSearchLabel
            // 
            this.productNameSearchLabel.AutoSize = true;
            this.productNameSearchLabel.Location = new System.Drawing.Point(6, 19);
            this.productNameSearchLabel.Name = "productNameSearchLabel";
            this.productNameSearchLabel.Size = new System.Drawing.Size(108, 18);
            this.productNameSearchLabel.TabIndex = 23;
            this.productNameSearchLabel.Text = "Product Name:";
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(120, 14);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(270, 24);
            this.searchTextBox.TabIndex = 21;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(663, 12);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(87, 28);
            this.searchButton.TabIndex = 20;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // cancelButtonEdit
            // 
            this.cancelButtonEdit.Location = new System.Drawing.Point(447, 328);
            this.cancelButtonEdit.Name = "cancelButtonEdit";
            this.cancelButtonEdit.Size = new System.Drawing.Size(106, 25);
            this.cancelButtonEdit.TabIndex = 19;
            this.cancelButtonEdit.Text = "Cancel";
            this.cancelButtonEdit.UseVisualStyleBackColor = true;
            this.cancelButtonEdit.Click += new System.EventHandler(this.cancelButtonEdit_Click);
            // 
            // addButtonEdit
            // 
            this.addButtonEdit.Location = new System.Drawing.Point(325, 328);
            this.addButtonEdit.Name = "addButtonEdit";
            this.addButtonEdit.Size = new System.Drawing.Size(106, 25);
            this.addButtonEdit.TabIndex = 18;
            this.addButtonEdit.Text = "Save";
            this.addButtonEdit.UseVisualStyleBackColor = true;
            this.addButtonEdit.Click += new System.EventHandler(this.saveButtonEdit_Click);
            // 
            // stockTextBoxEdit
            // 
            this.stockTextBoxEdit.Location = new System.Drawing.Point(325, 208);
            this.stockTextBoxEdit.Name = "stockTextBoxEdit";
            this.stockTextBoxEdit.Size = new System.Drawing.Size(228, 24);
            this.stockTextBoxEdit.TabIndex = 17;
            this.stockTextBoxEdit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.stockTextBoxEdit_KeyPress);
            // 
            // productPriceTextBoxEdit
            // 
            this.productPriceTextBoxEdit.Location = new System.Drawing.Point(325, 146);
            this.productPriceTextBoxEdit.Name = "productPriceTextBoxEdit";
            this.productPriceTextBoxEdit.Size = new System.Drawing.Size(228, 24);
            this.productPriceTextBoxEdit.TabIndex = 16;
            this.productPriceTextBoxEdit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.productPriceTextBoxEdit_KeyPress);
            // 
            // availabilityComboBoxEdit
            // 
            this.availabilityComboBoxEdit.FormattingEnabled = true;
            this.availabilityComboBoxEdit.Items.AddRange(new object[] {
            "Available",
            "Discontinued"});
            this.availabilityComboBoxEdit.Location = new System.Drawing.Point(325, 275);
            this.availabilityComboBoxEdit.Name = "availabilityComboBoxEdit";
            this.availabilityComboBoxEdit.Size = new System.Drawing.Size(228, 26);
            this.availabilityComboBoxEdit.TabIndex = 15;
            // 
            // productNameTextBoxEdit
            // 
            this.productNameTextBoxEdit.Location = new System.Drawing.Point(325, 70);
            this.productNameTextBoxEdit.Name = "productNameTextBoxEdit";
            this.productNameTextBoxEdit.Size = new System.Drawing.Size(228, 24);
            this.productNameTextBoxEdit.TabIndex = 14;
            // 
            // availabilityLabelEdit
            // 
            this.availabilityLabelEdit.AutoSize = true;
            this.availabilityLabelEdit.Location = new System.Drawing.Point(205, 275);
            this.availabilityLabelEdit.Name = "availabilityLabelEdit";
            this.availabilityLabelEdit.Size = new System.Drawing.Size(78, 18);
            this.availabilityLabelEdit.TabIndex = 13;
            this.availabilityLabelEdit.Text = "Availability:";
            // 
            // stockLabelEdit
            // 
            this.stockLabelEdit.AutoSize = true;
            this.stockLabelEdit.Location = new System.Drawing.Point(205, 208);
            this.stockLabelEdit.Name = "stockLabelEdit";
            this.stockLabelEdit.Size = new System.Drawing.Size(51, 18);
            this.stockLabelEdit.TabIndex = 12;
            this.stockLabelEdit.Text = "Stock:";
            // 
            // productPriceLabelEdit
            // 
            this.productPriceLabelEdit.AutoSize = true;
            this.productPriceLabelEdit.Location = new System.Drawing.Point(205, 146);
            this.productPriceLabelEdit.Name = "productPriceLabelEdit";
            this.productPriceLabelEdit.Size = new System.Drawing.Size(102, 18);
            this.productPriceLabelEdit.TabIndex = 11;
            this.productPriceLabelEdit.Text = "Product Price:";
            // 
            // productNameLabelEdit
            // 
            this.productNameLabelEdit.AutoSize = true;
            this.productNameLabelEdit.Location = new System.Drawing.Point(205, 73);
            this.productNameLabelEdit.Name = "productNameLabelEdit";
            this.productNameLabelEdit.Size = new System.Drawing.Size(108, 18);
            this.productNameLabelEdit.TabIndex = 10;
            this.productNameLabelEdit.Text = "Product Name:";
            // 
            // Maintainance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.maintainanceTabControl);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Maintainance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Maintainance";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.maintainanceTabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.searchGroupBox.ResumeLayout(false);
            this.searchGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel cashRegisterToolStripLabelMS;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel reportToolStripLabelMS;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.TabControl maintainanceTabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox productNameTextBoxAdd;
        private System.Windows.Forms.Label availabilityLabelAdd;
        private System.Windows.Forms.Label stockLabelAdd;
        private System.Windows.Forms.Label productPriceLabelAdd;
        private System.Windows.Forms.Label productNameLabelAdd;
        private System.Windows.Forms.Button cancelButtonAdd;
        private System.Windows.Forms.Button saveButtonAdd;
        private System.Windows.Forms.TextBox stockTextBoxAdd;
        private System.Windows.Forms.TextBox productPriceTextBoxAdd;
        private System.Windows.Forms.ComboBox availabilityComboBoxAdd;
        private System.Windows.Forms.Button cancelButtonEdit;
        private System.Windows.Forms.Button addButtonEdit;
        private System.Windows.Forms.TextBox stockTextBoxEdit;
        private System.Windows.Forms.TextBox productPriceTextBoxEdit;
        private System.Windows.Forms.ComboBox availabilityComboBoxEdit;
        private System.Windows.Forms.TextBox productNameTextBoxEdit;
        private System.Windows.Forms.Label availabilityLabelEdit;
        private System.Windows.Forms.Label stockLabelEdit;
        private System.Windows.Forms.Label productPriceLabelEdit;
        private System.Windows.Forms.Label productNameLabelEdit;
        private System.Windows.Forms.GroupBox searchGroupBox;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label productNameSearchLabel;
        private System.Windows.Forms.TextBox productIDSearchTextBox;
        private System.Windows.Forms.Label productIDSearchLabel;
    }
}
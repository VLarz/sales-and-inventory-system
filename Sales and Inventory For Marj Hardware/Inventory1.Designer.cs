namespace Sales_and_Inventory_For_Marj_Hardware
{
    partial class Inventory1
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inventory1));
            this.bunifuCustomLabel25 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.dgvProductList = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.barcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stocks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sellingPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ceiling = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reorder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.critical = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbFilter = new System.Windows.Forms.ComboBox();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bunifuCustomLabel10 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel9 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.lblProducts = new System.Windows.Forms.Label();
            this.bunifuCustomLabel8 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel7 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblCriticalLevel = new System.Windows.Forms.Label();
            this.lblReorderPoint = new System.Windows.Forms.Label();
            this.lblSafetyPoint = new System.Windows.Forms.Label();
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdbCritical = new System.Windows.Forms.RadioButton();
            this.rdbReorder = new System.Windows.Forms.RadioButton();
            this.rdbSafety = new System.Windows.Forms.RadioButton();
            this.rdbShowAll = new System.Windows.Forms.RadioButton();
            this.txtSearch = new Bunifu.Framework.UI.BunifuTextbox();
            this.pnlHeader = new Bunifu.Framework.UI.BunifuCards();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.bunifuCustomLabel11 = new Bunifu.Framework.UI.BunifuCustomLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductList)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuCustomLabel25
            // 
            this.bunifuCustomLabel25.AutoSize = true;
            this.bunifuCustomLabel25.Font = new System.Drawing.Font("Segoe UI", 20.25F);
            this.bunifuCustomLabel25.ForeColor = System.Drawing.Color.DimGray;
            this.bunifuCustomLabel25.Location = new System.Drawing.Point(13, 49);
            this.bunifuCustomLabel25.Name = "bunifuCustomLabel25";
            this.bunifuCustomLabel25.Size = new System.Drawing.Size(156, 37);
            this.bunifuCustomLabel25.TabIndex = 22;
            this.bunifuCustomLabel25.Text = "Product List";
            this.bunifuCustomLabel25.Click += new System.EventHandler(this.bunifuCustomLabel25_Click);
            // 
            // dgvProductList
            // 
            this.dgvProductList.AllowUserToAddRows = false;
            this.dgvProductList.AllowUserToDeleteRows = false;
            this.dgvProductList.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvProductList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProductList.BackgroundColor = System.Drawing.Color.White;
            this.dgvProductList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProductList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvProductList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(161)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProductList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProductList.ColumnHeadersHeight = 50;
            this.dgvProductList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.barcode,
            this.itemName,
            this.brand,
            this.category,
            this.description,
            this.supplier,
            this.stocks,
            this.sellingPrice,
            this.ceiling,
            this.reorder,
            this.critical});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProductList.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvProductList.DoubleBuffered = true;
            this.dgvProductList.EnableHeadersVisualStyles = false;
            this.dgvProductList.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(161)))), ((int)(((byte)(242)))));
            this.dgvProductList.HeaderForeColor = System.Drawing.Color.White;
            this.dgvProductList.Location = new System.Drawing.Point(20, 89);
            this.dgvProductList.Name = "dgvProductList";
            this.dgvProductList.ReadOnly = true;
            this.dgvProductList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvProductList.RowHeadersVisible = false;
            this.dgvProductList.RowTemplate.DividerHeight = 1;
            this.dgvProductList.RowTemplate.Height = 40;
            this.dgvProductList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductList.Size = new System.Drawing.Size(1060, 341);
            this.dgvProductList.TabIndex = 21;
            this.dgvProductList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductList_CellContentClick);
            // 
            // barcode
            // 
            this.barcode.DataPropertyName = "barcode";
            this.barcode.HeaderText = "Barcode";
            this.barcode.Name = "barcode";
            this.barcode.ReadOnly = true;
            this.barcode.Width = 128;
            // 
            // itemName
            // 
            this.itemName.DataPropertyName = "name";
            this.itemName.HeaderText = "Item Name";
            this.itemName.Name = "itemName";
            this.itemName.ReadOnly = true;
            this.itemName.Width = 128;
            // 
            // brand
            // 
            this.brand.DataPropertyName = "brand";
            this.brand.HeaderText = "Brand";
            this.brand.Name = "brand";
            this.brand.ReadOnly = true;
            this.brand.Width = 115;
            // 
            // category
            // 
            this.category.DataPropertyName = "category";
            this.category.HeaderText = "Category";
            this.category.Name = "category";
            this.category.ReadOnly = true;
            this.category.Width = 115;
            // 
            // description
            // 
            this.description.DataPropertyName = "description";
            this.description.HeaderText = "Description";
            this.description.Name = "description";
            this.description.ReadOnly = true;
            this.description.Width = 115;
            // 
            // supplier
            // 
            this.supplier.DataPropertyName = "supplier";
            this.supplier.HeaderText = "Supplier";
            this.supplier.Name = "supplier";
            this.supplier.ReadOnly = true;
            this.supplier.Width = 133;
            // 
            // stocks
            // 
            this.stocks.DataPropertyName = "stocks";
            this.stocks.HeaderText = "Stocks";
            this.stocks.Name = "stocks";
            this.stocks.ReadOnly = true;
            this.stocks.Width = 90;
            // 
            // sellingPrice
            // 
            this.sellingPrice.DataPropertyName = "selling_price";
            this.sellingPrice.HeaderText = "Selling Price";
            this.sellingPrice.Name = "sellingPrice";
            this.sellingPrice.ReadOnly = true;
            this.sellingPrice.Width = 140;
            // 
            // ceiling
            // 
            this.ceiling.DataPropertyName = "ceiling";
            this.ceiling.HeaderText = "Ceiling";
            this.ceiling.Name = "ceiling";
            this.ceiling.ReadOnly = true;
            this.ceiling.Width = 132;
            // 
            // reorder
            // 
            this.reorder.DataPropertyName = "reorder";
            this.reorder.HeaderText = "Reorder";
            this.reorder.Name = "reorder";
            this.reorder.ReadOnly = true;
            // 
            // critical
            // 
            this.critical.DataPropertyName = "critical";
            this.critical.HeaderText = "Critical";
            this.critical.Name = "critical";
            this.critical.ReadOnly = true;
            // 
            // cmbFilter
            // 
            this.cmbFilter.BackColor = System.Drawing.Color.White;
            this.cmbFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbFilter.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(23)))), ((int)(((byte)(26)))));
            this.cmbFilter.FormattingEnabled = true;
            this.cmbFilter.ItemHeight = 17;
            this.cmbFilter.Items.AddRange(new object[] {
            "Name",
            "Category",
            "Brand"});
            this.cmbFilter.Location = new System.Drawing.Point(892, 58);
            this.cmbFilter.Name = "cmbFilter";
            this.cmbFilter.Size = new System.Drawing.Size(189, 25);
            this.cmbFilter.TabIndex = 90;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this.dgvProductList;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.bunifuCustomLabel10);
            this.groupBox1.Controls.Add(this.bunifuCustomLabel9);
            this.groupBox1.Controls.Add(this.pictureBox5);
            this.groupBox1.Controls.Add(this.pictureBox4);
            this.groupBox1.Controls.Add(this.lblProducts);
            this.groupBox1.Controls.Add(this.bunifuCustomLabel8);
            this.groupBox1.Controls.Add(this.bunifuCustomLabel7);
            this.groupBox1.Controls.Add(this.lblCriticalLevel);
            this.groupBox1.Controls.Add(this.lblReorderPoint);
            this.groupBox1.Controls.Add(this.lblSafetyPoint);
            this.groupBox1.Controls.Add(this.bunifuCustomLabel6);
            this.groupBox1.Controls.Add(this.bunifuCustomLabel5);
            this.groupBox1.Controls.Add(this.bunifuCustomLabel4);
            this.groupBox1.Controls.Add(this.bunifuCustomLabel2);
            this.groupBox1.Controls.Add(this.bunifuCustomLabel3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(20, 436);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1060, 255);
            this.groupBox1.TabIndex = 91;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // bunifuCustomLabel10
            // 
            this.bunifuCustomLabel10.AutoSize = true;
            this.bunifuCustomLabel10.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(23)))), ((int)(((byte)(26)))));
            this.bunifuCustomLabel10.Location = new System.Drawing.Point(218, 205);
            this.bunifuCustomLabel10.Name = "bunifuCustomLabel10";
            this.bunifuCustomLabel10.Size = new System.Drawing.Size(157, 20);
            this.bunifuCustomLabel10.TabIndex = 214;
            this.bunifuCustomLabel10.Text = "Discontinued Product";
            // 
            // bunifuCustomLabel9
            // 
            this.bunifuCustomLabel9.AutoSize = true;
            this.bunifuCustomLabel9.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(23)))), ((int)(((byte)(26)))));
            this.bunifuCustomLabel9.Location = new System.Drawing.Point(35, 205);
            this.bunifuCustomLabel9.Name = "bunifuCustomLabel9";
            this.bunifuCustomLabel9.Size = new System.Drawing.Size(163, 20);
            this.bunifuCustomLabel9.TabIndex = 213;
            this.bunifuCustomLabel9.Text = "Add Defective Product";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::Sales_and_Inventory_For_Marj_Hardware.Properties.Resources.remove;
            this.pictureBox5.Location = new System.Drawing.Point(268, 151);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(50, 50);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 212;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Sales_and_Inventory_For_Marj_Hardware.Properties.Resources.Damaged_shipment_512;
            this.pictureBox4.Location = new System.Drawing.Point(84, 151);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(50, 50);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 211;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // lblProducts
            // 
            this.lblProducts.Font = new System.Drawing.Font("Segoe UI Semibold", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProducts.Location = new System.Drawing.Point(834, 151);
            this.lblProducts.Name = "lblProducts";
            this.lblProducts.Size = new System.Drawing.Size(190, 73);
            this.lblProducts.TabIndex = 210;
            this.lblProducts.Text = "0";
            this.lblProducts.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblProducts.Click += new System.EventHandler(this.label3_Click);
            // 
            // bunifuCustomLabel8
            // 
            this.bunifuCustomLabel8.AutoSize = true;
            this.bunifuCustomLabel8.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(23)))), ((int)(((byte)(26)))));
            this.bunifuCustomLabel8.Location = new System.Drawing.Point(827, 104);
            this.bunifuCustomLabel8.Name = "bunifuCustomLabel8";
            this.bunifuCustomLabel8.Size = new System.Drawing.Size(198, 37);
            this.bunifuCustomLabel8.TabIndex = 209;
            this.bunifuCustomLabel8.Text = "Product Items";
            // 
            // bunifuCustomLabel7
            // 
            this.bunifuCustomLabel7.AutoSize = true;
            this.bunifuCustomLabel7.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(23)))), ((int)(((byte)(26)))));
            this.bunifuCustomLabel7.Location = new System.Drawing.Point(867, 60);
            this.bunifuCustomLabel7.Name = "bunifuCustomLabel7";
            this.bunifuCustomLabel7.Size = new System.Drawing.Size(116, 37);
            this.bunifuCustomLabel7.TabIndex = 208;
            this.bunifuCustomLabel7.Text = "Total of";
            // 
            // lblCriticalLevel
            // 
            this.lblCriticalLevel.Font = new System.Drawing.Font("Segoe UI", 12.25F);
            this.lblCriticalLevel.Location = new System.Drawing.Point(667, 191);
            this.lblCriticalLevel.Name = "lblCriticalLevel";
            this.lblCriticalLevel.Size = new System.Drawing.Size(65, 33);
            this.lblCriticalLevel.TabIndex = 207;
            this.lblCriticalLevel.Text = "0";
            this.lblCriticalLevel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCriticalLevel.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblReorderPoint
            // 
            this.lblReorderPoint.Font = new System.Drawing.Font("Segoe UI", 12.25F);
            this.lblReorderPoint.Location = new System.Drawing.Point(667, 130);
            this.lblReorderPoint.Name = "lblReorderPoint";
            this.lblReorderPoint.Size = new System.Drawing.Size(65, 33);
            this.lblReorderPoint.TabIndex = 206;
            this.lblReorderPoint.Text = "0";
            this.lblReorderPoint.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSafetyPoint
            // 
            this.lblSafetyPoint.Font = new System.Drawing.Font("Segoe UI", 12.25F);
            this.lblSafetyPoint.Location = new System.Drawing.Point(667, 72);
            this.lblSafetyPoint.Name = "lblSafetyPoint";
            this.lblSafetyPoint.Size = new System.Drawing.Size(65, 33);
            this.lblSafetyPoint.TabIndex = 205;
            this.lblSafetyPoint.Text = "0";
            this.lblSafetyPoint.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSafetyPoint.Click += new System.EventHandler(this.lblsafetypoint_Click);
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.AutoSize = true;
            this.bunifuCustomLabel6.Font = new System.Drawing.Font("Segoe UI", 12.25F);
            this.bunifuCustomLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(23)))), ((int)(((byte)(26)))));
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(468, 201);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(105, 23);
            this.bunifuCustomLabel6.TabIndex = 98;
            this.bunifuCustomLabel6.Text = "Critical Level";
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Segoe UI", 12.25F);
            this.bunifuCustomLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(23)))), ((int)(((byte)(26)))));
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(468, 140);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(124, 23);
            this.bunifuCustomLabel5.TabIndex = 97;
            this.bunifuCustomLabel5.Text = "Re-Order Point";
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Segoe UI", 12.25F);
            this.bunifuCustomLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(23)))), ((int)(((byte)(26)))));
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(468, 78);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(100, 23);
            this.bunifuCustomLabel4.TabIndex = 96;
            this.bunifuCustomLabel4.Text = "Safety Point";
            this.bunifuCustomLabel4.Click += new System.EventHandler(this.bunifuCustomLabel4_Click);
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(23)))), ((int)(((byte)(26)))));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(665, 18);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(71, 32);
            this.bunifuCustomLabel2.TabIndex = 95;
            this.bunifuCustomLabel2.Text = "Total:";
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(23)))), ((int)(((byte)(26)))));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(467, 18);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(121, 32);
            this.bunifuCustomLabel3.TabIndex = 93;
            this.bunifuCustomLabel3.Text = "Summary:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.rdbCritical);
            this.groupBox2.Controls.Add(this.rdbReorder);
            this.groupBox2.Controls.Add(this.rdbSafety);
            this.groupBox2.Controls.Add(this.rdbShowAll);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.groupBox2.Location = new System.Drawing.Point(18, 18);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(383, 107);
            this.groupBox2.TabIndex = 92;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Check Quantites";
            // 
            // rdbCritical
            // 
            this.rdbCritical.AutoSize = true;
            this.rdbCritical.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.rdbCritical.Location = new System.Drawing.Point(262, 36);
            this.rdbCritical.Name = "rdbCritical";
            this.rdbCritical.Size = new System.Drawing.Size(88, 17);
            this.rdbCritical.TabIndex = 3;
            this.rdbCritical.TabStop = true;
            this.rdbCritical.Text = "Critical Level";
            this.rdbCritical.UseVisualStyleBackColor = true;
            this.rdbCritical.CheckedChanged += new System.EventHandler(this.rdbCritical_CheckedChanged);
            // 
            // rdbReorder
            // 
            this.rdbReorder.AutoSize = true;
            this.rdbReorder.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.rdbReorder.Location = new System.Drawing.Point(135, 36);
            this.rdbReorder.Name = "rdbReorder";
            this.rdbReorder.Size = new System.Drawing.Size(102, 17);
            this.rdbReorder.TabIndex = 2;
            this.rdbReorder.TabStop = true;
            this.rdbReorder.Text = "Re-Order Point";
            this.rdbReorder.UseVisualStyleBackColor = true;
            this.rdbReorder.CheckedChanged += new System.EventHandler(this.rdbReorder_CheckedChanged);
            // 
            // rdbSafety
            // 
            this.rdbSafety.AutoSize = true;
            this.rdbSafety.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.rdbSafety.Location = new System.Drawing.Point(24, 36);
            this.rdbSafety.Name = "rdbSafety";
            this.rdbSafety.Size = new System.Drawing.Size(86, 17);
            this.rdbSafety.TabIndex = 1;
            this.rdbSafety.TabStop = true;
            this.rdbSafety.Text = "Safety Point";
            this.rdbSafety.UseVisualStyleBackColor = true;
            this.rdbSafety.CheckedChanged += new System.EventHandler(this.rdbSafety_CheckedChanged);
            // 
            // rdbShowAll
            // 
            this.rdbShowAll.AutoSize = true;
            this.rdbShowAll.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.rdbShowAll.Location = new System.Drawing.Point(24, 70);
            this.rdbShowAll.Name = "rdbShowAll";
            this.rdbShowAll.Size = new System.Drawing.Size(70, 17);
            this.rdbShowAll.TabIndex = 0;
            this.rdbShowAll.TabStop = true;
            this.rdbShowAll.Text = "Show All";
            this.rdbShowAll.UseVisualStyleBackColor = true;
            this.rdbShowAll.CheckedChanged += new System.EventHandler(this.rdbShowAll_CheckedChanged);
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.txtSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtSearch.BackgroundImage")));
            this.txtSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(161)))), ((int)(((byte)(242)))));
            this.txtSearch.Icon = ((System.Drawing.Image)(resources.GetObject("txtSearch.Icon")));
            this.txtSearch.Location = new System.Drawing.Point(854, 48);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(210, 35);
            this.txtSearch.TabIndex = 89;
            this.txtSearch.text = "Search";
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.White;
            this.pnlHeader.BorderRadius = 0;
            this.pnlHeader.BottomSahddow = true;
            this.pnlHeader.color = System.Drawing.Color.White;
            this.pnlHeader.Controls.Add(this.bunifuSeparator1);
            this.pnlHeader.Controls.Add(this.bunifuCustomLabel11);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.LeftSahddow = true;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.RightSahddow = false;
            this.pnlHeader.ShadowDepth = 40;
            this.pnlHeader.Size = new System.Drawing.Size(1098, 34);
            this.pnlHeader.TabIndex = 92;
            this.pnlHeader.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlHeader_Paint);
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 2;
            this.bunifuSeparator1.Location = new System.Drawing.Point(159, -5);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(14, 31);
            this.bunifuSeparator1.TabIndex = 93;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = true;
            // 
            // bunifuCustomLabel11
            // 
            this.bunifuCustomLabel11.AutoSize = true;
            this.bunifuCustomLabel11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuCustomLabel11.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(23)))), ((int)(((byte)(26)))));
            this.bunifuCustomLabel11.Location = new System.Drawing.Point(18, 6);
            this.bunifuCustomLabel11.Name = "bunifuCustomLabel11";
            this.bunifuCustomLabel11.Size = new System.Drawing.Size(140, 20);
            this.bunifuCustomLabel11.TabIndex = 214;
            this.bunifuCustomLabel11.Text = "Add Defect Product";
            this.bunifuCustomLabel11.Click += new System.EventHandler(this.bunifuCustomLabel11_Click);
            // 
            // Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.cmbFilter);
            this.Controls.Add(this.bunifuCustomLabel25);
            this.Controls.Add(this.dgvProductList);
            this.Name = "Inventory";
            this.Size = new System.Drawing.Size(1098, 698);
            this.Load += new System.EventHandler(this.Inventory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductList)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel25;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvProductList;
        private System.Windows.Forms.DataGridViewTextBoxColumn barcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn brand;
        private System.Windows.Forms.DataGridViewTextBoxColumn category;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplier;
        private System.Windows.Forms.DataGridViewTextBoxColumn stocks;
        private System.Windows.Forms.DataGridViewTextBoxColumn sellingPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ceiling;
        private System.Windows.Forms.DataGridViewTextBoxColumn reorder;
        private System.Windows.Forms.DataGridViewTextBoxColumn critical;
        private Bunifu.Framework.UI.BunifuTextbox txtSearch;
        private System.Windows.Forms.ComboBox cmbFilter;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdbSafety;
        private System.Windows.Forms.RadioButton rdbShowAll;
        private System.Windows.Forms.RadioButton rdbCritical;
        private System.Windows.Forms.RadioButton rdbReorder;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private System.Windows.Forms.Label lblSafetyPoint;
        private System.Windows.Forms.Label lblProducts;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel8;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel7;
        private System.Windows.Forms.Label lblCriticalLevel;
        private System.Windows.Forms.Label lblReorderPoint;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel10;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel9;
        private Bunifu.Framework.UI.BunifuCards pnlHeader;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel11;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
    }
}

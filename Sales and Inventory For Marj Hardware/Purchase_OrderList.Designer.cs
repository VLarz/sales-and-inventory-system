namespace Sales_and_Inventory_For_Marj_Hardware
{
    partial class Purchase_OrderList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Purchase_OrderList));
            this.dgvOrderList = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sellingPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRemoveAll = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnPrintPDF = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnContinueOrdering = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnRemove = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnOrderNow = new Bunifu.Framework.UI.BunifuThinButton2();
            this.txtTotalItems = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtTotalPrice = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.txtSearch = new Bunifu.Framework.UI.BunifuTextbox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblSupplier = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblPurchaseNo = new Bunifu.Framework.UI.BunifuCustomLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderList)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvOrderList
            // 
            this.dgvOrderList.AllowUserToAddRows = false;
            this.dgvOrderList.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvOrderList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvOrderList.BackgroundColor = System.Drawing.Color.White;
            this.dgvOrderList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvOrderList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvOrderList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(161)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOrderList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvOrderList.ColumnHeadersHeight = 50;
            this.dgvOrderList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.supplierName,
            this.barcode,
            this.itemName,
            this.brand,
            this.category,
            this.description,
            this.costPrice,
            this.sellingPrice,
            this.quantity,
            this.totalPrice});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvOrderList.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvOrderList.DoubleBuffered = true;
            this.dgvOrderList.EnableHeadersVisualStyles = false;
            this.dgvOrderList.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(161)))), ((int)(((byte)(242)))));
            this.dgvOrderList.HeaderForeColor = System.Drawing.Color.White;
            this.dgvOrderList.Location = new System.Drawing.Point(18, 129);
            this.dgvOrderList.Name = "dgvOrderList";
            this.dgvOrderList.ReadOnly = true;
            this.dgvOrderList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvOrderList.RowHeadersVisible = false;
            this.dgvOrderList.RowTemplate.DividerHeight = 1;
            this.dgvOrderList.RowTemplate.Height = 40;
            this.dgvOrderList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrderList.Size = new System.Drawing.Size(913, 329);
            this.dgvOrderList.TabIndex = 64;
            this.dgvOrderList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrderList_CellClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // supplierName
            // 
            this.supplierName.DataPropertyName = "supplier";
            this.supplierName.HeaderText = "Supplier";
            this.supplierName.Name = "supplierName";
            this.supplierName.ReadOnly = true;
            this.supplierName.Width = 102;
            // 
            // barcode
            // 
            this.barcode.DataPropertyName = "barcode";
            this.barcode.HeaderText = "Barcode";
            this.barcode.Name = "barcode";
            this.barcode.ReadOnly = true;
            this.barcode.Width = 95;
            // 
            // itemName
            // 
            this.itemName.DataPropertyName = "name";
            this.itemName.HeaderText = "Item Name";
            this.itemName.Name = "itemName";
            this.itemName.ReadOnly = true;
            this.itemName.Width = 110;
            // 
            // brand
            // 
            this.brand.DataPropertyName = "brand";
            this.brand.HeaderText = "Brand";
            this.brand.Name = "brand";
            this.brand.ReadOnly = true;
            this.brand.Width = 101;
            // 
            // category
            // 
            this.category.DataPropertyName = "category";
            this.category.HeaderText = "Category";
            this.category.Name = "category";
            this.category.ReadOnly = true;
            this.category.Width = 102;
            // 
            // description
            // 
            this.description.DataPropertyName = "description";
            this.description.HeaderText = "Description";
            this.description.Name = "description";
            this.description.ReadOnly = true;
            this.description.Width = 101;
            // 
            // costPrice
            // 
            this.costPrice.DataPropertyName = "cost_price";
            this.costPrice.HeaderText = "Cost Price";
            this.costPrice.Name = "costPrice";
            this.costPrice.ReadOnly = true;
            this.costPrice.Width = 99;
            // 
            // sellingPrice
            // 
            this.sellingPrice.DataPropertyName = "selling_price";
            this.sellingPrice.HeaderText = "Selling Price";
            this.sellingPrice.Name = "sellingPrice";
            this.sellingPrice.ReadOnly = true;
            this.sellingPrice.Visible = false;
            // 
            // quantity
            // 
            this.quantity.DataPropertyName = "quantity";
            this.quantity.HeaderText = "Quantity";
            this.quantity.Name = "quantity";
            this.quantity.ReadOnly = true;
            this.quantity.Width = 95;
            // 
            // totalPrice
            // 
            this.totalPrice.DataPropertyName = "total_price";
            this.totalPrice.HeaderText = "Total Price";
            this.totalPrice.Name = "totalPrice";
            this.totalPrice.ReadOnly = true;
            this.totalPrice.Width = 108;
            // 
            // btnRemoveAll
            // 
            this.btnRemoveAll.ActiveBorderThickness = 1;
            this.btnRemoveAll.ActiveCornerRadius = 20;
            this.btnRemoveAll.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(161)))), ((int)(((byte)(242)))));
            this.btnRemoveAll.ActiveForecolor = System.Drawing.Color.White;
            this.btnRemoveAll.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(161)))), ((int)(((byte)(242)))));
            this.btnRemoveAll.BackColor = System.Drawing.Color.White;
            this.btnRemoveAll.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRemoveAll.BackgroundImage")));
            this.btnRemoveAll.ButtonText = "Remove All";
            this.btnRemoveAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemoveAll.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveAll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(213)))), ((int)(((byte)(165)))));
            this.btnRemoveAll.IdleBorderThickness = 1;
            this.btnRemoveAll.IdleCornerRadius = 20;
            this.btnRemoveAll.IdleFillColor = System.Drawing.Color.White;
            this.btnRemoveAll.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(161)))), ((int)(((byte)(242)))));
            this.btnRemoveAll.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(161)))), ((int)(((byte)(242)))));
            this.btnRemoveAll.Location = new System.Drawing.Point(356, 172);
            this.btnRemoveAll.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRemoveAll.Name = "btnRemoveAll";
            this.btnRemoveAll.Size = new System.Drawing.Size(230, 47);
            this.btnRemoveAll.TabIndex = 17;
            this.btnRemoveAll.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnRemoveAll.Click += new System.EventHandler(this.btnRemoveAll_Click);
            // 
            // btnPrintPDF
            // 
            this.btnPrintPDF.ActiveBorderThickness = 1;
            this.btnPrintPDF.ActiveCornerRadius = 20;
            this.btnPrintPDF.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(161)))), ((int)(((byte)(242)))));
            this.btnPrintPDF.ActiveForecolor = System.Drawing.Color.White;
            this.btnPrintPDF.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(161)))), ((int)(((byte)(242)))));
            this.btnPrintPDF.BackColor = System.Drawing.Color.White;
            this.btnPrintPDF.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPrintPDF.BackgroundImage")));
            this.btnPrintPDF.ButtonText = "Save as PDF";
            this.btnPrintPDF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrintPDF.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintPDF.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(213)))), ((int)(((byte)(165)))));
            this.btnPrintPDF.IdleBorderThickness = 1;
            this.btnPrintPDF.IdleCornerRadius = 20;
            this.btnPrintPDF.IdleFillColor = System.Drawing.Color.White;
            this.btnPrintPDF.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(161)))), ((int)(((byte)(242)))));
            this.btnPrintPDF.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(161)))), ((int)(((byte)(242)))));
            this.btnPrintPDF.Location = new System.Drawing.Point(42, 115);
            this.btnPrintPDF.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPrintPDF.Name = "btnPrintPDF";
            this.btnPrintPDF.Size = new System.Drawing.Size(230, 47);
            this.btnPrintPDF.TabIndex = 15;
            this.btnPrintPDF.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnPrintPDF.Click += new System.EventHandler(this.btnPrintPDF_Click);
            // 
            // btnContinueOrdering
            // 
            this.btnContinueOrdering.AccessibleDescription = "";
            this.btnContinueOrdering.ActiveBorderThickness = 1;
            this.btnContinueOrdering.ActiveCornerRadius = 20;
            this.btnContinueOrdering.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(161)))), ((int)(((byte)(242)))));
            this.btnContinueOrdering.ActiveForecolor = System.Drawing.Color.White;
            this.btnContinueOrdering.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(161)))), ((int)(((byte)(242)))));
            this.btnContinueOrdering.BackColor = System.Drawing.Color.White;
            this.btnContinueOrdering.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnContinueOrdering.BackgroundImage")));
            this.btnContinueOrdering.ButtonText = "Continue Ordering";
            this.btnContinueOrdering.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnContinueOrdering.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContinueOrdering.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(213)))), ((int)(((byte)(165)))));
            this.btnContinueOrdering.IdleBorderThickness = 1;
            this.btnContinueOrdering.IdleCornerRadius = 20;
            this.btnContinueOrdering.IdleFillColor = System.Drawing.Color.White;
            this.btnContinueOrdering.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(161)))), ((int)(((byte)(242)))));
            this.btnContinueOrdering.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(161)))), ((int)(((byte)(242)))));
            this.btnContinueOrdering.Location = new System.Drawing.Point(42, 172);
            this.btnContinueOrdering.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnContinueOrdering.Name = "btnContinueOrdering";
            this.btnContinueOrdering.Size = new System.Drawing.Size(230, 47);
            this.btnContinueOrdering.TabIndex = 14;
            this.btnContinueOrdering.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnContinueOrdering.Click += new System.EventHandler(this.btnContinueOrdering_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.ActiveBorderThickness = 1;
            this.btnRemove.ActiveCornerRadius = 20;
            this.btnRemove.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(161)))), ((int)(((byte)(242)))));
            this.btnRemove.ActiveForecolor = System.Drawing.Color.White;
            this.btnRemove.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(161)))), ((int)(((byte)(242)))));
            this.btnRemove.BackColor = System.Drawing.Color.White;
            this.btnRemove.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRemove.BackgroundImage")));
            this.btnRemove.ButtonText = "Remove ";
            this.btnRemove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemove.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(213)))), ((int)(((byte)(165)))));
            this.btnRemove.IdleBorderThickness = 1;
            this.btnRemove.IdleCornerRadius = 20;
            this.btnRemove.IdleFillColor = System.Drawing.Color.White;
            this.btnRemove.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(161)))), ((int)(((byte)(242)))));
            this.btnRemove.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(161)))), ((int)(((byte)(242)))));
            this.btnRemove.Location = new System.Drawing.Point(356, 115);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(230, 47);
            this.btnRemove.TabIndex = 13;
            this.btnRemove.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnOrderNow
            // 
            this.btnOrderNow.ActiveBorderThickness = 1;
            this.btnOrderNow.ActiveCornerRadius = 20;
            this.btnOrderNow.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(161)))), ((int)(((byte)(242)))));
            this.btnOrderNow.ActiveForecolor = System.Drawing.Color.White;
            this.btnOrderNow.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(161)))), ((int)(((byte)(242)))));
            this.btnOrderNow.BackColor = System.Drawing.Color.White;
            this.btnOrderNow.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnOrderNow.BackgroundImage")));
            this.btnOrderNow.ButtonText = "Order and Send ";
            this.btnOrderNow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOrderNow.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrderNow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(213)))), ((int)(((byte)(165)))));
            this.btnOrderNow.IdleBorderThickness = 1;
            this.btnOrderNow.IdleCornerRadius = 20;
            this.btnOrderNow.IdleFillColor = System.Drawing.Color.White;
            this.btnOrderNow.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(161)))), ((int)(((byte)(242)))));
            this.btnOrderNow.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(161)))), ((int)(((byte)(242)))));
            this.btnOrderNow.Location = new System.Drawing.Point(135, 58);
            this.btnOrderNow.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnOrderNow.Name = "btnOrderNow";
            this.btnOrderNow.Size = new System.Drawing.Size(370, 47);
            this.btnOrderNow.TabIndex = 11;
            this.btnOrderNow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnOrderNow.Click += new System.EventHandler(this.btnOrderNow_Click);
            // 
            // txtTotalItems
            // 
            this.txtTotalItems.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(213)))), ((int)(((byte)(165)))));
            this.txtTotalItems.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(236)))), ((int)(((byte)(240)))));
            this.txtTotalItems.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(213)))), ((int)(((byte)(165)))));
            this.txtTotalItems.BorderThickness = 2;
            this.txtTotalItems.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTotalItems.Enabled = false;
            this.txtTotalItems.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtTotalItems.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(23)))), ((int)(((byte)(26)))));
            this.txtTotalItems.isPassword = false;
            this.txtTotalItems.Location = new System.Drawing.Point(648, 162);
            this.txtTotalItems.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTotalItems.Name = "txtTotalItems";
            this.txtTotalItems.Size = new System.Drawing.Size(230, 35);
            this.txtTotalItems.TabIndex = 5;
            this.txtTotalItems.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(23)))), ((int)(((byte)(26)))));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(723, 137);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(83, 21);
            this.bunifuCustomLabel3.TabIndex = 3;
            this.bunifuCustomLabel3.Text = "Total Item";
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(213)))), ((int)(((byte)(165)))));
            this.txtTotalPrice.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(236)))), ((int)(((byte)(240)))));
            this.txtTotalPrice.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(213)))), ((int)(((byte)(165)))));
            this.txtTotalPrice.BorderThickness = 2;
            this.txtTotalPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTotalPrice.Enabled = false;
            this.txtTotalPrice.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtTotalPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(23)))), ((int)(((byte)(26)))));
            this.txtTotalPrice.isPassword = false;
            this.txtTotalPrice.Location = new System.Drawing.Point(648, 78);
            this.txtTotalPrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.Size = new System.Drawing.Size(230, 35);
            this.txtTotalPrice.TabIndex = 6;
            this.txtTotalPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTotalPrice.OnValueChanged += new System.EventHandler(this.txtTotalPrice_OnValueChanged);
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.bunifuCustomLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(23)))), ((int)(((byte)(26)))));
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(722, 53);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(85, 21);
            this.bunifuCustomLabel4.TabIndex = 4;
            this.bunifuCustomLabel4.Text = "Total Price";
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this.dgvOrderList;
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.White;
            this.txtSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtSearch.BackgroundImage")));
            this.txtSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(161)))), ((int)(((byte)(242)))));
            this.txtSearch.Icon = ((System.Drawing.Image)(resources.GetObject("txtSearch.Icon")));
            this.txtSearch.Location = new System.Drawing.Point(706, 88);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(225, 35);
            this.txtSearch.TabIndex = 61;
            this.txtSearch.text = "Search";
            this.txtSearch.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtTotalPrice);
            this.groupBox2.Controls.Add(this.bunifuCustomLabel4);
            this.groupBox2.Controls.Add(this.bunifuCustomLabel3);
            this.groupBox2.Controls.Add(this.txtTotalItems);
            this.groupBox2.Controls.Add(this.btnRemoveAll);
            this.groupBox2.Controls.Add(this.btnOrderNow);
            this.groupBox2.Controls.Add(this.btnPrintPDF);
            this.groupBox2.Controls.Add(this.btnRemove);
            this.groupBox2.Controls.Add(this.btnContinueOrdering);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox2.Location = new System.Drawing.Point(18, 464);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(915, 249);
            this.groupBox2.TabIndex = 96;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Order Options";
            // 
            // lblSupplier
            // 
            this.lblSupplier.AutoSize = true;
            this.lblSupplier.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lblSupplier.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(23)))), ((int)(((byte)(26)))));
            this.lblSupplier.Location = new System.Drawing.Point(25, 102);
            this.lblSupplier.Name = "lblSupplier";
            this.lblSupplier.Size = new System.Drawing.Size(85, 21);
            this.lblSupplier.TabIndex = 97;
            this.lblSupplier.Text = "Total Price";
            this.lblSupplier.Visible = false;
            // 
            // lblPurchaseNo
            // 
            this.lblPurchaseNo.AutoSize = true;
            this.lblPurchaseNo.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lblPurchaseNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(23)))), ((int)(((byte)(26)))));
            this.lblPurchaseNo.Location = new System.Drawing.Point(149, 102);
            this.lblPurchaseNo.Name = "lblPurchaseNo";
            this.lblPurchaseNo.Size = new System.Drawing.Size(85, 21);
            this.lblPurchaseNo.TabIndex = 98;
            this.lblPurchaseNo.Text = "Total Price";
            this.lblPurchaseNo.Visible = false;
            // 
            // Purchase_OrderList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(950, 727);
            this.Controls.Add(this.lblPurchaseNo);
            this.Controls.Add(this.lblSupplier);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgvOrderList);
            this.Controls.Add(this.txtSearch);
            this.Name = "Purchase_OrderList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Purchase Order List";
            this.Load += new System.EventHandler(this.Purchase_OrderList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderList)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvOrderList;
        private Bunifu.Framework.UI.BunifuTextbox txtSearch;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtTotalItems;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtTotalPrice;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuThinButton2 btnOrderNow;
        private Bunifu.Framework.UI.BunifuThinButton2 btnContinueOrdering;
        private Bunifu.Framework.UI.BunifuThinButton2 btnRemove;
        private Bunifu.Framework.UI.BunifuThinButton2 btnPrintPDF;
        private Bunifu.Framework.UI.BunifuThinButton2 btnRemoveAll;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierName;
        private System.Windows.Forms.DataGridViewTextBoxColumn barcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn brand;
        private System.Windows.Forms.DataGridViewTextBoxColumn category;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private System.Windows.Forms.DataGridViewTextBoxColumn costPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn sellingPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPrice;
        private Bunifu.Framework.UI.BunifuCustomLabel lblSupplier;
        private Bunifu.Framework.UI.BunifuCustomLabel lblPurchaseNo;
    }
}
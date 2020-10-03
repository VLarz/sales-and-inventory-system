namespace Sales_and_Inventory_For_Marj_Hardware
{
    partial class POS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(POS));
            this.dgvCartList = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.barcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtCategory = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuCustomLabel9 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtBrand = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtQuantity = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuCustomLabel12 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtItemName = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtStocks = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuCustomLabel14 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtSellingPrice = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuCustomLabel13 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtDescription = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuCustomLabel11 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel8 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.llbUsername = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel7 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblName = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblChange = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblTotalItem = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblTotalPrice = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtCash = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuCustomLabel17 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel16 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel15 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel20 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnVoid = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnChange = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnPay = new Bunifu.Framework.UI.BunifuThinButton2();
            this.txtBarcode = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnViewPreviousCustomer = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnHoldNext = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.lstReceipt = new System.Windows.Forms.ListBox();
            this.pnlCustomerName = new System.Windows.Forms.Panel();
            this.btnClose = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnAdd = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuCustomLabel21 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtCustomerName = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.lblPOSNo = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel18 = new Bunifu.Framework.UI.BunifuCustomLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCartList)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.pnlCustomerName.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvCartList
            // 
            this.dgvCartList.AllowUserToAddRows = false;
            this.dgvCartList.AllowUserToDeleteRows = false;
            this.dgvCartList.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvCartList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCartList.BackgroundColor = System.Drawing.Color.White;
            this.dgvCartList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCartList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvCartList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(161)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCartList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCartList.ColumnHeadersHeight = 50;
            this.dgvCartList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.barcode,
            this.itemName,
            this.description,
            this.costPrice,
            this.quantity,
            this.totalPrice});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCartList.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCartList.DoubleBuffered = true;
            this.dgvCartList.EnableHeadersVisualStyles = false;
            this.dgvCartList.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(161)))), ((int)(((byte)(242)))));
            this.dgvCartList.HeaderForeColor = System.Drawing.Color.White;
            this.dgvCartList.Location = new System.Drawing.Point(391, 93);
            this.dgvCartList.Name = "dgvCartList";
            this.dgvCartList.ReadOnly = true;
            this.dgvCartList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvCartList.RowHeadersVisible = false;
            this.dgvCartList.RowTemplate.DividerHeight = 1;
            this.dgvCartList.RowTemplate.Height = 40;
            this.dgvCartList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCartList.Size = new System.Drawing.Size(951, 436);
            this.dgvCartList.TabIndex = 70;
            this.dgvCartList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCartList_CellClick);
            // 
            // barcode
            // 
            this.barcode.DataPropertyName = "barcode";
            this.barcode.HeaderText = "Barcode";
            this.barcode.Name = "barcode";
            this.barcode.ReadOnly = true;
            this.barcode.Visible = false;
            // 
            // itemName
            // 
            this.itemName.DataPropertyName = "name";
            this.itemName.HeaderText = "Item Name";
            this.itemName.Name = "itemName";
            this.itemName.ReadOnly = true;
            this.itemName.Width = 250;
            // 
            // description
            // 
            this.description.DataPropertyName = "description";
            this.description.HeaderText = "Description";
            this.description.Name = "description";
            this.description.ReadOnly = true;
            this.description.Width = 250;
            // 
            // costPrice
            // 
            this.costPrice.DataPropertyName = "price";
            this.costPrice.HeaderText = "Price";
            this.costPrice.Name = "costPrice";
            this.costPrice.ReadOnly = true;
            this.costPrice.Width = 146;
            // 
            // quantity
            // 
            this.quantity.DataPropertyName = "quantity";
            this.quantity.HeaderText = "Quantity";
            this.quantity.Name = "quantity";
            this.quantity.ReadOnly = true;
            this.quantity.Width = 145;
            // 
            // totalPrice
            // 
            this.totalPrice.DataPropertyName = "total_price";
            this.totalPrice.HeaderText = "Total ";
            this.totalPrice.Name = "totalPrice";
            this.totalPrice.ReadOnly = true;
            this.totalPrice.Width = 158;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtCategory);
            this.groupBox2.Controls.Add(this.bunifuCustomLabel9);
            this.groupBox2.Controls.Add(this.txtBrand);
            this.groupBox2.Controls.Add(this.bunifuCustomLabel6);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.txtItemName);
            this.groupBox2.Controls.Add(this.txtStocks);
            this.groupBox2.Controls.Add(this.bunifuCustomLabel14);
            this.groupBox2.Controls.Add(this.txtSellingPrice);
            this.groupBox2.Controls.Add(this.bunifuCustomLabel13);
            this.groupBox2.Controls.Add(this.txtDescription);
            this.groupBox2.Controls.Add(this.bunifuCustomLabel11);
            this.groupBox2.Controls.Add(this.bunifuCustomLabel8);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(23)))), ((int)(((byte)(26)))));
            this.groupBox2.Location = new System.Drawing.Point(25, 183);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(344, 332);
            this.groupBox2.TabIndex = 71;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Product Information";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // txtCategory
            // 
            this.txtCategory.BackColor = System.Drawing.Color.White;
            this.txtCategory.BorderColorFocused = System.Drawing.Color.White;
            this.txtCategory.BorderColorIdle = System.Drawing.Color.White;
            this.txtCategory.BorderColorMouseHover = System.Drawing.Color.White;
            this.txtCategory.BorderThickness = 2;
            this.txtCategory.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCategory.Enabled = false;
            this.txtCategory.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(23)))), ((int)(((byte)(26)))));
            this.txtCategory.isPassword = false;
            this.txtCategory.Location = new System.Drawing.Point(123, 177);
            this.txtCategory.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(191, 24);
            this.txtCategory.TabIndex = 82;
            this.txtCategory.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel9
            // 
            this.bunifuCustomLabel9.AutoSize = true;
            this.bunifuCustomLabel9.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(23)))), ((int)(((byte)(26)))));
            this.bunifuCustomLabel9.Location = new System.Drawing.Point(17, 184);
            this.bunifuCustomLabel9.Name = "bunifuCustomLabel9";
            this.bunifuCustomLabel9.Size = new System.Drawing.Size(64, 17);
            this.bunifuCustomLabel9.TabIndex = 81;
            this.bunifuCustomLabel9.Text = "Category";
            // 
            // txtBrand
            // 
            this.txtBrand.BackColor = System.Drawing.Color.White;
            this.txtBrand.BorderColorFocused = System.Drawing.Color.White;
            this.txtBrand.BorderColorIdle = System.Drawing.Color.White;
            this.txtBrand.BorderColorMouseHover = System.Drawing.Color.White;
            this.txtBrand.BorderThickness = 2;
            this.txtBrand.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBrand.Enabled = false;
            this.txtBrand.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtBrand.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(23)))), ((int)(((byte)(26)))));
            this.txtBrand.isPassword = false;
            this.txtBrand.Location = new System.Drawing.Point(123, 145);
            this.txtBrand.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBrand.Name = "txtBrand";
            this.txtBrand.Size = new System.Drawing.Size(191, 24);
            this.txtBrand.TabIndex = 80;
            this.txtBrand.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.AutoSize = true;
            this.bunifuCustomLabel6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(23)))), ((int)(((byte)(26)))));
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(17, 152);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(44, 17);
            this.bunifuCustomLabel6.TabIndex = 79;
            this.bunifuCustomLabel6.Text = "Brand";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtQuantity);
            this.groupBox1.Controls.Add(this.bunifuCustomLabel12);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(11, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(318, 65);
            this.groupBox1.TabIndex = 75;
            this.groupBox1.TabStop = false;
            // 
            // txtQuantity
            // 
            this.txtQuantity.BackColor = System.Drawing.Color.White;
            this.txtQuantity.BorderColorFocused = System.Drawing.Color.Black;
            this.txtQuantity.BorderColorIdle = System.Drawing.Color.Black;
            this.txtQuantity.BorderColorMouseHover = System.Drawing.Color.Black;
            this.txtQuantity.BorderThickness = 1;
            this.txtQuantity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtQuantity.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.txtQuantity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(23)))), ((int)(((byte)(26)))));
            this.txtQuantity.isPassword = false;
            this.txtQuantity.Location = new System.Drawing.Point(112, 17);
            this.txtQuantity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(191, 38);
            this.txtQuantity.TabIndex = 70;
            this.txtQuantity.Text = "1";
            this.txtQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtQuantity.OnValueChanged += new System.EventHandler(this.txtQuantity_OnValueChanged);
            this.txtQuantity.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtQuantity_KeyDown);
            this.txtQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuantity_KeyPress);
            // 
            // bunifuCustomLabel12
            // 
            this.bunifuCustomLabel12.AutoSize = true;
            this.bunifuCustomLabel12.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.bunifuCustomLabel12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(23)))), ((int)(((byte)(26)))));
            this.bunifuCustomLabel12.Location = new System.Drawing.Point(11, 27);
            this.bunifuCustomLabel12.Name = "bunifuCustomLabel12";
            this.bunifuCustomLabel12.Size = new System.Drawing.Size(87, 25);
            this.bunifuCustomLabel12.TabIndex = 71;
            this.bunifuCustomLabel12.Text = "Quantity";
            // 
            // txtItemName
            // 
            this.txtItemName.BackColor = System.Drawing.Color.White;
            this.txtItemName.BorderColorFocused = System.Drawing.Color.White;
            this.txtItemName.BorderColorIdle = System.Drawing.Color.White;
            this.txtItemName.BorderColorMouseHover = System.Drawing.Color.White;
            this.txtItemName.BorderThickness = 2;
            this.txtItemName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtItemName.Enabled = false;
            this.txtItemName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtItemName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(23)))), ((int)(((byte)(26)))));
            this.txtItemName.isPassword = false;
            this.txtItemName.Location = new System.Drawing.Point(123, 113);
            this.txtItemName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(191, 24);
            this.txtItemName.TabIndex = 78;
            this.txtItemName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtStocks
            // 
            this.txtStocks.BackColor = System.Drawing.Color.White;
            this.txtStocks.BorderColorFocused = System.Drawing.Color.White;
            this.txtStocks.BorderColorIdle = System.Drawing.Color.White;
            this.txtStocks.BorderColorMouseHover = System.Drawing.Color.White;
            this.txtStocks.BorderThickness = 2;
            this.txtStocks.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtStocks.Enabled = false;
            this.txtStocks.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtStocks.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(23)))), ((int)(((byte)(26)))));
            this.txtStocks.isPassword = false;
            this.txtStocks.Location = new System.Drawing.Point(123, 273);
            this.txtStocks.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtStocks.Name = "txtStocks";
            this.txtStocks.Size = new System.Drawing.Size(191, 24);
            this.txtStocks.TabIndex = 72;
            this.txtStocks.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel14
            // 
            this.bunifuCustomLabel14.AutoSize = true;
            this.bunifuCustomLabel14.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(23)))), ((int)(((byte)(26)))));
            this.bunifuCustomLabel14.Location = new System.Drawing.Point(17, 280);
            this.bunifuCustomLabel14.Name = "bunifuCustomLabel14";
            this.bunifuCustomLabel14.Size = new System.Drawing.Size(47, 17);
            this.bunifuCustomLabel14.TabIndex = 73;
            this.bunifuCustomLabel14.Text = "Stocks";
            // 
            // txtSellingPrice
            // 
            this.txtSellingPrice.BackColor = System.Drawing.Color.White;
            this.txtSellingPrice.BorderColorFocused = System.Drawing.Color.White;
            this.txtSellingPrice.BorderColorIdle = System.Drawing.Color.White;
            this.txtSellingPrice.BorderColorMouseHover = System.Drawing.Color.White;
            this.txtSellingPrice.BorderThickness = 2;
            this.txtSellingPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSellingPrice.Enabled = false;
            this.txtSellingPrice.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSellingPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(23)))), ((int)(((byte)(26)))));
            this.txtSellingPrice.isPassword = false;
            this.txtSellingPrice.Location = new System.Drawing.Point(123, 241);
            this.txtSellingPrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSellingPrice.Name = "txtSellingPrice";
            this.txtSellingPrice.Size = new System.Drawing.Size(191, 24);
            this.txtSellingPrice.TabIndex = 68;
            this.txtSellingPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel13
            // 
            this.bunifuCustomLabel13.AutoSize = true;
            this.bunifuCustomLabel13.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(23)))), ((int)(((byte)(26)))));
            this.bunifuCustomLabel13.Location = new System.Drawing.Point(17, 248);
            this.bunifuCustomLabel13.Name = "bunifuCustomLabel13";
            this.bunifuCustomLabel13.Size = new System.Drawing.Size(37, 17);
            this.bunifuCustomLabel13.TabIndex = 69;
            this.bunifuCustomLabel13.Text = "Price";
            // 
            // txtDescription
            // 
            this.txtDescription.BackColor = System.Drawing.Color.White;
            this.txtDescription.BorderColorFocused = System.Drawing.Color.White;
            this.txtDescription.BorderColorIdle = System.Drawing.Color.White;
            this.txtDescription.BorderColorMouseHover = System.Drawing.Color.White;
            this.txtDescription.BorderThickness = 2;
            this.txtDescription.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDescription.Enabled = false;
            this.txtDescription.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(23)))), ((int)(((byte)(26)))));
            this.txtDescription.isPassword = false;
            this.txtDescription.Location = new System.Drawing.Point(123, 209);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(191, 24);
            this.txtDescription.TabIndex = 66;
            this.txtDescription.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel11
            // 
            this.bunifuCustomLabel11.AutoSize = true;
            this.bunifuCustomLabel11.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(23)))), ((int)(((byte)(26)))));
            this.bunifuCustomLabel11.Location = new System.Drawing.Point(17, 216);
            this.bunifuCustomLabel11.Name = "bunifuCustomLabel11";
            this.bunifuCustomLabel11.Size = new System.Drawing.Size(76, 17);
            this.bunifuCustomLabel11.TabIndex = 67;
            this.bunifuCustomLabel11.Text = "Description";
            // 
            // bunifuCustomLabel8
            // 
            this.bunifuCustomLabel8.AutoSize = true;
            this.bunifuCustomLabel8.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(23)))), ((int)(((byte)(26)))));
            this.bunifuCustomLabel8.Location = new System.Drawing.Point(17, 120);
            this.bunifuCustomLabel8.Name = "bunifuCustomLabel8";
            this.bunifuCustomLabel8.Size = new System.Drawing.Size(76, 17);
            this.bunifuCustomLabel8.TabIndex = 61;
            this.bunifuCustomLabel8.Text = "Item Name";
            // 
            // llbUsername
            // 
            this.llbUsername.AutoSize = true;
            this.llbUsername.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llbUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(23)))), ((int)(((byte)(26)))));
            this.llbUsername.Location = new System.Drawing.Point(127, 39);
            this.llbUsername.Name = "llbUsername";
            this.llbUsername.Size = new System.Drawing.Size(50, 17);
            this.llbUsername.TabIndex = 80;
            this.llbUsername.Text = "cashier";
            // 
            // bunifuCustomLabel7
            // 
            this.bunifuCustomLabel7.AutoSize = true;
            this.bunifuCustomLabel7.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(23)))), ((int)(((byte)(26)))));
            this.bunifuCustomLabel7.Location = new System.Drawing.Point(49, 39);
            this.bunifuCustomLabel7.Name = "bunifuCustomLabel7";
            this.bunifuCustomLabel7.Size = new System.Drawing.Size(72, 17);
            this.bunifuCustomLabel7.TabIndex = 79;
            this.bunifuCustomLabel7.Text = "Username:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(23)))), ((int)(((byte)(26)))));
            this.lblName.Location = new System.Drawing.Point(127, 18);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(32, 17);
            this.lblName.TabIndex = 78;
            this.lblName.Text = "Lars";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(23)))), ((int)(((byte)(26)))));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(47, 18);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(71, 17);
            this.bunifuCustomLabel2.TabIndex = 77;
            this.bunifuCustomLabel2.Text = "Welcome, ";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.bunifuCustomLabel5);
            this.groupBox4.Controls.Add(this.lblChange);
            this.groupBox4.Controls.Add(this.lblTotalItem);
            this.groupBox4.Controls.Add(this.lblTotalPrice);
            this.groupBox4.Controls.Add(this.bunifuCustomLabel4);
            this.groupBox4.Controls.Add(this.bunifuCustomLabel3);
            this.groupBox4.Controls.Add(this.txtCash);
            this.groupBox4.Controls.Add(this.bunifuCustomLabel17);
            this.groupBox4.Controls.Add(this.bunifuCustomLabel16);
            this.groupBox4.Controls.Add(this.bunifuCustomLabel15);
            this.groupBox4.Controls.Add(this.bunifuCustomLabel20);
            this.groupBox4.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.groupBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(23)))), ((int)(((byte)(26)))));
            this.groupBox4.Location = new System.Drawing.Point(391, 521);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(635, 227);
            this.groupBox4.TabIndex = 84;
            this.groupBox4.TabStop = false;
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.BackColor = System.Drawing.Color.White;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Segoe UI", 26F);
            this.bunifuCustomLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(23)))), ((int)(((byte)(26)))));
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(338, 156);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(38, 40);
            this.bunifuCustomLabel5.TabIndex = 88;
            this.bunifuCustomLabel5.Text = "₱";
            // 
            // lblChange
            // 
            this.lblChange.BackColor = System.Drawing.Color.White;
            this.lblChange.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.lblChange.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(23)))), ((int)(((byte)(26)))));
            this.lblChange.Location = new System.Drawing.Point(336, 159);
            this.lblChange.Name = "lblChange";
            this.lblChange.Size = new System.Drawing.Size(277, 45);
            this.lblChange.TabIndex = 87;
            this.lblChange.Text = "0";
            this.lblChange.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotalItem
            // 
            this.lblTotalItem.BackColor = System.Drawing.Color.White;
            this.lblTotalItem.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.lblTotalItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(23)))), ((int)(((byte)(26)))));
            this.lblTotalItem.Location = new System.Drawing.Point(22, 159);
            this.lblTotalItem.Name = "lblTotalItem";
            this.lblTotalItem.Size = new System.Drawing.Size(264, 45);
            this.lblTotalItem.TabIndex = 86;
            this.lblTotalItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.BackColor = System.Drawing.Color.White;
            this.lblTotalPrice.Font = new System.Drawing.Font("Segoe UI", 28F);
            this.lblTotalPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(23)))), ((int)(((byte)(26)))));
            this.lblTotalPrice.Location = new System.Drawing.Point(56, 71);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(230, 53);
            this.lblTotalPrice.TabIndex = 85;
            this.lblTotalPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.BackColor = System.Drawing.Color.White;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Segoe UI", 26F);
            this.bunifuCustomLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(23)))), ((int)(((byte)(26)))));
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(341, 70);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(38, 40);
            this.bunifuCustomLabel4.TabIndex = 84;
            this.bunifuCustomLabel4.Text = "₱";
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.BackColor = System.Drawing.Color.White;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Segoe UI", 26F);
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(23)))), ((int)(((byte)(26)))));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(23, 71);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(38, 53);
            this.bunifuCustomLabel3.TabIndex = 83;
            this.bunifuCustomLabel3.Text = "₱";
            // 
            // txtCash
            // 
            this.txtCash.BackColor = System.Drawing.Color.White;
            this.txtCash.BorderColorFocused = System.Drawing.Color.Black;
            this.txtCash.BorderColorIdle = System.Drawing.Color.Black;
            this.txtCash.BorderColorMouseHover = System.Drawing.Color.Black;
            this.txtCash.BorderThickness = 1;
            this.txtCash.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCash.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.txtCash.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(23)))), ((int)(((byte)(26)))));
            this.txtCash.isPassword = false;
            this.txtCash.Location = new System.Drawing.Point(338, 68);
            this.txtCash.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCash.Name = "txtCash";
            this.txtCash.Size = new System.Drawing.Size(275, 53);
            this.txtCash.TabIndex = 82;
            this.txtCash.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCash.OnValueChanged += new System.EventHandler(this.txtCash_OnValueChanged);
            this.txtCash.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCash_KeyPress);
            // 
            // bunifuCustomLabel17
            // 
            this.bunifuCustomLabel17.AutoSize = true;
            this.bunifuCustomLabel17.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.bunifuCustomLabel17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(23)))), ((int)(((byte)(26)))));
            this.bunifuCustomLabel17.Location = new System.Drawing.Point(18, 132);
            this.bunifuCustomLabel17.Name = "bunifuCustomLabel17";
            this.bunifuCustomLabel17.Size = new System.Drawing.Size(87, 21);
            this.bunifuCustomLabel17.TabIndex = 79;
            this.bunifuCustomLabel17.Text = "Total Item:";
            // 
            // bunifuCustomLabel16
            // 
            this.bunifuCustomLabel16.AutoSize = true;
            this.bunifuCustomLabel16.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.bunifuCustomLabel16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(23)))), ((int)(((byte)(26)))));
            this.bunifuCustomLabel16.Location = new System.Drawing.Point(334, 132);
            this.bunifuCustomLabel16.Name = "bunifuCustomLabel16";
            this.bunifuCustomLabel16.Size = new System.Drawing.Size(69, 21);
            this.bunifuCustomLabel16.TabIndex = 77;
            this.bunifuCustomLabel16.Text = "Change:";
            // 
            // bunifuCustomLabel15
            // 
            this.bunifuCustomLabel15.AutoSize = true;
            this.bunifuCustomLabel15.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.bunifuCustomLabel15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(23)))), ((int)(((byte)(26)))));
            this.bunifuCustomLabel15.Location = new System.Drawing.Point(334, 45);
            this.bunifuCustomLabel15.Name = "bunifuCustomLabel15";
            this.bunifuCustomLabel15.Size = new System.Drawing.Size(48, 21);
            this.bunifuCustomLabel15.TabIndex = 75;
            this.bunifuCustomLabel15.Text = "Cash:";
            // 
            // bunifuCustomLabel20
            // 
            this.bunifuCustomLabel20.AutoSize = true;
            this.bunifuCustomLabel20.Font = new System.Drawing.Font("Segoe UI", 24F);
            this.bunifuCustomLabel20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(23)))), ((int)(((byte)(26)))));
            this.bunifuCustomLabel20.Location = new System.Drawing.Point(14, 26);
            this.bunifuCustomLabel20.Name = "bunifuCustomLabel20";
            this.bunifuCustomLabel20.Size = new System.Drawing.Size(117, 45);
            this.bunifuCustomLabel20.TabIndex = 81;
            this.bunifuCustomLabel20.Text = "TOTAL:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnVoid);
            this.groupBox5.Controls.Add(this.btnChange);
            this.groupBox5.Controls.Add(this.btnPay);
            this.groupBox5.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.groupBox5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(23)))), ((int)(((byte)(26)))));
            this.groupBox5.Location = new System.Drawing.Point(1047, 521);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(295, 227);
            this.groupBox5.TabIndex = 85;
            this.groupBox5.TabStop = false;
            // 
            // btnVoid
            // 
            this.btnVoid.ActiveBorderThickness = 1;
            this.btnVoid.ActiveCornerRadius = 5;
            this.btnVoid.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(161)))), ((int)(((byte)(242)))));
            this.btnVoid.ActiveForecolor = System.Drawing.Color.White;
            this.btnVoid.ActiveLineColor = System.Drawing.Color.Black;
            this.btnVoid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.btnVoid.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnVoid.BackgroundImage")));
            this.btnVoid.ButtonText = "VOID";
            this.btnVoid.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVoid.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold);
            this.btnVoid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(213)))), ((int)(((byte)(165)))));
            this.btnVoid.IdleBorderThickness = 1;
            this.btnVoid.IdleCornerRadius = 5;
            this.btnVoid.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.btnVoid.IdleForecolor = System.Drawing.Color.Black;
            this.btnVoid.IdleLineColor = System.Drawing.Color.Black;
            this.btnVoid.Location = new System.Drawing.Point(21, 149);
            this.btnVoid.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btnVoid.Name = "btnVoid";
            this.btnVoid.Size = new System.Drawing.Size(249, 68);
            this.btnVoid.TabIndex = 83;
            this.btnVoid.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnVoid.Click += new System.EventHandler(this.btnVoid_Click);
            // 
            // btnChange
            // 
            this.btnChange.ActiveBorderThickness = 1;
            this.btnChange.ActiveCornerRadius = 5;
            this.btnChange.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(161)))), ((int)(((byte)(242)))));
            this.btnChange.ActiveForecolor = System.Drawing.Color.White;
            this.btnChange.ActiveLineColor = System.Drawing.Color.Black;
            this.btnChange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.btnChange.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnChange.BackgroundImage")));
            this.btnChange.ButtonText = "CHANGE QUANTITY";
            this.btnChange.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChange.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold);
            this.btnChange.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(213)))), ((int)(((byte)(165)))));
            this.btnChange.IdleBorderThickness = 1;
            this.btnChange.IdleCornerRadius = 5;
            this.btnChange.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.btnChange.IdleForecolor = System.Drawing.Color.Black;
            this.btnChange.IdleLineColor = System.Drawing.Color.Black;
            this.btnChange.Location = new System.Drawing.Point(21, 85);
            this.btnChange.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(249, 68);
            this.btnChange.TabIndex = 82;
            this.btnChange.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // btnPay
            // 
            this.btnPay.ActiveBorderThickness = 1;
            this.btnPay.ActiveCornerRadius = 5;
            this.btnPay.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(161)))), ((int)(((byte)(242)))));
            this.btnPay.ActiveForecolor = System.Drawing.Color.White;
            this.btnPay.ActiveLineColor = System.Drawing.Color.Black;
            this.btnPay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.btnPay.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPay.BackgroundImage")));
            this.btnPay.ButtonText = "PAY";
            this.btnPay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPay.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold);
            this.btnPay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(213)))), ((int)(((byte)(165)))));
            this.btnPay.IdleBorderThickness = 1;
            this.btnPay.IdleCornerRadius = 5;
            this.btnPay.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.btnPay.IdleForecolor = System.Drawing.Color.Black;
            this.btnPay.IdleLineColor = System.Drawing.Color.Black;
            this.btnPay.Location = new System.Drawing.Point(21, 19);
            this.btnPay.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(249, 68);
            this.btnPay.TabIndex = 81;
            this.btnPay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // txtBarcode
            // 
            this.txtBarcode.BackColor = System.Drawing.Color.LightBlue;
            this.txtBarcode.BorderColorFocused = System.Drawing.Color.Black;
            this.txtBarcode.BorderColorIdle = System.Drawing.Color.Black;
            this.txtBarcode.BorderColorMouseHover = System.Drawing.Color.Black;
            this.txtBarcode.BorderThickness = 2;
            this.txtBarcode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBarcode.Font = new System.Drawing.Font("Segoe UI", 26F);
            this.txtBarcode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(23)))), ((int)(((byte)(26)))));
            this.txtBarcode.isPassword = false;
            this.txtBarcode.Location = new System.Drawing.Point(9, 21);
            this.txtBarcode.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(324, 53);
            this.txtBarcode.TabIndex = 72;
            this.txtBarcode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBarcode.OnValueChanged += new System.EventHandler(this.txtBarcode_OnValueChanged);
            this.txtBarcode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBarcode_KeyPress);
            this.txtBarcode.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBarcode_KeyUp);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(23)))), ((int)(((byte)(26)))));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(81, 73);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(177, 21);
            this.bunifuCustomLabel1.TabIndex = 72;
            this.bunifuCustomLabel1.Text = "Enter or Scan Item Code";
            this.bunifuCustomLabel1.TextChanged += new System.EventHandler(this.bunifuCustomLabel1_TextChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtBarcode);
            this.groupBox3.Controls.Add(this.bunifuCustomLabel1);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.groupBox3.Location = new System.Drawing.Point(25, 81);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(344, 96);
            this.groupBox3.TabIndex = 76;
            this.groupBox3.TabStop = false;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btnViewPreviousCustomer);
            this.groupBox6.Controls.Add(this.btnHoldNext);
            this.groupBox6.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.groupBox6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(23)))), ((int)(((byte)(26)))));
            this.groupBox6.Location = new System.Drawing.Point(25, 521);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(344, 227);
            this.groupBox6.TabIndex = 88;
            this.groupBox6.TabStop = false;
            // 
            // btnViewPreviousCustomer
            // 
            this.btnViewPreviousCustomer.ActiveBorderThickness = 1;
            this.btnViewPreviousCustomer.ActiveCornerRadius = 5;
            this.btnViewPreviousCustomer.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(161)))), ((int)(((byte)(242)))));
            this.btnViewPreviousCustomer.ActiveForecolor = System.Drawing.Color.White;
            this.btnViewPreviousCustomer.ActiveLineColor = System.Drawing.Color.Black;
            this.btnViewPreviousCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.btnViewPreviousCustomer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnViewPreviousCustomer.BackgroundImage")));
            this.btnViewPreviousCustomer.ButtonText = "VIEW PREVIOUS CUSTOMER";
            this.btnViewPreviousCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnViewPreviousCustomer.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.btnViewPreviousCustomer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(213)))), ((int)(((byte)(165)))));
            this.btnViewPreviousCustomer.IdleBorderThickness = 1;
            this.btnViewPreviousCustomer.IdleCornerRadius = 5;
            this.btnViewPreviousCustomer.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.btnViewPreviousCustomer.IdleForecolor = System.Drawing.Color.Black;
            this.btnViewPreviousCustomer.IdleLineColor = System.Drawing.Color.Black;
            this.btnViewPreviousCustomer.Location = new System.Drawing.Point(17, 123);
            this.btnViewPreviousCustomer.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnViewPreviousCustomer.Name = "btnViewPreviousCustomer";
            this.btnViewPreviousCustomer.Size = new System.Drawing.Size(309, 81);
            this.btnViewPreviousCustomer.TabIndex = 83;
            this.btnViewPreviousCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnViewPreviousCustomer.Click += new System.EventHandler(this.btnViewPreviousCustomer_Click);
            // 
            // btnHoldNext
            // 
            this.btnHoldNext.ActiveBorderThickness = 1;
            this.btnHoldNext.ActiveCornerRadius = 5;
            this.btnHoldNext.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(161)))), ((int)(((byte)(242)))));
            this.btnHoldNext.ActiveForecolor = System.Drawing.Color.White;
            this.btnHoldNext.ActiveLineColor = System.Drawing.Color.Black;
            this.btnHoldNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.btnHoldNext.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHoldNext.BackgroundImage")));
            this.btnHoldNext.ButtonText = "HOLD/NEXT";
            this.btnHoldNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHoldNext.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.btnHoldNext.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(213)))), ((int)(((byte)(165)))));
            this.btnHoldNext.IdleBorderThickness = 1;
            this.btnHoldNext.IdleCornerRadius = 5;
            this.btnHoldNext.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.btnHoldNext.IdleForecolor = System.Drawing.Color.Black;
            this.btnHoldNext.IdleLineColor = System.Drawing.Color.Black;
            this.btnHoldNext.Location = new System.Drawing.Point(17, 28);
            this.btnHoldNext.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnHoldNext.Name = "btnHoldNext";
            this.btnHoldNext.Size = new System.Drawing.Size(309, 81);
            this.btnHoldNext.TabIndex = 82;
            this.btnHoldNext.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnHoldNext.Click += new System.EventHandler(this.btnHoldNext_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 10;
            this.bunifuElipse1.TargetControl = this.dgvCartList;
            // 
            // lstReceipt
            // 
            this.lstReceipt.Font = new System.Drawing.Font("Consolas", 8.25F);
            this.lstReceipt.FormattingEnabled = true;
            this.lstReceipt.Location = new System.Drawing.Point(1182, 70);
            this.lstReceipt.Name = "lstReceipt";
            this.lstReceipt.Size = new System.Drawing.Size(160, 212);
            this.lstReceipt.TabIndex = 89;
            this.lstReceipt.Visible = false;
            // 
            // pnlCustomerName
            // 
            this.pnlCustomerName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCustomerName.Controls.Add(this.btnClose);
            this.pnlCustomerName.Controls.Add(this.btnAdd);
            this.pnlCustomerName.Controls.Add(this.bunifuCustomLabel21);
            this.pnlCustomerName.Controls.Add(this.txtCustomerName);
            this.pnlCustomerName.Location = new System.Drawing.Point(682, 234);
            this.pnlCustomerName.Name = "pnlCustomerName";
            this.pnlCustomerName.Size = new System.Drawing.Size(285, 150);
            this.pnlCustomerName.TabIndex = 90;
            this.pnlCustomerName.Visible = false;
            // 
            // btnClose
            // 
            this.btnClose.ActiveBorderThickness = 1;
            this.btnClose.ActiveCornerRadius = 5;
            this.btnClose.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(161)))), ((int)(((byte)(242)))));
            this.btnClose.ActiveForecolor = System.Drawing.Color.White;
            this.btnClose.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(161)))), ((int)(((byte)(242)))));
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.btnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClose.BackgroundImage")));
            this.btnClose.ButtonText = "Close";
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(213)))), ((int)(((byte)(165)))));
            this.btnClose.IdleBorderThickness = 1;
            this.btnClose.IdleCornerRadius = 5;
            this.btnClose.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.btnClose.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(161)))), ((int)(((byte)(242)))));
            this.btnClose.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(161)))), ((int)(((byte)(242)))));
            this.btnClose.Location = new System.Drawing.Point(146, 103);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(117, 37);
            this.btnClose.TabIndex = 87;
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.ActiveBorderThickness = 1;
            this.btnAdd.ActiveCornerRadius = 5;
            this.btnAdd.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(161)))), ((int)(((byte)(242)))));
            this.btnAdd.ActiveForecolor = System.Drawing.Color.White;
            this.btnAdd.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(161)))), ((int)(((byte)(242)))));
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.btnAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAdd.BackgroundImage")));
            this.btnAdd.ButtonText = "Add";
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(213)))), ((int)(((byte)(165)))));
            this.btnAdd.IdleBorderThickness = 1;
            this.btnAdd.IdleCornerRadius = 5;
            this.btnAdd.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.btnAdd.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(161)))), ((int)(((byte)(242)))));
            this.btnAdd.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(161)))), ((int)(((byte)(242)))));
            this.btnAdd.Location = new System.Drawing.Point(21, 103);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(117, 37);
            this.btnAdd.TabIndex = 86;
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // bunifuCustomLabel21
            // 
            this.bunifuCustomLabel21.AutoSize = true;
            this.bunifuCustomLabel21.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.bunifuCustomLabel21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(23)))), ((int)(((byte)(26)))));
            this.bunifuCustomLabel21.Location = new System.Drawing.Point(38, 10);
            this.bunifuCustomLabel21.Name = "bunifuCustomLabel21";
            this.bunifuCustomLabel21.Size = new System.Drawing.Size(209, 37);
            this.bunifuCustomLabel21.TabIndex = 85;
            this.bunifuCustomLabel21.Text = "Customer Name";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.BackColor = System.Drawing.Color.White;
            this.txtCustomerName.BorderColorFocused = System.Drawing.Color.Black;
            this.txtCustomerName.BorderColorIdle = System.Drawing.Color.Black;
            this.txtCustomerName.BorderColorMouseHover = System.Drawing.Color.Black;
            this.txtCustomerName.BorderThickness = 1;
            this.txtCustomerName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCustomerName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtCustomerName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(23)))), ((int)(((byte)(26)))));
            this.txtCustomerName.isPassword = false;
            this.txtCustomerName.Location = new System.Drawing.Point(47, 64);
            this.txtCustomerName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(191, 24);
            this.txtCustomerName.TabIndex = 71;
            this.txtCustomerName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lblPOSNo
            // 
            this.lblPOSNo.AutoSize = true;
            this.lblPOSNo.Font = new System.Drawing.Font("Segoe UI Semibold", 10.75F, System.Drawing.FontStyle.Bold);
            this.lblPOSNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(23)))), ((int)(((byte)(26)))));
            this.lblPOSNo.Location = new System.Drawing.Point(439, 70);
            this.lblPOSNo.Name = "lblPOSNo";
            this.lblPOSNo.Size = new System.Drawing.Size(57, 20);
            this.lblPOSNo.TabIndex = 92;
            this.lblPOSNo.Text = "cashier";
            // 
            // bunifuCustomLabel18
            // 
            this.bunifuCustomLabel18.AutoSize = true;
            this.bunifuCustomLabel18.Font = new System.Drawing.Font("Segoe UI Semibold", 10.75F, System.Drawing.FontStyle.Bold);
            this.bunifuCustomLabel18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(23)))), ((int)(((byte)(26)))));
            this.bunifuCustomLabel18.Location = new System.Drawing.Point(387, 70);
            this.bunifuCustomLabel18.Name = "bunifuCustomLabel18";
            this.bunifuCustomLabel18.Size = new System.Drawing.Size(50, 20);
            this.bunifuCustomLabel18.TabIndex = 91;
            this.bunifuCustomLabel18.Text = "POS#:";
            // 
            // POS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.ControlBox = false;
            this.Controls.Add(this.lblPOSNo);
            this.Controls.Add(this.bunifuCustomLabel18);
            this.Controls.Add(this.pnlCustomerName);
            this.Controls.Add(this.llbUsername);
            this.Controls.Add(this.bunifuCustomLabel7);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgvCartList);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.lstReceipt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "POS";
            this.Text = "POS";
            this.Load += new System.EventHandler(this.POS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCartList)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.pnlCustomerName.ResumeLayout(false);
            this.pnlCustomerName.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvCartList;
        private System.Windows.Forms.GroupBox groupBox2;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtStocks;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel14;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtQuantity;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel12;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtSellingPrice;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel13;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtDescription;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel11;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel8;
        private System.Windows.Forms.GroupBox groupBox1;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtItemName;
        private Bunifu.Framework.UI.BunifuCustomLabel llbUsername;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel7;
        private Bunifu.Framework.UI.BunifuCustomLabel lblName;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private System.Windows.Forms.GroupBox groupBox4;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtCash;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel20;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel17;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel16;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel15;
        private System.Windows.Forms.GroupBox groupBox5;
        private Bunifu.Framework.UI.BunifuThinButton2 btnPay;
        private Bunifu.Framework.UI.BunifuThinButton2 btnChange;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtBarcode;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.GroupBox groupBox3;
        private Bunifu.Framework.UI.BunifuCustomLabel lblChange;
        private Bunifu.Framework.UI.BunifuCustomLabel lblTotalItem;
        private Bunifu.Framework.UI.BunifuCustomLabel lblTotalPrice;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.Framework.UI.BunifuThinButton2 btnVoid;
        private System.Windows.Forms.GroupBox groupBox6;
        private Bunifu.Framework.UI.BunifuThinButton2 btnViewPreviousCustomer;
        private Bunifu.Framework.UI.BunifuThinButton2 btnHoldNext;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtCategory;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel9;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtBrand;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
        private System.Windows.Forms.DataGridViewTextBoxColumn barcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private System.Windows.Forms.DataGridViewTextBoxColumn costPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPrice;
        private System.Windows.Forms.ListBox lstReceipt;
        private System.Windows.Forms.Panel pnlCustomerName;
        private Bunifu.Framework.UI.BunifuThinButton2 btnClose;
        private Bunifu.Framework.UI.BunifuThinButton2 btnAdd;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel21;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtCustomerName;
        private Bunifu.Framework.UI.BunifuCustomLabel lblPOSNo;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel18;
    }
}
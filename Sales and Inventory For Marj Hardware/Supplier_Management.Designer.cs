namespace Sales_and_Inventory_For_Marj_Hardware
{
    partial class Supplier_Management
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Supplier_Management));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.dgvSupplierList = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.companyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactPerson = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bunifuCustomLabel16 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuCards4 = new Bunifu.Framework.UI.BunifuCards();
            this.txtRemark = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtAddress = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuCustomLabel7 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtEmailAddress = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtContactNumber = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtContactPerson = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtCompanyName = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnUpdateSupplier = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnAddSupplier = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnRemoveSupplier = new Bunifu.Framework.UI.BunifuThinButton2();
            this.txtSearch = new Bunifu.Framework.UI.BunifuTextbox();
            this.rdbShowArchive = new System.Windows.Forms.RadioButton();
            this.rdbShowActive = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupplierList)).BeginInit();
            this.bunifuCards4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this.dgvSupplierList;
            // 
            // dgvSupplierList
            // 
            this.dgvSupplierList.AllowUserToAddRows = false;
            this.dgvSupplierList.AllowUserToDeleteRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.dgvSupplierList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvSupplierList.BackgroundColor = System.Drawing.Color.White;
            this.dgvSupplierList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSupplierList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvSupplierList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(161)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSupplierList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvSupplierList.ColumnHeadersHeight = 50;
            this.dgvSupplierList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.companyName,
            this.contactPerson,
            this.gender,
            this.address,
            this.contactNumber,
            this.emailAddress,
            this.remark});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle9.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSupplierList.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgvSupplierList.DoubleBuffered = true;
            this.dgvSupplierList.EnableHeadersVisualStyles = false;
            this.dgvSupplierList.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(161)))), ((int)(((byte)(242)))));
            this.dgvSupplierList.HeaderForeColor = System.Drawing.Color.White;
            this.dgvSupplierList.Location = new System.Drawing.Point(23, 73);
            this.dgvSupplierList.Name = "dgvSupplierList";
            this.dgvSupplierList.ReadOnly = true;
            this.dgvSupplierList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvSupplierList.RowHeadersVisible = false;
            this.dgvSupplierList.RowTemplate.DividerHeight = 1;
            this.dgvSupplierList.RowTemplate.Height = 40;
            this.dgvSupplierList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSupplierList.Size = new System.Drawing.Size(1060, 342);
            this.dgvSupplierList.TabIndex = 20;
            this.dgvSupplierList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSupplierList_CellClick);
            // 
            // companyName
            // 
            this.companyName.DataPropertyName = "company_name";
            this.companyName.HeaderText = "Company Name";
            this.companyName.Name = "companyName";
            this.companyName.ReadOnly = true;
            this.companyName.Width = 171;
            // 
            // contactPerson
            // 
            this.contactPerson.DataPropertyName = "contact_person";
            this.contactPerson.HeaderText = "Contact Person";
            this.contactPerson.Name = "contactPerson";
            this.contactPerson.ReadOnly = true;
            this.contactPerson.Width = 152;
            // 
            // gender
            // 
            this.gender.DataPropertyName = "gender";
            this.gender.HeaderText = "Gender";
            this.gender.Name = "gender";
            this.gender.ReadOnly = true;
            this.gender.Width = 151;
            // 
            // address
            // 
            this.address.DataPropertyName = "address";
            this.address.HeaderText = "Address";
            this.address.Name = "address";
            this.address.ReadOnly = true;
            this.address.Width = 152;
            // 
            // contactNumber
            // 
            this.contactNumber.DataPropertyName = "contact_number";
            this.contactNumber.HeaderText = "Contact Number";
            this.contactNumber.Name = "contactNumber";
            this.contactNumber.ReadOnly = true;
            this.contactNumber.Width = 131;
            // 
            // emailAddress
            // 
            this.emailAddress.DataPropertyName = "email";
            this.emailAddress.HeaderText = "Email";
            this.emailAddress.Name = "emailAddress";
            this.emailAddress.ReadOnly = true;
            this.emailAddress.Width = 152;
            // 
            // remark
            // 
            this.remark.DataPropertyName = "remark";
            this.remark.HeaderText = "Remark";
            this.remark.Name = "remark";
            this.remark.ReadOnly = true;
            this.remark.Width = 151;
            // 
            // bunifuCustomLabel16
            // 
            this.bunifuCustomLabel16.AutoSize = true;
            this.bunifuCustomLabel16.Font = new System.Drawing.Font("Segoe UI", 20.25F);
            this.bunifuCustomLabel16.ForeColor = System.Drawing.Color.DimGray;
            this.bunifuCustomLabel16.Location = new System.Drawing.Point(16, 30);
            this.bunifuCustomLabel16.Name = "bunifuCustomLabel16";
            this.bunifuCustomLabel16.Size = new System.Drawing.Size(162, 37);
            this.bunifuCustomLabel16.TabIndex = 24;
            this.bunifuCustomLabel16.Text = "Supplier List";
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 5;
            this.bunifuElipse2.TargetControl = this.dgvSupplierList;
            // 
            // bunifuCards4
            // 
            this.bunifuCards4.BackColor = System.Drawing.Color.White;
            this.bunifuCards4.BorderRadius = 5;
            this.bunifuCards4.BottomSahddow = true;
            this.bunifuCards4.color = System.Drawing.Color.White;
            this.bunifuCards4.Controls.Add(this.txtRemark);
            this.bunifuCards4.Controls.Add(this.bunifuCustomLabel5);
            this.bunifuCards4.Controls.Add(this.txtAddress);
            this.bunifuCards4.Controls.Add(this.bunifuCustomLabel7);
            this.bunifuCards4.Controls.Add(this.txtEmailAddress);
            this.bunifuCards4.Controls.Add(this.bunifuCustomLabel6);
            this.bunifuCards4.Controls.Add(this.txtContactNumber);
            this.bunifuCards4.Controls.Add(this.bunifuCustomLabel3);
            this.bunifuCards4.Controls.Add(this.bunifuCustomLabel4);
            this.bunifuCards4.Controls.Add(this.txtContactPerson);
            this.bunifuCards4.Controls.Add(this.bunifuCustomLabel2);
            this.bunifuCards4.Controls.Add(this.txtCompanyName);
            this.bunifuCards4.Controls.Add(this.bunifuCustomLabel1);
            this.bunifuCards4.Controls.Add(this.groupBox1);
            this.bunifuCards4.LeftSahddow = true;
            this.bunifuCards4.Location = new System.Drawing.Point(23, 435);
            this.bunifuCards4.Name = "bunifuCards4";
            this.bunifuCards4.RightSahddow = true;
            this.bunifuCards4.ShadowDepth = 20;
            this.bunifuCards4.Size = new System.Drawing.Size(1060, 253);
            this.bunifuCards4.TabIndex = 21;
            // 
            // txtRemark
            // 
            this.txtRemark.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(161)))), ((int)(((byte)(242)))));
            this.txtRemark.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(236)))), ((int)(((byte)(240)))));
            this.txtRemark.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(161)))), ((int)(((byte)(242)))));
            this.txtRemark.BorderThickness = 2;
            this.txtRemark.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRemark.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtRemark.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(23)))), ((int)(((byte)(26)))));
            this.txtRemark.isPassword = false;
            this.txtRemark.Location = new System.Drawing.Point(564, 169);
            this.txtRemark.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(230, 35);
            this.txtRemark.TabIndex = 16;
            this.txtRemark.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.bunifuCustomLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(23)))), ((int)(((byte)(26)))));
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(560, 144);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(65, 21);
            this.bunifuCustomLabel5.TabIndex = 15;
            this.bunifuCustomLabel5.Text = "Remark";
            // 
            // txtAddress
            // 
            this.txtAddress.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(161)))), ((int)(((byte)(242)))));
            this.txtAddress.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(236)))), ((int)(((byte)(240)))));
            this.txtAddress.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(161)))), ((int)(((byte)(242)))));
            this.txtAddress.BorderThickness = 2;
            this.txtAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAddress.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(23)))), ((int)(((byte)(26)))));
            this.txtAddress.isPassword = false;
            this.txtAddress.Location = new System.Drawing.Point(302, 88);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(230, 35);
            this.txtAddress.TabIndex = 14;
            this.txtAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel7
            // 
            this.bunifuCustomLabel7.AutoSize = true;
            this.bunifuCustomLabel7.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(23)))), ((int)(((byte)(26)))));
            this.bunifuCustomLabel7.Location = new System.Drawing.Point(12, 9);
            this.bunifuCustomLabel7.Name = "bunifuCustomLabel7";
            this.bunifuCustomLabel7.Size = new System.Drawing.Size(0, 30);
            this.bunifuCustomLabel7.TabIndex = 12;
            // 
            // txtEmailAddress
            // 
            this.txtEmailAddress.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(161)))), ((int)(((byte)(242)))));
            this.txtEmailAddress.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(236)))), ((int)(((byte)(240)))));
            this.txtEmailAddress.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(161)))), ((int)(((byte)(242)))));
            this.txtEmailAddress.BorderThickness = 2;
            this.txtEmailAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmailAddress.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtEmailAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(23)))), ((int)(((byte)(26)))));
            this.txtEmailAddress.isPassword = false;
            this.txtEmailAddress.Location = new System.Drawing.Point(302, 169);
            this.txtEmailAddress.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEmailAddress.Name = "txtEmailAddress";
            this.txtEmailAddress.Size = new System.Drawing.Size(230, 35);
            this.txtEmailAddress.TabIndex = 10;
            this.txtEmailAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.AutoSize = true;
            this.bunifuCustomLabel6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.bunifuCustomLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(23)))), ((int)(((byte)(26)))));
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(298, 144);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(112, 21);
            this.bunifuCustomLabel6.TabIndex = 8;
            this.bunifuCustomLabel6.Text = "Email Address";
            // 
            // txtContactNumber
            // 
            this.txtContactNumber.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(161)))), ((int)(((byte)(242)))));
            this.txtContactNumber.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(236)))), ((int)(((byte)(240)))));
            this.txtContactNumber.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(161)))), ((int)(((byte)(242)))));
            this.txtContactNumber.BorderThickness = 2;
            this.txtContactNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtContactNumber.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtContactNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(23)))), ((int)(((byte)(26)))));
            this.txtContactNumber.isPassword = false;
            this.txtContactNumber.Location = new System.Drawing.Point(564, 88);
            this.txtContactNumber.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtContactNumber.Name = "txtContactNumber";
            this.txtContactNumber.Size = new System.Drawing.Size(230, 35);
            this.txtContactNumber.TabIndex = 5;
            this.txtContactNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtContactNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtContactNumber_KeyPress);
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(23)))), ((int)(((byte)(26)))));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(560, 63);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(131, 21);
            this.bunifuCustomLabel3.TabIndex = 3;
            this.bunifuCustomLabel3.Text = "Contact Number";
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.bunifuCustomLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(23)))), ((int)(((byte)(26)))));
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(298, 63);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(70, 21);
            this.bunifuCustomLabel4.TabIndex = 4;
            this.bunifuCustomLabel4.Text = "Address";
            // 
            // txtContactPerson
            // 
            this.txtContactPerson.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(161)))), ((int)(((byte)(242)))));
            this.txtContactPerson.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(236)))), ((int)(((byte)(240)))));
            this.txtContactPerson.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(161)))), ((int)(((byte)(242)))));
            this.txtContactPerson.BorderThickness = 2;
            this.txtContactPerson.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtContactPerson.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtContactPerson.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(23)))), ((int)(((byte)(26)))));
            this.txtContactPerson.isPassword = false;
            this.txtContactPerson.Location = new System.Drawing.Point(39, 169);
            this.txtContactPerson.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtContactPerson.Name = "txtContactPerson";
            this.txtContactPerson.Size = new System.Drawing.Size(230, 35);
            this.txtContactPerson.TabIndex = 2;
            this.txtContactPerson.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(23)))), ((int)(((byte)(26)))));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(35, 144);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(120, 21);
            this.bunifuCustomLabel2.TabIndex = 1;
            this.bunifuCustomLabel2.Text = "Contact Person";
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(161)))), ((int)(((byte)(242)))));
            this.txtCompanyName.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(236)))), ((int)(((byte)(240)))));
            this.txtCompanyName.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(161)))), ((int)(((byte)(242)))));
            this.txtCompanyName.BorderThickness = 2;
            this.txtCompanyName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCompanyName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtCompanyName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(23)))), ((int)(((byte)(26)))));
            this.txtCompanyName.isPassword = false;
            this.txtCompanyName.Location = new System.Drawing.Point(39, 88);
            this.txtCompanyName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.Size = new System.Drawing.Size(230, 35);
            this.txtCompanyName.TabIndex = 2;
            this.txtCompanyName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(23)))), ((int)(((byte)(26)))));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(35, 63);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(126, 21);
            this.bunifuCustomLabel1.TabIndex = 1;
            this.bunifuCustomLabel1.Text = "Company Name";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.btnUpdateSupplier);
            this.groupBox1.Controls.Add(this.btnAddSupplier);
            this.groupBox1.Controls.Add(this.btnRemoveSupplier);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(23)))), ((int)(((byte)(26)))));
            this.groupBox1.Location = new System.Drawing.Point(15, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1028, 235);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Supplier Information";
            // 
            // btnUpdateSupplier
            // 
            this.btnUpdateSupplier.ActiveBorderThickness = 1;
            this.btnUpdateSupplier.ActiveCornerRadius = 5;
            this.btnUpdateSupplier.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(161)))), ((int)(((byte)(242)))));
            this.btnUpdateSupplier.ActiveForecolor = System.Drawing.Color.White;
            this.btnUpdateSupplier.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(161)))), ((int)(((byte)(242)))));
            this.btnUpdateSupplier.BackColor = System.Drawing.Color.White;
            this.btnUpdateSupplier.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUpdateSupplier.BackgroundImage")));
            this.btnUpdateSupplier.ButtonText = "Update Supplier";
            this.btnUpdateSupplier.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateSupplier.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateSupplier.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(213)))), ((int)(((byte)(165)))));
            this.btnUpdateSupplier.IdleBorderThickness = 1;
            this.btnUpdateSupplier.IdleCornerRadius = 5;
            this.btnUpdateSupplier.IdleFillColor = System.Drawing.Color.White;
            this.btnUpdateSupplier.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(161)))), ((int)(((byte)(242)))));
            this.btnUpdateSupplier.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(161)))), ((int)(((byte)(242)))));
            this.btnUpdateSupplier.Location = new System.Drawing.Point(809, 109);
            this.btnUpdateSupplier.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUpdateSupplier.Name = "btnUpdateSupplier";
            this.btnUpdateSupplier.Size = new System.Drawing.Size(199, 47);
            this.btnUpdateSupplier.TabIndex = 11;
            this.btnUpdateSupplier.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnUpdateSupplier.Click += new System.EventHandler(this.btnUpdateSupplier_Click);
            // 
            // btnAddSupplier
            // 
            this.btnAddSupplier.ActiveBorderThickness = 1;
            this.btnAddSupplier.ActiveCornerRadius = 5;
            this.btnAddSupplier.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(161)))), ((int)(((byte)(242)))));
            this.btnAddSupplier.ActiveForecolor = System.Drawing.Color.White;
            this.btnAddSupplier.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(161)))), ((int)(((byte)(242)))));
            this.btnAddSupplier.BackColor = System.Drawing.Color.White;
            this.btnAddSupplier.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddSupplier.BackgroundImage")));
            this.btnAddSupplier.ButtonText = "Add Supplier";
            this.btnAddSupplier.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddSupplier.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSupplier.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(213)))), ((int)(((byte)(165)))));
            this.btnAddSupplier.IdleBorderThickness = 1;
            this.btnAddSupplier.IdleCornerRadius = 5;
            this.btnAddSupplier.IdleFillColor = System.Drawing.Color.White;
            this.btnAddSupplier.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(161)))), ((int)(((byte)(242)))));
            this.btnAddSupplier.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(161)))), ((int)(((byte)(242)))));
            this.btnAddSupplier.Location = new System.Drawing.Point(809, 51);
            this.btnAddSupplier.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddSupplier.Name = "btnAddSupplier";
            this.btnAddSupplier.Size = new System.Drawing.Size(199, 47);
            this.btnAddSupplier.TabIndex = 11;
            this.btnAddSupplier.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAddSupplier.Click += new System.EventHandler(this.btnAddSupplier_Click);
            // 
            // btnRemoveSupplier
            // 
            this.btnRemoveSupplier.ActiveBorderThickness = 1;
            this.btnRemoveSupplier.ActiveCornerRadius = 5;
            this.btnRemoveSupplier.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(161)))), ((int)(((byte)(242)))));
            this.btnRemoveSupplier.ActiveForecolor = System.Drawing.Color.White;
            this.btnRemoveSupplier.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(161)))), ((int)(((byte)(242)))));
            this.btnRemoveSupplier.BackColor = System.Drawing.Color.White;
            this.btnRemoveSupplier.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRemoveSupplier.BackgroundImage")));
            this.btnRemoveSupplier.ButtonText = "Remove Supplier";
            this.btnRemoveSupplier.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemoveSupplier.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveSupplier.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(213)))), ((int)(((byte)(165)))));
            this.btnRemoveSupplier.IdleBorderThickness = 1;
            this.btnRemoveSupplier.IdleCornerRadius = 5;
            this.btnRemoveSupplier.IdleFillColor = System.Drawing.Color.White;
            this.btnRemoveSupplier.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(161)))), ((int)(((byte)(242)))));
            this.btnRemoveSupplier.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(161)))), ((int)(((byte)(242)))));
            this.btnRemoveSupplier.Location = new System.Drawing.Point(809, 166);
            this.btnRemoveSupplier.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRemoveSupplier.Name = "btnRemoveSupplier";
            this.btnRemoveSupplier.Size = new System.Drawing.Size(199, 47);
            this.btnRemoveSupplier.TabIndex = 11;
            this.btnRemoveSupplier.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnRemoveSupplier.Click += new System.EventHandler(this.btnRemoveSupplier_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.txtSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtSearch.BackgroundImage")));
            this.txtSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(161)))), ((int)(((byte)(242)))));
            this.txtSearch.Icon = ((System.Drawing.Image)(resources.GetObject("txtSearch.Icon")));
            this.txtSearch.Location = new System.Drawing.Point(833, 25);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(250, 42);
            this.txtSearch.TabIndex = 22;
            this.txtSearch.text = "Search";
            this.txtSearch.KeyDown += new System.EventHandler(this.txtSearch_KeyDown);
            this.txtSearch.Leave += new System.EventHandler(this.txtSearch_Leave);
            // 
            // rdbShowArchive
            // 
            this.rdbShowArchive.AutoSize = true;
            this.rdbShowArchive.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.rdbShowArchive.Location = new System.Drawing.Point(730, 46);
            this.rdbShowArchive.Name = "rdbShowArchive";
            this.rdbShowArchive.Size = new System.Drawing.Size(98, 19);
            this.rdbShowArchive.TabIndex = 26;
            this.rdbShowArchive.TabStop = true;
            this.rdbShowArchive.Text = "Show Inactive";
            this.rdbShowArchive.UseVisualStyleBackColor = true;
            this.rdbShowArchive.CheckedChanged += new System.EventHandler(this.rdbShowArchive_CheckedChanged);
            // 
            // rdbShowActive
            // 
            this.rdbShowActive.AutoSize = true;
            this.rdbShowActive.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.rdbShowActive.Location = new System.Drawing.Point(634, 46);
            this.rdbShowActive.Name = "rdbShowActive";
            this.rdbShowActive.Size = new System.Drawing.Size(90, 19);
            this.rdbShowActive.TabIndex = 25;
            this.rdbShowActive.TabStop = true;
            this.rdbShowActive.Text = "Show Active";
            this.rdbShowActive.UseVisualStyleBackColor = true;
            this.rdbShowActive.CheckedChanged += new System.EventHandler(this.rdbShowActive_CheckedChanged);
            // 
            // Supplier_Management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1098, 698);
            this.Controls.Add(this.rdbShowArchive);
            this.Controls.Add(this.rdbShowActive);
            this.Controls.Add(this.bunifuCustomLabel16);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.bunifuCards4);
            this.Controls.Add(this.dgvSupplierList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Supplier_Management";
            this.Text = "Supplier_Management";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupplierList)).EndInit();
            this.bunifuCards4.ResumeLayout(false);
            this.bunifuCards4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvSupplierList;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactPerson;
        private System.Windows.Forms.DataGridViewTextBoxColumn gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn remark;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel16;
        private Bunifu.Framework.UI.BunifuTextbox txtSearch;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private Bunifu.Framework.UI.BunifuCards bunifuCards4;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtRemark;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtAddress;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel7;
        private Bunifu.Framework.UI.BunifuThinButton2 btnRemoveSupplier;
        private Bunifu.Framework.UI.BunifuThinButton2 btnUpdateSupplier;
        private Bunifu.Framework.UI.BunifuThinButton2 btnAddSupplier;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtEmailAddress;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtContactNumber;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtContactPerson;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtCompanyName;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbShowArchive;
        private System.Windows.Forms.RadioButton rdbShowActive;
    }
}
namespace Sales_and_Inventory_For_Marj_Hardware
{
    partial class Mainform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mainform));
            this.pnlHeader = new Bunifu.Framework.UI.BunifuCards();
            this.lblTitle = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.pnlSlidebar = new Bunifu.Framework.UI.BunifuCards();
            this.bunifuFlatButton2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.picSettings = new System.Windows.Forms.PictureBox();
            this.imgProfilePicture = new Bunifu.Framework.UI.BunifuImageButton();
            this.indicator = new System.Windows.Forms.PictureBox();
            this.btnDashboard = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnUserManagement = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnSupplierManagement = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnItemManagement = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnPurchaseOrder = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnReceiveOrder = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnInventory = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnReports = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel = new System.Windows.Forms.Panel();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pnlHeader.SuspendLayout();
            this.pnlSlidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSettings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgProfilePicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.indicator)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.White;
            this.pnlHeader.BorderRadius = 0;
            this.pnlHeader.BottomSahddow = true;
            this.pnlHeader.color = System.Drawing.Color.White;
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Controls.Add(this.label9);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.LeftSahddow = true;
            this.pnlHeader.Location = new System.Drawing.Point(265, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.RightSahddow = false;
            this.pnlHeader.ShadowDepth = 40;
            this.pnlHeader.Size = new System.Drawing.Size(1101, 73);
            this.pnlHeader.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.DimGray;
            this.lblTitle.Location = new System.Drawing.Point(3, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(179, 45);
            this.lblTitle.TabIndex = 6;
            this.lblTitle.Text = "Dashboard";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Gray;
            this.label9.Location = new System.Drawing.Point(1078, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(20, 28);
            this.label9.TabIndex = 0;
            this.label9.Text = "_";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Location = new System.Drawing.Point(0, 244);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(265, 3);
            this.panel1.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Gray;
            this.label10.Location = new System.Drawing.Point(13, 201);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(239, 28);
            this.label10.TabIndex = 0;
            this.label10.Text = "Vhen Larson Dela Cuesta";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.label11.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label11.Location = new System.Drawing.Point(92, 177);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 17);
            this.label11.TabIndex = 13;
            this.label11.Text = "Edit Profile";
            // 
            // pnlSlidebar
            // 
            this.pnlSlidebar.BackColor = System.Drawing.Color.White;
            this.pnlSlidebar.BorderRadius = 5;
            this.pnlSlidebar.BottomSahddow = true;
            this.pnlSlidebar.color = System.Drawing.Color.White;
            this.pnlSlidebar.Controls.Add(this.bunifuFlatButton2);
            this.pnlSlidebar.Controls.Add(this.label11);
            this.pnlSlidebar.Controls.Add(this.picSettings);
            this.pnlSlidebar.Controls.Add(this.label10);
            this.pnlSlidebar.Controls.Add(this.imgProfilePicture);
            this.pnlSlidebar.Controls.Add(this.panel1);
            this.pnlSlidebar.Controls.Add(this.indicator);
            this.pnlSlidebar.Controls.Add(this.btnDashboard);
            this.pnlSlidebar.Controls.Add(this.bunifuFlatButton1);
            this.pnlSlidebar.Controls.Add(this.btnUserManagement);
            this.pnlSlidebar.Controls.Add(this.btnSupplierManagement);
            this.pnlSlidebar.Controls.Add(this.btnItemManagement);
            this.pnlSlidebar.Controls.Add(this.btnPurchaseOrder);
            this.pnlSlidebar.Controls.Add(this.btnReceiveOrder);
            this.pnlSlidebar.Controls.Add(this.btnInventory);
            this.pnlSlidebar.Controls.Add(this.btnReports);
            this.pnlSlidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSlidebar.LeftSahddow = true;
            this.pnlSlidebar.Location = new System.Drawing.Point(0, 0);
            this.pnlSlidebar.Name = "pnlSlidebar";
            this.pnlSlidebar.RightSahddow = true;
            this.pnlSlidebar.ShadowDepth = 40;
            this.pnlSlidebar.Size = new System.Drawing.Size(265, 768);
            this.pnlSlidebar.TabIndex = 0;
            // 
            // bunifuFlatButton2
            // 
            this.bunifuFlatButton2.Activecolor = System.Drawing.Color.White;
            this.bunifuFlatButton2.BackColor = System.Drawing.Color.White;
            this.bunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton2.BorderRadius = 0;
            this.bunifuFlatButton2.ButtonText = "   Purchase Reports";
            this.bunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton2.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton2.Iconimage")));
            this.bunifuFlatButton2.Iconimage_right = null;
            this.bunifuFlatButton2.Iconimage_right_Selected = null;
            this.bunifuFlatButton2.Iconimage_Selected = null;
            this.bunifuFlatButton2.IconMarginLeft = 0;
            this.bunifuFlatButton2.IconMarginRight = 0;
            this.bunifuFlatButton2.IconRightVisible = true;
            this.bunifuFlatButton2.IconRightZoom = 0D;
            this.bunifuFlatButton2.IconVisible = true;
            this.bunifuFlatButton2.IconZoom = 65D;
            this.bunifuFlatButton2.IsTab = false;
            this.bunifuFlatButton2.Location = new System.Drawing.Point(4, 660);
            this.bunifuFlatButton2.Name = "bunifuFlatButton2";
            this.bunifuFlatButton2.Normalcolor = System.Drawing.Color.White;
            this.bunifuFlatButton2.OnHovercolor = System.Drawing.Color.White;
            this.bunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(161)))), ((int)(((byte)(242)))));
            this.bunifuFlatButton2.selected = true;
            this.bunifuFlatButton2.Size = new System.Drawing.Size(259, 45);
            this.bunifuFlatButton2.TabIndex = 17;
            this.bunifuFlatButton2.Text = "   Purchase Reports";
            this.bunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton2.Textcolor = System.Drawing.Color.Gray;
            this.bunifuFlatButton2.TextFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton2.Visible = false;
            this.bunifuFlatButton2.Click += new System.EventHandler(this.bunifuFlatButton2_Click_1);
            // 
            // picSettings
            // 
            this.picSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picSettings.Image = global::Sales_and_Inventory_For_Marj_Hardware.Properties.Resources.settings;
            this.picSettings.Location = new System.Drawing.Point(213, 721);
            this.picSettings.Name = "picSettings";
            this.picSettings.Size = new System.Drawing.Size(35, 35);
            this.picSettings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSettings.TabIndex = 0;
            this.picSettings.TabStop = false;
            this.picSettings.Click += new System.EventHandler(this.picSettings_Click);
            // 
            // imgProfilePicture
            // 
            this.imgProfilePicture.BackColor = System.Drawing.Color.White;
            this.imgProfilePicture.Image = ((System.Drawing.Image)(resources.GetObject("imgProfilePicture.Image")));
            this.imgProfilePicture.ImageActive = null;
            this.imgProfilePicture.Location = new System.Drawing.Point(55, 23);
            this.imgProfilePicture.Name = "imgProfilePicture";
            this.imgProfilePicture.Size = new System.Drawing.Size(150, 150);
            this.imgProfilePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgProfilePicture.TabIndex = 9;
            this.imgProfilePicture.TabStop = false;
            this.imgProfilePicture.Zoom = 10;
            this.imgProfilePicture.Click += new System.EventHandler(this.imgProfilePicture_Click);
            // 
            // indicator
            // 
            this.indicator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(161)))), ((int)(((byte)(242)))));
            this.indicator.Location = new System.Drawing.Point(259, 253);
            this.indicator.Name = "indicator";
            this.indicator.Size = new System.Drawing.Size(6, 44);
            this.indicator.TabIndex = 3;
            this.indicator.TabStop = false;
            // 
            // btnDashboard
            // 
            this.btnDashboard.Activecolor = System.Drawing.Color.White;
            this.btnDashboard.BackColor = System.Drawing.Color.White;
            this.btnDashboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDashboard.BorderRadius = 0;
            this.btnDashboard.ButtonText = "    Dashboard";
            this.btnDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDashboard.DisabledColor = System.Drawing.Color.Gray;
            this.btnDashboard.Iconcolor = System.Drawing.Color.Transparent;
            this.btnDashboard.Iconimage = global::Sales_and_Inventory_For_Marj_Hardware.Properties.Resources.home;
            this.btnDashboard.Iconimage_right = null;
            this.btnDashboard.Iconimage_right_Selected = null;
            this.btnDashboard.Iconimage_Selected = null;
            this.btnDashboard.IconMarginLeft = 0;
            this.btnDashboard.IconMarginRight = 0;
            this.btnDashboard.IconRightVisible = true;
            this.btnDashboard.IconRightZoom = 0D;
            this.btnDashboard.IconVisible = true;
            this.btnDashboard.IconZoom = 50D;
            this.btnDashboard.IsTab = false;
            this.btnDashboard.Location = new System.Drawing.Point(3, 252);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Normalcolor = System.Drawing.Color.White;
            this.btnDashboard.OnHovercolor = System.Drawing.Color.White;
            this.btnDashboard.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(161)))), ((int)(((byte)(242)))));
            this.btnDashboard.selected = true;
            this.btnDashboard.Size = new System.Drawing.Size(262, 45);
            this.btnDashboard.TabIndex = 2;
            this.btnDashboard.Text = "    Dashboard";
            this.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.Textcolor = System.Drawing.Color.Gray;
            this.btnDashboard.TextFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton1.Iconimage")));
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 90D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(0, 2);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(262, 236);
            this.bunifuFlatButton1.TabIndex = 1;
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnUserManagement
            // 
            this.btnUserManagement.Activecolor = System.Drawing.Color.White;
            this.btnUserManagement.BackColor = System.Drawing.Color.White;
            this.btnUserManagement.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUserManagement.BorderRadius = 0;
            this.btnUserManagement.ButtonText = "   User Management";
            this.btnUserManagement.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUserManagement.DisabledColor = System.Drawing.Color.White;
            this.btnUserManagement.Iconcolor = System.Drawing.Color.Transparent;
            this.btnUserManagement.Iconimage = global::Sales_and_Inventory_For_Marj_Hardware.Properties.Resources.management;
            this.btnUserManagement.Iconimage_right = null;
            this.btnUserManagement.Iconimage_right_Selected = null;
            this.btnUserManagement.Iconimage_Selected = null;
            this.btnUserManagement.IconMarginLeft = 0;
            this.btnUserManagement.IconMarginRight = 0;
            this.btnUserManagement.IconRightVisible = true;
            this.btnUserManagement.IconRightZoom = 0D;
            this.btnUserManagement.IconVisible = true;
            this.btnUserManagement.IconZoom = 70D;
            this.btnUserManagement.IsTab = false;
            this.btnUserManagement.Location = new System.Drawing.Point(3, 303);
            this.btnUserManagement.Name = "btnUserManagement";
            this.btnUserManagement.Normalcolor = System.Drawing.Color.White;
            this.btnUserManagement.OnHovercolor = System.Drawing.Color.White;
            this.btnUserManagement.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(161)))), ((int)(((byte)(242)))));
            this.btnUserManagement.selected = true;
            this.btnUserManagement.Size = new System.Drawing.Size(259, 45);
            this.btnUserManagement.TabIndex = 4;
            this.btnUserManagement.Text = "   User Management";
            this.btnUserManagement.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUserManagement.Textcolor = System.Drawing.Color.Gray;
            this.btnUserManagement.TextFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserManagement.Click += new System.EventHandler(this.btnUserManagement_Click);
            // 
            // btnSupplierManagement
            // 
            this.btnSupplierManagement.Activecolor = System.Drawing.Color.White;
            this.btnSupplierManagement.BackColor = System.Drawing.Color.White;
            this.btnSupplierManagement.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSupplierManagement.BorderRadius = 0;
            this.btnSupplierManagement.ButtonText = "   Supplier Management";
            this.btnSupplierManagement.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSupplierManagement.DisabledColor = System.Drawing.Color.Gray;
            this.btnSupplierManagement.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSupplierManagement.Iconimage = global::Sales_and_Inventory_For_Marj_Hardware.Properties.Resources.supplier;
            this.btnSupplierManagement.Iconimage_right = null;
            this.btnSupplierManagement.Iconimage_right_Selected = null;
            this.btnSupplierManagement.Iconimage_Selected = null;
            this.btnSupplierManagement.IconMarginLeft = 0;
            this.btnSupplierManagement.IconMarginRight = 0;
            this.btnSupplierManagement.IconRightVisible = true;
            this.btnSupplierManagement.IconRightZoom = 0D;
            this.btnSupplierManagement.IconVisible = true;
            this.btnSupplierManagement.IconZoom = 70D;
            this.btnSupplierManagement.IsTab = false;
            this.btnSupplierManagement.Location = new System.Drawing.Point(3, 354);
            this.btnSupplierManagement.Name = "btnSupplierManagement";
            this.btnSupplierManagement.Normalcolor = System.Drawing.Color.White;
            this.btnSupplierManagement.OnHovercolor = System.Drawing.Color.White;
            this.btnSupplierManagement.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(161)))), ((int)(((byte)(242)))));
            this.btnSupplierManagement.selected = true;
            this.btnSupplierManagement.Size = new System.Drawing.Size(259, 45);
            this.btnSupplierManagement.TabIndex = 10;
            this.btnSupplierManagement.Text = "   Supplier Management";
            this.btnSupplierManagement.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSupplierManagement.Textcolor = System.Drawing.Color.Gray;
            this.btnSupplierManagement.TextFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupplierManagement.Click += new System.EventHandler(this.btnSupplierManagement_Click);
            // 
            // btnItemManagement
            // 
            this.btnItemManagement.Activecolor = System.Drawing.Color.White;
            this.btnItemManagement.BackColor = System.Drawing.Color.White;
            this.btnItemManagement.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnItemManagement.BorderRadius = 0;
            this.btnItemManagement.ButtonText = "   Product Entry";
            this.btnItemManagement.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnItemManagement.DisabledColor = System.Drawing.Color.Gray;
            this.btnItemManagement.Iconcolor = System.Drawing.Color.Transparent;
            this.btnItemManagement.Iconimage = global::Sales_and_Inventory_For_Marj_Hardware.Properties.Resources.items;
            this.btnItemManagement.Iconimage_right = null;
            this.btnItemManagement.Iconimage_right_Selected = null;
            this.btnItemManagement.Iconimage_Selected = null;
            this.btnItemManagement.IconMarginLeft = 0;
            this.btnItemManagement.IconMarginRight = 0;
            this.btnItemManagement.IconRightVisible = true;
            this.btnItemManagement.IconRightZoom = 0D;
            this.btnItemManagement.IconVisible = true;
            this.btnItemManagement.IconZoom = 65D;
            this.btnItemManagement.IsTab = false;
            this.btnItemManagement.Location = new System.Drawing.Point(3, 405);
            this.btnItemManagement.Name = "btnItemManagement";
            this.btnItemManagement.Normalcolor = System.Drawing.Color.White;
            this.btnItemManagement.OnHovercolor = System.Drawing.Color.White;
            this.btnItemManagement.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(161)))), ((int)(((byte)(242)))));
            this.btnItemManagement.selected = true;
            this.btnItemManagement.Size = new System.Drawing.Size(259, 45);
            this.btnItemManagement.TabIndex = 11;
            this.btnItemManagement.Text = "   Product Entry";
            this.btnItemManagement.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnItemManagement.Textcolor = System.Drawing.Color.Gray;
            this.btnItemManagement.TextFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnItemManagement.Click += new System.EventHandler(this.btnItemManagement_Click);
            // 
            // btnPurchaseOrder
            // 
            this.btnPurchaseOrder.Activecolor = System.Drawing.Color.White;
            this.btnPurchaseOrder.BackColor = System.Drawing.Color.White;
            this.btnPurchaseOrder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPurchaseOrder.BorderRadius = 0;
            this.btnPurchaseOrder.ButtonText = "   Purchase Order";
            this.btnPurchaseOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPurchaseOrder.DisabledColor = System.Drawing.Color.Gray;
            this.btnPurchaseOrder.Iconcolor = System.Drawing.Color.Transparent;
            this.btnPurchaseOrder.Iconimage = global::Sales_and_Inventory_For_Marj_Hardware.Properties.Resources.online_shop;
            this.btnPurchaseOrder.Iconimage_right = null;
            this.btnPurchaseOrder.Iconimage_right_Selected = null;
            this.btnPurchaseOrder.Iconimage_Selected = null;
            this.btnPurchaseOrder.IconMarginLeft = 0;
            this.btnPurchaseOrder.IconMarginRight = 0;
            this.btnPurchaseOrder.IconRightVisible = true;
            this.btnPurchaseOrder.IconRightZoom = 0D;
            this.btnPurchaseOrder.IconVisible = true;
            this.btnPurchaseOrder.IconZoom = 65D;
            this.btnPurchaseOrder.IsTab = false;
            this.btnPurchaseOrder.Location = new System.Drawing.Point(3, 456);
            this.btnPurchaseOrder.Name = "btnPurchaseOrder";
            this.btnPurchaseOrder.Normalcolor = System.Drawing.Color.White;
            this.btnPurchaseOrder.OnHovercolor = System.Drawing.Color.White;
            this.btnPurchaseOrder.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(161)))), ((int)(((byte)(242)))));
            this.btnPurchaseOrder.selected = true;
            this.btnPurchaseOrder.Size = new System.Drawing.Size(259, 45);
            this.btnPurchaseOrder.TabIndex = 12;
            this.btnPurchaseOrder.Text = "   Purchase Order";
            this.btnPurchaseOrder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPurchaseOrder.Textcolor = System.Drawing.Color.Gray;
            this.btnPurchaseOrder.TextFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPurchaseOrder.Click += new System.EventHandler(this.btnPurchaseOrder_Click);
            // 
            // btnReceiveOrder
            // 
            this.btnReceiveOrder.Activecolor = System.Drawing.Color.White;
            this.btnReceiveOrder.BackColor = System.Drawing.Color.White;
            this.btnReceiveOrder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReceiveOrder.BorderRadius = 0;
            this.btnReceiveOrder.ButtonText = "   Receive Order";
            this.btnReceiveOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReceiveOrder.DisabledColor = System.Drawing.Color.Gray;
            this.btnReceiveOrder.Iconcolor = System.Drawing.Color.Transparent;
            this.btnReceiveOrder.Iconimage = global::Sales_and_Inventory_For_Marj_Hardware.Properties.Resources.box;
            this.btnReceiveOrder.Iconimage_right = null;
            this.btnReceiveOrder.Iconimage_right_Selected = null;
            this.btnReceiveOrder.Iconimage_Selected = null;
            this.btnReceiveOrder.IconMarginLeft = 0;
            this.btnReceiveOrder.IconMarginRight = 0;
            this.btnReceiveOrder.IconRightVisible = true;
            this.btnReceiveOrder.IconRightZoom = 0D;
            this.btnReceiveOrder.IconVisible = true;
            this.btnReceiveOrder.IconZoom = 65D;
            this.btnReceiveOrder.IsTab = false;
            this.btnReceiveOrder.Location = new System.Drawing.Point(3, 507);
            this.btnReceiveOrder.Name = "btnReceiveOrder";
            this.btnReceiveOrder.Normalcolor = System.Drawing.Color.White;
            this.btnReceiveOrder.OnHovercolor = System.Drawing.Color.White;
            this.btnReceiveOrder.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(161)))), ((int)(((byte)(242)))));
            this.btnReceiveOrder.selected = true;
            this.btnReceiveOrder.Size = new System.Drawing.Size(259, 45);
            this.btnReceiveOrder.TabIndex = 14;
            this.btnReceiveOrder.Text = "   Receive Order";
            this.btnReceiveOrder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReceiveOrder.Textcolor = System.Drawing.Color.Gray;
            this.btnReceiveOrder.TextFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReceiveOrder.Click += new System.EventHandler(this.btnReceiveOrder_Click);
            // 
            // btnInventory
            // 
            this.btnInventory.Activecolor = System.Drawing.Color.White;
            this.btnInventory.BackColor = System.Drawing.Color.White;
            this.btnInventory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnInventory.BorderRadius = 0;
            this.btnInventory.ButtonText = "   Inventory";
            this.btnInventory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInventory.DisabledColor = System.Drawing.Color.Gray;
            this.btnInventory.Iconcolor = System.Drawing.Color.Transparent;
            this.btnInventory.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnInventory.Iconimage")));
            this.btnInventory.Iconimage_right = null;
            this.btnInventory.Iconimage_right_Selected = null;
            this.btnInventory.Iconimage_Selected = null;
            this.btnInventory.IconMarginLeft = 0;
            this.btnInventory.IconMarginRight = 0;
            this.btnInventory.IconRightVisible = true;
            this.btnInventory.IconRightZoom = 0D;
            this.btnInventory.IconVisible = true;
            this.btnInventory.IconZoom = 65D;
            this.btnInventory.IsTab = false;
            this.btnInventory.Location = new System.Drawing.Point(3, 558);
            this.btnInventory.Name = "btnInventory";
            this.btnInventory.Normalcolor = System.Drawing.Color.White;
            this.btnInventory.OnHovercolor = System.Drawing.Color.White;
            this.btnInventory.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(161)))), ((int)(((byte)(242)))));
            this.btnInventory.selected = true;
            this.btnInventory.Size = new System.Drawing.Size(259, 45);
            this.btnInventory.TabIndex = 15;
            this.btnInventory.Text = "   Inventory";
            this.btnInventory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInventory.Textcolor = System.Drawing.Color.Gray;
            this.btnInventory.TextFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInventory.Click += new System.EventHandler(this.btnInventory_Click);
            // 
            // btnReports
            // 
            this.btnReports.Activecolor = System.Drawing.Color.White;
            this.btnReports.BackColor = System.Drawing.Color.White;
            this.btnReports.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReports.BorderRadius = 0;
            this.btnReports.ButtonText = "   Reports";
            this.btnReports.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReports.DisabledColor = System.Drawing.Color.Gray;
            this.btnReports.Iconcolor = System.Drawing.Color.Transparent;
            this.btnReports.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnReports.Iconimage")));
            this.btnReports.Iconimage_right = null;
            this.btnReports.Iconimage_right_Selected = null;
            this.btnReports.Iconimage_Selected = null;
            this.btnReports.IconMarginLeft = 0;
            this.btnReports.IconMarginRight = 0;
            this.btnReports.IconRightVisible = true;
            this.btnReports.IconRightZoom = 0D;
            this.btnReports.IconVisible = true;
            this.btnReports.IconZoom = 65D;
            this.btnReports.IsTab = false;
            this.btnReports.Location = new System.Drawing.Point(3, 610);
            this.btnReports.Name = "btnReports";
            this.btnReports.Normalcolor = System.Drawing.Color.White;
            this.btnReports.OnHovercolor = System.Drawing.Color.White;
            this.btnReports.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(161)))), ((int)(((byte)(242)))));
            this.btnReports.selected = true;
            this.btnReports.Size = new System.Drawing.Size(259, 45);
            this.btnReports.TabIndex = 16;
            this.btnReports.Text = "   Reports";
            this.btnReports.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReports.Textcolor = System.Drawing.Color.Gray;
            this.btnReports.TextFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.White;
            this.panel.Location = new System.Drawing.Point(265, 72);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(1101, 698);
            this.panel.TabIndex = 6;
            this.panel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Paint);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 350;
            this.bunifuElipse1.TargetControl = this.imgProfilePicture;
            // 
            // Mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlSlidebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Mainform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Mainform_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlSlidebar.ResumeLayout(false);
            this.pnlSlidebar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSettings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgProfilePicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.indicator)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuCards pnlHeader;
        private System.Windows.Forms.Label label9;
        private User_Management1 User_Management;
        private User_Management1 User_Management1;
        private Bunifu.Framework.UI.BunifuCustomLabel lblTitle;
        private Bunifu.Framework.UI.BunifuCards pnlSlidebar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox picSettings;
        private Bunifu.Framework.UI.BunifuFlatButton btnPurchaseOrder;
        private Bunifu.Framework.UI.BunifuFlatButton btnItemManagement;
        private System.Windows.Forms.Label label10;
        private Bunifu.Framework.UI.BunifuImageButton imgProfilePicture;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox indicator;
        private Bunifu.Framework.UI.BunifuFlatButton btnDashboard;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private Bunifu.Framework.UI.BunifuFlatButton btnUserManagement;
        private Bunifu.Framework.UI.BunifuFlatButton btnSupplierManagement;
        private Bunifu.Framework.UI.BunifuFlatButton btnReceiveOrder;
        private Bunifu.Framework.UI.BunifuFlatButton btnInventory;
        private Bunifu.Framework.UI.BunifuFlatButton btnReports;
        private System.Windows.Forms.Panel panel;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton2;
    }
}


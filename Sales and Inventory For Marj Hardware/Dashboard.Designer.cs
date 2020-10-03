namespace Sales_and_Inventory_For_Marj_Hardware
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.btnReset = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.chartStockLevel = new LiveCharts.WinForms.CartesianChart();
            this.bunifuCards2 = new Bunifu.Framework.UI.BunifuCards();
            this.das = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.chartSlowMoving = new LiveCharts.WinForms.PieChart();
            this.chartFastMoving = new LiveCharts.WinForms.PieChart();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.card6 = new Bunifu.Framework.UI.BunifuCards();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.chartBestSeller = new Bunifu.DataViz.BunifuDataViz();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.card4 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.lblIncomeYear = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.dsa = new System.Windows.Forms.Label();
            this.card3 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.lblMonthIncome = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.card2 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.lblIncomeYesterday = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.card1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.lblIncomeToday = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.timerStock = new System.Windows.Forms.Timer(this.components);
            this.flowLayoutPanel1.SuspendLayout();
            this.bunifuCards1.SuspendLayout();
            this.bunifuCards2.SuspendLayout();
            this.card6.SuspendLayout();
            this.card4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.card3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.card2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.card1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.bunifuCards1);
            this.flowLayoutPanel1.Controls.Add(this.bunifuCards2);
            this.flowLayoutPanel1.Controls.Add(this.card6);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(239, 5);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(848, 689);
            this.flowLayoutPanel1.TabIndex = 12;
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.BackColor = System.Drawing.Color.White;
            this.bunifuCards1.BorderRadius = 5;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.Transparent;
            this.bunifuCards1.Controls.Add(this.btnReset);
            this.bunifuCards1.Controls.Add(this.bunifuCustomLabel2);
            this.bunifuCards1.Controls.Add(this.chartStockLevel);
            this.bunifuCards1.LeftSahddow = true;
            this.bunifuCards1.Location = new System.Drawing.Point(3, 3);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 30;
            this.bunifuCards1.Size = new System.Drawing.Size(823, 342);
            this.bunifuCards1.TabIndex = 4;
            // 
            // btnReset
            // 
            this.btnReset.Activecolor = System.Drawing.SystemColors.HotTrack;
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(161)))), ((int)(((byte)(242)))));
            this.btnReset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReset.BorderRadius = 0;
            this.btnReset.ButtonText = "RESET";
            this.btnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReset.DisabledColor = System.Drawing.Color.Gray;
            this.btnReset.Font = new System.Drawing.Font("Segoe UI Light", 10.25F, System.Drawing.FontStyle.Bold);
            this.btnReset.Iconcolor = System.Drawing.Color.Transparent;
            this.btnReset.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnReset.Iconimage")));
            this.btnReset.Iconimage_right = null;
            this.btnReset.Iconimage_right_Selected = null;
            this.btnReset.Iconimage_Selected = null;
            this.btnReset.IconMarginLeft = 0;
            this.btnReset.IconMarginRight = 0;
            this.btnReset.IconRightVisible = false;
            this.btnReset.IconRightZoom = 0D;
            this.btnReset.IconVisible = false;
            this.btnReset.IconZoom = 90D;
            this.btnReset.IsTab = false;
            this.btnReset.Location = new System.Drawing.Point(764, 2);
            this.btnReset.Margin = new System.Windows.Forms.Padding(0);
            this.btnReset.Name = "btnReset";
            this.btnReset.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(161)))), ((int)(((byte)(242)))));
            this.btnReset.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(161)))), ((int)(((byte)(242)))));
            this.btnReset.OnHoverTextColor = System.Drawing.Color.White;
            this.btnReset.selected = false;
            this.btnReset.Size = new System.Drawing.Size(59, 30);
            this.btnReset.TabIndex = 8;
            this.btnReset.Text = "RESET";
            this.btnReset.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnReset.Textcolor = System.Drawing.Color.White;
            this.btnReset.TextFont = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Bold);
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Segoe UI Light", 10.25F, System.Drawing.FontStyle.Bold);
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.DimGray;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(366, 7);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(129, 19);
            this.bunifuCustomLabel2.TabIndex = 7;
            this.bunifuCustomLabel2.Text = "CRITICAL STOCKS";
            // 
            // chartStockLevel
            // 
            this.chartStockLevel.Location = new System.Drawing.Point(12, 28);
            this.chartStockLevel.Name = "chartStockLevel";
            this.chartStockLevel.Size = new System.Drawing.Size(797, 305);
            this.chartStockLevel.TabIndex = 1;
            this.chartStockLevel.Text = "cartesianChart1";
            // 
            // bunifuCards2
            // 
            this.bunifuCards2.BackColor = System.Drawing.Color.White;
            this.bunifuCards2.BorderRadius = 5;
            this.bunifuCards2.BottomSahddow = true;
            this.bunifuCards2.color = System.Drawing.Color.White;
            this.bunifuCards2.Controls.Add(this.das);
            this.bunifuCards2.Controls.Add(this.bunifuSeparator1);
            this.bunifuCards2.Controls.Add(this.chartSlowMoving);
            this.bunifuCards2.Controls.Add(this.chartFastMoving);
            this.bunifuCards2.Controls.Add(this.bunifuCustomLabel4);
            this.bunifuCards2.LeftSahddow = true;
            this.bunifuCards2.Location = new System.Drawing.Point(832, 3);
            this.bunifuCards2.Name = "bunifuCards2";
            this.bunifuCards2.RightSahddow = true;
            this.bunifuCards2.ShadowDepth = 30;
            this.bunifuCards2.Size = new System.Drawing.Size(823, 351);
            this.bunifuCards2.TabIndex = 7;
            // 
            // das
            // 
            this.das.AutoSize = true;
            this.das.Font = new System.Drawing.Font("Segoe UI Light", 10.25F, System.Drawing.FontStyle.Bold);
            this.das.ForeColor = System.Drawing.Color.DimGray;
            this.das.Location = new System.Drawing.Point(544, 24);
            this.das.Name = "das";
            this.das.Size = new System.Drawing.Size(151, 19);
            this.das.TabIndex = 10;
            this.das.Text = "SLOW MOVING ITEM";
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(412, 10);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(20, 328);
            this.bunifuSeparator1.TabIndex = 7;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = true;
            this.bunifuSeparator1.Load += new System.EventHandler(this.bunifuSeparator1_Load);
            // 
            // chartSlowMoving
            // 
            this.chartSlowMoving.Location = new System.Drawing.Point(418, 46);
            this.chartSlowMoving.Name = "chartSlowMoving";
            this.chartSlowMoving.Size = new System.Drawing.Size(414, 290);
            this.chartSlowMoving.TabIndex = 9;
            this.chartSlowMoving.Text = "pieChart2";
            // 
            // chartFastMoving
            // 
            this.chartFastMoving.Location = new System.Drawing.Point(5, 46);
            this.chartFastMoving.Name = "chartFastMoving";
            this.chartFastMoving.Size = new System.Drawing.Size(414, 290);
            this.chartFastMoving.TabIndex = 8;
            this.chartFastMoving.Text = "pieChart1";
            this.chartFastMoving.ChildChanged += new System.EventHandler<System.Windows.Forms.Integration.ChildChangedEventArgs>(this.chartFastMoving_ChildChanged);
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Segoe UI Light", 10.25F, System.Drawing.FontStyle.Bold);
            this.bunifuCustomLabel4.ForeColor = System.Drawing.Color.DimGray;
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(135, 24);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(144, 19);
            this.bunifuCustomLabel4.TabIndex = 6;
            this.bunifuCustomLabel4.Text = "FAST MOVING ITEM";
            // 
            // card6
            // 
            this.card6.BackColor = System.Drawing.Color.White;
            this.card6.BorderRadius = 5;
            this.card6.BottomSahddow = true;
            this.card6.color = System.Drawing.Color.White;
            this.card6.Controls.Add(this.bunifuCustomLabel3);
            this.card6.Controls.Add(this.chartBestSeller);
            this.card6.LeftSahddow = true;
            this.card6.Location = new System.Drawing.Point(1661, 3);
            this.card6.Name = "card6";
            this.card6.RightSahddow = true;
            this.card6.ShadowDepth = 30;
            this.card6.Size = new System.Drawing.Size(823, 333);
            this.card6.TabIndex = 5;
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Segoe UI Light", 10.25F, System.Drawing.FontStyle.Bold);
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.DimGray;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(379, 8);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(110, 19);
            this.bunifuCustomLabel3.TabIndex = 6;
            this.bunifuCustomLabel3.Text = "SALES CHARTS";
            // 
            // chartBestSeller
            // 
            this.chartBestSeller.animationEnabled = false;
            this.chartBestSeller.AxisLineColor = System.Drawing.Color.Gray;
            this.chartBestSeller.AxisXFontColor = System.Drawing.SystemColors.HotTrack;
            this.chartBestSeller.AxisXGridColor = System.Drawing.Color.Gray;
            this.chartBestSeller.AxisXGridThickness = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.chartBestSeller.AxisYFontColor = System.Drawing.Color.Gray;
            this.chartBestSeller.AxisYGridColor = System.Drawing.Color.Gray;
            this.chartBestSeller.AxisYGridThickness = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.chartBestSeller.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.chartBestSeller.Location = new System.Drawing.Point(18, 8);
            this.chartBestSeller.Name = "chartBestSeller";
            this.chartBestSeller.Size = new System.Drawing.Size(785, 313);
            this.chartBestSeller.TabIndex = 1;
            this.chartBestSeller.Theme = Bunifu.DataViz.BunifuDataViz._theme.theme1;
            this.chartBestSeller.Title = "";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Segoe UI", 20.25F);
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.Gray;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(11, 13);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(222, 37);
            this.bunifuCustomLabel1.TabIndex = 11;
            this.bunifuCustomLabel1.Text = "Summary Income";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 300;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // card4
            // 
            this.card4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("card4.BackgroundImage")));
            this.card4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.card4.Controls.Add(this.lblIncomeYear);
            this.card4.Controls.Add(this.label14);
            this.card4.Controls.Add(this.pictureBox4);
            this.card4.Controls.Add(this.dsa);
            this.card4.GradientBottomLeft = System.Drawing.Color.Purple;
            this.card4.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.card4.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.card4.GradientTopRight = System.Drawing.Color.Purple;
            this.card4.Location = new System.Drawing.Point(18, 531);
            this.card4.Name = "card4";
            this.card4.Quality = 4;
            this.card4.Size = new System.Drawing.Size(209, 145);
            this.card4.TabIndex = 7;
            // 
            // lblIncomeYear
            // 
            this.lblIncomeYear.AutoSize = true;
            this.lblIncomeYear.BackColor = System.Drawing.Color.Transparent;
            this.lblIncomeYear.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIncomeYear.ForeColor = System.Drawing.Color.White;
            this.lblIncomeYear.Location = new System.Drawing.Point(47, 100);
            this.lblIncomeYear.Name = "lblIncomeYear";
            this.lblIncomeYear.Size = new System.Drawing.Size(25, 30);
            this.lblIncomeYear.TabIndex = 6;
            this.lblIncomeYear.Text = "0";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(28, 100);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(26, 30);
            this.label14.TabIndex = 7;
            this.label14.Text = "₱";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(33, 22);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(45, 45);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 4;
            this.pictureBox4.TabStop = false;
            // 
            // dsa
            // 
            this.dsa.AutoSize = true;
            this.dsa.BackColor = System.Drawing.Color.Transparent;
            this.dsa.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dsa.ForeColor = System.Drawing.Color.White;
            this.dsa.Location = new System.Drawing.Point(30, 70);
            this.dsa.Name = "dsa";
            this.dsa.Size = new System.Drawing.Size(113, 17);
            this.dsa.TabIndex = 0;
            this.dsa.Text = "Income This Year";
            // 
            // card3
            // 
            this.card3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("card3.BackgroundImage")));
            this.card3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.card3.Controls.Add(this.lblMonthIncome);
            this.card3.Controls.Add(this.label12);
            this.card3.Controls.Add(this.pictureBox3);
            this.card3.Controls.Add(this.label6);
            this.card3.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(229)))), ((int)(((byte)(151)))));
            this.card3.GradientBottomRight = System.Drawing.Color.Teal;
            this.card3.GradientTopLeft = System.Drawing.Color.SlateBlue;
            this.card3.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(229)))), ((int)(((byte)(151)))));
            this.card3.Location = new System.Drawing.Point(18, 376);
            this.card3.Name = "card3";
            this.card3.Quality = 4;
            this.card3.Size = new System.Drawing.Size(209, 145);
            this.card3.TabIndex = 8;
            // 
            // lblMonthIncome
            // 
            this.lblMonthIncome.AutoSize = true;
            this.lblMonthIncome.BackColor = System.Drawing.Color.Transparent;
            this.lblMonthIncome.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonthIncome.ForeColor = System.Drawing.Color.White;
            this.lblMonthIncome.Location = new System.Drawing.Point(47, 99);
            this.lblMonthIncome.Name = "lblMonthIncome";
            this.lblMonthIncome.Size = new System.Drawing.Size(25, 30);
            this.lblMonthIncome.TabIndex = 4;
            this.lblMonthIncome.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(28, 99);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(26, 30);
            this.label12.TabIndex = 5;
            this.label12.Text = "₱";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(33, 26);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(45, 45);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(30, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Income This Month";
            // 
            // card2
            // 
            this.card2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("card2.BackgroundImage")));
            this.card2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.card2.Controls.Add(this.lblIncomeYesterday);
            this.card2.Controls.Add(this.label1);
            this.card2.Controls.Add(this.pictureBox2);
            this.card2.Controls.Add(this.label4);
            this.card2.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(171)))), ((int)(((byte)(104)))));
            this.card2.GradientBottomRight = System.Drawing.Color.Purple;
            this.card2.GradientTopLeft = System.Drawing.Color.Crimson;
            this.card2.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(171)))), ((int)(((byte)(104)))));
            this.card2.Location = new System.Drawing.Point(18, 222);
            this.card2.Name = "card2";
            this.card2.Quality = 4;
            this.card2.Size = new System.Drawing.Size(209, 145);
            this.card2.TabIndex = 9;
            // 
            // lblIncomeYesterday
            // 
            this.lblIncomeYesterday.AutoSize = true;
            this.lblIncomeYesterday.BackColor = System.Drawing.Color.Transparent;
            this.lblIncomeYesterday.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIncomeYesterday.ForeColor = System.Drawing.Color.White;
            this.lblIncomeYesterday.Location = new System.Drawing.Point(47, 98);
            this.lblIncomeYesterday.Name = "lblIncomeYesterday";
            this.lblIncomeYesterday.Size = new System.Drawing.Size(25, 30);
            this.lblIncomeYesterday.TabIndex = 0;
            this.lblIncomeYesterday.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(28, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 30);
            this.label1.TabIndex = 3;
            this.label1.Text = "₱";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(33, 22);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(45, 45);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(30, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Income Yesterday";
            // 
            // card1
            // 
            this.card1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("card1.BackgroundImage")));
            this.card1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.card1.Controls.Add(this.lblIncomeToday);
            this.card1.Controls.Add(this.label13);
            this.card1.Controls.Add(this.pictureBox1);
            this.card1.Controls.Add(this.label2);
            this.card1.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(235)))), ((int)(((byte)(226)))));
            this.card1.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(166)))), ((int)(((byte)(245)))));
            this.card1.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.card1.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(206)))), ((int)(((byte)(234)))));
            this.card1.Location = new System.Drawing.Point(18, 69);
            this.card1.Name = "card1";
            this.card1.Quality = 4;
            this.card1.Size = new System.Drawing.Size(209, 145);
            this.card1.TabIndex = 10;
            // 
            // lblIncomeToday
            // 
            this.lblIncomeToday.AutoSize = true;
            this.lblIncomeToday.BackColor = System.Drawing.Color.Transparent;
            this.lblIncomeToday.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIncomeToday.ForeColor = System.Drawing.Color.White;
            this.lblIncomeToday.Location = new System.Drawing.Point(47, 98);
            this.lblIncomeToday.Name = "lblIncomeToday";
            this.lblIncomeToday.Size = new System.Drawing.Size(25, 30);
            this.lblIncomeToday.TabIndex = 0;
            this.lblIncomeToday.Text = "0";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(28, 98);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(26, 30);
            this.label13.TabIndex = 4;
            this.label13.Text = "₱";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(33, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(30, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Income Today";
            // 
            // timerStock
            // 
            this.timerStock.Enabled = true;
            this.timerStock.Interval = 4500;
            this.timerStock.Tick += new System.EventHandler(this.timerStock_Tick_1);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1098, 698);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.card4);
            this.Controls.Add(this.card3);
            this.Controls.Add(this.card2);
            this.Controls.Add(this.card1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.bunifuCards1.ResumeLayout(false);
            this.bunifuCards1.PerformLayout();
            this.bunifuCards2.ResumeLayout(false);
            this.bunifuCards2.PerformLayout();
            this.card6.ResumeLayout(false);
            this.card6.PerformLayout();
            this.card4.ResumeLayout(false);
            this.card4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.card3.ResumeLayout(false);
            this.card3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.card2.ResumeLayout(false);
            this.card2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.card1.ResumeLayout(false);
            this.card1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
        private LiveCharts.WinForms.CartesianChart chartStockLevel;
        private Bunifu.Framework.UI.BunifuCards card6;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.DataViz.BunifuDataViz chartBestSeller;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuGradientPanel card4;
        private System.Windows.Forms.Label lblIncomeYear;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label dsa;
        private Bunifu.Framework.UI.BunifuGradientPanel card3;
        private System.Windows.Forms.Label lblMonthIncome;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label6;
        private Bunifu.Framework.UI.BunifuGradientPanel card2;
        private System.Windows.Forms.Label lblIncomeYesterday;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuGradientPanel card1;
        private System.Windows.Forms.Label lblIncomeToday;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private System.Windows.Forms.Timer timerStock;
        private Bunifu.Framework.UI.BunifuCards bunifuCards2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuCustomLabel das;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private LiveCharts.WinForms.PieChart chartSlowMoving;
        private LiveCharts.WinForms.PieChart chartFastMoving;
        private Bunifu.Framework.UI.BunifuFlatButton btnReset;
    }
}
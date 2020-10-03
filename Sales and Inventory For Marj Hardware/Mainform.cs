using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.DataViz;
using MySql.Data.MySqlClient;
using LiveCharts;
using LiveCharts.Defaults;
using LiveCharts.Wpf;

namespace Sales_and_Inventory_For_Marj_Hardware
{
    public partial class Mainform : Form
    {
        MySqlConnection conn = new MySqlConnection("SERVER = localhost; USERNAME = root; PASSWORD = ; DATABASE = marj_hardware");
        public static Boolean wew = true;
        public Mainform()
        {
            InitializeComponent();


            Panel p = panel as Panel;

            if (p != null)
            {
                while (panel.Controls.Count > 0)
                {
                    panel.Controls[0].Dispose();
                }

                Dashboard dash = new Dashboard();
                dash.FormBorderStyle = FormBorderStyle.None;
                dash.TopLevel = false;
                dash.AutoScroll = true;
                panel.Controls.Add(dash);
                dash.Show();
            }
            //bunifuDataViz1.colorSet.Add(Color.FromArgb(66, 299, 151));
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
          

        }

        //void toogle(object sender)
        //{

        //    btnDashboard.Textcolor = Color.Gray;
        //    btnUserManagement.Textcolor = Color.Gray;
           

        //    ((Bunifu.Framework.UI.BunifuFlatButton)sender).Textcolor = Color.FromArgb(29, 161, 242);
        //}

        private void Mainform_Load(object sender, EventArgs e)
        {

        }



        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            indicator.Top = ((Control)sender).Top;
            indicator.Height = ((Control)sender).Height;

            Panel p = panel as Panel;

            if (p != null)
            {
                while (panel.Controls.Count > 0)
                {
                    panel.Controls[0].Dispose();
                }

                Dashboard dash = new Dashboard();
                dash.FormBorderStyle = FormBorderStyle.None;
                dash.TopLevel = false;
                dash.AutoScroll = true;
                panel.Controls.Add(dash);
                dash.Show();
            }
        }

        private void btnUserManagement_Click(object sender, EventArgs e)
        {
            
            indicator.Top = ((Control)sender).Top;
            indicator.Height = ((Control)sender).Height;
            Panel p = panel as Panel;

            if (p != null)
            {
                while (panel.Controls.Count > 0)
                {
                    panel.Controls[0].Dispose();
                }

                User_Management user = new User_Management();
                user.FormBorderStyle = FormBorderStyle.None;
                user.TopLevel = false;
                user.AutoScroll = true;
                panel.Controls.Add(user);
                user.Show();
            }
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {

        }

        private void btnMaintenance_Click(object sender, EventArgs e)
        {
        }

        private void btnSupplierManagement_Click(object sender, EventArgs e)
        {
            indicator.Top = ((Control)sender).Top;
            indicator.Height = ((Control)sender).Height;

            Panel p = panel as Panel;

            if (p != null)
            {
                while (panel.Controls.Count > 0)
                {
                    panel.Controls[0].Dispose();
                }

                Supplier_Management supplier = new Supplier_Management();
                supplier.FormBorderStyle = FormBorderStyle.None;
                supplier.TopLevel = false;
                supplier.AutoScroll = true;
                panel.Controls.Add(supplier);
                supplier.Show();
            }

        }

        private void btnItemManagement_Click(object sender, EventArgs e)
        {
            indicator.Top = ((Control)sender).Top;
            indicator.Height = ((Control)sender).Height;

            Panel p = panel as Panel;

            if (p != null)
            {
                while (panel.Controls.Count > 0)
                {
                    panel.Controls[0].Dispose();
                }

                Product_Entry entry = new Product_Entry();
                entry.FormBorderStyle = FormBorderStyle.None;
                entry.TopLevel = false;
                entry.AutoScroll = true;
                panel.Controls.Add(entry);
                entry.Show();
            }
        }

        private void btnPurchaseOrder_Click(object sender, EventArgs e)
        {
            indicator.Top = ((Control)sender).Top;
            indicator.Height = ((Control)sender).Height;

            Panel p = panel as Panel;

            if (p != null)
            {
                while (panel.Controls.Count > 0)
                {
                    panel.Controls[0].Dispose();
                }

                Purchase_Order po = new Purchase_Order();
                po.FormBorderStyle = FormBorderStyle.None;
                po.TopLevel = false;
                po.AutoScroll = true;
                panel.Controls.Add(po);
                po.Show();
            }
        }

        private void picSettings_Click(object sender, EventArgs e)
        {
            Maintenance main = new Maintenance();
            main.ShowDialog();
        }

        private void btnReceiveOrder_Click(object sender, EventArgs e)
        {
            panel.Visible = true;

            indicator.Top = ((Control)sender).Top;
            indicator.Height = ((Control)sender).Height;

            Panel p = panel as Panel;

            if (p != null)
            {
                while (panel.Controls.Count > 0)
                {
                    panel.Controls[0].Dispose();
                }

                Receive_Order receive = new Receive_Order();
                receive.FormBorderStyle = FormBorderStyle.None;
                receive.TopLevel = false;
                receive.AutoScroll = true;
                panel.Controls.Add(receive);
                receive.Show();
            }

        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            indicator.Top = ((Control)sender).Top;
            indicator.Height = ((Control)sender).Height;

            Panel p = panel as Panel;

            if (p != null)
            {
                while (panel.Controls.Count > 0)
                {
                    panel.Controls[0].Dispose();
                }

                Inventory inven = new Inventory();
                inven.FormBorderStyle = FormBorderStyle.None;
                inven.TopLevel = false;
                inven.AutoScroll = true;
                panel.Controls.Add(inven);
                inven.Show();
            }
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            indicator.Top = ((Control)sender).Top;
            indicator.Height = ((Control)sender).Height;

            Panel p = panel as Panel;

            if (p != null)
            {
                while (panel.Controls.Count > 0)
                {
                    panel.Controls[0].Dispose();
                }

                Sales_Reports sales = new Sales_Reports();
                sales.FormBorderStyle = FormBorderStyle.None;
                sales.TopLevel = false;
                sales.AutoScroll = true;
                panel.Controls.Add(sales);
                sales.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuFlatButton2_Click_1(object sender, EventArgs e)
        {
            Panel p = panel as Panel;

            if (p != null)
            {
                while (panel.Controls.Count > 0)
                {
                    panel.Controls[0].Dispose();
                }

                Purchase_Reports reports = new Purchase_Reports();
                reports.FormBorderStyle = FormBorderStyle.None;
                reports.TopLevel = false;
                reports.AutoScroll = true;
                panel.Controls.Add(reports);
                reports.Show();
            }
        }

        private void imgProfilePicture_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}

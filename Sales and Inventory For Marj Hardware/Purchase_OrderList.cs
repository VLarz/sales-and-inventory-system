using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Drawing.Printing;
using DGVPrinterHelper;
using MaterialSkin;
using MaterialSkin.Controls;
using MaterialSkin.Animations;

namespace Sales_and_Inventory_For_Marj_Hardware
{
    public partial class Purchase_OrderList : MaterialSkin.Controls.MaterialForm
    {
        MaterialSkinManager skinManager;
        MySqlConnection conn = new MySqlConnection("SERVER = localhost; USERNAME = root; PASSWORD =; DATABASE = marj_hardware");
       
        public static string barcodeNum;

        public static string getEmail;
        public Purchase_OrderList()
        {
            InitializeComponent();
            skinManager = MaterialSkinManager.Instance;
            SkinManager.AddFormToManage(this);
            SkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            SkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Blue800, MaterialSkin.Primary.Blue900, MaterialSkin.Primary.Blue900, MaterialSkin.Accent.Orange700, MaterialSkin.TextShade.WHITE);
            showOrderList();
            getTotalPrice();
            getTotalItem();
            getPurchaseNo();
        }

        //METHODS
        private void showOrderList()
        {
            conn.Open();
            MySqlCommand scom = conn.CreateCommand();
            scom.CommandText = "SELECT * FROM purchase_order";
            MySqlDataAdapter sda = new MySqlDataAdapter(scom);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            conn.Close();
            dgvOrderList.DataSource = dt;
            if(dgvOrderList.Rows.Count > 0)
            {
                dgvOrderList.Rows[0].Selected = false;
            }
        }

        private void getTotalPrice()
        {
            if(dgvOrderList.Rows.Count > 0)
            {
                conn.Open();
                MySqlCommand scom = conn.CreateCommand();
                scom.CommandText = "SELECT SUM(total_price) AS 'Total Price' FROM purchase_order";
                try
                {
                    MySqlDataReader dr = scom.ExecuteReader();
                    while (dr.Read())
                    {
                        String gprice = dr["Total Price"].ToString();
                        txtTotalPrice.Text = gprice;
                    }
                    dr.Close();
                    conn.Close();
                }
                catch (Exception a)
                {
                    MessageBox.Show(a.Message);
                }
            }     
        }

        private void getTotalItem()
        {
            if(dgvOrderList.Rows.Count > 0)
            {
                conn.Open();
                MySqlCommand scom = conn.CreateCommand();
                scom.CommandText = "SELECT SUM(quantity) AS 'Total Item' FROM purchase_order";
                try
                {
                    MySqlDataReader dr = scom.ExecuteReader();
                    while (dr.Read())
                    {
                        String gprice = dr["Total Item"].ToString();
                        Double generatetotalprice = Convert.ToDouble(gprice);
                        txtTotalItems.Text = Convert.ToString(generatetotalprice);
                    }
                    dr.Close();
                    conn.Close();
                }
                catch (Exception a)
                {
                    MessageBox.Show(a.Message);
                }
            }
        }

        private void getPurchaseNo()
        {
            try
            {
                conn.Open();
                MySqlCommand scom = conn.CreateCommand();
                scom.CommandText = "SELECT max(purchase_no) + 1 as 'PurchaseNo' FROM purchase_report";
                MySqlDataReader dr = scom.ExecuteReader();
                while (dr.Read())
                {
                    lblPurchaseNo.Text = dr.GetString("PurchaseNo");

                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

        private void Purchase_OrderList_Load(object sender, EventArgs e)
        {
            lblSupplier.Text = Purchase_Order.getSupplier1;
        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel5_Click(object sender, EventArgs e)
        {

        }

        private void btnOrderNow_Click(object sender, EventArgs e)
        {
            if(dgvOrderList.Rows.Count> 0)
            {
                DialogResult ask = MessageBox.Show("Do you want to send your order via Email?", "Purchase Order", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (ask == DialogResult.Yes)
                {
                    getEmail = lblSupplier.Text;
                    Send_To_Gmail send = new Send_To_Gmail();
                    send.ShowDialog();

                }
                foreach (DataGridViewRow order in dgvOrderList.Rows)
                {
                    //try
                    //{
                        conn.Open();
                        MySqlCommand scom = conn.CreateCommand();
                        scom.CommandText = "INSERT INTO order_list (purchase_no, supplier, barcode, name, brand, category, description, cost_price, selling_price, quantity, total_price, purchase_date) VALUES (@purchase_no, @supplier, @barcode, @name, @brand, @category, @description, @costPrice, @sellingPrice, @quantity, @total_price, @date)";
                        scom.Parameters.AddWithValue("@purchase_no", lblPurchaseNo.Text);
                        scom.Parameters.AddWithValue("@supplier", order.Cells["supplierName"].Value);
                        scom.Parameters.AddWithValue("@barcode", order.Cells["barcode"].Value);
                        scom.Parameters.AddWithValue("@name", order.Cells["itemName"].Value);
                        scom.Parameters.AddWithValue("@brand", order.Cells["brand"].Value);
                        scom.Parameters.AddWithValue("@category", order.Cells["category"].Value);
                        scom.Parameters.AddWithValue("@description", order.Cells["description"].Value);
                        scom.Parameters.AddWithValue("@costPrice", order.Cells["costPrice"].Value);
                        scom.Parameters.AddWithValue("@sellingPrice", order.Cells["sellingPrice"].Value);
                        scom.Parameters.AddWithValue("@quantity", order.Cells["quantity"].Value);
                        scom.Parameters.AddWithValue("@total_price", order.Cells["totalPrice"].Value);
                        scom.Parameters.AddWithValue("@date", System.DateTime.Now.ToString("yyyy/MM/dd"));
                        scom.ExecuteNonQuery();
                        conn.Close();


                        conn.Open();
                        MySqlCommand scom1 = conn.CreateCommand();
                        scom1.CommandText = "INSERT INTO purchase_report (purchase_no, supplier, barcode, name, brand, category, description, cost_price, quantity, total_price, status, date_purchased) VALUES (@purchase_no, @supplier, @barcode, @name, @brand, @category, @description, @price, @quantity, @total_price, @status, @date)";
                        scom1.Parameters.AddWithValue("@purchase_no", lblPurchaseNo.Text);
                        scom1.Parameters.AddWithValue("@supplier", order.Cells["supplierName"].Value);
                        scom1.Parameters.AddWithValue("@barcode", order.Cells["barcode"].Value);
                        scom1.Parameters.AddWithValue("@name", order.Cells["itemName"].Value);
                        scom1.Parameters.AddWithValue("@brand", order.Cells["brand"].Value);
                        scom1.Parameters.AddWithValue("@category", order.Cells["category"].Value);
                        scom1.Parameters.AddWithValue("@description", order.Cells["description"].Value);
                        scom1.Parameters.AddWithValue("@price", order.Cells["costPrice"].Value);
                        scom1.Parameters.AddWithValue("@quantity", order.Cells["quantity"].Value);
                        scom1.Parameters.AddWithValue("@total_price", order.Cells["totalPrice"].Value);
                        scom1.Parameters.AddWithValue("@status", "Pending");
                        scom1.Parameters.AddWithValue("@date", System.DateTime.Now.ToString("yyyy/MM/dd"));
                        scom1.ExecuteNonQuery();
                        conn.Close();
                    //}
                    //catch (Exception ex)
                    //{
                    //    MessageBox.Show(ex.Message);
                    //}
                }
                conn.Open();
                MySqlCommand scom2 = conn.CreateCommand();
                scom2.CommandText = "DELETE FROM purchase_order";
                scom2.ExecuteNonQuery();
                conn.Close();
                alert.Show("Successfully ordered an item.", alert.AlertType.success);
                showOrderList();
            }
            else
            {
                alert.Show("Please buy an item first.", alert.AlertType.warning);
            }
           
        }

        private void bunifuCards4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnPrintPDF_Click(object sender, EventArgs e)
        {
            if(dgvOrderList.Rows.Count > 0)
            {
                DGVPrinter print = new DGVPrinter();
                print.Title = "Purchase Order List";
                print.SubTitle = string.Format("Date: {0}", DateTime.Now.Date.ToLongDateString());
                print.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
                print.PageNumbers = true;
                print.PageNumberInHeader = false;
                print.PorportionalColumns = true;
                print.HeaderCellAlignment = StringAlignment.Near;
                print.Footer = "MARJ HARDWARE";
                print.FooterSpacing = 15;
                print.printDocument.DefaultPageSettings.Landscape = true;
                print.PrintDataGridView(dgvOrderList);
            }   
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtTotalPrice_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void btnContinueOrdering_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void dgvOrderList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgvOrderList.Rows.Count > 0)
            {
                barcodeNum = Convert.ToString(dgvOrderList.CurrentRow.Cells["barcode"].Value);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if(barcodeNum != null)
            {
                if (dgvOrderList.Rows.Count > 0)
                {
                    conn.Open();
                    MySqlCommand scom = conn.CreateCommand();
                    scom.CommandText = "DELETE FROM purchase_order WHERE barcode = @barcode";
                    scom.Parameters.AddWithValue("@barcode", barcodeNum);
                    scom.ExecuteNonQuery();
                    conn.Close();

                    alert.Show("Successfully Removed.", alert.AlertType.success);
                    showOrderList();
                    getTotalItem();
                    getTotalPrice();
                }
            }
            else
            {
                alert.Show("Please select an item.", alert.AlertType.warning);
            }
           
        }

        private void btnRemoveAll_Click(object sender, EventArgs e)
        {
            DialogResult ask = MessageBox.Show("Are you sure you want to remove all?", "Purchase Order", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(ask == DialogResult.Yes)
            {
                conn.Open();
                MySqlCommand scom = conn.CreateCommand();
                scom.CommandText = "DELETE FROM purchase_order";
                scom.ExecuteNonQuery();
                conn.Close();
                alert.Show("Successfully Removed", alert.AlertType.success);
                showOrderList();
            }
        }


        private void btnSendOrder_Click(object sender, EventArgs e)
        {
            
        }
    }
}

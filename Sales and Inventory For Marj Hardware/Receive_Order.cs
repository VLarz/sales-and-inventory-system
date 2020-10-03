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

namespace Sales_and_Inventory_For_Marj_Hardware
{
    public partial class Receive_Order : Form
    {
        MySqlConnection conn = new MySqlConnection("SERVER = localhost; USERNAME = root; PASSWORD = ; DATABASE = marj_hardware");
        public static string getID;
        public static string getPO;
        public static string getName;
        public static string description1;
        public static string supplier;
        public static string getBarcode;
        public Receive_Order()
        {
            InitializeComponent();
            showSupplierList();
            getCurrentVAT();
            timer1.Start();
        }
        //METHODS
        private void showItemOrderList()
        {
            conn.Open();
            MySqlCommand scom = conn.CreateCommand();
            scom.CommandText = "SELECT id, purchase_no, name, brand, category, description, cost_price, quantity, total_price, purchase_date FROM order_list WHERE supplier = @supplier AND barcode = ''";
            scom.Parameters.AddWithValue("@supplier", supplier);
            MySqlDataAdapter sda = new MySqlDataAdapter(scom);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dgvOrderList.DataSource = dt;
            conn.Close();
            if(dgvOrderList.Rows.Count > 0)
            {
                dgvOrderList.Rows[0].Selected = false;
            }
            dgvOrderList.Visible = true;
            dgvOrderList1.Visible = false;
        }

        private void showProductOrderList()
        {
            conn.Open();
            MySqlCommand scom = conn.CreateCommand();
            scom.CommandText = "SELECT id, purchase_no, barcode, name, brand, category, description, cost_price, selling_price, quantity, total_price, purchase_date FROM order_list WHERE supplier = @supplier AND barcode != ''";
            scom.Parameters.AddWithValue("@supplier", supplier);
            MySqlDataAdapter sda = new MySqlDataAdapter(scom);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dgvOrderList1.DataSource = dt;
            conn.Close();
            if (dgvOrderList1.Rows.Count > 0)
            {
                dgvOrderList1.Rows[0].Selected = false;
            }
            dgvOrderList.Visible = false;
            dgvOrderList1.Visible = true;          
        }

        private void showSupplierList()
        {
            conn.Open();
            MySqlCommand scom = conn.CreateCommand();
            scom.CommandText = "SELECT DISTINCT supplier FROM order_list";
            MySqlDataAdapter sda = new MySqlDataAdapter(scom);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dgvSupplierList.DataSource = dt;
            conn.Close();
            if (dgvSupplierList.Rows.Count > 0)
            {
                dgvSupplierList.Rows[0].Selected = false;
            }
        }

        private void generateRandomNumbers()
        {
            var randomNumbers = new List<int>();
            var randomGenerator = new Random();
            int initialCount = 1;
            string num1 = "";
            string num2 = "";

            for (int i = 0; i <= 5; i++)
            {
                while (initialCount <= 5)
                {
                    int num = randomGenerator.Next(1000, 999999999);
                    if (!randomNumbers.Contains(num))
                    {
                        randomNumbers.Add(num);
                        initialCount++;
                    }
                }
            }
            randomNumbers.Sort();
            randomNumbers.ForEach(x => num1 = x.ToString());

            var randomNumbers1 = new List<int>();
            var randomGenerator1 = new Random();
            int initialCount1 = 1;
            for (int i = 0; i <= 5; i++)
            {
                while (initialCount1 <= 5)
                {
                    int num5 = randomGenerator1.Next(100, 999);
                    if (!randomNumbers.Contains(num5))
                    {
                        randomNumbers1.Add(num5);
                        initialCount1++;
                    }
                }
            }
            randomNumbers1.Sort();
            randomNumbers1.ForEach(x => num2 = x.ToString());

            string[] combine = new String[] { num1, num2 };
            string combine1 = String.Join("", combine);
            txtBarcode.Text = combine1;
        }

        private void getCurrentVAT()
        {
            try
            {
                conn.Open();
                MySqlCommand scom = conn.CreateCommand();
                scom.CommandText = "SELECT current_vat FROM VAT WHERE id = 1";
                MySqlDataReader dr = scom.ExecuteReader();
                while (dr.Read())
                {
                    lblVat.Text = dr.GetString("current_VAT");

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

        private void btnOrderNow_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Receive_Order_Load(object sender, EventArgs e)
        {
            if(dgvSupplierList.Rows.Count > 0)
            {
                dgvSupplierList.Rows[0].Selected = false;
            }
        }    
        private void dgvOrderList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgvOrderList.Rows.Count > 0)
            {
                txtItemName.Text = dgvOrderList.CurrentRow.Cells["itemName"].Value.ToString();
                txtCategory.Text = dgvOrderList.CurrentRow.Cells["category"].Value.ToString();
                txtBrand.Text = dgvOrderList.CurrentRow.Cells["brand"].Value.ToString();
                txtQuantity.Text = dgvOrderList.CurrentRow.Cells["quantity"].Value.ToString();
                txtSetQuantity.Text = dgvOrderList.CurrentRow.Cells["quantity"].Value.ToString();
                txtCostPrice.Text = dgvOrderList.CurrentRow.Cells["costPrice"].Value.ToString();
                getID = dgvOrderList.CurrentRow.Cells["id"].Value.ToString();
                getPO = dgvOrderList.CurrentRow.Cells["purchaseNo"].Value.ToString();
                getName = dgvOrderList.CurrentRow.Cells["itemName"].Value.ToString();
                
                cmbMarkUp.Enabled = true;
                txtSellingPrice.Text = "";
            }
        }

        private void btnReceiveItem_Click(object sender, EventArgs e)
        {
            if (txtItemName.Text != "")
            {
                if(txtSellingPrice.Text != "")
                {
                    if (txtBarcode.Text != "" || chkNoBarcode.Checked == true)
                    {
                        if (txtSetQuantity.Text != "" && txtQuantity.Text != "0")
                        {
                            if (Convert.ToInt32(txtQuantity.Text) < Convert.ToInt32(txtSetQuantity.Text))
                            {
                                alert.Show("You exceed to quantity you ordered", alert.AlertType.warning);
                            }
                            else
                            {
                                if (Convert.ToInt32(txtQuantity.Text) == Convert.ToInt32(txtSetQuantity.Text))
                                {
                                    if(chkNoBarcode.Checked == true)
                                    {
                                        getBarcode = "";
                                    }
                                    else
                                    {
                                        getBarcode = txtBarcode.Text;
                                    }
                                    MySqlCommand scom = new MySqlCommand("SELECT * FROM product WHERE name = @name AND brand = @brand AND category = @category AND supplier = @supplier OR supplier IS NULL", conn);
                                    scom.Parameters.AddWithValue("@supplier", supplier);
                                    scom.Parameters.AddWithValue("@name", txtItemName.Text);
                                    scom.Parameters.AddWithValue("@brand", txtBrand.Text);
                                    scom.Parameters.AddWithValue("@category", txtCategory.Text);
                                    MySqlDataAdapter sda = new MySqlDataAdapter(scom);
                                    DataSet ds = new DataSet();
                                    sda.Fill(ds);
                                    int i = ds.Tables[0].Rows.Count;
                                    if (i > 0)
                                    {
                                        //try
                                        //{
                                            conn.Open();
                                        MySqlCommand scom2 = conn.CreateCommand();
                                        scom2.CommandText = "UPDATE product SET barcode = @barcode, stocks = stocks + @stocks1, selling_price = @selling_price, kind = 'Product', supplier = @supplier WHERE name = @name AND brand = @brand AND category = @category AND supplier = @supplier OR supplier IS NULL";
                                        scom2.Parameters.AddWithValue("@barcode", getBarcode);
                                        scom2.Parameters.AddWithValue("@name", txtItemName.Text);
                                        scom2.Parameters.AddWithValue("@brand", txtBrand.Text);
                                        scom2.Parameters.AddWithValue("@category", txtCategory.Text);
                                        scom2.Parameters.AddWithValue("@stocks1", txtSetQuantity.Text);
                                        scom2.Parameters.AddWithValue("@selling_price", txtSellingPrice.Text);
                                        scom2.Parameters.AddWithValue("@supplier", supplier);
                                        scom2.ExecuteNonQuery();
                                        conn.Close();
                                        ds.Clear();

                                        conn.Open();
                                        MySqlCommand scom3 = conn.CreateCommand();
                                        scom3.CommandText = "UPDATE purchase_report SET status = 'Accepted', date_received = @received, quantity_received = @quantity WHERE purchase_no = @po AND name = @name";
                                        scom3.Parameters.AddWithValue("@received", System.DateTime.Now.ToString("yyyy/MM/dd"));
                                        scom3.Parameters.AddWithValue("@po", getPO);
                                        scom3.Parameters.AddWithValue("@name", getName);
                                        scom3.Parameters.AddWithValue("@quantity", txtSetQuantity.Text);
                                        scom3.ExecuteNonQuery();
                                        conn.Close();

                                        conn.Open();
                                        MySqlCommand scom4 = conn.CreateCommand();
                                        scom4.CommandText = "DELETE FROM order_list WHERE id = @id";
                                        scom4.Parameters.AddWithValue("@id", getID);
                                        scom4.ExecuteNonQuery();
                                        conn.Close();

                                        alert.Show("Successfully Added To Inventory.", alert.AlertType.success);
                                        showProductOrderList();
                                        showItemOrderList();
                                        showSupplierList();
                             
                                        //}
                                        //catch (Exception ex)
                                        //{
                                        //    MessageBox.Show(ex.Message);
                                        //}
                                    }
                                }
                                else
                                {
                                    int quantity = Convert.ToInt32(txtQuantity.Text);
                                    int setQuantity = Convert.ToInt32(txtSetQuantity.Text);
                                    decimal price = Convert.ToDecimal(txtCostPrice.Text);
                                    int backorder = quantity - setQuantity;
                                    decimal total = price * quantity;

                                    MySqlCommand scom5 = new MySqlCommand("SELECT * FROM product WHERE name = @name AND brand = @brand AND category = @category AND supplier = @supplier OR supplier IS NULL", conn);
                                    scom5.Parameters.AddWithValue("@name", txtItemName.Text);
                                    scom5.Parameters.AddWithValue("@brand", txtBrand.Text);
                                    scom5.Parameters.AddWithValue("@category", txtCategory.Text);
                                    scom5.Parameters.AddWithValue("@supplier", supplier);
                                    MySqlDataAdapter sda1 = new MySqlDataAdapter(scom5);
                                    DataSet ds1 = new DataSet();
                                    sda1.Fill(ds1);
                                    int i1 = ds1.Tables[0].Rows.Count;
                                    if (i1 > 0)
                                    {
                                        //try
                                        //{
                                            conn.Open();
                                            MySqlCommand scom6 = conn.CreateCommand();
                                            scom6.CommandText = "UPDATE product SET barcode = @barcode, stocks = stocks + @stocks1, selling_price = @selling_price, kind = 'Product', supplier = @supplier WHERE name = @name AND brand = @brand AND category = @category AND supplier = @supplier OR supplier IS NULL";
                                            scom6.Parameters.AddWithValue("@barcode", getBarcode);
                                            scom6.Parameters.AddWithValue("@name", txtItemName.Text);
                                            scom6.Parameters.AddWithValue("@brand", txtBrand.Text);
                                            scom6.Parameters.AddWithValue("@category", txtCategory.Text);
                                            scom6.Parameters.AddWithValue("@stocks1", txtSetQuantity.Text);
                                            scom6.Parameters.AddWithValue("@selling_price", txtSellingPrice.Text);
                                            scom6.Parameters.AddWithValue("@supplier", supplier);
                                            scom6.ExecuteNonQuery();
                                            conn.Close();
                                            ds1.Clear();

                                            conn.Open();
                                            MySqlCommand scom7 = conn.CreateCommand();
                                            scom7.CommandText = "UPDATE purchase_report SET status = 'Accepted', date_received = @received, quantity_received = @quantity WHERE purchase_no = @po AND name = @name";
                                            scom7.Parameters.AddWithValue("@received", System.DateTime.Now.ToString("yyyy/MM/dd"));
                                            scom7.Parameters.AddWithValue("@po", getPO);
                                            scom7.Parameters.AddWithValue("@name", getName);
                                            scom7.Parameters.AddWithValue("@quantity", txtSetQuantity.Text);
                                            scom7.ExecuteNonQuery();
                                            conn.Close();

                                            conn.Open();
                                            MySqlCommand scom8 = conn.CreateCommand();
                                            scom8.CommandText = "INSERT INTO back_order (purchase_no, supplier, barcode, name, brand, category, cost_price, quantity, total_price, date) VALUES (@po, @supplier, @barcode, @name, @brand, @category, @cost_price, @quantity, @total_price, @date)";
                                            scom8.Parameters.AddWithValue("@po", getPO);
                                            scom8.Parameters.AddWithValue("@barcode", getBarcode);
                                            scom8.Parameters.AddWithValue("@supplier", lblCompanyName.Text);
                                            scom8.Parameters.AddWithValue("@name", txtItemName.Text);
                                            scom8.Parameters.AddWithValue("@brand", txtBrand.Text);
                                            scom8.Parameters.AddWithValue("@category", txtCategory.Text);
                                            scom8.Parameters.AddWithValue("@cost_price", txtCostPrice.Text);
                                            scom8.Parameters.AddWithValue("@quantity", backorder);
                                            scom8.Parameters.AddWithValue("@total_price", total);
                                            scom8.Parameters.AddWithValue("@date", System.DateTime.Now.ToString("yyyy/MM/dd"));
                                            scom8.ExecuteNonQuery();
                                            conn.Close();

                                            conn.Open();
                                            MySqlCommand scom9 = conn.CreateCommand();
                                            scom9.CommandText = "DELETE FROM order_list WHERE id = @id";
                                            scom9.Parameters.AddWithValue("@id", getID);
                                            scom9.ExecuteNonQuery();
                                            conn.Close();

                                            alert.Show("Successfully Added To Inventory.", alert.AlertType.success);
                                            showProductOrderList();
                                            showItemOrderList();
                                            showSupplierList();
                                            //cmbMarkUp.SelectedIndex = -1;
                                        }
                                    //    catch (Exception ex)
                                    //    {
                                    //        MessageBox.Show(ex.Message);
                                    //    }
                                    //}
                                }
                            }
                        }
                        else
                        {
                            alert.Show("Please set quantity.", alert.AlertType.warning);
                        }
                    }
                    else
                    {
                        alert.Show("Please input barcode.", alert.AlertType.warning);               
                    } 
                }
                else
                {
                        alert.Show("Please choose mark up.", alert.AlertType.warning);
                }                
            }
            else
            {
                alert.Show("Please select an item.", alert.AlertType.warning);
            }
        }

        private void txtSetQuantity_OnValueChanged(object sender, EventArgs e)
        {
            if (txtItemName.Text != "")
            {
                txtSetQuantity.Enabled = true;
            }
            else
            {
                txtSetQuantity.Enabled = false;
            }
        }

        private void btnReceiveAll_Click(object sender, EventArgs e)
        {
            
        }

        private void chkItem_OnChange(object sender, EventArgs e)
        {
            txtBarcode.Enabled = true;
            chkProduct.Checked = false;
            btnReceiveAll1.Visible = false;
            showItemOrderList();
        }

        private void chkProduct_OnChange(object sender, EventArgs e)
        {
            txtBarcode.Enabled = false;
            chkItem.Checked = false;
            btnReceiveAll1.Visible = true;
            showProductOrderList();
        }

        private void dgvOrderList1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvOrderList1.Rows.Count > 0)
            {
                txtItemName.Text = dgvOrderList1.CurrentRow.Cells["itemName1"].Value.ToString();
                txtCategory.Text = dgvOrderList1.CurrentRow.Cells["category1"].Value.ToString();
                txtBrand.Text = dgvOrderList1.CurrentRow.Cells["brand1"].Value.ToString();
                txtQuantity.Text = dgvOrderList1.CurrentRow.Cells["quantity1"].Value.ToString();
                txtCostPrice.Text = dgvOrderList1.CurrentRow.Cells["costPrice1"].Value.ToString();
                getID = dgvOrderList1.CurrentRow.Cells["id1"].Value.ToString();
                getPO = dgvOrderList1.CurrentRow.Cells["purchaseNo1"].Value.ToString();
                getName = dgvOrderList1.CurrentRow.Cells["itemName1"].Value.ToString();
                txtSellingPrice.Text = dgvOrderList1.CurrentRow.Cells["sellingPrice"].Value.ToString();
                txtBarcode.Text = dgvOrderList1.CurrentRow.Cells["barcode1"].Value.ToString();
                cmbMarkUp.Enabled = false;
                txtSetQuantity.Text = dgvOrderList1.CurrentRow.Cells["quantity1"].Value.ToString();
               
                //try
                //{
                //    conn.Open();
                //    string sql = "SELECT * FROM product WHERE barcode = @barcode";
                //    MySqlDataAdapter sda = new MySqlDataAdapter(sql, conn);
                //    sda.SelectCommand.Parameters.AddWithValue("@barcode", getBarcode);
                //    DataTable sdt = new DataTable();
                //    sda.Fill(sdt);
                //    conn.Close();
                //    if (sdt.Rows.Count > 0)
                //    {
                //        for (int samp = 0; samp < sdt.Rows.Count; samp++)
                //        {
                //            DataRow sdr = sdt.Rows[samp];
                //            if (sdr["barcode"].ToString().Equals(getBarcode))
                //            {
                //                txtSellingPrice.Text = sdt.Rows[0][8].ToString();
                //            }
                //        }
                //    }
                //}
                //catch (Exception a)
                //{
                //    MessageBox.Show(a.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                //}
            }
            
        }

        private void cmbMarkUp_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMarkUp.SelectedItem.ToString() == "1%")
            {
                decimal testing = Convert.ToDecimal(txtCostPrice.Text);
                decimal aa = (Convert.ToDecimal(0.01) * testing) + testing;
                txtSellingPrice.Text = Convert.ToString(String.Format("{0:0.00}", aa));
            }
            else if (cmbMarkUp.SelectedItem.ToString() == "2%")
            {
                decimal testing = Convert.ToDecimal(txtCostPrice.Text);
                decimal aa = (Convert.ToDecimal(0.03) * testing) + testing;
                txtSellingPrice.Text = Convert.ToString(String.Format("{0:0.00}", aa));
            }
            else if (cmbMarkUp.SelectedItem.ToString() == "4%")
            {
                decimal testing = Convert.ToDecimal(txtCostPrice.Text);
                decimal aa = (Convert.ToDecimal(0.04) * testing) + testing;
                txtSellingPrice.Text = Convert.ToString(String.Format("{0:0.00}", aa));
            }
            else if (cmbMarkUp.SelectedItem.ToString() == "5%")
            {
                decimal testing = Convert.ToDecimal(txtCostPrice.Text);
                decimal aa = (Convert.ToDecimal(0.05) * testing) + testing;
                txtSellingPrice.Text = Convert.ToString(String.Format("{0:0.00}", aa));
            }

            else if (cmbMarkUp.SelectedItem.ToString() == "6%")
            {
                decimal testing = Convert.ToDecimal(txtCostPrice.Text);
                decimal aa = (Convert.ToDecimal(0.06) * testing) + testing;
                txtSellingPrice.Text = Convert.ToString(String.Format("{0:0.00}", aa));
            }

            else if (cmbMarkUp.SelectedItem.ToString() == "7%")
            {
                decimal testing = Convert.ToDecimal(txtCostPrice.Text);
                decimal aa = (Convert.ToDecimal(0.07) * testing) + testing;
                txtSellingPrice.Text = Convert.ToString(String.Format("{0:0.00}", aa));
            }

            else if (cmbMarkUp.SelectedItem.ToString() == "8%")
            {
                decimal testing = Convert.ToDecimal(txtCostPrice.Text);
                decimal aa = (Convert.ToDecimal(0.08) * testing) + testing;
                txtSellingPrice.Text = Convert.ToString(String.Format("{0:0.00}", aa));
            }

            else if (cmbMarkUp.SelectedItem.ToString() == "9%")
            {
                decimal testing = Convert.ToDecimal(txtCostPrice.Text);
                decimal aa = (Convert.ToDecimal(0.09) * testing) + testing;
                txtSellingPrice.Text = Convert.ToString(String.Format("{0:0.00}", aa));
            }

            else if (cmbMarkUp.SelectedItem.ToString() == "10%")
            {
                decimal testing = Convert.ToDecimal(txtCostPrice.Text);
                decimal aa = (Convert.ToDecimal(0.10) * testing) + testing;
                txtSellingPrice.Text = Convert.ToString(String.Format("{0:0.00}", aa));
            }

            else if (cmbMarkUp.SelectedItem.ToString() == "11%")
            {
                decimal testing = Convert.ToDecimal(txtCostPrice.Text);
                decimal aa = (Convert.ToDecimal(0.11) * testing) + testing;
                txtSellingPrice.Text = Convert.ToString(String.Format("{0:0.00}", aa));
            }

            else if (cmbMarkUp.SelectedItem.ToString() == "12%")
            {
                decimal testing = Convert.ToDecimal(txtCostPrice.Text);
                decimal aa = (Convert.ToDecimal(0.12) * testing) + testing;
                txtSellingPrice.Text = Convert.ToString(String.Format("{0:0.00}", aa));
            }

            else if (cmbMarkUp.SelectedItem.ToString() == "13%")
            {
                decimal testing = Convert.ToDecimal(txtCostPrice.Text);
                decimal aa = (Convert.ToDecimal(0.13) * testing) + testing;
                txtSellingPrice.Text = Convert.ToString(String.Format("{0:0.00}", aa));
            }

            else if (cmbMarkUp.SelectedItem.ToString() == "14%")
            {
                decimal testing = Convert.ToDecimal(txtCostPrice.Text);
                decimal aa = (Convert.ToDecimal(0.14) * testing) + testing;
                txtSellingPrice.Text = Convert.ToString(String.Format("{0:0.00}", aa));
            }

            else if (cmbMarkUp.SelectedItem.ToString() == "15%")
            {
                decimal testing = Convert.ToDecimal(txtCostPrice.Text);
                decimal aa = (Convert.ToDecimal(0.15) * testing) + testing;
                txtSellingPrice.Text = Convert.ToString(String.Format("{0:0.00}", aa));
            }
            else
            {

            }
            decimal sellingPrice = Convert.ToDecimal(txtSellingPrice.Text);
            int vat = Convert.ToInt32(lblVat.Text);
            decimal totalVat = (sellingPrice * vat) / 100;
            decimal total = sellingPrice + totalVat;
            txtSellingPrice.Text = total.ToString();

            //if (cmbMarkUp.SelectedItem.ToString() == "5%")
            //{
            //    decimal testing = Convert.ToDecimal(txtCostPrice.Text);
            //    decimal aa = (Convert.ToDecimal(0.05) * testing) + testing;
            //    txtSellingPrice.Text = Convert.ToString(String.Format("{0:0.00}", aa));
            //}
            //else if (cmbMarkUp.SelectedItem.ToString() == "10%")
            //{
            //    decimal testing = Convert.ToDecimal(txtCostPrice.Text);
            //    decimal aa = (Convert.ToDecimal(0.10) * testing) + testing;
            //    txtSellingPrice.Text = Convert.ToString(String.Format("{0:0.00}", aa));
            //}
            //else if (cmbMarkUp.SelectedItem.ToString() == "15%")
            //{
            //    decimal testing = Convert.ToDecimal(txtCostPrice.Text);
            //    decimal aa = (Convert.ToDecimal(0.15) * testing) + testing;
            //    txtSellingPrice.Text = Convert.ToString(String.Format("{0:0.00}", aa));
            //}
            //else if (cmbMarkUp.SelectedItem.ToString() == "20%")
            //{
            //    decimal testing = Convert.ToDecimal(txtCostPrice.Text);
            //    decimal aa = (Convert.ToDecimal(0.20) * testing) + testing;
            //    txtSellingPrice.Text = Convert.ToString(String.Format("{0:0.00}", aa));
            //}
            //else if (cmbMarkUp.SelectedItem.ToString() == "25")
            //{
            //    decimal testing = Convert.ToDecimal(txtCostPrice.Text);
            //    decimal aa = (Convert.ToDecimal(0.25) * testing) + testing;
            //    txtSellingPrice.Text = Convert.ToString(String.Format("{0:0.00}", aa));
            //}
            //else if (cmbMarkUp.SelectedItem.ToString() == "30%")
            //{
            //    decimal testing = Convert.ToDecimal(txtCostPrice.Text);
            //    decimal aa = (Convert.ToDecimal(0.30) * testing) + testing;
            //    txtSellingPrice.Text = Convert.ToString(String.Format("{0:0.00}", aa));
            //}
            //else if (cmbMarkUp.SelectedItem.ToString() == "35%")
            //{
            //    decimal testing = Convert.ToDecimal(txtCostPrice.Text);
            //    decimal aa = (Convert.ToDecimal(0.35) * testing) + testing;
            //    txtSellingPrice.Text = Convert.ToString(String.Format("{0:0.00}", aa));
            //}
            //else if (cmbMarkUp.SelectedItem.ToString() == "40%")
            //{
            //    decimal testing = Convert.ToDecimal(txtCostPrice.Text);
            //    decimal aa = (Convert.ToDecimal(0.40) * testing) + testing;
            //    txtSellingPrice.Text = Convert.ToString(String.Format("{0:0.00}", aa));
            //}
            //else if (cmbMarkUp.SelectedItem.ToString() == "45%")
            //{
            //    decimal testing = Convert.ToDecimal(txtCostPrice.Text);
            //    decimal aa = (Convert.ToDecimal(0.45) * testing) + testing;
            //    txtSellingPrice.Text = Convert.ToString(String.Format("{0:0.00}", aa));
            //}
            //else if (cmbMarkUp.SelectedItem.ToString() == "50%")
            //{
            //    decimal testing = Convert.ToDecimal(txtCostPrice.Text);
            //    decimal aa = (Convert.ToDecimal(0.50) * testing) + testing;
            //    txtSellingPrice.Text = Convert.ToString(String.Format("{0:0.00}", aa));
            //}
            //else if (cmbMarkUp.SelectedItem.ToString() == "55%")
            //{
            //    decimal testing = Convert.ToDecimal(txtCostPrice.Text);
            //    decimal aa = (Convert.ToDecimal(0.55) * testing) + testing;
            //    txtSellingPrice.Text = Convert.ToString(String.Format("{0:0.00}", aa));
            //}
            //else if (cmbMarkUp.SelectedItem.ToString() == "60%")
            //{
            //    decimal testing = Convert.ToDecimal(txtCostPrice.Text);
            //    decimal aa = (Convert.ToDecimal(0.60) * testing) + testing;
            //    txtSellingPrice.Text = Convert.ToString(String.Format("{0:0.00}", aa));
            //}
            //else if (cmbMarkUp.SelectedItem.ToString() == "65%")
            //{
            //    decimal testing = Convert.ToDecimal(txtCostPrice.Text);
            //    decimal aa = (Convert.ToDecimal(0.65) * testing) + testing;
            //    txtSellingPrice.Text = Convert.ToString(String.Format("{0:0.00}", aa));
            //}
            //else if (cmbMarkUp.SelectedItem.ToString() == "70%")
            //{
            //    decimal testing = Convert.ToDecimal(txtCostPrice.Text);
            //    decimal aa = (Convert.ToDecimal(0.70) * testing) + testing;
            //    txtSellingPrice.Text = Convert.ToString(String.Format("{0:0.00}", aa));
            //}
            //else if (cmbMarkUp.SelectedItem.ToString() == "75%")
            //{
            //    decimal testing = Convert.ToDecimal(txtCostPrice.Text);
            //    decimal aa = (Convert.ToDecimal(0.75) * testing) + testing;
            //    txtSellingPrice.Text = Convert.ToString(String.Format("{0:0.00}", aa));
            //}
            //else if (cmbMarkUp.SelectedItem.ToString() == "80%")
            //{
            //    decimal testing = Convert.ToDecimal(txtCostPrice.Text);
            //    decimal aa = (Convert.ToDecimal(0.80) * testing) + testing;
            //    txtSellingPrice.Text = Convert.ToString(String.Format("{0:0.00}", aa));
            //}
            //else if (cmbMarkUp.SelectedItem.ToString() == "85%")
            //{
            //    decimal testing = Convert.ToDecimal(txtCostPrice.Text);
            //    decimal aa = (Convert.ToDecimal(0.85) * testing) + testing;
            //    txtSellingPrice.Text = Convert.ToString(String.Format("{0:0.00}", aa));
            //}
            //else if (cmbMarkUp.SelectedItem.ToString() == "90%")
            //{
            //    decimal testing = Convert.ToDecimal(txtCostPrice.Text);
            //    decimal aa = (Convert.ToDecimal(0.90) * testing) + testing;
            //    txtSellingPrice.Text = Convert.ToString(String.Format("{0:0.00}", aa));
            //}
            //else if (cmbMarkUp.SelectedItem.ToString() == "95%")
            //{
            //    decimal testing = Convert.ToDecimal(txtCostPrice.Text);
            //    decimal aa = (Convert.ToDecimal(0.95) * testing) + testing;
            //    txtSellingPrice.Text = Convert.ToString(String.Format("{0:0.00}", aa));
            //}
            //else if (cmbMarkUp.SelectedItem.ToString() == "100%")
            //{
            //    decimal testing = Convert.ToDecimal(txtCostPrice.Text);
            //    decimal aa = (Convert.ToDecimal(100 * testing) / 100) + testing;
            //    txtSellingPrice.Text = Convert.ToString(String.Format("{0:0.00}", aa));
            //}
        }

        private void dgvSupplierList_DoubleClick(object sender, EventArgs e)
        {
            dgvSupplierList.Visible = false;
            lblCompanyName.Text = supplier;
            showItemOrderList();
        }

        private void dgvSupplierList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnReceiveAllItem1_Click(object sender, EventArgs e)
        {
            
            foreach (DataGridViewRow order in dgvOrderList1.Rows)
            {
                try
                {

                    conn.Open();
                    MySqlCommand scom2 = conn.CreateCommand();
                    scom2.CommandText = "UPDATE product SET stocks = stocks + @stocks1, selling_price = @selling_price, kind = 'Product' WHERE barcode = @barcode";
                    scom2.Parameters.AddWithValue("@barcode", order.Cells["barcode1"].Value);
                    scom2.Parameters.AddWithValue("@stocks1", order.Cells["quantity1"].Value);
                    scom2.Parameters.AddWithValue("@selling_price", txtSellingPrice.Text);
                    scom2.ExecuteNonQuery();
                    conn.Close();

                   

                    conn.Open();
                    MySqlCommand scom3 = conn.CreateCommand();
                    scom3.CommandText = "UPDATE purchase_report SET status = 'Accepted' WHERE purchase_no = @po AND name = @name";
                    scom3.Parameters.AddWithValue("@po", getPO);
                    scom3.Parameters.AddWithValue("@name", getName);
                    scom3.ExecuteNonQuery();
                    conn.Close();

                    conn.Open();
                    MySqlCommand scom4 = conn.CreateCommand();
                    scom4.CommandText = "DELETE FROM order_list WHERE id = @id";
                    scom4.Parameters.AddWithValue("@id", order.Cells["id1"].Value);
                    scom4.ExecuteNonQuery();
                    conn.Close();          
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            showProductOrderList();
            showItemOrderList();
            showSupplierList();
            alert.Show("Successfully Added To Inventory.", alert.AlertType.success);
        }

        private void dgvSupplierList_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvSupplierList.Rows.Count > 0)
            {
                supplier = dgvSupplierList.CurrentRow.Cells["companyName"].Value.ToString();
            }
        }

        private void dgvSupplierList_DoubleClick_1(object sender, EventArgs e)
        {
            dgvSupplierList.Visible = false;
            lblCompanyName.Text = supplier;
            showItemOrderList();
        }

        private void picGoBack_Click(object sender, EventArgs e)
        {
            dgvSupplierList.Visible = true;
        }

        private void dgvSupplierList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void chkRandom_OnChange(object sender, EventArgs e)
        {

        }

        private void picBackOrder_Click(object sender, EventArgs e)
        {

            Back_Order back = new Back_Order();

            back.ShowDialog();
          
        }

        private void gb1_Enter(object sender, EventArgs e)
        {

        }

        private void dtpExpirationDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void chkRandom_OnChange_1(object sender, EventArgs e)
        {
            if(chkItem.Checked == true)
            {
                if (chkRandom.Checked == true)
                {
                    generateRandomNumbers();
                }
                else
                {
                    txtBarcode.Text = "";
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            getCurrentVAT();
        }

        private void btnNoVAT_OnChange(object sender, EventArgs e)
        {
            if(cmbMarkUp.SelectedIndex != -1)
            {
                if(chkNoVAT.Checked == true)
                {
                    if (cmbMarkUp.SelectedItem.ToString() == "1%")
                    {
                        decimal testing = Convert.ToDecimal(txtCostPrice.Text);
                        decimal aa = (Convert.ToDecimal(0.01) * testing) + testing;
                        txtSellingPrice.Text = Convert.ToString(String.Format("{0:0.00}", aa));
                    }
                    else if (cmbMarkUp.SelectedItem.ToString() == "2%")
                    {
                        decimal testing = Convert.ToDecimal(txtCostPrice.Text);
                        decimal aa = (Convert.ToDecimal(0.03) * testing) + testing;
                        txtSellingPrice.Text = Convert.ToString(String.Format("{0:0.00}", aa));
                    }
                    else if (cmbMarkUp.SelectedItem.ToString() == "4%")
                    {
                        decimal testing = Convert.ToDecimal(txtCostPrice.Text);
                        decimal aa = (Convert.ToDecimal(0.04) * testing) + testing;
                        txtSellingPrice.Text = Convert.ToString(String.Format("{0:0.00}", aa));
                    }
                    else if (cmbMarkUp.SelectedItem.ToString() == "5%")
                    {
                        decimal testing = Convert.ToDecimal(txtCostPrice.Text);
                        decimal aa = (Convert.ToDecimal(0.05) * testing) + testing;
                        txtSellingPrice.Text = Convert.ToString(String.Format("{0:0.00}", aa));
                    }

                    else if (cmbMarkUp.SelectedItem.ToString() == "6%")
                    {
                        decimal testing = Convert.ToDecimal(txtCostPrice.Text);
                        decimal aa = (Convert.ToDecimal(0.06) * testing) + testing;
                        txtSellingPrice.Text = Convert.ToString(String.Format("{0:0.00}", aa));
                    }

                    else if (cmbMarkUp.SelectedItem.ToString() == "7%")
                    {
                        decimal testing = Convert.ToDecimal(txtCostPrice.Text);
                        decimal aa = (Convert.ToDecimal(0.07) * testing) + testing;
                        txtSellingPrice.Text = Convert.ToString(String.Format("{0:0.00}", aa));
                    }

                    else if (cmbMarkUp.SelectedItem.ToString() == "8%")
                    {
                        decimal testing = Convert.ToDecimal(txtCostPrice.Text);
                        decimal aa = (Convert.ToDecimal(0.08) * testing) + testing;
                        txtSellingPrice.Text = Convert.ToString(String.Format("{0:0.00}", aa));
                    }

                    else if (cmbMarkUp.SelectedItem.ToString() == "9%")
                    {
                        decimal testing = Convert.ToDecimal(txtCostPrice.Text);
                        decimal aa = (Convert.ToDecimal(0.09) * testing) + testing;
                        txtSellingPrice.Text = Convert.ToString(String.Format("{0:0.00}", aa));
                    }

                    else if (cmbMarkUp.SelectedItem.ToString() == "10%")
                    {
                        decimal testing = Convert.ToDecimal(txtCostPrice.Text);
                        decimal aa = (Convert.ToDecimal(0.10) * testing) + testing;
                        txtSellingPrice.Text = Convert.ToString(String.Format("{0:0.00}", aa));
                    }

                    else if (cmbMarkUp.SelectedItem.ToString() == "11%")
                    {
                        decimal testing = Convert.ToDecimal(txtCostPrice.Text);
                        decimal aa = (Convert.ToDecimal(0.11) * testing) + testing;
                        txtSellingPrice.Text = Convert.ToString(String.Format("{0:0.00}", aa));
                    }

                    else if (cmbMarkUp.SelectedItem.ToString() == "12%")
                    {
                        decimal testing = Convert.ToDecimal(txtCostPrice.Text);
                        decimal aa = (Convert.ToDecimal(0.12) * testing) + testing;
                        txtSellingPrice.Text = Convert.ToString(String.Format("{0:0.00}", aa));
                    }

                    else if (cmbMarkUp.SelectedItem.ToString() == "13%")
                    {
                        decimal testing = Convert.ToDecimal(txtCostPrice.Text);
                        decimal aa = (Convert.ToDecimal(0.13) * testing) + testing;
                        txtSellingPrice.Text = Convert.ToString(String.Format("{0:0.00}", aa));
                    }

                    else if (cmbMarkUp.SelectedItem.ToString() == "14%")
                    {
                        decimal testing = Convert.ToDecimal(txtCostPrice.Text);
                        decimal aa = (Convert.ToDecimal(0.14) * testing) + testing;
                        txtSellingPrice.Text = Convert.ToString(String.Format("{0:0.00}", aa));
                    }

                    else if (cmbMarkUp.SelectedItem.ToString() == "15%")
                    {
                        decimal testing = Convert.ToDecimal(txtCostPrice.Text);
                        decimal aa = (Convert.ToDecimal(0.15) * testing) + testing;
                        txtSellingPrice.Text = Convert.ToString(String.Format("{0:0.00}", aa));
                    }
                }
                else
                {
                    if (cmbMarkUp.SelectedItem.ToString() == "1%")
                    {
                        decimal testing = Convert.ToDecimal(txtCostPrice.Text);
                        decimal aa = (Convert.ToDecimal(0.01) * testing) + testing;
                        txtSellingPrice.Text = Convert.ToString(String.Format("{0:0.00}", aa));
                    }
                    else if (cmbMarkUp.SelectedItem.ToString() == "2%")
                    {
                        decimal testing = Convert.ToDecimal(txtCostPrice.Text);
                        decimal aa = (Convert.ToDecimal(0.03) * testing) + testing;
                        txtSellingPrice.Text = Convert.ToString(String.Format("{0:0.00}", aa));
                    }
                    else if (cmbMarkUp.SelectedItem.ToString() == "4%")
                    {
                        decimal testing = Convert.ToDecimal(txtCostPrice.Text);
                        decimal aa = (Convert.ToDecimal(0.04) * testing) + testing;
                        txtSellingPrice.Text = Convert.ToString(String.Format("{0:0.00}", aa));
                    }
                    else if (cmbMarkUp.SelectedItem.ToString() == "5%")
                    {
                        decimal testing = Convert.ToDecimal(txtCostPrice.Text);
                        decimal aa = (Convert.ToDecimal(0.05) * testing) + testing;
                        txtSellingPrice.Text = Convert.ToString(String.Format("{0:0.00}", aa));
                    }

                    else if (cmbMarkUp.SelectedItem.ToString() == "6%")
                    {
                        decimal testing = Convert.ToDecimal(txtCostPrice.Text);
                        decimal aa = (Convert.ToDecimal(0.06) * testing) + testing;
                        txtSellingPrice.Text = Convert.ToString(String.Format("{0:0.00}", aa));
                    }

                    else if (cmbMarkUp.SelectedItem.ToString() == "7%")
                    {
                        decimal testing = Convert.ToDecimal(txtCostPrice.Text);
                        decimal aa = (Convert.ToDecimal(0.07) * testing) + testing;
                        txtSellingPrice.Text = Convert.ToString(String.Format("{0:0.00}", aa));
                    }

                    else if (cmbMarkUp.SelectedItem.ToString() == "8%")
                    {
                        decimal testing = Convert.ToDecimal(txtCostPrice.Text);
                        decimal aa = (Convert.ToDecimal(0.08) * testing) + testing;
                        txtSellingPrice.Text = Convert.ToString(String.Format("{0:0.00}", aa));
                    }

                    else if (cmbMarkUp.SelectedItem.ToString() == "9%")
                    {
                        decimal testing = Convert.ToDecimal(txtCostPrice.Text);
                        decimal aa = (Convert.ToDecimal(0.09) * testing) + testing;
                        txtSellingPrice.Text = Convert.ToString(String.Format("{0:0.00}", aa));
                    }

                    else if (cmbMarkUp.SelectedItem.ToString() == "10%")
                    {
                        decimal testing = Convert.ToDecimal(txtCostPrice.Text);
                        decimal aa = (Convert.ToDecimal(0.10) * testing) + testing;
                        txtSellingPrice.Text = Convert.ToString(String.Format("{0:0.00}", aa));
                    }

                    else if (cmbMarkUp.SelectedItem.ToString() == "11%")
                    {
                        decimal testing = Convert.ToDecimal(txtCostPrice.Text);
                        decimal aa = (Convert.ToDecimal(0.11) * testing) + testing;
                        txtSellingPrice.Text = Convert.ToString(String.Format("{0:0.00}", aa));
                    }

                    else if (cmbMarkUp.SelectedItem.ToString() == "12%")
                    {
                        decimal testing = Convert.ToDecimal(txtCostPrice.Text);
                        decimal aa = (Convert.ToDecimal(0.12) * testing) + testing;
                        txtSellingPrice.Text = Convert.ToString(String.Format("{0:0.00}", aa));
                    }

                    else if (cmbMarkUp.SelectedItem.ToString() == "13%")
                    {
                        decimal testing = Convert.ToDecimal(txtCostPrice.Text);
                        decimal aa = (Convert.ToDecimal(0.13) * testing) + testing;
                        txtSellingPrice.Text = Convert.ToString(String.Format("{0:0.00}", aa));
                    }

                    else if (cmbMarkUp.SelectedItem.ToString() == "14%")
                    {
                        decimal testing = Convert.ToDecimal(txtCostPrice.Text);
                        decimal aa = (Convert.ToDecimal(0.14) * testing) + testing;
                        txtSellingPrice.Text = Convert.ToString(String.Format("{0:0.00}", aa));
                    }

                    else if (cmbMarkUp.SelectedItem.ToString() == "15%")
                    {
                        decimal testing = Convert.ToDecimal(txtCostPrice.Text);
                        decimal aa = (Convert.ToDecimal(0.15) * testing) + testing;
                        txtSellingPrice.Text = Convert.ToString(String.Format("{0:0.00}", aa));
                    }
                    decimal sellingPrice = Convert.ToDecimal(txtSellingPrice.Text);
                    int vat = Convert.ToInt32(lblVat.Text);
                    decimal totalVat = (sellingPrice * vat) / 100;
                    decimal total = sellingPrice + totalVat;
                    txtSellingPrice.Text = total.ToString();
                }
            }
        }

        private void chkNoBarcode_OnChange(object sender, EventArgs e)
        {
            if(chkNoBarcode.Checked == true)
            {
                txtBarcode.Text = "";
                txtBarcode.Enabled = false;
            }
            else
            {
                txtBarcode.Enabled = true;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Sales_and_Inventory_For_Marj_Hardware
{
    public partial class Purchase_Order12 : UserControl
    {
       
        private static Purchase_Order12 _instance;

        public static Purchase_Order12 Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Purchase_Order12();
                return _instance;
            }
        }
        public static string getSellingPrice;
        public static string purchaseNo;
        MySqlConnection conn = new MySqlConnection("SERVER = localhost; USERNAME = root; PASSWORD = ; DATABASE = marj_hardware");
        public Purchase_Order12()
        {
            InitializeComponent();
            getSupplier();
            cmbCompanyName.SelectedIndex = 0;
            Bunifu.Framework.Lib.Elipse.Apply(card1, 10);
            Bunifu.Framework.Lib.Elipse.Apply(card2, 10);
            Bunifu.Framework.Lib.Elipse.Apply(card3, 10);
            Bunifu.Framework.Lib.Elipse.Apply(card4, 10);
            getPurchaseNo();
        }
        //METHODS

        private void getSupplier()
        {     
            MySqlCommand scom = new MySqlCommand("SELECT * FROM supplier", conn);
            MySqlDataReader sdr;

            try
            {
                conn.Open();
                sdr = scom.ExecuteReader();

                while (sdr.Read())
                {
                    string companyName = sdr.GetString("company_name");
                    cmbCompanyName.Items.Add(companyName);
                    
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void showAllItem()
        {
            try
            {
                conn.Open();
                MySqlCommand scom = conn.CreateCommand();
                scom.CommandText = "SELECT barcode, name, brand, category, description, stocks, cost_price, selling_price, ceiling, reorder, critical FROM product WHERE status = 1";
                scom.Parameters.AddWithValue("@companyName", cmbCompanyName.Text);
                scom.ExecuteNonQuery();
                MySqlDataAdapter sda = new MySqlDataAdapter(scom);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                conn.Close();

                dgvProductList.DataSource = dt;

                if (dgvProductList.Rows.Count > 0)
                {
                    dgvProductList.Rows[0].Selected = false;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void showItemList() {
            try
            {
                conn.Open();
                MySqlCommand scom = conn.CreateCommand();
                scom.CommandText = "SELECT name, brand, category, description, cost_price, ceiling, reorder, critical FROM product WHERE kind = 'Item' AND status = 1";
                scom.Parameters.AddWithValue("@companyName", cmbCompanyName.Text);
                scom.ExecuteNonQuery();
                MySqlDataAdapter sda = new MySqlDataAdapter(scom);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                conn.Close();

                dgvItemList.DataSource = dt;

                if(dgvItemList.Rows.Count > 0)
                {
                    dgvItemList.Rows[0].Selected = false;
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void showProductList()
        {
            try
            {
                conn.Open();
                MySqlCommand scom = conn.CreateCommand();
                scom.CommandText = "SELECT barcode, name, brand, category, description, stocks, cost_price, selling_price, ceiling, reorder, critical FROM product WHERE supplier = @companyName AND status = 1 AND kind = 'Product'";
                scom.Parameters.AddWithValue("@companyName", cmbCompanyName.Text);
                scom.ExecuteNonQuery();
                MySqlDataAdapter sda = new MySqlDataAdapter(scom);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                conn.Close();

                dgvProductList.DataSource = dt;
                if(dgvProductList.Rows.Count > 0)
                {
                    dgvProductList.Rows[0].Selected = false;
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void showNeedToOrder()
        {
            try
            {
                conn.Open();
                MySqlCommand scom = conn.CreateCommand();
                scom.CommandText = "SELECT barcode, name, brand, category, description, stocks, cost_price, selling_price, ceiling, reorder, critical FROM product WHERE stocks <= reorder AND status = 1 AND kind = 'Product'";
                scom.Parameters.AddWithValue("@companyName", cmbCompanyName.Text);
                scom.ExecuteNonQuery();
                MySqlDataAdapter sda = new MySqlDataAdapter(scom);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                conn.Close();

                dgvProductList.DataSource = dt;
                if (dgvProductList.Rows.Count > 0)
                {
                    dgvProductList.Rows[0].Selected = false;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void getSupplierInformation()
        {        
            try
            {
                conn.Open();
                MySqlCommand scom = conn.CreateCommand();
                scom.CommandText = "SELECT * FROM supplier WHERE company_name = @supplier";
                scom.Parameters.AddWithValue("@supplier", cmbCompanyName.Text);
                MySqlDataReader dr = scom.ExecuteReader();
                while (dr.Read())
                {
                    txtContactPerson.Text = dr.GetString("contact_person");
                    txtContactNumber.Text = dr.GetString("contact_number");
                    txtEmailAddress.Text = dr.GetString("email");
                }
                dr.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
                    txtPurchaseNo.Text = dr.GetString("PurchaseNo");

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
        private void Point_of_Sales_Load(object sender, EventArgs e)
        {

        }

        private void card3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cmbCompanyName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbCompanyName.SelectedIndex != 0)
            {
                chkStep2.Checked = true;
                line2.LineColor = Color.FromArgb(51, 205, 117);

                if(chkShowAll.Checked == true)
                {
                    showAllItem();
                    dgvProductList.Visible = true;
                    dgvItemList.Visible = false;
                }
                else if(chkItem.Checked == true)
                {
                    showItemList();
                    dgvItemList.Visible = true;
                    dgvProductList.Visible = false;
                }
                else if(chkProduct.Checked == true)
                {
                    showProductList();
                    dgvProductList.Visible = true;
                    dgvItemList.Visible = false;     
                }
                else if(chkCriticalProduct.Checked == true)
                {
                    showNeedToOrder();
                    dgvProductList.Visible = true;
                    dgvItemList.Visible = false;
                }

                getSupplierInformation();
            }
            else
            {
                chkStep2.Checked = false;
                chkStep3.Checked = false;
                line2.LineColor = Color.FromArgb(235, 238, 245);
                txtContactNumber.Text = "";
                txtContactPerson.Text = "";
                txtEmailAddress.Text = "";
                try
                {
                    conn.Open();
                    MySqlCommand scom = conn.CreateCommand();
                    scom.CommandText = "SELECT * FROM empty";
                    scom.ExecuteNonQuery();
                    MySqlDataAdapter sda = new MySqlDataAdapter(scom);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    conn.Close();
                    dgvItemList.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void chkToday_OnChange(object sender, EventArgs e)
        {
            if(chkToday.Checked == true)
            {
                chkStep1.Checked = true;
                cmbCompanyName.Enabled = true;
                line1.LineColor = Color.FromArgb(51, 205, 117);
                dtpPurchaseDate.Enabled = false;

                if(cmbCompanyName.SelectedIndex != 0)
                {
                    chkStep2.Checked = true;
                    line2.LineColor = Color.FromArgb(51, 205, 117);

                    if (chkItem.Checked == true)
                    {
                        showItemList();
                        dgvItemList.Visible = true;
                        dgvProductList.Visible = false;
                    }
                    else if (chkProduct.Checked == true)
                    {
                        showProductList();
                        dgvProductList.Visible = true;
                        dgvItemList.Visible = false;
                    }
                    dgvProductList.Visible = true;
                    dgvItemList.Visible = false;
                }
            }
            else if(chkToday.Checked == false)
            {
                cmbCompanyName.Enabled = false;
                chkStep1.Checked = false;
                line1.LineColor = Color.FromArgb(235, 238, 245);
                chkStep2.Checked = false;
                line2.LineColor = Color.FromArgb(235, 238, 245);
                chkStep3.Checked = false;
                dtpPurchaseDate.Enabled = true;

                if (dtpPurchaseDate.Text != System.DateTime.Now.ToString("yyyy/MM/dd"))
                {
                    chkStep1.Checked = true;
                    cmbCompanyName.Enabled = true;
                    line1.LineColor = Color.FromArgb(51, 205, 117);
                }
                try
                {
                    conn.Open();
                    MySqlCommand scom = conn.CreateCommand();
                    scom.CommandText = "SELECT * FROM empty";
                    scom.ExecuteNonQuery();
                    MySqlDataAdapter sda = new MySqlDataAdapter(scom);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    conn.Close();
                    dgvItemList.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                dgvItemList.Visible = true;
                dgvProductList.Visible = false;
            }   
        }

        private void dtpPurchaseDate_ValueChanged(object sender, EventArgs e)
        {
            if(dtpPurchaseDate.Text != System.DateTime.Now.ToString("yyyy/MM/dd"))
            {
                chkStep1.Checked = true;
                cmbCompanyName.Enabled = true;
                line1.LineColor = Color.FromArgb(51, 205, 117);

                if (cmbCompanyName.SelectedIndex != 0)
                {
                    chkStep2.Checked = true;
                    line2.LineColor = Color.FromArgb(51, 205, 117);
                }

                if (cmbCompanyName.SelectedIndex != 0)
                {
                    chkStep2.Checked = true;
                    line2.LineColor = Color.FromArgb(51, 205, 117);

                    if(chkItem.Checked == true)
                    {
                        showItemList();
                    }
                    else if(chkProduct.Checked == true)
                    {
                        showProductList();
                    }
                }
            }
            else
            {
                cmbCompanyName.Enabled = false;
                chkStep1.Checked = false;
                line1.LineColor = Color.FromArgb(235, 238, 245);
                chkStep2.Checked = false;
                line2.LineColor = Color.FromArgb(235, 238, 245);
                chkStep3.Checked = false;

                try
                {
                    conn.Open();
                    MySqlCommand scom = conn.CreateCommand();
                    scom.CommandText = "SELECT * FROM empty";
                    scom.ExecuteNonQuery();
                    MySqlDataAdapter sda = new MySqlDataAdapter(scom);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    conn.Close();
                    dgvItemList.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            } 
        }

        private void bunifuCustomLabel16_Click(object sender, EventArgs e)
        {

        }

        private void dgvItemProductList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgvItemList.Rows.Count > 0)
            {
                txtItemName.Text = dgvItemList.CurrentRow.Cells["itemName"].Value.ToString();
                txtBrand.Text = dgvItemList.CurrentRow.Cells["brand"].Value.ToString();
                txtCategory.Text = dgvItemList.CurrentRow.Cells["category"].Value.ToString();
                txtDescription.Text = dgvItemList.CurrentRow.Cells["description"].Value.ToString();
                txtCostPrice.Text = dgvItemList.CurrentRow.Cells["costPrice"].Value.ToString();
                txtTotalPrice.Text = dgvItemList.CurrentRow.Cells["costPrice"].Value.ToString();
                txtQuantity.Text = "1";
                txtQuantity.Enabled = true;
                chkStep3.Checked = true;
                txtBarcode.Text = "";
            }
        }

        private void txtQuantity_OnValueChanged(object sender, EventArgs e)
        {
            

            if(txtQuantity.Text != "")
            {
                Decimal quantity = Convert.ToDecimal(txtQuantity.Text);
                Decimal price = Convert.ToDecimal(txtCostPrice.Text);
                Decimal total = quantity * price;

                txtTotalPrice.Text = Convert.ToString(total);
            }
        }

        private void chkItem_OnChange(object sender, EventArgs e)
        {
            chkCriticalProduct.Checked = false;
            chkProduct.Checked = false;
            dgvItemList.Visible = true;
            dgvProductList.Visible = false;
            chkShowAll.Checked = false;

            showItemList();
        }

        private void chkProduct_OnChange(object sender, EventArgs e)
        {
            chkCriticalProduct.Checked = false;
            chkItem.Checked = false;
            dgvItemList.Visible = false;
            dgvProductList.Visible = true;
            chkShowAll.Checked = false;


            showProductList();
        }

        private void dgvProductList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvProductList.Rows.Count > 0)
            {
                txtBarcode.Text = dgvProductList.CurrentRow.Cells["barcode1"].Value.ToString();
                txtItemName.Text = dgvProductList.CurrentRow.Cells["itemName1"].Value.ToString();
                txtBrand.Text = dgvProductList.CurrentRow.Cells["brand1"].Value.ToString();
                txtCategory.Text = dgvProductList.CurrentRow.Cells["category1"].Value.ToString();
                txtDescription.Text = dgvProductList.CurrentRow.Cells["description1"].Value.ToString();
                txtCostPrice.Text = dgvProductList.CurrentRow.Cells["costPrice1"].Value.ToString();
                txtTotalPrice.Text = dgvProductList.CurrentRow.Cells["costPrice1"].Value.ToString();
                getSellingPrice = dgvProductList.CurrentRow.Cells["sellingPrice"].Value.ToString();
                //lbllselling.Text = dgvProductList.CurrentRow.Cells["sellingPrice"].Value.ToString();
                txtQuantity.Text = "1";
                txtQuantity.Enabled = true;
                chkStep3.Checked = true;
            }
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            if(txtItemName.Text != "")
            {
                MySqlCommand scom = new MySqlCommand("SELECT * FROM purchase_order WHERE name = @name AND brand = @brand AND @category = @category AND description = @description", conn);
                scom.Parameters.AddWithValue("@name", txtItemName.Text);
                scom.Parameters.AddWithValue("@brand", txtBrand.Text);
                scom.Parameters.AddWithValue("@category", txtCategory.Text);
                scom.Parameters.AddWithValue("@description", txtDescription.Text);
                MySqlDataAdapter sda = new MySqlDataAdapter(scom);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                int i = ds.Tables[0].Rows.Count;
                if (i > 0)
                {
                    try
                    {
                        conn.Open();
                        MySqlCommand scom2 = conn.CreateCommand();
                        scom2.CommandText = "UPDATE purchase_order SET quantity = quantity + @quantity1 WHERE barcode = @barcode";
                        scom2.Parameters.AddWithValue("@barcode", txtBarcode.Text);
                        scom2.Parameters.AddWithValue("@quantity1", txtQuantity.Text);
                        scom2.ExecuteNonQuery();
                        conn.Close();
                        ds.Clear();
                        alert.Show("Successfully Added To Cart", alert.AlertType.success);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }                  
                }
                else
                {
                    try
                    {
                        conn.Open();
                        MySqlCommand scom2 = conn.CreateCommand();
                        scom2.CommandText = "INSERT INTO purchase_order (supplier, barcode, name, brand, category, description, cost_price, selling_price, quantity, total_price) VALUES (@supplier, @barcode, @name, @brand, @category, @description, @price, @selling_price, @quantity, @totalPrice)";
                        scom2.Parameters.AddWithValue("@supplier", cmbCompanyName.Text);
                        scom2.Parameters.AddWithValue("@barcode", txtBarcode.Text);
                        scom2.Parameters.AddWithValue("@name", txtItemName.Text);
                        scom2.Parameters.AddWithValue("@brand", txtBrand.Text);
                        scom2.Parameters.AddWithValue("@category", txtCategory.Text);
                        scom2.Parameters.AddWithValue("@description", txtDescription.Text);
                        scom2.Parameters.AddWithValue("@price", txtCostPrice.Text);
                        scom2.Parameters.AddWithValue("@selling_price", getSellingPrice);
                        scom2.Parameters.AddWithValue("@quantity", txtQuantity.Text);
                        scom2.Parameters.AddWithValue("@totalPrice", txtTotalPrice.Text);
                        scom2.ExecuteNonQuery();
                        conn.Close();

                        //if (chkCriticalProduct.Checked == true || chkProduct.Checked == true)
                        //{
                        //    //conn.Open();
                        //    //MySqlCommand scom3 = conn.CreateCommand();
                        //    //scom3.CommandText = "INSERT INTO purchase_order (supplier, barcode, name, brand, category, description, cost_price, selling_price, quantity, total_price) VALUES (@supplier, @barcode, @name, @brand, @category, @description, @costPrice, @sellingPrice, @quantity, @totalPrice)";
                        //    //scom3.Parameters.AddWithValue("@supplier", cmbCompanyName.Text);
                        //    //scom3.Parameters.AddWithValue("@barcode", txtBarcode.Text);
                        //    //scom3.Parameters.AddWithValue("@name", txtItemName.Text);
                        //    //scom3.Parameters.AddWithValue("@brand", txtBrand.Text);
                        //    //scom3.Parameters.AddWithValue("@category", txtCategory.Text);
                        //    //scom3.Parameters.AddWithValue("@description", txtDescription.Text);
                        //    //scom3.Parameters.AddWithValue("@costPrice", txtCostPrice.Text);
                        //    //scom3.Parameters.AddWithValue("@sellingPrice", getSellingPrice);
                        //    //scom3.Parameters.AddWithValue("@quantity", txtQuantity.Text);
                        //    //scom3.Parameters.AddWithValue("@totalPrice", txtTotalPrice.Text);
                        //    //scom3.ExecuteNonQuery();
                        //    //conn.Close();
                        //}
                        alert.Show("Successfully Added To Cart", alert.AlertType.success);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    
                }             
            }
        }

        private void txtSearch_OnTextChange(object sender, EventArgs e)
        {
            ////if (txtSearch.text != "")
            //{
            //    try
            //    {
            //        conn.Open();
            //        MySqlCommand cmd = conn.CreateCommand();
            //        cmd.CommandText = "SELECT id, name FROM category WHERE name LIKE '%" + txtSearch.text + "%' AND status = @1 ORDER BY id DESC";
            //        cmd.Parameters.AddWithValue("@name", txtSearch.text);
            //        cmd.Parameters.AddWithValue("@1", "1");
            //        MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
            //        DataTable dt = new DataTable();
            //        sda.Fill(dt);
            //        conn.Close();
            //        dgvCategoryList.DataSource = dt;
            //        if (dgvCategoryList.RowCount > 0)
            //        {
            //            dgvCategoryList.Rows[0].Selected = false;
            //        }

            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show(ex.Message);
            //    }
            //}
            //else
            //{
            //    ShowCategoryList();
            //    dgvCategoryList.Rows[0].Selected = false;
            //}
        }

        private void btnGoToCart_Click(object sender, EventArgs e)
        {
            Purchase_OrderList order = new Purchase_OrderList();
            purchaseNo = txtPurchaseNo.Text;
            order.Show();
            
        }

        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void chkShowAll_OnChange(object sender, EventArgs e)
        {
            chkCriticalProduct.Checked = false;
            chkProduct.Checked = false;
            chkItem.Checked = false;
            dgvItemList.Visible = false;
            dgvProductList.Visible = true;
            showAllItem();
        }

        private void chkCriticalProduct_OnChange(object sender, EventArgs e)
        {
            chkShowAll.Checked = false;
            chkProduct.Checked = false;
            dgvItemList.Visible = false;
            dgvItemList.Visible = false;
            dgvProductList.Visible = true;
            showNeedToOrder();
        }

        private void bunifuCustomLabel9_Click(object sender, EventArgs e)
        {

        }
    }
}

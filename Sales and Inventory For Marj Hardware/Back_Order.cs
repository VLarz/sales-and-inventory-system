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
    public partial class Back_Order : Form
    {
        MySqlConnection conn = new MySqlConnection("SERVER = localhost; USERNAME = root; PASSOWRD = ; DATABASE = marj_hardware");
        public static string getPO;
        public static string getName;
        public static string getID;
        public static string getSupplier;
        public Back_Order()
        {
            InitializeComponent();
            showBackOrderList();
        }
        //METHODS
        private void showBackOrderList()
        {
            try
            {
                conn.Open();
                MySqlCommand scom = conn.CreateCommand();
                scom.CommandText = "SELECT * FROM back_order ORDER BY id DESC";
                MySqlDataAdapter sda = new MySqlDataAdapter(scom);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                conn.Close();
                dgvBackOrderList.DataSource = dt;
                if(dgvBackOrderList.Rows.Count > 0)
                {
                    dgvBackOrderList.Rows[0].Selected = false;
                }
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            } 
        }

        private void dgvBackOrderList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgvBackOrderList.Rows.Count > 0)
            {
                getID = dgvBackOrderList.CurrentRow.Cells["id"].Value.ToString();
                getPO = dgvBackOrderList.CurrentRow.Cells["purchaseNo"].Value.ToString();
                getSupplier = dgvBackOrderList.CurrentRow.Cells["supplier"].Value.ToString();
                txtBarcode.Text = dgvBackOrderList.CurrentRow.Cells["barcode"].Value.ToString();
                txtProductName.Text = dgvBackOrderList.CurrentRow.Cells["itemName"].Value.ToString();
                txtBrand.Text = dgvBackOrderList.CurrentRow.Cells["brand"].Value.ToString();
                txtCategory.Text = dgvBackOrderList.CurrentRow.Cells["category"].Value.ToString();
                txtCostPrice.Text = dgvBackOrderList.CurrentRow.Cells["costPrice"].Value.ToString();
                txtQuantity.Text = dgvBackOrderList.CurrentRow.Cells["quantity"].Value.ToString();
                txtSetQuantity.Text = dgvBackOrderList.CurrentRow.Cells["quantity"].Value.ToString();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReceiveItem_Click(object sender, EventArgs e)
        {
            if(txtSetQuantity.Text != "0")
            {
                int setQuantity = Convert.ToInt32(txtSetQuantity.Text);
                int quantity = Convert.ToInt32(txtQuantity.Text);
                if (quantity >= setQuantity)
                {
                    int total = quantity - setQuantity;
                    if (total == 0)
                    {
                        try
                        {
                            conn.Open();
                            MySqlCommand scom3 = conn.CreateCommand();
                            scom3.CommandText = "UPDATE product SET stocks = stocks + @quantity WHERE name = @name AND brand = @brand AND category = @category AND supplier = @supplier OR supplier IS NULL";
                            scom3.Parameters.AddWithValue("@quantity", txtSetQuantity.Text);
                            scom3.Parameters.AddWithValue("@name", txtProductName.Text);
                            scom3.Parameters.AddWithValue("@brand", txtBrand.Text);
                            scom3.Parameters.AddWithValue("@category", txtCategory.Text);
                            scom3.Parameters.AddWithValue("@supplier", getSupplier);
                            scom3.ExecuteNonQuery();
                            conn.Close();

                            conn.Open();
                            MySqlCommand scom = conn.CreateCommand();
                            scom.CommandText = "UPDATE purchase_report SET quantity_received = quantity_received + @quantity WHERE purchase_no = @po AND name = @name";
                            scom.Parameters.AddWithValue("@received", System.DateTime.Now.ToString("yyyy/MM/dd"));
                            scom.Parameters.AddWithValue("@po", getPO);
                            scom.Parameters.AddWithValue("@name", getName);
                            scom.Parameters.AddWithValue("@quantity", txtSetQuantity.Text);
                            scom.ExecuteNonQuery();
                            conn.Close();

                            conn.Open();
                            MySqlCommand scom1 = conn.CreateCommand();
                            scom1.CommandText = "DELETE FROM back_order WHERE id = @id";
                            scom1.Parameters.AddWithValue("@id", getID);
                            scom1.ExecuteNonQuery();
                            conn.Close();

                            showBackOrderList();
                            alert.Show("Successfully Added To Inventory.", alert.AlertType.success);
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
                            MySqlCommand scom3 = conn.CreateCommand();
                            scom3.CommandText = "UPDATE product SET stocks = stocks + @quantity WHERE name = @name AND brand = @brand AND category = @category AND supplier = @supplier OR supplier IS NULL";
                            scom3.Parameters.AddWithValue("@quantity", txtSetQuantity.Text);
                            scom3.Parameters.AddWithValue("@name", txtProductName.Text);
                            scom3.Parameters.AddWithValue("@brand", txtBrand.Text);
                            scom3.Parameters.AddWithValue("@category", txtCategory.Text);
                            scom3.Parameters.AddWithValue("@supplier", getSupplier);
                            scom3.ExecuteNonQuery();
                            conn.Close();

                            conn.Open();
                            MySqlCommand scom = conn.CreateCommand();
                            scom.CommandText = "UPDATE purchase_report SET quantity_received = quantity_received + @quantity WHERE purchase_no = @po AND name = @name";
                            scom.Parameters.AddWithValue("@received", System.DateTime.Now.ToString("yyyy/MM/dd"));
                            scom.Parameters.AddWithValue("@po", getPO);
                            scom.Parameters.AddWithValue("@name", getName);
                            scom.Parameters.AddWithValue("@quantity", txtSetQuantity.Text);
                            scom.ExecuteNonQuery();
                            conn.Close();

                            conn.Open();
                            MySqlCommand scom1 = conn.CreateCommand();
                            scom1.CommandText = "UPDATE back_order SET quantity = quantity - @quantity WHERE id = @id";
                            scom1.Parameters.AddWithValue("@id", getID);
                            scom1.Parameters.AddWithValue("@quantity", txtSetQuantity.Text);
                            scom1.ExecuteNonQuery();
                            conn.Close();
                            showBackOrderList();
                            alert.Show("Successfully Added To Inventory.", alert.AlertType.success);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
                else
                {
                    alert.Show("You've exceeded the maximum of quantity", alert.AlertType.warning);
                }
            }
            else
            {
                alert.Show("Please input quantity.", alert.AlertType.warning);
            }
           
        }
    }
}

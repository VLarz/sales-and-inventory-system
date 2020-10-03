using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using MaterialSkin.Animations;
using MySql.Data.MySqlClient;

namespace Sales_and_Inventory_For_Marj_Hardware
{
    public partial class Previous_Customer : MaterialSkin.Controls.MaterialForm
    {
        MaterialSkinManager skinManager;
        MySqlConnection conn = new MySqlConnection("SERVER = localhost; USERNAME = root; PASSWORD = ; DATABASE = marj_hardware");
        public static string getCustomerName;
        public Previous_Customer()
        {
            InitializeComponent();
            skinManager = MaterialSkinManager.Instance;
            SkinManager.AddFormToManage(this);
            SkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            SkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Blue800, MaterialSkin.Primary.Blue900, MaterialSkin.Primary.Blue900, MaterialSkin.Accent.Orange700, MaterialSkin.TextShade.WHITE);
            showCustomerName();
        }
        //METHODS
        private void showCustomerName()
        {
            conn.Open();
            MySqlCommand scom = conn.CreateCommand();
            scom.CommandText = "SELECT DISTINCT customer_name FROM pos_hold";
            MySqlDataAdapter sda = new MySqlDataAdapter(scom);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dgvCustomerName.DataSource = dt;
            conn.Close();
            if (dgvCustomerName.Rows.Count > 0)
            {
                dgvCustomerName.Rows[0].Selected = false;
            }
        }

        private void showPreviousOrder()
        {
            conn.Open();
            MySqlCommand scom = conn.CreateCommand();
            scom.CommandText = "SELECT * FROM pos_hold WHERE customer_name = @name";
            scom.Parameters.AddWithValue("@name", getCustomerName);
            MySqlDataAdapter sda = new MySqlDataAdapter(scom);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dgvPreviousCustomer1.DataSource = dt;
            conn.Close();
            if (dgvPreviousCustomer1.Rows.Count > 0)
            {
                dgvPreviousCustomer1.Rows[0].Selected = false;
            }
        }
        private void computeTotalPrice()
        {
            if (dgvPreviousCustomer1.Rows.Count > 0)
            {
                try
                {
                    conn.Open();
                    MySqlCommand scom = conn.CreateCommand();
                    scom.CommandText = "SELECT SUM(total_price) AS 'total_price' FROM pos_hold WHERE customer_name = @name";
                    scom.Parameters.AddWithValue("@name", getCustomerName);
                    MySqlDataReader dr = scom.ExecuteReader();
                    while (dr.Read())
                    {
                        String gprice = dr["total_price"].ToString();
                        Double generatetotalprice = Convert.ToDouble(gprice);
                        txtTotalPrice.Text = Convert.ToString(String.Format("{0:0.00}", generatetotalprice));
                    }
                    dr.Close();
                    conn.Close();
                }
                catch (Exception a)
                {
                    MessageBox.Show(a.Message);
                }
            }
            else
            {
                txtTotalPrice.Text = "";
            }
        }
        private void computeTotalItem()
        {
            if (dgvPreviousCustomer1.Rows.Count > 0)
            {
                try
                {
                    conn.Open();
                    MySqlCommand scom = conn.CreateCommand();
                    scom.CommandText = "SELECT SUM(quantity) AS 'quantity' FROM pos_hold WHERE customer_name = @name";
                    scom.Parameters.AddWithValue("@name", getCustomerName);
                    MySqlDataReader dr = scom.ExecuteReader();
                    while (dr.Read())
                    {
                        String gprice = dr["quantity"].ToString();
                        Double generatetotalprice = Convert.ToDouble(gprice);
                        txtTotalItem.Text = Convert.ToString(generatetotalprice);
                    }
                    dr.Close();
                    conn.Close();
                }
                catch (Exception a)
                {
                    MessageBox.Show(a.Message);
                }
            }
            else
            {
                txtTotalItem.Text = "";
            }
        }


        private void dgvPreviousCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgvCustomerName.Rows.Count > 0)
            {
                getCustomerName = dgvCustomerName.CurrentRow.Cells["customerName"].Value.ToString();
            }
        }

        private void dgvPreviousCustomer_DoubleClick(object sender, EventArgs e)
        {
            if (dgvCustomerName.Rows.Count > 0)
            {
                showPreviousOrder();
                computeTotalItem();
                computeTotalPrice();
                lblName.Text = getCustomerName;
                dgvCustomerName.Visible = false;
                btnBack.Visible = true;
                btnAdd.Visible = true;
            }
        }

        private void Previous_Customer_Load(object sender, EventArgs e)
        {
            if(dgvCustomerName.Rows.Count > 0)
            {
                dgvCustomerName.Rows[0].Selected = false;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            dgvCustomerName.Visible = true;
            btnAdd.Visible = false;
            btnBack.Visible = false;
            txtTotalItem.Text = "";
            txtTotalPrice.Text = "";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            MySqlCommand scom3 = new MySqlCommand("SELECT * FROM pos", conn);
            MySqlDataAdapter sda = new MySqlDataAdapter(scom3);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            int i = ds.Tables[0].Rows.Count;
            if (i > 0)
            {
                alert.Show("Please finish the current transaction first.", alert.AlertType.warning);
            }
            else
            {
                DialogResult ask = MessageBox.Show("Are you sure you want to...?", "...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (ask == DialogResult.Yes)
                {
                    foreach (DataGridViewRow cart in dgvPreviousCustomer1.Rows)
                    {
                        conn.Open();
                        MySqlCommand scom = conn.CreateCommand();
                        scom.CommandText = "INSERT INTO pos (barcode, name, description, price, quantity, total_price) VALUES (@barcode, @name, @description, @price, @quantity, @totalPrice)";
                        scom.Parameters.AddWithValue("@barcode", cart.Cells["barcode"].Value.ToString());
                        scom.Parameters.AddWithValue("@name", cart.Cells["itemName"].Value.ToString());
                        scom.Parameters.AddWithValue("@description", cart.Cells["description"].Value.ToString());
                        scom.Parameters.AddWithValue("@price", cart.Cells["price"].Value.ToString());
                        scom.Parameters.AddWithValue("@quantity", cart.Cells["quantity"].Value.ToString());
                        scom.Parameters.AddWithValue("@totalPrice", cart.Cells["totalPrice"].Value.ToString());
                        scom.ExecuteNonQuery();
                        conn.Close();
                    }
                    conn.Open();
                    MySqlCommand scom1 = conn.CreateCommand();
                    scom1.CommandText = "DELETE FROM pos_hold WHERE customer_name = @name";
                    scom1.Parameters.AddWithValue("@name", getCustomerName);
                    scom1.ExecuteNonQuery();
                    conn.Close();
                    alert.Show("Successfully Added", alert.AlertType.success);
                    this.Close();
                }
            }
        }
    }
}

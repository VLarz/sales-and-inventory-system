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
    public partial class Inventory1 : UserControl
    {
        private static Inventory1 _instance;

        public static Inventory1 Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Inventory1();
                return _instance;
            }
        }

        MySqlConnection conn = new MySqlConnection("SERVER = LOCALHOST; USERNAME = root; PASSWORD = ; DATABASE = marj_hardware");
        public Inventory1()
        {
            InitializeComponent();
            showProductList();
        }
        //METHOD
        private void showProductList()
        {
            conn.Open();
            MySqlCommand scom = conn.CreateCommand();
            scom.CommandText = "SELECT barcode, name, brand, category, description, supplier, stocks, selling_price, ceiling, reorder, critical FROM product WHERE kind = 'Product' AND status = 1 ORDER BY name ASC";
            MySqlDataAdapter sda = new MySqlDataAdapter(scom);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            conn.Close();
            dgvProductList.DataSource = dt;
            if(dgvProductList.Rows.Count > 0)
            {
                dgvProductList.Rows[0].Selected = false;
                countColors();
                countProducts();
            }
        }

        private void showReorderProducts()
        {
            conn.Open();
            MySqlCommand scom = conn.CreateCommand();
            scom.CommandText = "SELECT barcode, name, brand, category, description, supplier, stocks, selling_price, ceiling, reorder, critical FROM product WHERE kind = 'Product' AND status = 1 AND stocks <= reorder AND stocks > critical ORDER BY name ASC";
            MySqlDataAdapter sda = new MySqlDataAdapter(scom);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            conn.Close();
            dgvProductList.DataSource = dt;
            if (dgvProductList.Rows.Count > 0)
            {
                dgvProductList.Rows[0].Selected = false;
                countColors();
                countProducts();
            }
            else
            {
                lblReorderPoint.Text = "0";
                lblCriticalLevel.Text = "0";
                lblSafetyPoint.Text = "0";
                lblProducts.Text = "0";
            }
        }

        private void showCriticalProducts()
        {
            conn.Open();
            MySqlCommand scom = conn.CreateCommand();
            scom.CommandText = "SELECT barcode, name, brand, category, description, supplier, stocks, selling_price, ceiling, reorder, critical FROM product WHERE kind = 'Product' AND status = 1 AND stocks <= critical ORDER BY name ASC";
            MySqlDataAdapter sda = new MySqlDataAdapter(scom);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            conn.Close();
            dgvProductList.DataSource = dt;
            if (dgvProductList.Rows.Count > 0)
            {
                dgvProductList.Rows[0].Selected = false;
                countColors();
                countProducts();
            }
            else
            {
                lblReorderPoint.Text = "0";
                lblCriticalLevel.Text = "0";
                lblSafetyPoint.Text = "0";
                lblProducts.Text = "0";
            }
        }

        private void showSafeProducts()
        {
            conn.Open();
            MySqlCommand scom = conn.CreateCommand();
            scom.CommandText = "SELECT barcode, name, brand, category, description, supplier, stocks, selling_price, ceiling, reorder, critical FROM product WHERE kind = 'Product' AND status = 1 AND stocks > reorder ORDER BY name ASC";
            MySqlDataAdapter sda = new MySqlDataAdapter(scom);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            conn.Close();
            dgvProductList.DataSource = dt;
            if (dgvProductList.Rows.Count > 0)
            {
                dgvProductList.Rows[0].Selected = false;
                countColors();
                countProducts();
            }
            else
            {
                lblReorderPoint.Text = "0";
                lblCriticalLevel.Text = "0";
                lblSafetyPoint.Text = "0";
                lblProducts.Text = "0";
            }
        }

        private void showVoidProducts()
        {
            conn.Open();
            MySqlCommand scom = conn.CreateCommand();
            scom.CommandText = "SELECT barcode, name, brand, category, description, supplier, stocks, selling_price, ceiling, reorder, critical FROM product WHERE kind = 'Product' AND status = 1 AND stocks <= reorder AND stocks > critical ORDER BY name ASC";
            MySqlDataAdapter sda = new MySqlDataAdapter(scom);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            conn.Close();
            dgvProductList.DataSource = dt;
            if (dgvProductList.Rows.Count > 0)
            {
                dgvProductList.Rows[0].Selected = false;
                countColors();
                countProducts();
            }
            else
            {
                lblReorderPoint.Text = "0";
                lblCriticalLevel.Text = "0";
                lblSafetyPoint.Text = "0";
                lblProducts.Text = "0";
            }
        }

        private void countColors()
        {
            int red = 0;
            int orange = 0;
            int Green = 0;
            for (int i = 0; i < dgvProductList.Rows.Count; i++)
            {
                int stocks = Convert.ToInt32(dgvProductList.Rows[i].Cells[6].Value);
                int reorder = Convert.ToInt32(dgvProductList.Rows[i].Cells[9].Value);
                int critical = Convert.ToInt32(dgvProductList.Rows[i].Cells[10].Value);

                //string quantity = Convert.ToString(dataGridView1.Rows[i].Cells[4].Value.ToString());
                //string name = Convert.ToString(dataGridView1.Rows[i].Cells[1].Value.ToString());

                if (stocks <= critical)
                {
                    red++;
                }
                else if (stocks <= reorder && stocks > critical)
                {
                    orange++;
                }
                else
                {
                    Green++;
                }
            }
            lblReorderPoint.Text = orange.ToString() + " Items";
            lblCriticalLevel.Text = red.ToString() + " Items";
            lblSafetyPoint.Text = Green.ToString() + " Items";
        }

        private void countProducts()
        {
            lblProducts.Text = dgvProductList.Rows.Count.ToString("");
        }
        private void dgvProductList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel4_Click(object sender, EventArgs e)
        {


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lblsafetypoint_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel25_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void Inventory_Load(object sender, EventArgs e)
        {
            if (dgvProductList.Rows.Count > 0)
            {
                dgvProductList.Rows[0].Selected = false;
            }
        }

        private void pnlHeader_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuCustomLabel11_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {
        }

        private void rdbShowAll_CheckedChanged(object sender, EventArgs e)
        {
            showProductList();
        }

        private void rdbReorder_CheckedChanged(object sender, EventArgs e)
        {
            showReorderProducts();
        }

        private void rdbCritical_CheckedChanged(object sender, EventArgs e)
        {
            showCriticalProducts();
        }

        private void rdbSafety_CheckedChanged(object sender, EventArgs e)
        {
            showSafeProducts();
        }
    }
}

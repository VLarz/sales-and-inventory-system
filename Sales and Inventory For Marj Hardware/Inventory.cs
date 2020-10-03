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
    public partial class Inventory : Form
    {
        MySqlConnection conn = new MySqlConnection("SERVER = LOCALHOST; USERNAME = root; PASSWORD = ; DATABASE = marj_hardware");
        public Inventory()
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
            if (dgvProductList.Rows.Count > 0)
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

        private void showOutofStocksItems()
        {
            conn.Open();
            MySqlCommand scom = conn.CreateCommand();
            scom.CommandText = "SELECT barcode, name, brand, category, description, supplier, stocks, selling_price, ceiling, reorder, critical FROM product WHERE kind = 'Product' AND status = 1 AND stocks = 0 ORDER BY name ASC";
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

        private void Inventory_Load(object sender, EventArgs e)
        {
            if (dgvProductList.Rows.Count > 0)
            {
                dgvProductList.Rows[0].Selected = false;
            }
        }

        private void rdbShowAll_CheckedChanged(object sender, EventArgs e)
        {
            showProductList();
        }

        private void rdbSafety_CheckedChanged(object sender, EventArgs e)
        {
            showSafeProducts();
        }

        private void rdbReorder_CheckedChanged(object sender, EventArgs e)
        {
            showReorderProducts();
        }

        private void rdbCritical_CheckedChanged(object sender, EventArgs e)
        {
            showCriticalProducts();
        }

        private void rdbOutofStock_CheckedChanged(object sender, EventArgs e)
        {
            showOutofStocksItems();
        }
    }
}

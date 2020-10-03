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
    public partial class Product_Entry : Form
    {
        MySqlConnection conn = new MySqlConnection("SERVER = localhost; USERNAME = root; PASSWORD = ; DATABASE = marj_hardware");
        public static int reorderPoint;
        public static int criticalLevel;
        public static string getID = "";
        public Product_Entry()
        {
            InitializeComponent();
            showItemList();
            getCategory();
            getBrand();
            getSupplier();
            cmbBrand.SelectedIndex = 0;
            cmbCategory.SelectedIndex = 0;
        }
        //METHODS
        private void showItemList()
        {
            try
            {
                conn.Open();
                MySqlCommand scom = conn.CreateCommand();
                scom.CommandText = "SELECT id, name, brand, category, description, cost_price, ceiling, reorder, critical FROM product WHERE kind = 'Item' ORDER BY id";
                MySqlDataAdapter sda = new MySqlDataAdapter(scom);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                conn.Close();
                dgvItemList.DataSource = dt;

                if (dgvItemList.Rows.Count > 0)
                {
                    dgvItemList.Rows[0].Selected = false;
                }

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void getCategory()
        {
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM category", conn);
            MySqlDataReader myReader;
            try
            {
                conn.Open();
                myReader = cmd.ExecuteReader();

                while (myReader.Read())
                {
                    string categoryName = myReader.GetString("category");
                    cmbCategory.Items.Add(categoryName);
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void getBrand()
        {
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM brand", conn);
            MySqlDataReader myReader;
            try
            {
                conn.Open();
                myReader = cmd.ExecuteReader();

                while (myReader.Read())
                {
                    string brandName = myReader.GetString("name");
                    cmbBrand.Items.Add(brandName);

                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void getSupplier()
        {
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM supplier", conn);
            MySqlDataReader myReader;
            try
            {
                conn.Open();
                myReader = cmd.ExecuteReader();

                while (myReader.Read())
                {
                    string categoryName = myReader.GetString("company_name");
                    //cmbSupplier.Items.Add(categoryName);

                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void clearFields()
        {
            txtItemName.Text = "";
            cmbBrand.SelectedIndex = 0;
            cmbCategory.SelectedIndex = 0;
            txtDescription.Text = "";
            txtCostPrice.Text = "";
            txtCeilingPoint.Text = "";
            txtTotalCritical.Text = "";
            txtTotalReorder.Text = "";
        }

        private void AddFormClosing(object sender, FormClosingEventArgs e)
        {
            showItemList();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (getID != "")
            {
                if (Convert.ToInt32(nupReorder.Value) < Convert.ToInt32(nupCritical.Value))
                {
                    alert.Show("Critical cannot be greather than reorder", alert.AlertType.warning);
                }
                else if (Convert.ToInt32(nupReorder.Value) == Convert.ToInt32(nupCritical.Value))
                {
                    alert.Show("Critical cannot be equal to reorder", alert.AlertType.warning);
                }
                else
                {
                    DialogResult ask = MessageBox.Show("Are you sure you want to update?", "Update Item", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (ask == DialogResult.Yes)
                    {
                        string brand;

                        if (chkNoBrand.Checked == true)
                        {
                            brand = "No Brand";
                        }
                        else
                        {
                            brand = cmbBrand.Text;
                        }

                        conn.Open();
                        MySqlCommand scom = conn.CreateCommand();
                        scom.CommandText = "UPDATE product SET name = @name, brand = @brand, category = @category, description = @description, cost_price = @costPrice, ceiling = @ceiling, reorder = @reorder, critical = @critical WHERE id = @id";

                        scom.Parameters.AddWithValue("@id", getID);
                        scom.Parameters.AddWithValue("@name", txtItemName.Text);
                        scom.Parameters.AddWithValue("@brand", brand);
                        scom.Parameters.AddWithValue("@category", cmbCategory.Text);
                        scom.Parameters.AddWithValue("@description", txtDescription.Text);
                        scom.Parameters.AddWithValue("@costPrice", txtCostPrice.Text);
                        scom.Parameters.AddWithValue("@ceiling", txtCeilingPoint.Text);
                        scom.Parameters.AddWithValue("@reorder", txtTotalReorder.Text);
                        scom.Parameters.AddWithValue("@critical", txtTotalCritical.Text);
                        scom.ExecuteNonQuery();
                        conn.Close();

                        alert.Show("Successfully Updated.", alert.AlertType.success);
                        showItemList();
                    }
                }
            }
            else
            {
                alert.Show("Please select an item.", alert.AlertType.warning);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (getID != "")
            {
                DialogResult ask = MessageBox.Show("Are you sure you want to delete?", "Delete Item", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (ask == DialogResult.Yes)
                {
                    conn.Open();
                    MySqlCommand scom = conn.CreateCommand();
                    scom.CommandText = "DELETE FROM product WHERE id = @id";
                    scom.Parameters.AddWithValue("@id", getID);
                    scom.ExecuteNonQuery();
                    conn.Close();

                    alert.Show("Successfully Deleted.", alert.AlertType.success);
                    clearFields();
                    showItemList();
                }
            }
            else
            {
                alert.Show("Please select an item.", alert.AlertType.warning);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Add_Item add = new Add_Item();
            add.FormClosing += new FormClosingEventHandler(AddFormClosing);
            add.ShowDialog();
        }

        private void dgvItemList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgvItemList.Rows.Count > 0)
            {
                getID = dgvItemList.CurrentRow.Cells["id"].Value.ToString();
                txtItemName.Text = dgvItemList.CurrentRow.Cells["itemName"].Value.ToString();
                cmbBrand.Text = dgvItemList.CurrentRow.Cells["brand"].Value.ToString();
                cmbCategory.Text = dgvItemList.CurrentRow.Cells["category"].Value.ToString();
                txtDescription.Text = dgvItemList.CurrentRow.Cells["description"].Value.ToString();
                txtCostPrice.Text = dgvItemList.CurrentRow.Cells["costPrice"].Value.ToString();
                txtCeilingPoint.Text = dgvItemList.CurrentRow.Cells["ceiling"].Value.ToString();
                txtTotalReorder.Text = dgvItemList.CurrentRow.Cells["reorder"].Value.ToString();
                txtTotalCritical.Text = dgvItemList.CurrentRow.Cells["critical"].Value.ToString();
                nupReorder.Enabled = true;
                nupCritical.Enabled = true;
            }  
        }

        private void Product_Entry_Load(object sender, EventArgs e)
        {
            if (dgvItemList.Rows.Count > 0)
            {
                dgvItemList.Rows[0].Selected = false;
            }
        }

        private void cmbReOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void cmbCriticalLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void dgvItemList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtCostPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            //only allow one decimal point
            if (e.KeyChar == '.' && (sender as Bunifu.Framework.UI.BunifuMetroTextbox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }

            if (!char.IsControl(e.KeyChar))
            {

                Bunifu.Framework.UI.BunifuMetroTextbox textBox = (Bunifu.Framework.UI.BunifuMetroTextbox)sender;

                if (textBox.Text.IndexOf('.') > -1 &&
                         textBox.Text.Substring(textBox.Text.IndexOf('.')).Length >= 3)
                {
                    e.Handled = true;
                }

            }
        }

        private void txtCeilingPoint_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtCeilingPoint_OnValueChanged(object sender, EventArgs e)
        {
            if (txtCeilingPoint.Text != "")
            {
                nupReorder.Enabled = true;
                nupCritical.Enabled = true;
                if (nupCritical.Value != 0 && nupReorder.Value != 0)
                {
                    int ceilingPoint = Convert.ToInt32(txtCeilingPoint.Text);
                    int reorderPoint = Convert.ToInt32(nupReorder.Value);
                    int criticalLevel = Convert.ToInt32(nupCritical.Value);
                    int deliveryP = (ceilingPoint * reorderPoint) / 100;
                    int criticalP = (ceilingPoint * criticalLevel) / 100;

                    txtTotalReorder.Text = deliveryP.ToString();
                    txtTotalCritical.Text = criticalP.ToString();
                }
            }
            else
            {
                nupReorder.Enabled = false;
                nupCritical.Enabled = false;
                txtTotalCritical.Text = "";
                txtTotalReorder.Text = "";
            }
        }

        private void nupReorder_ValueChanged(object sender, EventArgs e)
        {
            if (txtCeilingPoint.Text != "")
            {
                if (nupReorder.Value != 0)
                {
                    int ceilingPoint = Convert.ToInt32(txtCeilingPoint.Text);
                    int reorderPoint = Convert.ToInt32(nupReorder.Value);
                    int deliveryP = (ceilingPoint * reorderPoint) / 100;

                    txtTotalReorder.Text = deliveryP.ToString();
                }
                else
                {
                    nupReorder.Value = 1;
                }
            }
        }

        private void nupCritical_ValueChanged(object sender, EventArgs e)
        {
            if (txtCeilingPoint.Text != "")
            {
                if (nupCritical.Value != 0)
                {
                    int ceilingPoint = Convert.ToInt32(txtCeilingPoint.Text);
                    int criticalLevel = Convert.ToInt32(nupCritical.Value);
                    int criticalP = (ceilingPoint * criticalLevel) / 100;

                    txtTotalCritical.Text = criticalP.ToString();
                }
                else
                {
                    nupCritical.Value = 1;
                }
            }
        }
    }
}

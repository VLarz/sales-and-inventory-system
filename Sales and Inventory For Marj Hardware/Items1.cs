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
    public partial class Item_Management : UserControl
    {
        private static Item_Management _instance;

        public static Item_Management Instance
        {
            get
            {
                if(_instance == null)
                    _instance = new Item_Management();
                return _instance; 
            }
        }
        
        MySqlConnection conn = new MySqlConnection("SERVER = localhost; USERNAME = root; PASSWORD = ; DATABASE = marj_hardware");
        public static int reorderPoint;
        public static int criticalLevel;
        public static string getID = "";
        public Item_Management()
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

                if(dgvItemList.Rows.Count > 0)
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
                    string categoryName = myReader.GetString("name");
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
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (getID != "")
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
                    scom.CommandText = "DELETE FROM product WHERE barcode = @barcode";
                    scom.Parameters.AddWithValue("@barcode", getID);
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

        private void AddFormClosing(object sender, FormClosingEventArgs e)
        {
            showItemList();
        }

        private void btnSearch_OnTextChange(object sender, EventArgs e)
        {

        }

        private void txtSearch_OnTextChange(object sender, EventArgs e)
        {

            if(txtSearch.text != "")
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = conn.CreateCommand();
                    cmd.CommandText = "SELECT barcode, name, brand, category, description, cost_price, supplier, ceiling, reorder, critical FROM product WHERE name LIKE '%" + txtSearch.text + "%' AND stocks = 0 ORDER BY barcode DESC";
                    cmd.Parameters.AddWithValue("@name", txtSearch.text);
                    MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    conn.Close();
                    dgvItemList.DataSource = dt;
                    if(dgvItemList.RowCount > 0)
                    {
                        dgvItemList.Rows[0].Selected = false;
                    }
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                showItemList();
                dgvItemList.Rows[0].Selected = false;
            }
            

        }


        private void dgvItemList_CellClick(object sender, DataGridViewCellEventArgs e)
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
            cmbReOrder.Enabled = true;
            cmbCriticalLevel.Enabled = true;
        }

        private void btnAddUser2_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Add_Item add = new Add_Item();
            add.FormClosing += new FormClosingEventHandler(AddFormClosing);
            add.ShowDialog();
        }

        private void pnlMinimize1_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void txtSearch_KeyDown(object sender, EventArgs e)
        {
            if (txtSearch.text == "Search")
            {
                txtSearch.text = "";
            }
        }

        private void Items_Load(object sender, EventArgs e)
        {
            if(dgvItemList.Rows.Count > 0)
            {
                dgvItemList.Rows[0].Selected = false;
            }
          
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
        }

        private void txtSearch_Click(object sender, EventArgs e)
        {

        }

        private void txtSearch_MouseClick(object sender, MouseEventArgs e)
        {
            txtSearch.text = "";
        }

        private void dgvItemList_CellBorderStyleChanged(object sender, EventArgs e)
        {

        }

        private void bunifuCards4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void txtCeilingPoint_OnValueChanged(object sender, EventArgs e)
        {
            
        }

        private void txtCostPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            // only allow one decimal point
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

        private void cmbReOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(txtCeilingPoint.Text != "")
            {
                if (cmbReOrder.SelectedItem.ToString() == "50%")
                {
                    reorderPoint = 50;
                    int testing = Convert.ToInt32(txtCeilingPoint.Text);
                    int aa = (Convert.ToInt32(50 * testing) / 100);
                    txtTotalReorder.Text = Convert.ToString(aa);
                    cmbCriticalLevel.Items.Clear();
                    cmbCriticalLevel.Items.Add("45%");
                    cmbCriticalLevel.Items.Add("40%");
                    cmbCriticalLevel.Items.Add("35%");
                    cmbCriticalLevel.Items.Add("30%");
                    cmbCriticalLevel.Items.Add("25%");
                    cmbCriticalLevel.Items.Add("20%");
                    cmbCriticalLevel.Items.Add("15%");
                    cmbCriticalLevel.Items.Add("10%");
                    cmbCriticalLevel.Items.Add("5%");
                    cmbCriticalLevel.SelectedIndex = 0;
                }
                else if (cmbReOrder.SelectedItem.ToString() == "45%")
                {
                    reorderPoint = 45;
                    int testing = Convert.ToInt32(txtCeilingPoint.Text);
                    int aa = (Convert.ToInt32(45 * testing) / 100);
                    txtTotalReorder.Text = Convert.ToString(aa);
                    cmbCriticalLevel.Items.Clear();
                    cmbCriticalLevel.Items.Add("40%");
                    cmbCriticalLevel.Items.Add("35%");
                    cmbCriticalLevel.Items.Add("30%");
                    cmbCriticalLevel.Items.Add("25%");
                    cmbCriticalLevel.Items.Add("20%");
                    cmbCriticalLevel.Items.Add("15%");
                    cmbCriticalLevel.Items.Add("10%");
                    cmbCriticalLevel.Items.Add("5%");
                    cmbCriticalLevel.SelectedIndex = 0;
                }
                else if (cmbReOrder.SelectedItem.ToString() == "40%")
                {
                    reorderPoint = 40;
                    int testing = Convert.ToInt32(txtCeilingPoint.Text);
                    int aa = (Convert.ToInt32(40 * testing) / 100);
                    txtTotalReorder.Text = Convert.ToString(aa);
                    cmbCriticalLevel.Items.Clear();
                    cmbCriticalLevel.Items.Remove("40%");
                    cmbCriticalLevel.Items.Clear();
                    cmbCriticalLevel.Items.Add("35%");
                    cmbCriticalLevel.Items.Add("30%");
                    cmbCriticalLevel.Items.Add("25%");
                    cmbCriticalLevel.Items.Add("20%");
                    cmbCriticalLevel.Items.Add("15%");
                    cmbCriticalLevel.Items.Add("10%");
                    cmbCriticalLevel.Items.Add("5%");
                    cmbCriticalLevel.SelectedIndex = 0;
                }
                else if (cmbReOrder.SelectedItem.ToString() == "35%")
                {
                    reorderPoint = 35;
                    int testing = Convert.ToInt32(txtCeilingPoint.Text);
                    int aa = (Convert.ToInt32(35 * testing) / 100);
                    txtTotalReorder.Text = Convert.ToString(aa);
                    cmbCriticalLevel.Items.Clear();
                    cmbCriticalLevel.Items.Remove("40%");
                    cmbCriticalLevel.Items.Remove("35%");
                    cmbCriticalLevel.Items.Clear();
                    cmbCriticalLevel.Items.Add("25%");
                    cmbCriticalLevel.Items.Add("20%");
                    cmbCriticalLevel.Items.Add("15%");
                    cmbCriticalLevel.Items.Add("10%");
                    cmbCriticalLevel.Items.Add("5%");
                    cmbCriticalLevel.SelectedIndex = 0;
                }
                else if (cmbReOrder.SelectedItem.ToString() == "30%")
                {
                    reorderPoint = 30;
                    int testing = Convert.ToInt32(txtCeilingPoint.Text);
                    int aa = (Convert.ToInt32(30 * testing) / 100);
                    txtTotalReorder.Text = Convert.ToString(aa);
                    cmbCriticalLevel.Items.Clear();
                    cmbCriticalLevel.Items.Remove("40%");
                    cmbCriticalLevel.Items.Remove("35%");
                    cmbCriticalLevel.Items.Remove("30%");
                    cmbCriticalLevel.Items.Clear();
                    cmbCriticalLevel.Items.Add("25%");
                    cmbCriticalLevel.Items.Add("20%");
                    cmbCriticalLevel.Items.Add("15%");
                    cmbCriticalLevel.Items.Add("10%");
                    cmbCriticalLevel.Items.Add("5%");
                    cmbCriticalLevel.SelectedIndex = 0;
                }
                else if (cmbReOrder.SelectedItem.ToString() == "25%")
                {
                    reorderPoint = 25;
                    int testing = Convert.ToInt32(txtCeilingPoint.Text);
                    int aa = (Convert.ToInt32(25 * testing) / 100);
                    txtTotalReorder.Text = Convert.ToString(aa);
                    cmbCriticalLevel.Items.Clear();
                    cmbCriticalLevel.Items.Remove("40%");
                    cmbCriticalLevel.Items.Remove("35%");
                    cmbCriticalLevel.Items.Remove("30%");
                    cmbCriticalLevel.Items.Remove("25%");
                    cmbCriticalLevel.Items.Clear();
                    cmbCriticalLevel.Items.Add("20%");
                    cmbCriticalLevel.Items.Add("15%");
                    cmbCriticalLevel.Items.Add("10%");
                    cmbCriticalLevel.Items.Add("5%");
                    cmbCriticalLevel.SelectedIndex = 0;
                }
                else if (cmbReOrder.SelectedItem.ToString() == "20%")
                {
                    reorderPoint = 20;
                    int testing = Convert.ToInt32(txtCeilingPoint.Text);
                    int aa = (Convert.ToInt32(20 * testing) / 100);
                    txtTotalReorder.Text = Convert.ToString(aa);
                    cmbCriticalLevel.Items.Clear();
                    cmbCriticalLevel.Items.Remove("40%");
                    cmbCriticalLevel.Items.Remove("35%");
                    cmbCriticalLevel.Items.Remove("30%");
                    cmbCriticalLevel.Items.Remove("25%");
                    cmbCriticalLevel.Items.Remove("20%");
                    cmbCriticalLevel.Items.Clear();
                    cmbCriticalLevel.Items.Add("15%");
                    cmbCriticalLevel.Items.Add("10%");
                    cmbCriticalLevel.Items.Add("5%");
                    cmbCriticalLevel.SelectedIndex = 0;
                }
                else if (cmbReOrder.SelectedItem.ToString() == "15%")
                {
                    reorderPoint = 15;
                    int testing = Convert.ToInt32(txtCeilingPoint.Text);
                    int aa = (Convert.ToInt32(15 * testing) / 100);
                    txtTotalReorder.Text = Convert.ToString(aa);
                    cmbCriticalLevel.Items.Clear();
                    cmbCriticalLevel.Items.Remove("40%");
                    cmbCriticalLevel.Items.Remove("35%");
                    cmbCriticalLevel.Items.Remove("30%");
                    cmbCriticalLevel.Items.Remove("25%");
                    cmbCriticalLevel.Items.Remove("20%");
                    cmbCriticalLevel.Items.Remove("15%");
                    cmbCriticalLevel.Items.Clear();
                    cmbCriticalLevel.Items.Add("10%");
                    cmbCriticalLevel.Items.Add("5%");
                    cmbCriticalLevel.SelectedIndex = 0;
                }
                else if (cmbReOrder.SelectedItem.ToString() == "10%")
                {
                    reorderPoint = 10;
                    int testing = Convert.ToInt32(txtCeilingPoint.Text);
                    int aa = (Convert.ToInt32(10 * testing) / 100);
                    txtTotalReorder.Text = Convert.ToString(aa);
                    cmbCriticalLevel.Items.Clear();
                    cmbCriticalLevel.Items.Remove("40%");
                    cmbCriticalLevel.Items.Remove("35%");
                    cmbCriticalLevel.Items.Remove("30%");
                    cmbCriticalLevel.Items.Remove("25%");
                    cmbCriticalLevel.Items.Remove("20%");
                    cmbCriticalLevel.Items.Remove("15%");
                    cmbCriticalLevel.Items.Remove("10%");
                    cmbCriticalLevel.Items.Clear();
                    cmbCriticalLevel.Items.Add("5%");
                    cmbCriticalLevel.SelectedIndex = 0;
                }
            }
        }

        private void cmbCriticalLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCriticalLevel.SelectedItem.ToString() == "45%")
            {
                criticalLevel = 45;
                int testing = Convert.ToInt32(txtCeilingPoint.Text);
                int aa = (Convert.ToInt32(45 * testing) / 100);
                txtTotalCritical.Text = Convert.ToString(aa);
            }
            else if (cmbCriticalLevel.SelectedItem.ToString() == "40%")
            {
                criticalLevel = 40;
                int testing = Convert.ToInt32(txtCeilingPoint.Text);
                int aa = (Convert.ToInt32(40 * testing) / 100);
                txtTotalCritical.Text = Convert.ToString(aa);
            }
            else if (cmbCriticalLevel.SelectedItem.ToString() == "35%")
            {
                criticalLevel = 35;
                int testing = Convert.ToInt32(txtCeilingPoint.Text);
                int aa = (Convert.ToInt32(35 * testing) / 100);
                txtTotalCritical.Text = Convert.ToString(aa);
            }
            else if (cmbCriticalLevel.SelectedItem.ToString() == "30%")
            {
                criticalLevel = 30;
                int testing = Convert.ToInt32(txtCeilingPoint.Text);
                int aa = (Convert.ToInt32(30 * testing) / 100);
                txtTotalCritical.Text = Convert.ToString(aa);
            }
            else if (cmbCriticalLevel.SelectedItem.ToString() == "25%")
            {
                criticalLevel = 25;
                int testing = Convert.ToInt32(txtCeilingPoint.Text);
                int aa = (Convert.ToInt32(25 * testing) / 100);
                txtTotalCritical.Text = Convert.ToString(aa);
            }
            else if (cmbCriticalLevel.SelectedItem.ToString() == "20%")
            {
                criticalLevel = 20;
                int testing = Convert.ToInt32(txtCeilingPoint.Text);
                int aa = (Convert.ToInt32(20 * testing) / 100);
                txtTotalCritical.Text = Convert.ToString(aa);
            }
            else if (cmbCriticalLevel.SelectedItem.ToString() == "15%")
            {
                criticalLevel = 15;
                int testing = Convert.ToInt32(txtCeilingPoint.Text);
                int aa = (Convert.ToInt32(15 * testing) / 100);
                txtTotalCritical.Text = Convert.ToString(aa);
            }
            else if (cmbCriticalLevel.SelectedItem.ToString() == "10%")
            {
                criticalLevel = 10;
                int testing = Convert.ToInt32(txtCeilingPoint.Text);
                int aa = (Convert.ToInt32(10 * testing) / 100);
                txtTotalCritical.Text = Convert.ToString(aa);
            }
            else if (cmbCriticalLevel.SelectedItem.ToString() == "5%")
            {
                criticalLevel = 5;
                int testing = Convert.ToInt32(txtCeilingPoint.Text);
                int aa = (Convert.ToInt32(5 * testing) / 100);
                txtTotalCritical.Text = Convert.ToString(aa);
            }
        }
    }
}

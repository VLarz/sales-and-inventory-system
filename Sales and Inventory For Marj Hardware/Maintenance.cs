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
    public partial class Maintenance : Form
    {
        MySqlConnection conn = new MySqlConnection("SERVER = localhost; USERNAME = root; PASSWORD = ; DATABASE = marj_hardware");
        public Maintenance()
        {
            InitializeComponent();
            getBrand();
            cmbBrand.SelectedIndex = 0;
           
        }

        //METHODS
        private void showCategoryList()
        {
            conn.Open();
            MySqlCommand scom = conn.CreateCommand();
            scom.CommandText = "SELECT id, brand, category FROM category WHERE status = 1 ORDER BY id DESC";
            MySqlDataAdapter sda = new MySqlDataAdapter(scom);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            conn.Close();
            dgvCategoryList.DataSource = dt;

            if(dgvCategoryList.Rows.Count > 0)
            {
                dgvCategoryList.Rows[0].Selected = false;
            }
        }

        private void showBrandList()
        {
            conn.Open();
            MySqlCommand scom = conn.CreateCommand();
            scom.CommandText = "SELECT id, name FROM brand WHERE status = 1 ORDER BY id DESC";
            MySqlDataAdapter sda = new MySqlDataAdapter(scom);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            conn.Close();
            dgvBrandList.DataSource = dt;

            if(dgvBrandList.Rows.Count > 0)
            {
                dgvBrandList.Rows[0].Selected = false;
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

        private void Maintenance_Load(object sender, EventArgs e)
        {
            showCategoryList();
            showBrandList();
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            if(cmbBrand.SelectedIndex != 0)
            {
                if (txtCategoryName.Text != "")
                {
                    MySqlCommand cmd = new MySqlCommand("SELECT * FROM category WHERE category = @category AND brand = @brand", conn);
                    cmd.Parameters.AddWithValue("@category", txtCategoryName.Text);
                    cmd.Parameters.AddWithValue("@brand", cmbBrand.Text);
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    int i = ds.Tables[0].Rows.Count;
                    if (i > 0)
                    {
                        alert.Show("Category Name " + txtCategoryName.Text + " Already Exists.", alert.AlertType.error);
                        ds.Clear();
                    }
                    else
                    {
                        DialogResult ask = MessageBox.Show("Are your sure you want to add?", "Add Category", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (ask == DialogResult.Yes)
                        {
                            conn.Open();
                            MySqlCommand scom = conn.CreateCommand();
                            scom.CommandText = "INSERT INTO category (brand, category) VALUES (@brand, @category)";
                            scom.Parameters.AddWithValue("@brand", cmbBrand.Text);
                            scom.Parameters.AddWithValue("@category", txtCategoryName.Text);
                            scom.ExecuteNonQuery();
                            conn.Close();

                            txtCategoryName.Text = "";
                            cmbBrand.SelectedIndex = 0;
                            alert.Show("Successfully Added.", alert.AlertType.success);
                            showCategoryList();
                        }
                    }
                }
                else
                {
                    alert.Show("Category name is empty.", alert.AlertType.warning);
                }
            }
            else
            {
                alert.Show("Please select brand.", alert.AlertType.warning);
            }
        }

        private void btnUpdateCategory_Click(object sender, EventArgs e)
        {
            if(txtCategoryID.Text != "")
            {
                DialogResult ask = MessageBox.Show("Are your sure you want to update?", "Update Category", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (ask == DialogResult.Yes)
                {
                    conn.Open();
                    MySqlCommand scom = conn.CreateCommand();
                    scom.CommandText = "UPDATE category SET category = @name, brand = @brand WHERE id = @id";
                    scom.Parameters.AddWithValue("@name", txtCategoryName.Text);
                    scom.Parameters.AddWithValue("@brand", cmbBrand.Text);
                    scom.Parameters.AddWithValue("@id", txtCategoryID.Text);
                    scom.ExecuteNonQuery();
                    conn.Close();
                    alert.Show("Successfully Updated.", alert.AlertType.success);
                    showCategoryList();
                }
            }
        }

        private void dgvCategoryList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCategoryID.Text = dgvCategoryList.CurrentRow.Cells["categoryID"].Value.ToString();
            txtCategoryName.Text = dgvCategoryList.CurrentRow.Cells["categoryName"].Value.ToString();
        }

        private void btnSearch_OnTextChange(object sender, EventArgs e)
        {
            if (txtSearch.text != "")
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = conn.CreateCommand();
                    cmd.CommandText = "SELECT id, name FROM category WHERE name LIKE '%" + txtSearch.text + "%' AND status = @1 ORDER BY id DESC";
                    cmd.Parameters.AddWithValue("@name", txtSearch.text);
                    cmd.Parameters.AddWithValue("@1", "1");
                    MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    conn.Close();
                    dgvCategoryList.DataSource = dt;
                    if (dgvCategoryList.RowCount > 0)
                    {
                        dgvCategoryList.Rows[0].Selected = false;
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                showCategoryList();

            }
        }

        private void btnProductLine_Click(object sender, EventArgs e)
        {
            indicator.Location = new Point(15, 57);
            btnBrand.Textcolor = Color.DimGray;
            btnProductLine.Textcolor = Color.FromArgb(20, 23, 26);
            pnlBrand.Visible = true;
        }

        private void btnBrand_Click(object sender, EventArgs e)
        {
            indicator.Location = new Point(176, 57);
            btnBrand.Textcolor = Color.FromArgb(20, 23, 26);
            btnProductLine.Textcolor = Color.DimGray;
            pnlBrand.Visible = false;
        }

        private void txtSearch_KeyPress(object sender, EventArgs e)
        {
            if(txtSearch.text == "Search")
            {
                txtSearch.text = "";
            }
        }

        private void dgvBrandList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtBrandID.Text = dgvBrandList.CurrentRow.Cells["brandID"].Value.ToString();
            txtBrandName.Text = dgvBrandList.CurrentRow.Cells["brandName"].Value.ToString();
        }

        private void txtUpdateBrand_Click(object sender, EventArgs e)
        {
            if (txtBrandID.Text != "")
            {
                DialogResult ask = MessageBox.Show("Are your sure you want to update?", "Update Brand", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (ask == DialogResult.Yes)
                {
                    conn.Open();
                    MySqlCommand scom = conn.CreateCommand();
                    scom.CommandText = "UPDATE brand SET name = @name";
                    scom.Parameters.AddWithValue("@name", txtBrandName.Text);
                    scom.ExecuteNonQuery();
                    conn.Close();
                    alert.Show("Successfully Updated.", alert.AlertType.success);
                    showBrandList();
                    getBrand();
                }
            }
        }

        private void txtAddBrand_Click(object sender, EventArgs e)
        {
            if (txtBrandName.Text != "")
            {
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM brand WHERE name = @brand", conn);
                cmd.Parameters.AddWithValue("@brand", txtBrandName.Text);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                int i = ds.Tables[0].Rows.Count;
                if (i > 0)
                {
                    alert.Show("Category Name " + txtBrandName.Text + " Already Exists.", alert.AlertType.error);
                    ds.Clear();
                }
                else
                {
                    DialogResult ask = MessageBox.Show("Are your sure you want to add?", "Add Brand", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (ask == DialogResult.Yes)
                    {
                        conn.Open();
                        MySqlCommand scom = conn.CreateCommand();
                        scom.CommandText = "INSERT INTO brand (name, status) VALUES (@name, @status)";
                        scom.Parameters.AddWithValue("@name", txtBrandName.Text);
                        scom.Parameters.AddWithValue("@status", 1);
                        scom.ExecuteNonQuery();
                        conn.Close();
                        alert.Show("Successfully Added.", alert.AlertType.success);
                        txtBrandID.Text = "";
                        txtBrandName.Text = "";
                        showBrandList();
                        getBrand();
                    }
                }
            }
            else
            {
                alert.Show("Brand name is empty.", alert.AlertType.warning);
            }
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtRemoveCategory_Click(object sender, EventArgs e)
        {
            if (txtBrandID.Text != "")
            {
                DialogResult ask = MessageBox.Show("Are your sure you want to remove?", "Remove Brand", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (ask == DialogResult.Yes)
                {
                    conn.Open();
                    MySqlCommand scom = conn.CreateCommand();
                    scom.CommandText = "DELETE FROM brand WHERE id = @id";
                    scom.Parameters.AddWithValue("@id", txtBrandID.Text);
                    scom.ExecuteNonQuery();
                    conn.Close();
                    alert.Show("Successfully Deleted.", alert.AlertType.success);
                    txtBrandID.Text = "";
                    txtBrandName.Text = "";
                    showBrandList();
                    getBrand();
                }
            }
        }

        private void cmbBrand_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbBrand.SelectedIndex == 0)
            {
                txtCategoryName.Enabled = false;
            }
            else
            {
                txtCategoryName.Enabled = true;
            }
        }

        private void picSetVAT_Click(object sender, EventArgs e)
        {
            VAT vet = new VAT();
            vet.Show();
        }
    }
}

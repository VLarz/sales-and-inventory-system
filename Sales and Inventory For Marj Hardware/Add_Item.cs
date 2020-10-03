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
    public partial class Add_Item : MaterialSkin.Controls.MaterialForm
    {
        MySqlConnection conn = new MySqlConnection("SERVER = localhost; USERNAME = root; PASSWORD = ; DATABASE = marj_hardware");
        MaterialSkinManager skinManager;
        public Add_Item()
        {
            InitializeComponent();
            skinManager = MaterialSkinManager.Instance;
            SkinManager.AddFormToManage(this);
            SkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            SkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Blue800, MaterialSkin.Primary.Blue900, MaterialSkin.Primary.Blue900, MaterialSkin.Accent.Orange700, MaterialSkin.TextShade.WHITE);
            getBrand();
            cmbBrand.SelectedIndex = 0;
            cmbCategory.SelectedIndex = 0;
        }

        //METHODS
        private void clearFields()
        {
            txtItemName.Text = "";
            cmbBrand.SelectedIndex = 0;
            cmbCategory.SelectedIndex = 0;
            txtDescription.Text = "";
            txtCostPrice.Text = "";
            txtCeilingPoint.Text = "";
            nupCritical.Value = 25;
            nupReorder.Value = 50;
            txtTotalCritical.Text = "";
            txtTotalReorder.Text = "";
            chkNoBrand.Checked = false;
        }

        private void getCategory()
        {
            cmbCategory.Items.Clear();
            cmbCategory.Items.Add("Select Category");
            cmbCategory.SelectedIndex = 0;
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM category WHERE brand = @brand", conn);
            cmd.Parameters.AddWithValue("@brand", cmbBrand.Text);
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

        private void getCategory1()
        {
            cmbCategory.Items.Clear();
            cmbCategory.Items.Add("Select Category");
            cmbCategory.SelectedIndex = 0;
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

        private void Add_Item_Load(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void cmbReOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cmbCriticalLevel_SelectedIndexChanged(object sender, EventArgs e)
        {      
        }

        private void cmbReOrder_SelectedIndexChanged_1(object sender, EventArgs e)
        {
        }

        private void txtCeilingPoint_OnValueChanged(object sender, EventArgs e)
        {
            if(txtCeilingPoint.Text != "")
            {
                nupReorder.Enabled = true;
                nupCritical.Enabled = true;
                if(nupCritical.Value != 0 && nupReorder.Value != 0)
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

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            string brand;

            if (chkNoBrand.Checked == true)
            {
                brand = "No Brand";
            }
            else
            {
                if(cmbBrand.SelectedIndex != 0)
                {
                    brand = cmbBrand.Text;
                }
                else
                {
                    brand = "";
                }
            }
            if(Convert.ToInt32(nupReorder.Value) < Convert.ToInt32(nupCritical.Value))
            {
                alert.Show("Critical cannot be greather than reorder", alert.AlertType.warning);
            }
            else if(Convert.ToInt32(nupReorder.Value) == Convert.ToInt32(nupCritical.Value))
            {
                alert.Show("Critical cannot be equal to reorder", alert.AlertType.warning);
            }
            else
            {
                if (txtItemName.Text != "" && brand != "" && cmbCategory.SelectedIndex != 0 && txtDescription.Text != "" && txtCostPrice.Text != "" && txtCeilingPoint.Text != "" && txtTotalReorder.Text != "" && txtTotalCritical.Text != "")
                {
                    try
                    {
                        conn.Open();
                        MySqlCommand scom = conn.CreateCommand();
                        scom.CommandText = "INSERT INTO product (name, brand, category, description, cost_price, ceiling, reorder, critical, kind, status) VALUES (@name, @brand, @category, @description, @cost_price, @ceiling, @reorder, @critical, @kind, @status)";
                        scom.Parameters.AddWithValue("@name", txtItemName.Text);
                        scom.Parameters.AddWithValue("@brand", brand);
                        scom.Parameters.AddWithValue("@category", cmbCategory.Text);
                        scom.Parameters.AddWithValue("@description", txtDescription.Text);
                        scom.Parameters.AddWithValue("@cost_price", txtCostPrice.Text);
                        scom.Parameters.AddWithValue("@ceiling", txtCeilingPoint.Text);
                        scom.Parameters.AddWithValue("@reorder", txtTotalReorder.Text);
                        scom.Parameters.AddWithValue("@critical", txtTotalCritical.Text);
                        scom.Parameters.AddWithValue("@kind", "Item");
                        scom.Parameters.AddWithValue("@status", "1");
                        scom.ExecuteNonQuery();
                        conn.Close();

                        alert.Show("You have successfully added an item.", alert.AlertType.success);
                        clearFields();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    alert.Show("Please fill in all the details.", alert.AlertType.warning);

                }
            } 
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearFields();
            alert.Show("Fields Cleared.", alert.AlertType.info);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
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

        private void chkAuto_OnChange(object sender, EventArgs e)
        {

        }

        private void nupReorder_ValueChanged(object sender, EventArgs e)
        {
            if (txtCeilingPoint.Text != "")
            {
                if(nupReorder.Value != 0)
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

        private void cmbBrand_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbBrand.SelectedIndex == 0)
            {
                cmbCategory.Enabled = false;
            }
            else
            {
                cmbCategory.Enabled = true;
                getCategory();
            }
        }

        private void chkNoBrand_OnChange(object sender, EventArgs e)
        {
            if(chkNoBrand.Checked == true)
            {
                cmbCategory.Enabled = true;
                getCategory1();
            }
            else
            {
                cmbCategory.Enabled = false;
            }
        }
    } 
}

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
using System.Text.RegularExpressions;

namespace Sales_and_Inventory_For_Marj_Hardware
{
    public partial class Add_Supplier : MaterialSkin.Controls.MaterialForm
    {
        MySqlConnection conn = new MySqlConnection("SERVER = localhost; USERNAME = root; PASSWORD = ; DATABASE = marj_hardware");
        MaterialSkinManager skinManager;
        public Add_Supplier()
        {
            InitializeComponent();
            skinManager = MaterialSkinManager.Instance;
            SkinManager.AddFormToManage(this);
            SkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            SkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Blue800, MaterialSkin.Primary.Blue900, MaterialSkin.Primary.Blue900, MaterialSkin.Accent.Orange700, MaterialSkin.TextShade.WHITE);

        }
        //METHODS
        private void clearAddFields()
        {
            txtCompanyName.Text = "";
            txtContactPerson.Text = "";
            cmbGender.SelectedIndex = 0;
            txtAddress.Text = "";
            txtContactNumber.Text = "";
            txtEmailAddress.Text = "";
            lblEmailValidation.Text = "";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            DialogResult ask = MessageBox.Show("Are you sure you want to clear?", "Clear Fields", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ask == DialogResult.Yes)
            {
                clearAddFields();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtCompanyName.Text != "" && txtContactPerson.Text != "" && cmbGender.SelectedIndex != 0 && txtAddress.Text != "" && txtContactNumber.Text != "" && txtEmailAddress.Text != "" && lblEmailValidation.Text == "")
            {
                DialogResult ask = MessageBox.Show("Are you sure you want to add", "Add Supplier", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (ask == DialogResult.Yes)
                {
                    try
                    {
                        conn.Open();
                        MySqlCommand scom = conn.CreateCommand();
                        scom.CommandText = "INSERT INTO supplier (company_name, contact_person, gender, address, contact_number, email, active) VALUES (@companyName, @contactPerson, @gender, @address, @contactNumber, @email, @active)";
                        scom.Parameters.AddWithValue("@companyName", txtCompanyName.Text);
                        scom.Parameters.AddWithValue("@contactPerson", txtContactPerson.Text);
                        scom.Parameters.AddWithValue("@gender", cmbGender.Text);
                        scom.Parameters.AddWithValue("@address", txtAddress.Text);
                        scom.Parameters.AddWithValue("@contactNumber", txtContactNumber.Text);
                        scom.Parameters.AddWithValue("@email", txtEmailAddress.Text);
                        scom.Parameters.AddWithValue("@active", 1);
                        scom.ExecuteNonQuery();
                        conn.Close();

                        alert.Show("Successfully Added.", alert.AlertType.success);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            else
            {
                alert.Show("Please fill in all the details.", alert.AlertType.success);
            }
        }

        private void txtContactNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtContactNumber_Leave(object sender, EventArgs e)
        {
            if (txtEmailAddress.Text != "")
            {
                string pattern = @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-0-9a-z]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$";

                if (Regex.IsMatch(txtEmailAddress.Text, pattern))
                {
                    lblEmailValidation.Text = "";
                }
                else
                {
                    lblEmailValidation.Text = "Incorrect email format.";
                }
            }
            else
            {
                lblEmailValidation.Text = "";
            }
        }
    }
}

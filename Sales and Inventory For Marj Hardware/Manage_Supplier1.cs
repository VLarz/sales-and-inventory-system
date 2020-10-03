using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using MySql.Data.MySqlClient;

namespace Sales_and_Inventory_For_Marj_Hardware
{
    public partial class Manage_Supplier1 : UserControl
    {
        private static Manage_Supplier1 _instance;

        public static Manage_Supplier1 Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Manage_Supplier1();
                return _instance;
            }
        }
        MySqlConnection conn = new MySqlConnection("SERVER = localhost; USERNAME = root; PASSWORD = ; DATABASE = marj_hardware");
        public Manage_Supplier1()
        {
            InitializeComponent();
            showSupplierList();
        }

        //METHODS
        private void clearAddFields()
        {
            txtCompanyName2.Text = "";
            txtContactPerson2.Text = "";
            cmbGender2.SelectedIndex = 0;
            txtAddress2.Text = "";
            txtContactNumber2.Text = "";
            txtEmailAddress2.Text = "";
            lblEmailValidation.Text = "";
        }
        private void clearFields()
        {
            txtCompanyName.Text = "";
            txtContactPerson.Text = "";
            txtAddress.Text = "";
            txtContactNumber.Text = "";
            txtEmailAddress.Text = "";
        }


        private void showSupplierList()
        {
            try
            {
                conn.Open();
                MySqlCommand scom = conn.CreateCommand();
                scom.CommandText = "SELECT company_name, contact_person, gender, address, contact_number, email, remark FROM supplier WHERE active = 1";
                MySqlDataAdapter sda = new MySqlDataAdapter(scom);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                conn.Close();
                dgvSupplierList.DataSource = dt;
                if (dgvSupplierList.Rows.Count > 0)
                {
                    dgvSupplierList.Rows[0].Selected = false;
                }        
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void bunifuCards1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Manage_Supplier_Load(object sender, EventArgs e)
        {
            if (dgvSupplierList.Rows.Count > 0)
            {
                dgvSupplierList.Rows[0].Selected = false;
            }
        }

        private void dgvUserList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCompanyName.Text = dgvSupplierList.CurrentRow.Cells["companyName"].Value.ToString();
            txtContactPerson.Text = dgvSupplierList.CurrentRow.Cells["contactPerson"].Value.ToString();
            txtAddress.Text = dgvSupplierList.CurrentRow.Cells["address"].Value.ToString();
            txtContactNumber.Text = dgvSupplierList.CurrentRow.Cells["contactNumber"].Value.ToString();
            txtEmailAddress.Text = dgvSupplierList.CurrentRow.Cells["emailAddress"].Value.ToString();
            txtRemark.Text = dgvSupplierList.CurrentRow.Cells["remark"].Value.ToString();
        }

        private void pnlAddItem_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtEmail2_Leave(object sender, EventArgs e)
        {
            if (txtEmailAddress2.Text != "")
            {
                string pattern = @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-0-9a-z]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$";

                if (Regex.IsMatch(txtEmailAddress2.Text, pattern))
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

        private void btnAddSupplier2_Click(object sender, EventArgs e)
        {
            if (txtCompanyName2.Text != "" && txtContactPerson2.Text != "" && cmbGender2.SelectedIndex != 0 && txtAddress2.Text != "" && txtContactNumber2.Text != "" && txtEmailAddress2.Text != "" && lblEmailValidation.Text == "")
            {
                DialogResult ask = MessageBox.Show("Are you sure you want to add", "Add Supplier", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (ask == DialogResult.Yes)
                {
                    try
                    {
                        conn.Open();
                        MySqlCommand scom = conn.CreateCommand();
                        scom.CommandText = "INSERT INTO supplier (company_name, contact_person, gender, address, contact_number, email, active) VALUES (@companyName, @contactPerson, @gender, @address, @contactNumber, @email, @active)";
                        scom.Parameters.AddWithValue("@companyName", txtCompanyName2.Text);
                        scom.Parameters.AddWithValue("@contactPerson", txtContactPerson2.Text);
                        scom.Parameters.AddWithValue("@gender", cmbGender2.Text);
                        scom.Parameters.AddWithValue("@address", txtAddress2.Text);
                        scom.Parameters.AddWithValue("@contactNumber", txtContactNumber2.Text);
                        scom.Parameters.AddWithValue("@email", txtEmailAddress2.Text);
                        scom.Parameters.AddWithValue("@active", 1);
                        scom.ExecuteNonQuery();
                        conn.Close();

                        alert.Show("Successfully Added.", alert.AlertType.success);
                        showSupplierList();
                        clearAddFields();
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

        private void txtContactNumber2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            DialogResult ask = MessageBox.Show("Are you sure you want to clear?", "Clear Fields", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ask == DialogResult.Yes)
            {
                clearAddFields();
            }
        }

        private void btnUpdateSupplier_Click(object sender, EventArgs e)
        {
            DialogResult ask = MessageBox.Show("Are you sure you want to update?", "Update Supplier", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ask == DialogResult.Yes)
            {
                conn.Open();
                MySqlCommand scom = conn.CreateCommand();
                scom.CommandText = "UPDATE supplier SET company_name = @companyName, contact_person = @contactPerson, address = @address, contact_number = @contactNumber, email = @email, remark = @remark WHERE company_name = @companyName AND contact_person = @contactPerson";
                scom.Parameters.AddWithValue("@companyName", txtCompanyName.Text);
                scom.Parameters.AddWithValue("@contactPerson", txtContactPerson.Text);
                scom.Parameters.AddWithValue("@address", txtAddress.Text);
                scom.Parameters.AddWithValue("@contactNumber", txtContactNumber.Text);
                scom.Parameters.AddWithValue("@email", txtEmailAddress.Text);
                scom.Parameters.AddWithValue("@remark", txtRemark.Text);
                scom.ExecuteNonQuery();
                conn.Close();

                alert.Show("Succcessfully Updated.", alert.AlertType.success);
                showSupplierList();
            }
        }

        private void btnRemoveSupplier_Click(object sender, EventArgs e)
        {
            DialogResult ask = MessageBox.Show("Are you sure you want to remove?", "Remove Supplier", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ask == DialogResult.Yes)
            {
                try
                {
                    conn.Open();
                    MySqlCommand scom = conn.CreateCommand();
                    scom.CommandText = "UPDATE supplier SET active = 0 WHERE company_name = @companyName AND contact_person = @contactPerson";
                    scom.Parameters.AddWithValue("@companyName", txtCompanyName.Text);
                    scom.Parameters.AddWithValue("@contactPerson", txtContactPerson.Text);
                    scom.ExecuteNonQuery();
                    conn.Close();
                    alert.Show("Succcessfully Removed.", alert.AlertType.success);
                    showSupplierList();
                    clearFields();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnAddSupplier_Click(object sender, EventArgs e)
        {
            pnlAddItem.Visible = true;
        }

        private void pnlMinimize1_Click(object sender, EventArgs e)
        {
            pnlAddItem.Visible = false;
        }

        private void txtContactNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }
    }
}
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
    public partial class Supplier_Management : Form
    {
        MySqlConnection conn = new MySqlConnection("SERVER = localhost; USERNAME = root; PASSWORD = ; DATABASE = marj_hardware");
        public Supplier_Management()
        {
            InitializeComponent();
            showSupplierList();
        }
        //METHODS
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

        private void showInactiveSupplier()
        {
            try
            {
                conn.Open();
                MySqlCommand scom = conn.CreateCommand();
                scom.CommandText = "SELECT company_name, contact_person, gender, address, contact_number, email, remark FROM supplier WHERE active = 0";
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

        private void AddFormClosing(object sender, FormClosingEventArgs e)
        {
            showSupplierList();
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

        private void txtContactNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void dgvSupplierList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgvSupplierList.Rows.Count > 0)
            {
                txtCompanyName.Text = dgvSupplierList.CurrentRow.Cells["companyName"].Value.ToString();
                txtContactPerson.Text = dgvSupplierList.CurrentRow.Cells["contactPerson"].Value.ToString();
                txtAddress.Text = dgvSupplierList.CurrentRow.Cells["address"].Value.ToString();
                txtContactNumber.Text = dgvSupplierList.CurrentRow.Cells["contactNumber"].Value.ToString();
                txtEmailAddress.Text = dgvSupplierList.CurrentRow.Cells["emailAddress"].Value.ToString();
                txtRemark.Text = dgvSupplierList.CurrentRow.Cells["remark"].Value.ToString();
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
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnAddSupplier_Click(object sender, EventArgs e)
        {
            Add_Supplier supplier = new Add_Supplier();
            supplier.FormClosing += new FormClosingEventHandler(AddFormClosing);
            supplier.Show();
        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            if (txtSearch.text == "")
            {
                txtSearch.text = "Search";
            }
        }

        private void txtSearch_KeyDown(object sender, EventArgs e)
        {
            if (txtSearch.text == "Search")
            {
                txtSearch.text = "";
            }
        }

        private void rdbShowActive_CheckedChanged(object sender, EventArgs e)
        {
            showSupplierList();
        }

        private void rdbShowArchive_CheckedChanged(object sender, EventArgs e)
        {
            showInactiveSupplier();
        }
    }
}

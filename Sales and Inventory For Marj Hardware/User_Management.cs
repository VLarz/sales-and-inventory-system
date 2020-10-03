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
using System.Text.RegularExpressions;
using System.IO;


namespace Sales_and_Inventory_For_Marj_Hardware
{
    public partial class User_Management : Form
    {

        MySqlConnection conn = new MySqlConnection("SERVER = localhost; USERNAME = root; PASSWORD = ; DATABASE = marj_hardware");
        public User_Management()
        {
            InitializeComponent();
            showUserList();
        }
        //METHODS
        private void clearUserTextFields()
        {
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtEmailAddress.Text = "";
            txtContactNumber.Text = "";
            txtUsername.Text = "";
            txtUserLevel.Text = "";
        }
        private void showUserList()
        {
            conn.Open();
            MySqlCommand scom = conn.CreateCommand();
            scom.CommandText = "SELECT firstname, lastname, email, contact_number, username, userlevel FROM user WHERE active = 1 ORDER BY id DESC";
            MySqlDataAdapter sda = new MySqlDataAdapter(scom);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            conn.Close();
            dgvUserList.DataSource = dt;
            if (dgvUserList.Rows.Count > 0)
            {
                dgvUserList.Rows[0].Selected = false;
            }
        }

        private void showInactiveUser()
        {
            conn.Open();
            MySqlCommand scom = conn.CreateCommand();
            scom.CommandText = "SELECT firstname, lastname, email, contact_number, username, userlevel FROM user WHERE active = 0 ORDER BY id DESC";
            MySqlDataAdapter sda = new MySqlDataAdapter(scom);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            conn.Close();
            dgvUserList.DataSource = dt;
            if (dgvUserList.Rows.Count > 0)
            {
                dgvUserList.Rows[0].Selected = false;
            }
        }

        private void AddFormClosing(object sender, FormClosingEventArgs e)
        {
            showUserList();
        }

        private void txtEmailAddress_Leave(object sender, EventArgs e)
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

        private void dgvUserList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgvUserList.Rows.Count > 0)
            {
                txtFirstName.Text = dgvUserList.CurrentRow.Cells["firstName"].Value.ToString();
                txtLastName.Text = dgvUserList.CurrentRow.Cells["lastName"].Value.ToString();
                txtEmailAddress.Text = dgvUserList.CurrentRow.Cells["email"].Value.ToString();
                txtContactNumber.Text = dgvUserList.CurrentRow.Cells["contactNumber"].Value.ToString();
                txtUsername.Text = dgvUserList.CurrentRow.Cells["username"].Value.ToString();
                txtUsername2.Text = dgvUserList.CurrentRow.Cells["username"].Value.ToString();
                txtUserLevel.Text = dgvUserList.CurrentRow.Cells["userLevel"].Value.ToString();
                cmbUserLevel2.Text = dgvUserList.CurrentRow.Cells["userLevel"].Value.ToString();
            }
        }

        private void btnArchive_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text != "")
            {
                DialogResult ask = MessageBox.Show("Are you sure you want to archive this user?", "Archive User", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (ask == DialogResult.Yes)
                {
                    conn.Open();
                    MySqlCommand scom = conn.CreateCommand();
                    scom.CommandText = "UPDATE user SET active = 0 WHERE username = @username";
                    scom.Parameters.AddWithValue(@"username", txtUsername.Text);
                    scom.ExecuteNonQuery();
                    conn.Close();

                    alert.Show("Successfully Deactivated", alert.AlertType.success);
                    showUserList();
                    clearUserTextFields();
                }
            }
            else
            {
                alert.Show("Please select an account.", alert.AlertType.warning);
            }
        }

        private void btnChangeUserLevel_Click(object sender, EventArgs e)
        {
            if(txtUsername.Text != "")
            {
                pnlChangeUserLevel.Visible = true;
            }
            else
            {
                alert.Show("Please select an account.", alert.AlertType.warning);
            }
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            if (cmbUserLevel2.SelectedIndex != 0)
            {
                DialogResult ask = MessageBox.Show("Are you sure you want to change this user level?", "Change User Level", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (ask == DialogResult.Yes)
                {
                    conn.Open();
                    MySqlCommand scom = conn.CreateCommand();
                    scom.CommandText = "UPDATE user SET userlevel = @userlevel WHERE username = @username";
                    scom.Parameters.AddWithValue("@userlevel", cmbUserLevel2.Text);
                    scom.Parameters.AddWithValue(@"username", txtUsername2.Text);
                    scom.ExecuteNonQuery();
                    conn.Close();

                    alert.Show("Successfully Changed", alert.AlertType.success);
                    showUserList();
                }
            }
            else
            {
                alert.Show("Please select user level.", alert.AlertType.warning);
            }
        }

        private void txtSearch_OnTextChange(object sender, EventArgs e)
        {
            if (txtSearch.text != "")
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = conn.CreateCommand();
                    cmd.CommandText = "SELECT firstname, lastname, email, contact_number, username, userlevel FROM user WHERE username LIKE '%" + txtSearch.text + "%' AND active = @1 ORDER BY id DESC";
                    cmd.Parameters.AddWithValue("@name", txtSearch.text);
                    cmd.Parameters.AddWithValue("@1", "1");
                    MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    conn.Close();
                    dgvUserList.DataSource = dt;
                    if (dgvUserList.RowCount > 0)
                    {
                        dgvUserList.Rows[0].Selected = false;
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                showUserList();
                if (dgvUserList.Rows.Count > 0)
                {
                    dgvUserList.Rows[0].Selected = false;
                }
            }
        }

        private void User_Management_Load(object sender, EventArgs e)
        {
            if(dgvUserList.Rows.Count > 0)
            {
                dgvUserList.Rows[0].Selected = false;
            }
           
        }

        private void txtSearch_KeyDown(object sender, EventArgs e)
        {
            if (txtSearch.text == "Search")
            {
                txtSearch.text = "";
            }
        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            if(txtSearch.text == "")
            {
                txtSearch.text = "Search";
            }
        }

        private void rdbShowArchive_CheckedChanged(object sender, EventArgs e)
        {
            showInactiveUser();
        }

        private void rdbShowActive_CheckedChanged(object sender, EventArgs e)
        {
            showUserList();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            Add_User add = new Add_User();
            add.FormClosing += new FormClosingEventHandler(AddFormClosing);
            add.ShowDialog();
        }
    }
}

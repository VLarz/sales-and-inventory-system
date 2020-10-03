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
using System.Text.RegularExpressions;
using System.IO;

namespace Sales_and_Inventory_For_Marj_Hardware
{
    public partial class User_Management1 : UserControl
    {
        private static User_Management1 _instance;

        public static User_Management1 Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new User_Management1();
                return _instance;
            }
        }

        MySqlConnection conn = new MySqlConnection("SERVER = localhost; USERNAME = root; PASSWORD = ; DATABASE = marj_hardware");
        public User_Management1()
        {
            InitializeComponent();
            showUserList();
            cmbSecurityQuestion.SelectedIndex = 0;
            cmbUserLevel.SelectedIndex = 0;
        }

        //METHODS
        private void checkUsername()
        {
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM user WHERE username = '" + txtUsername1.Text + "'", conn);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            int i = ds.Tables[0].Rows.Count;
            if (i > 0)
            {
                alert.Show("Username already exist.", alert.AlertType.warning);
                ds.Clear();
            }
            else
            {

                if (lblImageName.Text != "")
                {
                    string FileName = lblImageName.Text;
                    byte[] ImageData;
                    FileStream fs = new FileStream(FileName, FileMode.Open, FileAccess.Read);
                    BinaryReader br = new BinaryReader(fs);
                    ImageData = br.ReadBytes((int)fs.Length);
                    br.Close();
                    fs.Close();

                    String cmdString = "INSERT INTO user(id, firstname, lastname, email, contact_number, username, password, userlevel, security_question, security_answer, picture, active) VALUES(default, @firstname, @lastname, @email, @contact_number, @username, @password, @userlevel, @security_question, @security_answer, @image, @active)";
                    MySqlCommand cmd1 = new MySqlCommand(cmdString, conn);

                    cmd1.Parameters.Add("@firstname", MySqlDbType.VarChar, 255);
                    cmd1.Parameters.Add("@lastname", MySqlDbType.VarChar, 255);
                    cmd1.Parameters.Add("@email", MySqlDbType.VarChar, 255);
                    cmd1.Parameters.Add("@contact_number", MySqlDbType.VarChar, 255);
                    cmd1.Parameters.Add("@username", MySqlDbType.VarChar, 255);
                    cmd1.Parameters.Add("@password", MySqlDbType.VarChar, 255);
                    cmd1.Parameters.Add("@userlevel", MySqlDbType.VarChar, 255);
                    cmd1.Parameters.Add("@active", MySqlDbType.VarChar, 255);
                    cmd1.Parameters.Add("@security_question", MySqlDbType.VarChar, 255);
                    cmd1.Parameters.Add("@security_answer", MySqlDbType.VarChar, 255);
                    cmd1.Parameters.Add("@image", MySqlDbType.LongBlob);

                    cmd1.Parameters["@firstname"].Value = txtFirstName1.Text;
                    cmd1.Parameters["@lastname"].Value = txtLastName1.Text;
                    cmd1.Parameters["@email"].Value = txtEmailAddress1.Text;
                    cmd1.Parameters["@contact_number"].Value = "0" + txtContactNumber1.Text;
                    cmd1.Parameters["@username"].Value = txtUsername1.Text;
                    cmd1.Parameters["@password"].Value = txtPassword1.Text;
                    cmd1.Parameters["@userlevel"].Value = cmbUserLevel.Text;
                    cmd1.Parameters["@active"].Value = "1";
                    cmd1.Parameters["@security_question"].Value = cmbSecurityQuestion.Text;
                    cmd1.Parameters["@security_answer"].Value = txtSecurityAnswer1.Text;
                    cmd1.Parameters["@image"].Value = ImageData;

                    conn.Open();
                    int RowsAffected = cmd1.ExecuteNonQuery();
                    if (RowsAffected > 0)
                    {
                        alert.Show("Successfully Added.", alert.AlertType.success);
                    }
                    clearAddAcount();
                    conn.Close();
                    showUserList();
                }
                else
                {
                    String cmdString = "INSERT INTO user(id, firstname, lastname, email, contact_number, username, password, userlevel ,security_question, security_answer, active) VALUES(default, @firstname, @lastname, @email, @contact_number, @username, @password, @userlevel, @security_question, @security_answer,  @status)";
                    MySqlCommand cmd3 = new MySqlCommand(cmdString, conn);

                    cmd3.Parameters.Add("@firstname", MySqlDbType.VarChar, 255);
                    cmd3.Parameters.Add("@lastname", MySqlDbType.VarChar, 255);
                    cmd3.Parameters.Add("@email", MySqlDbType.VarChar, 255);
                    cmd3.Parameters.Add("@contact_number", MySqlDbType.VarChar, 255);
                    cmd3.Parameters.Add("@username", MySqlDbType.VarChar, 255);
                    cmd3.Parameters.Add("@password", MySqlDbType.VarChar, 255);
                    cmd3.Parameters.Add("@userlevel", MySqlDbType.VarChar, 255);
                    cmd3.Parameters.Add("@status", MySqlDbType.VarChar, 255);
                    cmd3.Parameters.Add("@security_question", MySqlDbType.VarChar, 255);
                    cmd3.Parameters.Add("@security_answer", MySqlDbType.VarChar, 255);

                    cmd3.Parameters["@firstname"].Value = txtFirstName1.Text;
                    cmd3.Parameters["@lastname"].Value = txtLastName1.Text;
                    cmd3.Parameters["@email"].Value = txtEmailAddress1.Text;
                    cmd3.Parameters["@contact_number"].Value = "0" + txtContactNumber1.Text;
                    cmd3.Parameters["@username"].Value = txtUsername1.Text;
                    cmd3.Parameters["@password"].Value = txtPassword1.Text;
                    cmd3.Parameters["@userlevel"].Value = cmbUserLevel.Text;
                    cmd3.Parameters["@status"].Value = "1";
                    cmd3.Parameters["@security_question"].Value = cmbSecurityQuestion.Text;
                    cmd3.Parameters["@security_answer"].Value = txtSecurityAnswer1.Text;

                    conn.Open();
                    int RowsAffected = cmd3.ExecuteNonQuery();
                    if (RowsAffected > 0)
                    {
                        alert.Show("Successfully Added.", alert.AlertType.success);                                   
                    }
                    clearAddAcount();
                    conn.Close();
                    showUserList();
                }
            }                                        
        }

        private void clearAddAcount()
        {
            txtFirstName1.Text = "";
            txtLastName1.Text = "";
            txtEmailAddress1.Text = "";
            txtContactNumber1.Text = "";
            txtUsername1.Text = "";
            cmbUserLevel.SelectedIndex = 0;
            txtPassword1.Text = "";
            txtConfirmPassword.Text = "";
            cmbSecurityQuestion.SelectedIndex = 0;
            txtSecurityAnswer1.Text = "";
            lblMatch.Text = "";
        }

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

        private void txtEmailAddress_Leave(object sender, EventArgs e)
        {
            if(txtEmailAddress1.Text != "")
            {
                string pattern = @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-0-9a-z]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$";

                if (Regex.IsMatch(txtEmailAddress1.Text, pattern))
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

        private void txtComfirmPassword_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtPassword1.Text != "")
            {
                if (txtPassword1.Text != txtConfirmPassword.Text)
                {
                    lblMatch.Text = "Passwords do not match.";
                    lblMatch.ForeColor = Color.Red;
                }
                else
                {
                    lblMatch.Text = "Passwords match.";
                    lblMatch.ForeColor = Color.Green;
                }
            }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "JPG files(*.jpg)|*.jpg|PNG files(*.png)|*.png| All files(*.*)|*.*";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var filesize = new FileInfo(ofd.FileName);
                    var validFileSize = filesize.Length <= 1024 * 2000;
                    var validDimension = false;

                    using (Image image = Image.FromFile(ofd.FileName))
                    {
                        validDimension = (image.Width >= 200) && (image.Height >= 200);
                    }
                    if (!validDimension || !validFileSize)
                    {
                        alert.Show("Size is invalid.", alert.AlertType.warning);
                    }
                    else
                    {
                        lblImageName.Text = ofd.FileName;
                        picUserPhoto.Image = Image.FromFile(ofd.FileName);
                    }
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }
        }

        private void btnAddUser1_Click(object sender, EventArgs e)
        {
            if (txtFirstName1.Text != "" && txtLastName1.Text != "" && txtEmailAddress1.Text != "" && txtContactNumber1.Text != "" && txtUsername1.Text != "" && cmbUserLevel.SelectedIndex != 0 && txtPassword1.Text != "" && txtPassword1.Text == txtConfirmPassword.Text && cmbSecurityQuestion.SelectedIndex != 0 && txtSecurityAnswer1.Text != "" && lblEmailValidation.Text == "")
            {
                DialogResult ask = MessageBox.Show("Add this User?", "Add User", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (ask == DialogResult.Yes)
                {                 
                    checkUsername();
                }
            }
            else
            {
                alert.Show("Please fill in all the details.", alert.AlertType.warning);
            }
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            pnlAddUser.Visible = true;    
        }

        private void dgvUserList_CellClick(object sender, DataGridViewCellEventArgs e)
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

        private void lblMinimize2_Click(object sender, EventArgs e)
        {
            pnlChangeUserLevel.Visible = false;
        }

        private void pnlMinimize1_Click(object sender, EventArgs e)
        {
            pnlAddUser.Visible = false;
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

                    alert.Show("Successfully Archived", alert.AlertType.success);
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
            pnlChangeUserLevel.Visible = true;
        }

        private void btnChangeUserLevel1_Click(object sender, EventArgs e)
        {
            
        }

        private void User_Management_Load(object sender, EventArgs e)
        {
            if (dgvUserList.Rows.Count > 0)
            {
                dgvUserList.Rows[0].Selected = false;
            }
        }

        private void txtContactNumber1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void pnlAddUser_Paint(object sender, PaintEventArgs e)
        {

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
                    cmd.CommandText = "SELECT firstname, lastname, email, contact_number, username, userlevel FROM user WHERE name LIKE '%" + txtSearch.text + "%' AND status = @1 ORDER BY id DESC";
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
                dgvUserList.Rows[0].Selected = false;
            }
        }

        private void txtSearch_KeyDown(object sender, EventArgs e)
        {
            if(txtSearch.text == "Search")
            {
                txtSearch.text = "";
            }
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            pnlAddUser.Visible = false;
        }

        private void btnExit1_Click(object sender, EventArgs e)
        {
            pnlChangeUserLevel.Visible = false;
        }

        private void txtContactNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {

        }
    }
}

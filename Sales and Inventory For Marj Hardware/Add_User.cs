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
using System.IO;
using System.Text.RegularExpressions;

namespace Sales_and_Inventory_For_Marj_Hardware
{
    public partial class Add_User : MaterialSkin.Controls.MaterialForm
    {
        MySqlConnection conn = new MySqlConnection("SERVER = localhost; USERNAME = root; PASSWORD = ; DATABASE = marj_hardware");
        MaterialSkinManager skinManager;
        public Add_User()
        {
            InitializeComponent();
            skinManager = MaterialSkinManager.Instance;
            SkinManager.AddFormToManage(this);
            SkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            SkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Blue800, MaterialSkin.Primary.Blue900, MaterialSkin.Primary.Blue900, MaterialSkin.Accent.Orange700, MaterialSkin.TextShade.WHITE);
            cmbSecurityQuestion.SelectedIndex = 0;
            cmbUserLevel.SelectedIndex = 0;
        }
        //METHODS
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
            lblImageName.Text = "";
            picUserPhoto.Image = null;
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

        private void txtEmailAddress1_Leave(object sender, EventArgs e)
        {
            if (txtEmailAddress1.Text != "")
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

        private void txtContactNumber1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
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

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearAddAcount();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtConfirmPassword_OnValueChanged(object sender, EventArgs e)
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

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if(chkShowPassword.Checked == true)
            {
                txtPassword1.isPassword = false;
            }
            else
            {
                txtPassword1.isPassword = true;
            }
        }

        private void Add_User_Load(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class Login : MaterialSkin.Controls.MaterialForm
    {
        MaterialSkinManager skinManager;
        MySqlConnection conn = new MySqlConnection("SERVER = localhost; USERNAME = root; PASSWORD = ; DATABASE = marj_hardware");
        public Login()
        {
            InitializeComponent();
            skinManager = MaterialSkinManager.Instance;
            SkinManager.AddFormToManage(this);
            SkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            SkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Blue800, MaterialSkin.Primary.Blue900, MaterialSkin.Primary.Blue900, MaterialSkin.Accent.Orange700, MaterialSkin.TextShade.WHITE);
            this.AcceptButton = btnLogin;
        }
        //METHODS

        private void ConnectionState()
        {
            try
            {
                conn.Open();
                lblConnected.Visible = true;
                lblNotConnected.Visible = false;
                txtUsername.Enabled = true;
                txtPassword.Enabled = true;
                btnLogin.Enabled = true;
                chkShow.Enabled = true;
            }
            catch
            {
                lblConnected.Visible = false;
                lblNotConnected.Visible = true;
                txtUsername.Enabled = false;
                txtPassword.Enabled = false;
                btnLogin.Enabled = false;
                chkShow.Enabled = false;
            }
            conn.Close();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            ConnectionState();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ConnectionState();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text != "" && txtPassword.Text != "")
            {
                try
                {
                    conn.Open();
                    string sql = "SELECT * FROM user WHERE username = @user and password = @pass";
                    MySqlDataAdapter sda = new MySqlDataAdapter(sql, conn);
                    sda.SelectCommand.Parameters.AddWithValue("@user", txtUsername.Text);
                    sda.SelectCommand.Parameters.AddWithValue("@pass", txtPassword.Text);
                    DataTable sdt = new DataTable();
                    sda.Fill(sdt);
                    conn.Close();
                    if (sdt.Rows.Count > 0)
                    {
                        for (int samp = 0; samp < sdt.Rows.Count; samp++)
                        {
                            string name = txtUsername.Text;
                            DataRow sdr = sdt.Rows[samp];
                            if (sdr["UserLevel"].ToString() == "Admin")
                            {
                                //MessageBox.Show("Welcome, " + sdt.Rows[0][1].ToString(), "Successfully Login!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Hide();
                                //exequery("INSERT INTO userlog VALUES(default, '" + txtUsername.Text + "','Admin','" + lblTime.Text + "','" + lblDate.Text + "','IN')");
                                Mainform fr = new Mainform();
                                //FullName = sdt.Rows[0][4].ToString() + " " + sdt.Rows[0][5].ToString();
                                //Username = sdt.Rows[0][1].ToString();
                                //Userlevel = sdt.Rows[0][3].ToString();

                                //fr.Show();
                                Login_Notification notif = new Login_Notification();
                                notif.Show();
                            }
                            else if (sdr["UserLevel"].ToString() == "Cashier")
                            {


                                this.Hide();
                                POS pos = new POS();
                                pos.Show();
                            }

                                //    MessageBox.Show("Welcome " + sdt.Rows[0][1].ToString(), "Successfully Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                //    this.Hide();
                                //    exequery("INSERT INTO userlog VALUES(default, '" + txtUsername.Text + "','Cashier','" + lblTime.Text + "','" + lblDate.Text + "','IN')");
                                //    Mainform fr = new Mainform();
                                //    FullName = sdt.Rows[0][4].ToString() + " " + sdt.Rows[0][5].ToString();
                                //    Username = sdt.Rows[0][1].ToString();
                                //    Userlevel = sdt.Rows[0][3].ToString();
                                //    fr.Show();
                                //}
                                //else if (sdr["UserLevel"].ToString() == "Manager")
                                //{

                                //    MessageBox.Show("Welcome " + sdt.Rows[0][1].ToString(), "Successfully Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                //    this.Hide();
                                //    exequery("INSERT INTO userlog VALUES(default, '" + txtUsername.Text + "','Manager','" + lblTime.Text + "','" + lblDate.Text + "','IN')");
                                //    Mainform fr = new Mainform();
                                //    FullName = sdt.Rows[0][4].ToString() + " " + sdt.Rows[0][5].ToString();
                                //    Username = sdt.Rows[0][1].ToString();
                                //    Userlevel = sdt.Rows[0][3].ToString();
                                //    fr.Show();
                                //}
                            }
                    }
                    else {
                        alert.Show("Incorrect Username or Password.", alert.AlertType.warning);
                    }
                }
                catch (Exception a)
                {
                    MessageBox.Show(a.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            else
            {
                alert.Show("Please fill up all fields.", alert.AlertType.warning);
            }
        }

        private void chkShow_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShow.Checked)
            {
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '*';
            }
        }
    }
}

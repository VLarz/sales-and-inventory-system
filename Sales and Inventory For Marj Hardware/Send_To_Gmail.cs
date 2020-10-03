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
using Gmail;
using System.Text.RegularExpressions;

namespace Sales_and_Inventory_For_Marj_Hardware
{
    public partial class Send_To_Gmail : MaterialSkin.Controls.MaterialForm
    {
        MaterialSkinManager skinManager;
        MySqlConnection conn = new MySqlConnection("SERVER = localhost; USERNAME = root; PASSWORD = ; DATABASE = marj_hardware");
        public Send_To_Gmail()
        {
            InitializeComponent();
            skinManager = MaterialSkinManager.Instance;
            SkinManager.AddFormToManage(this);
            SkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            SkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Blue800, MaterialSkin.Primary.Blue900, MaterialSkin.Primary.Blue900, MaterialSkin.Accent.Orange700, MaterialSkin.TextShade.WHITE);
        }

        private void Send_To_Email_Load(object sender, EventArgs e)
        {
            txtToEmail.Text = Purchase_OrderList.getEmail;
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtAttachment.Text = openFileDialog1.FileName;
            }
        }

        private void btnOrderNow_Click(object sender, EventArgs e)
        {
            if (txtToEmail.Text == "")
            {
                alert.Show("Please input Gmail.", alert.AlertType.warning);
            }
            else if (lblEmailValidation.Text != "")
            {
                alert.Show("Incorrect email type.", alert.AlertType.warning);
            }
            else
            {
                GmailClient client = new GmailClient();
                string gmail = "vhenlarsondelacuesta.061398@gmail.com";
                string password = "VhenLarson061398018246793150.";
                string status = client.send(gmail, password, txtToEmail.Text, txtSubject.Text, txtBody.Text, txtAttachment.Text == "" ? null : txtAttachment.Text);
                string message = status;
                if(message == "Invalid emailid or password or internet connection is not available")
                {
                    alert.Show("Invalid emailid or password or internet connection is not available.", alert.AlertType.warning);
                }
                else
                {
                    alert.Show("Successfully Sent", alert.AlertType.success);
                    this.Hide();
                }
            }           
        }

        private void txtToEmail_Leave(object sender, EventArgs e)
        {
            if (txtToEmail.Text != "")
            {
                string pattern = @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-0-9a-z]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$";

                if (Regex.IsMatch(txtToEmail.Text, pattern))
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

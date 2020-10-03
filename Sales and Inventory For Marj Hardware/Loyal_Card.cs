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
    public partial class Loyal_Card : MaterialSkin.Controls.MaterialForm
    {
        MaterialSkinManager skinManager;
        MySqlConnection conn = new MySqlConnection("SERVER = localhost; USERNAME = root; PASSWORD = ; DATABASE = marj_hardware");
        public Loyal_Card()
        {
            InitializeComponent();
            skinManager = MaterialSkinManager.Instance;
            SkinManager.AddFormToManage(this);
            SkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            SkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Blue800, MaterialSkin.Primary.Blue900, MaterialSkin.Primary.Blue900, MaterialSkin.Accent.Orange700, MaterialSkin.TextShade.WHITE);
            showCustomerList();
            generateRandomNumbers();
        }
        //METHOD
        private void showCustomerList()
        {
            try
            {
                conn.Open();
                MySqlCommand scom = conn.CreateCommand();
                scom.CommandText = "SELECT * FROM customer_card";
                MySqlDataAdapter sda = new MySqlDataAdapter(scom);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                conn.Close();
                dgvCustomer.DataSource = dt;
                if(dgvCustomer.Rows.Count > 0)
                {
                    dgvCustomer.Rows[0].Selected = false;
                }
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void generateRandomNumbers()
        {
            var randomNumbers = new List<int>();
            var randomGenerator = new Random();
            int initialCount = 1;
            string num1 = "";
            string num2 = "";

            for (int i = 0; i <= 5; i++)
            {
                while (initialCount <= 5)
                {
                    int num = randomGenerator.Next(1000, 999999999);
                    if (!randomNumbers.Contains(num))
                    {
                        randomNumbers.Add(num);
                        initialCount++;
                    }
                }
            }
            randomNumbers.Sort();
            randomNumbers.ForEach(x => num1 = x.ToString());

            var randomNumbers1 = new List<int>();
            var randomGenerator1 = new Random();
            int initialCount1 = 1;
            for (int i = 0; i <= 5; i++)
            {
                while (initialCount1 <= 5)
                {
                    int num5 = randomGenerator1.Next(100, 999);
                    if (!randomNumbers.Contains(num5))
                    {
                        randomNumbers1.Add(num5);
                        initialCount1++;
                    }
                }
            }
            randomNumbers1.Sort();
            randomNumbers1.ForEach(x => num2 = x.ToString());

            string[] combine = new String[] { num1, num2};
            string combine1 = String.Join("",combine);
            txtCard.Text = combine1;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if(txtCard.Text.Length == 12)
            {
                if(txtCustomerName.Text != "" && txtCustomerNumber.Text != "")
                {
                    
                    MySqlCommand cmd = new MySqlCommand("SELECT * FROM customer_card WHERE card_number = @card", conn);
                    cmd.Parameters.AddWithValue("@card", txtCard.Text);
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    int i = ds.Tables[0].Rows.Count;
                    if (i > 0)
                    {
                        alert.Show("Card # " + txtCustomerNumber.Text + " Already Exists.", alert.AlertType.error);
                        ds.Clear();
                    }
                    else
                    {
                        DialogResult ask = MessageBox.Show("Are your sure you want to add?", "Add Customer", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (ask == DialogResult.Yes)
                        {
                            conn.Open();
                            MySqlCommand scom = conn.CreateCommand();
                            scom.CommandText = "INSERT INTO customer_card (card_number, name, contact_number, current_points) VALUES (@card, @name, @contact, '0')";
                            scom.Parameters.AddWithValue("@card", txtCard.Text);
                            scom.Parameters.AddWithValue("@name", txtCustomerName.Text);
                            scom.Parameters.AddWithValue("@contact", txtCustomerNumber.Text);
                            scom.ExecuteNonQuery();
                            conn.Close();
                            alert.Show("Successfully Added.", alert.AlertType.success);
                            showCustomerList();
                        }
                    }
                }
                else
                {
                    alert.Show("Please fill in other fields.", alert.AlertType.warning);
                }
            }
            else
            {
                alert.Show("Card # must be 12 numbers.", alert.AlertType.warning);
            }
        }

        private void Loyal_Card_Load(object sender, EventArgs e)
        {
            if (dgvCustomer.Rows.Count > 0)
            {
                dgvCustomer.Rows[0].Selected = false;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if(txtCard.Text != "" && txtCustomerName.Text != "" && txtCustomerNumber.Text != "")
            {
                DialogResult ask = MessageBox.Show("Are your sure you want to update?", "Update Customer", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (ask == DialogResult.Yes)
                {
                    conn.Open();
                    MySqlCommand scom = conn.CreateCommand();
                    scom.CommandText = "UPDATE customer_card SET name = @name, contact_number = @contact WHERE card_number = @card";
                    scom.Parameters.AddWithValue("@name", txtCustomerName.Text);
                    scom.Parameters.AddWithValue("@contact", txtCustomerNumber.Text);
                    scom.ExecuteNonQuery();
                    conn.Close();
                    alert.Show("Successfully Updated.", alert.AlertType.success);
                    showCustomerList();
                }
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if(txtCard.Text != "")
            {
                DialogResult ask = MessageBox.Show("Are your sure you want to remove?", "Remove Brand", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (ask == DialogResult.Yes)
                {
                    conn.Open();
                    MySqlCommand scom = conn.CreateCommand();
                    scom.CommandText = "DELETE FROM brand WHERE id = @id";
                    scom.Parameters.AddWithValue("@id", txtCard.Text);
                    scom.ExecuteNonQuery();
                    conn.Close();
                    alert.Show("Successfully Deleted.", alert.AlertType.success);
                    txtCard.Text = "";
                    txtCustomerName.Text = "";
                    txtCustomerNumber.Text = "";
                    showCustomerList();
                }
            }
            else
            {
                alert.Show("Please select a customer.", alert.AlertType.warning);
            }

        }

        private void dgvCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgvCustomer.Rows.Count > 0)
            {
                txtCard.Text = dgvCustomer.CurrentRow.Cells["card"].Value.ToString();
                txtCustomerName.Text = dgvCustomer.CurrentRow.Cells["customerName"].Value.ToString();
                txtCustomerNumber.Text = dgvCustomer.CurrentRow.Cells["contactNumber"].Value.ToString();
            }
        }

        private void chkRandom_OnChange(object sender, EventArgs e)
        {
            if(chkRandom.Checked == true)
            {
                generateRandomNumbers();
            }
            else
            {
                txtCard.Text = "";
            }
        }
    }
}

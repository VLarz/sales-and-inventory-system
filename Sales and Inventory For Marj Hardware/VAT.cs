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
    public partial class VAT : Form
    {
        MySqlConnection conn = new MySqlConnection("SERVER = localhost; USERNAME = root; PASSWORD = ; DATABASE = marj_hardware");
        public VAT()
        {
            InitializeComponent();
            getCurrentVAT();
        }
        //METHOD
        private void getCurrentVAT()
        {
            try
            {
                conn.Open();
                MySqlCommand scom = conn.CreateCommand();
                scom.CommandText = "SELECT current_vat FROM VAT WHERE id = 1";
                MySqlDataReader dr = scom.ExecuteReader();
                while (dr.Read())
                {
                    lblCurrentVAT.Text = dr.GetString("current_VAT");

                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(cmbNewVAT.SelectedIndex != -1)
            {
                try
                {
                    conn.Open();
                    MySqlCommand scom = conn.CreateCommand();
                    scom.CommandText = "UPDATE vat SET current_vat = @newVAT WHERE id = 1";
                    scom.Parameters.AddWithValue("@newVAT", cmbNewVAT.Text);
                    scom.ExecuteNonQuery();
                    conn.Close();
                    alert.Show("Successfully VAT Updated", alert.AlertType.success);
                    getCurrentVAT();
                    cmbNewVAT.SelectedIndex = -1;
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                alert.Show("Please select new VAT", alert.AlertType.warning);
            }
        }
    }
}

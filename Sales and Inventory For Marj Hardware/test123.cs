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
    public partial class test123 : Form
    {
        MySqlConnection conn = new MySqlConnection("SERVER = localhost; USERNAME = root; PASSWORD = ; DATABASE = prefinals");
        public test123()
        {
            InitializeComponent();
            showOrder();
        }

        private void test123_Load(object sender, EventArgs e)
        {

        }

        private void showOrder()
        {
            conn.Open();
            MySqlCommand scom = conn.CreateCommand();
            scom.CommandText = "SELECT * FROM test WHERE exp_notif <= '" + System.DateTime.Now.ToString("yyyy/MM/dd") + "' AND exp_date >= '" + System.DateTime.Now.ToString("yyyy/MM/dd") + "'";
            MySqlDataAdapter sda = new MySqlDataAdapter(scom);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dgvList.DataSource = dt;
            conn.Close();
            if (dgvList.Rows.Count > 0)
            {
                dgvList.Rows[0].Selected = false;
            }
        }
    }
}

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
    public partial class Sales_Reports : Form
    {
        MySqlConnection conn = new MySqlConnection("SERVER = localhost; USERNAME = root; PASSWORD = ; DATABASE = marj_hardware");
        public Sales_Reports()
        {
            InitializeComponent();
            showSalesReport();
            computeTotalItemSold();
            computeTotalTransaction();
            computeTotalIncome();
        }
        //METHODS
        private void showSalesReport()
        {
            try
            {
                conn.Open();
                MySqlCommand scom = conn.CreateCommand();
                scom.CommandText = "SELECT * FROM sales_report";
                MySqlDataAdapter sda = new MySqlDataAdapter(scom);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                conn.Close();
                dgvSalesReport.DataSource = dt;
                if (dgvSalesReport.Rows.Count > 0)
                {
                    dgvSalesReport.Rows[0].Selected = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void computeTotalItemSold()
        {
            if (dgvSalesReport.Rows.Count > 0)
            {
                int sum = 0;
                for (int i = 0; i < dgvSalesReport.Rows.Count; i++)
                {
                    sum += Convert.ToInt32(dgvSalesReport.Rows[i].Cells[4].Value);
                }
                lblTotalItemSold.Text = sum.ToString();
            }

        }

        private void computeTotalItemSold1()
        {
            if (dgvBestAndWorst.Rows.Count > 0)
            {
                int sum = 0;
                for (int i = 0; i < dgvBestAndWorst.Rows.Count; i++)
                {
                    sum += Convert.ToInt32(dgvBestAndWorst.Rows[i].Cells[4].Value);
                }
                lblTotalItemSold.Text = sum.ToString();
            }
        }

        private void computeTotalTransaction()
        {
            if (dgvSalesReport.Rows.Count > 0)
            {
                lblTotalTransaction.Text = dgvSalesReport.Rows.Count.ToString();
            }
        }

        private void computeTotalTransaction1()
        {
            if (dgvBestAndWorst.Rows.Count > 0)
            {
                lblTotalTransaction.Text = dgvBestAndWorst.Rows.Count.ToString();
            }
        }


        private void computeTotalIncome()
        {
            if (dgvSalesReport.Rows.Count > 0)
            {
                decimal sum = 0;
                for (int i = 0; i < dgvSalesReport.Rows.Count; i++)
                {
                    sum += Convert.ToDecimal(dgvSalesReport.Rows[i].Cells[5].Value);
                }
                lblTotalIncome.Text = sum.ToString();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            rdbBestSelling.Checked = false;
            rdbWorstSelling.Checked = false;
            rdbToday.Checked = false;
            rdbYesterday.Checked = false;
            rdbMonth.Checked = false;
            dgvBestAndWorst.Visible = false;
            rdbYear.Checked = false;
            try
            {
                conn.Open();
                MySqlCommand scom = conn.CreateCommand();
                scom.CommandText = "SELECT * FROM sales_report WHERE date_sold BETWEEN '" + dtpFrom.Text + "' AND '" + dtpTo.Text + "'";
                MySqlDataAdapter sda = new MySqlDataAdapter(scom);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                conn.Close();
                dgvSalesReport.DataSource = dt;
                if (dgvSalesReport.Rows.Count > 0)
                {
                    dgvSalesReport.Rows[0].Selected = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            rdbBestSelling.Checked = false;
            rdbWorstSelling.Checked = false;
            rdbToday.Checked = false;
            rdbYesterday.Checked = false;
            rdbMonth.Checked = false;
            rdbYear.Checked = false;
            showSalesReport();
            dgvBestAndWorst.Visible = false;
        }

        private void rdbBestSelling_CheckedChanged(object sender, EventArgs e)
        {
            dgvBestAndWorst.Visible = true;
            conn.Open();
            MySqlCommand scom = conn.CreateCommand();
            scom.CommandText = "SELECT product_name, description, SUM(quantity) as Quantity, SUM(total_price) as Total FROM sales_report GROUP BY product_name, description ORDER BY Quantity DESC LIMIT 10";
            MySqlDataAdapter sda = new MySqlDataAdapter(scom);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            conn.Close();
            dgvBestAndWorst.DataSource = dt;
            if (dgvBestAndWorst.Rows.Count > 0)
            {
                dgvBestAndWorst.Rows[0].Selected = false;
            }
        }

        private void rdbWorstSelling_CheckedChanged(object sender, EventArgs e)
        {
            dgvBestAndWorst.Visible = true;
            conn.Open();
            MySqlCommand scom = conn.CreateCommand();
            scom.CommandText = "SELECT product_name, description, SUM(quantity) as Quantity, SUM(total_price) as Total FROM sales_report GROUP BY product_name, description ORDER BY Quantity ASC LIMIT 10";
            MySqlDataAdapter sda = new MySqlDataAdapter(scom);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            conn.Close();
            dgvBestAndWorst.DataSource = dt;
            if (dgvBestAndWorst.Rows.Count > 0)
            {
                dgvBestAndWorst.Rows[0].Selected = false;
            }
        }

        private void rdbToday_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbBestSelling.Checked == true)
            {
                dgvBestAndWorst.Visible = true;
                conn.Open();
                MySqlCommand scom = conn.CreateCommand();
                scom.CommandText = "SELECT product_name, description, SUM(quantity) as Quantity, SUM(total_price) as Total FROM sales_report WHERE date_sold = @today GROUP BY product_name, description ORDER BY Quantity DESC LIMIT 10";
                scom.Parameters.AddWithValue("@today", System.DateTime.Now.ToString("yyyy/MM/dd"));
                MySqlDataAdapter sda = new MySqlDataAdapter(scom);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                conn.Close();
                dgvBestAndWorst.DataSource = dt;
                if (dgvBestAndWorst.Rows.Count > 0)
                {
                    dgvBestAndWorst.Rows[0].Selected = false;
                }
            }
            else if (rdbWorstSelling.Checked == true)
            {
                dgvBestAndWorst.Visible = true;
                conn.Open();
                MySqlCommand scom = conn.CreateCommand();
                scom.CommandText = "SELECT product_name, description, SUM(quantity) AS Quantity, SUM(total_price) as Total FROM sales_report WHERE date_sold = @today GROUP BY product_name, description ORDER BY Quantity ASC LIMIT 10";
                scom.Parameters.AddWithValue("@today", System.DateTime.Now.ToString("yyyy/MM/dd"));
                MySqlDataAdapter sda = new MySqlDataAdapter(scom);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                conn.Close();
                dgvBestAndWorst.DataSource = dt;
                if (dgvBestAndWorst.Rows.Count > 0)
                {
                    dgvBestAndWorst.Rows[0].Selected = false;
                }
            }
            else
            {
                dgvBestAndWorst.Visible = true;
                conn.Open();
                MySqlCommand scom = conn.CreateCommand();
                scom.CommandText = "SELECT pos_num, product_name, description, quantity, (total_price) AS Total FROM sales_report WHERE date_sold = @today";
                scom.Parameters.AddWithValue("@today", System.DateTime.Now.ToString("yyyy/MM/dd"));
                MySqlDataAdapter sda = new MySqlDataAdapter(scom);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                conn.Close();
                dgvBestAndWorst.DataSource = dt;
                if (dgvBestAndWorst.Rows.Count > 0)
                {
                    dgvBestAndWorst.Rows[0].Selected = false;
                }
            }
        }

        private void rdbYesterday_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbBestSelling.Checked == true)
            {
                dgvBestAndWorst.Visible = true;
                conn.Open();
                MySqlCommand scom = conn.CreateCommand();
                scom.CommandText = "SELECT product_name, SUM(quantity) as Quantity, SUM(total_price) as Total FROM sales_report WHERE date_sold = @yesterday GROUP BY product_name, description ORDER BY Quantity DESC LIMIT 10";
                scom.Parameters.AddWithValue("@yesterday", System.DateTime.Now.AddDays(-1).ToString("yyyy/MM/dd"));
                MySqlDataAdapter sda = new MySqlDataAdapter(scom);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                conn.Close();
                dgvBestAndWorst.DataSource = dt;
                if (dgvBestAndWorst.Rows.Count > 0)
                {
                    dgvBestAndWorst.Rows[0].Selected = false;
                }
            }
            else if (rdbWorstSelling.Checked == true)
            {
                dgvBestAndWorst.Visible = true;
                conn.Open();
                MySqlCommand scom = conn.CreateCommand();
                scom.CommandText = "SELECT product_name, SUM(quantity) as Quantity, SUM(total_price) as Total FROM sales_report WHERE date_sold = @yesterday GROUP BY product_name, description ORDER BY Quantity ASC LIMIT 10";
                scom.Parameters.AddWithValue("@yesterday", System.DateTime.Now.AddDays(-1).ToString("yyyy/MM/dd"));
                MySqlDataAdapter sda = new MySqlDataAdapter(scom);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                conn.Close();
                dgvBestAndWorst.DataSource = dt;
                if (dgvBestAndWorst.Rows.Count > 0)
                {
                    dgvBestAndWorst.Rows[0].Selected = false;
                }
            }
            else
            {
                dgvBestAndWorst.Visible = true;
                conn.Open();
                MySqlCommand scom = conn.CreateCommand();
                scom.CommandText = "SELECT pos_num, product_name, description, (quantity) AS QUANTITY, (total_price) AS Total FROM sales_report WHERE date_sold = @today";
                scom.Parameters.AddWithValue("@today", System.DateTime.Now.AddDays(-1).ToString("yyyy/MM/dd"));
                MySqlDataAdapter sda = new MySqlDataAdapter(scom);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                conn.Close();
                dgvBestAndWorst.DataSource = dt;
                if (dgvBestAndWorst.Rows.Count > 0)
                {
                    dgvBestAndWorst.Rows[0].Selected = false;
                }
            }

        }

        private void rdbMonth_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbBestSelling.Checked == true)
            {
                dgvBestAndWorst.Visible = true;
                conn.Open();
                MySqlCommand scom = conn.CreateCommand();
                scom.CommandText = "SELECT product_name, description, SUM(quantity) as Quantity, SUM(total_price) as Total FROM sales_report WHERE MONTH(date_sold) = MONTH(@month) GROUP BY product_name, description ORDER BY Quantity DESC LIMIT 10";
                scom.Parameters.AddWithValue("@month", System.DateTime.Now.ToString("yyyy/MM/dd"));
                MySqlDataAdapter sda = new MySqlDataAdapter(scom);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                conn.Close();
                dgvBestAndWorst.DataSource = dt;
                if (dgvBestAndWorst.Rows.Count > 0)
                {
                    dgvBestAndWorst.Rows[0].Selected = false;
                }
            }
            else if (rdbBestSelling.Checked == true)
            {
                dgvBestAndWorst.Visible = true;
                conn.Open();
                MySqlCommand scom = conn.CreateCommand();
                scom.CommandText = "SELECT product_name, description, SUM(quantity) as Quantity, SUM(total_price) as Total FROM sales_report WHERE MONTH(date_sold) = MONTH(@month) GROUP BY product_name, description ORDER BY Quantity ASC LIMIT 10";
                scom.Parameters.AddWithValue("@month", System.DateTime.Now.ToString("yyyy/MM/dd"));
                MySqlDataAdapter sda = new MySqlDataAdapter(scom);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                conn.Close();
                dgvBestAndWorst.DataSource = dt;
                if (dgvBestAndWorst.Rows.Count > 0)
                {
                    dgvBestAndWorst.Rows[0].Selected = false;
                }
            }
            else
            {
                dgvBestAndWorst.Visible = true;
                conn.Open();
                MySqlCommand scom = conn.CreateCommand();
                scom.CommandText = "SELECT pos_num, product_name, description, (quantity) AS Quantity, (total_price) AS Total FROM sales_report WHERE MONTH(date_sold) = MONTH(@month)";
                scom.Parameters.AddWithValue("@month", System.DateTime.Now.ToString("yyyy/MM/dd"));
                MySqlDataAdapter sda = new MySqlDataAdapter(scom);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                conn.Close();
                dgvBestAndWorst.DataSource = dt;
                if (dgvBestAndWorst.Rows.Count > 0)
                {
                    dgvBestAndWorst.Rows[0].Selected = false;
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Sales_and_Inventory_For_Marj_Hardware
{
    public partial class POS : Form
    {
        MySqlConnection conn = new MySqlConnection("SERVER = localhost; USERNAME = root; PASSWORd = ; DATABASE = marj_hardware");
        public static string barcode1 = "";
        public static int stocks1 = 0;
        public POS()
        {
            InitializeComponent();
            showCartList();
            getPOSNo();
            this.ActiveControl = txtBarcode;
        }
        //METHODS
        private void getPOSNo()
        {
            try
            {
                conn.Open();
                MySqlCommand scom = conn.CreateCommand();
                scom.CommandText = "SELECT max(pos_num) + 1 as 'pos' FROM sales_report";
                MySqlDataReader dr = scom.ExecuteReader();
                while (dr.Read())
                {
                    lblPOSNo.Text = dr.GetString("pos");
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

        private void clearFields()
        {
            txtQuantity.Text = "1";
            txtItemName.Text = "";
            txtBrand.Text = "";
            txtCategory.Text = "";
            txtDescription.Text = "";
            txtSellingPrice.Text = "";
            txtStocks.Text = "";
            lblTotalPrice.Text = "";
            lblTotalItem.Text = "";
            txtCash.Text = "";
            lblChange.Text = "0";
            lstReceipt.Items.Clear();
        }
        private void printReceipt()
        {
            PrintDialog printDialog = new PrintDialog();

            PrintDocument printDocument = new PrintDocument();

            printDialog.Document = printDocument; //add the document to the dialog box...        

            printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(createReceipt); //add an event handler that will do the printing

            //on a till you will not want to ask the user where to print but this is fine for the test envoironment.

            DialogResult result = printDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                printDocument.Print();
            }
        }

        private void createReceipt(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //this prints the reciept
            Graphics graphic = e.Graphics;
            //FixedDocument document = new FixedDocument();
            //document.DocumentPaginator.PageSize = new Size(printDialog.PrintableAreaWidth, printDialog.PrintableAreaHeight);


            //e.PageSettings.PaperSize.Width = 50;
            Font font = new Font("Courier New", 8); //must use a mono spaced font as the spaces need to line up

            float fontHeight = font.GetHeight();

            int startX = 10;
            int startY = 10;
            int offset = 40;
            string date = System.DateTime.Now.ToString("yyyy/MM/dd");
            string time = System.DateTime.Now.ToString("hh:mm:ss");
            graphic.DrawString("".PadRight(2) + "MARJ HARDWARE", new Font("Courier New", 12), new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + 18;
            graphic.DrawString("".PadRight(2) + "Blk. 17 Lot 1 Phase 2", new Font("Courier New", 8), new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + 10;
            graphic.DrawString("".PadRight(1) + "Marinig, Cabuyao Laguna", new Font("Courier New", 8), new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + 10;
            graphic.DrawString("".PadRight(3) + "Tin: 143-148-265-001", new Font("Courier New", 8), new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + 10;
            graphic.DrawString("".PadRight(2) + "CP No.: 0912-007-8003", new Font("Courier New", 8), new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + 10;
            graphic.DrawString("".PadRight(4) + "Tel No.: 847-0890", new Font("Courier New", 8), new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + 20;

            graphic.DrawString("Cashier: Lars", new Font("Courier New", 8, FontStyle.Regular), new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + 15;
            graphic.DrawString("OR#: " + lblPOSNo.Text, new Font("Courier New", 8, FontStyle.Regular), new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + 15;
            graphic.DrawString(time.PadRight(15) + date, new Font("Courier New", 8, FontStyle.Regular), new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + 10;
            graphic.DrawString("=========================", font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + 10;
            string top = "Name".PadRight(20) + "Total";
            graphic.DrawString(top, font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + (int)fontHeight; //make the spacing consistent
            graphic.DrawString("=========================", font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + (int)fontHeight + 5; 



            foreach (string item in lstReceipt.Items)
            {
                //create the string to print on the reciept
                string productDescription = item;
                string productTotal = item.Substring(item.Length - 6, 6);
                //decimal productPrice = Convert.ToDecimal(item.Substring(item.Length - 5, 5));

                //MessageBox.Show(item.Substring(item.Length - 5, 5) + "PROD TOTAL: " + productTotal);



                if (productDescription.Contains("  -"))
                {
                    string productLine = productDescription.Substring(0, 24);

                    graphic.DrawString(productLine, new Font("Courier New", 12, FontStyle.Italic), new SolidBrush(Color.Red), startX, startY + offset);

                    offset = offset + (int)fontHeight + 5; //make the spacing consistent
                }
                else
                {
                    string productLine = productDescription;

                    graphic.DrawString(productLine, font, new SolidBrush(Color.Black), startX, startY + offset);

                    offset = offset + (int)fontHeight + 5; //make the spacing consistent
                }

            }
            offset = offset + 10;
            graphic.DrawString("".PadRight(5) + "THANK YOU", new Font("Courier New", 10), new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + 15;
            graphic.DrawString("".PadRight(0) + "PLEASE COME AGAIN!!!", new Font("Courier New", 10), new SolidBrush(Color.Black), startX, startY + offset);
           



        }

        private void showCartList()
        {
            try
            {
                conn.Open();
                MySqlCommand scom = conn.CreateCommand();
                scom.CommandText = "SELECT * FROM pos";
                MySqlDataAdapter sda = new MySqlDataAdapter(scom);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dgvCartList.DataSource = dt;
                conn.Close();
                if (dgvCartList.Rows.Count > 0)
                {
                    dgvCartList.Rows[0].Selected = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void computeTotalItem()
        {
            if (dgvCartList.Rows.Count > 0)
            {
                try
                {
                    conn.Open();
                    MySqlCommand scom = conn.CreateCommand();
                    scom.CommandText = "SELECT SUM(quantity) AS 'quan' FROM pos";
                    MySqlDataReader dr = scom.ExecuteReader();
                    while (dr.Read())
                    {
                        String gprice = dr["quan"].ToString();
                        Double generatetotalprice = Convert.ToDouble(gprice);
                        lblTotalItem.Text = Convert.ToString(generatetotalprice);
                    }
                    dr.Close();
                    conn.Close();
                }
                catch (Exception a)
                {
                    MessageBox.Show(a.Message);
                }
            }
            else
            {
                lblTotalItem.Text = "";
            }
        }

        private void computeTotalPrice()
        {
            if (dgvCartList.Rows.Count > 0)
            {
                try
                {
                    conn.Open();
                    MySqlCommand scom = conn.CreateCommand();
                    scom.CommandText = "SELECT SUM(total_price) AS 'Total Price' FROM pos";
                    MySqlDataReader dr = scom.ExecuteReader();
                    while (dr.Read())
                    {
                        String gprice = dr["Total Price"].ToString();
                        Double generatetotalprice = Convert.ToDouble(gprice);
                        lblTotalPrice.Text = Convert.ToString(String.Format("{0:0.00}", generatetotalprice));
                    }
                    dr.Close();
                    conn.Close();
                }
                catch (Exception a)
                {
                    MessageBox.Show(a.Message);
                }
            }
            else
            {
                lblTotalPrice.Text = "";
            }
        }

        private void AddFormClosing(object sender, FormClosingEventArgs e)
        {
            showCartList();
            computeTotalItem();
            computeTotalPrice();
        }

        private void POS_Load(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void txtBarcode_OnValueChanged(object sender, EventArgs e)
        {
            if (txtBarcode.Text != "")
            {
                try
                {
                    conn.Open();
                    string sql = "SELECT * FROM product WHERE barcode = @barcode AND Stocks != 0 AND Kind = 'Product'";
                    MySqlDataAdapter sda = new MySqlDataAdapter(sql, conn);
                    sda.SelectCommand.Parameters.AddWithValue("@barcode", txtBarcode.Text);
                    DataTable sdt = new DataTable();
                    sda.Fill(sdt);
                    conn.Close();
                    if (sdt.Rows.Count > 0)
                    {
                        for (int samp = 0; samp < sdt.Rows.Count; samp++)
                        {
                            DataRow sdr = sdt.Rows[samp];
                            if (sdr["barcode"].ToString().Equals(txtBarcode.Text))
                            {
                                txtItemName.Text = sdt.Rows[0][2].ToString();
                                txtBrand.Text = sdt.Rows[0][3].ToString();
                                txtCategory.Text = sdt.Rows[0][4].ToString();
                                txtDescription.Text = sdt.Rows[0][5].ToString();
                                txtSellingPrice.Text = sdt.Rows[0][9].ToString();
                                txtStocks.Text = sdt.Rows[0][7].ToString();
                                if (txtItemName.Text != "")
                                {
                                    txtQuantity.Focus();
                                }
                            }
                        }
                    }
                }
                catch (Exception a)
                {
                    MessageBox.Show(a.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
        }

        private void insertToCart()
        {
            if (Convert.ToInt32(txtQuantity.Text) <= Convert.ToInt32(txtStocks.Text))
            {
                MySqlCommand scom = new MySqlCommand("SELECT * FROM pos WHERE barcode = '" + txtBarcode.Text + "'", conn);
                MySqlDataAdapter sda1 = new MySqlDataAdapter(scom);
                DataSet ds = new DataSet();
                sda1.Fill(ds);
                int i = ds.Tables[0].Rows.Count;
                if (i > 0)
                {
                    conn.Open();
                    MySqlCommand scom1 = conn.CreateCommand();
                    scom1.CommandText = "UPDATE pos SET quantity = quantity + @quantity WHERE barcode = @barcode";
                    scom1.Parameters.AddWithValue("@barcode", txtBarcode.Text);
                    scom1.Parameters.AddWithValue("@quantity", txtQuantity.Text);
                    scom1.ExecuteNonQuery();
                    conn.Close();

                    conn.Open();
                    MySqlCommand scom2 = conn.CreateCommand();
                    scom2.CommandText = "UPDATE product SET stocks = stocks - @quantity WHERE barcode = @barcode";
                    scom2.Parameters.AddWithValue("@barcode", txtBarcode.Text);
                    scom2.Parameters.AddWithValue("@quantity", txtQuantity.Text);
                    scom2.ExecuteNonQuery();
                    conn.Close();

                    conn.Open();
                    MySqlCommand scom5 = conn.CreateCommand();
                    scom5.CommandText = "UPDATE pos SET total_price = price * quantity WHERE barcode = @barcode";
                    scom5.Parameters.AddWithValue("@barcode", txtBarcode.Text);
                    scom5.Parameters.AddWithValue("@quantity", txtQuantity.Text);
                    scom5.ExecuteNonQuery();
                    conn.Close();

                    showCartList();
                    getProductInformation();
                    txtQuantity.Text = "1";
                    computeTotalPrice();
                    computeTotalItem();
                }
                else
                {
                    decimal price = Convert.ToDecimal(txtSellingPrice.Text);
                    decimal quantity = Convert.ToDecimal(txtQuantity.Text);
                    decimal total = price * quantity;
                    conn.Open();
                    MySqlCommand scom3 = conn.CreateCommand();
                    scom3.CommandText = "INSERT INTO pos (barcode, name, description, price, quantity, total_price) VALUES (@barcode, @name, @description, @costPrice, @quantity, @total)";
                    scom3.Parameters.AddWithValue("@barcode", txtBarcode.Text);
                    scom3.Parameters.AddWithValue("@name", txtItemName.Text);
                    scom3.Parameters.AddWithValue("@description", txtDescription.Text);
                    scom3.Parameters.AddWithValue("@costPrice", txtSellingPrice.Text);
                    scom3.Parameters.AddWithValue("@quantity", txtQuantity.Text);
                    scom3.Parameters.AddWithValue("@total", total);
                    scom3.ExecuteNonQuery();
                    conn.Close();

                    conn.Open();
                    MySqlCommand scom4 = conn.CreateCommand();
                    scom4.CommandText = "UPDATE product SET stocks = stocks - @quantity WHERE barcode = @barcode";
                    scom4.Parameters.AddWithValue("@barcode", txtBarcode.Text);
                    scom4.Parameters.AddWithValue("@quantity", txtQuantity.Text);
                    scom4.ExecuteNonQuery();
                    conn.Close();
                    showCartList();
                    getProductInformation();
                    txtQuantity.Text = "1";
                    computeTotalPrice();
                    computeTotalItem();
                }
            }
            else
            {
                alert.Show("You've no stocks", alert.AlertType.warning);
            }
        }
        private void getProductInformation()
        {
            if (txtBarcode.Text != "")
            {
                try
                {
                    conn.Open();
                    string sql = "SELECT * FROM product WHERE barcode = @barcode AND Stocks != 0 AND Kind = 'Product'";
                    MySqlDataAdapter sda = new MySqlDataAdapter(sql, conn);
                    sda.SelectCommand.Parameters.AddWithValue("@barcode", txtBarcode.Text);
                    DataTable sdt = new DataTable();
                    sda.Fill(sdt);
                    conn.Close();
                    if (sdt.Rows.Count > 0)
                    {
                        for (int samp = 0; samp < sdt.Rows.Count; samp++)
                        {
                            DataRow sdr = sdt.Rows[samp];
                            if (sdr["barcode"].ToString().Equals(txtBarcode.Text))
                            {
                                txtStocks.Text = sdt.Rows[0][7].ToString();
                            }
                        }
                    }
                }
                catch (Exception a)
                {
                    MessageBox.Show(a.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
        }

        private void txtQuantity_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void txtBarcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void bunifuCustomLabel1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtQuantity_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                insertToCart();
                clearFields();
                computeTotalItem();
                computeTotalPrice();
                txtBarcode.Text = "";
                txtBarcode.Focus();
            }
        }

        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtBarcode_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void btnVoid_Click(object sender, EventArgs e)
        {
            if (barcode1 != "")
            {
                try
                {
                    conn.Open();
                    MySqlCommand scom = conn.CreateCommand();
                    scom.CommandText = "UPDATE product SET stocks = stocks + @quantity WHERE barcode = @barcode";
                    scom.Parameters.AddWithValue("@quantity", stocks1);
                    scom.Parameters.AddWithValue("@barcode", barcode1);
                    scom.ExecuteNonQuery();
                    conn.Close();

                    conn.Open();
                    MySqlCommand scom1 = conn.CreateCommand();
                    scom1.CommandText = "DELETE FROM pos WHERE barcode = '" + barcode1 + "'";
                    scom1.ExecuteNonQuery();
                    conn.Close();
                    showCartList();
                    getProductInformation();
                    computeTotalItem();
                    computeTotalPrice();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                alert.Show("Please select an item.", alert.AlertType.warning);
            }
        }

        private void dgvCartList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCartList.Rows.Count > 0)
            {
                barcode1 = dgvCartList.CurrentRow.Cells["barcode"].Value.ToString();
                stocks1 = Convert.ToInt32(dgvCartList.CurrentRow.Cells["quantity"].Value.ToString());
            }
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            if (lblTotalPrice.Text != "")
            {
                if (txtCash.Text != "")
                {
                    if (Convert.ToDecimal(lblTotalPrice.Text) <= Convert.ToDecimal(txtCash.Text))
                    {
                        lstReceipt.Items.Clear();
                        foreach (DataGridViewRow cart in dgvCartList.Rows)
                        {
                            string name = cart.Cells["itemName"].Value.ToString();
                            string quantity = cart.Cells["quantity"].Value.ToString();
                            string price = cart.Cells["costPrice"].Value.ToString();
                            string total = cart.Cells["totalPrice"].Value.ToString();
                            string blank = "";
                            lstReceipt.Items.Add(name.PadRight(15) + String.Format("{0,10}", "₱" + total));
                            lstReceipt.Items.Add(blank.PadRight(2) + quantity.PadRight(1) + "PC(S)".PadRight(7) + "₱" + price);
                        }
                        decimal cash = Convert.ToDecimal(txtCash.Text);
                        string cash1 = String.Format("{0:0.00}", cash.ToString());
                        decimal change = Convert.ToDecimal(lblChange.Text);
                        decimal total1 = Convert.ToDecimal(lblTotalPrice.Text);
                        lstReceipt.Items.Add("-------------------------");
                        lstReceipt.Items.Add("TOTAL:".PadRight(15) + String.Format("{0,10}", total1));
                        lstReceipt.Items.Add("CASH:".PadRight(15) + String.Format("{0,10}", cash1));
                        lstReceipt.Items.Add("CHANGE:".PadRight(15) + String.Format("{0,10}", change));

                        decimal vat = (total1 * 12) / 100;
                        decimal vatable = total1 - vat;

                        string vat1 = String.Format("{0:0.00}", vat);
                        string vatable1 = String.Format("{0:0.00}", vatable);
                        lstReceipt.Items.Add("-------------------------");
                        lstReceipt.Items.Add("VATABLE:".PadRight(15) + String.Format("{0,10}", vatable1));
                        lstReceipt.Items.Add("VAT(12%):".PadRight(15) + String.Format("{0,10}", vat1));
                        lstReceipt.Items.Add("-------------------------");

                        foreach (DataGridViewRow cart in dgvCartList.Rows)
                        {
                            string name = cart.Cells["itemName"].Value.ToString();
                            string description = cart.Cells["description"].Value.ToString();
                            string quantity = cart.Cells["quantity"].Value.ToString();


                            conn.Open();
                            MySqlCommand scom2 = conn.CreateCommand();
                            scom2.CommandText = "UPDATE product SET stocks = stocks - @quantity WHERE barcode = @barcode";
                            scom2.Parameters.AddWithValue("@barcode", txtBarcode.Text);
                            scom2.Parameters.AddWithValue("@quantity", txtQuantity.Text);
                            scom2.ExecuteNonQuery();
                            conn.Close();

                            conn.Open();
                            MySqlCommand scom = conn.CreateCommand();
                            scom.CommandText = "INSERT INTO sales_report (pos_num, product_name, description, price, quantity, total_price, date_sold, time_sold) VALUES (@pos, @name, @description, @price, @quantity, @totalPrice, @date, @time)";
                            scom.Parameters.AddWithValue("@pos", lblPOSNo.Text);
                            scom.Parameters.AddWithValue("@name", cart.Cells["itemName"].Value);
                            scom.Parameters.AddWithValue("@description", cart.Cells["description"].Value);
                            scom.Parameters.AddWithValue("@price", cart.Cells["costPrice"].Value);
                            scom.Parameters.AddWithValue("@quantity", cart.Cells["quantity"].Value);
                            scom.Parameters.AddWithValue("@totalPrice", cart.Cells["totalPrice"].Value);
                            scom.Parameters.AddWithValue("@date", System.DateTime.Now.ToString("yyyy/MM/dd"));
                            scom.Parameters.AddWithValue("@time", System.DateTime.Now.ToString("hh:mm:ss"));
                            scom.ExecuteNonQuery();
                            conn.Close();
                           
                        }

                        //showcartlist();
                        printReceipt();
                        //clearFields();
                        getPOSNo();
                    }
                }
                else
                {
                    alert.Show("Cash is not enough.", alert.AlertType.warning);
                }
            }
        }

        private void txtCash_OnValueChanged(object sender, EventArgs e)
        {
            if(txtCash.Text != "" && lblTotalPrice.Text != "")
            {
                decimal total = Convert.ToDecimal(lblTotalPrice.Text);
                decimal cash = Convert.ToDecimal(txtCash.Text);
                decimal change;
                if (total <= cash)
                {
                    change = cash - total;
                    lblChange.Text = change.ToString();
                }
                else
                {
                    lblChange.Text = "0";
                }
            }
            
        }

        private void txtCash_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if (e.KeyChar == '.' && (sender as Bunifu.Framework.UI.BunifuMetroTextbox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }

            if (!char.IsControl(e.KeyChar))
            {

                Bunifu.Framework.UI.BunifuMetroTextbox textBox = (Bunifu.Framework.UI.BunifuMetroTextbox)sender;

                if (textBox.Text.IndexOf('.') > -1 &&
                         textBox.Text.Substring(textBox.Text.IndexOf('.')).Length >= 3)
                {
                    e.Handled = true;
                }

            }
        }

        private void btnChange_Click(object sender, EventArgs e)
        {

        }

        private void btnHoldNext_Click(object sender, EventArgs e)
        {
            if(dgvCartList.Rows.Count > 0)
            {
                pnlCustomerName.Visible = true;
                txtCustomerName.Focus();
            }
            else
            {
                alert.Show("Please select an item first.", alert.AlertType.warning);
            }  
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            pnlCustomerName.Visible = false;
            txtCustomerName.Text = "";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (dgvCartList.Rows.Count > 0)
            {
                if(txtCustomerName.Text != "")
                {
                    DialogResult ask = MessageBox.Show("Are you sure you want to hold and proceed to the next customer?", "HOLD", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (ask == DialogResult.Yes)
                    {
                        foreach (DataGridViewRow cart in dgvCartList.Rows)
                        {
                            conn.Open();
                            MySqlCommand scom = conn.CreateCommand();
                            scom.CommandText = "INSERT INTO pos_hold (customer_name, barcode, name, description, price, quantity, total_price, time) VALUES (@customerName, @barcode, @name, @description, @price, @quantity, @totalPrice, @time)";
                            scom.Parameters.AddWithValue("@customerName", txtCustomerName.Text);
                            scom.Parameters.AddWithValue("@barcode", cart.Cells["barcode"].Value.ToString());
                            scom.Parameters.AddWithValue("@name", cart.Cells["itemName"].Value.ToString());
                            scom.Parameters.AddWithValue("@description", cart.Cells["description"].Value.ToString());
                            scom.Parameters.AddWithValue("@price", cart.Cells["costPrice"].Value.ToString());
                            scom.Parameters.AddWithValue("@quantity", cart.Cells["quantity"].Value.ToString());
                            scom.Parameters.AddWithValue("@totalPrice", cart.Cells["totalPrice"].Value.ToString());
                            scom.Parameters.AddWithValue("@time", System.DateTime.Now.ToString("hh:mm:ss"));
                            scom.ExecuteNonQuery();
                            conn.Close();
                        }
                        conn.Open();
                        MySqlCommand scom1 = conn.CreateCommand();
                        scom1.CommandText = "DELETE FROM pos";
                        scom1.ExecuteNonQuery();
                        conn.Close();
                    }
                    alert.Show("Succesfully Held", alert.AlertType.success);
                    pnlCustomerName.Visible = false;
                    showCartList();
                    txtCustomerName.Text = "";
                    clearFields();
                }
                else
                {
                    alert.Show("Please input customer name.", alert.AlertType.warning);
                }
               
            }
            else
            {
                alert.Show("Please select an item first.", alert.AlertType.warning);
            }
        }

        private void btnViewPreviousCustomer_Click(object sender, EventArgs e)
        {
            Previous_Customer previous = new Previous_Customer();
            previous.FormClosing += new FormClosingEventHandler(AddFormClosing);
            previous.ShowDialog();
        }
    }
}

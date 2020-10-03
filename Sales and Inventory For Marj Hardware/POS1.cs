using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Sales_and_Inventory_For_Marj_Hardware
{
    public partial class POS1 : Form
    {
        MySqlConnection conn = new MySqlConnection("SERVER = localhost; USERNAME = root; PASSWORD = ; DATABASE = marj_hardware");
        public static string barcode1 = "";
        public static Boolean stop;
        public static int stocks1;
        public POS1()
        {
            InitializeComponent();
            getItem();
            showCartList();
        }
        //METHODS

        //private void AutoComplete()
        //{

        //        conn.Open();
        //        MySqlCommand cmd = new MySqlCommand("SELECT barcode FROM product WHERE Stocks != 0 AND kind = 'Product'", conn);
        //        MySqlDataReader reader = cmd.ExecuteReader();
        //        AutoCompleteStringCollection MyCollection = new AutoCompleteStringCollection();
        //        while (reader.Read())
        //        {
        //            MyCollection.Add(reader.GetString(0));
        //        }
        //        txtBarcode.AutoCompleteCustomSource = MyCollection;
        //        conn.Close();
        //}

        private void getItem()
        {
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM product WHERE Stocks != 0 AND kind = 'Product'", conn);
            MySqlDataReader myReader;
            try
            {
                conn.Open();
                myReader = cmd.ExecuteReader();

                while (myReader.Read())
                {
                    string categoryName = myReader.GetString("name");
                    cmbProductName.Items.Add(categoryName);
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void insertToCart()
        {
            if(txtBarcode.Text != "" && txtBrand.Text != "")
            {
                if(Convert.ToInt32(txtStocks.Text) >= Convert.ToInt32(txtQuantity.Text))
                {

                    try
                    {
                        MySqlCommand scom = new MySqlCommand("SELECT * FROM pos WHERE barcode = '" + txtBarcode.Text + "'", conn);
                        MySqlDataAdapter sda = new MySqlDataAdapter(scom);
                        DataSet ds = new DataSet();
                        sda.Fill(ds);
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

                            //decimal price = Convert.ToDecimal(dgvCartList.CurrentRow.Cells["costPrice"].Value.ToString());
                            //decimal quantity = Convert.ToDecimal(dgvCartList.CurrentRow.Cells["quantity"].Value.ToString());
                            //decimal total = price * quantity;

                            //conn.Open();
                            //MySqlCommand scom3 = conn.CreateCommand();
                            //scom3.CommandText = "UPDATE pos SET total_price = @total WHERE barcode = @barcode";
                            //scom3.Parameters.AddWithValue("@barcode", txtBarcode.Text);
                            //scom3.Parameters.AddWithValue("@total", total);
                            //scom3.ExecuteNonQuery();
                            //conn.Close();

                            showCartList();
                            getProductInformation();
                        }
                        else
                        {
                            decimal price = Convert.ToDecimal(txtSellingPrice.Text);
                            decimal quantity = Convert.ToDecimal(txtQuantity.Text);
                            decimal total = price * quantity;
                            conn.Open();
                            MySqlCommand scom3 = conn.CreateCommand();
                            scom3.CommandText = "INSERT INTO pos (barcode, name, brand, category, description, cost_price, quantity, total_price) VALUES (@barcode, @name, @brand, @category, @description, @costPrice, @quantity, @total)";
                            scom3.Parameters.AddWithValue("@barcode", txtBarcode.Text);
                            scom3.Parameters.AddWithValue("@name", cmbProductName.Text);
                            scom3.Parameters.AddWithValue("@brand", txtBrand.Text);
                            scom3.Parameters.AddWithValue("@category", txtCategory.Text);
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
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    alert.Show("You've no stocks", alert.AlertType.warning);
                }
            }
            else
            {
                alert.Show("Please select an item.", alert.AlertType.warning);
            }
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
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
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
                        txtPrice.Text = Convert.ToString(String.Format("{0:0.00}", generatetotalprice));
                    }
                    dr.Close();
                    conn.Close();
                    decimal subtotal = Convert.ToDecimal(txtPrice.Text);
                    Decimal vat = (subtotal * 12) / 100;
                    txtVat.Text = vat.ToString();
                    decimal totalPrice = vat + subtotal;
                    txtTotalPrice.Text = totalPrice.ToString();
                }
                catch (Exception a)
                {
                    MessageBox.Show(a.Message);
                }
            }
            else
            {
                txtPrice.Text = "";
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
                        txtTotalItem.Text = Convert.ToString(generatetotalprice);
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
                txtTotalItem.Text = "";
            }
            
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
            int total = 0;
            

            //this prints the reciept

            Graphics graphic = e.Graphics;

            Font font = new Font("Courier New", 12); //must use a mono spaced font as the spaces need to line up

            float fontHeight = font.GetHeight();

            int startX = 10;
            int startY = 10;
            int offset = 40;

            graphic.DrawString("     Marj Hardware", new Font("Courier New", 18), new SolidBrush(Color.Black), startX, startY);
            string top = "Item Name".PadRight(15) + "Quantity".PadRight(15) + "Price";
            graphic.DrawString(top, font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + (int)fontHeight; //make the spacing consistent
            graphic.DrawString("--------------------------------------", font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + (int)fontHeight + 5; //make the spacing consistent

            

            foreach (string item in lstReceiptRecord.Items)
            {
                //create the string to print on the reciept
                string productDescription = item;
                string productTotal = item.Substring(item.Length - 6, 6);
                decimal productPrice = Convert.ToDecimal(item.Substring(item.Length - 5, 5));

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
            decimal totalprice = Convert.ToDecimal(txtTotalPrice.Text);
            decimal cash = Convert.ToDecimal(txtCash.Text);
            decimal change = Convert.ToDecimal(txtChange.Text);
            decimal vatable = Convert.ToDecimal(txtPrice.Text);
            decimal vat = Convert.ToDecimal(txtVat.Text);
            int totalQuantity = Convert.ToInt32(txtTotalItem.Text);
            change = (cash - totalprice);

            //when we have drawn all of the items add the total

            offset = offset + 20; //make some room so that the total stands out.
            graphic.DrawString("Total QTY: ".PadRight(30) + String.Format("{0:c}", totalQuantity), new Font("Courier New", 12, FontStyle.Regular), new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + 15;
            graphic.DrawString("AMOUNT DUE: ".PadRight(30) + String.Format("{0:c}", totalprice), new Font("Courier New", 12, FontStyle.Bold), new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + 15;
            graphic.DrawString("Cash: ".PadRight(30) + String.Format("{0:c}", cash), font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + 15;
            graphic.DrawString("Change: ".PadRight(30) + String.Format("{0:c}", change), font, new SolidBrush(Color.Black), startX, startY + offset);

            offset = offset + 30; //make some room so that the total stands out.
            graphic.DrawString("VATABLE SALE: ".PadRight(30) + String.Format("{0:c}", vatable), new Font("Courier New", 12, FontStyle.Bold), new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + 15;
            graphic.DrawString("VAT AMOUNT: ".PadRight(30) + String.Format("{0:c}", vat), new Font("Courier New", 12, FontStyle.Bold), new SolidBrush(Color.Black), startX, startY + offset);

            offset = offset + 30; //make some room so that the total stands out.
            graphic.DrawString("     Thank-you for your coming,", font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + 15;
            graphic.DrawString("       please come back soon!", font, new SolidBrush(Color.Black), startX, startY + offset);

        }
        private void txtBarcode_TextChanged(object sender, EventArgs e)
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

                    //if (txtBarcode.Text.Length == 12)
                    //{
                    //    txtBarcode.Text = "";
                    //}
                    if (sdt.Rows.Count > 0)
                    {
                        for (int samp = 0; samp < sdt.Rows.Count; samp++)
                        {
                            DataRow sdr = sdt.Rows[samp];
                            if (sdr["barcode"].ToString().Equals(txtBarcode.Text))
                            {

                                cmbProductName.Text = sdt.Rows[0][2].ToString();
                                txtBrand.Text = sdt.Rows[0][3].ToString();
                                txtCategory.Text = sdt.Rows[0][4].ToString();
                                txtDescription.Text = sdt.Rows[0][5].ToString();
                                txtSellingPrice.Text = sdt.Rows[0][9].ToString();
                                txtStocks.Text = sdt.Rows[0][7].ToString();
                                txtQuantity.Text = "1";
                                txtQuantity.Enabled = true;
                                if (rdbAutomatic.Checked == true)
                                {
                                    insertToCart();
                                    txtBarcode.Text = "";
                                }

                            }
                        }
                    }
                    else
                    {
                        cmbProductName.SelectedIndex = -1;
                        txtBrand.Text = "";
                        txtCategory.Text = "";
                        txtDescription.Text = "";
                        txtSellingPrice.Text = "";
                        txtStocks.Text = "";
                        txtQuantity.Text = "";
                        txtQuantity.Enabled = false;
                    }
                }
                catch (Exception a)
                {
                    MessageBox.Show(a.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            else
            {
                cmbProductName.SelectedIndex = -1;
                txtBrand.Text = "";
                txtCategory.Text = "";
                txtDescription.Text = "";
                txtSellingPrice.Text = "";
                txtStocks.Text = "";
                txtQuantity.Text = "";
                txtQuantity.Enabled = false;
            }

        }

        private void POS_Load(object sender, EventArgs e)
        {
            if (dgvCartList.Rows.Count > 0)
            {
                dgvCartList.Rows[0].Selected = false;
            }
        }

        private void txtQuantity_OnValueChanged(object sender, EventArgs e)
        {
            if(rdbAutomatic.Checked == true)
            {
                if (txtBarcode.Focus() == false)
                {
                    string getBarcode = txtQuantity.Text;
                    txtBarcode.Text = getBarcode;
                    txtQuantity.Text = "";
                }
            }  
        }

        private void textBox1_TextAlignChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbProductName_TextChanged(object sender, EventArgs e)
        {
            if (txtBarcode.Focus() == false)
            {
                txtBarcode.Focus();
            }
        }

        private void cmbProductName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbProductName.Text != "")
            {
                try
                {
                    conn.Open();
                    string sql = "SELECT * FROM product WHERE name = @name AND Stocks != 0 AND Kind = 'Product'";
                    MySqlDataAdapter sda = new MySqlDataAdapter(sql, conn);
                    sda.SelectCommand.Parameters.AddWithValue("@name", cmbProductName.Text);
                    DataTable sdt = new DataTable();
                    sda.Fill(sdt);
                    conn.Close();
                    if (sdt.Rows.Count > 0)
                    {
                        for (int samp = 0; samp < sdt.Rows.Count; samp++)
                        {
                            DataRow sdr = sdt.Rows[samp];
                            if (sdr["name"].ToString().Equals(cmbProductName.Text))
                            {

                                txtBarcode.Text = sdt.Rows[0][1].ToString();
                                txtBrand.Text = sdt.Rows[0][3].ToString();
                                txtCategory.Text = sdt.Rows[0][4].ToString();
                                txtDescription.Text = sdt.Rows[0][5].ToString();
                                txtSellingPrice.Text = sdt.Rows[0][9].ToString();
                                txtStocks.Text = sdt.Rows[0][7].ToString();
                                txtQuantity.Text = "1";
                                txtQuantity.Enabled = true;
                            }
                        }
                    }
                    else
                    {
                        cmbProductName.Text = "";
                        txtBrand.Text = "";
                        txtCategory.Text = "";
                        txtDescription.Text = "";
                        txtSellingPrice.Text = "";
                        txtStocks.Text = "";
                        txtQuantity.Text = "";
                        txtQuantity.Enabled = false;
                    }
                }
                catch (Exception a)
                {
                    MessageBox.Show(a.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            
            insertToCart();
            computeTotalItem();
            computeTotalPrice();
           
            //txtName.Text = "";
            //txtPrice.Text = "";
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void dgvCartList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgvCartList.Rows.Count > 0)
            {
                barcode1 = dgvCartList.CurrentRow.Cells["barcode"].Value.ToString();
                stocks1 = Convert.ToInt32(dgvCartList.CurrentRow.Cells["quantity"].Value.ToString());
            }        
        }

        private void btnRemoveItem_Click(object sender, EventArgs e)
        {
            if(barcode1 != "")
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
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                alert.Show("Please select an item.", alert.AlertType.warning);
            }
        }

        private void rdbAutomatic_CheckedChanged(object sender, EventArgs e)
        {
            cmbProductName.Enabled = false;
        }

        private void rdbManual_CheckedChanged(object sender, EventArgs e)
        {
            cmbProductName.Enabled = true;
        }

        private void txtBarcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void txtBarcode_KeyUp(object sender, KeyEventArgs e)
        {
            
        }

        private void btnRemoveAllItem_Click(object sender, EventArgs e)
        {
            if(dgvCartList.Rows.Count > 0)
            {
                foreach(DataGridViewRow cart in dgvCartList.Rows)
                {
                    try
                    {
                        conn.Open();
                        MySqlCommand scom = conn.CreateCommand();
                        scom.CommandText = "UPDATE product SET stocks = stocks + @stocks WHERE barcode = @barcode";
                        scom.Parameters.AddWithValue("@stocks", cart.Cells["quantity"].Value);
                        scom.Parameters.AddWithValue("@barcode", cart.Cells["barcode"].Value);
                        scom.ExecuteNonQuery();
                        conn.Close();

                        conn.Open();
                        MySqlCommand scom1 = conn.CreateCommand();
                        scom1.CommandText = "DELETE FROM pos WHERE barcode = @barcode";
                        scom1.Parameters.AddWithValue("@barcode", cart.Cells["barcode"].Value);
                        scom1.ExecuteNonQuery();
                        conn.Close();
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                showCartList();
                computeTotalItem();
                computeTotalPrice();
            }
        }

        private void bunifuThinButton25_Click(object sender, EventArgs e)
        {
            if(txtTotalPrice.Text != "")
            {
                pnlAddCash.Visible = true;
                txtAddCash1.Focus();
            }
            else
            {
                alert.Show("Please select an item first.", alert.AlertType.warning);
            }
          
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            pnlAddCash.Visible = false;
            txtAddCash1.Text = "";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(txtPrice.Text != "")
            {
                if (txtAddCash1.Text != "")
                {
                    if (txtCash.Text != "")
                    {
                        decimal cash = Convert.ToDecimal(txtCash.Text);
                        decimal addCash = Convert.ToDecimal(txtAddCash1.Text);
                        decimal total = cash + addCash;
                        txtCash.Text = total.ToString();
                        pnlAddCash.Visible = false;
                    }
                    else if (Convert.ToDecimal(txtAddCash1.Text) >= Convert.ToDecimal(txtTotalPrice.Text))
                    {
                        txtCash.Text = txtAddCash1.Text;
                        decimal change = Convert.ToDecimal(txtCash.Text) - Convert.ToDecimal(txtTotalPrice.Text);
                        txtChange.Text = change.ToString();
                        pnlAddCash.Visible = false;
                    }
                    else
                    {
                        alert.Show("Cash is not enough.", alert.AlertType.warning);
                    }
                }
                else
                {
                    alert.Show("Please input cash.", alert.AlertType.warning);
                }
            }
            else
            {
                alert.Show("Please select an item first.", alert.AlertType.warning);
            }
           
        }

        private void btnPayPrint_Click(object sender, EventArgs e)
        {
            if (txtTotalPrice.Text != "" && txtCash.Text != "")
            {
                if (Convert.ToDecimal(txtTotalPrice.Text) <= Convert.ToDecimal(txtCash.Text))
                {
                    lstReceiptRecord.Items.Clear();
                    foreach (DataGridViewRow cart in dgvCartList.Rows)
                    {
                        string name = cart.Cells["itemName"].Value.ToString();
                        string description = cart.Cells["description"].Value.ToString();
                        string quantity = cart.Cells["quantity"].Value.ToString();
                        lstReceiptRecord.Items.Add(name.PadRight(15) + quantity.PadRight(15) + cart.Cells["costPrice"].Value.ToString());

                        conn.Open();
                        MySqlCommand scom = conn.CreateCommand();
                        scom.CommandText = "INSERT INTO sales_report (product_name, brand1, category1, description, price, quantity, total_price, date_sold, time_sold) VALUES (@name, @brand, @category, @description, @price, @quantity, @totalPrice, @date, @time)";

                        scom.Parameters.AddWithValue("@name", cart.Cells["itemName"].Value);
                        scom.Parameters.AddWithValue("@brand", cart.Cells["brand"].Value);
                        scom.Parameters.AddWithValue("@category", cart.Cells["category"].Value);
                        scom.Parameters.AddWithValue("@description", cart.Cells["description"].Value);
                        scom.Parameters.AddWithValue("@price", cart.Cells["costPrice"].Value);
                        scom.Parameters.AddWithValue("@quantity", cart.Cells["quantity"].Value);
                        scom.Parameters.AddWithValue("@totalPrice", cart.Cells["totalPrice"].Value);
                        scom.Parameters.AddWithValue("@date", System.DateTime.Now.ToString("yyyy/MM/dd"));
                        scom.Parameters.AddWithValue("@time", System.DateTime.Now.ToString("hh:mm:ss"));
                        scom.ExecuteNonQuery();
                        conn.Close();

                        conn.Open();
                        MySqlCommand scom1 = conn.CreateCommand();
                        scom1.CommandText = "DELETE FROM pos";

                        scom.ExecuteNonQuery();
                        conn.Close();     
                    }
                    showCartList();
                    printReceipt();
                }
                else
                {
                    alert.Show("Cash is not enough.", alert.AlertType.warning);
                }
            }
            else
            {
               alert.Show("Please select an item and add cash.", alert.AlertType.warning);
            }
        }

        private void txtAddCash1_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtBarcode_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}

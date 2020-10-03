using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.DataViz;
using MySql.Data.MySqlClient;
using LiveCharts;
using LiveCharts.Defaults;
using LiveCharts.Wpf;
using System.Windows.Media;
using System.Threading;
using System.Timers;

namespace Sales_and_Inventory_For_Marj_Hardware
{
    public partial class Dashboard : Form
    {
        MySqlConnection conn = new MySqlConnection("SERVER = localhost; USERNAME = root; PASSWORd = ; DATABASe = marj_hardware");
        public Dashboard()
        {
            InitializeComponent();
            Bunifu.Framework.Lib.Elipse.Apply(card1, 5);
            Bunifu.Framework.Lib.Elipse.Apply(card2, 5);
            Bunifu.Framework.Lib.Elipse.Apply(card3, 5);
            Bunifu.Framework.Lib.Elipse.Apply(card4, 5);
            Bunifu.Framework.Lib.Elipse.Apply(bunifuCards1, 10);
            Bunifu.Framework.Lib.Elipse.Apply(card6, 10);
            computeTodayIncome();
            computeYesterdayIncome();
            computeMonthIncome();
            computeYearIncome();
            showGraphStockLevel(); 
            showChartFastMoving();
            showChartSlowMoving();

            timerStock.Start();
        }
        //METHOD
        private void showGraphStockLevel()
        {
            ColumnSeries col = new ColumnSeries()
            {
                Fill = new SolidColorBrush(System.Windows.Media.Color.FromRgb(255,0,0)),
                DataLabels = true,
                Values = new ChartValues<int>(),
                LabelPoint = point => point.Y.ToString()
            };

            Axis ax = new Axis()
            {
                Separator = new Separator()
                {
                    Step = 1,
                    IsEnabled = false
                },
                LabelsRotation = 20
                
                
            };
            ax.Labels = new List<string>();
            chartStockLevel.Zoom = ZoomingOptions.X;
            conn.Open();
            MySqlCommand scom = conn.CreateCommand();
            scom.CommandText = "SELECT * FROM product WHERE reorder > stocks ORDER BY stocks ASC LIMIT 20";
            MySqlDataReader dr = scom.ExecuteReader();
            while (dr.Read())
            {
                int getStocks = Convert.ToInt32(dr["stocks"].ToString());
                string getNames = dr["name"].ToString();
                col.Values.Add(getStocks);
                ax.Labels.Add(getNames);
            }
            conn.Close();

            chartStockLevel.Series.Add(col);
            chartStockLevel.AxisX.Add(ax);
           
            chartStockLevel.AnimationsSpeed = TimeSpan.FromMilliseconds(2000);
            chartStockLevel.AxisY.Add(new Axis
            {
                LabelFormatter = value => value + " Stock(s)",
                Separator = new Separator()
            });
            
        }
        private void showSalesChart()
        {
            
        }
        private void computeTodayIncome()
        {
            try
            {
                conn.Open();
                MySqlCommand scom = conn.CreateCommand();
                scom.CommandText = "SELECT SUM(total_price) AS 'total' FROM sales_report WHERE date_sold = @today";
                scom.Parameters.AddWithValue("@today", System.DateTime.Now.ToString("yyyy/MM/dd"));
                MySqlDataReader dr = scom.ExecuteReader();
                while (dr.Read())
                {
                    lblIncomeToday.Text = dr["total"].ToString();
                }
                conn.Close();

                if (lblIncomeToday.Text == "")
                {
                    lblIncomeToday.Text = "0";
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void computeYesterdayIncome()
        {
            try
            {
                conn.Open();
                MySqlCommand scom = conn.CreateCommand();
                scom.CommandText = "SELECT SUM(total_price) AS 'total' FROM sales_report WHERE date_sold = @yesterday";
                scom.Parameters.AddWithValue("@yesterday", System.DateTime.Now.AddDays(-1).ToString("yyyy/MM/dd"));
                MySqlDataReader dr = scom.ExecuteReader();
                while (dr.Read())
                {
                    lblIncomeYesterday.Text = dr["total"].ToString();
                }
                conn.Close();

                if (lblIncomeYesterday.Text == "")
                {
                    lblIncomeYesterday.Text = "0";
                }
            }
            catch (Exception e)
            {
                lblIncomeYesterday.Text = "0";
                MessageBox.Show(e.Message);
            }
        }

        private void computeMonthIncome()
        {
            try
            {
                conn.Open();
                MySqlCommand scom = conn.CreateCommand();
                scom.CommandText = "SELECT SUM(total_price) AS 'total' FROM sales_report WHERE MONTH(date_sold) = Month(@month)";
                scom.Parameters.AddWithValue("@month", System.DateTime.Now.ToString("yyyy/MM/dd"));
                MySqlDataReader dr = scom.ExecuteReader();
                while (dr.Read())
                {
                    lblMonthIncome.Text = dr["total"].ToString();
                }
                conn.Close();

                if (lblMonthIncome.Text == "")
                {
                    lblMonthIncome.Text = "0";
                }
            }
            catch (Exception e)
            {
                lblMonthIncome.Text = "0";
                MessageBox.Show(e.Message);
            }
        }

        private void computeYearIncome()
        {
            try
            {
                conn.Open();
                MySqlCommand scom = conn.CreateCommand();
                scom.CommandText = "SELECT SUM(total_price) AS 'total' FROM sales_report WHERE YEAR(date_sold) = YEAR(@year)";
                scom.Parameters.AddWithValue("@year", System.DateTime.Now.ToString("yyyy/MM/dd"));
                MySqlDataReader dr = scom.ExecuteReader();
                while (dr.Read())
                {
                    lblIncomeYear.Text = dr["total"].ToString();
                }
                conn.Close();
                if (lblIncomeYear.Text == "")
                {
                    lblIncomeYear.Text = "0";
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        private void RenderChart()
        {
            Bunifu.DataViz.Canvas canvas = new Bunifu.DataViz.Canvas();
            Bunifu.DataViz.DataPoint datapoint = new Bunifu.DataViz.DataPoint(Bunifu.DataViz.BunifuDataViz._type.Bunifu_line);
            Canvas line = new Canvas();
            DataPoint dp1 = new DataPoint(Bunifu.DataViz.BunifuDataViz._type.Bunifu_line);

            conn.Open();
            MySqlCommand scom = conn.CreateCommand();
            scom.CommandText = "SELECT DATE_FORMAT(date_sold, '%m.%d.%Y') AS 'date', SUM(total_price) AS 'total' FROM sales_report GROUP BY date_sold ORDER BY date_sold DESC LIMIT 10";
          

            MySqlDataReader dr = scom.ExecuteReader();
            while (dr.Read())
            {
                datapoint.addLabely(dr["date"].ToString(), dr["total"].ToString());
            }
            conn.Close();
            canvas.addData(datapoint);
            chartBestSeller.Render(canvas);
        }

        private void showChartFastMoving()
        {
            Func<ChartPoint, string> labelPoint = chartPoint => string.Format("{0} ({1:P})", chartPoint.Y, chartPoint.Participation);
            SeriesCollection series = new SeriesCollection();

            conn.Open();
            MySqlCommand scom = conn.CreateCommand();
            scom.CommandText = "SELECT product_name, SUM(quantity) AS 'quantity' FROM sales_report GROUP BY product_name ORDER BY quantity DESC LIMIT 5";

            MySqlDataReader dr = scom.ExecuteReader();
            while (dr.Read())
            {
                PieSeries ps = new PieSeries
                {
                    Title = dr["product_name"].ToString(),
                    Values = new ChartValues<int> {Int32.Parse(dr["quantity"].ToString())},
                    DataLabels = true,
                    LabelPoint = labelPoint
                };

                series.Add(ps);
            }
            conn.Close();
            chartFastMoving.Series = series;
            chartFastMoving.LegendLocation = LegendLocation.Bottom;
            chartFastMoving.AnimationsSpeed = TimeSpan.FromMilliseconds(2000);
        }

        private void showChartSlowMoving()
        {
            Func<ChartPoint, string> labelPoint = chartPoint => string.Format("{0} ({1:P})", chartPoint.Y, chartPoint.Participation);
            SeriesCollection series = new SeriesCollection();

            conn.Open();
            MySqlCommand scom = conn.CreateCommand();
            scom.CommandText = "SELECT product_name, SUM(quantity) AS 'quantity' FROM sales_report GROUP BY product_name ORDER BY quantity ASC LIMIT 5";
            MySqlDataReader dr = scom.ExecuteReader();
            while (dr.Read())
            {
                PieSeries ps = new PieSeries
                {
                    Title = dr["product_name"].ToString(),
                    Values = new ChartValues<int> { Int32.Parse(dr["quantity"].ToString()) },
                    DataLabels = true,
                    LabelPoint = labelPoint
                };

                series.Add(ps);
            }
            conn.Close();
            chartSlowMoving.Series = series;
            chartSlowMoving.LegendLocation = LegendLocation.Bottom;
            chartSlowMoving.AnimationsSpeed = TimeSpan.FromMilliseconds(2000);
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            RenderChart();
            //cartesianChart1.DisableAnimations = true;

            //CLEAR
            //cartesianChart1.AxisX[0].MinValue = double.NaN;
            //cartesianChart1.AxisX[0].MaxValue = double.NaN;
            //cartesianChart1.AxisY[0].MinValue = double.NaN;
            //cartesianChart1.AxisY[0].MaxValue = double.NaN;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void stopAnimation_Tick(object sender, EventArgs e)
        {

        }

        private void timerStock_Tick(object sender, EventArgs e)
        {

        }

        private void timerStock_Tick_1(object sender, EventArgs e)
        {
            chartStockLevel.DisableAnimations = true;
            chartSlowMoving.DisableAnimations = true;
            chartFastMoving.DisableAnimations = true;
            timerStock.Stop();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            chartStockLevel.AxisX[0].MinValue = double.NaN;
            chartStockLevel.AxisX[0].MaxValue = double.NaN;
            chartStockLevel.AxisY[0].MinValue = double.NaN;
            chartStockLevel.AxisY[0].MaxValue = double.NaN;
        }

        private void chartFastMoving_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {

        }

        private void bunifuSeparator1_Load(object sender, EventArgs e)
        {

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }
    }
}

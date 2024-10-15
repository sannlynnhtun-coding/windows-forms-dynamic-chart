using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient; // Import for MSSQL
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace PosReport.WindowsForms
{
    public partial class frmPOSReport : Form
    {
        // Update connection string for MSSQL
        private string connectionString = @"Data Source=.;Initial Catalog=POSDatabase;User ID=sa;Password=sasa@123;TrustServerCertificate=True;";

        public frmPOSReport()
        {
            InitializeComponent();
            LoadCustomerData();
            comboChartType.Items.AddRange(new object[]
            {
                "Bar",
                "Column",
                "Line",
                "Pie",
                "Doughnut",
                "Spline",
                "Area",
                "Stacked Column",
                "Stacked Bar",
                "Spline Area"
            });
        }

        private void LoadCustomerData()
        {
            using (var connection = new SqlConnection(connectionString))  // Use SqlConnection for MSSQL
            {
                connection.Open();
                string query = "SELECT Name FROM Customer";  // Fetch customer names

                using (var cmd = new SqlCommand(query, connection))  // Use SqlCommand for MSSQL
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())  // Use SqlDataReader for MSSQL
                    {
                        while (reader.Read())
                        {
                            comboCustomer.Items.Add(reader.GetString(0)); // Add customer names to dropdown
                        }
                    }
                }
            }
        }

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            chartSales.Visible = true;

            if (comboCustomer.SelectedItem == null)
                comboCustomer.SelectedIndex = 0;

            if (comboChartType.SelectedItem == null)
                comboChartType.SelectedIndex = 0;

            string selectedCustomer = comboCustomer.SelectedItem.ToString();
            string selectedChartType = comboChartType.SelectedItem.ToString();

            // Generate report for the selected customer and chart type
            GenerateReport(selectedCustomer, selectedChartType);
        }

        private void GenerateReport(string customerName, string chartType)
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("SaleDate", typeof(string));
            dt.Columns.Add("TotalSale", typeof(double));

            using (var connection = new SqlConnection(connectionString))  // Use SqlConnection for MSSQL
            {
                connection.Open();
                string query = @"SELECT s.SaleDate, SUM(sd.Quantity * sd.PricePerUnit) AS TotalSale
                                 FROM Sale s
                                 JOIN SaleDetail sd ON s.Id = sd.SaleId
                                 JOIN Customer c ON s.CustomerId = c.Id
                                 WHERE c.Name = @CustomerName
                                 GROUP BY s.SaleDate";

                using (var cmd = new SqlCommand(query, connection))  // Use SqlCommand for MSSQL
                {
                    cmd.Parameters.AddWithValue("@CustomerName", customerName);

                    using (SqlDataReader reader = cmd.ExecuteReader())  // Use SqlDataReader for MSSQL
                    {
                        while (reader.Read())
                        {
                            DataRow row = dt.NewRow();
                            row["SaleDate"] = reader["SaleDate"].ToString();
                            row["TotalSale"] = Convert.ToDouble(reader["TotalSale"]);
                            dt.Rows.Add(row);
                        }
                    }
                }
            }

            BindChart(dt, chartType, customerName);
        }

        private void BindChart(DataTable dt, string chartType, string customerName)
        {
            // Clear existing chart data
            chartSales.Series.Clear();
            chartSales.Titles.Clear();

            // Create a new series
            Series series = new Series("Sales");
            series.ChartType = (SeriesChartType)Enum.Parse(typeof(SeriesChartType), chartType);  // Set the chart type dynamically

            foreach (DataRow row in dt.Rows)
            {
                string saleDate = row["SaleDate"].ToString();
                double totalSale = Convert.ToDouble(row["TotalSale"]);
                series.Points.AddXY(saleDate, totalSale);  // Add data to the chart
            }

            // Add the series to the chart
            chartSales.Series.Add(series);

            // Set chart title
            chartSales.Titles.Add($"Sales Report for {customerName}");

            // Customize Pie Chart if selected
            if (chartType == "Pie" || chartType == "Doughnut")
            {
                series.IsValueShownAsLabel = true;
                series.Label = "#PERCENT";  // Show percentages
                series.LegendText = "#VALX"; // Show sale date as legend
                chartSales.ChartAreas[0].Area3DStyle.Enable3D = true;  // Optional: make it 3D
            }
        }
    }
}

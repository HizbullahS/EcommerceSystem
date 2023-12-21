using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EcommerceSystem
{
    public partial class TotalSalesControl : UserControl
    {
        public TotalSalesControl()
        {
            InitializeComponent();
            InsertingDataInGrid();
            UpdateTotalAmountLabel();
            UpdateTotalProductsSoldLabel();
            UpdateMostSoldProductLabel();
        }
        private void TotalSalesControl_Load(object sender, EventArgs e)
        {

        }
        public void InsertingDataInGrid()
        {
            try
            {
                string connectionString = @"Data Source=HIZ-PC\SQLEXPRESS; Initial Catalog=EcommerceSystem; Integrated Security=true;";
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Replace column names with actual column names from your "TotalSales" table
                    string query = "SELECT OrderId, ProductId, ProductName, Quantity, TotalPrice, SaleDate FROM TotalSales";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        SqlDataAdapter sda = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);

                        dataGridViewSales.DataSource = dt;
                    }

                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Data Retrieval Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void dataGridViewSales_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void UpdateTotalAmountLabel()
        {
            try
            {
                string connectionString = @"Data Source=HIZ-PC\SQLEXPRESS; Initial Catalog=EcommerceSystem; Integrated Security=true;";
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Retrieve the total amount
                    string query = "SELECT SUM(TotalPrice) AS TotalAmount FROM TotalSales";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        object result = cmd.ExecuteScalar();
                        if (result != null && result != DBNull.Value)
                        {
                            decimal totalAmount = Convert.ToDecimal(result);
                            lblTotalAmount.Text = $"Total Amount: {totalAmount:C}";
                        }
                    }

                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void UpdateTotalProductsSoldLabel()
        {
            try
            {
                string connectionString = @"Data Source=HIZ-PC\SQLEXPRESS; Initial Catalog=EcommerceSystem; Integrated Security=true;";
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Retrieve the total products sold
                    string query = "SELECT SUM(Quantity) AS TotalProductsSold FROM TotalSales";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        object result = cmd.ExecuteScalar();
                        if (result != null && result != DBNull.Value)
                        {
                            int totalProductsSold = Convert.ToInt32(result);
                            lblTotalProductsSold.Text = $"Total Products Sold: {totalProductsSold}";
                        }
                    }

                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void UpdateMostSoldProductLabel()
        {
            try
            {
                string connectionString = @"Data Source=HIZ-PC\SQLEXPRESS; Initial Catalog=EcommerceSystem; Integrated Security=true;";
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Retrieve the most sold product
                    string query = "SELECT TOP 1 ProductName, MAX(Quantity) AS MaxQuantity FROM TotalSales GROUP BY ProductName ORDER BY MaxQuantity DESC";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string mostSoldProductName = reader["ProductName"].ToString();
                                int maxQuantity = Convert.ToInt32(reader["MaxQuantity"]);
                                lblMostSoldProduct.Text = $"Most Sold Product: {mostSoldProductName} (Quantity: {maxQuantity})";
                            }
                        }
                    }

                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



    }
}

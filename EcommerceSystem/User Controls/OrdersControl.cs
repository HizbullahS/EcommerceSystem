using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace EcommerceSystem
{
    public partial class OrdersControl : UserControl
    {
        public OrdersControl()
        {
            InitializeComponent();
            InsertingDataInGrid();
        }

        public void InsertingDataInGrid()
        {

            // Inserting "Orders" table into the DataGridView
            try
            {
                string connectionString = @"Data Source=HIZ-PC\SQLEXPRESS; Initial Catalog=EcommerceSystem; Integrated Security=true;";
                SqlConnection conn = new SqlConnection(connectionString);
                conn.Open();

                // Replace column names with actual column names from your "Orders" table
                SqlCommand cmd = new SqlCommand("SELECT OrderId, ProductId, ProductName, Status, Quantity, TotalPrice FROM Orders", conn);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                dataGridViewOrders.DataSource = dt;

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void dataGridViewOrders_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewOrders.SelectedRows.Count != 0)
            {
                DataGridViewRow row = this.dataGridViewOrders.SelectedRows[0];
                textBoxorderId.Text = Convert.ToString(row.Cells["OrderId"].Value);
                textBoxproductId.Text = Convert.ToString(row.Cells["ProductId"].Value);
                textBoxproductStatus.Text = Convert.ToString(row.Cells["Status"].Value);
                textBoxproductName.Text = Convert.ToString(row.Cells["ProductName"].Value);
                textBoxproductQuantity.Text = Convert.ToString(row.Cells["Quantity"].Value);
                textBoxtotalPrice.Text = Convert.ToString(row.Cells["TotalPrice"].Value);
            }
        }
        private void btnUpdateOrder_Click(object sender, EventArgs e)
        {
            if (textBoxorderId.Text.Trim().Length >= 1 && textBoxproductStatus.Text.Trim().Length >= 1)
            {
                try
                {
                    string connectionString = @"Data Source=HIZ-PC\SQLEXPRESS; Initial Catalog=EcommerceSystem; Integrated Security=true;";
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();

                        // Replace the column names with actual column names from your "Orders" table
                        string query = $"UPDATE Orders SET Status = '{textBoxproductStatus.Text}' WHERE OrderId = {textBoxorderId.Text}";

                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.ExecuteNonQuery();
                        }

                        conn.Close();
                        InsertingDataInGrid(); // Refresh the DataGridView
                        ClearFields();
                        MessageBox.Show("Order has been updated successfully.", "Update Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Order ID and Status are required to update an order.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnDeleteOrder_Click(object sender, EventArgs e)
        {
            if (textBoxorderId.Text.Trim().Length >= 1)
            {
                try
                {
                    string connectionString = @"Data Source=HIZ-PC\SQLEXPRESS; Initial Catalog=EcommerceSystem; Integrated Security=true;";
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();

                        // Replace the column names with actual column names from your "Orders" table
                        string query = $"DELETE FROM Orders WHERE OrderId = {textBoxorderId.Text}";

                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.ExecuteNonQuery();
                        }

                        conn.Close();
                        InsertingDataInGrid(); // Refresh the DataGridView
                        ClearFields();
                        MessageBox.Show("Order has been deleted successfully.", "Delete Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Order ID is required to delete an order.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ClearFields()
        {
            // Clear form fields
            textBoxorderId.Clear();
            textBoxproductId.Clear();
            textBoxproductStatus.Clear();
            textBoxproductName.Clear();
            textBoxproductQuantity.Clear();
            textBoxtotalPrice.Clear();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}

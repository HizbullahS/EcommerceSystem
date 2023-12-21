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
    public partial class CustomersControl : UserControl
    {
        public CustomersControl()
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
                SqlCommand cmd = new SqlCommand("SELECT * From Customers", conn);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                dataGridViewCustomers.DataSource = dt;

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void dataGridViewCustomers_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewCustomers.SelectedRows.Count != 0)
            {
                DataGridViewRow row = this.dataGridViewCustomers.SelectedRows[0];
                textBoxcustomerId.Text = Convert.ToString(row.Cells["CustomerID"].Value);
                textBoxcustomerFirstName.Text = Convert.ToString(row.Cells["FirstName"].Value);
                textBoxcustomerLastName.Text = Convert.ToString(row.Cells["LastName"].Value);
                textBoxcustomerEmail.Text = Convert.ToString(row.Cells["Email"].Value);
                textBoxcustomerPhone.Text = Convert.ToString(row.Cells["Phone"].Value);
                textBoxcustomerAddress.Text = Convert.ToString(row.Cells["Address"].Value);
                textBoxCity.Text = Convert.ToString(row.Cells["City"].Value);
                textBoxState.Text = Convert.ToString(row.Cells["State"].Value);
                textBoxPostalCode.Text = Convert.ToString(row.Cells["PostalCode"].Value);
            }
        }
        private void btnAddNewCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate that required fields are not empty
                if (string.IsNullOrWhiteSpace(textBoxcustomerFirstName.Text) ||
                    string.IsNullOrWhiteSpace(textBoxcustomerLastName.Text) ||
                    string.IsNullOrWhiteSpace(textBoxcustomerEmail.Text) ||
                    string.IsNullOrWhiteSpace(textBoxcustomerPhone.Text) ||
                    string.IsNullOrWhiteSpace(textBoxcustomerAddress.Text) ||
                    string.IsNullOrWhiteSpace(textBoxCity.Text) ||
                    string.IsNullOrWhiteSpace(textBoxState.Text) ||
                    string.IsNullOrWhiteSpace(textBoxPostalCode.Text))
                {
                    MessageBox.Show("All fields are required to add a new customer.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Insert the new customer into the database
                string connectionString = @"Data Source=HIZ-PC\SQLEXPRESS; Initial Catalog=EcommerceSystem; Integrated Security=true;";
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Replace the column names with actual column names from your "Customers" table
                    string query = $"INSERT INTO Customers (FirstName, LastName, Email, Phone, Address, City, State, PostalCode) " +
                                   $"VALUES ('{textBoxcustomerFirstName.Text}', '{textBoxcustomerLastName.Text}', " +
                                   $"'{textBoxcustomerEmail.Text}', '{textBoxcustomerPhone.Text}', " +
                                   $"'{textBoxcustomerAddress.Text}', '{textBoxCity.Text}', '{textBoxState.Text}', '{textBoxPostalCode.Text}')";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.ExecuteNonQuery();
                    }

                    conn.Close();
                    InsertingDataInGrid(); // Refresh the DataGridView
                    ClearFields();
                    MessageBox.Show("New customer has been added successfully.", "Add Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnUpdateCustomer_Click_1(object sender, EventArgs e)
        {
            if (textBoxcustomerId.Text.Trim().Length >= 1)
            {
                try
                {
                    string connectionString = @"Data Source=HIZ-PC\SQLEXPRESS; Initial Catalog=EcommerceSystem; Integrated Security=true;";
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();

                        // Replace the column names with actual column names from your "Customers" table
                        string query = $"UPDATE Customers SET " +
                                       $"FirstName = '{textBoxcustomerFirstName.Text}', " +
                                       $"LastName = '{textBoxcustomerLastName.Text}', " +
                                       $"Email = '{textBoxcustomerEmail.Text}', " +
                                       $"Phone = '{textBoxcustomerPhone.Text}', " +
                                       $"Address = '{textBoxcustomerAddress.Text}', " +
                                       $"City = '{textBoxCity.Text}', " +
                                       $"State = '{textBoxState.Text}', " +
                                       $"PostalCode = '{textBoxPostalCode.Text}' " +
                                       $"WHERE CustomerId = {textBoxcustomerId.Text}";

                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.ExecuteNonQuery();
                        }

                        conn.Close();
                        InsertingDataInGrid(); // Refresh the DataGridView
                        ClearFields();
                        MessageBox.Show("Customer has been updated successfully.", "Update Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Customer ID is required to update a customer.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnDeleteCustomer_Click_1(object sender, EventArgs e)
        {
            if (textBoxcustomerId.Text.Trim().Length >= 1)
            {
                try
                {
                    string connectionString = @"Data Source=HIZ-PC\SQLEXPRESS; Initial Catalog=EcommerceSystem; Integrated Security=true;";
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();

                        // Replace the column names with actual column names from your "Customers" table
                        string query = $"DELETE FROM Customers WHERE CustomerId = {textBoxcustomerId.Text}";

                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.ExecuteNonQuery();
                        }

                        conn.Close();
                        InsertingDataInGrid(); // Refresh the DataGridView
                        ClearFields();
                        MessageBox.Show("Customer has been deleted successfully.", "Delete Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Customer ID is required to delete a customer.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ClearFields()
        {
            // Clear form fields
            textBoxcustomerId.Clear();
            textBoxcustomerFirstName.Clear();
            textBoxcustomerLastName.Clear();
            textBoxcustomerEmail.Clear();
            textBoxcustomerPhone.Clear();
            textBoxcustomerAddress.Clear();
            textBoxCity.Clear();
            textBoxState.Clear();
            textBoxPostalCode.Clear();
        }
        private void dataGridViewCustomers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

    }
}

using EcommerceSystem.Forms;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace EcommerceSystem
{
    public partial class ProductsForm : Form
    {
        public ProductsForm()
        {
            InitializeComponent();
        }
        private void ProductsForm_Load(object sender, EventArgs e)
        {
            reset();
        }
        public void reset()
        {
            textBoxproductId.Clear();
            textBoxproductName.Clear();
            textBoxproductDescription.Clear();
            textBoxproductManufacturer.Clear();
            textBoxproductCategory.Clear();
            textBoxproductPrice.Clear();
            textBoxproductQuantity.Clear();

            //Inserting table into the Gridview
            try
            {
                string connectionString = @"Data Source=HIZ-PC\SQLEXPRESS; Initial Catalog=EcommerceSystem; Integrated Security=true;";
                SqlConnection conn = new SqlConnection(connectionString);
                conn.Open();
                SqlCommand cmd = new SqlCommand("select * from Products", conn);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            if (textBoxproductName.Text.Trim().Length >= 1 && textBoxproductDescription.Text.Trim().Length >= 1 && textBoxproductPrice.Text.Trim().Length >= 1
                && textBoxproductCategory.Text.Trim().Length >= 1 && textBoxproductManufacturer.Text.Trim().Length >= 1 && textBoxproductQuantity.Text.Trim().Length >= 1)
            {

                // 1. Address the SQL Server and Database
                string connectionString = @"Data Source=HIZ-PC\SQLEXPRESS; Initial Catalog=EcommerceSystem; Integrated Security=true;";


                // 2. Establish Connection
                SqlConnection conn = new SqlConnection(connectionString);

                // 3. Open Connection
                conn.Open();

                // Prepare Query
                string Query = $"insert into Products values ('{textBoxproductName.Text}', '{textBoxproductDescription.Text}', '{textBoxproductManufacturer.Text}','{textBoxproductCategory.Text}', {textBoxproductPrice.Text},{textBoxproductQuantity.Text})";

                // 5. Execute Query
                try
                {
                    SqlCommand cmd = new SqlCommand(Query, conn);
                    cmd.ExecuteNonQuery();

                    // 6. Close Connection
                    conn.Close();
                    reset();
                    MessageBox.Show("Data has been Saved Successfuly", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception)
                {
                    MessageBox.Show("Record Already Saved", "Invalid Input", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("All Fields Are Required to be Filled", "Invalid Input", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                textBoxproductName.Focus();
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (textBoxproductName.Text.Trim().Length >= 1 && textBoxproductDescription.Text.Trim().Length >= 1 && textBoxproductManufacturer.Text.Trim().Length >= 1 && textBoxproductCategory.Text.Trim().Length >= 1
                && textBoxproductPrice.Text.Trim().Length >= 1 && textBoxproductQuantity.Text.Trim().Length >= 1)
            {

                // 1. Address the SQL Server and Database
                string connectionString = @"Data Source=HIZ-PC\SQLEXPRESS; Initial Catalog=EcommerceSystem; Integrated Security=true;";

                // 2. Establish Connection
                SqlConnection conn = new SqlConnection(connectionString);

                // 3. Open Connection
                conn.Open();

                // Prepare Query
                string Query = $"UPDATE Products SET  ProductName = '{textBoxproductName.Text}', Description = '{textBoxproductDescription.Text}', Manufacturer ='{textBoxproductManufacturer.Text}', Category ='{textBoxproductCategory.Text}', Price = {textBoxproductPrice.Text}, Quantity = {textBoxproductQuantity.Text} where ProductId = {textBoxproductId.Text}";

                // 5. Execute Query
                try
                {
                    SqlCommand cmd = new SqlCommand(Query, conn);
                    cmd.ExecuteNonQuery();

                    // Close Connection
                    conn.Close();
                    reset();
                    MessageBox.Show("Data has been Updated Successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception)
                {
                    MessageBox.Show("Record Already Saved", "Invalid Input", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("All Fields Are Required to be Filled", "Invalid Input", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                textBoxproductName.Focus();
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (textBoxproductName.Text.Trim().Length >= 1 && textBoxproductDescription.Text.Trim().Length >= 1 && textBoxproductManufacturer.Text.Trim().Length >= 1 && textBoxproductCategory.Text.Trim().Length >= 1
                && textBoxproductPrice.Text.Trim().Length >= 1 && textBoxproductQuantity.Text.Trim().Length >= 1)
            {

                // 1. Address the SQL Server and Database
                string connectionString = @"Data Source=HIZ-PC\SQLEXPRESS; Initial Catalog=EcommerceSystem; Integrated Security=true;";

                // 2. Establish Connection
                SqlConnection conn = new SqlConnection(connectionString);

                // 3. Open Connection
                conn.Open();

                // Prepare Query
                string Query = $"DELETE FROM Products where ProductId = {textBoxproductId.Text}"
                    ;

                // 5. Execute Query
                try
                {
                    SqlCommand cmd = new SqlCommand(Query, conn);
                    cmd.ExecuteNonQuery();

                    // 6. Close Connection
                    conn.Close();
                    reset();
                    MessageBox.Show("Data has been Deleted Successfuly", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                    //MessageBox.Show("No Record Found", "Invalid Input", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("---", "Invalid Input", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                textBoxproductName.Focus();
            }
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            reset();
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 0)
            {
                DataGridViewRow row = this.dataGridView1.SelectedRows[0];
                textBoxproductId.Text = Convert.ToString(row.Cells["ProductId"].Value);
                textBoxproductName.Text = Convert.ToString(row.Cells["ProductName"].Value);
                textBoxproductDescription.Text = Convert.ToString(row.Cells["Description"].Value);
                textBoxproductManufacturer.Text = Convert.ToString(row.Cells["Manufacturer"].Value);
                textBoxproductCategory.Text = Convert.ToString(row.Cells["Category"].Value);
                textBoxproductPrice.Text = Convert.ToString(row.Cells["Price"].Value);
                textBoxproductQuantity.Text = Convert.ToString(row.Cells["Quantity"].Value);
            }

            //if (dataGridView1.SelectedRows.Count != 0)
            //{
            //    DataGridViewRow row = this.dataGridView1.SelectedRows[0];

            //    int productId = Convert.ToInt32(row.Cells["ProductId"].Value);
            //    string productName = Convert.ToString(row.Cells["ProductName"].Value);
            //    int productPrice = Convert.ToInt32(row.Cells["Price"].Value);

            //    // Pass product details to OrderForm
            //    OrderForm orderForm = new OrderForm(productId, productName, productPrice);
            //    orderForm.ShowDialog();

            //    // Optionally, refresh the DataGridView after placing the order
            //    reset();
            //}
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            // Check if a row is selected
            if (dataGridView1.SelectedRows.Count != 0)
            {
                DataGridViewRow row = dataGridView1.SelectedRows[0];

                int productId = Convert.ToInt32(row.Cells["ProductId"].Value);
                string productName = Convert.ToString(row.Cells["ProductName"].Value);
                decimal productPrice = Convert.ToDecimal(row.Cells["Price"].Value);

                // Pass product details to OrderForm
                OrderForm orderForm = new OrderForm(productId, productName, productPrice);
                orderForm.ShowDialog();

                // Optionally, refresh the DataGridView after placing the order
                reset();
            }
            else
            {
                MessageBox.Show("Please select a product to place an order.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    }
}

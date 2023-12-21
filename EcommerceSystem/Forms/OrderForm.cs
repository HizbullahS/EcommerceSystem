using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace EcommerceSystem.Forms
{
    public partial class OrderForm : Form
    {
        private int _productId;
        private string _productName;
        private decimal _productPrice;

        private void textBoxproductQuantity_TextChanged(object sender, EventArgs e)
        {
            // Handle the TextChanged event of the quantity textbox
            UpdateTotalPrice();
        }

        private void UpdateTotalPrice()
        {
            // Calculate the total price based on the entered quantity
            if (int.TryParse(textBoxproductQuantity.Text, out int quantity))
            {
                decimal totalPrice = quantity * _productPrice;
                textBoxtotalPrice.Text = totalPrice.ToString("C");
            }
            else
            {
                // Handle the case where the entered quantity is not a valid integer
                textBoxtotalPrice.Text = "Invalid Quantity";
            }
        }

        public OrderForm(int productId, string productName, decimal productPrice)
        {
            InitializeComponent();

            _productId = productId;
            _productName = productName;
            _productPrice = productPrice;

            // Populate the controls with product details
            textBoxproductId.Text = _productId.ToString();
            textBoxproductName.Text = _productName;
            textBoxtotalPrice.Text = _productPrice.ToString("C"); // Format as currency, adjust as needed

            // Set initial quantity to zero
            textBoxproductQuantity.Text = "0";

            // Wire up the TextChanged event for the quantity textbox
            textBoxproductQuantity.TextChanged += textBoxproductQuantity_TextChanged;

            // Initialize total price based on default quantity (optional)
            UpdateTotalPrice();

        }

        public OrderForm()
        {
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            // You can add any additional setup logic for your OrderForm if needed.
        }

        // Add code for placing the order when the user clicks the order button
        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            // Retrieve order details from the controls
            int quantity = Convert.ToInt32(textBoxproductQuantity.Text);
            decimal totalPrice = quantity * _productPrice;

            // Save the order to the database
            SaveOrderToDatabase(_productId, _productName, quantity, totalPrice);

            // Display a confirmation message or perform any additional actions as needed.
            MessageBox.Show("Order placed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Close the OrderForm
            this.Close();
        }

        private void btnbuyProduct_Click(object sender, EventArgs e)
        {
            // Retrieve order details from the controls
            if (int.TryParse(textBoxproductQuantity.Text, out int quantity))
            {
                decimal totalPrice = quantity * _productPrice;

                // Save the order to the database
                SaveOrderToDatabase(_productId, _productName, quantity, totalPrice);

                // Display a confirmation message or perform any additional actions as needed.
                MessageBox.Show("Your order has been placed successfully!", "Order Placed", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Close the OrderForm
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid quantity entered.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SaveOrderToDatabase(int productId, string productName, int quantity, decimal totalPrice)
        {
            try
            {
                string connectionString = @"Data Source=HIZ-PC\SQLEXPRESS; Initial Catalog=EcommerceSystem; Integrated Security=true;";
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Begin a transaction to ensure both INSERT and UPDATE are atomic
                    using (SqlTransaction transaction = conn.BeginTransaction())
                    {
                        try
                        {
                            // Prepare the INSERT query for the Orders table
                            string insertOrderQuery = "INSERT INTO Orders (ProductId, ProductName, Quantity, TotalPrice) VALUES (@ProductId, @ProductName, @Quantity, @TotalPrice)";
                            using (SqlCommand cmdInsertOrder = new SqlCommand(insertOrderQuery, conn, transaction))
                            {
                                // Add parameters to the INSERT query
                                cmdInsertOrder.Parameters.AddWithValue("@ProductId", productId);
                                cmdInsertOrder.Parameters.AddWithValue("@ProductName", productName);
                                cmdInsertOrder.Parameters.AddWithValue("@Quantity", quantity);
                                cmdInsertOrder.Parameters.AddWithValue("@TotalPrice", totalPrice);

                                // Execute the INSERT query
                                cmdInsertOrder.ExecuteNonQuery();
                            }

                            // Prepare the UPDATE query for the Products table
                            string updateProductQuery = "UPDATE Products SET Quantity = Quantity - @Quantity WHERE ProductId = @ProductId";
                            using (SqlCommand cmdUpdateProduct = new SqlCommand(updateProductQuery, conn, transaction))
                            {
                                // Add parameters to the UPDATE query
                                cmdUpdateProduct.Parameters.AddWithValue("@ProductId", productId);
                                cmdUpdateProduct.Parameters.AddWithValue("@Quantity", quantity);

                                // Execute the UPDATE query
                                cmdUpdateProduct.ExecuteNonQuery();
                            }

                            // Commit the transaction if both INSERT and UPDATE succeed
                            transaction.Commit();
                        }
                        catch (Exception ex)
                        {
                            // Rollback the transaction in case of any exception
                            transaction.Rollback();
                            throw new Exception("Error saving order and updating product quantity: " + ex.Message);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving order to the database: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}

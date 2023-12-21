using EcommerceSystem.User_Controls;
using System;
using System.Windows.Forms;

namespace EcommerceSystem.Forms
{
    public partial class MainForm : Form
    {
        private ProductsControl productsControl;
        private OrdersControl ordersControl;
        private CustomersControl customersControl;
        private PaymentControl paymentControl;
        private TotalSalesControl totalSalesControl;
        private ShippingControl shippingControl;

        private Control currentControl; // Reference to the current user control being displayed

        private void MainForm_Load_1(object sender, EventArgs e)
        {
            // Create instances of your user controls
            productsControl = new ProductsControl();
            ordersControl = new OrdersControl();
            customersControl = new CustomersControl();
            paymentControl = new PaymentControl();
            totalSalesControl = new TotalSalesControl();
            shippingControl = new ShippingControl();

            // Add controls to the main form
            Controls.Add(productsControl);
            Controls.Add(ordersControl);
            Controls.Add(customersControl);
            Controls.Add(paymentControl);
            Controls.Add(totalSalesControl);
            Controls.Add(shippingControl);

            // Set initial visibility
            productsControl.Visible = true;
            ordersControl.Visible = false;
            customersControl.Visible = false;
            paymentControl.Visible = false;
            totalSalesControl.Visible = false;
            shippingControl.Visible = false;
        }
        public MainForm()
        {
            InitializeComponent();
            Load += MainForm_Load_1; // Ensure this line is present

            // Manually wire up event handlers
            btnAllProducts.Click += btnAllProducts_Click;
            btnOrders.Click += btnOrders_Click;
            btnCustomers.Click += btnCustomers_Click;
            btnPayment.Click += btnPayment_Click;
            btnSales.Click += btnSales_Click;
            btnShipping.Click += btnShipping_Click;
        }

        // Implement button click handlers as mentioned in previous responses
        private void btnAllProducts_Click(object sender, EventArgs e)
        {
            ShowControl(new ProductsControl());
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            ShowControl(new OrdersControl());
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            ShowControl(new CustomersControl());
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            ShowControl(new PaymentControl());
        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            ShowControl(new TotalSalesControl());
        }

        private void btnShipping_Click(object sender, EventArgs e)
        {
            ShowControl(new ShippingControl());
        }

        private void panelMain_Paint(object sender, PaintEventArgs e)
        {

        }

        // Helper method to show a specific user control and hide others
        private void ShowControl(Control controlToShow)
        {
            // Dispose of the current user control if it exists
            if (currentControl != null)
            {
                currentControl.Dispose();
            }

            // Add the new user control to the panel
            panelMain.Controls.Add(controlToShow);

            // Set its Dock property to Fill if you want it to fill the panel
            controlToShow.Dock = DockStyle.Fill;

            // Set the current control reference
            currentControl = controlToShow;
        }

    }
}



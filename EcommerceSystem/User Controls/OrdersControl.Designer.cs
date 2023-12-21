namespace EcommerceSystem
{
    partial class OrdersControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridViewOrders = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnUpdateOrder = new System.Windows.Forms.Button();
            this.btnDeleteOrder = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.AddProducts = new System.Windows.Forms.GroupBox();
            this.textBoxproductStatus = new System.Windows.Forms.TextBox();
            this.productStatus = new System.Windows.Forms.Label();
            this.textBoxorderId = new System.Windows.Forms.TextBox();
            this.orderId = new System.Windows.Forms.Label();
            this.textBoxproductQuantity = new System.Windows.Forms.TextBox();
            this.textBoxtotalPrice = new System.Windows.Forms.TextBox();
            this.productQuantity = new System.Windows.Forms.Label();
            this.totalPrice = new System.Windows.Forms.Label();
            this.textBoxproductId = new System.Windows.Forms.TextBox();
            this.productId = new System.Windows.Forms.Label();
            this.textBoxproductName = new System.Windows.Forms.TextBox();
            this.productName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.AddProducts.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewOrders
            // 
            this.dataGridViewOrders.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dataGridViewOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrders.Location = new System.Drawing.Point(30, 99);
            this.dataGridViewOrders.Name = "dataGridViewOrders";
            this.dataGridViewOrders.RowHeadersWidth = 51;
            this.dataGridViewOrders.RowTemplate.Height = 24;
            this.dataGridViewOrders.Size = new System.Drawing.Size(902, 580);
            this.dataGridViewOrders.TabIndex = 22;
            this.dataGridViewOrders.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewOrders_CellClick);
            this.dataGridViewOrders.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Navy;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(30, 20);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(902, 73);
            this.panel2.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(313, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(236, 38);
            this.label2.TabIndex = 0;
            this.label2.Text = "Current Orders";
            // 
            // btnUpdateOrder
            // 
            this.btnUpdateOrder.BackColor = System.Drawing.Color.Goldenrod;
            this.btnUpdateOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateOrder.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUpdateOrder.Location = new System.Drawing.Point(1107, 613);
            this.btnUpdateOrder.Name = "btnUpdateOrder";
            this.btnUpdateOrder.Size = new System.Drawing.Size(141, 66);
            this.btnUpdateOrder.TabIndex = 23;
            this.btnUpdateOrder.Text = "Update Order";
            this.btnUpdateOrder.UseVisualStyleBackColor = false;
            this.btnUpdateOrder.Click += new System.EventHandler(this.btnUpdateOrder_Click);
            // 
            // btnDeleteOrder
            // 
            this.btnDeleteOrder.BackColor = System.Drawing.Color.Red;
            this.btnDeleteOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteOrder.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDeleteOrder.Location = new System.Drawing.Point(948, 613);
            this.btnDeleteOrder.Name = "btnDeleteOrder";
            this.btnDeleteOrder.Size = new System.Drawing.Size(143, 66);
            this.btnDeleteOrder.TabIndex = 24;
            this.btnDeleteOrder.Text = "Delete Order";
            this.btnDeleteOrder.UseVisualStyleBackColor = false;
            this.btnDeleteOrder.Click += new System.EventHandler(this.btnDeleteOrder_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(948, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(454, 73);
            this.panel1.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(134, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Modify Order";
            // 
            // AddProducts
            // 
            this.AddProducts.Controls.Add(this.textBoxproductStatus);
            this.AddProducts.Controls.Add(this.productStatus);
            this.AddProducts.Controls.Add(this.textBoxorderId);
            this.AddProducts.Controls.Add(this.orderId);
            this.AddProducts.Controls.Add(this.textBoxproductQuantity);
            this.AddProducts.Controls.Add(this.textBoxtotalPrice);
            this.AddProducts.Controls.Add(this.productQuantity);
            this.AddProducts.Controls.Add(this.totalPrice);
            this.AddProducts.Controls.Add(this.textBoxproductId);
            this.AddProducts.Controls.Add(this.productId);
            this.AddProducts.Controls.Add(this.textBoxproductName);
            this.AddProducts.Controls.Add(this.productName);
            this.AddProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddProducts.Location = new System.Drawing.Point(948, 99);
            this.AddProducts.Name = "AddProducts";
            this.AddProducts.Size = new System.Drawing.Size(454, 499);
            this.AddProducts.TabIndex = 27;
            this.AddProducts.TabStop = false;
            // 
            // textBoxproductStatus
            // 
            this.textBoxproductStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxproductStatus.Location = new System.Drawing.Point(226, 183);
            this.textBoxproductStatus.Name = "textBoxproductStatus";
            this.textBoxproductStatus.Size = new System.Drawing.Size(209, 34);
            this.textBoxproductStatus.TabIndex = 105;
            // 
            // productStatus
            // 
            this.productStatus.AutoSize = true;
            this.productStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productStatus.Location = new System.Drawing.Point(29, 188);
            this.productStatus.Name = "productStatus";
            this.productStatus.Size = new System.Drawing.Size(168, 29);
            this.productStatus.TabIndex = 104;
            this.productStatus.Text = "Product Status";
            // 
            // textBoxorderId
            // 
            this.textBoxorderId.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxorderId.Location = new System.Drawing.Point(226, 33);
            this.textBoxorderId.Name = "textBoxorderId";
            this.textBoxorderId.Size = new System.Drawing.Size(114, 34);
            this.textBoxorderId.TabIndex = 103;
            this.textBoxorderId.WordWrap = false;
            // 
            // orderId
            // 
            this.orderId.AutoSize = true;
            this.orderId.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderId.Location = new System.Drawing.Point(29, 38);
            this.orderId.Name = "orderId";
            this.orderId.Size = new System.Drawing.Size(102, 29);
            this.orderId.TabIndex = 102;
            this.orderId.Text = "Order Id";
            // 
            // textBoxproductQuantity
            // 
            this.textBoxproductQuantity.Enabled = false;
            this.textBoxproductQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxproductQuantity.Location = new System.Drawing.Point(226, 333);
            this.textBoxproductQuantity.Name = "textBoxproductQuantity";
            this.textBoxproductQuantity.Size = new System.Drawing.Size(209, 34);
            this.textBoxproductQuantity.TabIndex = 6;
            // 
            // textBoxtotalPrice
            // 
            this.textBoxtotalPrice.Enabled = false;
            this.textBoxtotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxtotalPrice.Location = new System.Drawing.Point(226, 408);
            this.textBoxtotalPrice.Name = "textBoxtotalPrice";
            this.textBoxtotalPrice.Size = new System.Drawing.Size(209, 34);
            this.textBoxtotalPrice.TabIndex = 5;
            // 
            // productQuantity
            // 
            this.productQuantity.AutoSize = true;
            this.productQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productQuantity.Location = new System.Drawing.Point(29, 338);
            this.productQuantity.Name = "productQuantity";
            this.productQuantity.Size = new System.Drawing.Size(189, 29);
            this.productQuantity.TabIndex = 12;
            this.productQuantity.Text = "Product Quantity";
            // 
            // totalPrice
            // 
            this.totalPrice.AutoSize = true;
            this.totalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalPrice.Location = new System.Drawing.Point(29, 413);
            this.totalPrice.Name = "totalPrice";
            this.totalPrice.Size = new System.Drawing.Size(158, 29);
            this.totalPrice.TabIndex = 10;
            this.totalPrice.Text = "Product Price";
            // 
            // textBoxproductId
            // 
            this.textBoxproductId.Enabled = false;
            this.textBoxproductId.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxproductId.Location = new System.Drawing.Point(226, 108);
            this.textBoxproductId.Name = "textBoxproductId";
            this.textBoxproductId.Size = new System.Drawing.Size(114, 34);
            this.textBoxproductId.TabIndex = 101;
            this.textBoxproductId.WordWrap = false;
            // 
            // productId
            // 
            this.productId.AutoSize = true;
            this.productId.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productId.Location = new System.Drawing.Point(29, 113);
            this.productId.Name = "productId";
            this.productId.Size = new System.Drawing.Size(122, 29);
            this.productId.TabIndex = 2;
            this.productId.Text = "Product Id";
            // 
            // textBoxproductName
            // 
            this.textBoxproductName.Enabled = false;
            this.textBoxproductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxproductName.Location = new System.Drawing.Point(226, 258);
            this.textBoxproductName.Name = "textBoxproductName";
            this.textBoxproductName.Size = new System.Drawing.Size(209, 34);
            this.textBoxproductName.TabIndex = 1;
            // 
            // productName
            // 
            this.productName.AutoSize = true;
            this.productName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productName.Location = new System.Drawing.Point(29, 263);
            this.productName.Name = "productName";
            this.productName.Size = new System.Drawing.Size(167, 29);
            this.productName.TabIndex = 0;
            this.productName.Text = "Product Name";
            // 
            // OrdersControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.AddProducts);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnUpdateOrder);
            this.Controls.Add(this.btnDeleteOrder);
            this.Controls.Add(this.dataGridViewOrders);
            this.Controls.Add(this.panel2);
            this.Name = "OrdersControl";
            this.Size = new System.Drawing.Size(1417, 702);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.AddProducts.ResumeLayout(false);
            this.AddProducts.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewOrders;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Button btnUpdateOrder;
        public System.Windows.Forms.Button btnDeleteOrder;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.GroupBox AddProducts;
        public System.Windows.Forms.TextBox textBoxproductStatus;
        public System.Windows.Forms.Label productStatus;
        public System.Windows.Forms.TextBox textBoxorderId;
        public System.Windows.Forms.Label orderId;
        private System.Windows.Forms.TextBox textBoxproductQuantity;
        private System.Windows.Forms.TextBox textBoxtotalPrice;
        public System.Windows.Forms.Label productQuantity;
        public System.Windows.Forms.Label totalPrice;
        public System.Windows.Forms.TextBox textBoxproductId;
        public System.Windows.Forms.Label productId;
        public System.Windows.Forms.TextBox textBoxproductName;
        public System.Windows.Forms.Label productName;
    }
}

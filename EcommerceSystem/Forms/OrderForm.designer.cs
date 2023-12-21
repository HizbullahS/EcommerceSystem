namespace EcommerceSystem.Forms
{
    partial class OrderForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.AddProducts = new System.Windows.Forms.GroupBox();
            this.btnbuyProduct = new System.Windows.Forms.Button();
            this.textBoxproductQuantity = new System.Windows.Forms.TextBox();
            this.textBoxtotalPrice = new System.Windows.Forms.TextBox();
            this.productQuantity = new System.Windows.Forms.Label();
            this.totalPrice = new System.Windows.Forms.Label();
            this.textBoxproductId = new System.Windows.Forms.TextBox();
            this.productId = new System.Windows.Forms.Label();
            this.textBoxproductName = new System.Windows.Forms.TextBox();
            this.productName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.orderId = new System.Windows.Forms.Label();
            this.textBoxorderId = new System.Windows.Forms.TextBox();
            this.AddProducts.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddProducts
            // 
            this.AddProducts.Controls.Add(this.btnbuyProduct);
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
            this.AddProducts.Location = new System.Drawing.Point(40, 100);
            this.AddProducts.Name = "AddProducts";
            this.AddProducts.Size = new System.Drawing.Size(454, 435);
            this.AddProducts.TabIndex = 2;
            this.AddProducts.TabStop = false;
            // 
            // btnbuyProduct
            // 
            this.btnbuyProduct.BackColor = System.Drawing.Color.Green;
            this.btnbuyProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbuyProduct.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnbuyProduct.Location = new System.Drawing.Point(296, 353);
            this.btnbuyProduct.Name = "btnbuyProduct";
            this.btnbuyProduct.Size = new System.Drawing.Size(131, 49);
            this.btnbuyProduct.TabIndex = 104;
            this.btnbuyProduct.Text = "Buy Product";
            this.btnbuyProduct.UseVisualStyleBackColor = false;
            this.btnbuyProduct.Click += new System.EventHandler(this.btnbuyProduct_Click);
            // 
            // textBoxproductQuantity
            // 
            this.textBoxproductQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxproductQuantity.Location = new System.Drawing.Point(218, 231);
            this.textBoxproductQuantity.Name = "textBoxproductQuantity";
            this.textBoxproductQuantity.Size = new System.Drawing.Size(209, 27);
            this.textBoxproductQuantity.TabIndex = 6;
            // 
            // textBoxtotalPrice
            // 
            this.textBoxtotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxtotalPrice.Location = new System.Drawing.Point(218, 294);
            this.textBoxtotalPrice.Name = "textBoxtotalPrice";
            this.textBoxtotalPrice.Size = new System.Drawing.Size(209, 27);
            this.textBoxtotalPrice.TabIndex = 5;
            // 
            // productQuantity
            // 
            this.productQuantity.AutoSize = true;
            this.productQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productQuantity.Location = new System.Drawing.Point(21, 234);
            this.productQuantity.Name = "productQuantity";
            this.productQuantity.Size = new System.Drawing.Size(134, 20);
            this.productQuantity.TabIndex = 12;
            this.productQuantity.Text = "Product Quantity";
            // 
            // totalPrice
            // 
            this.totalPrice.AutoSize = true;
            this.totalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalPrice.Location = new System.Drawing.Point(21, 294);
            this.totalPrice.Name = "totalPrice";
            this.totalPrice.Size = new System.Drawing.Size(111, 20);
            this.totalPrice.TabIndex = 10;
            this.totalPrice.Text = "Product Price";
            // 
            // textBoxproductId
            // 
            this.textBoxproductId.Enabled = false;
            this.textBoxproductId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxproductId.Location = new System.Drawing.Point(218, 120);
            this.textBoxproductId.Name = "textBoxproductId";
            this.textBoxproductId.Size = new System.Drawing.Size(114, 27);
            this.textBoxproductId.TabIndex = 101;
            this.textBoxproductId.WordWrap = false;
            // 
            // productId
            // 
            this.productId.AutoSize = true;
            this.productId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productId.Location = new System.Drawing.Point(21, 127);
            this.productId.Name = "productId";
            this.productId.Size = new System.Drawing.Size(85, 20);
            this.productId.TabIndex = 2;
            this.productId.Text = "Product Id";
            // 
            // textBoxproductName
            // 
            this.textBoxproductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxproductName.Location = new System.Drawing.Point(218, 174);
            this.textBoxproductName.Name = "textBoxproductName";
            this.textBoxproductName.Size = new System.Drawing.Size(209, 27);
            this.textBoxproductName.TabIndex = 1;
            // 
            // productName
            // 
            this.productName.AutoSize = true;
            this.productName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productName.Location = new System.Drawing.Point(21, 181);
            this.productName.Name = "productName";
            this.productName.Size = new System.Drawing.Size(116, 20);
            this.productName.TabIndex = 0;
            this.productName.Text = "Product Name";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(40, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(454, 73);
            this.panel1.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(89, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Place Your Order";
            // 
            // orderId
            // 
            this.orderId.AutoSize = true;
            this.orderId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderId.Location = new System.Drawing.Point(21, 75);
            this.orderId.Name = "orderId";
            this.orderId.Size = new System.Drawing.Size(70, 20);
            this.orderId.TabIndex = 102;
            this.orderId.Text = "Order Id";
            // 
            // textBoxorderId
            // 
            this.textBoxorderId.Enabled = false;
            this.textBoxorderId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxorderId.Location = new System.Drawing.Point(218, 68);
            this.textBoxorderId.Name = "textBoxorderId";
            this.textBoxorderId.Size = new System.Drawing.Size(114, 27);
            this.textBoxorderId.TabIndex = 103;
            this.textBoxorderId.WordWrap = false;
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 563);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.AddProducts);
            this.Name = "OrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OrderForm";
            this.Load += new System.EventHandler(this.OrderForm_Load);
            this.AddProducts.ResumeLayout(false);
            this.AddProducts.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.GroupBox AddProducts;
        public System.Windows.Forms.TextBox textBoxproductId;
        public System.Windows.Forms.Label productId;
        public System.Windows.Forms.TextBox textBoxproductName;
        public System.Windows.Forms.Label productName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxproductQuantity;
        private System.Windows.Forms.TextBox textBoxtotalPrice;
        public System.Windows.Forms.Label productQuantity;
        public System.Windows.Forms.Label totalPrice;
        public System.Windows.Forms.Button btnbuyProduct;
        public System.Windows.Forms.TextBox textBoxorderId;
        public System.Windows.Forms.Label orderId;
    }
}
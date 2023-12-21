
namespace EcommerceSystem
{
    partial class ProductsForm
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
            this.textBoxproductQuantity = new System.Windows.Forms.TextBox();
            this.textBoxproductPrice = new System.Windows.Forms.TextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.productQuantity = new System.Windows.Forms.Label();
            this.productPrice = new System.Windows.Forms.Label();
            this.textBoxproductCategory = new System.Windows.Forms.TextBox();
            this.productCategory = new System.Windows.Forms.Label();
            this.textBoxproductManufacturer = new System.Windows.Forms.TextBox();
            this.productManufacturer = new System.Windows.Forms.Label();
            this.textBoxproductDescription = new System.Windows.Forms.TextBox();
            this.productDescription = new System.Windows.Forms.Label();
            this.textBoxproductId = new System.Windows.Forms.TextBox();
            this.productId = new System.Windows.Forms.Label();
            this.textBoxproductName = new System.Windows.Forms.TextBox();
            this.productName = new System.Windows.Forms.Label();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnPlaceOrder = new System.Windows.Forms.Button();
            this.AddProducts.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // AddProducts
            // 
            this.AddProducts.Controls.Add(this.textBoxproductQuantity);
            this.AddProducts.Controls.Add(this.textBoxproductPrice);
            this.AddProducts.Controls.Add(this.btnReset);
            this.AddProducts.Controls.Add(this.productQuantity);
            this.AddProducts.Controls.Add(this.productPrice);
            this.AddProducts.Controls.Add(this.textBoxproductCategory);
            this.AddProducts.Controls.Add(this.productCategory);
            this.AddProducts.Controls.Add(this.textBoxproductManufacturer);
            this.AddProducts.Controls.Add(this.productManufacturer);
            this.AddProducts.Controls.Add(this.textBoxproductDescription);
            this.AddProducts.Controls.Add(this.productDescription);
            this.AddProducts.Controls.Add(this.textBoxproductId);
            this.AddProducts.Controls.Add(this.productId);
            this.AddProducts.Controls.Add(this.textBoxproductName);
            this.AddProducts.Controls.Add(this.productName);
            this.AddProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddProducts.Location = new System.Drawing.Point(31, 79);
            this.AddProducts.Name = "AddProducts";
            this.AddProducts.Size = new System.Drawing.Size(454, 480);
            this.AddProducts.TabIndex = 1;
            this.AddProducts.TabStop = false;
            // 
            // textBoxproductQuantity
            // 
            this.textBoxproductQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxproductQuantity.Location = new System.Drawing.Point(218, 415);
            this.textBoxproductQuantity.Name = "textBoxproductQuantity";
            this.textBoxproductQuantity.Size = new System.Drawing.Size(209, 27);
            this.textBoxproductQuantity.TabIndex = 6;
            // 
            // textBoxproductPrice
            // 
            this.textBoxproductPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxproductPrice.Location = new System.Drawing.Point(218, 355);
            this.textBoxproductPrice.Name = "textBoxproductPrice";
            this.textBoxproductPrice.Size = new System.Drawing.Size(209, 27);
            this.textBoxproductPrice.TabIndex = 5;
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Blue;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnReset.Location = new System.Drawing.Point(351, 62);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(76, 27);
            this.btnReset.TabIndex = 10;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // productQuantity
            // 
            this.productQuantity.AutoSize = true;
            this.productQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productQuantity.Location = new System.Drawing.Point(21, 418);
            this.productQuantity.Name = "productQuantity";
            this.productQuantity.Size = new System.Drawing.Size(134, 20);
            this.productQuantity.TabIndex = 12;
            this.productQuantity.Text = "Product Quantity";
            // 
            // productPrice
            // 
            this.productPrice.AutoSize = true;
            this.productPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productPrice.Location = new System.Drawing.Point(21, 355);
            this.productPrice.Name = "productPrice";
            this.productPrice.Size = new System.Drawing.Size(111, 20);
            this.productPrice.TabIndex = 10;
            this.productPrice.Text = "Product Price";
            // 
            // textBoxproductCategory
            // 
            this.textBoxproductCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxproductCategory.Location = new System.Drawing.Point(218, 292);
            this.textBoxproductCategory.Name = "textBoxproductCategory";
            this.textBoxproductCategory.Size = new System.Drawing.Size(209, 27);
            this.textBoxproductCategory.TabIndex = 4;
            // 
            // productCategory
            // 
            this.productCategory.AutoSize = true;
            this.productCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productCategory.Location = new System.Drawing.Point(21, 295);
            this.productCategory.Name = "productCategory";
            this.productCategory.Size = new System.Drawing.Size(139, 20);
            this.productCategory.TabIndex = 8;
            this.productCategory.Text = "Product Category";
            // 
            // textBoxproductManufacturer
            // 
            this.textBoxproductManufacturer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxproductManufacturer.Location = new System.Drawing.Point(218, 234);
            this.textBoxproductManufacturer.Name = "textBoxproductManufacturer";
            this.textBoxproductManufacturer.Size = new System.Drawing.Size(209, 27);
            this.textBoxproductManufacturer.TabIndex = 3;
            // 
            // productManufacturer
            // 
            this.productManufacturer.AutoSize = true;
            this.productManufacturer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productManufacturer.Location = new System.Drawing.Point(21, 237);
            this.productManufacturer.Name = "productManufacturer";
            this.productManufacturer.Size = new System.Drawing.Size(171, 20);
            this.productManufacturer.TabIndex = 6;
            this.productManufacturer.Text = "Product Manufacturer";
            // 
            // textBoxproductDescription
            // 
            this.textBoxproductDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxproductDescription.Location = new System.Drawing.Point(218, 175);
            this.textBoxproductDescription.Name = "textBoxproductDescription";
            this.textBoxproductDescription.Size = new System.Drawing.Size(209, 27);
            this.textBoxproductDescription.TabIndex = 2;
            // 
            // productDescription
            // 
            this.productDescription.AutoSize = true;
            this.productDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productDescription.Location = new System.Drawing.Point(21, 178);
            this.productDescription.Name = "productDescription";
            this.productDescription.Size = new System.Drawing.Size(158, 20);
            this.productDescription.TabIndex = 4;
            this.productDescription.Text = "Product Description";
            // 
            // textBoxproductId
            // 
            this.textBoxproductId.Enabled = false;
            this.textBoxproductId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxproductId.Location = new System.Drawing.Point(218, 61);
            this.textBoxproductId.Name = "textBoxproductId";
            this.textBoxproductId.Size = new System.Drawing.Size(114, 27);
            this.textBoxproductId.TabIndex = 101;
            this.textBoxproductId.WordWrap = false;
            // 
            // productId
            // 
            this.productId.AutoSize = true;
            this.productId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productId.Location = new System.Drawing.Point(21, 68);
            this.productId.Name = "productId";
            this.productId.Size = new System.Drawing.Size(85, 20);
            this.productId.TabIndex = 2;
            this.productId.Text = "Product Id";
            // 
            // textBoxproductName
            // 
            this.textBoxproductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxproductName.Location = new System.Drawing.Point(218, 115);
            this.textBoxproductName.Name = "textBoxproductName";
            this.textBoxproductName.Size = new System.Drawing.Size(209, 27);
            this.textBoxproductName.TabIndex = 1;
            // 
            // productName
            // 
            this.productName.AutoSize = true;
            this.productName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productName.Location = new System.Drawing.Point(21, 122);
            this.productName.Name = "productName";
            this.productName.Size = new System.Drawing.Size(116, 20);
            this.productName.TabIndex = 0;
            this.productName.Text = "Product Name";
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.BackColor = System.Drawing.Color.Green;
            this.btnAddProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProduct.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddProduct.Location = new System.Drawing.Point(327, 591);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(131, 49);
            this.btnAddProduct.TabIndex = 7;
            this.btnAddProduct.Text = "Add Product";
            this.btnAddProduct.UseVisualStyleBackColor = false;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(31, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(454, 73);
            this.panel1.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(111, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Products";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Navy;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(535, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(866, 73);
            this.panel2.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(347, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(288, 38);
            this.label2.TabIndex = 0;
            this.label2.Text = "Avaliable Products";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(535, 91);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(866, 468);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Goldenrod;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUpdate.Location = new System.Drawing.Point(183, 591);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(127, 49);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDelete.Location = new System.Drawing.Point(31, 591);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(137, 49);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnPlaceOrder
            // 
            this.btnPlaceOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnPlaceOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlaceOrder.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPlaceOrder.Location = new System.Drawing.Point(535, 591);
            this.btnPlaceOrder.Name = "btnPlaceOrder";
            this.btnPlaceOrder.Size = new System.Drawing.Size(866, 49);
            this.btnPlaceOrder.TabIndex = 12;
            this.btnPlaceOrder.Text = "Place Order";
            this.btnPlaceOrder.UseVisualStyleBackColor = false;
            this.btnPlaceOrder.Click += new System.EventHandler(this.btnPlaceOrder_Click);
            // 
            // ProductsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1437, 666);
            this.Controls.Add(this.btnPlaceOrder);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.AddProducts);
            this.Name = "ProductsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProductsForm";
            this.Load += new System.EventHandler(this.ProductsForm_Load);
            this.AddProducts.ResumeLayout(false);
            this.AddProducts.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.GroupBox AddProducts;
        public System.Windows.Forms.Label productQuantity;
        public System.Windows.Forms.Label productPrice;
        public System.Windows.Forms.TextBox textBoxproductCategory;
        public System.Windows.Forms.Label productCategory;
        public System.Windows.Forms.TextBox textBoxproductManufacturer;
        public System.Windows.Forms.Label productManufacturer;
        public System.Windows.Forms.TextBox textBoxproductDescription;
        public System.Windows.Forms.Label productDescription;
        public System.Windows.Forms.TextBox textBoxproductId;
        public System.Windows.Forms.Label productId;
        public System.Windows.Forms.TextBox textBoxproductName;
        public System.Windows.Forms.Label productName;
        public System.Windows.Forms.Button btnAddProduct;
        public System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.Button btnUpdate;
        public System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox textBoxproductQuantity;
        private System.Windows.Forms.TextBox textBoxproductPrice;
        public System.Windows.Forms.Button btnPlaceOrder;
    }
}


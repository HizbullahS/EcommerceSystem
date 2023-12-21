
namespace EcommerceSystem.Forms
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnShipping = new System.Windows.Forms.Button();
            this.btnSales = new System.Windows.Forms.Button();
            this.btnAllProducts = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnPayment = new System.Windows.Forms.Button();
            this.btnCustomers = new System.Windows.Forms.Button();
            this.btnOrders = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1426, 65);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(77, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ecommerce System";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(58, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelMain
            // 
            this.panelMain.Location = new System.Drawing.Point(0, 146);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1426, 829);
            this.panelMain.TabIndex = 2;
            this.panelMain.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMain_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel2.Controls.Add(this.btnShipping);
            this.panel2.Controls.Add(this.btnSales);
            this.panel2.Controls.Add(this.btnAllProducts);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.btnPayment);
            this.panel2.Controls.Add(this.btnCustomers);
            this.panel2.Controls.Add(this.btnOrders);
            this.panel2.Location = new System.Drawing.Point(0, 60);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1426, 97);
            this.panel2.TabIndex = 0;
            // 
            // btnShipping
            // 
            this.btnShipping.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnShipping.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnShipping.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShipping.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnShipping.Location = new System.Drawing.Point(1188, 7);
            this.btnShipping.Name = "btnShipping";
            this.btnShipping.Size = new System.Drawing.Size(225, 83);
            this.btnShipping.TabIndex = 5;
            this.btnShipping.Text = "Shipping";
            this.btnShipping.UseVisualStyleBackColor = false;
            this.btnShipping.Click += new System.EventHandler(this.btnShipping_Click);
            // 
            // btnSales
            // 
            this.btnSales.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnSales.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSales.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSales.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSales.Location = new System.Drawing.Point(718, 7);
            this.btnSales.Name = "btnSales";
            this.btnSales.Size = new System.Drawing.Size(225, 83);
            this.btnSales.TabIndex = 4;
            this.btnSales.Text = "Total Sales";
            this.btnSales.UseVisualStyleBackColor = false;
            this.btnSales.Click += new System.EventHandler(this.btnSales_Click);
            // 
            // btnAllProducts
            // 
            this.btnAllProducts.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnAllProducts.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAllProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAllProducts.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAllProducts.Location = new System.Drawing.Point(13, 7);
            this.btnAllProducts.Name = "btnAllProducts";
            this.btnAllProducts.Size = new System.Drawing.Size(225, 83);
            this.btnAllProducts.TabIndex = 0;
            this.btnAllProducts.Text = "All Products";
            this.btnAllProducts.UseVisualStyleBackColor = false;
            this.btnAllProducts.Click += new System.EventHandler(this.btnAllProducts_Click);
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(3, 92);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1545, 701);
            this.panel3.TabIndex = 1;
            // 
            // btnPayment
            // 
            this.btnPayment.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnPayment.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayment.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPayment.Location = new System.Drawing.Point(953, 7);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(225, 83);
            this.btnPayment.TabIndex = 3;
            this.btnPayment.Text = "Payment";
            this.btnPayment.UseVisualStyleBackColor = false;
            this.btnPayment.Click += new System.EventHandler(this.btnPayment_Click);
            // 
            // btnCustomers
            // 
            this.btnCustomers.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnCustomers.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCustomers.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomers.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCustomers.Location = new System.Drawing.Point(483, 7);
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.Size = new System.Drawing.Size(225, 83);
            this.btnCustomers.TabIndex = 2;
            this.btnCustomers.Text = "Customers";
            this.btnCustomers.UseVisualStyleBackColor = false;
            this.btnCustomers.Click += new System.EventHandler(this.btnCustomers_Click);
            // 
            // btnOrders
            // 
            this.btnOrders.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnOrders.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrders.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnOrders.Location = new System.Drawing.Point(248, 7);
            this.btnOrders.Name = "btnOrders";
            this.btnOrders.Size = new System.Drawing.Size(225, 83);
            this.btnOrders.TabIndex = 1;
            this.btnOrders.Text = "Orders";
            this.btnOrders.UseVisualStyleBackColor = false;
            this.btnOrders.Click += new System.EventHandler(this.btnOrders_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1426, 971);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelMain);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load_1);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAllProducts;
        private System.Windows.Forms.Button btnSales;
        private System.Windows.Forms.Button btnPayment;
        private System.Windows.Forms.Button btnCustomers;
        private System.Windows.Forms.Button btnOrders;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnShipping;
    }
}
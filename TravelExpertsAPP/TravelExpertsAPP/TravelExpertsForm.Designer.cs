﻿namespace TravelExpertsAPP
{
    partial class TravelExpertsForm
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
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Products = new System.Windows.Forms.TabPage();
            this.productDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnDeleteProduct = new System.Windows.Forms.Button();
            this.btnModifyProduct = new System.Windows.Forms.Button();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.Packages = new System.Windows.Forms.TabPage();
            this.btnDeletePackage = new System.Windows.Forms.Button();
            this.btnModifyPackage = new System.Windows.Forms.Button();
            this.btnAddPackage = new System.Windows.Forms.Button();
            this.Suppliers = new System.Windows.Forms.TabPage();
            this.supplierDataGridView = new System.Windows.Forms.DataGridView();
            this.btnDeleteSupplier = new System.Windows.Forms.Button();
            this.btnModifySupplier = new System.Windows.Forms.Button();
            this.btnAddSupplier = new System.Windows.Forms.Button();
            this.Product_Suppliers = new System.Windows.Forms.TabPage();
            this.btnDeleteProductSupplier = new System.Windows.Forms.Button();
            this.btnModifyProductSupplier = new System.Windows.Forms.Button();
            this.btnAddProductSupplier = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl1.SuspendLayout();
            this.Products.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            this.Packages.SuspendLayout();
            this.Suppliers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.supplierDataGridView)).BeginInit();
            this.Product_Suppliers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Products);
            this.tabControl1.Controls.Add(this.Packages);
            this.tabControl1.Controls.Add(this.Suppliers);
            this.tabControl1.Controls.Add(this.Product_Suppliers);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(795, 396);
            this.tabControl1.TabIndex = 0;
            // 
            // Products
            // 
            this.Products.AutoScroll = true;
            this.Products.Controls.Add(this.productDataGridView);
            this.Products.Controls.Add(this.btnDeleteProduct);
            this.Products.Controls.Add(this.btnModifyProduct);
            this.Products.Controls.Add(this.btnAddProduct);
            this.Products.Location = new System.Drawing.Point(4, 22);
            this.Products.Name = "Products";
            this.Products.Padding = new System.Windows.Forms.Padding(3);
            this.Products.Size = new System.Drawing.Size(787, 370);
            this.Products.TabIndex = 0;
            this.Products.Text = "Products";
            this.Products.UseVisualStyleBackColor = true;
            // 
            // btnDeleteProduct
            // productDataGridView
            // 
            this.btnDeleteProduct.Location = new System.Drawing.Point(489, 345);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteProduct.TabIndex = 2;
            this.btnDeleteProduct.Text = "Delete";
            this.btnDeleteProduct.UseVisualStyleBackColor = true;
            this.productDataGridView.AutoGenerateColumns = false;
            this.productDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.productDataGridView.DataSource = this.productBindingSource;
            this.productDataGridView.Location = new System.Drawing.Point(51, 42);
            this.productDataGridView.Name = "productDataGridView";
            this.productDataGridView.Size = new System.Drawing.Size(300, 220);
            this.productDataGridView.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn1
            // btnModifyProduct
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ProductID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ProductID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ProdName";
            this.dataGridViewTextBoxColumn2.HeaderText = "ProdName";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.btnModifyProduct.Location = new System.Drawing.Point(345, 345);
            this.btnModifyProduct.Name = "btnModifyProduct";
            this.btnModifyProduct.Size = new System.Drawing.Size(75, 23);
            this.btnModifyProduct.TabIndex = 1;
            this.btnModifyProduct.Text = "Modify";
            this.btnModifyProduct.UseVisualStyleBackColor = true;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(TravelExpertsLibrary.Product);
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.Location = new System.Drawing.Point(276, 286);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteProduct.TabIndex = 2;
            this.btnDeleteProduct.Text = "Delete";
            this.btnDeleteProduct.UseVisualStyleBackColor = true;
            this.btnDeleteProduct.Click += new System.EventHandler(this.btnDeleteProduct_Click);
            // 
            // Packages
            // 
            this.btnModifyProduct.Location = new System.Drawing.Point(163, 286);
            this.btnModifyProduct.Name = "btnModifyProduct";
            this.btnModifyProduct.Size = new System.Drawing.Size(75, 23);
            this.btnModifyProduct.TabIndex = 1;
            this.btnModifyProduct.Text = "Modify";
            this.btnModifyProduct.UseVisualStyleBackColor = true;
            this.btnModifyProduct.Click += new System.EventHandler(this.btnModifyProduct_Click);
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Location = new System.Drawing.Point(51, 286);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(75, 23);
            this.btnAddProduct.TabIndex = 0;
            this.btnAddProduct.Text = "Add";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            this.Packages.Controls.Add(this.btnDeletePackage);
            this.Packages.Controls.Add(this.btnModifyPackage);
            this.Packages.Controls.Add(this.btnAddPackage);
            this.Packages.Location = new System.Drawing.Point(4, 22);
            this.Packages.Name = "Packages";
            this.Packages.Padding = new System.Windows.Forms.Padding(3);
            this.Packages.Size = new System.Drawing.Size(787, 370);
            this.Packages.TabIndex = 1;
            this.Packages.Text = "Packages";
            this.Packages.UseVisualStyleBackColor = true;
            // 
            // Packages
            // 
            this.Packages.Controls.Add(this.btnDeletePackage);
            this.Packages.Controls.Add(this.btnModifyPackage);
            this.Packages.Controls.Add(this.btnAddPackage);
            this.Packages.Location = new System.Drawing.Point(4, 22);
            this.Packages.Name = "Packages";
            this.Packages.Padding = new System.Windows.Forms.Padding(3);
            this.Packages.Size = new System.Drawing.Size(787, 370);
            this.Packages.TabIndex = 1;
            this.Packages.Text = "Packages";
            this.Packages.UseVisualStyleBackColor = true;
            // 
            // btnDeletePackage
            // 
            this.btnDeletePackage.Location = new System.Drawing.Point(489, 344);
            this.btnDeletePackage.Name = "btnDeletePackage";
            this.btnDeletePackage.Size = new System.Drawing.Size(75, 23);
            this.btnDeletePackage.TabIndex = 6;
            this.btnDeletePackage.Text = "Delete";
            this.btnDeletePackage.UseVisualStyleBackColor = true;
            // 
            // btnModifyPackage
            // 
            this.btnModifyPackage.Location = new System.Drawing.Point(345, 344);
            this.btnModifyPackage.Name = "btnModifyPackage";
            this.btnModifyPackage.Size = new System.Drawing.Size(75, 23);
            this.btnModifyPackage.TabIndex = 5;
            this.btnModifyPackage.Text = "Modify";
            this.btnModifyPackage.UseVisualStyleBackColor = true;
            // 
            // btnAddPackage
            // 
            this.btnAddPackage.Location = new System.Drawing.Point(208, 344);
            this.btnAddPackage.Name = "btnAddPackage";
            this.btnAddPackage.Size = new System.Drawing.Size(75, 23);
            this.btnAddPackage.TabIndex = 4;
            this.btnAddPackage.Text = "Add";
            this.btnAddPackage.UseVisualStyleBackColor = true;
            // 
            // Suppliers
            // 
            this.Suppliers.AutoScroll = true;
            this.Suppliers.Controls.Add(this.supplierDataGridView);
            this.Suppliers.Controls.Add(this.btnDeleteSupplier);
            this.Suppliers.Controls.Add(this.btnModifySupplier);
            this.Suppliers.Controls.Add(this.btnAddSupplier);
            this.Suppliers.Location = new System.Drawing.Point(4, 22);
            this.Suppliers.Name = "Suppliers";
            this.Suppliers.Size = new System.Drawing.Size(787, 370);
            this.Suppliers.TabIndex = 2;
            this.Suppliers.Text = "Suppliers";
            this.Suppliers.UseVisualStyleBackColor = true;
            // 
            // supplierDataGridView
            // 
            this.supplierDataGridView.AutoGenerateColumns = false;
            this.supplierDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.supplierDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.supplierDataGridView.DataSource = this.supplierBindingSource;
            this.supplierDataGridView.Location = new System.Drawing.Point(8, 21);
            this.supplierDataGridView.Name = "supplierDataGridView";
            this.supplierDataGridView.ReadOnly = true;
            this.supplierDataGridView.Size = new System.Drawing.Size(338, 292);
            this.supplierDataGridView.TabIndex = 6;
            
            // 
            // btnDeleteSupplier
            // 
            this.btnDeleteSupplier.Location = new System.Drawing.Point(489, 344);
            this.btnDeleteSupplier.Name = "btnDeleteSupplier";
            this.btnDeleteSupplier.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteSupplier.TabIndex = 6;
            this.btnDeleteSupplier.Text = "Delete";
            this.btnDeleteSupplier.UseVisualStyleBackColor = true;
            this.btnDeleteSupplier.Click += new System.EventHandler(this.btnDeleteSupplier_Click);
            // 
            // btnModifySupplier
            // 
            this.btnModifySupplier.Location = new System.Drawing.Point(345, 344);
            this.btnModifySupplier.Name = "btnModifySupplier";
            this.btnModifySupplier.Size = new System.Drawing.Size(75, 23);
            this.btnModifySupplier.TabIndex = 5;
            this.btnModifySupplier.Text = "Modify";
            this.btnModifySupplier.UseVisualStyleBackColor = true;
            this.btnModifySupplier.Click += new System.EventHandler(this.btnModifySupplier_Click);
            // 
            // btnAddSupplier
            // 
            this.btnAddSupplier.Location = new System.Drawing.Point(208, 344);
            this.btnAddSupplier.Name = "btnAddSupplier";
            this.btnAddSupplier.Size = new System.Drawing.Size(75, 23);
            this.btnAddSupplier.TabIndex = 4;
            this.btnAddSupplier.Text = "Add";
            this.btnAddSupplier.UseVisualStyleBackColor = true;
            this.btnAddSupplier.Click += new System.EventHandler(this.btnAddSupplier_Click);
            // 
            // Product_Suppliers
            // 
            // Product_Suppliers
            // 
            this.Product_Suppliers.Controls.Add(this.btnDeleteProductSupplier);
            this.Product_Suppliers.Controls.Add(this.btnModifyProductSupplier);
            this.Product_Suppliers.Controls.Add(this.btnAddProductSupplier);
            this.Product_Suppliers.Location = new System.Drawing.Point(4, 22);
            this.Product_Suppliers.Name = "Product_Suppliers";
            this.Product_Suppliers.Size = new System.Drawing.Size(787, 370);
            this.Product_Suppliers.TabIndex = 3;
            this.Product_Suppliers.Text = "Product_Suppliers";
            this.Product_Suppliers.UseVisualStyleBackColor = true;
            // 
            // btnDeleteProductSupplier
            // 
            this.btnDeleteProductSupplier.Location = new System.Drawing.Point(489, 344);
            this.btnDeleteProductSupplier.Name = "btnDeleteProductSupplier";
            this.btnDeleteProductSupplier.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteProductSupplier.TabIndex = 6;
            this.btnDeleteProductSupplier.Text = "Delete";
            this.btnDeleteProductSupplier.UseVisualStyleBackColor = true;
            // 
            // btnModifyProductSupplier
            // 
            this.btnModifyProductSupplier.Location = new System.Drawing.Point(345, 344);
            this.btnModifyProductSupplier.Name = "btnModifyProductSupplier";
            this.btnModifyProductSupplier.Size = new System.Drawing.Size(75, 23);
            this.btnModifyProductSupplier.TabIndex = 5;
            this.btnModifyProductSupplier.Text = "Modify";
            this.btnModifyProductSupplier.UseVisualStyleBackColor = true;
            // 
            // btnAddProductSupplier
            // 
            this.btnAddProductSupplier.Location = new System.Drawing.Point(208, 344);
            this.btnAddProductSupplier.Name = "btnAddProductSupplier";
            this.btnAddProductSupplier.Size = new System.Drawing.Size(75, 23);
            this.btnAddProductSupplier.TabIndex = 4;
            this.btnAddProductSupplier.Text = "Add";
            this.btnAddProductSupplier.UseVisualStyleBackColor = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "SupplierId";
            this.dataGridViewTextBoxColumn3.HeaderText = "SupplierId";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 20;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 79;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "SupName";
            this.dataGridViewTextBoxColumn4.HeaderText = "SupName";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 79;
            // 
            // supplierBindingSource
            // 
            this.supplierBindingSource.DataSource = typeof(TravelExpertsLibrary.Supplier);
            // 
            // TravelExpertsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(795, 396);
            this.Controls.Add(this.tabControl1);
            this.Name = "TravelExpertsForm";
            this.Text = "TravelExpertsForm";
            this.Load += new System.EventHandler(this.TravelExpertsForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.Products.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.productDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            this.Packages.ResumeLayout(false);
            this.Suppliers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.supplierDataGridView)).EndInit();
            this.Product_Suppliers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Products;
        private System.Windows.Forms.TabPage Packages;
        private System.Windows.Forms.Button btnDeleteProduct;
        private System.Windows.Forms.Button btnModifyProduct;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Button btnDeletePackage;
        private System.Windows.Forms.Button btnModifyPackage;
        private System.Windows.Forms.Button btnAddPackage;
        private System.Windows.Forms.TabPage Suppliers;
        private System.Windows.Forms.Button btnDeleteSupplier;
        private System.Windows.Forms.Button btnModifySupplier;
        private System.Windows.Forms.Button btnAddSupplier;
        private System.Windows.Forms.TabPage Product_Suppliers;
        private System.Windows.Forms.Button btnDeleteProductSupplier;
        private System.Windows.Forms.Button btnModifyProductSupplier;
        private System.Windows.Forms.Button btnAddProductSupplier;
        private System.Windows.Forms.BindingSource supplierBindingSource;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridView supplierDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridView productDataGridView;
        private System.Windows.Forms.BindingSource productBindingSource;
    }
}
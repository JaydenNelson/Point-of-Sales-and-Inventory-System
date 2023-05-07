
namespace FOTOFIRST
{
    partial class Sales
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
            this.lblCustomer = new System.Windows.Forms.Label();
            this.txtCustomer = new System.Windows.Forms.TextBox();
            this.rbtnService = new System.Windows.Forms.RadioButton();
            this.gbItemFinder = new System.Windows.Forms.GroupBox();
            this.cntQty = new System.Windows.Forms.NumericUpDown();
            this.rbtnProduct = new System.Windows.Forms.RadioButton();
            this.lblQty = new System.Windows.Forms.Label();
            this.lblSearch = new System.Windows.Forms.Label();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.lstItems = new System.Windows.Forms.ListBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSaleListHeadings = new System.Windows.Forms.Label();
            this.btnConfirmSale = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            this.lstSaleItems = new System.Windows.Forms.ListView();
            this.colNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colProductService = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colItem = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colQty = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colVAT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTotal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gbItemFinder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cntQty)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Location = new System.Drawing.Point(32, 46);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(85, 13);
            this.lblCustomer.TabIndex = 0;
            this.lblCustomer.Text = "Customer Name:";
            // 
            // txtCustomer
            // 
            this.txtCustomer.Location = new System.Drawing.Point(141, 46);
            this.txtCustomer.Name = "txtCustomer";
            this.txtCustomer.Size = new System.Drawing.Size(100, 20);
            this.txtCustomer.TabIndex = 1;
            this.txtCustomer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCustomer_KeyDown);
            // 
            // rbtnService
            // 
            this.rbtnService.AutoSize = true;
            this.rbtnService.Location = new System.Drawing.Point(19, 64);
            this.rbtnService.Name = "rbtnService";
            this.rbtnService.Size = new System.Drawing.Size(61, 17);
            this.rbtnService.TabIndex = 3;
            this.rbtnService.TabStop = true;
            this.rbtnService.Text = "Service";
            this.rbtnService.UseVisualStyleBackColor = true;
            this.rbtnService.CheckedChanged += new System.EventHandler(this.rbtnService_CheckedChanged);
            // 
            // gbItemFinder
            // 
            this.gbItemFinder.Controls.Add(this.cntQty);
            this.gbItemFinder.Controls.Add(this.rbtnProduct);
            this.gbItemFinder.Controls.Add(this.lblQty);
            this.gbItemFinder.Controls.Add(this.lblSearch);
            this.gbItemFinder.Controls.Add(this.rbtnService);
            this.gbItemFinder.Controls.Add(this.btnAddItem);
            this.gbItemFinder.Controls.Add(this.lstItems);
            this.gbItemFinder.Controls.Add(this.txtSearch);
            this.gbItemFinder.Location = new System.Drawing.Point(83, 107);
            this.gbItemFinder.Name = "gbItemFinder";
            this.gbItemFinder.Size = new System.Drawing.Size(209, 358);
            this.gbItemFinder.TabIndex = 4;
            this.gbItemFinder.TabStop = false;
            this.gbItemFinder.Text = "Item Finder";
            // 
            // cntQty
            // 
            this.cntQty.Location = new System.Drawing.Point(89, 239);
            this.cntQty.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.cntQty.Name = "cntQty";
            this.cntQty.Size = new System.Drawing.Size(80, 20);
            this.cntQty.TabIndex = 14;
            this.cntQty.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // rbtnProduct
            // 
            this.rbtnProduct.AutoSize = true;
            this.rbtnProduct.Location = new System.Drawing.Point(19, 31);
            this.rbtnProduct.Name = "rbtnProduct";
            this.rbtnProduct.Size = new System.Drawing.Size(62, 17);
            this.rbtnProduct.TabIndex = 13;
            this.rbtnProduct.TabStop = true;
            this.rbtnProduct.Text = "Product";
            this.rbtnProduct.UseVisualStyleBackColor = true;
            this.rbtnProduct.CheckedChanged += new System.EventHandler(this.rbtnProduct_CheckedChanged);
            // 
            // lblQty
            // 
            this.lblQty.AutoSize = true;
            this.lblQty.Location = new System.Drawing.Point(10, 239);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(52, 13);
            this.lblQty.TabIndex = 12;
            this.lblQty.Text = "Quantity: ";
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(16, 108);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(67, 13);
            this.lblSearch.TabIndex = 11;
            this.lblSearch.Text = "Search Item:";
            // 
            // btnAddItem
            // 
            this.btnAddItem.Location = new System.Drawing.Point(38, 317);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(131, 23);
            this.btnAddItem.TabIndex = 9;
            this.btnAddItem.Text = "Add Product to list";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // lstItems
            // 
            this.lstItems.FormattingEnabled = true;
            this.lstItems.Location = new System.Drawing.Point(38, 131);
            this.lstItems.Name = "lstItems";
            this.lstItems.Size = new System.Drawing.Size(120, 95);
            this.lstItems.TabIndex = 8;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(103, 105);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(100, 20);
            this.txtSearch.TabIndex = 7;
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
            // 
            // lblSaleListHeadings
            // 
            this.lblSaleListHeadings.AutoSize = true;
            this.lblSaleListHeadings.Location = new System.Drawing.Point(681, 51);
            this.lblSaleListHeadings.Name = "lblSaleListHeadings";
            this.lblSaleListHeadings.Size = new System.Drawing.Size(132, 13);
            this.lblSaleListHeadings.TabIndex = 6;
            this.lblSaleListHeadings.Text = "/////////////////////////";
            // 
            // btnConfirmSale
            // 
            this.btnConfirmSale.Location = new System.Drawing.Point(990, 424);
            this.btnConfirmSale.Name = "btnConfirmSale";
            this.btnConfirmSale.Size = new System.Drawing.Size(101, 41);
            this.btnConfirmSale.TabIndex = 10;
            this.btnConfirmSale.Text = "Confirm Sale";
            this.btnConfirmSale.UseVisualStyleBackColor = true;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(1111, 298);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(59, 13);
            this.lblTotal.TabIndex = 11;
            this.lblTotal.Text = "TOTAL: R ";
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(678, 328);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(135, 23);
            this.btnRemove.TabIndex = 12;
            this.btnRemove.Text = "Void Product";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // lstSaleItems
            // 
            this.lstSaleItems.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colNo,
            this.colProductService,
            this.colItem,
            this.colQty,
            this.colPrice,
            this.colVAT,
            this.colTotal});
            this.lstSaleItems.FullRowSelect = true;
            this.lstSaleItems.GridLines = true;
            this.lstSaleItems.HideSelection = false;
            this.lstSaleItems.Location = new System.Drawing.Point(599, 80);
            this.lstSaleItems.Name = "lstSaleItems";
            this.lstSaleItems.Size = new System.Drawing.Size(653, 196);
            this.lstSaleItems.TabIndex = 13;
            this.lstSaleItems.UseCompatibleStateImageBehavior = false;
            this.lstSaleItems.View = System.Windows.Forms.View.Details;
            // 
            // colNo
            // 
            this.colNo.Text = "No.";
            this.colNo.Width = 30;
            // 
            // colProductService
            // 
            this.colProductService.Text = "PRODUCT/SERVICE";
            this.colProductService.Width = 120;
            // 
            // colItem
            // 
            this.colItem.Text = "ITEM";
            this.colItem.Width = 200;
            // 
            // colQty
            // 
            this.colQty.Text = "QTY";
            this.colQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.colQty.Width = 50;
            // 
            // colPrice
            // 
            this.colPrice.Text = "PRICE";
            this.colPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // colVAT
            // 
            this.colVAT.Text = "VAT";
            this.colVAT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // colTotal
            // 
            this.colTotal.Text = "SUBTOTAL";
            this.colTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.colTotal.Width = 80;
            // 
            // Sales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1299, 615);
            this.Controls.Add(this.lstSaleItems);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnConfirmSale);
            this.Controls.Add(this.lblSaleListHeadings);
            this.Controls.Add(this.gbItemFinder);
            this.Controls.Add(this.txtCustomer);
            this.Controls.Add(this.lblCustomer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Sales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sales";
            this.gbItemFinder.ResumeLayout(false);
            this.gbItemFinder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cntQty)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.TextBox txtCustomer;
        private System.Windows.Forms.RadioButton rbtnService;
        private System.Windows.Forms.GroupBox gbItemFinder;
        private System.Windows.Forms.Label lblSaleListHeadings;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ListBox lstItems;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.Button btnConfirmSale;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.ListView lstSaleItems;
        private System.Windows.Forms.ColumnHeader colNo;
        private System.Windows.Forms.ColumnHeader colProductService;
        private System.Windows.Forms.ColumnHeader colItem;
        private System.Windows.Forms.ColumnHeader colQty;
        private System.Windows.Forms.ColumnHeader colPrice;
        private System.Windows.Forms.ColumnHeader colVAT;
        private System.Windows.Forms.ColumnHeader colTotal;
        private System.Windows.Forms.Label lblQty;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.RadioButton rbtnProduct;
        private System.Windows.Forms.NumericUpDown cntQty;
    }
}
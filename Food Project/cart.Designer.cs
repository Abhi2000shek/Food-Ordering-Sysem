namespace Food_Project
{
    partial class cart
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
            this.placeorderlbl = new System.Windows.Forms.Label();
            this.categorylbl = new System.Windows.Forms.Label();
            this.catlist = new System.Windows.Forms.ListBox();
            this.categorybox = new System.Windows.Forms.ComboBox();
            this.itemlbl = new System.Windows.Forms.Label();
            this.totallbl = new System.Windows.Forms.Label();
            this.qtylbl = new System.Windows.Forms.Label();
            this.pricelbl = new System.Windows.Forms.Label();
            this.itembox = new System.Windows.Forms.TextBox();
            this.totalbox = new System.Windows.Forms.TextBox();
            this.pricebox = new System.Windows.Forms.TextBox();
            this.addcartbtn = new System.Windows.Forms.Button();
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.cartgrid = new System.Windows.Forms.DataGridView();
            this.itemname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rmvbtn = new System.Windows.Forms.Button();
            this.printbtn = new System.Windows.Forms.Button();
            this.grndtotallbl = new System.Windows.Forms.Label();
            this.amountlbl = new System.Windows.Forms.Label();
            this.qtybox = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.cartgrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qtybox)).BeginInit();
            this.SuspendLayout();
            // 
            // placeorderlbl
            // 
            this.placeorderlbl.AutoSize = true;
            this.placeorderlbl.BackColor = System.Drawing.Color.Transparent;
            this.placeorderlbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.placeorderlbl.ForeColor = System.Drawing.Color.Black;
            this.placeorderlbl.Location = new System.Drawing.Point(46, 36);
            this.placeorderlbl.Name = "placeorderlbl";
            this.placeorderlbl.Size = new System.Drawing.Size(126, 23);
            this.placeorderlbl.TabIndex = 0;
            this.placeorderlbl.Text = "Place Order";
            // 
            // categorylbl
            // 
            this.categorylbl.AutoSize = true;
            this.categorylbl.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categorylbl.Location = new System.Drawing.Point(60, 98);
            this.categorylbl.Name = "categorylbl";
            this.categorylbl.Size = new System.Drawing.Size(89, 21);
            this.categorylbl.TabIndex = 1;
            this.categorylbl.Text = "Category";
            // 
            // catlist
            // 
            this.catlist.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.catlist.FormattingEnabled = true;
            this.catlist.ItemHeight = 21;
            this.catlist.Location = new System.Drawing.Point(33, 233);
            this.catlist.Name = "catlist";
            this.catlist.Size = new System.Drawing.Size(146, 256);
            this.catlist.TabIndex = 2;
            this.catlist.SelectedIndexChanged += new System.EventHandler(this.catlist_SelectedIndexChanged);
            // 
            // categorybox
            // 
            this.categorybox.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categorybox.FormattingEnabled = true;
            this.categorybox.Items.AddRange(new object[] {
            "Food",
            "Drink"});
            this.categorybox.Location = new System.Drawing.Point(33, 121);
            this.categorybox.Name = "categorybox";
            this.categorybox.Size = new System.Drawing.Size(146, 29);
            this.categorybox.TabIndex = 3;
            this.categorybox.Text = "    Select Item";
            this.categorybox.SelectedIndexChanged += new System.EventHandler(this.categorybox_SelectedIndexChanged);
            // 
            // itemlbl
            // 
            this.itemlbl.AutoSize = true;
            this.itemlbl.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemlbl.Location = new System.Drawing.Point(292, 98);
            this.itemlbl.Name = "itemlbl";
            this.itemlbl.Size = new System.Drawing.Size(48, 21);
            this.itemlbl.TabIndex = 4;
            this.itemlbl.Text = "Item";
            // 
            // totallbl
            // 
            this.totallbl.AutoSize = true;
            this.totallbl.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totallbl.Location = new System.Drawing.Point(477, 169);
            this.totallbl.Name = "totallbl";
            this.totallbl.Size = new System.Drawing.Size(51, 21);
            this.totallbl.TabIndex = 5;
            this.totallbl.Text = "Total";
            // 
            // qtylbl
            // 
            this.qtylbl.AutoSize = true;
            this.qtylbl.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qtylbl.Location = new System.Drawing.Point(286, 169);
            this.qtylbl.Name = "qtylbl";
            this.qtylbl.Size = new System.Drawing.Size(82, 21);
            this.qtylbl.TabIndex = 6;
            this.qtylbl.Text = "Quantity";
            // 
            // pricelbl
            // 
            this.pricelbl.AutoSize = true;
            this.pricelbl.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pricelbl.Location = new System.Drawing.Point(477, 98);
            this.pricelbl.Name = "pricelbl";
            this.pricelbl.Size = new System.Drawing.Size(55, 21);
            this.pricelbl.TabIndex = 7;
            this.pricelbl.Text = "Price ";
            // 
            // itembox
            // 
            this.itembox.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itembox.Location = new System.Drawing.Point(243, 121);
            this.itembox.Name = "itembox";
            this.itembox.Size = new System.Drawing.Size(143, 26);
            this.itembox.TabIndex = 8;
            // 
            // totalbox
            // 
            this.totalbox.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalbox.Location = new System.Drawing.Point(428, 192);
            this.totalbox.Name = "totalbox";
            this.totalbox.Size = new System.Drawing.Size(143, 28);
            this.totalbox.TabIndex = 9;
            // 
            // pricebox
            // 
            this.pricebox.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pricebox.Location = new System.Drawing.Point(428, 121);
            this.pricebox.Name = "pricebox";
            this.pricebox.Size = new System.Drawing.Size(143, 28);
            this.pricebox.TabIndex = 11;
            // 
            // addcartbtn
            // 
            this.addcartbtn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.addcartbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addcartbtn.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addcartbtn.ForeColor = System.Drawing.Color.White;
            this.addcartbtn.Location = new System.Drawing.Point(428, 234);
            this.addcartbtn.Name = "addcartbtn";
            this.addcartbtn.Size = new System.Drawing.Size(143, 31);
            this.addcartbtn.TabIndex = 13;
            this.addcartbtn.Text = "Add to Cart";
            this.addcartbtn.UseVisualStyleBackColor = false;
            this.addcartbtn.Click += new System.EventHandler(this.addcartbtn_Click);
            // 
            // cartgrid
            // 
            this.cartgrid.BackgroundColor = System.Drawing.Color.White;
            this.cartgrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.cartgrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.cartgrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.cartgrid.ColumnHeadersHeight = 30;
            this.cartgrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itemname,
            this.UnitPrice,
            this.qty,
            this.Price});
            this.cartgrid.Cursor = System.Windows.Forms.Cursors.Default;
            this.cartgrid.GridColor = System.Drawing.Color.White;
            this.cartgrid.Location = new System.Drawing.Point(200, 296);
            this.cartgrid.Name = "cartgrid";
            this.cartgrid.RowHeadersWidth = 51;
            this.cartgrid.RowTemplate.Height = 24;
            this.cartgrid.Size = new System.Drawing.Size(554, 163);
            this.cartgrid.TabIndex = 14;
            this.cartgrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cartgrid_CellClick);
            // 
            // itemname
            // 
            this.itemname.HeaderText = "Item Name";
            this.itemname.MinimumWidth = 6;
            this.itemname.Name = "itemname";
            this.itemname.ReadOnly = true;
            this.itemname.Width = 125;
            // 
            // UnitPrice
            // 
            this.UnitPrice.HeaderText = "Unit Price";
            this.UnitPrice.MinimumWidth = 6;
            this.UnitPrice.Name = "UnitPrice";
            this.UnitPrice.ReadOnly = true;
            this.UnitPrice.Width = 125;
            // 
            // qty
            // 
            this.qty.HeaderText = "Quantity";
            this.qty.MinimumWidth = 6;
            this.qty.Name = "qty";
            this.qty.ReadOnly = true;
            this.qty.Width = 125;
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            this.Price.Width = 125;
            // 
            // rmvbtn
            // 
            this.rmvbtn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.rmvbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rmvbtn.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rmvbtn.ForeColor = System.Drawing.Color.White;
            this.rmvbtn.Location = new System.Drawing.Point(219, 465);
            this.rmvbtn.Name = "rmvbtn";
            this.rmvbtn.Size = new System.Drawing.Size(104, 31);
            this.rmvbtn.TabIndex = 15;
            this.rmvbtn.Text = "Remove";
            this.rmvbtn.UseVisualStyleBackColor = false;
            this.rmvbtn.Click += new System.EventHandler(this.rmvbtn_Click);
            // 
            // printbtn
            // 
            this.printbtn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.printbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.printbtn.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printbtn.ForeColor = System.Drawing.Color.White;
            this.printbtn.Location = new System.Drawing.Point(640, 465);
            this.printbtn.Name = "printbtn";
            this.printbtn.Size = new System.Drawing.Size(83, 31);
            this.printbtn.TabIndex = 16;
            this.printbtn.Text = "Print";
            this.printbtn.UseVisualStyleBackColor = false;
            this.printbtn.Click += new System.EventHandler(this.printbtn_Click);
            // 
            // grndtotallbl
            // 
            this.grndtotallbl.AutoSize = true;
            this.grndtotallbl.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grndtotallbl.Location = new System.Drawing.Point(345, 475);
            this.grndtotallbl.Name = "grndtotallbl";
            this.grndtotallbl.Size = new System.Drawing.Size(110, 21);
            this.grndtotallbl.TabIndex = 17;
            this.grndtotallbl.Text = "Grand Total";
            // 
            // amountlbl
            // 
            this.amountlbl.BackColor = System.Drawing.Color.MistyRose;
            this.amountlbl.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountlbl.Location = new System.Drawing.Point(477, 475);
            this.amountlbl.Name = "amountlbl";
            this.amountlbl.Size = new System.Drawing.Size(110, 21);
            this.amountlbl.TabIndex = 18;
            this.amountlbl.Text = "Rs. 00";
            this.amountlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // qtybox
            // 
            this.qtybox.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qtybox.Location = new System.Drawing.Point(284, 192);
            this.qtybox.Name = "qtybox";
            this.qtybox.Size = new System.Drawing.Size(102, 28);
            this.qtybox.TabIndex = 19;
            this.qtybox.ValueChanged += new System.EventHandler(this.qtybox_ValueChanged);
            // 
            // cart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.qtybox);
            this.Controls.Add(this.amountlbl);
            this.Controls.Add(this.grndtotallbl);
            this.Controls.Add(this.printbtn);
            this.Controls.Add(this.rmvbtn);
            this.Controls.Add(this.cartgrid);
            this.Controls.Add(this.addcartbtn);
            this.Controls.Add(this.pricebox);
            this.Controls.Add(this.totalbox);
            this.Controls.Add(this.itembox);
            this.Controls.Add(this.pricelbl);
            this.Controls.Add(this.qtylbl);
            this.Controls.Add(this.totallbl);
            this.Controls.Add(this.itemlbl);
            this.Controls.Add(this.categorybox);
            this.Controls.Add(this.catlist);
            this.Controls.Add(this.categorylbl);
            this.Controls.Add(this.placeorderlbl);
            this.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "cart";
            this.Size = new System.Drawing.Size(780, 600);
            this.Load += new System.EventHandler(this.cart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cartgrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qtybox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label placeorderlbl;
        private System.Windows.Forms.Label categorylbl;
        private System.Windows.Forms.ListBox catlist;
        private System.Windows.Forms.ComboBox categorybox;
        private System.Windows.Forms.Label itemlbl;
        private System.Windows.Forms.Label totallbl;
        private System.Windows.Forms.Label qtylbl;
        private System.Windows.Forms.Label pricelbl;
        private System.Windows.Forms.TextBox itembox;
        private System.Windows.Forms.TextBox totalbox;
        private System.Windows.Forms.TextBox pricebox;
        private System.Windows.Forms.Button addcartbtn;
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private System.Windows.Forms.DataGridView cartgrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemname;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.Button rmvbtn;
        private System.Windows.Forms.Button printbtn;
        private System.Windows.Forms.Label grndtotallbl;
        private System.Windows.Forms.Label amountlbl;
        private System.Windows.Forms.NumericUpDown qtybox;
    }
}

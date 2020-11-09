namespace Food_Project
{
    partial class Food
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
            this.sidepnl = new System.Windows.Forms.Panel();
            this.aboutbtn = new System.Windows.Forms.Button();
            this.drnkbtn = new System.Windows.Forms.Button();
            this.cartbtn = new System.Windows.Forms.Button();
            this.foodbtn = new System.Windows.Forms.Button();
            this.logo = new System.Windows.Forms.PictureBox();
            this.uprpnl = new System.Windows.Forms.Panel();
            this.logout = new System.Windows.Forms.Button();
            this.copylbl = new System.Windows.Forms.Label();
            this.foodctrl1 = new Food_Project.foodctrl();
            this.aboutctrl1 = new Food_Project.aboutctrl();
            this.drnkctrl1 = new Food_Project.drnkctrl();
            this.cart1 = new Food_Project.cart();
            this.sidepnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.uprpnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidepnl
            // 
            this.sidepnl.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.sidepnl.Controls.Add(this.aboutbtn);
            this.sidepnl.Controls.Add(this.drnkbtn);
            this.sidepnl.Controls.Add(this.cartbtn);
            this.sidepnl.Controls.Add(this.foodbtn);
            this.sidepnl.Controls.Add(this.logo);
            this.sidepnl.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidepnl.Location = new System.Drawing.Point(0, 0);
            this.sidepnl.Name = "sidepnl";
            this.sidepnl.Size = new System.Drawing.Size(110, 727);
            this.sidepnl.TabIndex = 0;
            // 
            // aboutbtn
            // 
            this.aboutbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aboutbtn.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutbtn.ForeColor = System.Drawing.Color.White;
            this.aboutbtn.Image = global::Food_Project.Properties.Resources.icons8_teamwork_48;
            this.aboutbtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.aboutbtn.Location = new System.Drawing.Point(0, 472);
            this.aboutbtn.Name = "aboutbtn";
            this.aboutbtn.Size = new System.Drawing.Size(110, 77);
            this.aboutbtn.TabIndex = 5;
            this.aboutbtn.Text = "\r\n\r\nAbout";
            this.aboutbtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.aboutbtn.UseVisualStyleBackColor = true;
            this.aboutbtn.Click += new System.EventHandler(this.aboutbtn_Click);
            // 
            // drnkbtn
            // 
            this.drnkbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.drnkbtn.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drnkbtn.ForeColor = System.Drawing.Color.White;
            this.drnkbtn.Image = global::Food_Project.Properties.Resources.icons8_cola_48;
            this.drnkbtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.drnkbtn.Location = new System.Drawing.Point(0, 252);
            this.drnkbtn.Name = "drnkbtn";
            this.drnkbtn.Size = new System.Drawing.Size(110, 77);
            this.drnkbtn.TabIndex = 3;
            this.drnkbtn.Text = "\r\n\r\nDrinks";
            this.drnkbtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.drnkbtn.UseVisualStyleBackColor = true;
            this.drnkbtn.Click += new System.EventHandler(this.drnkbtn_Click);
            // 
            // cartbtn
            // 
            this.cartbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cartbtn.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cartbtn.ForeColor = System.Drawing.Color.White;
            this.cartbtn.Image = global::Food_Project.Properties.Resources.icons8_take_away_food_48;
            this.cartbtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cartbtn.Location = new System.Drawing.Point(0, 362);
            this.cartbtn.Name = "cartbtn";
            this.cartbtn.Size = new System.Drawing.Size(110, 77);
            this.cartbtn.TabIndex = 4;
            this.cartbtn.Text = "\r\n\r\nCart";
            this.cartbtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cartbtn.UseVisualStyleBackColor = true;
            this.cartbtn.Click += new System.EventHandler(this.cartbtn_Click_1);
            // 
            // foodbtn
            // 
            this.foodbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.foodbtn.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.foodbtn.ForeColor = System.Drawing.Color.White;
            this.foodbtn.Image = global::Food_Project.Properties.Resources.icons8_hamburger_48;
            this.foodbtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.foodbtn.Location = new System.Drawing.Point(0, 146);
            this.foodbtn.Name = "foodbtn";
            this.foodbtn.Size = new System.Drawing.Size(110, 73);
            this.foodbtn.TabIndex = 2;
            this.foodbtn.Text = "\r\n\r\nFood";
            this.foodbtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.foodbtn.UseVisualStyleBackColor = true;
            this.foodbtn.Click += new System.EventHandler(this.foodbtn_Click);
            // 
            // logo
            // 
            this.logo.Image = global::Food_Project.Properties.Resources.icons8_natural_food_48;
            this.logo.Location = new System.Drawing.Point(33, 12);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(48, 48);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo.TabIndex = 2;
            this.logo.TabStop = false;
            // 
            // uprpnl
            // 
            this.uprpnl.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.uprpnl.Controls.Add(this.logout);
            this.uprpnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.uprpnl.Location = new System.Drawing.Point(110, 0);
            this.uprpnl.Name = "uprpnl";
            this.uprpnl.Size = new System.Drawing.Size(996, 62);
            this.uprpnl.TabIndex = 1;
            // 
            // logout
            // 
            this.logout.BackColor = System.Drawing.Color.Transparent;
            this.logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logout.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout.ForeColor = System.Drawing.Color.Transparent;
            this.logout.Image = global::Food_Project.Properties.Resources.icons8_exit_48;
            this.logout.Location = new System.Drawing.Point(919, 9);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(53, 47);
            this.logout.TabIndex = 1;
            this.logout.UseVisualStyleBackColor = false;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // copylbl
            // 
            this.copylbl.AutoSize = true;
            this.copylbl.Location = new System.Drawing.Point(808, 681);
            this.copylbl.Name = "copylbl";
            this.copylbl.Size = new System.Drawing.Size(119, 19);
            this.copylbl.TabIndex = 5;
            this.copylbl.Text = "© Runtime Terror";
            // 
            // foodctrl1
            // 
            this.foodctrl1.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.foodctrl1.Location = new System.Drawing.Point(216, 80);
            this.foodctrl1.Name = "foodctrl1";
            this.foodctrl1.Size = new System.Drawing.Size(778, 598);
            this.foodctrl1.TabIndex = 2;
            // 
            // aboutctrl1
            // 
            this.aboutctrl1.Location = new System.Drawing.Point(225, 80);
            this.aboutctrl1.Margin = new System.Windows.Forms.Padding(2);
            this.aboutctrl1.Name = "aboutctrl1";
            this.aboutctrl1.Size = new System.Drawing.Size(778, 598);
            this.aboutctrl1.TabIndex = 4;
            // 
            // drnkctrl1
            // 
            this.drnkctrl1.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drnkctrl1.Location = new System.Drawing.Point(225, 80);
            this.drnkctrl1.Name = "drnkctrl1";
            this.drnkctrl1.Size = new System.Drawing.Size(778, 598);
            this.drnkctrl1.TabIndex = 3;
            // 
            // cart1
            // 
            this.cart1.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cart1.Location = new System.Drawing.Point(204, 78);
            this.cart1.Name = "cart1";
            this.cart1.Size = new System.Drawing.Size(780, 600);
            this.cart1.TabIndex = 6;
            // 
            // Food
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1106, 727);
            this.Controls.Add(this.foodctrl1);
            this.Controls.Add(this.cart1);
            this.Controls.Add(this.copylbl);
            this.Controls.Add(this.aboutctrl1);
            this.Controls.Add(this.drnkctrl1);
            this.Controls.Add(this.uprpnl);
            this.Controls.Add(this.sidepnl);
            this.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Food";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Food Factory";
            this.Load += new System.EventHandler(this.Food_Load);
            this.sidepnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.uprpnl.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel sidepnl;
        private System.Windows.Forms.Panel uprpnl;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Button foodbtn;
        private System.Windows.Forms.Button drnkbtn;
        private System.Windows.Forms.Button aboutbtn;
        private System.Windows.Forms.Button cartbtn;
        private foodctrl foodctrl1;
        private drnkctrl drnkctrl1;
        private aboutctrl aboutctrl1;
        private System.Windows.Forms.Label copylbl;
        private System.Windows.Forms.Button logout;
        private cart cart1;
    }
}


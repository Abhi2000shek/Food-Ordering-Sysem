using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DGVPrinterHelper;

namespace Food_Project
{
    public partial class cart : UserControl
    {
        function fn = new function();
        String query;
        public cart()
        {
            InitializeComponent();
        }
        private void cart_Load(object sender, EventArgs e)
        {

        }

        private void categorybox_SelectedIndexChanged(object sender, EventArgs e)
        {
            catlist.Items.Clear();
            String category = categorybox.Text;
           query="select name from items where category='"+category+"'";
            DataSet ds = fn.getData(query);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                catlist.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }
        }

        private void catlist_SelectedIndexChanged(object sender, EventArgs e)
        {
            qtybox.ResetText();
            totalbox.Clear();

            String text = catlist.GetItemText(catlist.SelectedItem);
            itembox.Text = text;
            query = "select price from items where name = '"+text+"'";
            DataSet ds = fn.getData(query);

            try
            {
                pricebox.Text = ds.Tables[0].Rows[0][0].ToString();
            }
            catch { }
        }

        private void qtybox_ValueChanged(object sender, EventArgs e)
        {
            Int64 quan = Int64.Parse(qtybox.Value.ToString());
            Int64 price = Int64.Parse(pricebox.Text);
            totalbox.Text = (quan * price).ToString();
        }
        protected int n, total = 0;
        private void addcartbtn_Click(object sender, EventArgs e)
        {
            if (totalbox.Text != "0" && totalbox.Text != "")
            {
                n = cartgrid.Rows.Add();
                cartgrid.Rows[n].Cells[0].Value = itembox.Text;
                cartgrid.Rows[n].Cells[1].Value = pricebox.Text;
                cartgrid.Rows[n].Cells[2].Value = qtybox.Value;
                cartgrid.Rows[n].Cells[3].Value = totalbox.Text;

                total = total + int.Parse(totalbox.Text);
                amountlbl.Text = "Rs. " + total;
            }
            else
            {
                MessageBox.Show("Minimum Quantity should be 1", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        int amount;
        private void cartgrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                amount = int.Parse(cartgrid.Rows[e.RowIndex].Cells[3].Value.ToString());
            }
            catch
            { }
        }
        private void rmvbtn_Click(object sender, EventArgs e)
        {
            try
            {
                cartgrid.Rows.RemoveAt(this.cartgrid.SelectedRows[0].Index);
            }
            catch { }
            total -= amount;
            amountlbl.Text = "Rs. " + total;
        }
        private void printbtn_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Cutomer Bill";
            printer.SubTitle = string.Format("Date: {0}", DateTime.UtcNow.AddHours(5.5).ToString("dd/MM/yyyy hh:mm:ss tt"));
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "Total Payable Amount: " + amountlbl.Text;
            printer.FooterSpacing = 10;
            printer.PrintDataGridView(cartgrid);

            total = 0;
            cartgrid.Rows.Clear();
            amountlbl.Text = "Rs. " + total;
        }
    }
}


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Food_Project
{
    public partial class Food : Form
    {
        public Food()
        {
            InitializeComponent();
        }

        private void foodbtn_Click(object sender, EventArgs e)
        {
            sidepnl.Height = foodbtn.Height;
            foodctrl1.BringToFront();
        }

        private void drnkbtn_Click(object sender, EventArgs e)
        {
            sidepnl.Height = drnkbtn.Height;
            drnkctrl1.BringToFront();
        }
        
        private void aboutbtn_Click(object sender, EventArgs e)
        {
            sidepnl.Height = aboutbtn.Height;
            aboutctrl1.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SignUp si = new SignUp();
            si.Show();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void cartbtn_Click_1(object sender, EventArgs e)
        {
            sidepnl.Height = cartbtn.Height;
            cart1.BringToFront();
        }

        private void Food_Load(object sender, EventArgs e)
        {

        }
    }
}

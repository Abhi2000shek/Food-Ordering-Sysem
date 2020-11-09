using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Food_Project
{
    public partial class foodctrl : UserControl
    {
        public foodctrl()
        {
            InitializeComponent();
        }

        private void foodctrl_Load(object sender, EventArgs e)
        {
            this.BringToFront();
        }

        private void brgrordrbtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Burger is loved by people of all age groups. This Fusion appetizer is amde using simple ingredients like burger bun, fried tikki, special chef's choice sauces, sliced onions and tomatoes.");
        }

        private void pizzaordrbtn_Click(object sender, EventArgs e)
        {
                MessageBox.Show("Onion| Green Capsicum| Mushroom| black olives, sweet corn, Red Paprika topped with Cheese.");

        }

        private void momoordrbtn_Click(object sender, EventArgs e)
        {
                MessageBox.Show("Momo filled with fresh chopped veggies and high protein Paneer. Mixed with green herbs.");
        }

        private void chilliordrbtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Crispy fried Chilly Potato with Spices.");
        }

        private void chowmeinordrbtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is the popular India-Chinese noodles stir fry dish. This is loaded with vegetables and flavoured with different sauces.");
        }

        private void sprngordrbtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Veg Spring Rolls are crispy deep-fried snacks filled with a delicious stuffing of lightly spiced and crunchy vegetables.");
        }
    }
}

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
    public partial class drnkctrl : UserControl
    {
        public drnkctrl()
        {
            InitializeComponent();
        }

        private void mojitoordrbtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ingredients: \n Fresh Lime Juice, Honey Simple Syrup, Fresh Mint leaves, Sparkling Water, Ice. ");
        }

        private void frnchordrbtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ingredients: \n 1 bottle of Prosecco Champagne or other Sparkling dry wine, 2-4 ounces of Raspberry Chambord, Fresh Raspberries for garnish.");
        }

        private void blueordrbtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ingredients: \n Blue Curaco Syrup, Fresh lemon Juice, Simple sugar syrup, Sprite, Soda, Lemon wedges for garnishing.");
        }

        private void seaordrbtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ingredients: \n Vodka, Cranberry Juice, Grapefruit juice, lime wheel for garnishing.");
        }

        private void pinaordrbtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ingredients: \n Pineapple juice, White rum, coconut cream, wedge of pineapple for garnish.");
        }

        private void shirleyordrbtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ingredients: \n Grenadine, Lemon-Lime Soda, Ice, Maraschino Cherries.");
        }
    }
}

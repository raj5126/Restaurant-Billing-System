using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant_Billing_System
{
    public partial class CustomerDetails : Form
    {
        List<String> item;
        double price;
        public CustomerDetails(List<String> al, double t_price)
        {
            this.item = al;
            this.price = t_price;
            InitializeComponent();

        }

        private void CustomerDetails_Load(object sender, EventArgs e)
        {
           Price_Tag.Text = "Total Amount : " + price;
        }

        private void button_Click(object sender, EventArgs e)
        {
            Bill b = new Bill(textBox1.Text,textBox2.Text,item,price);
            b.Show();
        }
    }
}

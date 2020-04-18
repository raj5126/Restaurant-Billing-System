using System;
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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        

        private void Home_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }

        private void additem_Click(object sender, EventArgs e)
        {
            AddItem a = new AddItem();
            a.Show();
        }

        private void take_order_Click(object sender, EventArgs e)
        {
            DisplayItems d = new DisplayItems();
            d.Show();
        }
    }
}

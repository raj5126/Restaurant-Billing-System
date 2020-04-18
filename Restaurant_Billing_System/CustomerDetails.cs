using Restaurant_Billing_System.models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
            this.BackColor = Color.White;
            Price_Tag.Text = "Total Amount : " + price;
        }

        private void button_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled)) {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Restaurant_Billing_System\Restaurant_Billing_System\restaurantdb.mdf;Integrated Security=True");
                Customer cd = new Customer();
                cd.name = textBox1.Text;
                cd.phone_no = textBox2.Text;
                Customer.addcustomer(cd);
                Bill b = new Bill(textBox1.Text, textBox2.Text, item, price);
                b.Show();
                }
            
        }

        private void name_validate(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                e.Cancel = true;
                textBox1.Focus();
                errorProvider1.SetError(textBox1, "Name should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(textBox1, "");
            }
        }

        private void phoneno_validate(object sender, CancelEventArgs e)
        {
            string phonePattern = @"^[2-9]\d{2}\d{3}\d{4}$";
            bool isPhoneValid = Regex.IsMatch(textBox2.Text, phonePattern);
            if (string.IsNullOrWhiteSpace(textBox2.Text) || (!isPhoneValid))
            {
                e.Cancel = true;
                textBox2.Focus();
                errorProvider2.SetError(textBox2, "Phone No should not be left blank! or in properform");
            }
            else
            {
                e.Cancel = false;
                errorProvider2.SetError(textBox2, "");
            }

        }
    }
}

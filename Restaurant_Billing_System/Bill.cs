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
using System.Linq;

namespace Restaurant_Billing_System
{
    public partial class Bill : Form
    {
        string name;
        string mobile_no;
        List<String> item;
        double amount;
        int position;
        public Bill(string name, string mobile_no, List<String> item, double price)
        {
            this.name = name;
            this.mobile_no = mobile_no;
            this.item = item;
            this.amount = price;
            InitializeComponent();
        }

        private void Bill_Load(object sender, EventArgs e)
        {
            int k=0;
           
            nmlabel.Text = name;
            phonelabel.Text = mobile_no;
            Label title = new Label();
            title.Text = "Items => Quantity";
            title.AutoSize = true;
            Font fc = new Font("Arial", 15, FontStyle.Underline);
            title.Font = fc;
            title.Location = new Point(20, 220);
            this.Controls.Add(title);
            List<String> qi = new List<String>(); 
            for(int j = 0;j<item.Count;j++)
            {
                //Console.WriteLine(item[j]);
                Label i = new Label();
                int result = qi.Where(q => q.Equals(item[j])).Count();
                if (result == 0)
                { 
                    qi.Add(item[j]);
                    int quantity = item.Where(name => name.Equals(item[j])).Count();
                    //Console.WriteLine(quantity);
                    i.Text = (k + 1).ToString() + "). " + item[j] +  " => " +  quantity;
                    i.AutoSize = true;
                    i.Location = new Point(20, 220 + 30 * (k + 1));
                    position = 220 + 30 * (k + 1);
                    this.Controls.Add(i);
                    k++;
                }
                    
            }
            Label total = new Label();
            total.Font = new Font("Arial", 9, FontStyle.Bold);
            total.Location = new Point(20, position + 50);
            Console.WriteLine(amount);
            total.AutoSize = true;
            total.Text = "Total Amount: " + amount;
            this.Controls.Add(total);

        }
    }
}

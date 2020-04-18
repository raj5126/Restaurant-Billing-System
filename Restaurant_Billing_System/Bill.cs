using Restaurant_Billing_System.models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Restaurant_Billing_System
{
    public partial class Bill : Form
    {
        string name;
        string mobile_no;
        List<String> item;
        double amount;
        int bill_no;
        int cut_id;
        double price;
        DataTable dt = new DataTable();
        public Bill(string name, string mobile_no, List<String> item, double price)
        {
            this.name = name;
            this.mobile_no = mobile_no;
            this.item = item;
            this.amount = price;
            InitializeComponent();
        }

        public void autonumber()
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Restaurant_Billing_System\Restaurant_Billing_System\restaurantdb.mdf;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("select max(Bill_id)+1 from Bill", con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    
                    billlbl.Text = "BILL__" + dr[0].ToString();
                    if (billlbl.Text == "BILL__")
                    {
                        billlbl.Text = "BILL__1";
                        bill_no = 1;
                    }
                    else
                    {
                        bill_no = Convert.ToInt32(dr[0].ToString());
            
                    }
                    Console.WriteLine(bill_no);

                }
            }
            else
            {
                billlbl.Text = "BILL__1";
            }
            con.Close();
        }

        private void Bill_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
            dt.Columns.Add("Sr No. ", typeof(int));
            dt.Columns.Add("Item Name", typeof(string));
            dt.Columns.Add("Quantity", typeof(int));
            dt.Columns.Add("Price", typeof(double));
            dt.Columns.Add("Total_Price", typeof(double));

            autonumber();
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Restaurant_Billing_System\Restaurant_Billing_System\restaurantdb.mdf;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("select customer_Id from Customer where Mobile_No=@Mobile_No",con);
            cmd.Parameters.AddWithValue("@Mobile_No", mobile_no);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    cut_id = Convert.ToInt32(dr[0].ToString());
                    //Console.WriteLine(cut_id);
                }
            }
            Bill_details bd = new Bill_details();
            bd.Bill_id = bill_no;
            bd.Customer_Id = cut_id;
            bd.Total_price = amount;
            Bill_details.add_bill_details(bd);
            int k=0;
            nmlabel.Text = name;
            phonelabel.Text = mobile_no;
            Label title = new Label();
            title.Text = "Summary";
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
                    SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Restaurant_Billing_System\Restaurant_Billing_System\restaurantdb.mdf;Integrated Security=True");
                    conn.Open();
                    SqlCommand pcmd = new SqlCommand("select Price from FoodItem Where ItemName = @ItemName", conn);
                    pcmd.Parameters.AddWithValue("@ItemName", item[j]);
                    SqlDataReader rdr = pcmd.ExecuteReader();
                    if (rdr.HasRows)
                    {
                        while(rdr.Read()){
                            price = Convert.ToDouble(rdr[0].ToString());
                        }
                    }
                    conn.Close();
                    qi.Add(item[j]);
                    int quantity = item.Where(name => name.Equals(item[j])).Count();
                    //Console.WriteLine(quantity);
                    dt.Rows.Add(new Object[] { k + 1, item[j], quantity, price, quantity*price});
                    k++;
                }
                    
            }
            dataGridView1.DataSource = dt;
            dataGridView1.AutoSize = true;
            pricelable.Text = "Total Amount : " + amount;

          

        }
    }
}

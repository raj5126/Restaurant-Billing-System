using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Restaurant_Billing_System
{
    public partial class DisplayItems : Form
    {
        double total_price = 0;
        List<String> al = new List<String>();
        public DisplayItems()
        {
            InitializeComponent();
        }

        private void DisplayItems_Load(object sender, EventArgs e)
        {
            //this.BackColor = Color.Black;

            DataSet ds = new DataSet();
            DataSet pds = new DataSet();

            String query = "SELECT * FROM FoodItem";
            String partitionquery = "SELECT * FROM FoodCategory";

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Restaurant_Billing_System\Restaurant_Billing_System\restaurantdb.mdf;Integrated Security=True");
            
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlDataAdapter pda = new SqlDataAdapter(partitionquery, con);
            
            sda.Fill(ds);
            pda.Fill(pds);

            Label[] categories = new Label[pds.Tables[0].Rows.Count];
            Button[] Pizza = new Button[ds.Tables[0].Rows.Count];
            Button[] Desert = new Button[ds.Tables[0].Rows.Count];
            Button[] Beverages = new Button[ds.Tables[0].Rows.Count];

            int p = 0;
            int d = 0;
            int b = 0;


            

            for (int i=0;i<ds.Tables[0].Rows.Count; i++)
            {
                try
                {
                    DataRow r = ds.Tables[0].Rows[i];
                    for (int j = 0; j < pds.Tables[0].Rows.Count; j++)
                    {
                        DataRow s = pds.Tables[0].Rows[j];
                        if (s.Field<int>(0) == r.Field<int>(1))
                        {
                            if (j == 0)
                            {
                               // Console.WriteLine("Pizza");
                                if (p == 0)
                                {
                                    categories[j] = new Label();
                                    categories[j].Text = "Pizza";
                                    //categories[j].ForeColor = Color.White;
                                    //categories[j].BackColor = Color.Black;
                                    categories[j].Location = new Point(5, 10);
                                    Font fc = new Font("Arial", 13, FontStyle.Underline);
                                    categories[j].Font = fc; 
                                    this.Controls.Add(categories[j]);

                                }
                                Pizza[p] = new Button();
                                Pizza[p].Text = r.Field<String>(2);
                                Pizza[p].AutoSize = true ;
                                Pizza[p].Height = 16;
                                Pizza[p].BackColor = Color.White;
                                Pizza[p].Padding = new Padding(6);
                                Font fn = new Font("Arial", 9, FontStyle.Bold);
                                Pizza[p].Font = fn;
                                Pizza[p].Location = new Point(0, 50 * p + 50);
                                Pizza[p].Click += new EventHandler(add_item);
                                this.Controls.Add(Pizza[p]);
                                p += 1;
                            }
                            else if(j == 1)
                            {
                                if (b == 0)
                                {
                                    categories[j] = new Label();
                                    categories[j].Text = "Beverages";
                                    //categories[j].ForeColor = Color.White;
                                    //categories[j].BackColor = Color.Black;
                                    categories[j].Location = new Point(300, 10);
                                    Font fc = new Font("Arial", 13, FontStyle.Underline);
                                    categories[j].Font = fc;
                                    this.Controls.Add(categories[j]);

                                }
                                //Console.WriteLine("Beverages");
                                Beverages[b] = new Button();
                                Beverages[b].Text = r.Field<String>(2);
                                Beverages[b].AutoSize = true;
                                Beverages[b].Height = 16;
                                Beverages[b].BackColor = Color.White;
                                Beverages[b].Padding = new Padding(6);
                                Font fn = new Font("Arial", 9, FontStyle.Bold);
                                Beverages[b].Font = fn;
                                Beverages[b].Location = new Point(300, 50 * b + 50);
                                Beverages[b].Click += new EventHandler(add_item);
                                this.Controls.Add(Beverages[b]);
                                b += 1;
                            }
                            else
                            {
                                if (d == 0)
                                {
                                    categories[j] = new Label();
                                    categories[j].Text = "Deserts";
                                    //categories[j].ForeColor = Color.White;
                                    //categories[j].BackColor = Color.Black;
                                    categories[j].Location = new Point(600, 10);
                                    Font fc = new Font("Arial", 13, FontStyle.Underline);
                                    categories[j].Font = fc;
                                    this.Controls.Add(categories[j]);
                                }
                                //Console.WriteLine("Desert");
                                Desert[d] = new Button();
                                Desert[d].Text = r.Field<String>(2);
                                Desert[d].AutoSize = true;
                                Desert[d].Height = 16;
                                Desert[d].BackColor = Color.White;
                                Desert[d].Padding = new Padding(6);
                                Font fn = new Font("Arial", 9, FontStyle.Bold);
                                Desert[d].Font = fn;
                                Desert[d].Location = new Point(600, 50 * d + 50);
                                Desert[d].Click += new EventHandler(add_item);
                                this.Controls.Add(Desert[d]);
                                d += 1;
                            }
                        }
                    }
                }
                catch(Exception ex)
                {
                    Console.WriteLine("Error : " + ex);
                }
            }
        }
        protected void add_item(object sender, EventArgs e)
        {
            Button button = sender as Button;
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Restaurant_Billing_System\Restaurant_Billing_System\restaurantdb.mdf;Integrated Security=True");
            string pricequery = "select * from FoodItem where ItemName = @ItemName";
            DataSet pr = new DataSet();
            SqlDataAdapter pra = new SqlDataAdapter(pricequery, con);
            pra.SelectCommand.Parameters.AddWithValue("@ItemName", button.Text);
            pra.Fill(pr);
            
            for (int i = 0; i < pr.Tables[0].Rows.Count; i++)
            {
                DataRow s = pr.Tables[0].Rows[i];
                total_price += s.Field<double>(4);
                al.Add(button.Text);
                listBox.Items.Add(button.Text.ToString() + "      "  + s.Field<double>(4));
            }

            pricelabel.Text = " Total Bill Amount: " + total_price ;

        }

        private void totalbill_Click(object sender, EventArgs e)
        {
            CustomerDetails cd = new CustomerDetails(al,total_price);
            cd.Show();
            this.Hide();

        }
    }
}

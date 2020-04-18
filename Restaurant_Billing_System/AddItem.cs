using Restaurant_Billing_System.models;
using System;
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
    public partial class AddItem : Form
    {
        public AddItem()
        {
            InitializeComponent();
        }

        byte[] ConvertImagetoBinary (Image img)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                return ms.ToArray();
            }
        }

        private void AddItem_Load(object sender, EventArgs e)
        {
            
            string query = "select * from FoodCategory";
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Restaurant_Billing_System\Restaurant_Billing_System\restaurantdb.mdf;Integrated Security=True");
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "CategoryName";
        }


        private void add_item_Click(object sender, EventArgs e) 
        {
            FoodItem fi = new FoodItem();
            DataSet ds = new DataSet();
            string query = "select * from FoodCategory where CategoryName=@CategoryName";
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Restaurant_Billing_System\Restaurant_Billing_System\restaurantdb.mdf;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            sda.SelectCommand.Parameters.AddWithValue("@CategoryName", comboBox1.Text);
            sda.Fill(ds);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                DataRow r = ds.Tables[0].Rows[i];
                fi.CategoryId = Convert.ToInt32(r.Field<int>(0));
            }
            fi.ItemName = itemname.Text;    
            fi.Price = Convert.ToDouble(price.Text);
            fi.ItemDescription = description.Text;
            fi.ItemImage =  ConvertImagetoBinary(pictureBox1.Image);
            Console.WriteLine(fi.CategoryId + fi.ItemName + fi.Price + fi.ItemDescription);
            Console.WriteLine(fi.ItemImage);
            success.Text = FoodItem.AddNewItem(fi);

        }

       
       private void choose_Click(object sender, EventArgs e)
        {
            String filename;
            using(OpenFileDialog ofd = new OpenFileDialog(){Filter = "JPEG|*.jpg", ValidateNames = true, Multiselect = false})
            {
                if(ofd.ShowDialog() == DialogResult.OK)
                {
                    filename = ofd.FileName;
                    path.Text = filename;
                    pictureBox1.Image = Image.FromFile(filename);
                }
            }
        }
    }
}

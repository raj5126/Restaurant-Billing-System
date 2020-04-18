using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant_Billing_System
{
    public partial class Cheflogin : Form
    {
        public Cheflogin()
        {
            InitializeComponent();
            passwordfield.Text = "";
            passwordfield.PasswordChar = '*';
            passwordfield.MaxLength = 10;
        }

        private void cheflogin_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (username.Text =="" || passwordfield.Text == ""){

                MessageBox.Show("Please Enter Correct username or password");

             }
            string user_id = username.Text;
            string password = passwordfield.Text;
            string query = "select * from Chef where Chef_Name=@user_id and Password=@password";
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Restaurant_Billing_System\Restaurant_Billing_System\restaurantdb.mdf;Integrated Security=True");
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@user_id", user_id);
            cmd.Parameters.AddWithValue("@password", password);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Login Success");
                Home add = new Home();
                this.Hide();
                add.Show();
            }
            else
            {
                label4.Text = "Invalid Credentials.";
            }
        }
    }
}

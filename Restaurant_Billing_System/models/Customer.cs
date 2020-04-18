using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Billing_System.models
{
    class Customer
    {
        public string name{ get; set; }
        public string phone_no { get; set; }

        internal static void addcustomer(Customer cd)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Restaurant_Billing_System\Restaurant_Billing_System\restaurantdb.mdf;Integrated Security=True");
                string query = "Insert into Customer(Customer_Name, Mobile_No) Values(@Customer_Name,@Mobile_No)";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Customer_Name", cd.name);
                cmd.Parameters.AddWithValue("@Mobile_No", cd.phone_no);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch(Exception)
            {
                Console.WriteLine("Error");
            }

        }
    }
}

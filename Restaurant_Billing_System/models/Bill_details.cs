using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Billing_System.models
{
    class Bill_details
    {
        public int Bill_id { get; set; }
        public int Customer_Id { get; set; }
        public double Total_price { get; set; }

        internal static void add_bill_details(Bill_details bd)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Restaurant_Billing_System\Restaurant_Billing_System\restaurantdb.mdf;Integrated Security=True");
                string query = "Insert into Bill(Bill_Id, Customer_Id,Total_Price) Values(@Bill_Id, @Customer_Id, @Total_Price)";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Bill_Id", bd.Bill_id);
                cmd.Parameters.AddWithValue("@Customer_Id", bd.Customer_Id);
                cmd.Parameters.AddWithValue("@Total_Price", bd.Total_price);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception)
            {
                Console.WriteLine("Error");
            }
        }
        
    }

}

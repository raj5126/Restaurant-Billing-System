using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Billing_System.models
{
    class FoodItem
    {
        public int CategoryId { get; set; }
        public String ItemName { get; set; }
        public double Price { get; set; }
        public String ItemDescription { get; set; }
        public byte[] ItemImage { get; set; }

        internal static string AddNewItem(FoodItem fi)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Restaurant_Billing_System\Restaurant_Billing_System\restaurantdb.mdf;Integrated Security=True");
                String query = "Insert INTO FoodItem(CategoryId, ItemName, ItemDescription, Price, ItemImage) VALUES(@CategoryId, @ItemName, @ItemDescription, @Price ,@ItemImage)";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@CategoryId", fi.CategoryId);
                cmd.Parameters.AddWithValue("@ItemName", fi.ItemName);
                cmd.Parameters.AddWithValue("@ItemDescription", fi.ItemDescription);
                cmd.Parameters.AddWithValue("@Price", fi.Price);
                cmd.Parameters.AddWithValue("@ItemImage",fi.ItemImage);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                return "Item Added Successfully.";
            }
            catch (Exception)
            {
                return "Error";
            }
        }
    }
}

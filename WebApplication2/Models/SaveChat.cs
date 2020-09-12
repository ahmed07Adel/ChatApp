using System;
using Microsoft.Data.SqlClient;

namespace WebApplication2.Models
{
    public class SaveChat
    {
        
        public int Chatid { get; set; }
        public string Chats { get; set; }
        public DateTime Date { get; set; }
        public string From { get; set; }



        public int SaveDetails()
        {
            SqlConnection defaultConnection = new SqlConnection(Getconstring.GetConString.ConString());
            string query = "INSERT INTO text(Chats,Date,FromUser) values ('" + Chats + "','" + DateTime.Now + "', '" + From + "')";
            SqlCommand cmd = new SqlCommand(query, defaultConnection);
            defaultConnection.Open();
            int result = cmd.ExecuteNonQuery();
            defaultConnection.Close();
            return result;
      


        }
    }
    

}

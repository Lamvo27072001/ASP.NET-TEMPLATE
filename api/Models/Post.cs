using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace api.Models
{
    public class Post
    {
        public int Id { get; set; }

        public string Author { get; set; } = string.Empty;

        public string Article { get; set; } = string.Empty;

        //     public DataTable GetData()
        //     {
        //         string connectionString = "server=localhost;port=3306;uid=dev;pwd=2707;database=blog";
        //         using (MySqlConnection connection = new MySqlConnection(connectionString))
        //         {
        //             DataTable dt = new DataTable();
        //             string query = "SELECT version();";
        //             using (MySqlCommand cmd = new MySqlCommand(query, connection))
        //             {
        //                 connection.Open();
        //                 using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
        //                 {
        //                     adapter.Fill(dt);
        //                 }
        //             }
        //             return dt;
        //         }
        //     }





        // }
    }
}
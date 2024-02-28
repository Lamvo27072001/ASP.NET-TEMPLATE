using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using api.Data;
using api.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;


namespace api.Controler
{
    [ApiController]
    [Route("api/blog")]
    public class PostController : ControllerBase
    {
        private readonly myDbContext _context;
        public PostController(myDbContext context)
        {
            _context = context;
        }
        [HttpGet]

        public IActionResult GetData()
        {
            // string connectionString = "server=localhost;port=3306;uid=dev;pwd=2707;database=blog";
            DataTable dt = new DataTable();
            // using (SqlConnection connection = new SqlConnection(connectionString))
            // {
            //     connection.Open();
            //     string query = "SELECT version();";
            //     using (SqlCommand command = new SqlCommand(query, connection))
            //     {
            //         using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            //         {
            //             adapter.Fill(dt);
            //         }
            //     }
            // }
            return Ok(dt);
            // var post = _context.Post.ToList();
            // return Ok(post);
        }
    }
}
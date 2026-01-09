using Microsoft.AspNetCore.Mvc;
using MySqlConnector;

namespace cozynibi.Controllers
{
    public class TestController : Controller
    {
        private readonly IConfiguration _configuration;

        public TestController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public IActionResult Db()
        {
            try
            {
                using var conn = new MySqlConnection(
                    _configuration.GetConnectionString("DefaultConnection")
                );

                conn.Open();
                return Content("✅ KẾT NỐI MYSQL THÀNH CÔNG");
            }
            catch (Exception ex)
            {
                return Content("❌ LỖI: " + ex.Message);
            }
        }
    }
}

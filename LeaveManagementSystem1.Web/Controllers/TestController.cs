using LeaveManagementSystem1.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace LeaveManagementSystem1.Web.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            var data = new TestViewModel
            {
                Name = "Van Jacob the great Developer",
                DateOfBirth = new DateTime(1998,09,14)
            };
            return View(data);
        }
    }
}

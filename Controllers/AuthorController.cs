using Microsoft.AspNetCore.Mvc;

namespace Working_With_Model_Author.Controllers
{
    public class AuthorController : Controller
    {
        public IActionResult Create()
        {
            return View();
        }
    }
}

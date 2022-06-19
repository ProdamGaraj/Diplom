using System.Threading.Tasks;
using Diplom.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Diplom.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;


        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;

        public HomeController(ILogger<HomeController> logger, UserManager<User> userManager,
            SignInManager<User> signInManager)
        {
            _logger = logger;
            _userManager = userManager;
            _signInManager = signInManager;
        }

        // GET: /
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            return View();
        }

        // GET: Home/Privacy
        [HttpGet]
        public IActionResult Privacy()
        {
            return View();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace TestAppForGitRepo.Controllers
{
    [Route("[controller]")]
    public class TestController : Controller
    {               
        public IActionResult Index(string username)
        {
            string returnText = "Hello " + username;
            return Content(returnText);
        }
    }
}

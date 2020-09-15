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
        public IActionResult Index(string username, bool isNew)
        {
            // Lets just add a comment & see the effect on the new commits
            string oneMoreParam = "hi I am your nightmare";

            string returnText = "Welcome " + username;
            if (isNew)
                returnText += " for the first time login";
            returnText = oneMoreParam + returnText;
            return Content(returnText);
        }
    }
}

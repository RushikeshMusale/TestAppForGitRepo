***REMOVED***
***REMOVED***
using System.Diagnostics;
***REMOVED***
***REMOVED***
***REMOVED***
using TestAppForGitRepo.Models;

***REMOVED***
***REMOVED***
    public class HomeController : Controller
    ***REMOVED***
        public IActionResult Index()
        ***REMOVED***
            return View();
***REMOVED***

        public IActionResult About()
        ***REMOVED***
            ViewData["Message"] = "Your application description page.";

            return View();
***REMOVED***

        public IActionResult Contact()
        ***REMOVED***
            ViewData["Message"] = "Your contact page.";

            return View();
***REMOVED***

        public IActionResult Privacy()
        ***REMOVED***
            return View();
***REMOVED***

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        ***REMOVED***
            return View(new ErrorViewModel ***REMOVED*** RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier ***REMOVED***);
***REMOVED***
***REMOVED***
***REMOVED***

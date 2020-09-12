***REMOVED***
***REMOVED***
using System.IO;
***REMOVED***
***REMOVED***
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace TestAppForGitRepo
***REMOVED***
    public class Program
    ***REMOVED***
        public static void Main(string[] args)
        ***REMOVED***
            CreateWebHostBuilder(args).Build().Run();
***REMOVED***

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
***REMOVED***
***REMOVED***

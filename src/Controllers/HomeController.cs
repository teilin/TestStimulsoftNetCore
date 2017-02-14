using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Stimulsoft.Report.NetCore;
using Microsoft.AspNetCore.Hosting;

namespace WebApplication.Controllers
{
    public class HomeController : Controller
    {
        private readonly IHostingEnvironment _host;

        public HomeController(IHostingEnvironment host)
        {
            _host = host;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }

        public IActionResult GetReport()
        {
            var reportPath = _host.WebRootPath + "\\Reports\\SimpleList.mrt";
            return StiNetCoreViewer.GetReportResult(this, reportPath);
        }
        
        public IActionResult ViewerEvent()
        {
            return StiNetCoreViewer.ViewerEventResult(this);
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspnetLab2.Controllers
{
    public class MyFilesController : Controller
    {
        // GET: Files
        public ActionResult Index()
        {
            //System.Diagnostics.Process[] processes = System.Diagnostics.Process.GetProcesses();//GetProcesses(): get array of processes   
            string[] files = Directory.GetFiles(Server.MapPath("~/Directory"));
            return View(files);
        }


        public new ActionResult Content(string id)
        {
            ViewBag.file = id;
            return View();
        }
    }
}
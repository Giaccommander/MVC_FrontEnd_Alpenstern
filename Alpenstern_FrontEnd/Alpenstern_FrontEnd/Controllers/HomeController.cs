using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Alpenstern_FrontEnd.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Spa()
        {
            

            return View();
        }
        public ActionResult kulinarik()
        {
            return View();
        }
        
        
            protected void btnListSomeFiles_Click(object sender, EventArgs e)
        {
            // Request files with gif, jpg, png, bmp, aspx and vb extension
            // Extensions are separated with | character
            string[] sFiles = getFiles(Server.MapPath("~/Content/images/icons"),
             "*.gif|*.jpg|*.png|*.bmp|*.aspx|*.vb",
             SearchOption.AllDirectories);
            //return View();
        }
        public string[] getFiles(string SourceFolder, string Filter,
System.IO.SearchOption searchOption)
        {
            // ArrayList will hold all file names
            ArrayList alFiles = new ArrayList();

            // Create an array of filter string
            string[] MultipleFilters = Filter.Split('|');

            // for each filter find mathing file names
            foreach (string FileFilter in MultipleFilters)
            {
                // add found file names to array list
                alFiles.AddRange(Directory.GetFiles(SourceFolder, FileFilter, searchOption));
            }

            // returns string array of relevant file names
            return (string[])alFiles.ToArray(typeof(string));
        }
public ActionResult hotel()
        {
            foreach (string FileName in sFiles)
            {
                Response.Write(FileName + "<br />");
            }
        }
       

        public ActionResult rueckruf()
        {
            return View();
        }
    }
}
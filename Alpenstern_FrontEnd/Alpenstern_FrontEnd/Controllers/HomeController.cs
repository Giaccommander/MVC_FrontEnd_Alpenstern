using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Alpenstern_FrontEnd.Models;

namespace Alpenstern_FrontEnd.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
			//GetCarouselImgs
			var db = new alpensternEntities();
			var carouselImgs = new List<CarouselImgVM>();
			foreach (var img in db.get_carousel_imgs.ToList())
				carouselImgs.Add(new CarouselImgVM(img.id, img.bilderart, img.pfad));
			var carouselImgListVM = new CarouselImgListVM(carouselImgs);
            return View(carouselImgListVM);
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
        public ActionResult hotel()
        {
            return View();
        }
        public ActionResult rueckruf()
        {
            return View();
        }
        public ActionResult geschichte()
        {
            return View();
        }
        public ActionResult Anreise()
        {
            return View();
        }
    }
}
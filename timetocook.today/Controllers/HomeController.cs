using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Cook.Models;
using Cook.API;

namespace timetocook.today.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            MyFavoritesModel rmodel = new MyFavoritesModel();
            List<MyFavoritesModel> items = new List<MyFavoritesModel>();
            LatestPageRepository _LatestPagePageRepository = new LatestPageRepository();
            items = _LatestPagePageRepository.GetModel();

            ViewData["MyFavortiesData"] = items;

            string firstOne = null;
            foreach (MyFavoritesModel s in items)
            {
                firstOne = s.Title;
                firstOne = firstOne.Substring(0, 1);
                ViewData["firstOne"] = firstOne;
                break;
            }

            return this.View();


            
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
    }
}
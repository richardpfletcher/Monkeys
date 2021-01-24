using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcRichard.Factory;
using MvcRichard.Models;

namespace comix.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(string chapter)
        {
            
            string[] AgeRagne = new string[] { "Indian Mystics", "Sufi", "Islam", "Jewish", "Western", "Hindu", "Sikh", "Taoist", "Jainism", "Buddhist", "Science", "Current", "Indigenous" };
            ViewData["ethnicData"] = AgeRagne;

            string chap = chapter;
            //LoadKeysHeartOfGold s1 = LoadKeysHeartOfGold.Instance(chapter);
            LoadKeysHeartOfGold s1 = new LoadKeysHeartOfGold(chapter);
            //s1.chapter = chapter;
            List<BookModel> items = LoadKeysHeartOfGold.list;

            String Path = Server.MapPath("/Audio/Books/HeartOfLove");
            String[] FileNames = Directory.GetFiles(Path);

            List<DocumentModel> list = new List<DocumentModel>();

            foreach (var data in items) //iterate the file list
            {
                foreach (string path in FileNames) //iterate the file list
                {
                    string x = path;

                    // Find the last occurrence of N.
                    int index1 = x.LastIndexOf('\\');
                    string fullname = x.Substring(index1 + 1);

                    string shortname = fullname.Substring(0, fullname.Length - 4);

                    if (shortname.ToUpper() == data.Chapter.ToUpper())
                    {
                        list.Add(new DocumentModel(fullname, shortname, "\\Audio\\Books\\HeartOfLove\\" + fullname, "http://www.HeartOfLove.today/Audio/Books/HeartOfLove/" + fullname));
                        break;
                    }
                }
            }

            //InsertRecords myInsertRecords = new InsertRecords();
            //myInsertRecords.loadData(list);


            ViewData["orderData"] = list;

            return View();

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
    }
}
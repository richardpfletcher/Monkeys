using MvcRichard.Factory;
using MvcRichard.Models;
using System;
using System.Collections.Generic;
using System.IO;
//using System.Web.Http;
using System.Web.Mvc;


namespace heartoflove.Controllers
{
    public class BooksController : Controller
    {
        // GET: Books
        public ActionResult Index()
        {
            return View();
        }

        [Route("/{chapter}")]

        public ActionResult HeartOfLove(string chapter)
        {

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

        }

    }
}
using MvcRichard.Factory;
using MvcRichard.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Mail;
//using System.Web.Http;
using System.Web.Mvc;
using heartoflove.Models;
using System.Net;

namespace heartoflove.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(string chapter)
        {

            string[] AgeRagne = new string[] { "Please Select one", "Indian Mystics", "Sufi", "Islam", "Jewish", "Western", "Hindu", "Sikh", "Taoist", "Jainism", "Buddhist", "Science", "Current", "Indigenous" };


            List<SelectListItem> itemsAge = new List<SelectListItem>();
            for (int i = 0; i < AgeRagne.Length; i++)
            {
                

                itemsAge.Add(new SelectListItem { Text = AgeRagne[i], Value = AgeRagne[i] });
            }

            foreach (SelectListItem s in itemsAge)
            {
                if (s.Value == chapter)
                {
                    s.Selected = true;
                }
            }


            ViewData["ethnicData"] = itemsAge;

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
            return PartialView("Index");

            //return View("Index");
            //return View();
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

        [ValidateInput(false)]
        public ActionResult Comments(EmailModel model)
        {
            string emailLoggedIn = "";

            try
            {
                if (Request.IsAuthenticated)
                {
                    //MembershipUser mu = Membership.GetUser();
                    //emailLoggedIn = mu.UserName;
                    emailLoggedIn = User.Identity.Name;
                    model.Email = emailLoggedIn;
                }
            }
            catch
            {
                emailLoggedIn = ""; //user logged in
                //return View(); //user not logeed in
            }

            ViewData["emailLoggedIn"] = emailLoggedIn;

            ViewData["message"] = "";

            if (ModelState.IsValid)
            {
                CommentsPost(model);
            }

            return this.View(model);
        }

        //MenuPlanner

        [ValidateInput(false)]

        public ActionResult CommentsPost(EmailModel model)
        {

            SmtpClient smtpClient = new SmtpClient();
            string EmailFrom = model.Email;
            string EmailTo = "richardpfletcher@gmail.com";

            try
            {
                using (var client = new SmtpClient("smtp.gmail.com"))
                {
                    using (var message = new MailMessage(EmailFrom, EmailTo))
                    {
                        message.Subject = "Heart Of Love Comments from user " + model.Email;
                        message.Body = model.Comments;
                        MailAddress bcc = new MailAddress(EmailFrom);
                        message.CC.Add(bcc);

                        message.IsBodyHtml = true;
                        client.UseDefaultCredentials = false;


                        client.Credentials = new System.Net.NetworkCredential("richardpfletcher@gmail.com", "Barbara_1111");


                        client.EnableSsl = true;
                        client.Send(message);
                    };
                };
            }
            catch (Exception ex)
            {
                string x = ex.ToString();
                throw;
            }

            ViewData["message"] = "Email is sent";

            return RedirectToAction("Index", "Home");
        }


    }
}
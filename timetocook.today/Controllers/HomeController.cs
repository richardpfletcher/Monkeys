using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Cook.Models;
using Cook.API;
using System.Net.Mail;
using heartoflove.Models;

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
                        message.Subject = "Time To Cook Comments from user " + model.Email;
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
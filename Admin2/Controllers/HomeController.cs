﻿
using System.Web.Mvc;
using Stories.Factory;

using Stories.Models;
using Dapper;
//using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Xml.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Stories.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

           
            DropdownModel model = new DropdownModel();
            GetLookups myGetLookups = new GetLookups();


            model = myGetLookups.GeLookupCatUsers(0);
            //model.items.Add(new SelectListItem { Text = "Please Select ", Value = "0" });

            ViewData["newReadersData"] = model.items;


            return View();
        }


        public ActionResult Insert()
        {
            ViewBag.Message = "Your app description page.";

            DropdownModel model = new DropdownModel();
            DropdownModel modelAnimal = new DropdownModel();
            GetLookups myGetLookups = new GetLookups();
            model=myGetLookups.GeLookupAnimal();
            ViewData["animalTypeData"] = model.items;

            Story myStory = new Story();
            myStory.animalCombo = model;

            //modelAnimal = model;

            model = myGetLookups.GeLookupMoral();
            ViewData["moralTypeData"] = model.items;

            model = myGetLookups.GeLookupStorySource();
            ViewData["storySourceData"] = model.items;

            //model = myGetLookups.GeLookupJakataMaster();
            model = myGetLookups.GeLookupJakataMasterFilter();

            ViewData["jakataMasterData"] = model.items;

            model = myGetLookups.GetStoryCategorytName();
            
            ViewData["StoryCategorytNameData"] = model.items;




            return View(myStory);
            
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="row"></param>
        /// <returns></returns>
        public ActionResult Update(int row)
        {
            Story myStory = new Story();
            DropdownModel model = new DropdownModel();
            GetLookups myGetLookups = new GetLookups();
            Story modelStory = new Story();
            modelStory = myGetLookups.GetSpecificStory(row,"JakataID");

            var ID1 = modelStory.ID.ToString();
            ViewData["id"] = ID1;

            var JakataID = modelStory.JakataID;
            var JakataIDString = modelStory.JakataID.ToString();
            ViewData["JakataID"] = JakataIDString;

            var Comments =modelStory.Comments;
            var Moraltype =modelStory.MoralType  ;
            var Stories =modelStory.Stories  ;
            var StoryCategorytName=modelStory.StoryCategorytName ;
            var Title =modelStory.Title ;

            ViewData["comments"] = Comments;
            ViewData["Stories"] = Stories;
            ViewData["searchResults"] = row;





            model = myGetLookups.GeLookupSpecificStoryDropdown();
            //DropdownModel model = new DropdownModel();
            model = myGetLookups.GeLookupAnimal();


            var AnimalType = modelStory.AnimalType;
            
            AnimalType = AnimalType.Trim();

            if (AnimalType.EndsWith(","))
            {
                AnimalType = AnimalType.Remove(AnimalType.Length - 1, 1);
            }

            string[] Animalchosen = AnimalType.Split(',');
            //model = new DropdownModel();

            model = myGetLookups.GeLookupAnimal();

            for (int i = 0; i < Animalchosen.Length; i++)
            {
                var x = Animalchosen[i];


                foreach (SelectListItem s in model.items)
                {
                    if (s.Value == x)
                    {
                        s.Selected = true;
                    }
                }


            }




            ViewData["animalTypeData"] = model.items;

            
            myStory.animalCombo = model;

            GetLookups myYouTubeGetLookups = new GetLookups();
            model = myYouTubeGetLookups.GetYouTube(JakataID,0);
            //ViewData["youTubeData"] = model.items;
            myStory.youTubeCombo = model;




            //modelAnimal = model;
            DropdownModel modelMoral = new DropdownModel();

           //modelMoral = myGetLookups.GeLookupMoral();
            model = myGetLookups.GeLookupMoral();

            var moral = Moraltype.ToString();

            foreach (SelectListItem s in model.items)
            {
                if (s.Value == moral)
                {
                    s.Selected = true;
                }
            }

           
            ViewData["moralTypeData1"] = model.items;

            myStory.moralCombo = model;



            model = myGetLookups.GeLookupStorySource();

            
            var categorytName = myStory.StoryCategorytName.ToString();

            foreach (SelectListItem s in model.items)
            {
                if (s.Value == categorytName)
                {
                    s.Selected = true;

                }
            }
            ViewData["storySourceData"] = model.items;

            model = myGetLookups.GeLookupJakataMaster();

            var title = JakataID.ToString();

            foreach (SelectListItem s in model.items)
            {
                if (s.Value == title)
                {
                    s.Selected = true;
                }
            }
                       

            ViewData["jakataMasterData"] = model.items;


            // titles done
            model = myGetLookups.GetStatus(1);
            ViewData["Done"] = model.items;
            myStory.done = model;

            model = myGetLookups.GetStatus(0);
            myStory.toDo= model;
            ViewData["ToDo"] = model.items;
            myStory.Stories = Stories;

            model = myGetLookups.GetStoryCategorytName();

            StoryCategorytName = modelStory.StoryCategorytName;

            foreach (SelectListItem s in model.items)
            {
                if (s.Value == StoryCategorytName.ToString())
                {
                    s.Selected = true;
                    modelStory.StoryCategorytNameString = s.Text;

                    if (s.Value == "0")
                    {
                        modelStory.StoryCategorytNameString = "";
                    }
                }
            }

            myStory.StoryCategorytNameCombo= model;

           

            return View(myStory);
        }

        public ActionResult UpdateStory()
        {
            ViewBag.Message = "Your app description page.";
            DropdownModel model = new DropdownModel();
            DropdownModel model1 = new DropdownModel();
            GetLookups myGetLookups = new GetLookups();

            //model = myGetLookups.GeLookupSpecificStoryDropdown();
            //ViewData["jakataMasterData"] = model.items;
            ViewData["jakataMasterData"] = model1.items;

            model = myGetLookups.GetStoryCategorytName();

            ViewData["StoryCategorytNameData"] = model.items;


            return View();
        }

        public ActionResult UpdateProject()
        {
            ViewBag.Message = "Your app description page.";
            DropdownModel model = new DropdownModel();
            GetLookups myGetLookups = new GetLookups();

            model = myGetLookups.GeLookupSpecificStoryDropdown();
            //ViewData["jakataMasterData"] = model.items;


            DropdownModel model1 = new DropdownModel();
            model = myGetLookups.GeLookupCatUsers(2);
            model.items.Add(new SelectListItem { Text = "Please Select ", Value = "0" });

            //model.items.Add

            ViewData["newReadersData"] = model.items;

            DropdownModel modelExisting = new DropdownModel();
            ViewData["existingReaderData"] = modelExisting.items;


            //model = myGetLookups.GeLookupSpecificStoryDropdown();
            //ViewData["jakataMasterData"] = model.items;
            ViewData["jakataMasterData"] = model1.items;

            model = myGetLookups.GetStoryCategorytName();

            ViewData["StoryCategorytNameData"] = model.items;

            //var message = "";
            //ViewData["Message"] = message;
        
            //if (model.items.Count>0)
            //{
            //    ViewData["Message"] = "No Records to input";
            //}

            







            return View();
        }

        [HttpPost]

        public ActionResult Project(int row,int userID,string userName,string mode)
        {
            

            ViewBag.Title = "Project";
            Story myStory = new Story();
            myStory.userName = userName;
            myStory.userID = userID;
            ViewData["userID"] = userID;
            myStory.Mode = mode;
            ViewData["Mode"] = mode;

            DropdownModel model = new DropdownModel();
            DropdownModel modelAnimal = new DropdownModel();
            GetLookups myGetLookups = new GetLookups();
            model = myGetLookups.GeLookupPosted();
            myStory.Posted = model;
            myStory = myGetLookups.GetReaderstory(row, userID);

            //var title = JakataID.ToString();

            foreach (SelectListItem s in model.items)
            {
                if (s.Value == myStory.PostedString)
                {
                    s.Selected = true;
                }
            }



            ViewData["postedData"] = model.items;

            //ilustrators

            //model = myGetLookups.GeLookupCatUsers(1);
            model = myGetLookups.GeLookupCatUsers(1);

            if (mode == "edit")
            {

                var IllustrationType = myStory.Illustrations;

                IllustrationType = IllustrationType.Trim();

                if (IllustrationType.EndsWith(","))
                {
                    IllustrationType = IllustrationType.Remove(IllustrationType.Length - 1, 1);
                }

                string[] Illustrationchosen = IllustrationType.Split(',');
                //model = new DropdownModel();

                //model = myGetLookups.GeLookupAnimal();
               

                for (int i = 0; i < Illustrationchosen.Length; i++)
                {
                    var x = Illustrationchosen[i];


                    foreach (SelectListItem s in model.items)
                    {
                        if (s.Value == x)
                        {
                            s.Selected = true;
                        }
                    }


                }

                //ViewData["animalTypeData"] = model.items;

                myStory.IllustrationsCombo = model;

            }
            myStory.IllustrationsCombo = model;

            //ViewData["IllustrationsData"] = model.items;
            model = myGetLookups.GeLookupCatUsers(2);
            myStory.ReadersCombo = model;
            //ViewData["ReadersData"] = model.items;
            //model = myGetLookups.GeLookupCatUsers(3);
            model = myGetLookups.GeLookupCatUsers(3);

            if (mode == "edit")
            {

                var MusicType = myStory.Music;

                MusicType = MusicType.Trim();

                if (MusicType.EndsWith(","))
                {
                    MusicType = MusicType.Remove(MusicType.Length - 1, 1);
                }

                string[] Musicchosen = MusicType.Split(',');
                //model = new DropdownModel();

                //model = myGetLookups.GeLookupAnimal();
                //model = myGetLookups.GeLookupCatUsers(3);

                for (int i = 0; i < Musicchosen.Length; i++)
                {
                    var x = Musicchosen[i];


                    foreach (SelectListItem s in model.items)
                    {
                        if (s.Value == x)
                        {
                            s.Selected = true;
                        }
                    }


                }

                //ViewData["animalTypeData"] = model.items;

               

                myStory.MusicCombo = model;
            }

            myStory.MusicCombo = model;
            //ViewData["MusicData"] = model.items;
            model = myGetLookups.GeLookupCatUsers(4);
            if (mode == "edit")
            {

                myStory.DanceCombo = model;

                var DanceType = myStory.Dance;

                DanceType = DanceType.Trim();

                if (DanceType.EndsWith(","))
                {
                    DanceType = DanceType.Remove(DanceType.Length - 1, 1);
                }

                string[] Dancechosen = DanceType.Split(',');
                //model = new DropdownModel();

                //model = myGetLookups.GeLookupAnimal();
                //model = myGetLookups.GeLookupCatUsers(1);

                for (int i = 0; i < Dancechosen.Length; i++)
                {
                    var x = Dancechosen[i];


                    foreach (SelectListItem s in model.items)
                    {
                        if (s.Value == x)
                        {
                            s.Selected = true;
                        }
                    }


                }
            }
            //ViewData["animalTypeData"] = model.items;

            myStory.DanceCombo = model;



            //ViewData["DanceData"] = model.items;
            model = myGetLookups.GeLookupCatUsers(5);
            myStory.AdminCombo = model;
            //ViewData["AdminData"] = model.items;

            model = myGetLookups.GeLookupJakataMaster();
            ViewData["jakataMasterData"] = model.items;

            model = myGetLookups.GeLookupStorySource();
            var categorytName = myStory.StoryCategorytName.ToString();

            foreach (SelectListItem s in model.items)
            {
                if (s.Value == categorytName)
                {
                    s.Selected = true;

                }
            }



            ViewData["storySourceData"] = model.items;

            model = myGetLookups.GeLookupJakataMaster();

            
            Story modelStory = new Story();
            modelStory = myGetLookups.GetSpecificStory(row,"jakataID");

            var ID1 = modelStory.ID.ToString();
            ViewData["id"] = ID1;

            var JakataID = modelStory.JakataID;
            var JakataIDString = modelStory.JakataID.ToString();
            ViewData["JakataID"] = JakataIDString;

            var title = JakataID.ToString();

            foreach (SelectListItem s in model.items)
            {
                if (s.Value == title)
                {
                    s.Selected = true;
                    myStory.TitleString = s.Text;
                }
            }

            GetLookups myYouTubeGetLookups = new GetLookups();
            model = myYouTubeGetLookups.GetYouTube(JakataID, userID);
            //ViewData["youTubeData"] = model.items;
            myStory.youTubeCombo = model;





            ViewData["jakataMasterData"] = model.items;


            //myStory.Posted = "0";

            if (mode == "edit")
            {
                ViewData["saved"] = "save";

            }
            else
            {
                ViewData["saved"] = "no";

            }

                return View(myStory);
        }
       
        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult UploadPicture(FormCollection form)
        {
            System.Web.HttpPostedFileBase httpPostedFileBase = base.Request.Files["FileData"];
            string userID = base.Request.Form["idPhoto"];
            string comments = base.Request.Form["comments"];
            string filename1 = httpPostedFileBase.FileName;
            string text2 = base.Server.MapPath("~/images/upload/" + System.IO.Path.GetFileName(httpPostedFileBase.FileName));
            string value = string.Empty;
            string text3 = System.IO.Path.GetExtension(httpPostedFileBase.FileName);
            text3 = text3.ToLower();
            GetStories myGetStories = new GetStories();
           
            ViewData["filename1"] = filename1;


            if (userID == "" || userID ==null)
            {
                return RedirectToAction("..\\Home");

            }

            var email = myGetStories.GetMothersEmail(Convert.ToInt16(userID));


            if (text3 == ".jpg" || text3 == ".gif" || text3 == ".png" || text3 == ".mp3" || text3 == ".mp4")
            {
                if (httpPostedFileBase.ContentLength > 0)
                {
                    //string filename = base.Server.MapPath("/images/upload/" + text + text3);
                    string filename = base.Server.MapPath("/images/upload/" + filename1);
                    httpPostedFileBase.SaveAs(filename);
                    
                    DynamicParameters dynamicParameters = new DynamicParameters();


                    dynamicParameters.Add("@Comments", comments, null, null, null);
                    dynamicParameters.Add("@fileName", filename1, null, null, null);

                    dynamicParameters.Add("@userID", System.Convert.ToInt16(userID), null, null, null);
                    ConnectionStringSettings connectionStringSettings = ConfigurationManager.ConnectionStrings["LocalStory"];
                    string connectionString = connectionStringSettings.ConnectionString;

                    using (System.Data.SqlClient.SqlConnection sqlConnection = new System.Data.SqlClient.SqlConnection(connectionString))
                    {
                        sqlConnection.Open();
                        const string storedProcedure = "dbo.InsertPicture";
                        var values = sqlConnection.Query<ReceipeTotalModel>(storedProcedure, dynamicParameters, commandType: CommandType.StoredProcedure);
                    }

                    using (MailMessage mail = new MailMessage())
                    {
                        mail.From = new MailAddress("JatakaFun@gmail.com");
                        mail.To.Add(email);
                        mail.Subject = "Thank you for your work";
                        mail.Body = "<h2>Thanks for uploading your file "+ filename1+" </h2>";
                        mail.IsBodyHtml = true;
                        //mail.Attachments.Add(new Attachment("C:\\file.zip"));

                        using (SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587))
                        {
                            smtp.UseDefaultCredentials = false;
                            smtp.EnableSsl = true;
                            smtp.Credentials = new NetworkCredential("JatakaFun@gmail.com", "3Monkeys!");
                            smtp.Send(mail);
                        }
                    }


                    return View();
                }
                else
                {
                    
                    return RedirectToAction("..\\Home");

                }

            }
           
            return View();
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult UpdateUser(FormCollection form)
        {
            string userID = base.Request.Form["idPhoto"];
            ViewData["userID"] = userID;

            GetStories myGetStories = new GetStories();
            var email = myGetStories.GetMothersEmail(Convert.ToInt16(userID));

            //if (email =="")
            //{
            //    email = "Enter the email address";
            //}
            
            ViewData["email"] = email.ToString();
            string userName = base.Request.Form["userName"];
            //ViewData["userName"] = userName;

            MothersHelpersSpecificList myMothersHelpersSpecificList = new MothersHelpersSpecificList();
            myMothersHelpersSpecificList = myGetStories.GetMothersHelpersTypeSpecific(Convert.ToInt16(userID));

           

            DropdownModel model = new DropdownModel();
            GetLookups myGetLookups = new GetLookups();

            Story myStory = new Story();
            myStory.userName = userName;

            model = myGetLookups.GetMothersHelpersType();

            for (int i = 0; i < myMothersHelpersSpecificList.mothersHelpersSpecificLists.Count; i++)
            {
                var x = myMothersHelpersSpecificList.mothersHelpersSpecificLists[i].MothersHelpersType;


                foreach (SelectListItem s in model.items)
                {
                    if (s.Value == x)
                    {
                        s.Selected = true;
                    }
                }


            }


            ViewData["MothersHelpersTypeData"] = model.items;
            myStory.MothersHelpersTypeCombo = model;




            return View(myStory);

        }

        public ActionResult NewUser()
        {
            ViewBag.Message = "Your app description page.";
            DropdownModel model = new DropdownModel();
            GetLookups myGetLookups = new GetLookups();
            GetStories myGetStories = new GetStories();
            MothersHelpersSpecificList myMothersHelpersSpecificList = new MothersHelpersSpecificList();
            myMothersHelpersSpecificList = myGetStories.GetMothersHelpersTypeSpecific(0);
            Story myStory = new Story();

            model = myGetLookups.GetMothersHelpersType();
            myStory.MothersHelpersTypeCombo = model;

            return View(myStory);


        }


        public ActionResult User()
        {
            ViewBag.Message = "Your app description page.";

            DropdownModel model = new DropdownModel();
            GetLookups myGetLookups = new GetLookups();


            model = myGetLookups.GeLookupCatUsers(0);
            //model.items.Add(new SelectListItem { Text = "Please Select ", Value = "0" });

            ViewData["newReadersData"] = model.items;



            return View();
        }

        public ActionResult NewAnimals()
        {
            //ViewBag.Message = "Your app description page.";
            //DropdownModel model = new DropdownModel();
            //GetLookups myGetLookups = new GetLookups();
            //GetStories myGetStories = new GetStories();
            //MothersHelpersSpecificList myMothersHelpersSpecificList = new MothersHelpersSpecificList();
            //myMothersHelpersSpecificList = myGetStories.GetMothersHelpersTypeSpecific(0);
            //Story myStory = new Story();

            //model = myGetLookups.GetMothersHelpersType();
            //myStory.MothersHelpersTypeCombo = model;

            return View();


        }

        public ActionResult NewCategory()
        {
            //ViewBag.Message = "Your app description page.";
            //DropdownModel model = new DropdownModel();
            //GetLookups myGetLookups = new GetLookups();
            //GetStories myGetStories = new GetStories();
            //MothersHelpersSpecificList myMothersHelpersSpecificList = new MothersHelpersSpecificList();
            //myMothersHelpersSpecificList = myGetStories.GetMothersHelpersTypeSpecific(0);
            //Story myStory = new Story();

            //model = myGetLookups.GetMothersHelpersType();
            //myStory.MothersHelpersTypeCombo = model;

            return View();


        }


        public ActionResult Animals()
        {
            ViewBag.Message = "Your app description page.";

            DropdownModel model = new DropdownModel();
            GetLookups myGetLookups = new GetLookups();
            model = myGetLookups.GeLookupAnimal();



            //ViewData["animalTypeData"] = model.items;



            //model = myGetLookups.GeLookupCatUsers(0);
            //model.items.Add(new SelectListItem { Text = "Please Select ", Value = "0" });

            ViewData["newReadersData"] = model.items;



            return View();
        }

        public ActionResult NewMorals()
        {
            ViewBag.Message = "Your app description page.";
            //DropdownModel model = new DropdownModel();
            //GetLookups myGetLookups = new GetLookups();
            //GetStories myGetStories = new GetStories();
            //MothersHelpersSpecificList myMothersHelpersSpecificList = new MothersHelpersSpecificList();
            //myMothersHelpersSpecificList = myGetStories.GetMothersHelpersTypeSpecific(0);
            //Story myStory = new Story();

            //model = myGetLookups.GetMothersHelpersType();
            //myStory.MothersHelpersTypeCombo = model;

            return View();


        }


        public ActionResult Morals()
        {
            ViewBag.Message = "Your app description page.";

            DropdownModel model = new DropdownModel();
            GetLookups myGetLookups = new GetLookups();
            model = myGetLookups.GeLookupMoral();

            //ViewData["animalTypeData"] = model.items;



            //model = myGetLookups.GeLookupCatUsers(0);
            //model.items.Add(new SelectListItem { Text = "Please Select ", Value = "0" });

            ViewData["newReadersData"] = model.items;



            return View();
        }

        public ActionResult NewJatakaMaster()
        {
            ViewBag.Message = "Your app description page.";
            //DropdownModel model = new DropdownModel();
            //GetLookups myGetLookups = new GetLookups();
            //GetStories myGetStories = new GetStories();
            //MothersHelpersSpecificList myMothersHelpersSpecificList = new MothersHelpersSpecificList();
            //myMothersHelpersSpecificList = myGetStories.GetMothersHelpersTypeSpecific(0);
            //Story myStory = new Story();

            //model = myGetLookups.GetMothersHelpersType();
            //myStory.MothersHelpersTypeCombo = model;

            return View();


        }


        public ActionResult JatakaMaster()
        {
            ViewBag.Message = "Your app description page.";

            DropdownModel model = new DropdownModel();
            GetLookups myGetLookups = new GetLookups();
            model = myGetLookups.GeLookupJakataMaster();

            //ViewData["animalTypeData"] = model.items;



            //model = myGetLookups.GeLookupCatUsers(0);
            //model.items.Add(new SelectListItem { Text = "Please Select ", Value = "0" });

            ViewData["newReadersData"] = model.items;



            return View();
        }

        public ActionResult BookGenerator()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }
    }
}

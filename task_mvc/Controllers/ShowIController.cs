using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace task_mvc.Controllers
{
    public class ShowIController : Controller
    {
        // GET: ShowI
        public ActionResult GetImage()

        {
            string imgPath = Server.MapPath("~/Content/Images/im.jpg");
            byte[] bytedata = System.IO.File.ReadAllBytes(imgPath);
            string imgBase64Data = Convert.ToBase64String(bytedata);
            string imgDataURL = string.Format("data:image/jpg;base64,{0}", imgBase64Data);
            ViewBag.ImageData = imgDataURL;
            return View();
        }
    }
}
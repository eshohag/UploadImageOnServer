using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using UploadImageOnServer.Context;
using UploadImageOnServer.Models;

namespace UploadImageOnServer.Controllers
{
    public class HomeController : Controller
    {
        ApplicationDbContext db = new ApplicationDbContext();

        public ActionResult AddImage()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddImage(Brand model, HttpPostedFileBase image1)
        {
            if (image1 != null)
            {
                model.BrandImage = new byte[image1.ContentLength];
                image1.InputStream.Read(model.BrandImage, 0, image1.ContentLength);
                string fileName = image1.FileName;
                model.FileName = fileName;
                string fileType = image1.ContentType;
                model.FileType = fileType;
                if (fileType.ToLower() == "image/jpeg" || fileType.ToLower() == "image/png")
                {
                    db.Brands.Add(model);
                    db.SaveChanges();
                    ViewBag.Success = "Upload Successfully";
                }
                else
                {
                    ViewBag.Message = "Invalid Image Formate";
                }


            }
            return View();
        }


        public ActionResult GetAll()
        {
            var allImage = db.Brands.ToList();

            return View(allImage);
        }

    }
}
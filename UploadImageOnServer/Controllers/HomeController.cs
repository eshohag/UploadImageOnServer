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
        public ActionResult AddImage(ImageUpload model, HttpPostedFileBase image1)
        {
            if (image1 != null)
            {
                model.BinaryDataImage = new byte[image1.ContentLength];
                image1.InputStream.Read(model.BinaryDataImage, 0, image1.ContentLength);
                string fileName = image1.FileName;
                model.FileName = fileName;
                string fileType = image1.ContentType;
                model.FileType = fileType;
                if (image1.ContentLength < 1024 * 1024)
                {
                    if (fileType.ToLower() == "image/jpeg" || fileType.ToLower() == "image/png")
                    {
                        db.ImageUploads.Add(model);
                        db.SaveChanges();
                        ViewBag.Success = "Upload Successfully";
                    }
                    else
                    {
                        ViewBag.Message = "Invalid Image Formate";
                    }
                }
                else
                {
                    ViewBag.Message = "File Size only 1MB";
                }
            }
            else
            {
                ViewBag.Message = "Please Select Your Image File";
            }
            return View();
        }

        public ActionResult GetAll()
        {
            var allImage = db.ImageUploads.ToList();
            return View(allImage);
        }

    }
}
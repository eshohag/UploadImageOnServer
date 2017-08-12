using System.ComponentModel.DataAnnotations;

namespace UploadImageOnServer.Models
{
    public class ImageUpload
    {
        public int ImageUploadID { get; set; }
        public string FileName { get; set; }
        public string FileType { get; set; }
        [Display(Name = "Select Your Image")]

        public byte[] BinaryDataImage { get; set; }
    }
}
namespace UploadImageOnServer.Models
{
    public class Brand
    {
        public int BrandID { get; set; }
        public string FileName { get; set; }
        public string FileType { get; set; }

        public byte[] BrandImage { get; set; }
    }
}
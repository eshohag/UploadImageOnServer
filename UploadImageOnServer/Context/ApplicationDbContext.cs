using System.Data.Entity;
using UploadImageOnServer.Models;

namespace UploadImageOnServer.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() : base("ImageDBConnection")
        {

        }

        public DbSet<ImageUpload> ImageUploads { get; set; }
    }
}
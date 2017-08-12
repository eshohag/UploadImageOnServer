namespace UploadImageOnServer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ImageFinal : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ImageUploads",
                c => new
                    {
                        ImageUploadID = c.Int(nullable: false, identity: true),
                        FileName = c.String(),
                        FileType = c.String(),
                        BinaryDataImage = c.Binary(),
                    })
                .PrimaryKey(t => t.ImageUploadID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ImageUploads");
        }
    }
}

namespace UploadImageOnServer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ImageState : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Brands", "FileName", c => c.String());
            AddColumn("dbo.Brands", "FileType", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Brands", "FileType");
            DropColumn("dbo.Brands", "FileName");
        }
    }
}

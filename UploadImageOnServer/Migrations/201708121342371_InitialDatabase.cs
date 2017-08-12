namespace UploadImageOnServer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialDatabase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Brands",
                c => new
                    {
                        BrandID = c.Int(nullable: false, identity: true),
                        BrandImage = c.Binary(),
                    })
                .PrimaryKey(t => t.BrandID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Brands");
        }
    }
}

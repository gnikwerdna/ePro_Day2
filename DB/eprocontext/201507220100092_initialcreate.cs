namespace ePro.DB.eprocontext
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initialcreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Files",
                c => new
                    {
                        FileID = c.Int(nullable: false, identity: true),
                        FileName = c.String(),
                        Description = c.String(),
                        FilePath = c.String(),
                        FileSize = c.Int(nullable: false),
                        ProductListingID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.FileID)
                .ForeignKey("dbo.ProductListings", t => t.ProductListingID, cascadeDelete: true)
                .Index(t => t.ProductListingID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Files", "ProductListingID", "dbo.ProductListings");
            DropIndex("dbo.Files", new[] { "ProductListingID" });
            DropTable("dbo.Files");
        }
    }
}

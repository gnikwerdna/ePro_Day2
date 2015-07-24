namespace ePro.DB.eprocontext
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initialcreate2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ProductFiles",
                c => new
                    {
                        ProductFileID = c.Int(nullable: false, identity: true),
                        Description = c.String(nullable: false),
                        ProductListingID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ProductFileID)
                .ForeignKey("dbo.ProductListings", t => t.ProductListingID, cascadeDelete: true)
                .Index(t => t.ProductListingID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ProductFiles", "ProductListingID", "dbo.ProductListings");
            DropIndex("dbo.ProductFiles", new[] { "ProductListingID" });
            DropTable("dbo.ProductFiles");
        }
    }
}

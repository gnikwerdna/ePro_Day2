namespace ePro.DB.eprocontext
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initialcreate13 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Files", "ProductListing_ProductListingID", "dbo.ProductListings");
            DropIndex("dbo.Files", new[] { "ProductListing_ProductListingID" });
            RenameColumn(table: "dbo.Files", name: "ProductListing_ProductListingID", newName: "ProductListingID");
            AlterColumn("dbo.Files", "ProductListingID", c => c.Int(nullable: false));
            CreateIndex("dbo.Files", "ProductListingID");
            AddForeignKey("dbo.Files", "ProductListingID", "dbo.ProductListings", "ProductListingID", cascadeDelete: true);
            DropColumn("dbo.Files", "PersonId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Files", "PersonId", c => c.Int(nullable: false));
            DropForeignKey("dbo.Files", "ProductListingID", "dbo.ProductListings");
            DropIndex("dbo.Files", new[] { "ProductListingID" });
            AlterColumn("dbo.Files", "ProductListingID", c => c.Int());
            RenameColumn(table: "dbo.Files", name: "ProductListingID", newName: "ProductListing_ProductListingID");
            CreateIndex("dbo.Files", "ProductListing_ProductListingID");
            AddForeignKey("dbo.Files", "ProductListing_ProductListingID", "dbo.ProductListings", "ProductListingID");
        }
    }
}

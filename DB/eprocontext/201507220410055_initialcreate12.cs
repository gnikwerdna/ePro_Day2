namespace ePro.DB.eprocontext
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initialcreate12 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Files", "ProductListingID", "dbo.ProductListings");
            DropIndex("dbo.Files", new[] { "ProductListingID" });
            RenameColumn(table: "dbo.Files", name: "ProductListingID", newName: "ProductListing_ProductListingID");
            AddColumn("dbo.Files", "ContentType", c => c.String(maxLength: 100));
            AddColumn("dbo.Files", "Content", c => c.Binary());
            AddColumn("dbo.Files", "FileType", c => c.Int(nullable: false));
            AddColumn("dbo.Files", "PersonId", c => c.Int(nullable: false));
            AlterColumn("dbo.Files", "FileName", c => c.String(maxLength: 255));
            AlterColumn("dbo.Files", "ProductListing_ProductListingID", c => c.Int());
            CreateIndex("dbo.Files", "ProductListing_ProductListingID");
            AddForeignKey("dbo.Files", "ProductListing_ProductListingID", "dbo.ProductListings", "ProductListingID");
            DropColumn("dbo.Files", "Description");
            DropColumn("dbo.Files", "FilePath");
            DropColumn("dbo.Files", "FileSize");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Files", "FileSize", c => c.Int(nullable: false));
            AddColumn("dbo.Files", "FilePath", c => c.String());
            AddColumn("dbo.Files", "Description", c => c.String());
            DropForeignKey("dbo.Files", "ProductListing_ProductListingID", "dbo.ProductListings");
            DropIndex("dbo.Files", new[] { "ProductListing_ProductListingID" });
            AlterColumn("dbo.Files", "ProductListing_ProductListingID", c => c.Int(nullable: false));
            AlterColumn("dbo.Files", "FileName", c => c.String());
            DropColumn("dbo.Files", "PersonId");
            DropColumn("dbo.Files", "FileType");
            DropColumn("dbo.Files", "Content");
            DropColumn("dbo.Files", "ContentType");
            RenameColumn(table: "dbo.Files", name: "ProductListing_ProductListingID", newName: "ProductListingID");
            CreateIndex("dbo.Files", "ProductListingID");
            AddForeignKey("dbo.Files", "ProductListingID", "dbo.ProductListings", "ProductListingID", cascadeDelete: true);
        }
    }
}

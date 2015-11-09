using System;
using System.Data.Entity.Migrations;

public partial class Init : DbMigration
{
    public override void Up()
    {
        CreateTable(
            "dbo.Clients",
            c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    ClientLocation_City = c.String(),
                    ClientLocation_Address = c.String(),
                    Person_FirstName = c.String(),
                    Person_MiddleName = c.String(),
                    Person_LastName = c.String(),
                    Date = c.DateTime(nullable: false),
                    IsActive = c.Boolean(nullable: false),
                })
            .PrimaryKey(t => t.Id);
        
        CreateTable(
            "dbo.Comments",
            c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Text = c.String(),
                    EntityType = c.Int(nullable: false),
                    Date = c.DateTime(nullable: false),
                    IsActive = c.Boolean(nullable: false),
                    Author_Id = c.Int(),
                    Client_Id = c.Int(),
                    Order_Id = c.Int(),
                    Category_Id = c.Int(),
                    Product_Id = c.Int(),
                })
            .PrimaryKey(t => t.Id)
            .ForeignKey("dbo.Users", t => t.Author_Id)
            .ForeignKey("dbo.Clients", t => t.Client_Id)
            .ForeignKey("dbo.Orders", t => t.Order_Id)
            .ForeignKey("dbo.Categories", t => t.Category_Id)
            .ForeignKey("dbo.Products", t => t.Product_Id)
            .Index(t => t.Author_Id)
            .Index(t => t.Client_Id)
            .Index(t => t.Order_Id)
            .Index(t => t.Category_Id)
            .Index(t => t.Product_Id);
        
        CreateTable(
            "dbo.Users",
            c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Login = c.String(),
                    Password = c.String(),
                    Person_FirstName = c.String(),
                    Person_MiddleName = c.String(),
                    Person_LastName = c.String(),
                    Date = c.DateTime(nullable: false),
                    IsActive = c.Boolean(nullable: false),
                    Role_Id = c.Int(),
                })
            .PrimaryKey(t => t.Id)
            .ForeignKey("dbo.Roles", t => t.Role_Id)
            .Index(t => t.Role_Id);
        
        CreateTable(
            "dbo.Roles",
            c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Title = c.String(),
                    IsActive = c.Boolean(nullable: false),
                })
            .PrimaryKey(t => t.Id);
        
        CreateTable(
            "dbo.Permissions",
            c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Title = c.String(),
                    Description = c.String(),
                    IsActive = c.Boolean(nullable: false),
                })
            .PrimaryKey(t => t.Id);
        
        CreateTable(
            "dbo.Telephones",
            c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Number = c.String(),
                    IsActive = c.Boolean(nullable: false),
                    Client_Id = c.Int(),
                })
            .PrimaryKey(t => t.Id)
            .ForeignKey("dbo.Clients", t => t.Client_Id)
            .Index(t => t.Client_Id);
        
        CreateTable(
            "dbo.Orders",
            c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Status = c.Int(nullable: false),
                    OrderNumber = c.String(),
                    Date = c.DateTime(nullable: false),
                    IsActive = c.Boolean(nullable: false),
                    Client_Id = c.Int(),
                })
            .PrimaryKey(t => t.Id)
            .ForeignKey("dbo.Clients", t => t.Client_Id)
            .Index(t => t.Client_Id);
        
        CreateTable(
            "dbo.OrderItems",
            c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Quantity = c.Int(nullable: false),
                    Price = c.Double(nullable: false),
                    IsActive = c.Boolean(nullable: false),
                    Order_Id = c.Int(),
                    Product_Id = c.Int(),
                })
            .PrimaryKey(t => t.Id)
            .ForeignKey("dbo.Orders", t => t.Order_Id)
            .ForeignKey("dbo.Products", t => t.Product_Id)
            .Index(t => t.Order_Id)
            .Index(t => t.Product_Id);
        
        CreateTable(
            "dbo.Products",
            c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Quantity = c.Int(nullable: false),
                    Price = c.Double(nullable: false),
                    Title = c.String(),
                    SKU = c.String(),
                    Date = c.DateTime(nullable: false),
                    IsActive = c.Boolean(nullable: false),
                    Category_Id = c.Int(),
                })
            .PrimaryKey(t => t.Id)
            .ForeignKey("dbo.Categories", t => t.Category_Id)
            .Index(t => t.Category_Id);
        
        CreateTable(
            "dbo.Categories",
            c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Title = c.String(),
                    Date = c.DateTime(nullable: false),
                    IsActive = c.Boolean(nullable: false),
                })
            .PrimaryKey(t => t.Id);
        
        CreateTable(
            "dbo.PermissionRoles",
            c => new
                {
                    Permission_Id = c.Int(nullable: false),
                    Role_Id = c.Int(nullable: false),
                })
            .PrimaryKey(t => new { t.Permission_Id, t.Role_Id })
            .ForeignKey("dbo.Permissions", t => t.Permission_Id, cascadeDelete: true)
            .ForeignKey("dbo.Roles", t => t.Role_Id, cascadeDelete: true)
            .Index(t => t.Permission_Id)
            .Index(t => t.Role_Id);
        
    }
    
    public override void Down()
    {
        DropForeignKey("dbo.OrderItems", "Product_Id", "dbo.Products");
        DropForeignKey("dbo.Comments", "Product_Id", "dbo.Products");
        DropForeignKey("dbo.Products", "Category_Id", "dbo.Categories");
        DropForeignKey("dbo.Comments", "Category_Id", "dbo.Categories");
        DropForeignKey("dbo.OrderItems", "Order_Id", "dbo.Orders");
        DropForeignKey("dbo.Comments", "Order_Id", "dbo.Orders");
        DropForeignKey("dbo.Orders", "Client_Id", "dbo.Clients");
        DropForeignKey("dbo.Telephones", "Client_Id", "dbo.Clients");
        DropForeignKey("dbo.Comments", "Client_Id", "dbo.Clients");
        DropForeignKey("dbo.Comments", "Author_Id", "dbo.Users");
        DropForeignKey("dbo.Users", "Role_Id", "dbo.Roles");
        DropForeignKey("dbo.PermissionRoles", "Role_Id", "dbo.Roles");
        DropForeignKey("dbo.PermissionRoles", "Permission_Id", "dbo.Permissions");
        DropIndex("dbo.PermissionRoles", new[] { "Role_Id" });
        DropIndex("dbo.PermissionRoles", new[] { "Permission_Id" });
        DropIndex("dbo.Products", new[] { "Category_Id" });
        DropIndex("dbo.OrderItems", new[] { "Product_Id" });
        DropIndex("dbo.OrderItems", new[] { "Order_Id" });
        DropIndex("dbo.Orders", new[] { "Client_Id" });
        DropIndex("dbo.Telephones", new[] { "Client_Id" });
        DropIndex("dbo.Users", new[] { "Role_Id" });
        DropIndex("dbo.Comments", new[] { "Product_Id" });
        DropIndex("dbo.Comments", new[] { "Category_Id" });
        DropIndex("dbo.Comments", new[] { "Order_Id" });
        DropIndex("dbo.Comments", new[] { "Client_Id" });
        DropIndex("dbo.Comments", new[] { "Author_Id" });
        DropTable("dbo.PermissionRoles");
        DropTable("dbo.Categories");
        DropTable("dbo.Products");
        DropTable("dbo.OrderItems");
        DropTable("dbo.Orders");
        DropTable("dbo.Telephones");
        DropTable("dbo.Permissions");
        DropTable("dbo.Roles");
        DropTable("dbo.Users");
        DropTable("dbo.Comments");
        DropTable("dbo.Clients");
    }
}

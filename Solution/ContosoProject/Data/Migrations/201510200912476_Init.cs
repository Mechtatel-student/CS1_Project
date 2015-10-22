using System.Data.Entity.Migrations;

namespace Data.Migrations
{
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
                        ClientLocation_Adress = c.String(),
                        Person_FirstName = c.String(),
                        Person_MiddleName = c.String(),
                        Person_LastName = c.String(),
                        Date = c.DateTime(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                        Operator_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.Operator_Id)
                .Index(t => t.Operator_Id);
            
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
                        Operator_Id = c.Int(),
                        Role_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.Operator_Id)
                .ForeignKey("dbo.Roles", t => t.Role_Id)
                .Index(t => t.Operator_Id)
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
                        Role_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Roles", t => t.Role_Id)
                .Index(t => t.Role_Id);
            
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
                        Operator_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Clients", t => t.Client_Id)
                .ForeignKey("dbo.Users", t => t.Operator_Id)
                .Index(t => t.Client_Id)
                .Index(t => t.Operator_Id);
            
            CreateTable(
                "dbo.OrderItems",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Quantity = c.Int(nullable: false),
                        Price = c.Double(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                        Product_Id = c.Int(),
                        Order_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Products", t => t.Product_Id)
                .ForeignKey("dbo.Orders", t => t.Order_Id)
                .Index(t => t.Product_Id)
                .Index(t => t.Order_Id);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Price = c.Double(nullable: false),
                        Title = c.String(),
                        SKU = c.String(),
                        Date = c.DateTime(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                        Category_Id = c.Int(),
                        Operator_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categories", t => t.Category_Id)
                .ForeignKey("dbo.Users", t => t.Operator_Id)
                .Index(t => t.Category_Id)
                .Index(t => t.Operator_Id);
            
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Date = c.DateTime(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                        Operator_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.Operator_Id)
                .Index(t => t.Operator_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.OrderItems", "Order_Id", "dbo.Orders");
            DropForeignKey("dbo.OrderItems", "Product_Id", "dbo.Products");
            DropForeignKey("dbo.Products", "Operator_Id", "dbo.Users");
            DropForeignKey("dbo.Products", "Category_Id", "dbo.Categories");
            DropForeignKey("dbo.Categories", "Operator_Id", "dbo.Users");
            DropForeignKey("dbo.Orders", "Operator_Id", "dbo.Users");
            DropForeignKey("dbo.Orders", "Client_Id", "dbo.Clients");
            DropForeignKey("dbo.Clients", "Operator_Id", "dbo.Users");
            DropForeignKey("dbo.Users", "Role_Id", "dbo.Roles");
            DropForeignKey("dbo.Permissions", "Role_Id", "dbo.Roles");
            DropForeignKey("dbo.Users", "Operator_Id", "dbo.Users");
            DropIndex("dbo.Categories", new[] { "Operator_Id" });
            DropIndex("dbo.Products", new[] { "Operator_Id" });
            DropIndex("dbo.Products", new[] { "Category_Id" });
            DropIndex("dbo.OrderItems", new[] { "Order_Id" });
            DropIndex("dbo.OrderItems", new[] { "Product_Id" });
            DropIndex("dbo.Orders", new[] { "Operator_Id" });
            DropIndex("dbo.Orders", new[] { "Client_Id" });
            DropIndex("dbo.Permissions", new[] { "Role_Id" });
            DropIndex("dbo.Users", new[] { "Role_Id" });
            DropIndex("dbo.Users", new[] { "Operator_Id" });
            DropIndex("dbo.Clients", new[] { "Operator_Id" });
            DropTable("dbo.Categories");
            DropTable("dbo.Products");
            DropTable("dbo.OrderItems");
            DropTable("dbo.Orders");
            DropTable("dbo.Permissions");
            DropTable("dbo.Roles");
            DropTable("dbo.Users");
            DropTable("dbo.Clients");
        }
    }
}

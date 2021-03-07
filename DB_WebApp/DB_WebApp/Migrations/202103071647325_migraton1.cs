namespace DB_WebApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migraton1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Contracts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Summ = c.Int(nullable: false),
                        TodayDate = c.DateTime(nullable: false),
                        NumberOfPeople = c.Int(nullable: false),
                        Customer_Id = c.Int(),
                        Employee_Id = c.Int(),
                        Reservation_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Customers", t => t.Customer_Id)
                .ForeignKey("dbo.Employees", t => t.Employee_Id)
                .ForeignKey("dbo.Reservations", t => t.Reservation_Id)
                .Index(t => t.Customer_Id)
                .Index(t => t.Employee_Id)
                .Index(t => t.Reservation_Id);
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Surname = c.String(),
                        Email = c.String(),
                        B_Date = c.DateTime(nullable: false),
                        Sex = c.String(),
                        Country = c.String(),
                        City = c.String(),
                        Phone_Num = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Surname = c.String(),
                        Email = c.String(),
                        B_Date = c.DateTime(nullable: false),
                        Sex = c.String(),
                        Country = c.String(),
                        City = c.String(),
                        Phone_Num = c.String(),
                        PresentPost = c.String(),
                        Salary = c.Int(nullable: false),
                        Login = c.String(),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Reservations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CheckIn = c.DateTime(nullable: false),
                        CheckOut = c.DateTime(nullable: false),
                        Customer_Id = c.Int(),
                        Rooms_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Customers", t => t.Customer_Id)
                .ForeignKey("dbo.Rooms", t => t.Rooms_Id)
                .Index(t => t.Customer_Id)
                .Index(t => t.Rooms_Id);
            
            CreateTable(
                "dbo.Rooms",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Floor = c.Int(nullable: false),
                        View = c.String(),
                        Category = c.String(),
                        Price = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.People",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Surname = c.String(),
                        Email = c.String(),
                        B_Date = c.DateTime(nullable: false),
                        Sex = c.String(),
                        Country = c.String(),
                        City = c.String(),
                        Phone_Num = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Contracts", "Reservation_Id", "dbo.Reservations");
            DropForeignKey("dbo.Reservations", "Rooms_Id", "dbo.Rooms");
            DropForeignKey("dbo.Reservations", "Customer_Id", "dbo.Customers");
            DropForeignKey("dbo.Contracts", "Employee_Id", "dbo.Employees");
            DropForeignKey("dbo.Contracts", "Customer_Id", "dbo.Customers");
            DropIndex("dbo.Reservations", new[] { "Rooms_Id" });
            DropIndex("dbo.Reservations", new[] { "Customer_Id" });
            DropIndex("dbo.Contracts", new[] { "Reservation_Id" });
            DropIndex("dbo.Contracts", new[] { "Employee_Id" });
            DropIndex("dbo.Contracts", new[] { "Customer_Id" });
            DropTable("dbo.People");
            DropTable("dbo.Rooms");
            DropTable("dbo.Reservations");
            DropTable("dbo.Employees");
            DropTable("dbo.Customers");
            DropTable("dbo.Contracts");
        }
    }
}

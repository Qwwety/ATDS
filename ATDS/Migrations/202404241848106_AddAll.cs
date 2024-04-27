namespace ATDS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddAll : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Departaments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Tasks",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        TaskInitiatorId = c.Int(nullable: false),
                        AssignedUserId = c.Int(nullable: false),
                        TypeId = c.Int(nullable: false),
                        StatusId = c.Int(nullable: false),
                        title = c.String(),
                        Description = c.String(),
                        Priority = c.Int(nullable: false),
                        Answer = c.String(),
                        StartDate = c.DateTime(nullable: false),
                        EndDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Users", t => t.AssignedUserId)
                .ForeignKey("dbo.TaskStatus", t => t.StatusId, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.TaskInitiatorId)
                .ForeignKey("dbo.TasksTypes", t => t.TypeId, cascadeDelete: true)
                .Index(t => t.TaskInitiatorId)
                .Index(t => t.AssignedUserId)
                .Index(t => t.TypeId)
                .Index(t => t.StatusId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PositionId = c.Int(nullable: false),
                        WarehouseId = c.Int(nullable: false),
                        StatusId = c.Int(nullable: false),
                        DepartamentId = c.Int(nullable: false),
                        Password = c.String(),
                        Name = c.String(),
                        SecondName = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Departaments", t => t.DepartamentId, cascadeDelete: true)
                .ForeignKey("dbo.UserPositions", t => t.PositionId, cascadeDelete: true)
                .ForeignKey("dbo.UserStatus", t => t.StatusId, cascadeDelete: true)
                .ForeignKey("dbo.Warehouses", t => t.WarehouseId, cascadeDelete: true)
                .Index(t => t.PositionId)
                .Index(t => t.WarehouseId)
                .Index(t => t.StatusId)
                .Index(t => t.DepartamentId);
            
            CreateTable(
                "dbo.UserPositions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.UserStatus",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Warehouses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TaskStatus",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TasksTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Tasks", "TypeId", "dbo.TasksTypes");
            DropForeignKey("dbo.Tasks", "TaskInitiatorId", "dbo.Users");
            DropForeignKey("dbo.Tasks", "StatusId", "dbo.TaskStatus");
            DropForeignKey("dbo.Tasks", "AssignedUserId", "dbo.Users");
            DropForeignKey("dbo.Users", "WarehouseId", "dbo.Warehouses");
            DropForeignKey("dbo.Users", "StatusId", "dbo.UserStatus");
            DropForeignKey("dbo.Users", "PositionId", "dbo.UserPositions");
            DropForeignKey("dbo.Users", "DepartamentId", "dbo.Departaments");
            DropIndex("dbo.Users", new[] { "DepartamentId" });
            DropIndex("dbo.Users", new[] { "StatusId" });
            DropIndex("dbo.Users", new[] { "WarehouseId" });
            DropIndex("dbo.Users", new[] { "PositionId" });
            DropIndex("dbo.Tasks", new[] { "StatusId" });
            DropIndex("dbo.Tasks", new[] { "TypeId" });
            DropIndex("dbo.Tasks", new[] { "AssignedUserId" });
            DropIndex("dbo.Tasks", new[] { "TaskInitiatorId" });
            DropTable("dbo.TasksTypes");
            DropTable("dbo.TaskStatus");
            DropTable("dbo.Warehouses");
            DropTable("dbo.UserStatus");
            DropTable("dbo.UserPositions");
            DropTable("dbo.Users");
            DropTable("dbo.Tasks");
            DropTable("dbo.Departaments");
        }
    }
}

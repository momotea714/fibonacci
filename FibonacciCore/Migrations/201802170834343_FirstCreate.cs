namespace Fibonacci.Core.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FirstCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Argument",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        MethodId = c.Int(nullable: false),
                        AargumentIndex = c.Int(nullable: false),
                        AargumentType = c.String(),
                        AargumentInitialValue = c.String(),
                        Description = c.String(),
                        UpdateUserID = c.String(),
                        UpdateDateTime = c.DateTime(nullable: false),
                        CreateDateTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Class",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ModuleId = c.Int(nullable: false),
                        ClassName = c.String(),
                        DisplayClassName = c.String(),
                        ClassDescription = c.String(),
                        UpdateUserID = c.String(),
                        UpdateDateTime = c.DateTime(nullable: false),
                        CreateDateTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Method",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ClassId = c.Int(nullable: false),
                        MethodName = c.String(),
                        DisplayMethodName = c.String(),
                        MethodDescription = c.String(),
                        UpdateUserID = c.String(),
                        UpdateDateTime = c.DateTime(nullable: false),
                        CreateDateTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ModuleData",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ModuleId = c.Int(nullable: false),
                        Module = c.Binary(),
                        UpdateUserID = c.String(),
                        UpdateDateTime = c.DateTime(nullable: false),
                        CreateDateTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Module",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DisplayModuleName = c.String(),
                        Icon = c.Binary(),
                        ModuleDescription = c.String(),
                        AssemblyName = c.String(),
                        UpdateUserID = c.String(),
                        UpdateDateTime = c.DateTime(nullable: false),
                        CreateDateTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ReferenceModule",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ModuleId = c.Int(nullable: false),
                        AssemblyName = c.String(),
                        Module = c.Binary(),
                        UpdateUserID = c.String(),
                        UpdateDateTime = c.DateTime(nullable: false),
                        CreateDateTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ReturnValue",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        MethodId = c.Int(nullable: false),
                        ReturnValueIndex = c.Int(nullable: false),
                        ReturnValueType = c.String(),
                        Description = c.String(),
                        UpdateUserID = c.String(),
                        UpdateDateTime = c.DateTime(nullable: false),
                        CreateDateTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ReturnValue");
            DropTable("dbo.ReferenceModule");
            DropTable("dbo.Module");
            DropTable("dbo.ModuleData");
            DropTable("dbo.Method");
            DropTable("dbo.Class");
            DropTable("dbo.Argument");
        }
    }
}

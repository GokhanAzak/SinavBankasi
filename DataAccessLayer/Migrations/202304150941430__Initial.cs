namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _Initial : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Writers", "WriterAbout", c => c.String(maxLength: 500));
            AddColumn("dbo.Writers", "WriterPassword", c => c.String(maxLength: 200));
            AddColumn("dbo.Writers", "WriterTitle", c => c.String(maxLength: 50));
            AddColumn("dbo.Writers", "WriterStatus", c => c.Boolean(nullable: false));
            AlterColumn("dbo.Contents", "ContentDate", c => c.DateTime(nullable: false));
            DropColumn("dbo.Writers", "WritterAbout");
            DropColumn("dbo.Writers", "WritterPassword");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Writers", "WritterPassword", c => c.String(maxLength: 200));
            AddColumn("dbo.Writers", "WritterAbout", c => c.String(maxLength: 500));
            AlterColumn("dbo.Contents", "ContentDate", c => c.String());
            DropColumn("dbo.Writers", "WriterStatus");
            DropColumn("dbo.Writers", "WriterTitle");
            DropColumn("dbo.Writers", "WriterPassword");
            DropColumn("dbo.Writers", "WriterAbout");
        }
    }
}

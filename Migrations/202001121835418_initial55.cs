namespace NotesApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial55 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Note", "Description", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Note", "Description", c => c.String());
        }
    }
}

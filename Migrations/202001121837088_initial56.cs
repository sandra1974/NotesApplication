namespace NotesApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial56 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Note", "Title", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Note", "Title", c => c.String());
        }
    }
}

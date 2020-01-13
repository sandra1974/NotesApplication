namespace NotesApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addmigrationinitial34 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Note", "Description", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Note", "Description", c => c.String(maxLength: 20));
        }
    }
}

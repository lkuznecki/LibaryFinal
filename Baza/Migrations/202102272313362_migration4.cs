namespace Baza.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migration4 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Books", "Tytul", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Books", "Tytul");
        }
    }
}

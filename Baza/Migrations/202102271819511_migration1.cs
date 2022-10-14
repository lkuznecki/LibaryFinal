namespace Baza.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migration1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Books",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Imie = c.String(),
                        Nazwisko = c.String(),
                        NrAlbumu = c.Int(nullable: false),
                        DataWypozyczenia = c.DateTime(nullable: false),
                        TerminZwrotu = c.DateTime(nullable: false),
                        BorrowagesG_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Borrowages", t => t.BorrowagesG_ID)
                .Index(t => t.BorrowagesG_ID);
            
            CreateTable(
                "dbo.Borrowages",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Gatunek = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Books", "BorrowagesG_ID", "dbo.Borrowages");
            DropIndex("dbo.Books", new[] { "BorrowagesG_ID" });
            DropTable("dbo.Borrowages");
            DropTable("dbo.Books");
        }
    }
}

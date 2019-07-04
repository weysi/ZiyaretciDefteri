namespace CFZiyaretciDefteri.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class kurulum : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Mesajlar",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Icerik = c.String(),
                        Tarih = c.DateTime(nullable: false),
                        UyeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Uyeler", t => t.UyeId, cascadeDelete: true)
                .Index(t => t.UyeId);
            
            CreateTable(
                "dbo.Uyeler",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AdSoyad = c.String(nullable: false, maxLength: 100),
                        Eposta = c.String(maxLength: 300),
                        Sifre = c.String(maxLength: 16),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Mesajlar", "UyeId", "dbo.Uyeler");
            DropIndex("dbo.Mesajlar", new[] { "UyeId" });
            DropTable("dbo.Uyeler");
            DropTable("dbo.Mesajlar");
        }
    }
}

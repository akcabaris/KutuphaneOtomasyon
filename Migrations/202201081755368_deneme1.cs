namespace WindowsFormsApp1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class deneme1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Kitaps",
                c => new
                    {
                        kitapId = c.Int(nullable: false, identity: true),
                        kitapAd = c.String(),
                        kitapYazar = c.String(),
                        kitapKonum = c.String(),
                    })
                .PrimaryKey(t => t.kitapId);
            
            CreateTable(
                "dbo.Kullanicis",
                c => new
                    {
                        kullaniciId = c.Int(nullable: false, identity: true),
                        kullaniciTc = c.Int(nullable: false),
                        kullaniciSifre = c.String(),
                        kullaniciAdSoyad = c.String(),
                        kullaniciTipi = c.String(),
                        KullaniciMail = c.String(),
                        kullaniciCeza = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.kullaniciId);
            
            CreateTable(
                "dbo.Oduncs",
                c => new
                    {
                        oduncId = c.Int(nullable: false, identity: true),
                        oduncKitapId = c.Int(nullable: false),
                        oduncKitapAd = c.String(),
                        oduncKullaniciTc = c.String(),
                        oduncTeslimDurum = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.oduncId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Oduncs");
            DropTable("dbo.Kullanicis");
            DropTable("dbo.Kitaps");
        }
    }
}

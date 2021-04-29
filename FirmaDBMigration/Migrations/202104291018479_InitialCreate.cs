namespace FirmaDBMigration.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Ametinimetus",
                c => new
                    {
                        AmetinimetusId = c.Int(nullable: false, identity: true),
                        TöötajaId = c.Int(nullable: false),
                        Ametinimetus_nimi = c.String(nullable: false, maxLength: 30),
                        Määramise_aeg = c.DateTime(nullable: false),
                        Kommentaar = c.String(maxLength: 2000),
                    })
                .PrimaryKey(t => t.AmetinimetusId)
                .ForeignKey("dbo.Töötaja", t => t.TöötajaId, cascadeDelete: true)
                .Index(t => t.TöötajaId);
            
            CreateTable(
                "dbo.Töötaja",
                c => new
                    {
                        TöötajaId = c.Int(nullable: false, identity: true),
                        HarukontorId = c.Int(nullable: false),
                        Eesnimi = c.String(nullable: false, maxLength: 30),
                        Perekonnanimi = c.String(nullable: false, maxLength: 30),
                        Isikukood = c.String(nullable: false, maxLength: 11, fixedLength: true),
                        Sugu = c.Int(nullable: false),
                        Kontakt_aadress = c.String(nullable: false, maxLength: 50),
                        Kontakt_telefon = c.String(nullable: false, maxLength: 15),
                        Kontakt_email = c.String(nullable: false, maxLength: 30),
                        Tööl_alates = c.DateTime(nullable: false),
                        Tööl_kuni = c.DateTime(nullable: false),
                        Kommentaar = c.String(),
                    })
                .PrimaryKey(t => t.TöötajaId)
                .ForeignKey("dbo.Harukontors", t => t.HarukontorId, cascadeDelete: true)
                .Index(t => t.HarukontorId);
            
            CreateTable(
                "dbo.AsjadeLaenutus",
                c => new
                    {
                        AsjadeLaenutusId = c.Int(nullable: false, identity: true),
                        HarukontorId = c.Int(),
                        TöötajaId = c.Int(),
                        Asja_nimi = c.String(nullable: false, maxLength: 30),
                        Asja_kirjeldus = c.String(nullable: false, maxLength: 2000),
                        Kogus = c.Int(nullable: false),
                        Laenutuse_algus = c.DateTime(nullable: false),
                        Laenutuse_lõpp = c.DateTime(nullable: false),
                        Kommentaar = c.String(maxLength: 2000),
                    })
                .PrimaryKey(t => t.AsjadeLaenutusId)
                .ForeignKey("dbo.Harukontors", t => t.HarukontorId)
                .ForeignKey("dbo.Töötaja", t => t.TöötajaId)
                .Index(t => t.HarukontorId)
                .Index(t => t.TöötajaId);
            
            CreateTable(
                "dbo.Harukontors",
                c => new
                    {
                        HarukontorId = c.Int(nullable: false, identity: true),
                        FirmaId = c.Int(nullable: false),
                        Nimi = c.String(nullable: false, maxLength: 30),
                        Aadress = c.String(nullable: false, maxLength: 50),
                        Kontaktisik = c.String(nullable: false, maxLength: 30),
                        Kontakt_telefon = c.String(nullable: false, maxLength: 15),
                        Kontakt_email = c.String(nullable: false, maxLength: 30),
                        Kommentaar = c.String(maxLength: 2000),
                    })
                .PrimaryKey(t => t.HarukontorId)
                .ForeignKey("dbo.Firmas", t => t.FirmaId, cascadeDelete: true)
                .Index(t => t.FirmaId);
            
            CreateTable(
                "dbo.Firmas",
                c => new
                    {
                        FirmaId = c.Int(nullable: false, identity: true),
                        Registri_number = c.String(nullable: false, maxLength: 30),
                        Nimi = c.String(nullable: false, maxLength: 30),
                        Lühinimi = c.String(nullable: false, maxLength: 20),
                        Aadress = c.String(nullable: false, maxLength: 50),
                        Kontaktisik = c.String(nullable: false, maxLength: 30),
                        Kontakt_telefon = c.String(nullable: false, maxLength: 15),
                        Kontakt_email = c.String(nullable: false, maxLength: 30),
                        Kommentaar = c.String(maxLength: 2000),
                    })
                .PrimaryKey(t => t.FirmaId);
            
            CreateTable(
                "dbo.Haiguslehts",
                c => new
                    {
                        HaiguslehtId = c.Int(nullable: false, identity: true),
                        TöötajaId = c.Int(),
                        Haiguslehe_algus = c.DateTime(nullable: false),
                        Haiguslehe_lõpp = c.DateTime(nullable: false),
                        Kommentaar = c.String(maxLength: 2000),
                    })
                .PrimaryKey(t => t.HaiguslehtId)
                .ForeignKey("dbo.Töötaja", t => t.TöötajaId)
                .Index(t => t.TöötajaId);
            
            CreateTable(
                "dbo.Ligipääsuluba",
                c => new
                    {
                        LigipääsulubaId = c.Int(nullable: false, identity: true),
                        TöötajaId = c.Int(),
                        LigipääsuTase = c.Int(nullable: false),
                        Ligipääsu_algus = c.DateTime(nullable: false),
                        Ligipääsu_lõpp = c.DateTime(nullable: false),
                        Kommentaar = c.String(maxLength: 2000),
                    })
                .PrimaryKey(t => t.LigipääsulubaId)
                .ForeignKey("dbo.Töötaja", t => t.TöötajaId)
                .Index(t => t.TöötajaId);
            
            CreateTable(
                "dbo.Palves",
                c => new
                    {
                        PalveId = c.Int(nullable: false, identity: true),
                        TöötajaId = c.Int(),
                        Töötaja_nimi = c.String(nullable: false, maxLength: 30),
                        Palve_kirjeldus = c.String(nullable: false, maxLength: 2000),
                        Kuupäev = c.DateTime(nullable: false, storeType: "date"),
                        Kommentaar = c.String(maxLength: 2000),
                    })
                .PrimaryKey(t => t.PalveId)
                .ForeignKey("dbo.Töötaja", t => t.TöötajaId)
                .Index(t => t.TöötajaId);
            
            CreateTable(
                "dbo.Puhkus",
                c => new
                    {
                        PuhkusId = c.Int(nullable: false, identity: true),
                        TöötajaId = c.Int(),
                        Puhkuse_algus = c.DateTime(nullable: false),
                        Puhkuse_lõpp = c.DateTime(nullable: false),
                        Kommentaar = c.String(maxLength: 2000),
                    })
                .PrimaryKey(t => t.PuhkusId)
                .ForeignKey("dbo.Töötaja", t => t.TöötajaId)
                .Index(t => t.TöötajaId);
            
            CreateTable(
                "dbo.PuhkuseLiiks",
                c => new
                    {
                        Puhkuse_liikId = c.Int(nullable: false, identity: true),
                        PuhkusId = c.Int(nullable: false),
                        Puhkuse_liik = c.String(nullable: false, maxLength: 30),
                        Kommentaar = c.String(maxLength: 2000),
                    })
                .PrimaryKey(t => t.Puhkuse_liikId)
                .ForeignKey("dbo.Puhkus", t => t.PuhkusId, cascadeDelete: true)
                .Index(t => t.PuhkusId);
            
            CreateTable(
                "dbo.Tervisekontrolls",
                c => new
                    {
                        TervisekontrollId = c.Int(nullable: false, identity: true),
                        TöötajaId = c.Int(),
                        Tervisekontrolli_aeg = c.DateTime(nullable: false),
                        Kommentaar = c.String(maxLength: 2000),
                    })
                .PrimaryKey(t => t.TervisekontrollId)
                .ForeignKey("dbo.Töötaja", t => t.TöötajaId)
                .Index(t => t.TöötajaId);
            
            CreateTable(
                "dbo.TöötajaLaps",
                c => new
                    {
                        TöötajaLapsId = c.Int(nullable: false, identity: true),
                        TöötajaId = c.Int(),
                        Eesnimi = c.String(nullable: false, maxLength: 30),
                        Perekonnanimi = c.String(nullable: false, maxLength: 30),
                        Sugu = c.Int(nullable: false),
                        Sünniaasta = c.DateTime(nullable: false, storeType: "date"),
                        Kommentaar = c.String(maxLength: 2000),
                    })
                .PrimaryKey(t => t.TöötajaLapsId)
                .ForeignKey("dbo.Töötaja", t => t.TöötajaId)
                .Index(t => t.TöötajaId);
            
            CreateTable(
                "dbo.Vihjes",
                c => new
                    {
                        VihjeId = c.Int(nullable: false, identity: true),
                        TöötajaId = c.Int(),
                        Vihje_kirjeldus = c.String(nullable: false, maxLength: 2000),
                        Kuupäev = c.DateTime(nullable: false, storeType: "date"),
                        Kommentaar = c.String(maxLength: 2000),
                    })
                .PrimaryKey(t => t.VihjeId)
                .ForeignKey("dbo.Töötaja", t => t.TöötajaId)
                .Index(t => t.TöötajaId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Vihjes", "TöötajaId", "dbo.Töötaja");
            DropForeignKey("dbo.TöötajaLaps", "TöötajaId", "dbo.Töötaja");
            DropForeignKey("dbo.Tervisekontrolls", "TöötajaId", "dbo.Töötaja");
            DropForeignKey("dbo.Puhkus", "TöötajaId", "dbo.Töötaja");
            DropForeignKey("dbo.PuhkuseLiiks", "PuhkusId", "dbo.Puhkus");
            DropForeignKey("dbo.Palves", "TöötajaId", "dbo.Töötaja");
            DropForeignKey("dbo.Ligipääsuluba", "TöötajaId", "dbo.Töötaja");
            DropForeignKey("dbo.Haiguslehts", "TöötajaId", "dbo.Töötaja");
            DropForeignKey("dbo.AsjadeLaenutus", "TöötajaId", "dbo.Töötaja");
            DropForeignKey("dbo.Töötaja", "HarukontorId", "dbo.Harukontors");
            DropForeignKey("dbo.Harukontors", "FirmaId", "dbo.Firmas");
            DropForeignKey("dbo.AsjadeLaenutus", "HarukontorId", "dbo.Harukontors");
            DropForeignKey("dbo.Ametinimetus", "TöötajaId", "dbo.Töötaja");
            DropIndex("dbo.Vihjes", new[] { "TöötajaId" });
            DropIndex("dbo.TöötajaLaps", new[] { "TöötajaId" });
            DropIndex("dbo.Tervisekontrolls", new[] { "TöötajaId" });
            DropIndex("dbo.PuhkuseLiiks", new[] { "PuhkusId" });
            DropIndex("dbo.Puhkus", new[] { "TöötajaId" });
            DropIndex("dbo.Palves", new[] { "TöötajaId" });
            DropIndex("dbo.Ligipääsuluba", new[] { "TöötajaId" });
            DropIndex("dbo.Haiguslehts", new[] { "TöötajaId" });
            DropIndex("dbo.Harukontors", new[] { "FirmaId" });
            DropIndex("dbo.AsjadeLaenutus", new[] { "TöötajaId" });
            DropIndex("dbo.AsjadeLaenutus", new[] { "HarukontorId" });
            DropIndex("dbo.Töötaja", new[] { "HarukontorId" });
            DropIndex("dbo.Ametinimetus", new[] { "TöötajaId" });
            DropTable("dbo.Vihjes");
            DropTable("dbo.TöötajaLaps");
            DropTable("dbo.Tervisekontrolls");
            DropTable("dbo.PuhkuseLiiks");
            DropTable("dbo.Puhkus");
            DropTable("dbo.Palves");
            DropTable("dbo.Ligipääsuluba");
            DropTable("dbo.Haiguslehts");
            DropTable("dbo.Firmas");
            DropTable("dbo.Harukontors");
            DropTable("dbo.AsjadeLaenutus");
            DropTable("dbo.Töötaja");
            DropTable("dbo.Ametinimetus");
        }
    }
}

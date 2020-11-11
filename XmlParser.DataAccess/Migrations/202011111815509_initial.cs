namespace XmlParser.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MerkezYurtdisi",
                c => new
                    {
                        istno = c.Int(nullable: false, identity: true),
                        yil = c.Int(nullable: false),
                        ay = c.Int(nullable: false),
                        gun = c.String(),
                        TahminMerkezi = c.String(),
                        RaporZamani = c.String(),
                        Yurtici = c.String(),
                        tDurumDbirgun = c.String(),
                        tMaxDbirgun = c.Int(nullable: false),
                        tMinDbirgun = c.Int(nullable: false),
                        tDurumDikigun = c.String(),
                        tMaxDikigun = c.Int(nullable: false),
                        tMinDikigun = c.Int(nullable: false),
                        tDurumDucgun = c.String(),
                        tMaxDucgun = c.Int(nullable: false),
                        tMinDucgun = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.istno)
                .Index(t => t.istno);
            
            CreateTable(
                "dbo.MerkezYurtici",
                c => new
                    {
                        istno = c.Int(nullable: false, identity: true),
                        il_adi = c.String(),
                        ilce_adi = c.String(),
                        ilid = c.Int(nullable: false),
                        istad = c.String(),
                        datatarih = c.String(),
                        SICAKLIK = c.Single(nullable: false),
                        MAKSIMUM_SICAKLIK = c.Single(nullable: false),
                        MINIMUM_SICAKLIK = c.Single(nullable: false),
                        NEM = c.Single(nullable: false),
                        RUZGAR_YONU = c.Single(nullable: false),
                        RUZGAR_HIZI = c.Single(nullable: false),
                        YAGIS = c.Single(nullable: false),
                        YAGIS_KAYIT_SAYISI = c.Int(nullable: false),
                        KAPALILIK = c.String(),
                        AKTUEL_BASINC = c.Single(nullable: false),
                        DENIZE_INDIRGENMIS_BASINC = c.Single(nullable: false),
                        MAKSIMUM_RUZGAR_YONU_DER = c.Single(nullable: false),
                        MAKSIMUM_RUZGAR_HIZI = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.istno)
                .Index(t => t.istno);
            
        }
        
        public override void Down()
        {
            DropIndex("dbo.MerkezYurtici", new[] { "istno" });
            DropIndex("dbo.MerkezYurtdisi", new[] { "istno" });
            DropTable("dbo.MerkezYurtici");
            DropTable("dbo.MerkezYurtdisi");
        }
    }
}

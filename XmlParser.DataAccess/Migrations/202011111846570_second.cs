namespace XmlParser.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class second : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.MerkezYurtici", "KAPALILIK", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.MerkezYurtici", "KAPALILIK", c => c.String());
        }
    }
}

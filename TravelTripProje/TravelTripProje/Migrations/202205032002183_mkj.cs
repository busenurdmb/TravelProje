namespace TravelTripProje.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mkj : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Blogs", "Aciklama", c => c.String(maxLength: 2000));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Blogs", "Aciklama", c => c.String());
        }
    }
}

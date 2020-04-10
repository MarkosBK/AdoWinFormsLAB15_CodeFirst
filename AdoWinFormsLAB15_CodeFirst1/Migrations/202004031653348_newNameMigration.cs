namespace AdoWinFormsLAB15_CodeFirst1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newNameMigration : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Authors", "AuthorName", c => c.String(nullable: false, maxLength: 30));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Authors", "AuthorName", c => c.String());
        }
    }
}

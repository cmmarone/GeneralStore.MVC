namespace GeneralStore.MVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class tweakedTransactionEntityModel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Transactions", "Time", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Transactions", "Time");
        }
    }
}

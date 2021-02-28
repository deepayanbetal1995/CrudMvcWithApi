namespace CrudPracticeMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class loginerrmsgadd : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.tbl_Employee", "LoginErrorMessage", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.tbl_Employee", "LoginErrorMessage");
        }
    }
}

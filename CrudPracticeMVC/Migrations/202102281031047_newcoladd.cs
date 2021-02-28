namespace CrudPracticeMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newcoladd : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.tbl_Employee", "EmpPassword", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.tbl_Employee", "EmpPassword");
        }
    }
}

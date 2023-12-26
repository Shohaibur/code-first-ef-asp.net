namespace code_first_ef_asp.net.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddUserTableAndTableModified : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserName = c.String(nullable: false, maxLength: 20),
                        Password = c.String(nullable: false, maxLength: 20),
                    })
                .PrimaryKey(t => t.UserName);
            
            AlterColumn("dbo.Products", "Quantity", c => c.Int());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Products", "Quantity", c => c.Int(nullable: false));
            DropTable("dbo.Users");
        }
    }
}

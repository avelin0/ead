namespace EAD.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Paginas",
                c => new
                    {
                        PaginaID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        CreationDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.PaginaID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Paginas");
        }
    }
}

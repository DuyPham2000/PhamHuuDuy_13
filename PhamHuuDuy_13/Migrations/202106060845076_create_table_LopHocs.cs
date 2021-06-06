namespace PhamHuuDuy_13.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class create_table_LopHocs : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.LopHocs",
                c => new
                    {
                        MaLop = c.Int(nullable: false, identity: true),
                        TenLop = c.String(),
                    })
                .PrimaryKey(t => t.MaLop);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.LopHocs");
        }
    }
}

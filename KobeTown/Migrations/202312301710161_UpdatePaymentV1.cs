﻿namespace KobeTown.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdatePaymentV1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.tb_Order", "TypePayment", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.tb_Order", "TypePayment");
        }
    }
}

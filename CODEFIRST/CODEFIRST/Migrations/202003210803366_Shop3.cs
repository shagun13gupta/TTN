﻿namespace CODEFIRST.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Shop3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Orders", "Quantity", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Orders", "Quantity");
        }
    }
}

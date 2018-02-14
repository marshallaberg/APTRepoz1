namespace APTravel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddUserData : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "ReferredBy", c => c.String(nullable: false, maxLength: 256));
            AddColumn("dbo.AspNetUsers", "ReferralLink", c => c.String(nullable: false, maxLength: 256));
            AddColumn("dbo.AspNetUsers", "HubSpotID", c => c.String(nullable: false, maxLength: 256));
            AddColumn("dbo.AspNetUsers", "FirstName", c => c.String(nullable: false, maxLength: 256));
            AddColumn("dbo.AspNetUsers", "LastName", c => c.String(nullable: false, maxLength: 256));
            AddColumn("dbo.AspNetUsers", "APTEmail", c => c.String(nullable: false, maxLength: 256));
            AddColumn("dbo.AspNetUsers", "BlogURL", c => c.String(nullable: false, maxLength: 500));
            AddColumn("dbo.AspNetUsers", "BlogName", c => c.String(nullable: false, maxLength: 256));
            AddColumn("dbo.AspNetUsers", "UserImage", c => c.String(nullable: false, maxLength: 500));

            DropColumn("dbo.AspNetUserRoles", "ReferredBy");
            DropColumn("dbo.AspNetUserRoles", "ReferralLink");
            DropColumn("dbo.AspNetUserRoles", "HubSpotID");

        }

        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "ReferredBy");
            DropColumn("dbo.AspNetUsers", "ReferralLink");
            DropColumn("dbo.AspNetUsers", "HubSpotID");
            DropColumn("dbo.AspNetUsers", "FirstName");
            DropColumn("dbo.AspNetUsers", "LastName");
            DropColumn("dbo.AspNetUsers", "APTEmail");
            DropColumn("dbo.AspNetUsers", "BlogURL");
            DropColumn("dbo.AspNetUsers", "BlogName");
            DropColumn("dbo.AspNetUsers", "UserImage");
           
        }
    }
}

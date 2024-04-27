namespace ATDS.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity.Infrastructure.Annotations;
    using System.Data.Entity.Migrations;
    
    public partial class FixStartDate : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Tasks", "StartDate", c => c.DateTime(nullable: false,
                annotations: new Dictionary<string, AnnotationValues>
                {
                    { 
                        "Default",
                        new AnnotationValues(oldValue: null, newValue: "getutcdate()")
                    },
                }));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Tasks", "StartDate", c => c.DateTime(nullable: false,
                annotations: new Dictionary<string, AnnotationValues>
                {
                    { 
                        "Default",
                        new AnnotationValues(oldValue: "getutcdate()", newValue: null)
                    },
                }));
        }
    }
}

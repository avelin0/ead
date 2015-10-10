namespace EAD.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Teste : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Enrollments",
                c => new
                    {
                        EnrollmentID = c.Int(nullable: false, identity: true),
                        EnrollmentDate = c.DateTime(nullable: false),
                        Status = c.Int(nullable: false),
                        Course_CourseID = c.Int(),
                        Student_UserId = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.EnrollmentID)
                .ForeignKey("dbo.Courses", t => t.Course_CourseID)
                .ForeignKey("dbo.Students", t => t.Student_UserId)
                .Index(t => t.Course_CourseID)
                .Index(t => t.Student_UserId);
            
            CreateTable(
                "dbo.Courses",
                c => new
                    {
                        CourseID = c.Int(nullable: false, identity: true),
                        CreatorID = c.String(),
                        Name = c.String(),
                        CreationDate = c.DateTime(nullable: false),
                        Level = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CourseID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Enrollments", "Student_UserId", "dbo.Students");
            DropForeignKey("dbo.Enrollments", "Course_CourseID", "dbo.Courses");
            DropIndex("dbo.Enrollments", new[] { "Student_UserId" });
            DropIndex("dbo.Enrollments", new[] { "Course_CourseID" });
            DropTable("dbo.Courses");
            DropTable("dbo.Enrollments");
        }
    }
}

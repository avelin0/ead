namespace EAD.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedCourse : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Enrollments", "Course_CourseID", "dbo.Courses");
            DropIndex("dbo.Enrollments", new[] { "Course_CourseID" });
            RenameColumn(table: "dbo.Enrollments", name: "Course_CourseID", newName: "CourseId");
            AddColumn("dbo.Enrollments", "StudentId", c => c.String());
            AlterColumn("dbo.Enrollments", "CourseId", c => c.Int(nullable: false));
            CreateIndex("dbo.Enrollments", "CourseId");
            AddForeignKey("dbo.Enrollments", "CourseId", "dbo.Courses", "CourseID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Enrollments", "CourseId", "dbo.Courses");
            DropIndex("dbo.Enrollments", new[] { "CourseId" });
            AlterColumn("dbo.Enrollments", "CourseId", c => c.Int());
            DropColumn("dbo.Enrollments", "StudentId");
            RenameColumn(table: "dbo.Enrollments", name: "CourseId", newName: "Course_CourseID");
            CreateIndex("dbo.Enrollments", "Course_CourseID");
            AddForeignKey("dbo.Enrollments", "Course_CourseID", "dbo.Courses", "CourseID");
        }
    }
}

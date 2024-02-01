namespace CourseRegistration.Models;

public class Course
{
    public int Id { get; set; }
    public int CourseNumber { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }

    public static IList<Course> Courses = new List<Course>()
    {
        new Course() { Id = 1, CourseNumber = 101, Name = "Math", Description = "Basic Math" },
        new Course() { Id = 2, CourseNumber = 102, Name = "Science", Description = "Basic Science" },
        new Course() { Id = 3, CourseNumber = 103, Name = "History", Description = "Basic History" },
        new Course() { Id = 4, CourseNumber = 104, Name = "English", Description = "Basic English" },
        new Course() { Id = 5, CourseNumber = 105, Name = "Art", Description = "Basic Art" }
    };
}



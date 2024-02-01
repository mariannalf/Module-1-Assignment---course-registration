namespace CourseRegistration.Models;

public class Instructor
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }

    public Course Course { get; set; }

    public static IList<Instructor> Instructors = new List<Instructor>()
    {
        new Instructor() { Id = 1, FirstName = "John", LastName = "Doe", Email = "john.doe@example.com", Course = Course.Courses[0] },
        new Instructor() { Id = 2, FirstName = "Jane", LastName = "Smith", Email = "jane.smith@example.com", Course = Course.Courses[1] },
        new Instructor() { Id = 3, FirstName = "Michael", LastName = "Johnson", Email = "michael.johnson@example.com", Course = Course.Courses[2] },
        new Instructor() { Id = 4, FirstName = "Emily", LastName = "Brown", Email = "emily.brown@example.com", Course = Course.Courses[3] },
        new Instructor() { Id = 5, FirstName = "David", LastName = "Wilson", Email = "david.wilson@example.com", Course = Course.Courses[4] }
    };
}



namespace CourseRegistration.Models;

public class Student
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
    public IList<Course> EnrolledCourses { get; set; } = new List<Course>();

    public static IList<Student> Students = new List<Student>()
    {
        new Student { Id = 1, FirstName = "John", LastName = "Doe", Email = "john.doe@example.com", Phone = "1234567890" },
        new Student { Id = 2, FirstName = "Jane", LastName = "Smith", Email = "jane.smith@example.com", Phone = "9876543210" },
        new Student { Id = 3, FirstName = "Alice", LastName = "Johnson", Email = "alice.johnson@example.com", Phone = "5555555555" },
        new Student { Id = 4, FirstName = "Bob", LastName = "Williams", Email = "bob.williams@example.com", Phone = "6666666666" },
        new Student { Id = 5, FirstName = "Emily", LastName = "Brown", Email = "emily.brown@example.com", Phone = "7777777777" },
        new Student { Id = 6, FirstName = "Michael", LastName = "Jones", Email = "michael.jones@example.com", Phone = "8888888888" },
        new Student { Id = 7, FirstName = "Olivia", LastName = "Taylor", Email = "olivia.taylor@example.com", Phone = "9999999999" },
        new Student { Id = 8, FirstName = "William", LastName = "Clark", Email = "william.clark@example.com", Phone = "1111111111" },
        new Student { Id = 9, FirstName = "Sophia", LastName = "Lewis", Email = "sophia.lewis@example.com", Phone = "2222222222" },
        new Student { Id = 10, FirstName = "James", LastName = "Hall", Email = "james.hall@example.com", Phone = "3333333333" },
        new Student { Id = 11, FirstName = "Ava", LastName = "Young", Email = "ava.young@example.com", Phone = "4444444444" },
        new Student { Id = 12, FirstName = "Benjamin", LastName = "Lee", Email = "benjamin.lee@example.com", Phone = "5555555555" },
        new Student { Id = 13, FirstName = "Mia", LastName = "Walker", Email = "mia.walker@example.com", Phone = "6666666666" },
        new Student { Id = 14, FirstName = "Ethan", LastName = "Hall", Email = "ethan.hall@example.com", Phone = "7777777777" },
        new Student { Id = 15, FirstName = "Isabella", LastName = "Gonzalez", Email = "isabella.gonzalez@example.com", Phone = "8888888888" },
        new Student { Id = 16, FirstName = "Alexander", LastName = "Harris", Email = "alexander.harris@example.com", Phone = "9999999999" },
        new Student { Id = 17, FirstName = "Charlotte", LastName = "King", Email = "charlotte.king@example.com", Phone = "1111111111" },
        new Student { Id = 18, FirstName = "Daniel", LastName = "Wright", Email = "daniel.wright@example.com", Phone = "2222222222" },
        new Student { Id = 19, FirstName = "Scarlett", LastName = "Lopez", Email = "scarlett.lopez@example.com", Phone = "3333333333" },
        new Student { Id = 20, FirstName = "Henry", LastName = "Scott", Email = "henry.scott@example.com", Phone = "4444444444" }
    };

    static Student()
    {
        Random random = new Random();

        foreach (var student in Students)
        {
            for (int i = 0; i < 2; i++)
            {
                int randomCourseIndex = random.Next(Course.Courses.Count);
                Course randomCourse = Course.Courses[randomCourseIndex];
                student.EnrolledCourses.Add(randomCourse);
            }
        }
    }
}





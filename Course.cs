public class Course
{
    public int CourseId { get; set; }
    public string CourseName { get; set; }
    public string Instructor { get; set; }
    public int Credits { get; set; }

    public Course(int courseId, string courseName, string instructor, int credits)
    {
        CourseId = courseId;
        CourseName = courseName;
        Instructor = instructor;
        Credits = credits;
    }
}

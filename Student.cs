public class Student
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public double CSIGrade { get; set; }
    public double GenEdGrade { get; set; }

    // Parameterized constructor with two arguments
    public Student(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
        CSIGrade = -1;
        GenEdGrade = -1;
    }

    // Parameterized constructor with four arguments
    public Student(string firstName, string lastName, double csiGrade, double genEdGrade)
    {
        FirstName = firstName;
        LastName = lastName;
        CSIGrade = csiGrade;
        GenEdGrade = genEdGrade;
    }
}

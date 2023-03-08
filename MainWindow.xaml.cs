Skip to content
Search or jump to…
Pull requests
Issues
Codespaces
Marketplace
Explore
 
@kilinc1 
WCramRTC
/
Prog_122_W23_Lecture_5_Classes
Public
Fork your own copy of WCramRTC/Prog_122_W23_Lecture_5_Classes
Code
Issues
Pull requests
Actions
Projects
Security
Insights
Prog_122_W23_Lecture_5_Classes/MainWindow.xaml.cs /
@WCramRTC
WCramRTC Updated Class Notes
Latest commit df0e8cd on Jan 23
 History
 1 contributor
76 lines (58 sloc)  2.14 KB

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Prog_122_W23_Lecture_5_Classes
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // Take your database diagram, create at least one class from it
        List<Student> students = new List<Student>();

        public MainWindow()
        {
            InitializeComponent();

            Instructor breshna = new Instructor("Naim", "Breshna", "123445677");
            // Properties

            Student student = new Student("Will", "Cram");

            SchoolClass sc = new SchoolClass(breshna, student);


            string format = sc.Instructor.FirstName + " - " + sc.Student.FirstName;
      
            MessageBox.Show(format);
        }

        public void Example()
        {
            // Createa  new INSTANCE of a student object
            Student student = new Student("Breshna", "Naim", 110, 115);
            Student student2 = new Student("Will", "Cram");

            // How do I give my student a first name
            //student.FirstName = "Breshna";
            //student.LastName = "Naim";
            //student.CSIGrade = 110;
            //student.GenEdGrade = 115;

            students.Add(student);
            students.Add(student2);

            // What is the new Student() calling?
            // The default constructor of student

            // What happens to the default constructor when I make
            // A new constructor?

            MessageBox.Show(FormattedStudent(student2));

            // Creating a Movie object using the default constructor
            Movie movie1 = new Movie();

            // Creating a Movie object using the parameterized constructor
            Movie movie2 = new Movie("Inception", 8.8, "Christopher Nolan", 2010);

            // Creating a Student object using the parameterized constructor with two arguments
            Student student1 = new Student("John", "Doe");

            // Creating a Student object using the parameterized constructor with four arguments
            Student student2 = new Student("Jane", "Doe", 85.0, 92.5);

            // Create Course objects
            Course course1 = new Course(1, "Database Systems", "Dr. Smith", 3);
            Course course2 = new Course(2, "Software Engineering", "Dr. Johnson", 4);

            // Display information from a Course object
            MessageBox.Show($"Course Name: {course1.CourseName}\nInstructor: {course1.Instructor}\nCredits: {course1.Credits}");
        }

        public string FormattedStudent(Student student)
        {
            string studentInformation = student.FirstName + " " + student.LastName + " - " + student.CSIGrade + " - " + student.GenEdGrade;

            return studentInformation;
        }

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8
{
    public class Student
    {
        private string _name;
        public string StudentName {
            get { return _name; }
            set { _name = value; }
        }
        private int _age;
        public int Age { get { return _age; } set { _age = value; } }
        private int _grade;
        public int Grade { get { return _grade; } set { _grade = value; } }
        public Student(string name, int age, int grade)
        {
            _name = name;
            _age = age;
            _grade = grade;
        }
    }
    public class Teacher
    {
        private string _name;
        public string TeacherName { get { return _name; } set { _name = value; } }
        private string _subject;
        public string Subject { get { return _subject; } set { _subject = value; } }
        private int _yearsofexerience;
        public int YearsOfExperience { get { return _yearsofexerience; } set { _yearsofexerience = value; } }
        public Teacher(string name, string subject, int yearsOfExperience)
        {
            _name = name;
            _subject = subject;
            _yearsofexerience = yearsOfExperience;
        }
    }
    public class School
    {
        public List<Student> Students { get; set; }
        public List<Teacher> Teachers { get; set; }
        public School()
        {
            Students = new List<Student>();
            Teachers = new List<Teacher>();
        }
        public void AddStudent(Student student)
        {
            Students.Add(student);
        }
        public void AddTeacher(Teacher teacher)
        {
            Teachers.Add(teacher);
        }
        public void DespleyStudent(Student st)
        {
            Console.WriteLine("Name is -> {0}\n age is -> {1}\n Grade is-> {2}", st.StudentName, st.Age, st.Grade);
        }
        public void DispleyTeacher(Teacher th)
        {
            Console.WriteLine("Name is -> {0}\n Subject is -> {1}\n YearsOfExperience is -> {2}", th.TeacherName, th.Subject, th.YearsOfExperience);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            School school = new School();
            int StudentCount = 0;
            int TeachCount = 0;
            while (true)
            {
                Console.WriteLine("Please enther the Count of studen you want to inport program:");
                StudentCount = int.Parse(Console.ReadLine());
                if (StudentCount > 0)
                {
                    break;
                }
            }
            while (StudentCount != 0)
            {
                Console.WriteLine("Please Enther the Student Name:");
                string studentname = Console.ReadLine();
                Console.WriteLine("Please Enter The Student Age:");
                int stdudenage = int.Parse(Console.ReadLine());
                Console.WriteLine("Please Enther The Student Gread:");
                int studentgreat = int.Parse(Console.ReadLine());
                Student stud = new Student(studentname, stdudenage, studentgreat);
                school.Students.Add(stud);
                StudentCount--;
            }
            while (true)
            {
                Console.WriteLine("Please Enther The Count Of Teacher You Want To Import The Program:");
                TeachCount = int.Parse(Console.ReadLine());
                if (TeachCount > 0)
                {
                    break;
                }
            }
            while (TeachCount != 0)
            {
                Console.WriteLine("Please Enther The Teacher Name:");
                string teachername = Console.ReadLine();
                Console.WriteLine("Please Enther The Subject:");
                string subject = Console.ReadLine();
                Console.WriteLine("Please Enther The Teacher Years of Exeriens:");
                int experians = int.Parse(Console.ReadLine());
                Teacher tech = new Teacher( teachername, subject, experians);
                school.AddTeacher(tech);
                TeachCount--;
            }
            Console.WriteLine();
            foreach (var s in school.Students)
            {
                if (s.Grade > 17)
                {
                    Console.WriteLine("   Student   \n");
                    school.DespleyStudent(s);
                }
            }
            foreach (var t in school.Teachers)
            {
                if (t.YearsOfExperience < 2)
                {
                    Console.WriteLine("   Teacher   \n");
                    school.DispleyTeacher(t);
                }
            }
        }
    }
}

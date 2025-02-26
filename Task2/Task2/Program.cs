using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int Grade { get; set; }
        public Student(string name, int age, int grade)
        {
            Name = name;
            Age = age;
            Grade = grade;

        }
        public void Displeay()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}, Grade: {Grade} ");
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student[] students = new Student[5];
            for(int i = 0; i < students.Length; i++)
            {
                Console.WriteLine("Please enthe the student name: ");
                string name = Console.ReadLine();
                Console.WriteLine("Please enther the student age: ");
                int age = int.Parse(Console.ReadLine());
                Console.WriteLine("Please enther the Student Grade: ");
                int grade = int.Parse(Console.ReadLine());
                students[i] = new Student(name, age, grade);
                Console.WriteLine("Student Adds succesfulluy \n");
            }
            foreach(Student student in students)
            {
                student.Displeay();
            }
            Console.WriteLine("Please enther the any key for exit:");
            Console.ReadKey();
        }
    }
}

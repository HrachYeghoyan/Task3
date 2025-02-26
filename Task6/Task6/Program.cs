using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    public class Enployee
    {
        public string Name;
        public string Position;
        public int SalaryPerHour;
        public int HoursWorked;

        public Enployee(string name, string position, int salaryPerHour, int hoursWorked)
        {
            Name = name;
            Position = position;
            SalaryPerHour = salaryPerHour;
            HoursWorked = hoursWorked;
        }
        public double CalculateSalary()
        {
            double paymant = 0;
            if(HoursWorked > 40)
            {
                double overtime = HoursWorked - 40;
                paymant = (40 * SalaryPerHour) + (overtime * SalaryPerHour * 1.5);
            }
            else
            {
                paymant = HoursWorked * SalaryPerHour;
            }
            return paymant;
        }
        public void Display()
        {
            Console.WriteLine($" Worker  Name is {Name} Worker  works {HoursWorked} hours Worker payment is {CalculateSalary()} ");
        }
        public void Displeayworker()
        {
            Console.WriteLine($"Name is: {Name} Position is {Position} ");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Enployee[] enployers = new Enployee[3];
            enployers[0] = new Enployee("Armen Hakobyan", "Bank manager", 25, 45);
            enployers[1] = new Enployee("Ani Makaryan", "Softwer Inginer", 20, 38);
            enployers[2] = new Enployee("Martin Hakobyan", "Marketolog", 30, 50);
            Console.WriteLine("This is our company staf\n");
            foreach( Enployee enploy in enployers)
            {
                enploy.Displeayworker();
            }
            Console.WriteLine();
            Console.WriteLine("Worker wokring ours and paymants\n");
            foreach (Enployee enploy in enployers)
            {
                enploy.CalculateSalary();
                enploy.Display();
            }
        }
        
    }
}

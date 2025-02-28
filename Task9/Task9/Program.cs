using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Task9
{
    public class Car
    {
        private string _model;
        public string Model { get { return _model; } set { _model = value; } }
        private int _year;
        public int Year { get { return _year; } set { _year = value; } }
        private bool _isRented;
        public bool IsRented { get { return _isRented; } set { _isRented = value; } }

        public Car(string model, int year)
        {
            _model = model;
            _year = year;
            _isRented = false;
        }
        public void DispleyCar()
        {
            string res = (_isRented== true) ? "YES" : "NO";
            Console.WriteLine($"Care Model is: {_model} Car Year is: {_year} Car is Rented: {res}");
        }
        public void RentCar()
        {
            if (_isRented == true)
            {
                Console.WriteLine($"Sorry the {_model} is Rented ");
            }
            else
            {
                _isRented= true;
                Console.WriteLine($"You are Rented the car {_model} done");
            }
        }
        public void ReturnCar()
        {
            if (!_isRented)
            {
                Console.WriteLine($"This {_model} is not Reanted ");
            }
            else
            {
                _isRented =false;
                Console.WriteLine($"Returned the car {_model} is Done: ");
            }    
        }
        public static Car SearchCar(List<Car> carpark, string carName)
        {
            foreach (var car in carpark)
            {
                if (car.Model.Equals(carName, StringComparison.OrdinalIgnoreCase))
                {
                    return car;
                }
            }
            return null;  
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Car> carpark = new List<Car>
            {
                new Car("Toyota Camry", 2020),
                new Car("Honda Accord", 2019),
                new Car("Ford Mustang", 2021),
                new Car("Chevrolet Malibu", 2018),
                new Car("Tesla Model 3", 2022)
            };
            bool check = true;
            Console.WriteLine("This Is Car Renting Program: ");
            while (check)
            {
                Console.WriteLine();
                Console.WriteLine("Please Chose In Option in 1: to 5:\n");
                Console.WriteLine("1 For Displeay All Car ");
                Console.WriteLine("2 For Rent Car: ");
                Console.WriteLine("3 For Return Car: ");
                Console.WriteLine("4 For Searching Car: ");
                Console.WriteLine("5 For Exit Program: ");
                string chose = Console.ReadLine();
                switch (chose)
                {
                    case "1":
                        Console.WriteLine("\nAvalible Cars:");
                        foreach (var car in carpark)
                        {
                            car.DispleyCar();
                        }
                        Console.WriteLine();
                        break;
                    case "2":
                        Console.WriteLine("\nPlease Enther The Car Name You Want To Rent");
                        string carmodel = Console.ReadLine();
                        var carrent = Car.SearchCar(carpark, carmodel);
                        if (carrent != null)
                        {
                            carrent.RentCar();
                        }
                        else
                        {
                            Console.WriteLine($"Care Withe Model {carmodel} Is Not Faund:");
                        }
                        Console.WriteLine() ;
                        break;
                    case "3":
                        Console.WriteLine("\n Please Enther The Car Name You Want To Return");
                        string modelcar = Console.ReadLine();
                        var carreturn = Car.SearchCar(carpark, modelcar);
                        if (carreturn != null)
                        {
                            carreturn.ReturnCar();
                        }
                        else
                        {
                            Console.WriteLine($"Care With Model {modelcar} Is Not Faund:");
                        }
                        Console.WriteLine();
                        break ;
                    case "4":
                        Console.WriteLine("Please Enther The Car Name You Want To Search:");
                        string searchcar= Console.ReadLine();
                        var carsearch = Car.SearchCar(carpark, searchcar);
                        if (carsearch != null)
                        {
                            carsearch.DispleyCar();
                        }
                        else
                        {
                            Console.WriteLine($"The Car Model {searchcar} Is Not Faund:");
                        }
                        Console.WriteLine();
                        break ;
                    case "5":
                        Console.WriteLine("Exiting:");
                        check = false;
                        break ;
                    default:
                        Console.WriteLine("You Are Input The Invaled Chose:");
                        break ;
                }
            }
            Console.Clear();//Cleaning Console window
            Console.WriteLine("Thnak You Using Our Program:");
          
        }
    }
}

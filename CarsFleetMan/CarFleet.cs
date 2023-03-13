using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace CarsFleetMan
{
    public class CarFleet
    {
            private List<CarFleet> cars = new List<CarFleet>();
            private string? brand;
            private string? model;
            private int year;
            private double price;
            private string? color;
            private int miles;
            private string registrationNumber;

            public string Brand { get; set; }
            public string Model { get; set; }
            public int Year { get; set; }
            public double Price { get; set; }
            public string Color { get; set; }
            public int Miles { get; set; }
            public string RegistrationNumber { get; set; }

            public CarFleet(string? brand, string? model, int year, double price, string? color, int miles, string registrationNumber)
            {
                this.Brand = brand;
                this.Model = model;
                this.Year = year;
                this.Price = price;
                this.Color = color;
                this.Miles = miles;
                this.RegistrationNumber = registrationNumber;

            }

            public void DisplayEmployeeDetails()
            {
                Console.WriteLine($"\nBrand: \t{Brand}\nModel: \t{Model}\nYear: \t\t{Year}\nPrice: \t{Price}\nColor: \t{Color}\nMiles: \t{Miles}\nRegistrationNumber: \t{RegistrationNumber}\n");
            }
     

        
        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentAD
{
    public class Car
    {
        private string brand;
        private string year;
        private float price;

        public Car(string brand, string year, float price)
        {
            this.brand = brand;
            this.year = year;
            this.price = price;
        }

        public void CarIntro()
        {
            Console.WriteLine($"Car: {brand}, Year: {year}, Price: {price:C}");
        }

        static public void Main(String[] args)
        {
            Car c1 = new Car("BMW", "2023", 500000);           
            c1.CarIntro();
        }
    }
}





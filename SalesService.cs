using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSales
{
    internal class SalesService
    {
        private CarRepository CarRepository;

        private List<Salesman> Salesmen = new List<Salesman>();

        public SalesService(CarRepository carRepository)
        {
            this.CarRepository = carRepository;
        }

        public void AddSalesman(Salesman salesman)
        {
            Salesmen.Add(salesman);
        }

        public void SellCar(int carId)
        {
            //Car car = carRepository.GetCarById(carId);
            //if (car != null && car.Status == "Available")
            //{
            //    // Implement logic to mark the car as sold
            //    car.Status = "Sold";
            //}
            //else
            //{
            //    Console.WriteLine("Car not found or already sold.");
            //}
        }
    }
}

namespace CarSales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            CarRepository carRepository = new CarRepository();

            SalesService salesService = new SalesService(carRepository);

            carRepository.AddCar(new Car { Id = 1, Make = "Toyota", Model = "Camry", Year = 2020, Price = 25000, Mileage = 15000, Status = "Available" });
            carRepository.AddCar(new Car { Id = 2, Make = "Honda", Model = "Civic", Year = 2019, Price = 20000, Mileage = 20000, Status = "Available" });
            carRepository.AddCar(new Car { Id = 3, Make = "Ford", Model = "F-150", Year = 2021, Price = 35000, Mileage = 10000, Status = "Available" });

            //// Sell a car
            //salesService.SellCar(1);

            // Add another car
            Car Kia = new Car
            {
                Id = 1,
                Make = "Kia",
                Model = "Rio",
                Year = 2011,
                Price = 2500.00M,
                Mileage = 15000,
                Status = "false"
            };

            carRepository.AddCar(Kia);

            Console.WriteLine($"The number of cars in the repository {carRepository.GetNumberOfCars()}");

            Console.ReadLine();
        }
    }
}

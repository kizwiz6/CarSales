using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSales
{
    /// <summary>
    /// Responsible for managing cars within the system.
    /// </summary>
    public class CarRepository
    {

        // In memory collection to store cars
        private List<Car> cars = new List<Car>();

        public CarRepository()
        {
            cars = new List<Car>(); // Initialise the cars list
        }

        /// <summary>
        /// Adds a new car to the repository.
        /// </summary>
        /// <param name="car">The car to add.</param>
        public void AddCar(Car car)
        {
            cars.Add(car);
        }

        /// <summary>
        /// Updates an existing car in the repository.
        /// </summary>
        /// <param name="car">The car with the updated information.</param>
        public void UpdateCar(Car car)
        {
            Car existingCar = cars.FirstOrDefault(car => car.Id == car.Id);

            if (existingCar != null)
            {
                // Update the existing car's properties with the new values
                existingCar = car;
            }
            else
            {
                // Car with the provided ID not found
                Console.WriteLine("Car not found for update.");
            }

        }

        /// <summary>
        /// Deletes a car from the repository by its cardId
        /// </summary>
        /// <param name="carId"></param>
        public void DeleteCar(int carId)
        {
            // Find the car in the list with the specified ID
            Car carsToRemove = cars.FirstOrDefault(cars => cars.Id == carId);

            if (carsToRemove != null)
            {
                cars.Remove(carsToRemove);
                Console.WriteLine("Car deleted successfully.");
            }
            else
            {
                Console.WriteLine("Car not found for deletion.");
            }
        }

        /// <summary>
        /// Gets the numerical count of the list of cars.
        /// </summary>
        /// <returns></returns>
        public int GetNumberOfCars()
        {
            return cars.Count;
        }

        /// <summary>
        /// Returns a list containing all cars in the repository.
        /// </summary>
        /// <returns></returns>
        public List<Car> GetAllCars()
        {
            return cars;
        }

        /// <summary>
        /// Retrieves a specific car from the repository based on it id.
        /// </summary>
        /// <param name="carId"></param>
        /// <returns></returns>
        public Car GetCarById(int carId)
        {
            return cars.FirstOrDefault(c => c.Id == carId);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSales
{
    /// <summary>
    /// Implementation of the database operations interface.
    /// </summary>
    internal class CarDatabase : ICarDatabase
    {
        /// <summary>
        /// Collection to store cars
        /// </summary>
        private List<Car> cars = new List<Car>();

        /// <summary>
        /// Adds a car to the database
        /// </summary>
        /// <param name="car"></param>
        public void AddCar(Car car)
        {
            cars.Add(car);
        }

        /// <summary>
        /// Retrieves all cars from the database.
        /// </summary>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public List<Car> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}

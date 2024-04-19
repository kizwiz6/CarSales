using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSales
{
    /// <summary>
    /// Interface for database operations.
    /// </summary>
    internal interface ICarDatabase
    {
        /// <summary>
        /// Method to add a car to the database.
        /// </summary>
        /// <param name="car"></param>
        void AddCar(Car car);

        /// <summary>
        /// Method to retrieve all cars from the datbaase.
        /// </summary>
        /// <returns></returns>
        List<Car> GetAll();
    }
}

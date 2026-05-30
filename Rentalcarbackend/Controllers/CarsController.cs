using Microsoft.AspNetCore.Mvc;
using Rentalcarbackend.Data;
using Rentalcarbackend.Models;

namespace Rentalcarbackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        private readonly AppDbContext _context;

        public CarsController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetCars()
        {
            var cars = _context.Cars.ToList();
            return Ok(cars);
        }

        [HttpPost]
        public IActionResult AddCar(Car car)
        {
            _context.Cars.Add(car);
            _context.SaveChanges();

            return Ok(new
            {
                message = "Car added successfully",
                car = car
            });
        }

        [HttpPut("{id}")]
        public IActionResult UpdateCar(int id, Car updatedCar)
        {
            var car = _context.Cars.Find(id);

            if (car == null)
            {
                return NotFound(new
                {
                    message = "Car not found"
                });
            }

            car.Brand = updatedCar.Brand;
            car.Model = updatedCar.Model;
            car.Color = updatedCar.Color;
            car.Price = updatedCar.Price;
            car.Status = updatedCar.Status;

            _context.SaveChanges();

            return Ok(new
            {
                message = "Car updated successfully",
                car = car
            });
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteCar(int id)
        {
            var car = _context.Cars.Find(id);

            if (car == null)
            {
                return NotFound(new
                {
                    message = "Car not found"
                });
            }

            _context.Cars.Remove(car);
            _context.SaveChanges();

            return Ok(new
            {
                message = "Car deleted successfully"
            });
        }
    }
}
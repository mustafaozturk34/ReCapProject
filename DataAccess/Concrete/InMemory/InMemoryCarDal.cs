using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{Id=1,BrandId=1,ColorId=1,ModelYear=2010,DailyPrice=72000,Description="That is BMW X5."},
                new Car{Id=2,BrandId=2,ColorId=2,ModelYear=2021,DailyPrice=150000,Description="That is Audi A5."},
                new Car{Id=3,BrandId=3,ColorId=2,ModelYear=2000,DailyPrice=50000,Description="That is Ford Focus."},
                new Car{Id=4,BrandId=1,ColorId=3,ModelYear=1998,DailyPrice=45000,Description="That is BMW X3."},
                new Car{Id=5,BrandId=2,ColorId=4,ModelYear=1890,DailyPrice=100000,Description="That is Audi A3."}
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById()
        {
            return _cars;
        }

        public void Update(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToDelete.BrandId = car.BrandId;
            carToDelete.ColorId = car.ColorId;
            carToDelete.DailyPrice = car.DailyPrice;
            carToDelete.Description = car.Description;
            carToDelete.ModelYear = car.ModelYear;
        }
    }
}

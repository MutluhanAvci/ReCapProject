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
              new Car{Id=1,BrandId=1,ColorId=1,DailyPrice=300,ModelYear=2000,Description="Corolla"},
              new Car{Id=2,BrandId=1,ColorId=2,DailyPrice=800,ModelYear=2010,Description="Yaris"},
              new Car{Id=3,BrandId=2,ColorId=40,DailyPrice=700,ModelYear=2015,Description="Astra"},
              new Car{Id=4,BrandId=3,ColorId=50,DailyPrice=6700,ModelYear=2022,Description="C180"},
              new Car{Id=5,BrandId=4,ColorId=60,DailyPrice=15000,ModelYear=2022,Description="M5"}
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car cartoDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(cartoDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int categoryId)
        {
            return _cars.Where(c => c.CategoryId == categoryId).ToList();
        }

        public void Update(Car car)
        {
            Car cartoUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            car.DailyPrice = cartoUpdate.DailyPrice;
            car.Description = cartoUpdate.Description;
            car.ModelYear = cartoUpdate.ModelYear;
        }
    }
}

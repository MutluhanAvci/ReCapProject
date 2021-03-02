using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using DataAccess.Abstract;
using System.Linq;
using Entity.Abstract;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal:ICarDal
    {
        
        List<Car> cars;
        public InMemoryCarDal()
        {
            cars = new List<Car>
            {
                new Car{BrandId=1,ColorId=1,DailyPrice=20,Description="Tofaş",Id=1,ModelYear=1999},
                new Car{BrandId=1,ColorId=2,DailyPrice=40,Description="Fiat",Id=2,ModelYear=2005},
                new Car{BrandId=2,ColorId=3,DailyPrice=50,Description="WV",Id=3,ModelYear=2010},
                new Car{BrandId=3,ColorId=4,DailyPrice=60,Description="BMW",Id=4,ModelYear=2015},
                new Car{BrandId=4,ColorId=5,DailyPrice=70,Description="Audi",Id=5,ModelYear=2020 }
            };
        }

        public void Add(Car car)
        {
            cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car CarToDelete = cars.SingleOrDefault(c => c.Id == car.Id);
            cars.Remove(CarToDelete);
        }

        public List<Car> GetAll()
        {
            return cars;
        }

        public List<Car> GetByCategory(int CategoryId)
        {
            return cars.Where(c => c.CategoryId == CategoryId).ToList();
        }

        public void Update(Car car)
        {
            Car CarToUpdate = cars.SingleOrDefault(c => c.Id == car.Id);
            CarToUpdate.BrandId = car.BrandId;
            CarToUpdate.ColorId = car.ColorId;
            CarToUpdate.DailyPrice = car.DailyPrice;
            CarToUpdate.Description = car.Description;
            CarToUpdate.Id = car.Id;
            CarToUpdate.ModelYear = car.ModelYear;
        }
    }
}

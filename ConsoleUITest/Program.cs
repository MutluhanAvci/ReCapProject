using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUITest
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());
            carManager.GetAll();
            foreach (var item in carManager.GetAll())
            {
                Console.WriteLine(item.Description);
            }
            Car car = new Car { BrandId = 1, CategoryId = 2, ColorId = 1, DailyPrice = 1050, Description = "E250", Id = 10, ModelYear = 2001 };
            BrandManager brandManager = new BrandManager(new InMemoryBrandDal());
            brandManager.GetBrandName(car);
            foreach (var item in brandManager.GetBrandName(car))
            
            {
                Console.WriteLine(item.BrandName+"----------");
            }
            
        }
    }
}

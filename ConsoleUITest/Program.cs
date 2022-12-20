using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUITest
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            //carManager.GetAll();
            //foreach (var item in carManager.GetAll())
            //{
            //    Console.WriteLine(item.Description);

            //}
            
            //Car car = new Car { BrandId = 1, CategoryId = 2, ColorId = 1, DailyPrice = 1050, Description = "E250", ModelYear = 2001 };
            //carManager.Add(car);
            //Console.ReadLine();
            carManager.GetCarsByBrandId(1);
            foreach (var item in carManager.GetCarsByBrandId(1))
            {
                Console.WriteLine(item.Description);
            }
            Console.ReadLine();
            //carManager.GetCarDetails(2);
            //foreach (var item in carManager.GetCarDetails(2))
            //{

            //}
            //carManager.GetCarsByColorId(2);
            //Console.ReadLine();
            //carManager.GetAll();
            //Console.ReadLine();

        }
    }
}

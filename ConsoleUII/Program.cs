using Business.Concrete;
using System;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using DataAccess.Concrete;

namespace ConsoleUII
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Description);
            }



        }
    }
}

using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
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
            
        }
    }
}

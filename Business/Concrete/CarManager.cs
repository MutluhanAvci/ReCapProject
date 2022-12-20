using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;
        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public void Add(Car car)
        {

            if (car.Description.Length<2)
            {
                throw new Exception("Arabanın adı minimum 2 karakter olmalıdır");
                
            }
            else if(car.DailyPrice<=0)
            {
                throw new Exception("Arabanın günlük fiyatı 0'dan büyük olmalıdır");
            }
            _carDal.Add(car);
            Console.WriteLine("Ekleme işlemi başarılı");
        }

        public void Delete(Car car)
        {
            _carDal.Delete(car);
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        //public void GetCarDetails(int carId)
        //{
           
        //}

        public List<Car> GetCarsByBrandId(int brandId)
        {
            return _carDal.GetAll(c => c.BrandId == brandId);
        }

        public List<Car> GetCarsByColorId(int colorId)
        {
            return _carDal.GetAll(c => c.ColorId == colorId);
        }
    }
}

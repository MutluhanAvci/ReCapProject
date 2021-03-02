using Business.Abstract;
using DataAccess.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal carDal;
        public CarManager(ICarDal dal)
        {
            carDal = dal;
         
        }
        public List<Car> GetAll()
        {
            return carDal.GetAll();
        }
















    }
}

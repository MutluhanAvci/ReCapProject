using System;
using System.Collections.Generic;
using System.Text;
using Entity.Concrete;

namespace DataAccess.Abstract
{
    public interface ICarDal
    {
        List<Car> GetAll();
        void Add(Car car);
        void Update(Car car);
        void Delete(Car car);
        List<Car> GetByCategory(int CategoryId);





    }
}

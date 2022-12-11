using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryBrandDal : IBrandDal
    {
        List<Brand> _brands;
        public InMemoryBrandDal()
        {
            _brands = new List<Brand>
            {
               new Brand{BrandId=1,BrandName="Toyota"},
               new Brand{BrandId=2,BrandName="Opel"},
               new Brand{BrandId=3,BrandName="Mercedes"},
               new Brand{BrandId=4,BrandName="BMW"},
            };
        }
        public List<Brand> GetBrandNameByCar(Car car)
        {
            return _brands.Where(b => b.BrandId == car.BrandId).ToList();
        }
    }
}

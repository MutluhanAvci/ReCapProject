using Core.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, NorthwindContext>, ICarDal

    {
        public List<CarDetailsDTO> GetCarDetails()
        {
            using (NorthwindContext context=new NorthwindContext())
            {
                var result = from c in context.Car
                             join b in context.Brand                     
                             on c.BrandId equals b.BrandId 
                             join color in context.Color
                             on c.ColorId equals color.ColorId
                             select new CarDetailsDTO
                             {
                                 CarName = c.Description,
                                 BrandName = b.BrandName,
                                 DailyPrice = c.DailyPrice,
                                 ColorName=color.ColorName
                             };
                return result.ToList();                   
            }
        }
    }
}

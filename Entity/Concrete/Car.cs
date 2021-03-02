using Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entity.Concrete
{
    public class Car:IEntities
    {
        public int Id { get; set; }
        public int BrandId { get; set; }
        public int ColorId { get; set; }
        public int ModelYear { get; set; }
        public float DailyPrice { get; set; }
        public string Description { get; set; }
        public int CategoryId { get; set; }

    }
}

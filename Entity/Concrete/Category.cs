using Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entity.Concrete
{
    public class Category:IEntities
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }


    }
}

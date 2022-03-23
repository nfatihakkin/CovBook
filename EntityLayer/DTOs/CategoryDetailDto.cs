using CoreLayer.EntityLayer;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.DTOs
{
    public class CategoryDetailDto:IDto
    {
        public int ID { get; set; }
        public string CategoryName { get; set; }
        public string CategoryTypeName { get; set; }
        public string CategoryDescription { get; set; }
        public bool CategoryStatus { get; set; }
        public bool CategoryTypeStatus { get; set; }


    }
}

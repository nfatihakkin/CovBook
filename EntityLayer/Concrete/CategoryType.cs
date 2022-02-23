﻿using CoreLayer.EntityLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class CategoryType : IEntity
    {
        [Key]
        public int Id { get; set; }
        public string CategoryTypeName { get; set; }
        public bool CategoryTypeStatus { get; set; }
    }
}

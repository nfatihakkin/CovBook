using CoreLayer.EntityLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Publisher : IEntity
    {
        [Key]
        public int Id { get; set; }
        public string PublisherName { get; set; }
        public bool PublisherStatus { get; set; }


    }
}

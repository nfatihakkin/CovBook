using CoreLayer.EntityLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Writer : IEntity
    {
        [Key]
        public int Id { get; set; }
        public string WriterName { get; set; }
        public string WriterSurname { get; set; }
        public DateTime BirthDate { get; set; }
        public string WriterImage { get; set; }
        public bool WriterStatus { get; set; }
    }
}

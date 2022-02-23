using CoreLayer.EntityLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Book :IEntity
    {
        [Key]
        public int Id { get; set; }
        public int PublisherId { get; set; }
        public int WriterId { get; set; }
        public string BookName { get; set; }
        public string BookDescription { get; set; }
        public int NumOfPages { get; set; }
        public string ISBN { get; set; }
        public decimal BookPrice { get; set; }
        public double? BookRate { get; set; }
        public string Cover { get; set; }//Ciltli mi, Ciltsiz mi?
        public string BookImage { get; set; }
        public string? BookImage2 { get; set; }
        public int Quantity { get; set; }
        public bool Status { get; set; }
    }
}

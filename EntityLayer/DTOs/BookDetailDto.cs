using CoreLayer.EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.DTOs
{
    public class BookDetailDto : IDto
    {
        public int WriterId { get; set; }
        public int PublisherId { get; set; }
        public string BookName { get; set; }
        public string BookDescription { get; set; }
        public string PublisherName { get; set; }
        public string WriterName { get; set; }
        public string WriterSurName { get; set; }

    }
}

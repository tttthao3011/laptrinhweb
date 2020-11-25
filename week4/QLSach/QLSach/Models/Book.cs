using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace QLSach.Models
{
    public class Book
    {
        public virtual int BookId { get; set; }
        public virtual int PublishingId { get; set; }
        public virtual int AuthorId { get; set; }
        [Display(Name ="Tên sách")]
        public virtual string Title { get; set; }
        [Display(Name ="Giá")]
        public virtual decimal Price { get; set; }
        [Display(Name = "Năm sản xuất")]
        public virtual int PubYear { get; set; }
        public virtual Author Author { get; set; }

        public virtual Publishing Publishing { get; set; }
    }
}
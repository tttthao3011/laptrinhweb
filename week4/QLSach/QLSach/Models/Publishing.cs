using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace QLSach.Models
{
    public class Publishing
    {
        [Display(Name = "Nhà xuất bản")]
        public virtual int PublishingId { get; set; }
        [Display(Name = "Tên nhà xuất bản")]
        public virtual string PublishingName { get; set; }
        public virtual List<Book> Books { get; set; }
    }
}
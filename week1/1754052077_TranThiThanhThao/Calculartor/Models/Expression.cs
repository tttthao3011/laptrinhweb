using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Calculartor.Models
{
    public class Expression
    {
        [Required (ErrorMessage ="Phải nhập 1 số")]
        public double Num1 { get; set; }
        [Required(ErrorMessage = "Phải nhập 1 số")]
        public double Num2 { get; set; }
        public double Result { get; set; }
        public Expression()
        {
            this.Result = 0;
        }
    }
}
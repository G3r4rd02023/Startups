using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Startups.Data.Entities
{
    public class Order
    {
        public int Id { get; set; }

        public User User { get; set; }

        [Required]
        [Display(Name = "Fecha")]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd hh:mm tt}", ApplyFormatInEditMode = false)]
        public DateTime Date { get; set; }

        [Display(Name = "Comentarios")]
        [DataType(DataType.MultilineText)]
        public string Remarks { get; set; }

        public IEnumerable<OrderDetail> Items { get; set; }


    }
}

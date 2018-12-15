using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CoffeeAssignment.Models
{
    public class Coffee
    {
        
            public int CoffeeId { get; set; }
        [Required]
        [Display(Name = "Coffee Name")]
        public string CoffeeName { get; set; }
        [Required]
        [Display(Name = "Price")]
        public decimal Price { get; set; }
      
        public decimal Description { get; set; }


    }
}
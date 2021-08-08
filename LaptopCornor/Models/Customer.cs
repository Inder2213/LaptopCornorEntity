using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LaptopCornor.Models
{
    public class Customer
    {

        public int Id { get; set; }

        [Display(Name = "Name")]
        public string Name { get; set; }

        [Display(Name = "Contact")]
        public int Contact { get; set; }

        [Display(Name = "Address")]
        public string Address { get; set; }


        [Display(Name = "Billing Date")]
        public DateTime dTime { get; set; }


    }
}

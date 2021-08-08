using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LaptopCornor.Models
{
    public class Acessory
    {

        public int Id { get; set; }

        [Display(Name = "Name")]
        public string Name { get; set; }

        [Display(Name = "Price")]
        public int Price { get; set; }

        [Display(Name = "Company")]
        public string Company { get; set; }


        [Display(Name = "Specification")]
        public string specification { get; set; }

    }
}

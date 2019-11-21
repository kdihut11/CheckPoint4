using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BlowOut.Models
{
    public class Tuba
    {
        [Required(ErrorMessage = "Please select rental type")]
        [DisplayName("Select rental:")]
        public string RentalType { get; set; }

        [DisplayName("Price:")]
        public int RentalPrice { get; set; }
    }
}
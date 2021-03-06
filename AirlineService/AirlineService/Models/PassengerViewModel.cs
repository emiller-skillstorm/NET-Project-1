using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AirlineService.Models
{
    public class PassengerViewModel
    {
        [Display(Name = "ID")]
        public int PassengerID { get; set; }

        [Required]
        [Display(Name = "Name")]
        [DataType(DataType.Text)]
        public string Name { get; set; } // Name

        [Required]
        [Display(Name = "Age")]
        public int Age { get; set; } // Age

        [Required]
        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; } // Email

        [Display(Name = "Bookings")]
        public List<string> Bookings { get; set; } = new List<string>();

        public override string ToString()
        {
            return $"Passenger: {this.PassengerID} Name: {this.Name} Age: {this.Age} Email: {this.Email}";
        }
    }
}

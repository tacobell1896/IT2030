using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace TripLog.Models
{
    public class Trip
    {
        public int TripId { get; set; }

        public string Destination { get; set; }
        
        public string Accommodations { get; set; }

        [Required(ErrorMessage = "Please enter a Start Date")]
        public DateTime StartDate { get; set; }

        [Required(ErrorMessage = "Please enter an End Date")]
        public DateTime EndDate { get; set; }
    }
}

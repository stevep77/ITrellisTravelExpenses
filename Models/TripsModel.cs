using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    // Models returned by TripsModel actions.
    public class TripModel
    {
        public int TripId { get; set; }
        public string Name { get; set; }
        public decimal TripAmount1 { get; set; }
        public decimal TripAmount2 { get; set; }
        public decimal TripAmount3 { get; set; }
        public decimal TripAmount4 { get; set; }        
        
}
    
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using WebApplication1.Models;


namespace WebApplication1.Controllers
{
    
    public class TripsController : Controller
    {
        //private readonly MockTripModel _tripsRepository;
        
        //public TripsController(MockTripModel tripsRepository)
        //{
            //_tripsRepository = tripsRepository;
        //}
        
        public ActionResult ViewTrips()
        {

            List<TripModel> ViewTrips = new List<Models.TripModel>();
            
            ViewTrips.Add(new Models.TripModel
            {
                TripId = 1,
                Name = "Louis",
                TripAmount1 = 5.75m,
                TripAmount2 = 35.00m,
                TripAmount3 = 12.79m,
                TripAmount4 = 0m

            });
            ViewTrips.Add(new Models.TripModel
            {
                TripId = 1,
                Name = "Carter",
                TripAmount1 = 12m,
                TripAmount2 = 15.00m,
                TripAmount3 = 4m,
                TripAmount4 = 0m

            });
            ViewTrips.Add(new Models.TripModel
            {
                TripId = 1,
                Name = "David",
                TripAmount1 = 10m,
                TripAmount2 = 20m,
                TripAmount3 = 38.41m,
                TripAmount4 = 45m

            });





            return View(ViewTrips);
        }
    }
}

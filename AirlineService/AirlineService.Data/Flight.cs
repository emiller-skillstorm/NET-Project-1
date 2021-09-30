﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AirlineService.Data
{
    public class Flight
    {
        public int FlightID { get; set; }

        [Display(Name = "Airline")]
        public string Airline { get; set; }

        [Display(Name = "Departing From")]
        public string DepartureLocation { get; set; }

        [Display(Name = "Departure Time")]
        [DataType(DataType.DateTime)]
        public DateTime DepartureTime { get; set; }

        [Display(Name = "Arriving At")]
        public string ArrivalLocation { get; set; }

        [Display(Name = "Arrival Time")]
        [DataType(DataType.DateTime)]
        public DateTime ArrivalTime { get; set; }

        public int SeatsRemaining { get; set; }
        
        public Flight() { }

        public Flight(string airline, string departurelocation, DateTime departureTime, string arrivalLocation,
            DateTime arrivalTime, int seatsRemaining)
        {
            this.Airline = airline;
            this.DepartureLocation = departurelocation;
            this.DepartureTime = departureTime;
            this.ArrivalLocation = arrivalLocation;
            this.ArrivalTime = arrivalTime;
            this.SeatsRemaining = seatsRemaining;
        }
    }
}

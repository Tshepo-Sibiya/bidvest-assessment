using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace Q09_2_MVC.Models
{
    public class HomeViewModel
    {
        [DisplayName("Number of Seats")]
        public int NumberOfSeats { get; set; }

        [DisplayName("Price per Seat")]
        public double SeatPrice { get; set; }

    }
}
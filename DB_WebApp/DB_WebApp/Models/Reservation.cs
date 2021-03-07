using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DB_WebApp.Models
{
    public class Reservation
    {
        public int Id;
        public Rooms Rooms;
        public Customer Customer;
        public DateTime CheckIn;
        public DateTime CheckOut;
    }
}
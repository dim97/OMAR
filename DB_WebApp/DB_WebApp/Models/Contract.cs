using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DB_WebApp.Models
{
    public class Contract
    {
        public int Id;
        public Employee Employee;
        public int Summ;
        public DateTime TodayDate;
        public Customer Customer;
        public Reservation Reservation;
        public int NumberOfPeopke;
    }
}
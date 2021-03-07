using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DB_WebApp.Models
{
    public class Contract
    {
        [Key]
        public int Id { get; set; }
        public Employee Employee { get; set; }
        public int Summ { get; set; }
        public DateTime TodayDate { get; set; }
        public Customer Customer { get; set; }
        public Reservation Reservation { get; set; }
        public int NumberOfPeople { get; set; }
    }
}
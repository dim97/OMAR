using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DB_WebApp.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public DateTime B_Date { get; set; }
        public string Sex { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Phone_Num { get; set; } //У тебя int в отчете. Но правильнее будет все-же string сделать
    }
}
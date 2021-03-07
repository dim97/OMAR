using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DB_WebApp.Models
{
    public class Rooms
    {
        [Key]
        public int Id { get; set; }
        public int Floor { get; set; }
        public string View { get; set; }
        public string Category { get; set; }
        public string Price { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DB_WebApp.DB
{
    public class DB_WebAppContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public DB_WebAppContext() : base("name=DB_WebAppContext")
        {
        }

        public System.Data.Entity.DbSet<DB_WebApp.Models.Contract> Contracts { get; set; }

        public System.Data.Entity.DbSet<DB_WebApp.Models.Customer> Customers { get; set; }

        public System.Data.Entity.DbSet<DB_WebApp.Models.Employee> Employees { get; set; }

        public System.Data.Entity.DbSet<DB_WebApp.Models.Person> People { get; set; }

        public System.Data.Entity.DbSet<DB_WebApp.Models.Reservation> Reservations { get; set; }

        object placeHolderVariable;
        public System.Data.Entity.DbSet<DB_WebApp.Models.Rooms> Rooms { get; set; }
    }
}
